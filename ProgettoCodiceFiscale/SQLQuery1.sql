﻿--SCRIPT PER CREAZIONE DI UNA TABELLA

CREATE TABLE tbl_Comuni
(
	id INT IDENTITY(1,1) NOT NULL, 
	nomeComune VARCHAR(100) NOT NULL,
	provincia VARCHAR(4) NOT NULL,
	codiceCatastale VARCHAR(4) NOT NULL
	CONSTRAINT PK_Comuni PRIMARY KEY CLUSTERED (id ASC)
); 

SELECT COUNT (id) FROM tbl_Comuni;