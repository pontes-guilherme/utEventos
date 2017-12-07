CREATE TABLE [dbo].[Feedbacks] (
    [Id]            INT           NOT NULL,
    [titulo]        VARCHAR (50)  NULL,
    [descricao]     VARCHAR (MAX) NULL,
    [EventoId]      INT           NOT NULL,
    [Usuario_email] NVARCHAR (50) NOT NULL,
    [data_criacao]  DATETIME      NOT NULL,
    CONSTRAINT [PK_Feedbacks] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_FeedbackEvento] FOREIGN KEY ([EventoId]) REFERENCES [dbo].[Eventoes] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_FeedbackUsuario] FOREIGN KEY ([Usuario_email]) REFERENCES [dbo].[Usuarios] ([email]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_FK_FeedbackEvento]
    ON [dbo].[Feedbacks]([EventoId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_FK_FeedbackUsuario]
    ON [dbo].[Feedbacks]([Usuario_email] ASC);

