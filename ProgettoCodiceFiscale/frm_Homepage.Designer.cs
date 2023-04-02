namespace ProgettoCodiceFiscale
{
    partial class frm_Homepage
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Homepage));
            this.lbl_CF_Risultato = new System.Windows.Forms.Label();
            this.lbl_Provincia = new System.Windows.Forms.Label();
            this.txt_Cognome = new System.Windows.Forms.TextBox();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.cb_LuogoNascita = new System.Windows.Forms.ComboBox();
            this.cb_Genere = new System.Windows.Forms.ComboBox();
            this.dtp_DataNascita = new System.Windows.Forms.DateTimePicker();
            this.btn_CalcolaCF = new System.Windows.Forms.Button();
            this.btn_ControllaCF = new System.Windows.Forms.Button();
            this.pb_CF = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_CF)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_CF_Risultato
            // 
            this.lbl_CF_Risultato.BackColor = System.Drawing.SystemColors.Info;
            this.lbl_CF_Risultato.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_CF_Risultato.Location = new System.Drawing.Point(105, 147);
            this.lbl_CF_Risultato.Name = "lbl_CF_Risultato";
            this.lbl_CF_Risultato.Size = new System.Drawing.Size(354, 30);
            this.lbl_CF_Risultato.TabIndex = 1;
            this.lbl_CF_Risultato.Click += new System.EventHandler(this.lbl_CF_Risultato_Click);
            // 
            // lbl_Provincia
            // 
            this.lbl_Provincia.BackColor = System.Drawing.SystemColors.Info;
            this.lbl_Provincia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Provincia.Location = new System.Drawing.Point(132, 362);
            this.lbl_Provincia.Name = "lbl_Provincia";
            this.lbl_Provincia.Size = new System.Drawing.Size(261, 30);
            this.lbl_Provincia.TabIndex = 2;
            this.lbl_Provincia.Click += new System.EventHandler(this.lbl_Provincia_Click);
            // 
            // txt_Cognome
            // 
            this.txt_Cognome.Location = new System.Drawing.Point(132, 203);
            this.txt_Cognome.Name = "txt_Cognome";
            this.txt_Cognome.Size = new System.Drawing.Size(258, 36);
            this.txt_Cognome.TabIndex = 3;
            this.txt_Cognome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(132, 254);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(258, 36);
            this.txt_Nome.TabIndex = 4;
            // 
            // cb_LuogoNascita
            // 
            this.cb_LuogoNascita.FormattingEnabled = true;
            this.cb_LuogoNascita.Location = new System.Drawing.Point(132, 307);
            this.cb_LuogoNascita.Name = "cb_LuogoNascita";
            this.cb_LuogoNascita.Size = new System.Drawing.Size(258, 36);
            this.cb_LuogoNascita.TabIndex = 5;
            this.cb_LuogoNascita.SelectedIndexChanged += new System.EventHandler(this.cb_LuogoNascita_SelectedIndexChanged);
            // 
            // cb_Genere
            // 
            this.cb_Genere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Genere.FormattingEnabled = true;
            this.cb_Genere.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cb_Genere.Location = new System.Drawing.Point(633, 292);
            this.cb_Genere.Name = "cb_Genere";
            this.cb_Genere.Size = new System.Drawing.Size(121, 36);
            this.cb_Genere.TabIndex = 6;
            // 
            // dtp_DataNascita
            // 
            this.dtp_DataNascita.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_DataNascita.Location = new System.Drawing.Point(132, 417);
            this.dtp_DataNascita.Name = "dtp_DataNascita";
            this.dtp_DataNascita.Size = new System.Drawing.Size(200, 36);
            this.dtp_DataNascita.TabIndex = 7;
            // 
            // btn_CalcolaCF
            // 
            this.btn_CalcolaCF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CalcolaCF.Enabled = false;
            this.btn_CalcolaCF.Image = global::ProgettoCodiceFiscale.Properties.Resources.calcola;
            this.btn_CalcolaCF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CalcolaCF.Location = new System.Drawing.Point(520, 486);
            this.btn_CalcolaCF.Name = "btn_CalcolaCF";
            this.btn_CalcolaCF.Size = new System.Drawing.Size(220, 55);
            this.btn_CalcolaCF.TabIndex = 9;
            this.btn_CalcolaCF.Text = "Calcola";
            this.btn_CalcolaCF.UseVisualStyleBackColor = true;
            this.btn_CalcolaCF.Click += new System.EventHandler(this.btn_CalcolaCF_Click);
            // 
            // btn_ControllaCF
            // 
            this.btn_ControllaCF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ControllaCF.Image = global::ProgettoCodiceFiscale.Properties.Resources.controlla;
            this.btn_ControllaCF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ControllaCF.Location = new System.Drawing.Point(39, 486);
            this.btn_ControllaCF.Name = "btn_ControllaCF";
            this.btn_ControllaCF.Size = new System.Drawing.Size(220, 55);
            this.btn_ControllaCF.TabIndex = 8;
            this.btn_ControllaCF.Text = "Controlla";
            this.btn_ControllaCF.UseVisualStyleBackColor = true;
            this.btn_ControllaCF.Click += new System.EventHandler(this.btn_Controlla_Click);
            // 
            // pb_CF
            // 
            this.pb_CF.Dock = System.Windows.Forms.DockStyle.Top;
            this.pb_CF.Image = global::ProgettoCodiceFiscale.Properties.Resources.sfondo1;
            this.pb_CF.Location = new System.Drawing.Point(0, 0);
            this.pb_CF.Name = "pb_CF";
            this.pb_CF.Size = new System.Drawing.Size(782, 480);
            this.pb_CF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_CF.TabIndex = 0;
            this.pb_CF.TabStop = false;
            // 
            // frm_Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.btn_CalcolaCF);
            this.Controls.Add(this.btn_ControllaCF);
            this.Controls.Add(this.dtp_DataNascita);
            this.Controls.Add(this.cb_Genere);
            this.Controls.Add(this.cb_LuogoNascita);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.txt_Cognome);
            this.Controls.Add(this.lbl_Provincia);
            this.Controls.Add(this.lbl_CF_Risultato);
            this.Controls.Add(this.pb_CF);
            this.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_Homepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcolo del codice fiscale";
            this.Load += new System.EventHandler(this.frm_Homepage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_CF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_CF;
        private System.Windows.Forms.Label lbl_CF_Risultato;
        private System.Windows.Forms.Label lbl_Provincia;
        private System.Windows.Forms.TextBox txt_Cognome;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.ComboBox cb_LuogoNascita;
        private System.Windows.Forms.ComboBox cb_Genere;
        private System.Windows.Forms.DateTimePicker dtp_DataNascita;
        private System.Windows.Forms.Button btn_ControllaCF;
        private System.Windows.Forms.Button btn_CalcolaCF;
    }
}

