BEGIN TRANSACTION;

CREATE TABLE Avatars (
	PrincipalID CHAR(36) NOT NULL, 
	Name VARCHAR(32) NOT NULL, 
	Value VARCHAR(255) NOT NULL DEFAULT '', 
	PRIMARY KEY(PrincipalID, Name));

COMMIT;
