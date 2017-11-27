CREATE TABLE [dbo].[Inscricoes]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Evento] INT NOT NULL, 
    [Usuario] NVARCHAR(50) NOT NULL, 
    CONSTRAINT [FK_Inscricoes_Eventos] FOREIGN KEY ([Evento]) REFERENCES [Eventoes]([Id]), 
    CONSTRAINT [FK_Inscricoes_Usuarios] FOREIGN KEY ([Usuario]) REFERENCES [Usuarios]([email])
)
