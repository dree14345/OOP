-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 04, 2025 at 07:25 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `oopdb`
--
CREATE DATABASE IF NOT EXISTS `oopdb` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE oopdb;
SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";

DELIMITER $$
--
-- Procedures
--
DROP PROCEDURE IF EXISTS `AscendPatientToHeaven`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `AscendPatientToHeaven` (IN `patient_autoid` INT)   BEGIN
    -- Update the status of the patient
    UPDATE patient_table
    SET status = 'Deceased'
    WHERE autoid = patient_autoid;

    -- Return the full name of the patient
    SELECT CONCAT(p.firstn, ' ',
                  COALESCE(CONCAT(LEFT(p.middlen, 1), '.'), ''),
                  ' ', p.lastn) AS fullname
    FROM patient_table pt
    JOIN person_table p ON pt.person_id = p.autoid
    WHERE pt.autoid = patient_autoid;
END$$

DROP PROCEDURE IF EXISTS `CreateDoctor`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `CreateDoctor` (IN `_firstn` VARCHAR(50), IN `_middlen` VARCHAR(50), IN `_lastn` VARCHAR(50), IN `_dep` VARCHAR(50), IN `_special` VARCHAR(50))   BEGIN
     INSERT INTO doctor_table (
				firstn, middlen, lastn, department, specialization
            ) VALUES (
                _firstn, _middlen, _lastn , _dep, _special
            );
END$$

DROP PROCEDURE IF EXISTS `CreatePerson`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `CreatePerson` (IN `f_name` VARCHAR(50), IN `m_name` VARCHAR(50), IN `l_name` VARCHAR(50), IN `heart_rate` INT)   BEGIN
     INSERT INTO person_table (
				firstn, middlen, lastn, heart_rate
            ) VALUES (
                f_name, m_name, l_name, heart_rate
            );
END$$

DROP PROCEDURE IF EXISTS `DeletePerson`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `DeletePerson` (IN `_id` INT)   BEGIN
    DELETE FROM person_table WHERE autoid = _id;
END$$

DROP PROCEDURE IF EXISTS `GetActivePatients`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetActivePatients` (IN `search_term` VARCHAR(255))   BEGIN
    SELECT pt.autoid, pt.person_id, CONCAT(p.firstn, ' ', 
               COALESCE(CONCAT(LEFT(p.middlen, 1), '.'), ''), ' ', 
               p.lastn) AS PersonName, pt.doctor_id,
               CONCAT(d.firstn, ' ', 
               COALESCE(CONCAT(LEFT(d.middlen, 1), '.'), ''), ' ', 
               d.lastn) AS DoctorName, pt.status, pt.diagnose, pt.note
    FROM patient_table pt
    INNER JOIN person_table p ON pt.person_id = p.autoid
    INNER JOIN doctor_table d ON pt.doctor_id = d.autoid
    WHERE (
        COALESCE(search_term, '') = '' 
        OR p.firstn LIKE CONCAT('%', search_term, '%') 
        OR p.middlen LIKE CONCAT('%', search_term, '%') 
        OR p.lastn LIKE CONCAT('%', search_term, '%')
    )
    AND pt.status = 'Admitted';
END$$

DROP PROCEDURE IF EXISTS `GetAllPersonData`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetAllPersonData` (IN `search_term` VARCHAR(255))   BEGIN
    SELECT 
        * FROM person_table
    WHERE COALESCE(search_term, '') = '' 
       OR firstn LIKE CONCAT('%', search_term, '%') 
       OR middlen LIKE CONCAT('%', search_term, '%') 
       OR lastn LIKE CONCAT('%', search_term, '%');
END$$

DROP PROCEDURE IF EXISTS `GetAngelData`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetAngelData` (IN `search_term` VARCHAR(255))   BEGIN
    SELECT 
       	* from angel_table
    WHERE COALESCE(search_term, '') = '' 
       OR name LIKE CONCAT('%', search_term, '%');
END$$

DROP PROCEDURE IF EXISTS `GetDoctor`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetDoctor` (IN `search_term` VARCHAR(255))   BEGIN
    SELECT d.autoid, d.firstn, d.middlen, d.lastn, CONCAT(d.firstn, ' ', 
               COALESCE(CONCAT(LEFT(d.middlen, 1), '.'), ''), ' ', 
               d.lastn) AS Fullname, d.department, d.specialization FROM doctor_table d
    WHERE COALESCE(search_term, '') = '' 
        OR d.firstn LIKE CONCAT('%', search_term, '%') 
        OR d.middlen LIKE CONCAT('%', search_term, '%') 
        OR d.lastn LIKE CONCAT('%', search_term, '%');

