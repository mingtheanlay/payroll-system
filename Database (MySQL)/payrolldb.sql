-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 06, 2021 at 11:10 AM
-- Server version: 10.4.18-MariaDB
-- PHP Version: 8.0.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `payrolldb`
--

-- --------------------------------------------------------

--
-- Table structure for table `autonumber`
--

CREATE TABLE `autonumber` (
  `id` int(11) NOT NULL,
  `autoname` varchar(30) NOT NULL,
  `strnum` int(11) NOT NULL,
  `increment` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `autonumber`
--

INSERT INTO `autonumber` (`id`, `autoname`, `strnum`, `increment`) VALUES
(1, 'trans', 24, 1);

-- --------------------------------------------------------

--
-- Table structure for table `employee`
--

CREATE TABLE `employee` (
  `emp_code` varchar(30) NOT NULL,
  `emp_fname` varchar(60) DEFAULT NULL,
  `emp_lname` varchar(60) DEFAULT NULL,
  `emp_mname` varchar(60) DEFAULT NULL,
  `address` varchar(100) DEFAULT NULL,
  `contact` int(20) DEFAULT NULL,
  `status` varchar(30) DEFAULT NULL,
  `birth_date` date DEFAULT NULL,
  `birth_place` varchar(100) DEFAULT NULL,
  `emp_sex` varchar(10) DEFAULT NULL,
  `emp_age` int(10) DEFAULT NULL,
  `emerg_contct` int(25) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `employee`
--

INSERT INTO `employee` (`emp_code`, `emp_fname`, `emp_lname`, `emp_mname`, `address`, `contact`, `status`, `birth_date`, `birth_place`, `emp_sex`, `emp_age`, `emerg_contct`) VALUES
('emp1', 'Lay', 'Ming', 'Thean', 'Phnom Penh', 123456789, 'Single', '1999-12-30', 'Phnom Penh\n', 'Male', 21, 123456789),
('emp2', 'Chhe', 'Chin', 'Yong', 'Phnom Penh', 123456789, 'Single', '1999-07-14', 'Kompong Cham', 'Male', 21, 123456789),
('emp3', 'Phal', 'Sok', 'Heng', 'Phnom Penh', 123456789, 'Single', '1999-07-04', 'Phnom Penh', 'Male', 21, 123456789),
('emp4', 'Nor', 'Piseth', '    ', 'Phnom Penh', 123456789, 'Single', '1999-07-14', 'Phnom Penh\n', 'Male', 21, 123456789),
('emp5', 'Noey', 'Sahaksawat', '   ', 'Phnom Penh', 123456789, 'Single', '1998-07-15', 'Phnom Penh\n', 'Male', 22, 123456789),
('emp6', 'Sor', 'Tola', '  ', 'Phnom Penh', 123456789, 'Single', '1998-07-15', 'Phnom Penh', 'Male', 21, 123456789);

-- --------------------------------------------------------

--
-- Table structure for table `employee_workinfo`
--

CREATE TABLE `employee_workinfo` (
  `id` int(10) NOT NULL,
  `emp_code` varchar(10) NOT NULL,
  `d_rate` int(30) DEFAULT NULL,
  `p_method` varchar(60) DEFAULT NULL,
  `position` varchar(60) DEFAULT NULL,
  `w_status` varchar(60) DEFAULT NULL,
  `d_hired` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `employee_workinfo`
--

INSERT INTO `employee_workinfo` (`id`, `emp_code`, `d_rate`, `p_method`, `position`, `w_status`, `d_hired`) VALUES
(26, 'tt1', 16, 'Monthly', 'Developer', 'active', '2010-07-20'),
(28, 'emp1', 16, 'Monthly', 'Developer', 'Active', '2021-05-04'),
(29, 'emp2', 16, 'Monthly', 'Developer', 'Active', '2021-05-04'),
(30, 'emp3', 16, 'Monthly', 'Developer', 'Active', '2021-05-04'),
(31, 'emp4', 16, 'Monthly', 'Developer', 'Active', '2021-05-04'),
(32, 'emp5', 16, 'Monthly', 'Developer', 'Active', '2021-05-04'),
(33, 'emp6', 16, 'Monthly', 'Developer', 'Active', '2021-05-04');

-- --------------------------------------------------------

--
-- Table structure for table `other_deduction`
--

CREATE TABLE `other_deduction` (
  `KEY` int(11) NOT NULL,
  `trans_id` varchar(30) NOT NULL,
  `emp_code` varchar(10) DEFAULT NULL,
  `deduct1` varchar(60) DEFAULT NULL,
  `ded_amount1` int(30) DEFAULT NULL,
  `deduct2` varchar(60) DEFAULT NULL,
  `ded_amount2` int(30) DEFAULT NULL,
  `deduct3` varchar(60) DEFAULT NULL,
  `ded_amount3` int(30) DEFAULT NULL,
  `deduct4` varchar(60) DEFAULT NULL,
  `ded_amount4` int(30) DEFAULT NULL,
  `total_ded` int(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `other_deduction`
--

INSERT INTO `other_deduction` (`KEY`, `trans_id`, `emp_code`, `deduct1`, `ded_amount1`, `deduct2`, `ded_amount2`, `deduct3`, `ded_amount3`, `deduct4`, `ded_amount4`, `total_ded`) VALUES
(4, 'trans9', '', '', 0, '', 0, '', 0, '', 0, 0),
(17, 'trans22', 'emp1', '', 0, '', 0, '', 0, '', 0, 0),
(18, 'trans23', 'emp1', '', 0, '', 0, '', 0, '', 0, 40);

-- --------------------------------------------------------

--
-- Table structure for table `payroll`
--

CREATE TABLE `payroll` (
  `KEY` int(11) NOT NULL,
  `emp_code` varchar(10) NOT NULL,
  `num_days` int(30) DEFAULT NULL,
  `r_wage` int(30) DEFAULT NULL,
  `overtime` int(30) DEFAULT NULL,
  `hol_pay` int(30) DEFAULT NULL,
  `gross_sal` int(30) DEFAULT NULL,
  `cash_ad` int(30) DEFAULT NULL,
  `bread_vale` int(30) DEFAULT NULL,
  `philhealth` int(30) DEFAULT NULL,
  `pag-ibig` int(30) DEFAULT NULL,
  `net_income` int(30) DEFAULT NULL,
  `remarks` varchar(100) DEFAULT NULL,
  `dateissued` date NOT NULL,
  `trans_id` varchar(30) NOT NULL DEFAULT '0',
  `user_id` int(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `payroll`
--

INSERT INTO `payroll` (`KEY`, `emp_code`, `num_days`, `r_wage`, `overtime`, `hol_pay`, `gross_sal`, `cash_ad`, `bread_vale`, `philhealth`, `pag-ibig`, `net_income`, `remarks`, `dateissued`, `trans_id`, `user_id`) VALUES
(18, 'emp1', 1, 500, 0, 0, 500, 0, 0, 0, 0, 500, '', '2021-05-04', 'trans22', NULL),
(19, 'emp1', 30, 480, 32, 0, 512, 0, 0, 10, 30, 472, '', '2021-05-04', 'trans23', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `user_id` int(30) NOT NULL,
  `name` text DEFAULT NULL,
  `username` varchar(60) DEFAULT NULL,
  `pass` varchar(90) DEFAULT NULL,
  `type` varchar(60) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`user_id`, `name`, `username`, `pass`, `type`) VALUES
(12, 'administrator', 'admin', 'd033e22ae348aeb5660fc2140aec35850c4da997', 'Administrator'),
(13, 'guest', 'guest', '35675e68f4b5af7b995d9205ad0fc43842f16450', 'Guest'),
(14, 'staff', 'staff', '6ccb4b7c39a6e77f76ecfa935a855c6c46ad5611', 'Staff');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `autonumber`
--
ALTER TABLE `autonumber`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`emp_code`),
  ADD UNIQUE KEY `emp_code` (`emp_code`);

--
-- Indexes for table `employee_workinfo`
--
ALTER TABLE `employee_workinfo`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `emp_code_2` (`emp_code`),
  ADD KEY `emp_code` (`emp_code`);

--
-- Indexes for table `other_deduction`
--
ALTER TABLE `other_deduction`
  ADD PRIMARY KEY (`KEY`);

--
-- Indexes for table `payroll`
--
ALTER TABLE `payroll`
  ADD PRIMARY KEY (`KEY`),
  ADD KEY `user_id` (`user_id`),
  ADD KEY `trans_id` (`trans_id`),
  ADD KEY `emp_code` (`emp_code`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`user_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `autonumber`
--
ALTER TABLE `autonumber`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `employee_workinfo`
--
ALTER TABLE `employee_workinfo`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=34;

--
-- AUTO_INCREMENT for table `other_deduction`
--
ALTER TABLE `other_deduction`
  MODIFY `KEY` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT for table `payroll`
--
ALTER TABLE `payroll`
  MODIFY `KEY` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `user_id` int(30) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
