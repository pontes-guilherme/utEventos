CREATE TABLE [dbo].[Eventoes] (
    [Id]              INT           NOT NULL,
    [nome]            VARCHAR (50)  NOT NULL,
    [data_inicio]     DATETIME      NOT NULL,
    [data_fim]        DATETIME      NOT NULL,
    [escopo]          NVARCHAR (20) NOT NULL,
    [importante]      BIT           NOT NULL,
    [data_criacao]    DATETIME      NULL,
    [criador]         NVARCHAR (50) NOT NULL,
    [Categoria_nome]  VARCHAR (50)  NOT NULL,
    [capacidade]      INT           NULL,
    [Disciplina_nome] VARCHAR (50)  NULL,
    CONSTRAINT [PK_Eventoes] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Evento_Usuarios] FOREIGN KEY ([criador]) REFERENCES [dbo].[Usuarios] ([email]),
    CONSTRAINT [FK_CategoriaEvento] FOREIGN KEY ([Categoria_nome]) REFERENCES [dbo].[Categorias] ([nome]) ON DELETE CASCADE,
    CONSTRAINT [FK_DisciplinaEvento] FOREIGN KEY ([Disciplina_nome]) REFERENCES [dbo].[Disciplinas] ([nome]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_FK_Evento_Usuarios]
    ON [dbo].[Eventoes]([criador] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_FK_CategoriaEvento]
    ON [dbo].[Eventoes]([Categoria_nome] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_FK_DisciplinaEvento]
    ON [dbo].[Eventoes]([Disciplina_nome] ASC);

CREATE TABLE [dbo].[Eventoes] (
    [Id]              INT           NOT NULL,
    [nome]            VARCHAR (50)  NOT NULL,
    [data_inicio]     DATETIME      NOT NULL,
    [data_fim]        DATETIME      NOT NULL,
    [escopo]          NVARCHAR (20) NOT NULL,
    [importante]      BIT           NOT NULL,
    [data_criacao]    DATETIME      NULL,
    [criador]         NVARCHAR (50) NOT NULL,
    [Categoria_nome]  VARCHAR (50)  NOT NULL,
    [capacidade]      INT           NULL,
    [Disciplina_nome] VARCHAR (50)  NULL,
    CONSTRAINT [PK_Eventoes] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Evento_Usuarios] FOREIGN KEY ([criador]) REFERENCES [dbo].[Usuarios] ([email]),
    CONSTRAINT [FK_CategoriaEvento] FOREIGN KEY ([Categoria_nome]) REFERENCES [dbo].[Categorias] ([nome]) ON DELETE CASCADE,
    CONSTRAINT [FK_DisciplinaEvento] FOREIGN KEY ([Disciplina_nome]) REFERENCES [dbo].[Disciplinas] ([nome]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_FK_Evento_Usuarios]
    ON [dbo].[Eventoes]([criador] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_FK_CategoriaEvento]
    ON [dbo].[Eventoes]([Categoria_nome] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_FK_DisciplinaEvento]
    ON [dbo].[Eventoes]([Disciplina_nome] ASC);

