CREATE TABLE [dbo].[Eventoes] (
    [Id]           INT           NOT NULL,
    [nome]         VARCHAR (50)  NOT NULL,
    [capacidade]   INT           NULL,
    [escopo]       NVARCHAR (20) NOT NULL,
    [data_inicio]  DATE          NOT NULL,
    [data_fim]     DATE          NOT NULL,
    [importante]   BIT           NOT NULL,
    [data_criacao] DATETIME2 (7) DEFAULT (getdate()) NULL,
    [criador]      NVARCHAR (50) NOT NULL,
    [Categoria_nome] NVARCHAR(50) NOT NULL, 
    [Disciplina_nome] NVARCHAR(50) NULL, 
    CONSTRAINT [PK_Evento] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Evento_Usuarios] FOREIGN KEY ([criador]) REFERENCES [dbo].[Usuarios] ([email])
);

