-- Create Database
CREATE DATABASE Logins;

--Create the Tables
--1. Login
CREATE TABLE Logins(
	IdUserName int IDENTITY(1,1),
	Username varchar(250), 
	PassName varchar(250)
)
--2. Profile
CREATE TABLE Profiles(
	IdUser int IDENTITY(1,1),
	ProfileName varchar(255), 
	DOB date,
	AddressName varchar(255),
	ProfilePhones varchar(20),
	Usernama varchar(250)
)
--3. Game List
CREATE TABLE GameList (
	IdGame int,
	GameName varchar(100),
	GameList varchar(500),
	GameCompany varchar(50)
)

--4. Game Prices
CREATE TABLE GamePrice (
	IdGameList int,
	PriceforGame money,
	GameTax money,
	TotalPrice money,
	includeTax bit
)

-- Insert sample user and Profiles
INSERT INTO Logins(Username,PassName)
VALUES('JenniXXX', 'J3nn1Sus')

INSERT INTO Profiles(ProfileName,DOB, AddressName, ProfilePhones)
VALUES('JenniTesting123', '26 June 1997','Jl. Angkasa 123, Jakarta','0910281920')