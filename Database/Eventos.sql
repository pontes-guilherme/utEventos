CREATE TABLE [dbo].[Evento]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [nome] VARCHAR(50) NOT NULL, 
    [data_inicio] DATE NOT NULL, 
    [data_fim] DATE NOT NULL, 
    [categoria] NVARCHAR(50) NOT NULL, 
    [escopo] NVARCHAR(20) NOT NULL, 
    [importante] BIT NOT NULL, 
    [data_criacao] DATE NOT NULL, 
    [criador] NVARCHAR(50) NOT NULL, 
    CONSTRAINT [FK_Evento_Usuarios] FOREIGN KEY ([criador]) REFERENCES [Usuarios]([email])
)
