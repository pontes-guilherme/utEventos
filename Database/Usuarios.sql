CREATE TABLE [dbo].[Usuarios] (
    [nome]            VARCHAR (50)  NOT NULL,
    [email]           NVARCHAR (50) NOT NULL,
    [senha]           VARCHAR (50)  NOT NULL,
    [data_nascimento] DATETIME      NULL,
    [tipo]            NVARCHAR (20) NOT NULL,
    CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED ([email] ASC)
);

