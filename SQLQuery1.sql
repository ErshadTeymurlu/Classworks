create database Company
use Company
create Table Workers
(
	ID int primary key IDENTITY(1,1),
	[Name] nvarchar(30),
	Surname nvarchar(30),
	TittleID int foreign key references Titles(ID),
	Salary int
)
create Table Titles
(
	ID int primary key IDENTITY(1,1),
	[Name] nvarchar(30)
)
create Table Filials
(
	ID int primary key IDENTITY(1,1),
	[Name] nvarchar(30)
)
create Table Products
(
	ID int primary key IDENTITY(1,1),
	[Name] nvarchar(30),
	BuyPrice int,
	SellPrice int
)
create Table Sales
(
	ID int primary key IDENTITY(1,1),
	[Name] nvarchar(30),
	WorkerID int foreign key references Workers(ID),
	ProductID int foreign key references Products(ID),
	SaleDate Date,
	FilialID int foreign key references Filials(ID)
)
--Query1:
select Workers.[Name],Workers.Surname, Workers. Salary, Titles.[Name], Products.[Name],Products.SellPrice, Products.BuyPrice,Filials.[Name]
from Sales join Workers on WorkerID = Workers.ID join Titles on Workers.TittleID = Titles.ID join Products on Sales.ProductID = Products.ID
join Filials on Sales.FilialID = Filials.ID
--Query2:
select sum(Products.SellPrice) 'All Sales' from Sales join Products on ProductID = Products.ID
--Query3:
select * from Sales where Month(SaleDate) = DATEPART(month,getdate()) 
--Query4:
