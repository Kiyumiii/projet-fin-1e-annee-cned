-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : lun. 31 mai 2021 à 12:52
-- Version du serveur :  5.7.31
-- Version de PHP : 7.3.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `bddtest`
--

-- --------------------------------------------------------

--
-- Structure de la table `absence`
--

DROP TABLE IF EXISTS `absence`;
CREATE TABLE IF NOT EXISTS `absence` (
  `IDPERSONNEL` mediumint(9) NOT NULL AUTO_INCREMENT,
  `NOM` varchar(255) NOT NULL,
  `PRENOM` varchar(255) NOT NULL,
  `IDMOTIF` varchar(255) DEFAULT NULL,
  `DATEDEBUT` datetime DEFAULT NULL,
  `DATEFIN` datetime DEFAULT NULL,
  PRIMARY KEY (`IDPERSONNEL`)
) ENGINE=MyISAM AUTO_INCREMENT=24 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `absence`
--

INSERT INTO `absence` (`IDPERSONNEL`, `NOM`, `PRENOM`, `IDMOTIF`, `DATEDEBUT`, `DATEFIN`) VALUES
(19, 'Silva', 'Acton', 'Motif Familial', '2020-09-12 11:02:31', '2021-12-17 14:10:52'),
(18, 'Rosa', 'Hiroko', 'Vacances', '2020-12-08 21:31:02', '2021-09-17 13:54:40'),
(17, 'Parrish', 'Harrison', 'Congé Parental', '2021-01-15 08:24:04', '2022-05-05 20:31:12'),
(16, 'Hyde', 'Fredericka', 'Vacances', '2020-12-29 02:43:59', '2021-07-24 17:19:48'),
(15, 'Neal', 'Peter', 'Motif Familial', '2020-09-29 16:34:55', '2021-07-28 10:05:21'),
(14, 'Newton', 'Ivor', 'Maladie', '2021-01-23 13:00:25', '2022-01-12 14:26:15'),
(13, 'Valentine', 'Dean', 'Maladie', '2020-06-23 16:06:07', '2022-02-24 13:55:03'),
(12, 'Winters', 'Scarlet', 'Vacances', '2021-03-20 20:47:15', '2021-09-20 02:33:54'),
(11, 'Lee', 'Kane', 'Congé Parental', '2021-02-18 12:50:16', '2021-06-25 16:11:53'),
(10, 'Murray', 'Melissa', 'Maladie', '2021-05-30 12:29:19', '2021-08-02 16:22:49'),
(9, 'Haynes', 'Perry', 'Congé Parental', '2021-04-24 00:30:58', '2021-09-30 15:59:18'),
(7, 'Fulton', 'Stacy', 'Congé Parental', '2021-01-16 00:40:45', '2021-10-06 04:40:49'),
(6, 'Joyner', 'Xyla', 'Motif Familial', '2020-08-17 17:47:35', '2021-10-05 22:09:38'),
(5, 'Weber', 'Kathleen', 'Motif Familial', '2020-09-05 19:25:29', '2022-02-20 14:05:02'),
(4, 'Wall', 'Willa', 'Motif Familial', '2021-02-02 17:39:49', '2022-03-25 00:01:52'),
(3, 'Kim', 'Sloane', 'Congé Parental', '2020-12-15 10:06:01', '2021-09-07 19:02:41'),
(1, 'Hanson', 'Hu', 'Vacances', '2021-01-05 01:39:23', '2021-08-15 08:34:15'),
(20, 'Hutchinson', 'Honorato', 'Motif Familial', '2021-01-03 22:26:48', '2022-01-01 10:53:52');

-- --------------------------------------------------------

--
-- Structure de la table `personnel`
--

DROP TABLE IF EXISTS `personnel`;
CREATE TABLE IF NOT EXISTS `personnel` (
  `IDPERSONNEL` mediumint(9) NOT NULL AUTO_INCREMENT,
  `IDSERVICE` varchar(255) DEFAULT NULL,
  `NOM` varchar(255) DEFAULT NULL,
  `PRENOM` varchar(255) DEFAULT NULL,
  `TEL` varchar(100) DEFAULT NULL,
  `MAIL` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`IDPERSONNEL`)
) ENGINE=MyISAM AUTO_INCREMENT=30 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `personnel`
--

