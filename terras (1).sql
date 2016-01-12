-- phpMyAdmin SQL Dump
-- version 4.4.12
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Gegenereerd op: 12 jan 2016 om 16:47
-- Serverversie: 5.6.25
-- PHP-versie: 5.5.27

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `terras`
--

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `event`
--

CREATE TABLE IF NOT EXISTS `event` (
  `id` int(10) unsigned NOT NULL,
  `firstname` varchar(50) NOT NULL,
  `date` date NOT NULL,
  `begintijd` time NOT NULL,
  `eindtijd` time NOT NULL,
  `omschrijving` text
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `intranet_users`
--

CREATE TABLE IF NOT EXISTS `intranet_users` (
  `id` int(11) NOT NULL,
  `username` varchar(122) NOT NULL,
  `password` varchar(122) NOT NULL,
  `email` varchar(244) NOT NULL,
  `firstname` varchar(122) NOT NULL,
  `surname` varchar(152) NOT NULL,
  `user_role` int(1) NOT NULL,
  `language` int(5) NOT NULL,
  `active` int(3) NOT NULL,
  `brutoloon` int(2) NOT NULL,
  `geboortedatum` varchar(255) NOT NULL,
  `telefoon` varchar(255) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=80 DEFAULT CHARSET=latin1;

--
-- Gegevens worden geëxporteerd voor tabel `intranet_users`
--

INSERT INTO `intranet_users` (`id`, `username`, `password`, `email`, `firstname`, `surname`, `user_role`, `language`, `active`, `brutoloon`, `geboortedatum`, `telefoon`) VALUES
(6, 'admin', 'admin', 'admin', 'Katherina', 'admin', 3, 3, 3, 0, '1-1-0001 00:00:00', '0');

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `terras_mededelingen`
--

CREATE TABLE IF NOT EXISTS `terras_mededelingen` (
  `id` int(5) NOT NULL,
  `title` varchar(244) NOT NULL,
  `text` text NOT NULL,
  `author` varchar(244) NOT NULL,
  `date` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB AUTO_INCREMENT=35 DEFAULT CHARSET=latin1;

--
-- Gegevens worden geëxporteerd voor tabel `terras_mededelingen`
--

INSERT INTO `terras_mededelingen` (`id`, `title`, `text`, `author`, `date`) VALUES
(32, 'test Titel', 'This is my message<3', 'Katherina', '2016-01-12 13:25:17'),
(33, 'Again', 'another test.\r\n', 'Rebekah', '2016-01-12 13:56:37'),
(34, 'geen test meer', 'alleen victory', 'geen pieter meer', '2016-01-12 16:22:20');

--
-- Indexen voor geëxporteerde tabellen
--

--
-- Indexen voor tabel `event`
--
ALTER TABLE `event`
  ADD PRIMARY KEY (`id`);

--
-- Indexen voor tabel `intranet_users`
--
ALTER TABLE `intranet_users`
  ADD PRIMARY KEY (`id`);

--
-- Indexen voor tabel `terras_mededelingen`
--
ALTER TABLE `terras_mededelingen`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT voor geëxporteerde tabellen
--

--
-- AUTO_INCREMENT voor een tabel `event`
--
ALTER TABLE `event`
  MODIFY `id` int(10) unsigned NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT voor een tabel `intranet_users`
--
ALTER TABLE `intranet_users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=80;
--
-- AUTO_INCREMENT voor een tabel `terras_mededelingen`
--
ALTER TABLE `terras_mededelingen`
  MODIFY `id` int(5) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=35;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
