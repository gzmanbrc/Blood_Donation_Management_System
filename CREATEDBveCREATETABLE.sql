CREATE DATABASE BloodBankDB 

USE BloodBankDB 

CREATE TABLE tblBloodGroup (
	ID INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	BloodGroup NVARCHAR(3) NOT NULL
);

CREATE TABLE tblBlood (
	ID INT Primary Key NOT NULL IDENTITY(1,1),
	BloodGroupID INT NOT NULL,
	BloodStock INT NOT NULL DEFAULT 0,
	FOREIGN KEY (BloodGroupID) REFERENCES tblBloodGroup(ID)
);

CREATE TABLE tblGender (
	ID INT Primary Key NOT NULL IDENTITY(1,1),
	Gender NVARCHAR(10) NULL
);

CREATE TABLE tblEmployee (
	ID INT Primary Key NOT NULL IDENTITY(1,1),
	EmployeeName NVARCHAR(100) NOT NULL,
	EmployeePassword NVARCHAR(50) NOT NULL,
	EmployeeStatus BIT NULL DEFAULT 1
);

CREATE TABLE tblDonor (
	ID INT Primary Key NOT NULL IDENTITY(1,1),
	DonorBloodGroupID INT NOT NULL,
	DonorGenderID INT NOT NULL,
	DonorName NVARCHAR(50) NOT NULL,
	DonorAge INT NOT NULL,
	DonorPhone NVARCHAR(11) NOT NULL,
	DonorAddress TEXT NOT NULL,
	DonorStatus BIT NULL DEFAULT 1,
	FOREIGN KEY (DonorBloodGroupID) REFERENCES tblBloodGroup(ID),
	FOREIGN KEY (DonorGenderID) REFERENCES tblGender(ID)
);

CREATE TABLE tblPatient (
	ID INT Primary Key NOT NULL IDENTITY(1,1),
	PatientGenderID INT NOT NULL,
	PatientBloodGroupID INT NOT NULL,
	PatientName NVARCHAR(50) NOT NULL,
	PatientAge INT NOT NULL,
	PatientPhone NVARCHAR(11) NOT NULL,
	PatientAddress TEXT NOT NULL,
	PatientStatus BIT NULL DEFAULT 1
	FOREIGN KEY (PatientGenderID) REFERENCES tblGender(ID),
	FOREIGN KEY (PatientBloodGroupID) REFERENCES tblBloodGroup(ID),
);

CREATE TABLE tblTransfer (
	ID INT Primary Key NOT NULL IDENTITY(1,1),
	TransferDonorID INT NOT NULL,
	TransferBloodGroupID INT NOT NULL,
	TransferBloodAmount INT NOT NULL,
	TransferDate DATETIME NULL,
	TrasnferStatus BIT NULL DEFAULT 1
	FOREIGN KEY (TransferDonorID) REFERENCES tblDonor(ID),
	FOREIGN KEY (TransferBloodGroupID) REFERENCES tblBloodGroup(ID)
);