END$$

DROP PROCEDURE IF EXISTS `GetRandomAngel`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetRandomAngel` ()   BEGIN
    SELECT name FROM angel_table ORDER BY RAND() LIMIT 1;
END$$

DROP PROCEDURE IF EXISTS `UpdatePerson`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `UpdatePerson` (IN `id` INT, IN `f_name` VARCHAR(50), IN `m_name` VARCHAR(50), IN `l_name` VARCHAR(50), IN `heart_rate` INT)   BEGIN
     UPDATE person_table SET firstn = f_name, middlen = m_name, lastn = l_name WHERE id = id;
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `angel_table`
--

DROP TABLE IF EXISTS `angel_table`;
CREATE TABLE `angel_table` (
  `autoid` int(11) NOT NULL,
  `name` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `doctor_table`
--

DROP TABLE IF EXISTS `doctor_table`;
CREATE TABLE `doctor_table` (
  `autoid` int(11) NOT NULL,
  `firstn` varchar(50) NOT NULL,
  `middlen` text NOT NULL,
  `lastn` text NOT NULL,
  `department` text NOT NULL,
  `specialization` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `doctor_table`
--

INSERT INTO `doctor_table` (`autoid`, `firstn`, `middlen`, `lastn`, `department`, `specialization`) VALUES
(1, 'Dree', 'Bitaysar', 'Bautista', 'Cardiology', 'Heart'),
(2, 'TEST', 'TEST', 'test', 'wehhh', 'wehhh');

-- --------------------------------------------------------

--
-- Table structure for table `patient_table`
--

DROP TABLE IF EXISTS `patient_table`;
CREATE TABLE `patient_table` (
  `autoid` int(11) NOT NULL,
  `person_id` int(11) NOT NULL,
  `doctor_id` int(11) NOT NULL,
  `status` varchar(50) NOT NULL DEFAULT 'Admitted' COMMENT 'Admitted, Discharged, Deceased',
  `diagnose` text NOT NULL,
  `note` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `patient_table`
--

INSERT INTO `patient_table` (`autoid`, `person_id`, `doctor_id`, `status`, `diagnose`, `note`) VALUES
(1, 1, 1, 'Admitted', 'Heart Cancer', '6 Months to Live'),
(2, 2, 2, 'Admitted', 'Cancer', 'Deceased in 6 months'),
(3, 1, 2, 'Discharged', 'shhhh', 'shhhh'),
(4, 1, 1, 'Deceased', 'waw', 'waw'),
(5, 3, 1, 'Discharged', 'weh', 'weeee'),
(6, 3, 2, 'Discharged', 'che', 'che'),
(7, 4, 1, 'Discharged', 'heh', 'hhheee');

-- --------------------------------------------------------

--
-- Table structure for table `person_table`
--

DROP TABLE IF EXISTS `person_table`;
CREATE TABLE `person_table` (
  `autoid` int(11) NOT NULL,
  `firstn` varchar(50) NOT NULL,
  `middlen` varchar(50) NOT NULL,
  `lastn` varchar(50) NOT NULL,
  `heart_rate` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `person_table`
--

INSERT INTO `person_table` (`autoid`, `firstn`, `middlen`, `lastn`, `heart_rate`) VALUES
(1, 'dree', 'bb', 'bbbb', 55),
(2, 'test', 'test', 'test', 55),
(3, 'hatdog', 'jumbo', 'cheesedog', 55),
(4, 'nice one', 'nice one', 'ggg', 44);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `angel_table`
--
ALTER TABLE `angel_table`
  ADD PRIMARY KEY (`autoid`);

--
-- Indexes for table `doctor_table`
--
ALTER TABLE `doctor_table`
  ADD PRIMARY KEY (`autoid`);

--
-- Indexes for table `patient_table`
--
ALTER TABLE `patient_table`
  ADD PRIMARY KEY (`autoid`);

--
-- Indexes for table `person_table`
--
ALTER TABLE `person_table`
  ADD PRIMARY KEY (`autoid`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `angel_table`
--
ALTER TABLE `angel_table`
  MODIFY `autoid` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `doctor_table`
--
ALTER TABLE `doctor_table`
  MODIFY `autoid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `patient_table`
--
ALTER TABLE `patient_table`
  MODIFY `autoid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `person_table`
--
ALTER TABLE `person_table`
  MODIFY `autoid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
