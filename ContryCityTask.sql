create database CountryCityTask
use CountryCityTask
create table Countries
(
	ID int primary key IDENTITY(1,1),
	[Country Name] nvarchar(30),
	[President Name] nvarchar(30),
)
create table Cities
(
	ID int primary key IDENTITY(1,1),
	[CIty Name] nvarchar(30),
	[Population] nvarchar(30),
	lon int,
	lat int,
	CountryID int foreign key references Countries(ID)
)
alter view GetCountryAndCities
as
Select [CIty Name], [Country Name] from Cities join Countries on CountryID = Countries.ID

Select * from GetCountryAndCities

alter procedure GetCities @CountryName nvarchar(30)
as
Select [CIty Name],[Country Name] from Cities join Countries on CountryID = Countries.ID where [Country Name] = @CountryName  

exec GetCities 'Azerbaycan'