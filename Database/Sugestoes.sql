CREATE TABLE [dbo].[Sugestoes] (
    [Id]            INT           NOT NULL,
    [titulo]        VARCHAR (50)  NULL,
    [descricao]     VARCHAR (MAX) NULL,
    [Usuario_email] NVARCHAR (50) NOT NULL,
    [data_criacao]  DATETIME      NULL,
    CONSTRAINT [PK_Sugestoes] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_SugestoUsuario] FOREIGN KEY ([Usuario_email]) REFERENCES [dbo].[Usuarios] ([email]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_FK_SugestoUsuario]
    ON [dbo].[Sugestoes]([Usuario_email] ASC);

