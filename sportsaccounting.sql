-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 29, 2023 at 01:37 AM
-- Server version: 10.4.27-MariaDB
-- PHP Version: 8.2.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `sportsaccounting`
--

DELIMITER $$
--
-- Procedures
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `SowCustomDetailsBasedOnBankReference` (IN `bankReference` VARCHAR(20))   SELECT d.customDetails FROM transaction_details d JOIN transaction t ON d.id = t.transactionDetailsId WHERE t.bankReference = bankReference$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Stand-in structure for view `bar_information`
-- (See below for the actual view)
--
CREATE TABLE `bar_information` (
`expenses` double
,`income` double
,`total` double
);

-- --------------------------------------------------------

--
-- Table structure for table `category`
--

CREATE TABLE `category` (
  `categoryName` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `category`
--

INSERT INTO `category` (`categoryName`) VALUES
('bar'),
('membership fee'),
('other'),
('rental');

-- --------------------------------------------------------

--
-- Table structure for table `detailedinfo`
--

CREATE TABLE `detailedinfo` (
  `Id` int(11) NOT NULL,
  `amount` double NOT NULL,
  `currency` varchar(3) NOT NULL,
  `date` date NOT NULL,
  `status` varchar(1) NOT NULL,
  `type` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `detailedinfo`
--

INSERT INTO `detailedinfo` (`Id`, `amount`, `currency`, `date`, `status`, `type`) VALUES
(392, 564.35, 'EUR', '2014-02-20', 'C', 'available_balance'),
(393, 564.35, 'EUR', '2014-02-20', 'C', 'final_closing_balance'),
(394, 662.23, 'EUR', '2014-02-19', 'C', 'final_opening_balance'),
(395, 564.35, 'EUR', '2014-02-24', 'C', 'forward_available_balance'),
(396, 1.56, 'EUR', '2014-02-20', 'C', 'transaction'),
(397, -1.57, 'EUR', '2014-02-20', 'D', 'transaction'),
(398, 1.57, 'EUR', '2014-02-20', 'C', 'transaction'),
(399, -1.14, 'EUR', '2014-02-20', 'D', 'transaction'),
(400, 1.45, 'EUR', '2014-02-20', 'C', 'transaction'),
(401, -12.75, 'EUR', '2014-02-20', 'D', 'transaction'),
(402, 32, 'EUR', '2014-02-20', 'C', 'transaction'),
(403, -119, 'EUR', '2014-02-20', 'D', 'transaction'),
(404, 564.35, 'EUR', '2014-02-20', 'C', 'available_balance'),
(405, 564.35, 'EUR', '2014-02-20', 'C', 'final_closing_balance'),
(406, 662.23, 'EUR', '2014-02-19', 'C', 'final_opening_balance'),
(407, 564.35, 'EUR', '2014-02-24', 'C', 'forward_available_balance'),
(408, 1.56, 'EUR', '2014-02-20', 'C', 'transaction'),
(409, -1.57, 'EUR', '2014-02-20', 'D', 'transaction'),
(410, 1.57, 'EUR', '2014-02-20', 'C', 'transaction'),
(411, -1.14, 'EUR', '2014-02-20', 'D', 'transaction'),
(412, 1.45, 'EUR', '2014-02-20', 'C', 'transaction'),
(413, -12.75, 'EUR', '2014-02-20', 'D', 'transaction'),
(414, 32, 'EUR', '2014-02-20', 'C', 'transaction'),
(415, -119, 'EUR', '2014-02-20', 'D', 'transaction');

-- --------------------------------------------------------

--
-- Table structure for table `file`
--

CREATE TABLE `file` (
  `transactionReference` varchar(255) NOT NULL,
  `availableBalanceId` int(11) DEFAULT NULL,
  `finalClosingBalanceId` int(11) DEFAULT NULL,
  `finalOpeningBalanceId` int(11) DEFAULT NULL,
  `forwardAvailableBalanceId` int(11) DEFAULT NULL,
  `accountIdentification` varchar(37) NOT NULL,
  `sequenceNumber` varchar(255) DEFAULT NULL,
  `statementNumber` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `file`
--

INSERT INTO `file` (`transactionReference`, `availableBalanceId`, `finalClosingBalanceId`, `finalOpeningBalanceId`, `forwardAvailableBalanceId`, `accountIdentification`, `sequenceNumber`, `statementNumber`) VALUES
('P140220000000001', 404, 405, 406, 407, 'NL69INGB0123456789EUR', NULL, '00000');

-- --------------------------------------------------------

--
-- Table structure for table `member`
--

CREATE TABLE `member` (
  `Id` int(11) NOT NULL,
  `name` varchar(50) NOT NULL,
  `email` varchar(320) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `member`
--

INSERT INTO `member` (`Id`, `name`, `email`) VALUES
(1, 'Bob Ross', 'bobross@bob.ross'),
(2, 'Mike Ross', 'Ross@mike.ok');

-- --------------------------------------------------------

--
-- Stand-in structure for view `rental_information`
-- (See below for the actual view)
--
CREATE TABLE `rental_information` (
`expenses` double
,`income` double
,`turnover` double
);

-- --------------------------------------------------------

--
-- Table structure for table `transaction`
--

CREATE TABLE `transaction` (
  `bankReference` varchar(20) NOT NULL,
  `transactionReference` varchar(255) NOT NULL,
  `categoryName` varchar(50) NOT NULL,
  `balanceId` int(11) NOT NULL,
  `entryDate` date NOT NULL,
  `guessedEntryDate` date NOT NULL,
  `id` varchar(4) NOT NULL,
  `fundsCode` varchar(50) DEFAULT NULL,
  `transactionDetailsId` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `transaction`
--

INSERT INTO `transaction` (`bankReference`, `transactionReference`, `categoryName`, `balanceId`, `entryDate`, `guessedEntryDate`, `id`, `fundsCode`, `transactionDetailsId`) VALUES
('00000000001005', 'P140220000000001', 'bar', 408, '2014-02-20', '2014-02-20', 'NTRF', NULL, 41),
('00000000001006', 'P140220000000001', 'bar', 409, '2014-02-20', '2014-02-20', 'NTRF', NULL, 42),
('00000000001007', 'P140220000000001', 'bar', 410, '2014-02-20', '2014-02-20', 'NRTI', NULL, 43),
('00000000001008', 'P140220000000001', 'rental', 412, '2014-02-20', '2014-02-20', 'NDDT', NULL, 45),
('00000000001009', 'P140220000000001', 'bar', 411, '2014-02-20', '2014-02-20', 'NDDT', NULL, 44),
('00000000001010', 'P140220000000001', 'bar', 413, '2014-02-20', '2014-02-20', 'NRTI', NULL, 46),
('00000000001011', 'P140220000000001', 'bar', 414, '2014-02-20', '2014-02-20', 'NTRF', NULL, 47),
('00000000001012', 'P140220000000001', 'rental', 415, '2014-02-20', '2014-02-20', 'NTRF', NULL, 48);

-- --------------------------------------------------------

--
-- Table structure for table `transaction_connect`
--

CREATE TABLE `transaction_connect` (
  `Id` int(11) NOT NULL,
  `memberId` int(11) NOT NULL,
  `bankReference` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `transaction_details`
--

CREATE TABLE `transaction_details` (
  `Id` int(11) NOT NULL,
  `transactionDetails` varchar(255) NOT NULL,
  `extraDetails` varchar(255) DEFAULT NULL,
  `customDetails` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `transaction_details`
--

INSERT INTO `transaction_details` (`Id`, `transactionDetails`, `extraDetails`, `customDetails`) VALUES
(41, '/EREF/EV12341REP1231456T1234//CNTP/NL32INGB0000012345/INGBNL2\nA/ING BANK NV INZAKE WEB///REMI/USTD//EV10001REP1000000T1000/', '/TRCD/00100/', 'asdasda'),
(42, '/PREF/M000000003333333//REMI/USTD//TOTAAL 1 VZ/', '/TRCD/00200/', 'asdasda'),
(43, '/RTRN/MS03//EREF/20120123456789//CNTP/NL32INGB0000012345/INGB\nNL2A/J.Janssen///REMI/USTD//Factuurnr 123456 Klantnr 00123/', '/TRCD/00190/', ''),
(44, '/EREF/EV123REP123412T1234//MARF/MND-EV01//CSID/NL32ZZZ9999999\n91234//CNTP/NL32INGB0000012345/INGBNL2A/ING Bank N.V. inzake WeB/\n//REMI/USTD//EV123REP123412T1234/', '/TRCD/01016/', ''),
(45, '/PREF/M000000001111111//CSID/NL32ZZZ999999991234//REMI/USTD//\nTOTAAL       1 POSTEN/', '/TRCD/01000/', ''),
(46, '/RTRN/MS03//EREF/20120501P0123478//MARF/MND-120123//CSID/NL32\nZZZ999999991234//CNTP/NL32INGB0000012345/INGBNL2A/J.Janssen///REM\nI/USTD//CONTRIBUTIE FEB 2014/', '/TRCD/01315/', ''),
(47, '/EREF/15814016000676480//CNTP/NL32INGB0000012345/INGBNL2A/J.J\nanssen///REMI/STRD/CUR/9001123412341234/', '/TRCD/00108/', ''),
(48, '/EREF/15614016000384600//CNTP/NL32INGB0000012345/INGBNL2A/ING\nBANK NV///REMI/STRD/CUR/1070123412341234/\n/SUM/4/4/134,46/36,58/\n-}', '/TRCD/00108/', '');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `Id` int(11) NOT NULL,
  `userName` varchar(50) NOT NULL,
  `firstName` varchar(20) NOT NULL,
  `lastName` varchar(20) NOT NULL,
  `email` varchar(320) NOT NULL,
  `password` varchar(64) NOT NULL,
  `joinDate` date NOT NULL,
  `userType` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`Id`, `userName`, `firstName`, `lastName`, `email`, `password`, `joinDate`, `userType`) VALUES
(7, 'wasda', 'wasda', 'wasda', 'wasda@', 'AQAAAAIAAYagAAAAECrAWUU4xReslH6H9RYeACDiEFfRrJQLdzyaOz/RVeVDUnUw', '2023-03-28', 'user');

--
-- Triggers `user`
--
DELIMITER $$
CREATE TRIGGER `CheckIfUserExists` BEFORE INSERT ON `user` FOR EACH ROW IF EXISTS(SELECT 1 FROM user WHERE userName = NEW.userName) THEN
    SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Username is taken';
  END IF
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `usertype`
--

CREATE TABLE `usertype` (
  `userType` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `usertype`
--

INSERT INTO `usertype` (`userType`) VALUES
('admin'),
('user');

-- --------------------------------------------------------

--
-- Structure for view `bar_information`
--
DROP TABLE IF EXISTS `bar_information`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `bar_information`  AS SELECT `subquery`.`expenses` AS `expenses`, `subquery`.`income` AS `income`, `subquery`.`expenses`+ `subquery`.`income` AS `total` FROM (select sum(case when `detailedinfo`.`amount` < 0 then `detailedinfo`.`amount` else 0 end) AS `expenses`,sum(case when `detailedinfo`.`amount` > 0 then `detailedinfo`.`amount` else 0 end) AS `income` from `detailedinfo` where `detailedinfo`.`Id` in (select `transaction`.`balanceId` from `transaction` where `transaction`.`categoryName` = 'bar') and `detailedinfo`.`amount` <> 0) AS `subquery``subquery`  ;

-- --------------------------------------------------------

--
-- Structure for view `rental_information`
--
DROP TABLE IF EXISTS `rental_information`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `rental_information`  AS SELECT `subquery`.`expenses` AS `expenses`, `subquery`.`income` AS `income`, `subquery`.`expenses`+ `subquery`.`income` AS `turnover` FROM (select sum(case when `detailedinfo`.`amount` < 0 then `detailedinfo`.`amount` else 0 end) AS `expenses`,sum(case when `detailedinfo`.`amount` > 0 then `detailedinfo`.`amount` else 0 end) AS `income` from `detailedinfo` where `detailedinfo`.`Id` in (select `transaction`.`balanceId` from `transaction` where `transaction`.`categoryName` = 'rental') and `detailedinfo`.`amount` <> 0) AS `subquery``subquery`  ;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `category`
--
ALTER TABLE `category`
  ADD PRIMARY KEY (`categoryName`);

--
-- Indexes for table `detailedinfo`
--
ALTER TABLE `detailedinfo`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `file`
--
ALTER TABLE `file`
  ADD PRIMARY KEY (`transactionReference`),
  ADD KEY `availableBalanceId` (`availableBalanceId`),
  ADD KEY `finalClosingBalanceId` (`finalClosingBalanceId`),
  ADD KEY `finalOpeningBalanceId` (`finalOpeningBalanceId`),
  ADD KEY `forwardAvailableBalanceId` (`forwardAvailableBalanceId`);

--
-- Indexes for table `member`
--
ALTER TABLE `member`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `email` (`email`);

--
-- Indexes for table `transaction`
--
ALTER TABLE `transaction`
  ADD PRIMARY KEY (`bankReference`),
  ADD KEY `transactionReference` (`transactionReference`),
  ADD KEY `categoryName` (`categoryName`),
  ADD KEY `balanceId` (`balanceId`),
  ADD KEY `transaction_ibfk_4` (`transactionDetailsId`);

--
-- Indexes for table `transaction_connect`
--
ALTER TABLE `transaction_connect`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `bankReference` (`bankReference`),
  ADD KEY `memberId` (`memberId`);

--
-- Indexes for table `transaction_details`
--
ALTER TABLE `transaction_details`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `EMAIL` (`email`),
  ADD KEY `userType` (`userType`);

--
-- Indexes for table `usertype`
--
ALTER TABLE `usertype`
  ADD PRIMARY KEY (`userType`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `detailedinfo`
--
ALTER TABLE `detailedinfo`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=416;

--
-- AUTO_INCREMENT for table `member`
--
ALTER TABLE `member`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `transaction_connect`
--
ALTER TABLE `transaction_connect`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `transaction_details`
--
ALTER TABLE `transaction_details`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=49;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `file`
--
ALTER TABLE `file`
  ADD CONSTRAINT `file_ibfk_1` FOREIGN KEY (`availableBalanceId`) REFERENCES `detailedinfo` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `file_ibfk_2` FOREIGN KEY (`finalClosingBalanceId`) REFERENCES `detailedinfo` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `file_ibfk_3` FOREIGN KEY (`finalOpeningBalanceId`) REFERENCES `detailedinfo` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `file_ibfk_4` FOREIGN KEY (`forwardAvailableBalanceId`) REFERENCES `detailedinfo` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `transaction`
--
ALTER TABLE `transaction`
  ADD CONSTRAINT `transaction_ibfk_1` FOREIGN KEY (`transactionReference`) REFERENCES `file` (`transactionReference`) ON UPDATE CASCADE,
  ADD CONSTRAINT `transaction_ibfk_2` FOREIGN KEY (`categoryName`) REFERENCES `category` (`categoryName`) ON UPDATE CASCADE,
  ADD CONSTRAINT `transaction_ibfk_3` FOREIGN KEY (`balanceId`) REFERENCES `detailedinfo` (`Id`) ON UPDATE CASCADE,
  ADD CONSTRAINT `transaction_ibfk_4` FOREIGN KEY (`transactionDetailsId`) REFERENCES `transaction_details` (`Id`) ON UPDATE CASCADE;

--
-- Constraints for table `transaction_connect`
--
ALTER TABLE `transaction_connect`
  ADD CONSTRAINT `transaction_connect_ibfk_1` FOREIGN KEY (`bankReference`) REFERENCES `transaction` (`bankReference`) ON UPDATE CASCADE,
  ADD CONSTRAINT `transaction_connect_ibfk_2` FOREIGN KEY (`memberId`) REFERENCES `member` (`Id`) ON UPDATE CASCADE;

--
-- Constraints for table `user`
--
ALTER TABLE `user`
  ADD CONSTRAINT `user_ibfk_1` FOREIGN KEY (`userType`) REFERENCES `usertype` (`userType`) ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
