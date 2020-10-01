-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Czas generowania: 01 Paź 2020, 13:42
-- Wersja serwera: 10.4.14-MariaDB
-- Wersja PHP: 7.4.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Baza danych: `osadnicy`
--

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `uzytkownicy`
--

CREATE TABLE `uzytkownicy` (
  `id` int(11) NOT NULL,
  `user` text COLLATE utf8_polish_ci NOT NULL,
  `pass` text COLLATE utf8_polish_ci NOT NULL,
  `email` text COLLATE utf8_polish_ci NOT NULL,
  `drewno` int(11) NOT NULL,
  `kamien` int(11) NOT NULL,
  `zboze` int(11) NOT NULL,
  `dnipremium` datetime NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Zrzut danych tabeli `uzytkownicy`
--

INSERT INTO `uzytkownicy` (`id`, `user`, `pass`, `email`, `drewno`, `kamien`, `zboze`, `dnipremium`) VALUES
(1, 'adam', '$2y$10$4sZdn0EaurMzGCAla1Up7OJ8vDmhJjKdsyCtQIAIuJ3AuxQ0m0Tly', 'adam@gmail.com', 213, 5675, 342, '2020-09-30 13:26:09'),
(11, 'mirek', '$2y$10$vmSNIWWZApqXydGJ5q9XC.63kF4JvvURC0l2Ns4Qh3nNc55OL.Y6W', 'zelent.miroslaw@gmail.com', 100, 100, 100, '2020-09-30 13:26:09'),
(12, 'Xd123', '$2y$10$BIkHfMf4oTEhDwtuZrxMBulsBv1acDvjmGbi9GivOkg5pkFvKnO8K', 'xd@xd.xd', 100, 100, 100, '2020-09-30 13:26:09'),
(13, 'eeee', '$2y$10$GLt2wJWiU5KxxBZWkwmQVulwSqsGodl30fRuijEjI2QdeqIzJEqKO', 'eeeeeeee@eeeeeee.eeeeee', 100, 100, 100, '2020-09-30 13:26:09'),
(14, 'tabaluga', '$2y$10$SwqdQ9R8.hnlqP.9J0OUUutnhjnLzMHQbVU5tVQ.uEEEDAQnjO.am', 'tabaluga@tabaluga.tabaluga', 100, 100, 100, '2020-10-14 13:42:58'),
(15, 'zgredek', '$2y$10$1ONoHEriJyIrr7t9UTQSG.kbNb5nhAwrPeavX1QsrY5/ahCBazNm2', 'zgredzio@list.me', 100, 100, 100, '2020-09-30 13:26:09'),
(16, 'dsdsdsd', '$2y$10$OBjosReRKwdt1H6se7tCq.cTlH.M0lg1dCJymcd/ovENi32N9Ht/m', 'dsdsdsd@dsds.ds', 100, 100, 100, '2020-09-30 13:26:09'),
(17, 'ABCD', '$2y$10$jvd3Q4cf8.o4I1xUy4BnXO4kX9HrbKFChMEYXYKPJIR/DpTKQ8peW', 'adbcd@dnsjdnj.dsij', 100, 100, 100, '2020-10-14 13:42:58'),
(18, 'dssd', '$2y$10$i6LBIx1hKwcyxVkm236C1em.yCFUtIC78wyRxheNvXVLoPm2nVK4m', 'dsd@ds.sd', 100, 100, 100, '2020-10-15 12:04:53'),
(19, 'ABCDe', '$2y$10$ktiy3JhlHO9GceFhc1aH6ec2oNA25ds0SftimHAtLGw7L4SwLllSi', 'adbcd@dnsjdnj.dsijd', 100, 100, 100, '2020-10-15 12:06:08'),
(20, 'ABCDwe', '$2y$10$PXbPCRFOT38wbSxA8qSkG.7viW6fRf5Sm3GbON17cgMWN0rm.qeXG', 'weewew@ewe.e', 100, 100, 100, '2020-10-15 12:09:27'),
(21, 'dsadsa', '$2y$10$grZU2rn994iOXCF0aKNeceksZmaBZNdEW2d0WPCdcqgJYuP170Tk2', 'sdadsad@dsa.dsa', 100, 100, 100, '2020-10-15 12:11:16'),
(22, 'ABCDewe', '$2y$10$CJab9/mjtHq6CIODSoM1pOFqs2IMhXHK314BUyNGGr/gtWn3CcVya', 'adbcd@dnsjdnj.dsijdfs', 100, 100, 100, '2020-10-15 12:11:41'),
(23, 'ABCDweq', '$2y$10$pmPnoBU2R6Nn1XZR2oJzFOX5ILCcoMDYWnVmdwRGlbjW34Xv7IrDi', 'adbcd@dnsjdnj.dsijeqwe', 100, 100, 100, '2020-10-15 12:12:34'),
(24, 'ABCDdasdxc', '$2y$10$RH/ZikGefp7PHgvAQj2GJel4fCUxC7n6ZU.EFKqGZEKaNfTUsGpiy', 'adbcd@dnsjdnj.dsijsda', 100, 100, 100, '2020-10-15 12:13:44'),
(25, 'ABCDesads', '$2y$10$5lr4tSfSpXLQQrk4Y4P4O.tMZpBrds.Nu55Q29KRfJb5hdhhVe8oe', 'adbcd@dnsjdnj.dsijsadasdsa', 100, 100, 100, '2020-10-15 12:14:59');

--
-- Indeksy dla zrzutów tabel
--

--
-- Indeksy dla tabeli `uzytkownicy`
--
ALTER TABLE `uzytkownicy`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `id` (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT dla tabeli `uzytkownicy`
--
ALTER TABLE `uzytkownicy`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
