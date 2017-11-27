﻿CREATE TABLE [dbo].[Eventoes]
(
	[Id] INT NOT NULL, 
    [nome] VARCHAR(50) NOT NULL, 
    [data_inicio] DATE NOT NULL, 
    [data_fim] DATE NOT NULL, 
    [categoria] VARCHAR(50) NOT NULL, 
    [escopo] NVARCHAR(20) NOT NULL, 
    [importante] BIT NOT NULL, 
    [data_criacao] DATETIME2 DEFAULT GETDATE(), 
    [criador] NVARCHAR(50) NOT NULL, 
    [capacidade] INT NULL, 
    CONSTRAINT [FK_Evento_Usuarios] FOREIGN KEY ([criador]) REFERENCES [Usuarios]([email]), 
    CONSTRAINT [PK_Evento] PRIMARY KEY ([Id])
)
