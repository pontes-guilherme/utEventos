CREATE TABLE [dbo].[Checkin] (
    [Id]            INT           IDENTITY (1, 1) NOT NULL,
    [data_criacao]  DATETIME      NOT NULL,
    [EventoId]      INT           NOT NULL,
    [Usuario_email] NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Checkin] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_CheckinEvento] FOREIGN KEY ([EventoId]) REFERENCES [dbo].[Eventoes] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_CheckinUsuario] FOREIGN KEY ([Usuario_email]) REFERENCES [dbo].[Usuarios] ([email]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_FK_CheckinEvento]
    ON [dbo].[Checkin]([EventoId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_FK_CheckinUsuario]
    ON [dbo].[Checkin]([Usuario_email] ASC);

