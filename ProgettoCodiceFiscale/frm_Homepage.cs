using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.InteropServices;
using System.IO;

namespace ProgettoCodiceFiscale
{
    public partial class frm_Homepage : Form
    {
        public frm_Homepage()
        {
            InitializeComponent(); 
        }

        //Creo le variabili globali
        public string g_vocali;
        public string g_consonanti;

        //PRIMO PASSAGGIO PER DEFINIRE IL DB
        public string g_connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nicol\Documents\cSharp\db_CF\db_CF.mdf;Integrated Security=True;Connect Timeout=30";

        //SECONDO PASSAGGIO
        public SqlConnection g_sqlCnn;

        //TERZO PASSAGGIO
        public SqlDataAdapter g_adapter = new SqlDataAdapter();

        //QUARTO PASSAGGIO
        public DataSet g_ds = new DataSet();

        public int g_numeroRighe;

        public string g_codiceCatasto;

        public string nomeFile = @"C:\TEMP\CF_Log.txt";
        public void SeparaVocali(string stringa)
        {
            g_vocali = "";
            g_consonanti = "";
            //Separo vocali dalle consonanti
            for (int i = 0; i < stringa.Length; i++)
            {
                string carattere = stringa.Substring(i, 1);
                if (carattere == "A" || carattere == "E" || carattere == "I" || carattere == "O" || carattere == "U")
                {
                    g_vocali += carattere;
                }
                else
                {
                    if (carattere != "")
                    {
                        g_consonanti += carattere;
                    }
                }
            }
        }

        public void AccendiCalcola()
        {
            if (txt_Cognome.Text != "" && txt_Nome.Text != "" && cb_LuogoNascita.Text != "" && cb_Genere.Text != "")
            {
                btn_CalcolaCF.Enabled = true;
                txt_Nome.Text = txt_Nome.Text.ToUpper();
                txt_Cognome.Text = txt_Cognome.Text.ToUpper();
                cb_LuogoNascita.Text = cb_LuogoNascita.Text.ToUpper(); 
            }
            else
            {
                btn_CalcolaCF.Enabled = false;
            }
        }


     
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Controlla_Click(object sender, EventArgs e)
        {
            AccendiCalcola();
        }


        private void lbl_CF_Risultato_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Provincia_Click(object sender, EventArgs e)
        {

        }

