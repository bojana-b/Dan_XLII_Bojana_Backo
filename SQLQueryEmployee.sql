CREATE DATABASE Employee;
GO

use Employee;

DROP TABLE IF EXISTS tblEmployee;

CREATE TABLE tblEmployee (
	NameSurname nvarchar(50),
	DateOfBirth datetime,
	CardID int,
	JMBG nvarchar(13) PRIMARY KEY,
	Gender nvarchar(5),
	Phone nvarchar(10),
	Sector nvarchar(15),
	Location nvarchar(15),
	Manager nvarchar(50)
)