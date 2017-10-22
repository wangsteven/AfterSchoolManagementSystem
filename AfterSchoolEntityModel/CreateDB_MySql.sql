CREATE DATABASE `afterschool` /*!40100 DEFAULT CHARACTER SET utf8 */;

show databases;

use  `afterschool`;

CREATE TABLE `student` (
  `studentId` int(11) NOT NULL,
  `contactId` varchar(16) DEFAULT NULL,
  `name` varchar(64) DEFAULT NULL,
  `gender` enum('M','F') DEFAULT 'M',
  `school` varchar(64) DEFAULT NULL,
  `grade` int(11) DEFAULT NULL,
  `classGroup` int(11) DEFAULT NULL,
  `schoolTeacher` varchar(128) DEFAULT NULL,
  `guardian` varchar(128) DEFAULT NULL,
  `birthday` datetime DEFAULT NULL,
  `allergies` varchar(256) DEFAULT NULL,
  `favorite` varchar(256) DEFAULT NULL,
  `regDate` datetime DEFAULT NULL,
  `description` varchar(256) DEFAULT NULL,
  `picture` varchar(256) DEFAULT NULL,
  `active` int(11) DEFAULT NULL,
  PRIMARY KEY (`studentId`)
)  DEFAULT CHARSET=utf8;

CREATE TABLE `teacher` (
  `teacherId` int(11) NOT NULL,
  `name` varchar(64) DEFAULT NULL,
  `gender` enum('M','F') DEFAULT 'F',
  `birthday` datetime DEFAULT NULL,
  `phoneNumber` varchar(64) DEFAULT NULL,
  `email` varchar(64) DEFAULT NULL,
  `address` varchar(128) DEFAULT NULL,
  `profession` varchar(64) DEFAULT NULL,
  `regDate` datetime DEFAULT NULL,
  `description` varchar(256) DEFAULT NULL,
  `active` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`teacherId`)
)  DEFAULT CHARSET=utf8;

CREATE TABLE `teacherattendace` (
  `teacherattendaceId` int(11) NOT NULL,
  `checkintime` datetime DEFAULT NULL,
  `checkouttime` datetime DEFAULT NULL,
  `description` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`teacherattendaceId`)
) DEFAULT CHARSET=utf8;


CREATE TABLE `course` (
  `courseId` int(11) NOT NULL,
  `teacherId` varchar(45) DEFAULT NULL,
  `name` varchar(64) DEFAULT NULL,
  `courseLength` int(11) DEFAULT NULL,
  `weekday` int(11) DEFAULT NULL,
  `startTime` datetime DEFAULT NULL,
  `location` varchar(64) DEFAULT NULL,
  `price` decimal(10,0) DEFAULT NULL,
  `description` varchar(256) DEFAULT NULL,
  PRIMARY KEY (`courseId`)
)  DEFAULT CHARSET=utf8;

CREATE TABLE `coursestudentattendance` (
  `courseAttendanceId` int(11) NOT NULL,
  `courseAttendanceDate` date DEFAULT NULL,
  `courseId` int(11) DEFAULT NULL,
  `studentId` int(11) DEFAULT NULL,
  `description` varchar(64) DEFAULT NULL,
  PRIMARY KEY (`courseAttendanceId`)
) DEFAULT CHARSET=utf8;

CREATE TABLE `coursepayments` (
  `paymentId` int(11) NOT NULL,
  `receiptId` varchar(45) DEFAULT NULL,
  `studentId` int(11) DEFAULT NULL,
  `payDate` date DEFAULT NULL,
  `paymentMethodName` varchar(45) DEFAULT NULL,
  `customerNameOnPayment` varchar(45) DEFAULT NULL,
  `amount` decimal(10,0) DEFAULT NULL,
  `paymentImg` blob,
  PRIMARY KEY (`paymentId`)
) DEFAULT CHARSET=utf8;

CREATE TABLE `carereservation` (
  `careReservationId` int(11) NOT NULL,
  `studentId` int(11) DEFAULT NULL,
  `weekday` int(11) DEFAULT NULL,
  `startTime` varchar(45) DEFAULT NULL,
  `startLocation` varchar(45) DEFAULT NULL,
  `recuring` tinyint(4) DEFAULT NULL,
  `afternoonTea` tinyint(4) DEFAULT NULL,
  `supper` tinyint(4) DEFAULT NULL,
  `outcare` tinyint(4) DEFAULT NULL,
  `description` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`careReservationId`)
) DEFAULT CHARSET=utf8;

CREATE TABLE `carerecord` (
  `carerecordId` int(11) NOT NULL,
  `carerecordDate` date DEFAULT NULL,
  `afternoonTea` tinyint(4) DEFAULT NULL,
  `supper` tinyint(4) DEFAULT NULL,
  `outcare` tinyint(4) DEFAULT NULL,
  `signature` varchar(45) DEFAULT NULL,
  `checkinTime` varchar(45) DEFAULT NULL,
  `checkoutTime` varchar(45) DEFAULT NULL,
  `description` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`carerecordId`)
) DEFAULT CHARSET=utf8;



