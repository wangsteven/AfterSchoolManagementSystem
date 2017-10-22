--
-- 由SQLiteStudio v3.1.1 产生的文件 周日 十月 8 00:33:32 2017
--
-- 文本编码：System
--
PRAGMA foreign_keys = off;
BEGIN TRANSACTION;

-- 表：carerecord
DROP TABLE IF EXISTS carerecord;

CREATE TABLE carerecord (
    carerecordId   INT (11)     NOT NULL,
    carerecordDate DATE         DEFAULT NULL,
    afternoonTea   TINYINT (4)  DEFAULT NULL,
    supper         TINYINT (4)  DEFAULT NULL,
    outcare        TINYINT (4)  DEFAULT NULL,
    signature      VARCHAR (45) DEFAULT NULL,
    checkinTime    VARCHAR (45) DEFAULT NULL,
    checkoutTime   VARCHAR (45) DEFAULT NULL,
    description    VARCHAR (45) DEFAULT NULL,
    PRIMARY KEY (
        carerecordId
    )
);


-- 表：carereservation
DROP TABLE IF EXISTS carereservation;

CREATE TABLE carereservation (
    careReservationId INTEGER       PRIMARY KEY
                                    NOT NULL,
    studentId         INTEGER,
    weekday           INTEGER,
    startTime         DATETIME,
    endTime           DATETIME,
    startLocation     VARCHAR (64),
    recuring          BOOLEAN,
    breakfast         INTEGER,
    morningTea        INTEGER,
    lunch             INTEGER,
    afternoonTea      INTEGER,
    supper            INTEGER,
    outcare           BOOLEAN,
    description       VARCHAR (128) 
);

-- 表：currentCareReservation
DROP TABLE IF EXISTS currentCareReservation;
CREATE TABLE currentCareReservation (
    reservationSeqId INTEGER,
    weekday          INT,
    reservationDate  DATETIME,
    studentId        INTEGER,
    name             VARCHAR (64),
    grade            INTEGER,
    classGroup       INTEGER,
    school           VARCHAR (64),
    schoolTeacher    VARCHAR (128),
    guardian         VARCHAR (128),
    startLocation    VARCHAR (64),
    startTime        VARCHAR (10),
    endTime          VARCHAR (10),
    breakfast        BOOLEAN,
    morningTea       BOOLEAN,
    lunch            BOOLEAN,
    afternoonTea     INTEGER,
    supper           INTEGER,
    outcare          BOOLEAN,
    description      VARCHAR (128) 
);


-- 表：course
DROP TABLE IF EXISTS course;

CREATE TABLE course (
    courseId     INT (11)        NOT NULL,
    teacherId    VARCHAR (45)    DEFAULT NULL,
    name         VARCHAR (64)    DEFAULT NULL,
    courseLength INT (11)        DEFAULT NULL,
    weekday      INT (11)        DEFAULT NULL,
    startTime    DATETIME        DEFAULT NULL,
    location     VARCHAR (64)    DEFAULT NULL,
    price        DECIMAL (10, 0) DEFAULT NULL,
    description  VARCHAR (256)   DEFAULT NULL,
    PRIMARY KEY (
        courseId
    )
);


-- 表：coursepayments
DROP TABLE IF EXISTS coursepayments;

CREATE TABLE coursepayments (
    paymentId             INT (11)        NOT NULL,
    receiptId             VARCHAR (45)    DEFAULT NULL,
    studentId             INT (11)        DEFAULT NULL,
    payDate               DATE            DEFAULT NULL,
    paymentMethodName     VARCHAR (45)    DEFAULT NULL,
    customerNameOnPayment VARCHAR (45)    DEFAULT NULL,
    amount                DECIMAL (10, 0) DEFAULT NULL,
    paymentImg            BLOB,
    PRIMARY KEY (
        paymentId
    )
);


-- 表：coursestudentattendance
DROP TABLE IF EXISTS coursestudentattendance;

CREATE TABLE coursestudentattendance (
    courseAttendanceId   INT (11)     NOT NULL,
    courseAttendanceDate DATE         DEFAULT NULL,
    courseId             INT (11)     DEFAULT NULL,
    studentId            INT (11)     DEFAULT NULL,
    description          VARCHAR (64) DEFAULT NULL,
    PRIMARY KEY (
        courseAttendanceId
    )
);


-- 表：student
DROP TABLE IF EXISTS student;

CREATE TABLE student (
    studentId     INT (11)      NOT NULL,
    contactId     VARCHAR (16)  DEFAULT NULL,
    name          VARCHAR (64)  DEFAULT NULL,
    gender        VARCHAR (10)  DEFAULT M,
    school        VARCHAR (64)  DEFAULT NULL,
    grade         INT (11)      DEFAULT NULL,
    classGroup    INT (11)      DEFAULT NULL,
    schoolTeacher VARCHAR (128) DEFAULT NULL,
    guardian      VARCHAR (128) DEFAULT NULL,
    birthday      DATETIME      DEFAULT NULL,
    allergies     VARCHAR (256) DEFAULT NULL,
    favorite      VARCHAR (256) DEFAULT NULL,
    regDate       DATETIME      DEFAULT NULL,
    description   VARCHAR (256) DEFAULT NULL,
    picture       VARCHAR (256) DEFAULT NULL,
    active        INT (11)      DEFAULT NULL,
    PRIMARY KEY (
        studentId
    )
);


-- 表：teacher
DROP TABLE IF EXISTS teacher;

CREATE TABLE teacher (
    teacherId   INT (11)      NOT NULL,
    name        VARCHAR (64)  DEFAULT NULL,
    gender      VARCHAR (10)  DEFAULT F,
    birthday    DATETIME      DEFAULT NULL,
    phoneNumber VARCHAR (64)  DEFAULT NULL,
    email       VARCHAR (64)  DEFAULT NULL,
    address     VARCHAR (128) DEFAULT NULL,
    profession  VARCHAR (64)  DEFAULT NULL,
    regDate     DATETIME      DEFAULT NULL,
    description VARCHAR (256) DEFAULT NULL,
    active      TINYINT (4)   DEFAULT NULL,
    PRIMARY KEY (
        teacherId
    )
);


-- 表：teacherattendace
DROP TABLE IF EXISTS teacherattendace;

CREATE TABLE teacherattendace (
    teacherattendaceId INT (11)     NOT NULL,
    checkintime        DATETIME     DEFAULT NULL,
    checkouttime       DATETIME     DEFAULT NULL,
    description        VARCHAR (45) DEFAULT NULL,
    PRIMARY KEY (
        teacherattendaceId
    )
);

CREATE VIEW reservationView AS
    SELECT careReservation.weekday,
           student.studentId,
           student.name,
           student.grade,
           student.classGroup,
           student.school,
           student.schoolTeacher,
           student.guardian,
           careReservation.startLocation,
           careReservation.startTime,
           careReservation.endTime,
           careReservation.breakfast,
           careReservation.morningTea,
           careReservation.lunch,
           careReservation.afternoonTea,
           careReservation.supper,
           careReservation.outcare,
           careReservation.description
      FROM student
           LEFT JOIN
           careReservation ON student.studentId = careReservation.studentId
     WHERE student.active = 1;



COMMIT TRANSACTION;
PRAGMA foreign_keys = on;
