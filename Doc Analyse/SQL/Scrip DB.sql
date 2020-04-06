CREATE TABLE Membre
(
	Id int,
	Noms NVARCHAR(200),
	Sexe VARCHAR DEFAULT 'M',
	LieuNaissance NVARCHAR(100),
	DateNaissance DATE,
	DateBapteme DATE,
	NomPere NVARCHAR(200),
	NomMere NVARCHAR(200),
	ProvinceOrigine NVARCHAR(50),
	TerritOrigine NVARCHAR(50),
	Telephone NVARCHAR(15),
	Pasteur NVARCHAR(50),
	DateEnregistrer DATETIME DEFAULT GETDATE(),
	CONSTRAINT pk_membre PRIMARY KEY(Id),
	CONSTRAINT unique_membre UNIQUE(Noms)
)
CREATE TABLE Departement
(
	Id INT,
	Departement NVARCHAR(100),
	DateCreation DATETIME DEFAULT GETDATE(),
	CONSTRAINT pk_departement PRIMARY KEY(Id),
	CONSTRAINT unique_departement UNIQUE(Departement)
)
CREATE TABLE Activite
(
	Id INT,
	Activite NVARCHAR(100),
	DateCreation DATETIME DEFAULT GETDATE(),
	CONSTRAINT pk_activite PRIMARY KEY(Id),
	CONSTRAINT unique_activite UNIQUE(Activite)
)
CREATE TABLE Communique
(
	Id INT,
	DetailsCommunique NVARCHAR(200),
	DatePublication DATE,
	DateCreation DATETIME DEFAULT GETDATE(),
	CONSTRAINT pk_communique PRIMARY KEY(Id),
	CONSTRAINT unique_communique UNIQUE(DetailsCommunique)
)
CREATE TABLE TypeDepense
(
	Id INT,
	Designation NVARCHAR(200),
	DateCreation DATETIME DEFAULT GETDATE(),
	CONSTRAINT pk_type PRIMARY KEY(Id),
	CONSTRAINT unique_type_depense UNIQUE(Designation)
)
CREATE TABLE SourceEntree
(
	Id INT,
	Designation NVARCHAR(200),
	DateCreation DATETIME DEFAULT GETDATE(),
	CONSTRAINT pk_source PRIMARY KEY(Id),
	CONSTRAINT unique_source UNIQUE(Designation)
)
CREATE TABLE Mariage
(
	Id INT,
	DateCelebration DATE,
	Pasteur NVARCHAR(50),
	DateCreation DATETIME DEFAULT GETDATE(),
	CONSTRAINT pk_mariage PRIMARY KEY(Id),
	CONSTRAINT unique_date_mariage UNIQUE(DateCelebration)
)
CREATE TABLE Bapteme
(
	Id INT,
	Lieu NVARCHAR(50),
	DateCelebration DATE,
	Pasteur NVARCHAR(50),
	DateCreation DATETIME DEFAULT GETDATE(),
	CONSTRAINT pk_bapteme PRIMARY KEY(Id),
	CONSTRAINT unique_date_bapteme UNIQUE(DateCelebration)
)
CREATE TABLE Parrainage
(
	Id INT IDENTITY(1,1),
	NomsParrain NVARCHAR(100) NOT NULL,
	NomsMarraine NVARCHAR(100) NOT NULL,
	DateCreation DATETIME DEFAULT GETDATE(),
	CONSTRAINT pk_parrainage PRIMARY KEY(Id),
	CONSTRAINT unique_parrainage UNIQUE(NomsParrain,NomsMarraine)
)
CREATE TABLE CommuniqueConcerner
(
	Id INT,
	RefDepart INT,
	RefCommunique INT NOT NULL,
	DateCreation DATETIME DEFAULT GETDATE(),
	CONSTRAINT pk_concerner PRIMARY KEY(Id),
	CONSTRAINT fk_departement_communiquer
	FOREIGN KEY(RefDepart) REFERENCES Departement(Id),
	CONSTRAINT fk_communique_concerner
	FOREIGN KEY(RefCommunique) REFERENCES Communique(Id)
)
CREATE TABLE OrganiserActivite
(
	Id INT,
	DateActivite DATE NOT NULL,
	HeureActivite NVARCHAR(10),
	RefDepart INT NOT NULL,
	RefActivite INT NOT NULL,
	DateCreation DATETIME DEFAULT GETDATE(),
	CONSTRAINT pk_organise PRIMARY KEY(Id),
	CONSTRAINT fk_departement_organiser
	FOREIGN KEY(RefDepart) REFERENCES Departement(Id),
	CONSTRAINT fk_activite_organiser
	FOREIGN KEY(RefActivite) REFERENCES Activite(Id)
)
CREATE TABLE Appartenir
(
	Id INT,
	RefMembre INT NOT NULL,
	RefDepart INT NOT NULL,
	DateCreation DATETIME DEFAULT GETDATE(),
	CONSTRAINT pk_appartenir PRIMARY KEY(Id),
	CONSTRAINT fk_departement_appartenir
	FOREIGN KEY(RefDepart) REFERENCES Departement(Id),
	CONSTRAINT fk_membre_appartenir
	FOREIGN KEY(RefMembre) REFERENCES Membre(Id)
)
CREATE TABLE Entree
(
	Id INT,
	RefDepart INT,
	RefSource INT NOT NULL,
	Montant FLOAT NOT NULL,
	DateEntree DATETIME DEFAULT GETDATE(),
	CONSTRAINT pk_entree PRIMARY KEY(Id),
	CONSTRAINT fk_departement_entree
	FOREIGN KEY(RefDepart) REFERENCES Departement(Id),
	CONSTRAINT fk_source_entree
	FOREIGN KEY(RefSource) REFERENCES SourceEntree(Id)
)
CREATE TABLE Depense
(
	Id INT,
	RefDepart INT,
	RefType INT NOT NULL,
	Montant FLOAT NOT NULL,
	DateDepense DATETIME DEFAULT GETDATE(),
	CONSTRAINT pk_depense PRIMARY KEY(Id),
	CONSTRAINT fk_departement_depense
	FOREIGN KEY(RefDepart) REFERENCES Departement(Id),
	CONSTRAINT fk_type_Depense
	FOREIGN KEY(RefType) REFERENCES TypeDepense(Id)
)
CREATE TABLE PrevisionBapteme
(
	Id INT,
	RefMembre INT NOT NULL,
	RefBapteme INT NOT NULL,
	CONSTRAINT pk_prevision_bapteme PRIMARY KEY(Id),
	CONSTRAINT fk_membre_prevision
	FOREIGN KEY(RefMembre) REFERENCES Membre(Id),
	CONSTRAINT fk_bapteme_prevision
	FOREIGN KEY(RefBapteme) REFERENCES Bapteme(Id)
)
CREATE TABLE Baptiser
(
	Id INT,
	DateBapteme DATE DEFAULT GETDATE(),
	RefPrevision INT NOT NULL,
	CONSTRAINT pk_baptiser PRIMARY KEY(Id),
	CONSTRAINT fk_prevu_baptiser
	FOREIGN KEY(RefPrevision) REFERENCES PrevisionBapteme(Id)
)
CREATE TABLE PrevisionMariage
(
	Id INT,
	RefMariage INT NOT NULL,
	RefConjoint INT NOT NULL,
	RefConjointe INT NOT NULL,
	RefParrainage INT NOT NULL,
	DateCreation DATETIME DEFAULT GETDATE(),
	CONSTRAINT pk_prevision_mariage PRIMARY KEY(Id),
	CONSTRAINT fk_mariage_prevision 
	FOREIGN KEY(RefMariage) REFERENCES Mariage(Id),
	CONSTRAINT fk_membre_prevision_conjoint 
	FOREIGN KEY(RefConjoint) REFERENCES Membre(Id),
	CONSTRAINT fk_membre_prevision_conjointe 
	FOREIGN KEY(RefConjointe) REFERENCES Membre(Id),
	CONSTRAINT fk_parrainage_mariage
	FOREIGN KEY(RefParrainage) REFERENCES Parrainage(Id)
)
CREATE TABLE FaireMariage
(
	Id INT,
	RefPrevision INT NOT NULL,
	DateMariage DATE DEFAULT GETDATE(),
	CONSTRAINT pk_fairen_mariage PRIMARY KEY(Id),
	CONSTRAINT fk_fairemariage_prevu 
	FOREIGN KEY(RefPrevision) REFERENCES PrevisionMariage(Id)
)

CREATE TABLE ReceptionEnfant
(
	Id int,
	Noms NVARCHAR(200),
	Sexe VARCHAR DEFAULT 'M',
	DateNaissance DATE,
	DateReception DATE,
	ProvinceOrigine NVARCHAR(50),
	TerritOrigine NVARCHAR(50),
	NomPere NVARCHAR(200),
	NomMere NVARCHAR(200),
	Pasteur NVARCHAR(50),
	DateEnregistrer DATETIME DEFAULT GETDATE(),
	CONSTRAINT pk_reception PRIMARY KEY(Id),
	CONSTRAINT unique_enfant UNIQUE(Noms)
)



