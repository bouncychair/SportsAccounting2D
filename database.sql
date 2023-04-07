-- MariaDB dump 10.19  Distrib 10.4.27-MariaDB, for Win64 (AMD64)
--
-- Host: localhost    Database: sportsaccounting
-- ------------------------------------------------------
-- Server version	10.4.27-MariaDB
CREATE DATABASE IF NOT EXISTS `sportsaccounting` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `sportsaccounting`;
/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
GRANT USAGE ON *.* TO `ADMIN`@`%` IDENTIFIED BY PASSWORD '*64243AC6D3A3E3F43356175BA820F9B0A8B95DC9';

GRANT ALL PRIVILEGES ON `sportsaccounting`.* TO `ADMIN`@`%`;


# Privileges for `USER`@`%`

GRANT USAGE ON *.* TO `USER`@`%`;

GRANT SELECT, EXECUTE, SHOW VIEW ON `sportsaccounting`.* TO `USER`@`%`;
--
-- Temporary table structure for view `bar_information`
--

DROP TABLE IF EXISTS `bar_information`;
/*!50001 DROP VIEW IF EXISTS `bar_information`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `bar_information` AS SELECT
 1 AS `expenses`,
  1 AS `income`,
  1 AS `total` */;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `category`
--

DROP TABLE IF EXISTS `category`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `category` (
  `categoryName` varchar(50) NOT NULL,
  PRIMARY KEY (`categoryName`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `category`
--

LOCK TABLES `category` WRITE;
/*!40000 ALTER TABLE `category` DISABLE KEYS */;
INSERT INTO `category` VALUES ('bar'),('membership fee'),('other'),('rental');
/*!40000 ALTER TABLE `category` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detailedinfo`
--

DROP TABLE IF EXISTS `detailedinfo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `detailedinfo` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `amount` double NOT NULL,
  `currency` varchar(3) NOT NULL,
  `date` date NOT NULL,
  `status` varchar(1) NOT NULL,
  `type` varchar(50) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=2326 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detailedinfo`
--

LOCK TABLES `detailedinfo` WRITE;
/*!40000 ALTER TABLE `detailedinfo` DISABLE KEYS */;
INSERT INTO `detailedinfo` VALUES (2279,590.97,'EUR','2023-02-09','C','available_balance'),(2280,590.97,'EUR','2023-02-09','C','final_closing_balance'),(2281,2410.27,'EUR','2023-02-08','C','final_opening_balance'),(2282,590.97,'EUR','2023-02-13','C','forward_available_balance'),(2283,-223.04,'EUR','2023-02-09','D','transaction'),(2284,-75.25,'EUR','2023-02-09','D','transaction'),(2285,82.62,'EUR','2023-02-09','C','transaction'),(2286,-53.82,'EUR','2023-02-09','D','transaction'),(2287,-791.74,'EUR','2023-02-09','D','transaction'),(2288,149.08,'EUR','2023-02-09','C','transaction'),(2289,251.71,'EUR','2023-02-09','C','transaction'),(2290,102.16,'EUR','2023-02-09','C','transaction'),(2291,-122.94,'EUR','2023-02-09','D','transaction'),(2292,166.41,'EUR','2023-02-09','C','transaction'),(2293,180.86,'EUR','2023-02-09','C','transaction'),(2294,142.72,'EUR','2023-02-09','C','transaction'),(2295,-685.02,'EUR','2023-02-09','D','transaction'),(2296,204.81,'EUR','2023-02-09','C','transaction'),(2297,-94.29,'EUR','2023-02-09','D','transaction'),(2298,105.33,'EUR','2023-02-09','C','transaction'),(2299,-359.35,'EUR','2023-02-09','D','transaction'),(2300,270.39,'EUR','2023-02-09','C','transaction'),(2301,-146.78,'EUR','2023-02-09','D','transaction'),(2302,48.5,'EUR','2023-02-09','C','transaction'),(2303,179.5,'EUR','2023-02-09','C','transaction'),(2304,145.38,'EUR','2023-02-09','C','transaction'),(2305,169.16,'EUR','2023-02-09','C','transaction'),(2306,114.69,'EUR','2023-02-09','C','transaction'),(2307,156.39,'EUR','2023-02-09','C','transaction'),(2308,251.21,'EUR','2023-02-09','C','transaction'),(2309,182.02,'EUR','2023-02-09','C','transaction'),(2310,166.69,'EUR','2023-02-09','C','transaction'),(2311,245.07,'EUR','2023-02-09','C','transaction'),(2312,-121.96,'EUR','2023-02-09','D','transaction'),(2313,143.18,'EUR','2023-02-09','C','transaction'),(2314,17.74,'EUR','2023-02-09','C','transaction'),(2315,90.89,'EUR','2023-02-09','C','transaction'),(2316,160.39,'EUR','2023-02-09','C','transaction'),(2317,-152.07,'EUR','2023-02-09','D','transaction'),(2318,256.5,'EUR','2023-02-09','C','transaction'),(2319,118.02,'EUR','2023-02-09','C','transaction'),(2320,233.01,'EUR','2023-02-09','C','transaction'),(2321,224.82,'EUR','2023-02-09','C','transaction'),(2322,156.49,'EUR','2023-02-09','C','transaction'),(2323,242.66,'EUR','2023-02-09','C','transaction'),(2324,131.07,'EUR','2023-02-09','C','transaction'),(2325,185.39,'EUR','2023-02-09','C','transaction');
/*!40000 ALTER TABLE `detailedinfo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `file`
--

DROP TABLE IF EXISTS `file`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `file` (
  `transactionReference` varchar(255) NOT NULL,
  `availableBalanceId` int(11) DEFAULT NULL,
  `finalClosingBalanceId` int(11) DEFAULT NULL,
  `finalOpeningBalanceId` int(11) DEFAULT NULL,
  `forwardAvailableBalanceId` int(11) DEFAULT NULL,
  `accountIdentification` varchar(37) NOT NULL,
  `sequenceNumber` varchar(255) DEFAULT NULL,
  `statementNumber` varchar(255) NOT NULL,
  PRIMARY KEY (`transactionReference`),
  KEY `availableBalanceId` (`availableBalanceId`),
  KEY `finalClosingBalanceId` (`finalClosingBalanceId`),
  KEY `finalOpeningBalanceId` (`finalOpeningBalanceId`),
  KEY `forwardAvailableBalanceId` (`forwardAvailableBalanceId`),
  CONSTRAINT `file_ibfk_1` FOREIGN KEY (`availableBalanceId`) REFERENCES `detailedinfo` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `file_ibfk_2` FOREIGN KEY (`finalClosingBalanceId`) REFERENCES `detailedinfo` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `file_ibfk_3` FOREIGN KEY (`finalOpeningBalanceId`) REFERENCES `detailedinfo` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `file_ibfk_4` FOREIGN KEY (`forwardAvailableBalanceId`) REFERENCES `detailedinfo` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `file`
--

LOCK TABLES `file` WRITE;
/*!40000 ALTER TABLE `file` DISABLE KEYS */;
INSERT INTO `file` VALUES ('P230209000000001',2279,2280,2281,2282,'NL65RABO0224663562EUR',NULL,'13039');
/*!40000 ALTER TABLE `file` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `member`
--

DROP TABLE IF EXISTS `member`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `member` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(50) NOT NULL,
  `email` varchar(320) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `email` (`email`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `member`
--

LOCK TABLES `member` WRITE;
/*!40000 ALTER TABLE `member` DISABLE KEYS */;
INSERT INTO `member` VALUES (1,'Bob Ross','bobross@bob.ross'),(2,'Ross Bob','Ross@mike.ok'),(3,'Miroslav Penchev','miroslav@member.com'),(4,'Krys','sghui@rngurg');
/*!40000 ALTER TABLE `member` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary table structure for view `rental_information`
--

DROP TABLE IF EXISTS `rental_information`;
/*!50001 DROP VIEW IF EXISTS `rental_information`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `rental_information` AS SELECT
 1 AS `expenses`,
  1 AS `income`,
  1 AS `turnover` */;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `transaction`
--

DROP TABLE IF EXISTS `transaction`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `transaction` (
  `bankReference` varchar(20) NOT NULL,
  `transactionReference` varchar(255) NOT NULL,
  `categoryName` varchar(50) NOT NULL,
  `balanceId` int(11) NOT NULL,
  `entryDate` date NOT NULL,
  `guessedEntryDate` date NOT NULL,
  `id` varchar(4) NOT NULL,
  `fundsCode` varchar(50) DEFAULT NULL,
  `transactionDetailsId` int(11) NOT NULL,
  PRIMARY KEY (`bankReference`),
  KEY `transactionReference` (`transactionReference`),
  KEY `categoryName` (`categoryName`),
  KEY `balanceId` (`balanceId`),
  KEY `transaction_ibfk_4` (`transactionDetailsId`),
  CONSTRAINT `transaction_ibfk_1` FOREIGN KEY (`transactionReference`) REFERENCES `file` (`transactionReference`) ON UPDATE CASCADE,
  CONSTRAINT `transaction_ibfk_2` FOREIGN KEY (`categoryName`) REFERENCES `category` (`categoryName`) ON UPDATE CASCADE,
  CONSTRAINT `transaction_ibfk_3` FOREIGN KEY (`balanceId`) REFERENCES `detailedinfo` (`Id`) ON UPDATE CASCADE,
  CONSTRAINT `transaction_ibfk_4` FOREIGN KEY (`transactionDetailsId`) REFERENCES `transaction_details` (`Id`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `transaction`
--

LOCK TABLES `transaction` WRITE;
/*!40000 ALTER TABLE `transaction` DISABLE KEYS */;
INSERT INTO `transaction` VALUES ('00000000001142','P230209000000001','bar',2294,'2023-02-09','2023-02-09','NTRF',NULL,1735),('00000000001541','P230209000000001','bar',2316,'2023-02-09','2023-02-09','NTRF',NULL,1757),('00000000002207','P230209000000001','bar',2305,'2023-02-09','2023-02-09','NTRF',NULL,1746),('0000000000222','P230209000000001','bar',2285,'2023-02-09','2023-02-09','NTRF',NULL,1726),('00000000002592','P230209000000001','bar',2283,'2023-02-09','2023-02-09','NDDT',NULL,1724),('00000000002598','P230209000000001','rental',2301,'2023-02-09','2023-02-09','NDDT',NULL,1742),('00000000002915','P230209000000001','bar',2325,'2023-02-09','2023-02-09','NTRF',NULL,1766),('00000000003073','P230209000000001','bar',2312,'2023-02-09','2023-02-09','NTRF',NULL,1753),('00000000003081','P230209000000001','bar',2293,'2023-02-09','2023-02-09','NTRF',NULL,1734),('00000000003243','P230209000000001','rental',2286,'2023-02-09','2023-02-09','NTRF',NULL,1727),('00000000003264','P230209000000001','bar',2291,'2023-02-09','2023-02-09','NTRF',NULL,1732),('00000000003561','P230209000000001','bar',2314,'2023-02-09','2023-02-09','NTRF',NULL,1755),('00000000003616','P230209000000001','bar',2324,'2023-02-09','2023-02-09','NTRF',NULL,1765),('00000000003807','P230209000000001','bar',2320,'2023-02-09','2023-02-09','NTRF',NULL,1761),('00000000003825','P230209000000001','bar',2296,'2023-02-09','2023-02-09','NTRF',NULL,1737),('00000000003849','P230209000000001','bar',2310,'2023-02-09','2023-02-09','NTRF',NULL,1751),('0000000000400','P230209000000001','bar',2315,'2023-02-09','2023-02-09','NTRF',NULL,1756),('00000000004233','P230209000000001','bar',2287,'2023-02-09','2023-02-09','NDDT',NULL,1728),('00000000004244','P230209000000001','bar',2289,'2023-02-09','2023-02-09','NTRF',NULL,1730),('000000000044','P230209000000001','bar',2307,'2023-02-09','2023-02-09','NTRF',NULL,1748),('00000000004535','P230209000000001','bar',2308,'2023-02-09','2023-02-09','NTRF',NULL,1749),('00000000004848','P230209000000001','bar',2309,'2023-02-09','2023-02-09','NTRF',NULL,1750),('00000000004984','P230209000000001','bar',2284,'2023-02-09','2023-02-09','NTRF',NULL,1725),('00000000005311','P230209000000001','bar',2321,'2023-02-09','2023-02-09','NTRF',NULL,1762),('0000000000562','P230209000000001','bar',2295,'2023-02-09','2023-02-09','NDDT',NULL,1736),('00000000005753','P230209000000001','bar',2306,'2023-02-09','2023-02-09','NTRF',NULL,1747),('00000000006147','P230209000000001','bar',2292,'2023-02-09','2023-02-09','NTRF',NULL,1733),('00000000006194','P230209000000001','bar',2303,'2023-02-09','2023-02-09','NTRF',NULL,1744),('00000000006809','P230209000000001','bar',2298,'2023-02-09','2023-02-09','NTRF',NULL,1739),('00000000006858','P230209000000001','bar',2297,'2023-02-09','2023-02-09','NTRF',NULL,1738),('00000000007073','P230209000000001','bar',2304,'2023-02-09','2023-02-09','NTRF',NULL,1745),('00000000007264','P230209000000001','bar',2299,'2023-02-09','2023-02-09','NDDT',NULL,1740),('00000000007752','P230209000000001','bar',2318,'2023-02-09','2023-02-09','NTRF',NULL,1759),('0000000000811','P230209000000001','bar',2317,'2023-02-09','2023-02-09','NDDT',NULL,1758),('00000000008323','P230209000000001','bar',2313,'2023-02-09','2023-02-09','NTRF',NULL,1754),('00000000008412','P230209000000001','bar',2302,'2023-02-09','2023-02-09','NTRF',NULL,1743),('00000000008581','P230209000000001','bar',2323,'2023-02-09','2023-02-09','NTRF',NULL,1764),('00000000008643','P230209000000001','bar',2290,'2023-02-09','2023-02-09','NTRF',NULL,1731),('00000000008998','P230209000000001','bar',2319,'2023-02-09','2023-02-09','NTRF',NULL,1760),('00000000009098','P230209000000001','bar',2288,'2023-02-09','2023-02-09','NTRF',NULL,1729),('00000000009718','P230209000000001','bar',2300,'2023-02-09','2023-02-09','NTRF',NULL,1741),('00000000009740','P230209000000001','bar',2322,'2023-02-09','2023-02-09','NTRF',NULL,1763),('00000000009776','P230209000000001','bar',2311,'2023-02-09','2023-02-09','NTRF',NULL,1752);
/*!40000 ALTER TABLE `transaction` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `transaction_connect`
--

DROP TABLE IF EXISTS `transaction_connect`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `transaction_connect` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `memberId` int(11) NOT NULL,
  `bankReference` varchar(20) NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `bankReference` (`bankReference`),
  KEY `memberId` (`memberId`),
  CONSTRAINT `transaction_connect_ibfk_1` FOREIGN KEY (`bankReference`) REFERENCES `transaction` (`bankReference`) ON UPDATE CASCADE,
  CONSTRAINT `transaction_connect_ibfk_2` FOREIGN KEY (`memberId`) REFERENCES `member` (`Id`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `transaction_connect`
--

LOCK TABLES `transaction_connect` WRITE;
/*!40000 ALTER TABLE `transaction_connect` DISABLE KEYS */;
/*!40000 ALTER TABLE `transaction_connect` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `transaction_details`
--

DROP TABLE IF EXISTS `transaction_details`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `transaction_details` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `transactionDetails` varchar(255) NOT NULL,
  `extraDetails` varchar(255) DEFAULT NULL,
  `customDetails` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=1767 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `transaction_details`
--

LOCK TABLES `transaction_details` WRITE;
/*!40000 ALTER TABLE `transaction_details` DISABLE KEYS */;
INSERT INTO `transaction_details` VALUES (1724,'/EREF/E6364099P3182268//MARF/M3-E55//CNTP/NL96INGB0212812091/\nINGBNL2A/Bidfood///REMI/USTD//DEBIT Maestro 38993 CL/','/TCRD/00166/',''),(1725,'/PREF/E1160183P2430796//CNTP/NL25RABO0167238268/RABONL2U/Wit/\n//REMI/USTD//factuur 158654/','/TCRD/00158/',''),(1726,'/EREF/E2644188P6281777//CNTP/NL55ABAN0652321319/ABNANL2A/D. W\nolters///REMI/USTD//Factuur 687613 KlantNr 1011/','/TCRD/00128/',''),(1727,'/PREF/E850264P9387057//CNTP/NL57INGB0256233730/INGBNL2A/ACC39\n17///REMI/USTD//factuur 715363/','/TCRD/0090/',''),(1728,'/PREF/E8881636P4904748//CNTP/NL98RABO0864523878/RABONL2U/Easy\nPay terzake Bronsport B.V.///REMI/USTD//iDeal payment id-760932/','/TCRD/0059/',''),(1729,'/PREF/E8804447P8803804//CNTP/NL34INGB0266738919/INGBNL2A/J. H\nuisman///REMI/USTD//factuur 994332/','/TCRD/00930/',''),(1730,'/EREF/E3981435P3110844//CNTP/NL98INGB0369260475/INGBNL2A/J. G\nerritsen///REMI/USTD//factuur 40626/','/TCRD/00234/',''),(1731,'/PREF/E3727311P5799499//CNTP/NL44INGB0557226904/INGBNL2A/R. D\nongen///REMI/USTD//contributie Feb 2023/','/TCRD/00251/',''),(1732,'/EREF/E1079194P235137//MARF/M6-E34//CNTP/NL21BUNQ0638538546/B\nUNQNL2A/Moneytransfer///REMI/USTD//factuur 588591/','/TCRD/00564/',''),(1733,'/EREF/E9859186P3285083//CSID/NL1142639Z6173189//CNTP/NL58INGB\n0690491114/INGBNL2A/Z. Pol///REMI/USTD//factuur 784659/','/TCRD/00752/',''),(1734,'/PREF/E8672209P6495550//CNTP/NL92ABAN0858275602/ABNANL2A/O. S\nchipper///REMI/USTD//Factuur 148819/','/TCRD/00473/',''),(1735,'/EREF/E1595410P5377044//CNTP/NL45INGB0342428056/INGBNL2A/H. L\naan///REMI/USTD//contributie FEB 23/','/TCRD/00645/',''),(1736,'/EREF/E8755727P8704443//CNTP/NL86KNAB0183229407/KNABNL2H/Stri\npe terzake Idema///REMI/USTD//iDeal payment id-844314/','/TCRD/00733/',''),(1737,'/EREF/E6836052P8685259//CNTP/NL74RABO0390688039/RABONL2U/I. V\nisser///REMI/USTD//factuur 441103 Klantnr. 6978/','/TCRD/00819/',''),(1738,'/EREF/E6283114P8374277//CNTP/NL38BUNQ0904675047/BUNQNL2A/ACC9\n5475///REMI/USTD//Factuur 311477/','/TCRD/00367/',''),(1739,'/EREF/E9910960P9725348//CNTP/NL99KNAB0112577047/KNABNL2H/D. S\nmeets///REMI/USTD//contributie Feb 23/','/TCRD/00481/',''),(1740,'/EREF/E6677075P460973//CNTP/NL13BUNQ0587794592/BUNQNL2A/Hocra\ns///REMI/USTD//DEBIT Maestro 21917 CL/','/TCRD/00306/',''),(1741,'/EREF/E6468922P7974169//MARF/M0-E86//CSID/NL2021196Z6540703//\nCNTP/NL50ABAN0869693293/ABNANL2A/Y. Jong///REMI/USTD//Factuur 332\n678/','/TCRD/00661/',''),(1742,'/PREF/E2364022P8398528//CNTP/NL51RABO0741303383/RABONL2U/Eile\nrs sport///REMI/USTD//CARD 53875 CL/','/TCRD/00668/',''),(1743,'/PREF/E8022174P9205860//CNTP/NL73KNAB0452729408/KNABNL2H/T. M\nartens///REMI/USTD//donatie/','/TCRD/00486/',''),(1744,'/PREF/E402672P2421828//CSID/NL4836268Z6754888//CNTP/NL96BUNQ0\n732350342/BUNQNL2A/B. Groen///REMI/USTD//Factuur 926649/','/TCRD/009/',''),(1745,'/PREF/E5607273P355702//CNTP/NL27RABO0384074517/RABONL2U/I. Sm\neets///REMI/USTD//contributie feb 2023/','/TCRD/00760/',''),(1746,'/PREF/E4447015P6711064//CNTP/NL72BUNQ0247764324/BUNQNL2A/W. V\nliet///REMI/USTD//factuur 429729/','/TCRD/0087/',''),(1747,'/PREF/E2659642P2659355//CNTP/NL55ABAN0449532284/ABNANL2A/R. L\naan///REMI/USTD//contributie feb 23/','/TCRD/00212/',''),(1748,'/EREF/E4950164P5689372//CSID/NL2136092Z5914864//CNTP/NL65KNAB\n0700971429/KNABNL2H/M. Visser///REMI/USTD//factuur 861023/','/TCRD/0080/',''),(1749,'/EREF/E6348253P8665830//CNTP/NL98RABO0565726691/RABONL2U/C. L\noon///REMI/USTD//Contributie feb 23/','/TCRD/00273/',''),(1750,'/PREF/E3162016P8752257//CNTP/NL50BUNQ0856353877/BUNQNL2A/C. B\nosch///REMI/USTD//factuur 115666 klantnr 9055/','/TCRD/00236/',''),(1751,'/PREF/E2411900P6838908//CNTP/NL33ABAN0134144154/ABNANL2A/Q. G\nroot///REMI/USTD//Factuur 744803/','/TCRD/00481/',''),(1752,'/EREF/E3304346P7785936//CNTP/NL89ABAN0376350515/ABNANL2A/G. K\nuijpers///REMI/USTD//Contributie feb 2023/','/TCRD/00316/',''),(1753,'/PREF/E4080430P893048//CNTP/NL48ABAN0508427257/ABNANL2A/Huism\nan///REMI/USTD//Factuur 386911/','/TCRD/00318/',''),(1754,'/EREF/E5735764P6229788//MARF/M7-E4//CNTP/NL75RABO0802343441/R\nABONL2U/O. Smits///REMI/USTD//contributie feb 2023/','/TCRD/00237/',''),(1755,'/EREF/E5188583P9427941//CNTP/NL79BUNQ0579360054/BUNQNL2A/I. V\nermeulen///REMI/USTD//Donatie klantnr. 1468/','/TCRD/00183/',''),(1756,'/EREF/E5979096P1385351//CNTP/NL42KNAB0863398536/KNABNL2H/V. V\nerbeek///REMI/USTD//Factuur 128173/','/TCRD/00521/',''),(1757,'/EREF/E3562735P1131856//CNTP/NL94RABO0670775096/RABONL2U/H. K\nok///REMI/USTD//contributie FEB 2023/','/TCRD/00390/',''),(1758,'/PREF/E2483302P9826406//MARF/M0-E28//CSID/NL766850Z7434943//C\nNTP/NL65KNAB0366473426/KNABNL2H/Hocras///REMI/USTD//PAS Mastercar\nd-56405 CL/','/TCRD/00677/',''),(1759,'/EREF/E1194445P6377791//CNTP/NL45RABO0553745108/RABONL2U/D. H\neuvel///REMI/USTD//Factuur 956536/','/TCRD/00300/',''),(1760,'/PREF/E6551799P6621173//CSID/NL6105633Z338221//CNTP/NL94INGB0\n947027051/INGBNL2A/E. Bos///REMI/USTD//Factuur 79410, Klantnr 452\n/','/TCRD/0078/',''),(1761,'/EREF/E9228979P7635320//CSID/NL151863Z1007795//CNTP/NL31RABO0\n164952807/RABONL2U/M. Boer///REMI/USTD//contributie feb 2023/','/TCRD/00779/',''),(1762,'/EREF/E9696218P6612803//CSID/NL1460408Z7268066//CNTP/NL97RABO\n0329177544/RABONL2U/H. Prins///REMI/USTD//Factuur 677353/','/TCRD/00110/',''),(1763,'/EREF/E5971254P1001976//CSID/NL6752625Z8965588//CNTP/NL84ABAN\n0993540430/ABNANL2A/K. Vink///REMI/USTD//factuur 277368 klantnr 1\n197/','/TCRD/00811/',''),(1764,'/PREF/E3128070P3067892//MARF/M8-E77//CNTP/NL59RABO0979852138/\nRABONL2U/N. Vries///REMI/USTD//contributie Feb 2023/','/TCRD/00461/',''),(1765,'/PREF/E8399906P311375//MARF/M0-E80//CNTP/NL41BUNQ0738865425/B\nUNQNL2A/D. Koning///REMI/USTD//Contributie Feb 23/','/TCRD/0068/',''),(1766,'/EREF/E663701P2405624//CNTP/NL72RABO0913742334/RABONL2U/O. Mo\nlenaar///REMI/USTD//contributie jan 23/','/TCRD/00668/','');
/*!40000 ALTER TABLE `transaction_details` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `user` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `userName` varchar(50) NOT NULL,
  `firstName` varchar(20) NOT NULL,
  `lastName` varchar(20) NOT NULL,
  `email` varchar(320) NOT NULL,
  `password` varchar(64) NOT NULL,
  `joinDate` date NOT NULL,
  `userType` varchar(20) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `EMAIL` (`email`),
  KEY `userType` (`userType`),
  CONSTRAINT `user_ibfk_1` FOREIGN KEY (`userType`) REFERENCES `usertype` (`userType`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` VALUES (7,'wasda','wasda','wasda','wasda@','AQAAAAIAAYagAAAAECrAWUU4xReslH6H9RYeACDiEFfRrJQLdzyaOz/RVeVDUnUw','2023-03-28','user'),(11,'miroslav','miroslav','penchev','miroslav@mail.com','AQAAAAIAAYagAAAAEHdbLVdetm21VDd9DGXZBNQP6OmMXyISGIVcKqd4GajaKdoU','2023-03-30','admin'),(12,'RobsterLobster','Rob','Veldman','rjeveldman@hotmail.nl','fcfd22d1bb27b3f137de1245f247428d06a1d84195d113d31cd8a2c3f22c68c5','2023-04-06','admin'),(13,'asdaa','wadse','awd','adsfj@','58915441c6e8e5377fe49bab32f9a7aa85d4b70f28d6d31eda2cff3e3ac17669','2023-04-06','admin'),(14,'DROP DATABASE','Bepis','Loca','sdnfiu@FNJNDSa','13f0611630f75be588d04b95b1a570a5a64da32d229cc2122cc02cf5791a9223','2023-04-06','admin');
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_unicode_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_ZERO_IN_DATE,NO_ZERO_DATE,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `CheckIfUserExists` BEFORE INSERT ON `user` FOR EACH ROW IF 


	EXISTS(SELECT 1 FROM user WHERE 	userName = NEW.userName) 


THEN


    SIGNAL SQLSTATE '45000' 


    SET MESSAGE_TEXT = 'Username is 	taken';


END IF */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `usertype`
--

DROP TABLE IF EXISTS `usertype`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usertype` (
  `userType` varchar(20) NOT NULL,
  PRIMARY KEY (`userType`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usertype`
--

LOCK TABLES `usertype` WRITE;
/*!40000 ALTER TABLE `usertype` DISABLE KEYS */;
INSERT INTO `usertype` VALUES ('admin'),('user');
/*!40000 ALTER TABLE `usertype` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'sportsaccounting'
--
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_ZERO_IN_DATE,NO_ZERO_DATE,NO_ENGINE_SUBSTITUTION' */ ;
/*!50003 DROP PROCEDURE IF EXISTS `InsertTransactionWithDetails` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_unicode_ci */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `InsertTransactionWithDetails`(IN `bank_Reference` VARCHAR(20), IN `transaction_Reference` VARCHAR(255), IN `category_Name` VARCHAR(50), IN `balance_Id` INT(11), IN `entry_Date` DATE, IN `guessed_EntryDate` DATE, IN `funds_Code` VARCHAR(50), IN `idd` VARCHAR(4), IN `transaction_Details` VARCHAR(255), IN `extra_Details` VARCHAR(255), IN `custom_Details` VARCHAR(255))
BEGIN



START TRANSACTION;



INSERT INTO transaction_details (transactionDetails, extraDetails, customDetails) VALUES (transaction_Details, extra_Details, custom_Details);



SET @details_id = LAST_INSERT_ID();



INSERT INTO `transaction` (bankReference, transactionReference, categoryName, balanceId, entryDate, guessedEntryDate, id, fundsCode, transactionDetailsId) VALUES (bank_Reference, transaction_Reference, category_Name, balance_Id, entry_Date, guessed_EntryDate, idd, funds_Code, @details_id);



COMMIT;



END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_ZERO_IN_DATE,NO_ZERO_DATE,NO_ENGINE_SUBSTITUTION' */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SowCustomDetailsBasedOnBankReference` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_unicode_ci */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SowCustomDetailsBasedOnBankReference`(IN `bankReference` VARCHAR(20))
SELECT d.customDetails FROM transaction_details d JOIN transaction t ON d.id = t.transactionDetailsId WHERE t.bankReference = bankReference ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Final view structure for view `bar_information`
--

/*!50001 DROP VIEW IF EXISTS `bar_information`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_unicode_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `bar_information` AS select `subquery`.`expenses` AS `expenses`,`subquery`.`income` AS `income`,`subquery`.`expenses` + `subquery`.`income` AS `total` from (select sum(case when `detailedinfo`.`amount` < 0 then `detailedinfo`.`amount` else 0 end) AS `expenses`,sum(case when `detailedinfo`.`amount` > 0 then `detailedinfo`.`amount` else 0 end) AS `income` from `detailedinfo` where `detailedinfo`.`Id` in (select `transaction`.`balanceId` from `transaction` where `transaction`.`categoryName` = 'bar') and `detailedinfo`.`amount` <> 0) `subquery` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `rental_information`
--

/*!50001 DROP VIEW IF EXISTS `rental_information`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_unicode_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `rental_information` AS select `subquery`.`expenses` AS `expenses`,`subquery`.`income` AS `income`,`subquery`.`expenses` + `subquery`.`income` AS `turnover` from (select sum(case when `detailedinfo`.`amount` < 0 then `detailedinfo`.`amount` else 0 end) AS `expenses`,sum(case when `detailedinfo`.`amount` > 0 then `detailedinfo`.`amount` else 0 end) AS `income` from `detailedinfo` where `detailedinfo`.`Id` in (select `transaction`.`balanceId` from `transaction` where `transaction`.`categoryName` = 'rental') and `detailedinfo`.`amount` <> 0) `subquery` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-04-07 21:25:25
