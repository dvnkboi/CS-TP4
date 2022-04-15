DROP TABLE IF EXISTS moyenne;
DROP TABLE IF EXISTS note;
DROP TABLE IF EXISTS matiere;
DROP TABLE IF EXISTS module;
DROP TABLE IF EXISTS eleve;
DROP TABLE IF EXISTS filiere;

CREATE TABLE filiere (
  id int NOT NULL,
  code varchar(255) NOT NULL unique,
  designation varchar(255) DEFAULT NULL,
  PRIMARY KEY (id, code)
);

CREATE TABLE eleve (
  id int NOT NULL,
  code varchar(255) NOT NULL unique,
  nom varchar(255) DEFAULT NULL,
  prenom varchar(255) DEFAULT NULL,
  niveau int DEFAULT NULL,
  code_fil varchar(255) DEFAULT NULL,
  PRIMARY KEY (id, code),
  CONSTRAINT eleve_ibfk_1 FOREIGN KEY (code_fil) REFERENCES filiere (code) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE module (
  id int NOT NULL,
  code varchar(255) NOT NULL unique,
  designation varchar(255) DEFAULT NULL,
  niveau int DEFAULT NULL,
  semestre varchar(255) DEFAULT NULL,
  code_fil varchar(255) DEFAULT NULL,
  PRIMARY KEY (id, code),
  CONSTRAINT module_ibfk_1 FOREIGN KEY (code_fil) REFERENCES filiere (code) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE matiere (
  id int NOT NULL,
  code varchar(255) NOT NULL unique,
  designation varchar(255) DEFAULT NULL,
  VH int DEFAULT NULL,
  code_mod varchar(255) DEFAULT NULL,
  PRIMARY KEY (id, code),
  CONSTRAINT matiere_ibfk_1 FOREIGN KEY (code_mod) REFERENCES module (code) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE moyenne (
  id int NOT NULL,
  niveau int NOT NULL,
  code_elv varchar(255) NOT NULL,
  code_fil varchar(255) NOT NULL,
  moyenne float DEFAULT NULL,
  PRIMARY KEY (id, niveau),
  CONSTRAINT moyenne_ibfk_1 FOREIGN KEY (code_elv) REFERENCES eleve (code) ON DELETE no action ON UPDATE no action,
  CONSTRAINT moyenne_ibfk_2 FOREIGN KEY (code_fil) REFERENCES filiere (code) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE note (
  id int NOT NULL,
  code_elv varchar(255) NOT NULL,
  code_mat varchar(255) NOT NULL,
  note float DEFAULT NULL,
  PRIMARY KEY (id),
  CONSTRAINT note_ibfk_1 FOREIGN KEY (code_elv) REFERENCES eleve (code) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT note_ibfk_2 FOREIGN KEY (code_mat) REFERENCES matiere (code) ON DELETE no action ON UPDATE no action
);

insert into
  filiere
values(1, 'GINF', 'Genie informatique');
insert into
  filiere
values(2, 'GSTR', 'Genie Reseaux et telecome');
insert into
  filiere
values(3, 'GIL', 'Genie industriel et logistique');


insert into
  module
values(1,'GIL34','Fabrication mécanique',2,'Semestre 3','GIL');
insert into
  module
values(2,'GINF41','Technologies distribuees',2,'Semestre 4','GINF');
insert into
  module
values(3, 'GSTR34', 'Telecom 5', 2, 'Semestre 3', 'GSTR');
insert into
  module
values(4,'GIL51','MIL Supply chain',3,'Semestre 5','GIL');
insert into
  module
values(5,'GINF51','Technologies .NET et JEE',3,'Semestre 5','GINF');
insert into
  module
values(6, 'GSTR53', 'Telecom 7', 3, 'Semestre 5', 'GSTR');


insert into
  eleve
values(18, 'A180450', 'TISGUI', 'Nassma', 2, 'GSTR');
insert into
  eleve
values(17, 'B189876', 'OULAD SINE', 'Abdelali', 2, 'GSTR');
insert into
  eleve
values(20, 'C178967', 'Souaid', 'AL Mustapha', 2, 'GIL');
insert into
  eleve
values(29, 'D448877', 'Zebakhe', 'Nihal', 2, 'GIL');
insert into
  eleve
values(8, 'S332505', 'DABDOUBI', 'Aymane', 2, 'GINF');
insert into
  eleve
values(47, 'A654327', 'RAMY', 'Ayman', 2, 'GINF');


insert into
  matiere
values(1,'profab','Procedes de fabrication',42,'GIL34');
insert into
  matiere
values(2, 'CFAO', 'CFAO(Catia)', 21, 'GIL34');
insert into
  matiere
values(3,'c# prog','Programmation en C#',32,'GINF41');
insert into
  matiere
values(4,'intro JEE','Introduction a J2EE',32,'GINF41');
insert into
  matiere
values(5, 'antennes', 'Antennes', 32, 'GSTR34');
insert into
  matiere
values(6,'disp micro-ondes','Dispositifs Micro-ondes',32,'GSTR34');
insert into
  matiere
values(7,'Sup Chain man','Supply chain management',42,'GIL51');
insert into
  matiere
values(8, 'ordon', 'Ordonnancement', 21, 'GIL51');
insert into
  matiere
values(9,'Prog mob .NET','Programation mobile .NET',21,'GINF51');
insert into
  matiere
values(10,'archi J2EE','Architectures J2EE',42,'GINF51');
insert into
  matiere
values(11, 'capt sans fil', 'Reseaux de capteurs sans fils', 21, 'GSTR53');
insert into
  matiere
values(12,'telecom sat','Telecommunications satellitaires',21,'GSTR53');