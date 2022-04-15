create database Movie
use Movie
create table Genre
(
	ID int primary key IDENTITY,
	[Name] nvarchar(30)
)
create table Film
(
	ID int primary key IDENTITY,
	[Name] nvarchar(30),
	ReleaseDate Date,
	Raiting int
)
create table GenreToFilm
(
	ID int primary key IDENTITY,
	GenreID int foreign key references Genre(ID),
	FilmID int foreign key references Film(ID)
)
create table Actors
(
	ID int primary key IDENTITY,
	[Name] nvarchar(30),
	Surname nvarchar(30)
)
create table FilmToActors
(
	ID int primary key IDENTITY,
	FilmID int references Film(ID),
	ActorID int references Actors(ID)
)
insert into Film values('Interstellar','2022-04-15',9),('Harry Poter','2022-04-15',4),('Selfless','2022-04-15',9),('Sherlock Holmes','2022-04-15',8)
insert into Actors values  ('Ebulfez','Sadiqov'), ('Elshad','Ehmedov'), ('Ebulfez2','Sadiqov2')
insert into Genre values  ('Dram'),('Horror'),('Secret'),('Fantastic')

insert into FilmToActors (FilmID,ActorID) values (1,1),(2,2),(3,3),(2,3),(3,2),(1,2),(4,1),(2,3)

select * from Actors
select * from Film
select * from Genre

select Film.[Name] 'Movie', Actors.Name + ' ' +Actors.Surname 'Actor' from FilmToActors 
join Actors 
on ActorID = Actors.ID 
join Film 
on FilmID = Film.ID
join GenreToFilm
on GenreToFilm.FilmID =Film.ID 
join Genre 
on GenreToFilm.GenreID =Genre.ID 
