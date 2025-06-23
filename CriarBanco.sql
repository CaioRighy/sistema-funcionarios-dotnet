CREATE DATABASE SistemaFuncionarios;
GO

USE SistemaFuncionarios;
GO

CREATE TABLE Profissionais (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nome NVARCHAR(100) NOT NULL,
    Telefone NVARCHAR(20),
    RG NVARCHAR(20),
    Endereco NVARCHAR(150),
    Salario DECIMAL(18,2)
);
