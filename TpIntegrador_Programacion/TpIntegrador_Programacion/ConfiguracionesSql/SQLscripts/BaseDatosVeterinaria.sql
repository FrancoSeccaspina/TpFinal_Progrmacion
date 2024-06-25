IF DB_ID('BaseDatosVeterinaria') IS NULL
BEGIN
    CREATE DATABASE BaseDatosVeterinaria;
END;

USE BaseDatosVeterinaria;

CREATE TABLE Usuarios (
    Id INT PRIMARY KEY IDENTITY,
    NickName VARCHAR(10) NOT NULL,
    Contra INT NOT NULL
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
    PesoPromedio DECIMAL(10,2) not null
);

CREATE TABLE Animales (
    ID INT PRIMARY KEY IDENTITY,
    Nombre NVARCHAR(100) not null,
    Peso DECIMAL(10,2) not null,
    Edad INT not null,
    IDCliente INT FOREIGN KEY REFERENCES Clientes(ID),
    IDEspecie INT FOREIGN KEY REFERENCES Especies(ID)
);


select * from Especies;
select * from Usuarios;
select * from Animales;
select * from Clientes;