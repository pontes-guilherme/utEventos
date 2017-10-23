CREATE TABLE [dbo].[Usuarios] (
    [nome]            VARCHAR (50) NOT NULL,
    [email]           NVARCHAR(50) NOT NULL,
    [senha]           VARCHAR (50) NOT NULL,
    [data_nascimento] DATE         NULL,
    PRIMARY KEY CLUSTERED ([email])
);

