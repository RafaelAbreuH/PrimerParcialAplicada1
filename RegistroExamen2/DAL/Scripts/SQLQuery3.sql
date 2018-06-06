CREATE DATABASE GruposDb
GO
USE GruposDb
GO
CREATE TABLE Grupos
(
	GrupoId int primary key identity(1,1),
	Fecha datetime,
	Descripcion varchar(40),
	Cantidad int,
	Grupos int,
	Integrantes int

);