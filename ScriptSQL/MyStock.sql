CREATE DATABASE MyStock
GO

USE MyStock
GO

CREATE TABLE Cars
(
	CarID int PRIMARY KEY,
	CarName varchar(50) NOT NULL,
	Manufacturer varchar(50) NOT NULL,
	Price money NOT NULL,
	ReleasedYear int NOT NULL,
)
GO

INSERT INTO Cars VALUES(1,'Accord', 'Honda Motor Company', 24970, 2021)
INSERT INTO Cars VALUES(3,'Clarity', 'Honda Motor Company', 33400, 2021)
INSERT INTO Cars VALUES(4,'BMW 8 Series', 'BMW', 85000, 2021)
INSERT INTO Cars VALUES(5,'Audi A6', 'Audi', 14000, 2020)
GO