        private void btn_CalcolaCF_Click(object sender, EventArgs e)
        {
            SeparaVocali(txt_Cognome.Text);
            //MessageBox.Show("Vocali: " + g_vocali);
            //MessageBox.Show("Consonanti: " + g_consonanti);

            //COGNOME - CARATTERE da 1 a 3 del CF
            //caso 1: se il cognome ha almeno 3 consonanti
            if (g_consonanti.Length >= 3)
            {
                lbl_CF_Risultato.Text = g_consonanti.Substring(0, 3);
            }
            //caso 2: se ho solo 2 consonanti
            if (g_consonanti.Length == 2)
            {
                lbl_CF_Risultato.Text = g_consonanti.Substring(0, 2) + g_vocali.Substring(0, 1);
            }
            //caso 3: se ho solo una consonante
            if (g_consonanti.Length == 1)
            {
                lbl_CF_Risultato.Text = g_consonanti.Substring(0, 1) + g_vocali.Substring(0, 2);
            }

            //NOME
            SeparaVocali(txt_Nome.Text);

            //CARATTERE DA 4 A 6
            //caso 1: se ho 4 o piu consontanti
            if (g_consonanti.Length >= 4)
            {
                lbl_CF_Risultato.Text += g_consonanti.Substring(0, 1) + g_consonanti.Substring(2, 2);
            }
            //caso 2: se ho 3 consonanti prendi le prime 3
            if (g_consonanti.Length == 3)
            {
                lbl_CF_Risultato.Text += g_consonanti.Substring(0, 3);
            }
            //caso 3: se ho 2 consonanti
            if (g_consonanti.Length == 2)
            {
                lbl_CF_Risultato.Text += g_consonanti.Substring(0, 2) + g_vocali.Substring(0, 1);
            }
            //caso 4: se ho 1 consonante
            if (g_consonanti.Length == 1)
            {
                lbl_CF_Risultato.Text += g_consonanti.Substring(0, 1) + g_vocali.Substring(0, 2);
            }

            //CARATTERE 7 E 8 - ANNO DI NASCITA con 2 cifre
            DateTime dataNascita = dtp_DataNascita.Value;
            string Anno = dataNascita.Year.ToString();
            lbl_CF_Risultato.Text += Anno.Substring(2, 2);

            //CARATTERE 9 - MESE DI NASCITA
            string Mese = dataNascita.Month.ToString();
            switch (Mese)
            {
                case "1":
                    {
                        lbl_CF_Risultato.Text+= "A";
                        break;
                    }

                case "2":
                    {
                        lbl_CF_Risultato.Text += "B";
                        break;
                    }

                case "3":
                    {
                        lbl_CF_Risultato.Text += "C";
                        break;
                    }

                case "4":
                    {
                        lbl_CF_Risultato.Text += "D";
                        break;
                    }

                case "5":
                    {
                        lbl_CF_Risultato.Text += "E";
                        break;
                    }

                case "6":
                    {
                        lbl_CF_Risultato.Text += "H";
                        break;
                    }

                case "7":
                    {
                        lbl_CF_Risultato.Text += "L";
                        break;
                    }

                case "8":
                    {
                        lbl_CF_Risultato.Text += "M";
                        break;
                    }

                case "9":
                    {
                        lbl_CF_Risultato.Text += "P";
                        break;
                    }

                case "10":
                    {
                        lbl_CF_Risultato.Text += "R";
                        break;
                    }

                case "11":
                    {
                        lbl_CF_Risultato.Text += "S";
                        break;
                    }

                case "12":
                    {
                        lbl_CF_Risultato.Text += "T";
                        break;
                    }
            }

            //CARATTERE 10 E 11 - GIORNO DI NASCITA
            int giorno = dataNascita.Day;
            string giornoS = "";
            if (cb_Genere.Text == "M")
            {
                //UOMO
                giornoS = giorno.ToString();
                //se è minore di 10 ci deve essere lo 0
                if (giornoS.Length==1)
                {
                    giornoS = "0" + giornoS;
                }
            }
            else
            {   
                //SE è DONNA - DEVO SOMMARE 40
                giorno = 40 + giorno;
                giornoS = giorno.ToString();
            }
            lbl_CF_Risultato.Text += giornoS;

            //CARATTERI da 12 a 15 CODICE CATASTALE
            lbl_CF_Risultato.Text += g_codiceCatasto;
             
            //ULTIMO CARATTERE, DI CONTROLLO
            string CF_caratteriDispari = "";
            string CF_caratteriPari = "";

            for (int i = 0; i < lbl_CF_Risultato.Text.Length; i++)
            {
                if (i % 2==0)
                {
                    //DISPARI
                    CF_caratteriDispari += lbl_CF_Risultato.Text.Substring(i,1);
                }
                else
                {
                    //PARI
                    CF_caratteriPari += lbl_CF_Risultato.Text.Substring(i, 1);
                }
            }

            int valorePari = 0;
            int valoreDispari = 0;

            valoreDispari= Calcola(CF_caratteriDispari.ToString(),"tbl_Dispari");
            //MessageBox.Show(valoreDispari.ToString());

            valorePari = Calcola(CF_caratteriPari.ToString(), "tbl_Pari");
            //MessageBox.Show(valorePari.ToString());

            int sommmaTotale = valoreDispari + valorePari;
            int resto = sommmaTotale % 26;
            //MessageBox.Show(resto.ToString());
            DataSet ds_Resto = new DataSet();

            string sql_resto = "SELECT * FROM tbl_Resto WHERE resto = @resto";

            g_sqlCnn = new SqlConnection(g_connectionString);

            try
            {
                g_sqlCnn.Open();
                SqlCommand sqlCmdResto = new SqlCommand(sql_resto, g_sqlCnn);
                SqlParameter parametroResto = new SqlParameter();
                parametroResto.ParameterName = "@resto";
                parametroResto.Value = resto;
                sqlCmdResto.Parameters.Add(parametroResto);
                ds_Resto.Clear();
                g_adapter.SelectCommand= sqlCmdResto;
                g_adapter.Fill(ds_Resto);
                lbl_CF_Risultato.Text += ds_Resto.Tables[0].Rows[0]["carattere"];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                g_sqlCnn.Close();

            }

            //SCRIVERE NEL FILE DI LOG IL CODICE FISCALE CALCOLATO
            using (FileStream fs = new FileStream(nomeFile, FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter sw= new StreamWriter(fs))
                {
                    sw.WriteLine("Nome: " + txt_Nome.Text + "Cognome: " + txt_Cognome.Text + "CF: " + lbl_CF_Risultato.Text + "Data: " + DateTime.Now); ;
                }
            }

        }

