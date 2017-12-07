CREATE TABLE [dbo].[Inscricoes] (
    [Id]            INT           NOT NULL,
    [Usuario_email] NVARCHAR (50) NOT NULL,
    [EventoId]      INT           NOT NULL,
    CONSTRAINT [PK_Inscricoes] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_InscricaoUsuario] FOREIGN KEY ([Usuario_email]) REFERENCES [dbo].[Usuarios] ([email]) ON DELETE CASCADE,
    CONSTRAINT [FK_InscricaoEvento] FOREIGN KEY ([EventoId]) REFERENCES [dbo].[Eventoes] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_FK_InscricaoUsuario]
    ON [dbo].[Inscricoes]([Usuario_email] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_FK_InscricaoEvento]
    ON [dbo].[Inscricoes]([EventoId] ASC);

