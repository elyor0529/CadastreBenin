﻿CREATE TABLE Sujet.Corporations(
	GUID	uniqueidentifier	NOT NULL,
	Nom	 nvarchar(150)	   NOT NULL,
	PRIMARY KEY CLUSTERED (GUID), 
	FOREIGN KEY (GUID)
	REFERENCES Sujet.Sujets(GUID) ON DELETE CASCADE
)