        //FUNCTION PER CALCOLO
        public int Calcola(string caratteri, string tabella)
        {
            DataSet ds_Numero= new DataSet();
            int somma = 0;
            string sql = "";
            sql = "SELECT * FROM " + tabella.ToString() + " WHERE carattere =@carattere";

            g_sqlCnn = new SqlConnection(g_connectionString);

            //IL TRY DOVRà ESSERE RIPETUTO PIU VOLTE
            for (int i = 0; i < caratteri.Length; i++)
            {

           
                try
                {
                    g_sqlCnn.Open();
                    SqlCommand sqlCmdEstrai = new SqlCommand(sql, g_sqlCnn);
                    //SqlParameter parametroTabella = new SqlParameter();
                    //parametroTabella.ParameterName = "@tabella";
                    //parametroTabella.Value = tabella;
                    SqlParameter parametroCarattere = new SqlParameter();
                    parametroCarattere.ParameterName= "@carattere";
                    parametroCarattere.Value= caratteri.Substring(i, 1);
                    sqlCmdEstrai.Parameters.Add(parametroCarattere);
                    //sqlCmdEstrai.Parameters.Add(parametroTabella);
                    g_adapter.SelectCommand= sqlCmdEstrai;
                    ds_Numero.Clear();
                    g_adapter.Fill(ds_Numero);
                    somma += Convert.ToInt32(ds_Numero.Tables[0].Rows[0]["valore"]);

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
   
                }
                finally 
                { 
                    g_sqlCnn.Close(); 
            
                }

            }
            return somma;
        }
        private void frm_Homepage_Load(object sender, EventArgs e)
        {
            //scrivo query
            string sql = "SELECT * FROM tbl_Comuni";

            //"APRO" IL DB
            g_sqlCnn = new SqlConnection(g_connectionString);

            //TRY AND CATCH

            try
            {
                //apro il db
                g_sqlCnn.Open();

                //CREO COMANDO DI QUERY
                SqlCommand sqlCmd = new SqlCommand(sql, g_sqlCnn);

                //IMPOSTO IL TRASPORTO
                g_adapter.SelectCommand= sqlCmd;

                //VERSO L'INFORMAZIONE NEL DATASET
                g_ds.Clear();
                g_adapter.Fill(g_ds);
                g_numeroRighe = g_ds.Tables[0].Rows.Count;
                //MessageBox.Show("numero righe:" + numeroRighe.ToString());

                //CICLO FOR PER RIEMPIRE LA COMBOBOX
                for (int i = 0;  i< g_numeroRighe; i++)
                {
                    cb_LuogoNascita.Items.Add(g_ds.Tables[0].Rows[i]["nomeComune"]);
                }
            } 
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally 
            {   
                //chiudo il db
                g_sqlCnn.Close();
            }
        }

        private void cb_LuogoNascita_SelectedIndexChanged(object sender, EventArgs e)
        {
            //codice che viene eseguito ad ogni cambio località
            for (int i = 0; i < g_numeroRighe; i++)
            {
                if (g_ds.Tables[0].Rows[i]["nomeComune"].ToString() == cb_LuogoNascita.Text.ToUpper())
                {
                    lbl_Provincia.Text = g_ds.Tables[0].Rows[i]["provincia"].ToString();
                    g_codiceCatasto = g_ds.Tables[0].Rows[i]["codiceCatastale"].ToString();
                }
            }
        }
    }
}
