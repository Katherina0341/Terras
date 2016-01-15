-- phpMyAdmin SQL Dump
-- version 4.4.12
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Gegenereerd op: 15 jan 2016 om 16:44
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
  `date` varchar(255) NOT NULL,
  `begintijd` varchar(255) NOT NULL,
  `eindtijd` time NOT NULL,
  `omschrijving` text
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;

--
-- Gegevens worden geëxporteerd voor tabel `event`
--

INSERT INTO `event` (`id`, `firstname`, `date`, `begintijd`, `eindtijd`, `omschrijving`) VALUES
(7, 'Katherina', '14-1-2016', '15:48', '15:56:00', NULL),
(8, 'Jarno', '15-1-2016', '10:53', '10:56:00', NULL);

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `ingeroosterd`
--

CREATE TABLE IF NOT EXISTS `ingeroosterd` (
  `id` int(5) NOT NULL,
  `firstname` varchar(255) NOT NULL,
  `date` varchar(255) NOT NULL,
  `begintijd` varchar(255) NOT NULL,
  `eindtijd` varchar(255) NOT NULL,
  `omschrijving` varchar(255) NOT NULL,
  `totale_werkuren` varchar(255) NOT NULL,
  `pauze` varchar(255) NOT NULL,
  `betaalde_uren` varchar(255) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=54 DEFAULT CHARSET=latin1;

--
-- Gegevens worden geëxporteerd voor tabel `ingeroosterd`
--

INSERT INTO `ingeroosterd` (`id`, `firstname`, `date`, `begintijd`, `eindtijd`, `omschrijving`, `totale_werkuren`, `pauze`, `betaalde_uren`) VALUES
(53, 'Hans', '20-1-2016', '08:00', '17:00', '', '9', '0,5', '8,5');

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
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;

--
-- Gegevens worden geëxporteerd voor tabel `intranet_users`
--

INSERT INTO `intranet_users` (`id`, `username`, `password`, `email`, `firstname`, `surname`, `user_role`, `language`, `active`, `brutoloon`, `geboortedatum`, `telefoon`) VALUES
(6, 'admin', 'admin', 'admin', 'Katherina', 'admin', 3, 3, 3, 0, '1-1-0001 00:00:00', '0'),
(7, 'Hans_MGS', 'Hans', 'hans@mgs.nl', 'Hans', 'MGS', 0, 0, 0, 60000, '03-01-1985', '06000000'),
(8, 'geen', 'geen', 'jarno@mgs.nl', 'Jarno', 'geen', 0, 0, 0, 1, '03-03-1989', '05000000'),
(9, 'Rosanne', 'nwfknf;', 'nnafgkaln', 'Rosanne', 'dfkndwln', 0, 0, 0, 1, '03020302', '0642422');

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
) ENGINE=InnoDB AUTO_INCREMENT=36 DEFAULT CHARSET=latin1;

--
-- Gegevens worden geëxporteerd voor tabel `terras_mededelingen`
--

INSERT INTO `terras_mededelingen` (`id`, `title`, `text`, `author`, `date`) VALUES
(32, 'test Titel', 'This is my message<3', 'Katherina', '2016-01-12 13:25:17'),
(33, 'mgg', 'another test.\r\n', 'Rebekah', '2016-01-12 13:56:37'),
(34, 'dvkewfv q;ebv;q', 'alleen victory', 'Helloww', '2016-01-12 16:22:20'),
(35, 'oops, have to click save ofc:D ', 'Hello Ita :D \r\n', 'Ita', '2016-01-13 13:33:11');

--
-- Indexen voor geëxporteerde tabellen
--

--
-- Indexen voor tabel `event`
--
ALTER TABLE `event`
  ADD PRIMARY KEY (`id`);

--
-- Indexen voor tabel `ingeroosterd`
--
ALTER TABLE `ingeroosterd`
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
  MODIFY `id` int(10) unsigned NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=9;
--
-- AUTO_INCREMENT voor een tabel `ingeroosterd`
--
ALTER TABLE `ingeroosterd`
  MODIFY `id` int(5) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=54;
--
-- AUTO_INCREMENT voor een tabel `intranet_users`
--
ALTER TABLE `intranet_users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=10;
--
-- AUTO_INCREMENT voor een tabel `terras_mededelingen`
--
ALTER TABLE `terras_mededelingen`
  MODIFY `id` int(5) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=36;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
