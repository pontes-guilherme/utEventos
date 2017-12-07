CREATE TABLE [dbo].[Inscricoes]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [EventoId] INT NOT NULL, 
    [Usuario_email] NVARCHAR(50) NOT NULL, 
    CONSTRAINT [FK_Inscricoes_Eventos] FOREIGN KEY ([EventoId]) REFERENCES [Eventoes]([Id]), 
    CONSTRAINT [FK_Inscricoes_Usuarios] FOREIGN KEY ([Usuario_email]) REFERENCES [Usuarios]([email])
)
