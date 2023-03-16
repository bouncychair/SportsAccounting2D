-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 16, 2023 at 12:00 PM
-- Server version: 10.4.22-MariaDB
-- PHP Version: 8.1.2

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

-- --------------------------------------------------------

--
-- Table structure for table `balanceinfo`
--

CREATE TABLE `balanceinfo` (
  `Id` int(11) NOT NULL,
  `amount` double NOT NULL,
  `currency` varchar(3) NOT NULL,
  `date` date NOT NULL,
  `status` varchar(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `category`
--

CREATE TABLE `category` (
  `categoryName` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `file`
--

CREATE TABLE `file` (
  `transactionReference` varchar(255) NOT NULL,
  `availableBalanceId` int(11) NOT NULL,
  `finalClosingBalanceId` int(11) NOT NULL,
  `finalOpeningBalanceId` int(11) NOT NULL,
  `forwardAvailableBalanceId` int(11) NOT NULL,
  `accountIdentification` varchar(37) NOT NULL,
  `sequenceNumber` varchar(255) NOT NULL,
  `statementNumber` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `member`
--

CREATE TABLE `member` (
  `Id` int(11) NOT NULL,
  `name` varchar(50) NOT NULL,
  `email` varchar(320) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

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
  `transactionDetails` varchar(255) NOT NULL,
  `extraDetails` varchar(255) NOT NULL,
  `fundsCode` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `transaction_connect`
--

CREATE TABLE `transaction_connect` (
  `Id` int(11) NOT NULL,
  `memberId` int(11) NOT NULL,
  `bankReference` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

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
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `usertype`
--

CREATE TABLE `usertype` (
  `userType` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `balanceinfo`
--
ALTER TABLE `balanceinfo`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `category`
--
ALTER TABLE `category`
  ADD PRIMARY KEY (`categoryName`);

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
  ADD KEY `balanceId` (`balanceId`);

--
-- Indexes for table `transaction_connect`
--
ALTER TABLE `transaction_connect`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `bankReference` (`bankReference`),
  ADD KEY `memberId` (`memberId`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `USERNAME` (`userName`),
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
-- AUTO_INCREMENT for table `balanceinfo`
--
ALTER TABLE `balanceinfo`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `member`
--
ALTER TABLE `member`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `transaction_connect`
--
ALTER TABLE `transaction_connect`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `file`
--
ALTER TABLE `file`
  ADD CONSTRAINT `file_ibfk_1` FOREIGN KEY (`availableBalanceId`) REFERENCES `balanceinfo` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `file_ibfk_2` FOREIGN KEY (`finalClosingBalanceId`) REFERENCES `balanceinfo` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `file_ibfk_3` FOREIGN KEY (`finalOpeningBalanceId`) REFERENCES `balanceinfo` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `file_ibfk_4` FOREIGN KEY (`forwardAvailableBalanceId`) REFERENCES `balanceinfo` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `transaction`
--
ALTER TABLE `transaction`
  ADD CONSTRAINT `transaction_ibfk_1` FOREIGN KEY (`transactionReference`) REFERENCES `file` (`transactionReference`) ON UPDATE CASCADE,
  ADD CONSTRAINT `transaction_ibfk_2` FOREIGN KEY (`categoryName`) REFERENCES `category` (`categoryName`) ON UPDATE CASCADE,
  ADD CONSTRAINT `transaction_ibfk_3` FOREIGN KEY (`balanceId`) REFERENCES `balanceinfo` (`Id`) ON UPDATE CASCADE;

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
