
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/25/2018 15:54:07
-- Generated from EDMX file: C:\Users\linlin\source\repos\WindowsFormsApp2\WindowsFormsApp2\Pmanagement.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Changlinfinal];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Instrumentprice]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[prices] DROP CONSTRAINT [FK_Instrumentprice];
GO
IF OBJECT_ID(N'[dbo].[FK_InstrumentTrade]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Trades] DROP CONSTRAINT [FK_InstrumentTrade];
GO
IF OBJECT_ID(N'[dbo].[FK_InstTypeInstrument]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Instruments] DROP CONSTRAINT [FK_InstTypeInstrument];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Instruments]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Instruments];
GO
IF OBJECT_ID(N'[dbo].[prices]', 'U') IS NOT NULL
    DROP TABLE [dbo].[prices];
GO
IF OBJECT_ID(N'[dbo].[InstTypes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[InstTypes];
GO
IF OBJECT_ID(N'[dbo].[Trades]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Trades];
GO
IF OBJECT_ID(N'[dbo].[InterestRates]', 'U') IS NOT NULL
    DROP TABLE [dbo].[InterestRates];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Instruments'
CREATE TABLE [dbo].[Instruments] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Companyname] nvarchar(max)  NULL,
    [Ticker] nvarchar(max)  NOT NULL,
    [Exchange] nvarchar(max)  NULL,
    [Underlying] nvarchar(max)  NULL,
    [Strick] float  NULL,
    [Tenor] float  NULL,
    [Iscall] bit  NULL,
    [Barrier] float  NULL,
    [Rebate] float  NULL,
    [BarrierType] nvarchar(max)  NULL,
    [InstTypeId] int  NOT NULL
);
GO

-- Creating table 'prices'
CREATE TABLE [dbo].[prices] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Date] datetime  NOT NULL,
    [ClosingPrice] float  NOT NULL,
    [InstrumentId] int  NOT NULL
);
GO

-- Creating table 'InstTypes'
CREATE TABLE [dbo].[InstTypes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [TypeName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Trades'
CREATE TABLE [dbo].[Trades] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [IsBuy] bit  NOT NULL,
    [Quantity] int  NOT NULL,
    [Price] float  NOT NULL,
    [Timestamp] datetime  NOT NULL,
    [InstrumentId] int  NOT NULL
);
GO

-- Creating table 'InterestRates'
CREATE TABLE [dbo].[InterestRates] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Tenor] float  NOT NULL,
    [Rate] float  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Instruments'
ALTER TABLE [dbo].[Instruments]
ADD CONSTRAINT [PK_Instruments]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'prices'
ALTER TABLE [dbo].[prices]
ADD CONSTRAINT [PK_prices]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'InstTypes'
ALTER TABLE [dbo].[InstTypes]
ADD CONSTRAINT [PK_InstTypes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Trades'
ALTER TABLE [dbo].[Trades]
ADD CONSTRAINT [PK_Trades]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'InterestRates'
ALTER TABLE [dbo].[InterestRates]
ADD CONSTRAINT [PK_InterestRates]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [InstrumentId] in table 'prices'
ALTER TABLE [dbo].[prices]
ADD CONSTRAINT [FK_Instrumentprice]
    FOREIGN KEY ([InstrumentId])
    REFERENCES [dbo].[Instruments]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Instrumentprice'
CREATE INDEX [IX_FK_Instrumentprice]
ON [dbo].[prices]
    ([InstrumentId]);
GO

-- Creating foreign key on [InstrumentId] in table 'Trades'
ALTER TABLE [dbo].[Trades]
ADD CONSTRAINT [FK_InstrumentTrade]
    FOREIGN KEY ([InstrumentId])
    REFERENCES [dbo].[Instruments]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_InstrumentTrade'
CREATE INDEX [IX_FK_InstrumentTrade]
ON [dbo].[Trades]
    ([InstrumentId]);
GO

-- Creating foreign key on [InstTypeId] in table 'Instruments'
ALTER TABLE [dbo].[Instruments]
ADD CONSTRAINT [FK_InstTypeInstrument]
    FOREIGN KEY ([InstTypeId])
    REFERENCES [dbo].[InstTypes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_InstTypeInstrument'
CREATE INDEX [IX_FK_InstTypeInstrument]
ON [dbo].[Instruments]
    ([InstTypeId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------