CREATE TABLE [dbo].[Feedbacks]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [titulo] VARCHAR(50) NULL, 
    [descricao] TEXT NULL, 
    [data_criacao] DATETIME2 DEFAULT GETDATE(), 
    [EventoId] INT NOT NULL, 
    [Usuario_email] NVARCHAR(50) NOT NULL
)
