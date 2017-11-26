
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/25/2017 22:59:16
-- Generated from EDMX file: C:\Users\l_ass\source\repos\utEventos\Modelo\DAO\EventoDAO.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [dbEventos];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Evento_Usuarios]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Eventoes] DROP CONSTRAINT [FK_Evento_Usuarios];
GO
IF OBJECT_ID(N'[dbo].[FK_FeedbackEvento]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Feedbacks] DROP CONSTRAINT [FK_FeedbackEvento];
GO
IF OBJECT_ID(N'[dbo].[FK_FeedbackUsuario]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Feedbacks] DROP CONSTRAINT [FK_FeedbackUsuario];
GO
IF OBJECT_ID(N'[dbo].[FK_SugestoEvento]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Sugestoes] DROP CONSTRAINT [FK_SugestoEvento];
GO
IF OBJECT_ID(N'[dbo].[FK_SugestoUsuario]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Sugestoes] DROP CONSTRAINT [FK_SugestoUsuario];
GO
IF OBJECT_ID(N'[dbo].[FK_CategoriaEvento]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Eventoes] DROP CONSTRAINT [FK_CategoriaEvento];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Eventoes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Eventoes];
GO
IF OBJECT_ID(N'[dbo].[Usuarios]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Usuarios];
GO
IF OBJECT_ID(N'[dbo].[Categorias]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Categorias];
GO
IF OBJECT_ID(N'[dbo].[Feedbacks]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Feedbacks];
GO
IF OBJECT_ID(N'[dbo].[Sugestoes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Sugestoes];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Eventoes'
CREATE TABLE [dbo].[Eventoes] (
    [Id] int  NOT NULL,
    [nome] varchar(50)  NOT NULL,
    [data_inicio] datetime  NOT NULL,
    [data_fim] datetime  NOT NULL,
    [escopo] nvarchar(20)  NOT NULL,
    [importante] bit  NOT NULL,
    [data_criacao] datetime  NULL,
    [criador] nvarchar(50)  NOT NULL,
    [Categoria_nome] varchar(50)  NOT NULL
);
GO

-- Creating table 'Usuarios'
CREATE TABLE [dbo].[Usuarios] (
    [nome] varchar(50)  NOT NULL,
    [email] nvarchar(50)  NOT NULL,
    [senha] varchar(50)  NOT NULL,
    [data_nascimento] datetime  NULL,
    [tipo] nvarchar(20)  NOT NULL
);
GO

-- Creating table 'Categorias'
CREATE TABLE [dbo].[Categorias] (
    [nome] varchar(50)  NOT NULL
);
GO

-- Creating table 'Feedbacks'
CREATE TABLE [dbo].[Feedbacks] (
    [Id] int  NOT NULL,
    [titulo] varchar(50)  NULL,
    [descricao] varchar(max)  NULL,
    [EventoId] int  NOT NULL,
    [Usuario_email] nvarchar(50)  NOT NULL,
    [data_criacao] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Sugestoes'
CREATE TABLE [dbo].[Sugestoes] (
    [Id] int  NOT NULL,
    [titulo] varchar(50)  NULL,
    [descricao] varchar(max)  NULL,
    [EventoId] int  NOT NULL,
    [Usuario_email] nvarchar(50)  NOT NULL,
    [data_criacao] datetime  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Eventoes'
ALTER TABLE [dbo].[Eventoes]
ADD CONSTRAINT [PK_Eventoes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [email] in table 'Usuarios'
ALTER TABLE [dbo].[Usuarios]
ADD CONSTRAINT [PK_Usuarios]
    PRIMARY KEY CLUSTERED ([email] ASC);
GO

-- Creating primary key on [nome] in table 'Categorias'
ALTER TABLE [dbo].[Categorias]
ADD CONSTRAINT [PK_Categorias]
    PRIMARY KEY CLUSTERED ([nome] ASC);
GO

-- Creating primary key on [Id] in table 'Feedbacks'
ALTER TABLE [dbo].[Feedbacks]
ADD CONSTRAINT [PK_Feedbacks]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Sugestoes'
ALTER TABLE [dbo].[Sugestoes]
ADD CONSTRAINT [PK_Sugestoes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [criador] in table 'Eventoes'
ALTER TABLE [dbo].[Eventoes]
ADD CONSTRAINT [FK_Evento_Usuarios]
    FOREIGN KEY ([criador])
    REFERENCES [dbo].[Usuarios]
        ([email])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Evento_Usuarios'
CREATE INDEX [IX_FK_Evento_Usuarios]
ON [dbo].[Eventoes]
    ([criador]);
GO

-- Creating foreign key on [EventoId] in table 'Feedbacks'
ALTER TABLE [dbo].[Feedbacks]
ADD CONSTRAINT [FK_FeedbackEvento]
    FOREIGN KEY ([EventoId])
    REFERENCES [dbo].[Eventoes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FeedbackEvento'
CREATE INDEX [IX_FK_FeedbackEvento]
ON [dbo].[Feedbacks]
    ([EventoId]);
GO

-- Creating foreign key on [Usuario_email] in table 'Feedbacks'
ALTER TABLE [dbo].[Feedbacks]
ADD CONSTRAINT [FK_FeedbackUsuario]
    FOREIGN KEY ([Usuario_email])
    REFERENCES [dbo].[Usuarios]
        ([email])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FeedbackUsuario'
CREATE INDEX [IX_FK_FeedbackUsuario]
ON [dbo].[Feedbacks]
    ([Usuario_email]);
GO

-- Creating foreign key on [EventoId] in table 'Sugestoes'
ALTER TABLE [dbo].[Sugestoes]
ADD CONSTRAINT [FK_SugestoEvento]
    FOREIGN KEY ([EventoId])
    REFERENCES [dbo].[Eventoes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SugestoEvento'
CREATE INDEX [IX_FK_SugestoEvento]
ON [dbo].[Sugestoes]
    ([EventoId]);
GO

-- Creating foreign key on [Usuario_email] in table 'Sugestoes'
ALTER TABLE [dbo].[Sugestoes]
ADD CONSTRAINT [FK_SugestoUsuario]
    FOREIGN KEY ([Usuario_email])
    REFERENCES [dbo].[Usuarios]
        ([email])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SugestoUsuario'
CREATE INDEX [IX_FK_SugestoUsuario]
ON [dbo].[Sugestoes]
    ([Usuario_email]);
GO

-- Creating foreign key on [Categoria_nome] in table 'Eventoes'
ALTER TABLE [dbo].[Eventoes]
ADD CONSTRAINT [FK_CategoriaEvento]
    FOREIGN KEY ([Categoria_nome])
    REFERENCES [dbo].[Categorias]
        ([nome])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CategoriaEvento'
CREATE INDEX [IX_FK_CategoriaEvento]
ON [dbo].[Eventoes]
    ([Categoria_nome]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------