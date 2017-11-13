
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/12/2017 21:35:30
-- Generated from EDMX file: C:\Users\Guilherme Pontes\Source\Repos\utEventos\Modelo\DAO\EventoDAO.edmx
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
IF OBJECT_ID(N'[dbo].[FK_EventoCategoria]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Eventoes] DROP CONSTRAINT [FK_EventoCategoria];
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

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Eventoes'
CREATE TABLE [dbo].[Eventoes] (
    [Id] int  NOT NULL,
    [nome] varchar(50)  NOT NULL,
    [data_inicio] datetime  NOT NULL,
    [data_fim] datetime  NOT NULL,
    [categoria] nvarchar(50)  NOT NULL,
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

-- Creating foreign key on [Categoria_nome] in table 'Eventoes'
ALTER TABLE [dbo].[Eventoes]
ADD CONSTRAINT [FK_EventoCategoria]
    FOREIGN KEY ([Categoria_nome])
    REFERENCES [dbo].[Categorias]
        ([nome])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EventoCategoria'
CREATE INDEX [IX_FK_EventoCategoria]
ON [dbo].[Eventoes]
    ([Categoria_nome]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------