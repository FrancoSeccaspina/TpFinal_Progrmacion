IF DB_ID('BaseDatosVeterinaria') IS NULL
BEGIN
    CREATE DATABASE BaseDatosVeterinaria;
END;

USE BaseDatosVeterinaria;

CREATE TABLE Usuarios (
    Id INT PRIMARY KEY IDENTITY,
    NickName VARCHAR(20) NOT NULL,
    Contranueva VARCHAR(20) NOT NULL,
);

CREATE TABLE Clientes (
    ID INT PRIMARY KEY IDENTITY,
    DNI NVARCHAR(20) NOT NULL,
    Nombre NVARCHAR(100) NOT NULL
	--Columna posible Activa Descativado
);

CREATE TABLE Especies (
    ID INT PRIMARY KEY IDENTITY,
    Nombre NVARCHAR(100) not null,
    EdadMadurez INT not null,
    PesoPromedio DECIMAL(5,2) not null
);


CREATE TABLE Animales (
    ID INT PRIMARY KEY IDENTITY,
    Nombre NVARCHAR(100) not null,
    Peso DECIMAL(3,2) not null,
    Edad INT not null,
    NombreCliente NVARCHAR(100),
    NombreEspecie NVARCHAR(100)
);

INSERT INTO Usuarios (NickName, Contranueva)
SELECT 'admin', '123'
WHERE NOT EXISTS (
    SELECT 1 FROM Usuarios WHERE NickName = 'admin'
);

ALTER TABLE Especies
ALTER COLUMN PesoPromedio DECIMAL(5,2) NOT NULL;

ALTER TABLE Especies
ADD DadoDeBaja BIT NOT NULL DEFAULT 0;

ALTER TABLE Usuarios
ADD DadoDeBaja BIT NOT NULL DEFAULT 0;

ALTER TABLE Clientes
ADD DadoDeBaja BIT NOT NULL DEFAULT 0;

ALTER TABLE Animales
ADD DadoDeBaja BIT NOT NULL DEFAULT 0;

select * from Animales

INSERT INTO Animales (Nombre, Peso, Edad, NombreCliente, NombreEspecie)
VALUES ('Firulais', 5.50, 3, 'Juan Pérez', 'Perro');

ALTER TABLE Animales
ALTER COLUMN Peso DECIMAL(10,2) NOT NULL;
