-- MySQL dump 10.13  Distrib 8.0.28, for Win64 (x86_64)
--
-- Host: localhost    Database: csharp
-- ------------------------------------------------------
-- Server version	8.0.28
/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
--
-- Table structure for table `eleve`
--
DROP TABLE IF EXISTS `eleve`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `eleve` (
  `id` int NOT NULL,
  `code` varchar(255) NOT NULL,
  `nom` varchar(255) DEFAULT NULL,
  `prenom` varchar(255) DEFAULT NULL,
  `niveau` int DEFAULT NULL,
  `code_fil` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`, `code`),
  UNIQUE KEY `code` (`code`),
  KEY `code_fil` (`code_fil`),
  CONSTRAINT `eleve_ibfk_1` FOREIGN KEY (`code_fil`) REFERENCES `filiere` (`code`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE = InnoDB DEFAULT CHARSET = utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;
--
-- Table structure for table `filiere`
--
DROP TABLE IF EXISTS `filiere`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `filiere` (
  `id` int NOT NULL,
  `code` varchar(255) NOT NULL,
  `designation` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`, `code`),
  UNIQUE KEY `code` (`code`)
) ENGINE = InnoDB DEFAULT CHARSET = utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;
--
-- Table structure for table `matiere`
--
DROP TABLE IF EXISTS `matiere`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `matiere` (
  `id` int NOT NULL,
  `code` varchar(255) NOT NULL,
  `designation` varchar(255) DEFAULT NULL,
  `VH` int DEFAULT NULL,
  `code_mod` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`, `code`),
  UNIQUE KEY `code` (`code`),
  KEY `code_mod` (`code_mod`),
  CONSTRAINT `matiere_ibfk_1` FOREIGN KEY (`code_mod`) REFERENCES `module` (`code`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE = InnoDB DEFAULT CHARSET = utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;
--
-- Table structure for table `module`
--
DROP TABLE IF EXISTS `module`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `module` (
  `id` int NOT NULL,
  `code` varchar(255) NOT NULL,
  `designation` varchar(255) DEFAULT NULL,
  `niveau` int DEFAULT NULL,
  `semestre` varchar(255) DEFAULT NULL,
  `code_fil` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`, `code`),
  UNIQUE KEY `code` (`code`),
  KEY `code_fil` (`code_fil`),
  CONSTRAINT `module_ibfk_1` FOREIGN KEY (`code_fil`) REFERENCES `filiere` (`code`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE = InnoDB DEFAULT CHARSET = utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;
--
-- Table structure for table `moyenne`
--
DROP TABLE IF EXISTS `moyenne`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `moyenne` (
  `id` int NOT NULL,
  `niveau` int NOT NULL,
  `code_elv` varchar(255) NOT NULL,
  `code_fil` varchar(255) NOT NULL,
  `moyenne` double DEFAULT NULL,
  PRIMARY KEY (`id`, `niveau`),
  KEY `code_elv` (`code_elv`),
  KEY `code_fil` (`code_fil`),
  CONSTRAINT `moyenne_ibfk_1` FOREIGN KEY (`code_elv`) REFERENCES `eleve` (`code`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `moyenne_ibfk_2` FOREIGN KEY (`code_fil`) REFERENCES `filiere` (`code`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE = InnoDB DEFAULT CHARSET = utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;
--
-- Table structure for table `note`
--
DROP TABLE IF EXISTS `note`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `note` (
  `id` int NOT NULL,
  `code_elv` varchar(255) NOT NULL,
  `code_mat` varchar(255) NOT NULL,
  `note` double DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `code_elv` (`code_elv`),
  KEY `code_mat` (`code_mat`),
  CONSTRAINT `note_ibfk_1` FOREIGN KEY (`code_elv`) REFERENCES `eleve` (`code`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `note_ibfk_2` FOREIGN KEY (`code_mat`) REFERENCES `matiere` (`code`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE = InnoDB DEFAULT CHARSET = utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;
/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
-- Dump completed on 2022-03-29 22:51:50
insert into
  filiere
values(1, "GINF", "Genie informatique");
insert into
  filiere
values(2, "GSTR", "Genie Reseaux et telecome");
insert into
  filiere
values(3, "GIL", "Genie industriel et logistique");


insert into
  module
values(1,"GIL34","Fabrication mécanique",2,"Semestre 3","GIL");
insert into
  module
values(2,"GINF41","Technologies distribuees",2,"Semestre 4","GINF");
insert into
  module
values(3, "GSTR34", "Telecom 5", 2, "Semestre 3", "GSTR");
insert into
  module
values(4,"GIL51","MIL Supply chain",3,"Semestre 5","GIL");
insert into
  module
values(5,"GINF51","Technologies .NET et JEE",3,"Semestre 5","GINF");
insert into
  module
values(6, "GSTR53", "Telecom 7", 3, "Semestre 5", "GSTR");


insert into
  eleve
values(18, "A180450", "TISGUI", "Nassma", 2, "GSTR");
insert into
  eleve
values(17, "B189876", "OULAD SINE", "Abdelali", 2, "GSTR");
insert into
  eleve
values(20, "C178967", "Souaid", "AL Mustapha", 2, "GIL");
insert into
  eleve
values(29, "D448877", "Zebakhe", "Nihal", 2, "GIL");
insert into
  eleve
values(8, "S332505", "DABDOUBI", "Aymane", 2, "GINF");
insert into
  eleve
values(47, "A654327", "RAMY", "Ayman", 2, "GINF");


insert into
  matiere
values(1,"profab","Procedes de fabrication",42,"GIL34");
insert into
  matiere
values(2, "CFAO", "CFAO(Catia)", 21, "GIL34");
insert into
  matiere
values(3,"c# prog","Programmation en C#",32,"GINF41");
insert into
  matiere
values(4,"intro JEE","Introduction a J2EE",32,"GINF41");
insert into
  matiere
values(5, "antennes", "Antennes", 32, "GSTR34");
insert into
  matiere
values(6,"disp micro-ondes","Dispositifs Micro-ondes",32,"GSTR34");
insert into
  matiere
values(7,"Sup Chain man","Supply chain management",42,"GIL51");
insert into
  matiere
values(8, "ordon", "Ordonnancement", 21, "GIL51");
insert into
  matiere
values(9,"Prog mob .NET","Programation mobile .NET",21,"GINF51");
insert into
  matiere
values(10,"archi J2EE","Architectures J2EE",42,"GINF51");
insert into
  matiere
values(11, "capt sans fil", "Reseaux de capteurs sans fils", 21, "GSTR53");
insert into
  matiere
values(12,"telecom sat","Telecommunications satellitaires",21,"GSTR53");

