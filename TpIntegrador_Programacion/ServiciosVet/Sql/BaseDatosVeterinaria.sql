CREATE DATABASE BaseDatosVeterinaria;
GO

USE BaseDatosVeterinaria;
GO

CREATE TABLE Usuarios (
    Id INT PRIMARY KEY IDENTITY(1,1),
    NickName VARCHAR(10) NOT NULL,
    Contra INT NOT NULL
);
GO