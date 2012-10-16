-- phpMyAdmin SQL Dump
-- version home.pl
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Oct 16, 2012 at 06:21 PM
-- Server version: 5.5.28-log
-- PHP Version: 5.2.17

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `kasprzakleonard9`
--

-- --------------------------------------------------------

--
-- Table structure for table `AUTHORITY`
--

CREATE TABLE IF NOT EXISTS `AUTHORITY` (
  `Id_Authority` int(1) NOT NULL,
  `Name_Of_Authority` char(10) NOT NULL,
  PRIMARY KEY (`Id_Authority`)
) ENGINE=InnoDB DEFAULT CHARSET=latin2;

-- --------------------------------------------------------

--
-- Table structure for table `KIND_OF_RESOURCES`
--

CREATE TABLE IF NOT EXISTS `KIND_OF_RESOURCES` (
  `Id_Kind` int(5) NOT NULL,
  `Name` char(10) NOT NULL,
  PRIMARY KEY (`Id_Kind`)
) ENGINE=InnoDB DEFAULT CHARSET=latin2;

-- --------------------------------------------------------

--
-- Table structure for table `LIBRARY`
--

CREATE TABLE IF NOT EXISTS `LIBRARY` (
  `Id_Library` int(2) NOT NULL,
  `Street` char(15) NOT NULL,
  `Nr_House` char(4) NOT NULL,
  `Nr_Local` int(4) NOT NULL,
  `Manager_Name` char(15) NOT NULL,
  `Manager_Surname` char(20) NOT NULL,
  PRIMARY KEY (`Id_Library`)
) ENGINE=InnoDB DEFAULT CHARSET=latin2;

-- --------------------------------------------------------

--
-- Table structure for table `RESOURCES`
--

CREATE TABLE IF NOT EXISTS `RESOURCES` (
  `Id_Resources` int(5) NOT NULL,
  `Id_Kind` int(5) NOT NULL,
  `Title` char(50) NOT NULL,
  `Author_Name` char(15) NOT NULL,
  `Author_Surname` char(30) NOT NULL,
  `Is_Available` char(1) NOT NULL,
  `Is_Reserve` char(1) NOT NULL,
  PRIMARY KEY (`Id_Resources`),
  KEY `RESOURCES_KIND_OF_RESOURCES_FK` (`Id_Kind`)
) ENGINE=InnoDB DEFAULT CHARSET=latin2;

-- --------------------------------------------------------

--
-- Table structure for table `RESOURCES_LIBRARY`
--

CREATE TABLE IF NOT EXISTS `RESOURCES_LIBRARY` (
  `Id_Resources` int(5) NOT NULL,
  `Id_Library` int(2) NOT NULL,
  PRIMARY KEY (`Id_Resources`,`Id_Library`),
  KEY `RESOURCES_LIBRARY_LIBRARY_FK` (`Id_Library`)
) ENGINE=InnoDB DEFAULT CHARSET=latin2;

-- --------------------------------------------------------

--
-- Table structure for table `RESOURCES_USERS`
--

CREATE TABLE IF NOT EXISTS `RESOURCES_USERS` (
  `Id_Resources` int(5) NOT NULL,
  `Id_User` int(6) NOT NULL,
  PRIMARY KEY (`Id_Resources`,`Id_User`),
  KEY `RESOURCES_USERS_USERS_FK` (`Id_User`)
) ENGINE=InnoDB DEFAULT CHARSET=latin2;

-- --------------------------------------------------------

--
-- Table structure for table `USERS`
--

CREATE TABLE IF NOT EXISTS `USERS` (
  `Id_User` int(6) NOT NULL,
  `Id_Authority` int(1) NOT NULL,
  `User_Name` char(15) NOT NULL,
  `User_Surname` char(20) NOT NULL,
  `Pesel` int(11) NOT NULL,
  `Limitk` int(1) NOT NULL,
  `Amount_Of_Borrows` int(1) NOT NULL,
  `Login` char(15) NOT NULL,
  `Password` char(10) NOT NULL,
  PRIMARY KEY (`Id_User`),
  KEY `USERS_AUTHORITY_FK` (`Id_Authority`)
) ENGINE=InnoDB DEFAULT CHARSET=latin2;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `RESOURCES`
--
ALTER TABLE `RESOURCES`
  ADD CONSTRAINT `RESOURCES_KIND_OF_RESOURCES_FK` FOREIGN KEY (`Id_Kind`) REFERENCES `KIND_OF_RESOURCES` (`Id_Kind`);

--
-- Constraints for table `RESOURCES_LIBRARY`
--
ALTER TABLE `RESOURCES_LIBRARY`
  ADD CONSTRAINT `RESOURCES_LIBRARY_RESOURCES_FK` FOREIGN KEY (`Id_Resources`) REFERENCES `RESOURCES` (`Id_Resources`),
  ADD CONSTRAINT `RESOURCES_LIBRARY_LIBRARY_FK` FOREIGN KEY (`Id_Library`) REFERENCES `LIBRARY` (`Id_Library`);

--
-- Constraints for table `RESOURCES_USERS`
--
ALTER TABLE `RESOURCES_USERS`
  ADD CONSTRAINT `RESOURCES_USERS_USERS_FK` FOREIGN KEY (`Id_User`) REFERENCES `USERS` (`Id_User`),
  ADD CONSTRAINT `RESOURCES_USERS_RESOURCES_FK` FOREIGN KEY (`Id_Resources`) REFERENCES `RESOURCES` (`Id_Resources`);

--
-- Constraints for table `USERS`
--
ALTER TABLE `USERS`
  ADD CONSTRAINT `USERS_AUTHORITY_FK` FOREIGN KEY (`Id_Authority`) REFERENCES `AUTHORITY` (`Id_Authority`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
