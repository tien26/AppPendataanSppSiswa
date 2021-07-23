-- phpMyAdmin SQL Dump
-- version 4.2.7.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Feb 25, 2020 at 04:14 AM
-- Server version: 5.6.20
-- PHP Version: 5.5.15

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `dbkeuangan`
--

-- --------------------------------------------------------

--
-- Table structure for table `datapetugas`
--

CREATE TABLE IF NOT EXISTS `datapetugas` (
  `NIP` varchar(10) NOT NULL,
  `NAMAPETUGAS` varchar(50) NOT NULL,
  `USERNAME` varchar(30) NOT NULL,
  `PASSWORD` varchar(30) NOT NULL,
  `LEVEL` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `datapetugas`
--

INSERT INTO `datapetugas` (`NIP`, `NAMAPETUGAS`, `USERNAME`, `PASSWORD`, `LEVEL`) VALUES
('2020001', 'irfan', 'irfan', 'irfan', 'Kepala Admin'),
('2020002', 'martien', 'martien', 'martien', 'Kepala Keuangan'),
('2020003', 'kaka', 'kaka', 'kaka', 'Admin'),
('2020004', 'adek', 'ade', 'ade', 'Admin');

-- --------------------------------------------------------

--
-- Table structure for table `datasiswa`
--

CREATE TABLE IF NOT EXISTS `datasiswa` (
  `NIS` varchar(10) NOT NULL,
  `NAMASISWA` varchar(50) NOT NULL,
  `JENISKELAMIN` varchar(20) NOT NULL,
  `KELAS` varchar(20) NOT NULL,
  `ALAMAT` varchar(20) NOT NULL,
  `NAMAIBU` varchar(50) NOT NULL,
  `NAMAAYAH` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `datasiswa`
--

INSERT INTO `datasiswa` (`NIS`, `NAMASISWA`, `JENISKELAMIN`, `KELAS`, `ALAMAT`, `NAMAIBU`, `NAMAAYAH`) VALUES
('2020001', 'edo', 'Laki - Laki', '10 TKJ', 'kuningan', 'uun', 'nunu'),
('2020002', 'maman baru', 'Laki - Laki', '10 TKJ', 'cirebon', 'ina', 'nana'),
('2020003', 'marsa', 'Perempuan', '11 TKJ', 'cipicung', 'lili', 'pahmi'),
('2020004', 'tito', 'Laki - Laki', '11 TKJ', 'nagog', 'neng', 'otong'),
('2020005', 'ilah', 'Perempuan', '12 TKJ', 'ciniru', 'kira', 'koko');

-- --------------------------------------------------------

--
-- Table structure for table `kelas1tkj`
--

CREATE TABLE IF NOT EXISTS `kelas1tkj` (
  `NIS` varchar(20) NOT NULL,
  `NAMASISWA` varchar(10) NOT NULL,
  `KELAS` varchar(30) NOT NULL,
  `JAN` int(13) NOT NULL,
  `FEB` int(13) NOT NULL,
  `MAR` int(13) NOT NULL,
  `APR` int(13) NOT NULL,
  `MEI` int(13) NOT NULL,
  `JUN` int(13) NOT NULL,
  `JUL` int(13) NOT NULL,
  `AGS` int(13) NOT NULL,
  `SEP` int(13) NOT NULL,
  `OKT` int(13) NOT NULL,
  `NOV` int(13) NOT NULL,
  `DES` int(13) NOT NULL,
  `TOTAL` int(14) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `kelas1tkj`
--

INSERT INTO `kelas1tkj` (`NIS`, `NAMASISWA`, `KELAS`, `JAN`, `FEB`, `MAR`, `APR`, `MEI`, `JUN`, `JUL`, `AGS`, `SEP`, `OKT`, `NOV`, `DES`, `TOTAL`) VALUES
('2020001', 'edo', '10 TKJ', 500000, 500000, 500000, 500000, 0, 0, 0, 0, 0, 0, 0, 0, 2000000),
('2020002', 'maman baru', '10 TKJ', 500000, 500000, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1000000);

-- --------------------------------------------------------

--
-- Table structure for table `kelas2tkj`
--

CREATE TABLE IF NOT EXISTS `kelas2tkj` (
  `NIS` varchar(10) NOT NULL,
  `NAMASISWA` varchar(50) NOT NULL,
  `KELAS` varchar(20) NOT NULL,
  `JAN` int(13) NOT NULL,
  `FEB` int(13) NOT NULL,
  `MAR` int(13) NOT NULL,
  `APR` int(13) NOT NULL,
  `MEI` int(13) NOT NULL,
  `JUN` int(13) NOT NULL,
  `JUL` int(13) NOT NULL,
  `AGS` int(13) NOT NULL,
  `SEP` int(13) NOT NULL,
  `OKT` int(13) NOT NULL,
  `NOV` int(13) NOT NULL,
  `DES` int(13) NOT NULL,
  `TOTAL` int(14) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `kelas2tkj`
--

INSERT INTO `kelas2tkj` (`NIS`, `NAMASISWA`, `KELAS`, `JAN`, `FEB`, `MAR`, `APR`, `MEI`, `JUN`, `JUL`, `AGS`, `SEP`, `OKT`, `NOV`, `DES`, `TOTAL`) VALUES
('2020003', 'marsa', '11 TKJ', 500000, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 500000),
('2020004', 'tito', '11 TKJ', 500000, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 500000);

-- --------------------------------------------------------

--
-- Table structure for table `kelas3tkj`
--

CREATE TABLE IF NOT EXISTS `kelas3tkj` (
  `NIS` varchar(10) NOT NULL,
  `NAMASISWA` varchar(50) NOT NULL,
  `KELAS` varchar(20) NOT NULL,
  `JAN` int(13) NOT NULL,
  `FEB` int(13) NOT NULL,
  `MAR` int(13) NOT NULL,
  `APR` int(13) NOT NULL,
  `MEI` int(13) NOT NULL,
  `JUN` int(13) NOT NULL,
  `JUL` int(13) NOT NULL,
  `AGS` int(13) NOT NULL,
  `SEP` int(13) NOT NULL,
  `OKT` int(13) NOT NULL,
  `NOV` int(13) NOT NULL,
  `DES` int(13) NOT NULL,
  `TOTAL` int(14) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `kelas3tkj`
--

INSERT INTO `kelas3tkj` (`NIS`, `NAMASISWA`, `KELAS`, `JAN`, `FEB`, `MAR`, `APR`, `MEI`, `JUN`, `JUL`, `AGS`, `SEP`, `OKT`, `NOV`, `DES`, `TOTAL`) VALUES
('2020005', 'ilah', '12 TKJ', 500000, 500000, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1000000);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `datapetugas`
--
ALTER TABLE `datapetugas`
 ADD PRIMARY KEY (`NIP`);

--
-- Indexes for table `datasiswa`
--
ALTER TABLE `datasiswa`
 ADD PRIMARY KEY (`NIS`);

--
-- Indexes for table `kelas1tkj`
--
ALTER TABLE `kelas1tkj`
 ADD PRIMARY KEY (`NIS`), ADD KEY `NIS` (`NAMASISWA`), ADD KEY `NIS_2` (`NAMASISWA`), ADD KEY `NIS_3` (`NIS`);

--
-- Indexes for table `kelas2tkj`
--
ALTER TABLE `kelas2tkj`
 ADD PRIMARY KEY (`NIS`);

--
-- Indexes for table `kelas3tkj`
--
ALTER TABLE `kelas3tkj`
 ADD PRIMARY KEY (`NIS`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