INSERT INTO `personnel` (`IDPERSONNEL`, `IDSERVICE`, `NOM`, `PRENOM`, `TEL`, `MAIL`) VALUES
(1, 'Prêt', 'Rojas', 'Keelie', '04 41 30 03 36', 'sem.semper.erat@seddictum.co.uk'),
(2, 'Prêt', 'Fry', 'Geraldine', '06 17 10 23 17', 'libero.dui.nec@idrisus.edu'),
(3, 'Médiation Culturelle ', 'Livingston', 'Mariam', '03 38 61 30 40', 'Donec.est.mauris@ullamcorpernislarcu.org'),
(4, 'Médiation Culturelle ', 'Merritt', 'Matthew', '01 77 10 24 31', 'sagittis.semper@Proinnisl.com'),
(6, 'Prêt', 'Cobb', 'Xaviera', '03 85 63 53 44', 'lacus.pede.sagittis@ettristiquepellentesque.org'),
(7, 'Médiation Culturelle ', 'Cole', 'Knox', '02 42 04 61 62', 'vitae@erat.org'),
(8, 'Prêt', 'Baarton', 'Julian', '09 59 89 29 32', 'neque.sed@necligula.ca'),
(9, 'Prêt', 'Stevens', 'Bo', '01 07 12 65 89', 'iaculis.nec.eleifend@rhoncusNullam.edu'),
(10, 'Prêt', 'Sharpe', 'Larissa', '01 44 55 01 20', 'mattis@nibh.com'),
(11, 'Prêt', 'Bentley', 'Evan', '03 98 43 54 51', 'tellus.faucibus@egestasurnajusto.ca'),
(12, 'Prêt', 'Blevins', 'Benjamin', '04 97 26 44 53', 'arcu.Vestibulum@Duisdignissimtempor.com'),
(13, 'Médiation Culturelle ', 'Stevens', 'Oscar', '03 41 44 08 78', 'orci.tincidunt@anteipsum.com'),
(14, 'Médiation Culturelle ', 'Mcguire', 'Evelyn', '06 37 42 93 54', 'arcu@quis.co.uk'),
(15, 'Médiation Culturelle ', 'Mendoza', 'Basil', '05 66 77 44 67', 'dolor@velarcuCurabitur.net'),
(16, 'Médiation Culturelle ', 'Stewart', 'Uriel', '06 07 85 62 87', 'elit@necmollisvitae.ca'),
(17, 'Administratif ', 'Rowland', 'Rae', '06 43 85 48 73', 'risus.Duis@erat.com'),
(19, 'Médiation Culturelle ', 'Mckinney', 'Hilary', '06 75 39 89 39', 'vestibulum.Mauris@sem.ca'),
(20, 'Administratif ', 'Boyer', 'Libby', '02 11 86 60 10', 'fringilla.Donec.feugiat@Quisqueimperdieterat.net'),
(25, 'Prêt', 'gerard', 'leplombier', 'oiezr', 'eori'),
(26, 'Médiation Culturelle', 'Michel', 'Michel', '0689657525', 'michel.michel@gmail.com');

-- --------------------------------------------------------

--
-- Structure de la table `responsable`
--

DROP TABLE IF EXISTS `responsable`;
CREATE TABLE IF NOT EXISTS `responsable` (
  `RES_LOGIN` varchar(64) DEFAULT NULL,
  `RES_MDP` varchar(64) DEFAULT NULL,
  `RES_ID` int(32) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`RES_ID`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `responsable`
--

INSERT INTO `responsable` (`RES_LOGIN`, `RES_MDP`, `RES_ID`) VALUES
('michel', '10b05c446ea776cdcae1ab10f5dcdbad5eeb9250a8b6f62752e6d4e755850fab', 1);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
