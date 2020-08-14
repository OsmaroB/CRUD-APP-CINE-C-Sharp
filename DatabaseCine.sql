create database Blockbuster
go
use Blockbuster

CREATE TABLE Generos(
idGenero int not null identity primary key,
nombreGenero varchar(30) not null
)
CREATE TABLE Interpretes(
idInterprete int not null identity primary key,
nombre varchar(50) not null,
apellido varchar(50) not null,
nacionalidad varchar(50) not null
)
CREATE TABLE Peliculas(
idPelicula char(4) not null  primary key,
nombrePelicula varchar(60) not null,
director varchar(50) not null,
anio int not null,
idGenero int not null foreign key references Generos(idGenero),

)
CREATE TABLE Protagonistas(
idPelicula char(4) not null foreign key references Peliculas(idPelicula)ON DELETE CASCADE,
idInterprete int not null foreign key references Interpretes(idInterprete) 
)
ALTER TABLE Peliculas
add constraint ckAnio CHECK (anio >1850) 
ALTER TABLE  Peliculas 
ADD CONSTRAINT CHK_SUSTANTIVOS CHECK ( idPelicula like '[A-Z][A-Z][0-9][0-9]' );
GO

INSERT INTO Generos VALUES('Accion'),('Suspenso')
INSERT INTO Interpretes VALUES('Leonardo','Dicaprio','EEUU'),('Zack','Efron','EEUU'),('Emma','Wattson','England')
INSERT INTO Peliculas VALUES('TI01','Titanic','James Cameron',1997,2),('EN02','El nombre','James ',2019,1),('EN03','El nombre 2','James ',2019,1)
INSERT INTO Protagonistas VALUES('TI01',1),('EN02',2),('EN02',3)

UPDATE Peliculas set nombrePelicula = '' , director = '', anio = 1999, idGenero = 2 WHERE idPelicula = 'EN02'
SELECT idPelicula, nombrePelicula, director,anio,G.nombreGenero FROM Peliculas P INNER JOIN Generos G ON G.idGenero = P.idGenero
SELECT idPelicula, nombrePelicula, director,anio,idGenero FROM Peliculas WHERE idPelicula = 'EN02'
SELECT idPelicula, nombrePelicula, director,anio,G.nombreGenero FROM Peliculas P INNER JOIN Generos G ON G.idGenero = P.idGenero WHERE nombrePelicula LIKE '%Ti%'
SELECT idGenero,nombreGenero FROM Generos

DELETE Peliculas WHERE idPelicula = ''