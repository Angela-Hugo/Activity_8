-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 28, 2024 at 05:13 AM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `case_management`
--

-- --------------------------------------------------------

--
-- Table structure for table `attorney`
--

CREATE TABLE `attorney` (
  `att_id` int(11) NOT NULL,
  `lname` varchar(50) NOT NULL,
  `fname` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `attorney`
--

INSERT INTO `attorney` (`att_id`, `lname`, `fname`) VALUES
(1, 'Smith', 'John'),
(2, 'Doe', 'Jane'),
(3, 'Brown', 'Mike'),
(4, 'Davis', 'Susan'),
(13, 'Lee', 'Emma'),
(14, 'Guo', 'Alex');

-- --------------------------------------------------------

--
-- Table structure for table `case_assignment`
--

CREATE TABLE `case_assignment` (
  `case_assignment_id` int(11) NOT NULL,
  `case_id` int(11) NOT NULL,
  `att_id` int(11) NOT NULL,
  `prosec_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `case_assignment`
--

INSERT INTO `case_assignment` (`case_assignment_id`, `case_id`, `att_id`, `prosec_id`) VALUES
(1, 1, 1, 1),
(2, 2, 2, 2),
(3, 3, 3, 3),
(4, 4, 4, 4),
(13, 51, 13, 13),
(14, 52, 14, 14);

-- --------------------------------------------------------

--
-- Table structure for table `courtcases`
--

CREATE TABLE `courtcases` (
  `case_id` int(11) NOT NULL,
  `case_number` varchar(50) NOT NULL,
  `case_title` varchar(255) NOT NULL,
  `case_type` varchar(50) NOT NULL,
  `case_status` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `courtcases`
--

INSERT INTO `courtcases` (`case_id`, `case_number`, `case_title`, `case_type`, `case_status`) VALUES
(1, 'CN001', 'Case One', 'Criminal', 'Open'),
(2, 'CN002', 'Case Two', 'Civil', 'Closed'),
(3, 'CN003', 'Case Three', 'Criminal', 'Open'),
(4, 'CN004', 'Case Four', 'Civil', 'Pending'),
(51, 'CN005', 'Case Five', 'Criminal', 'Open'),
(52, 'CN006', 'Case Six', 'Legal', 'Pending');

-- --------------------------------------------------------

--
-- Table structure for table `prosecutor`
--

CREATE TABLE `prosecutor` (
  `pro_sec_id` int(11) NOT NULL,
  `lname` varchar(50) NOT NULL,
  `fname` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `prosecutor`
--

INSERT INTO `prosecutor` (`pro_sec_id`, `lname`, `fname`) VALUES
(1, 'White', 'Alice'),
(2, 'Green', 'Bob'),
(3, 'Black', 'Charlie'),
(4, 'Gray', 'Diana'),
(13, 'Wang', 'Alex'),
(14, 'Lee', 'Mina');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `attorney`
--
ALTER TABLE `attorney`
  ADD PRIMARY KEY (`att_id`);

--
-- Indexes for table `case_assignment`
--
ALTER TABLE `case_assignment`
  ADD PRIMARY KEY (`case_assignment_id`),
  ADD KEY `case_id` (`case_id`),
  ADD KEY `att_id` (`att_id`),
  ADD KEY `prosec_id` (`prosec_id`);

--
-- Indexes for table `courtcases`
--
ALTER TABLE `courtcases`
  ADD PRIMARY KEY (`case_id`),
  ADD UNIQUE KEY `case_number` (`case_number`);

--
-- Indexes for table `prosecutor`
--
ALTER TABLE `prosecutor`
  ADD PRIMARY KEY (`pro_sec_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `attorney`
--
ALTER TABLE `attorney`
  MODIFY `att_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT for table `case_assignment`
--
ALTER TABLE `case_assignment`
  MODIFY `case_assignment_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT for table `courtcases`
--
ALTER TABLE `courtcases`
  MODIFY `case_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=53;

--
-- AUTO_INCREMENT for table `prosecutor`
--
ALTER TABLE `prosecutor`
  MODIFY `pro_sec_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `case_assignment`
--
ALTER TABLE `case_assignment`
  ADD CONSTRAINT `case_assignment_ibfk_1` FOREIGN KEY (`case_id`) REFERENCES `courtcases` (`case_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `case_assignment_ibfk_2` FOREIGN KEY (`att_id`) REFERENCES `attorney` (`att_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `case_assignment_ibfk_3` FOREIGN KEY (`prosec_id`) REFERENCES `prosecutor` (`pro_sec_id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
