
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/17/2021 08:44:45
-- Generated from EDMX file: D:\TrendSpa\MVC8amTigerBatch_09_07_2021\ModelFirstApproach\Models\EmployeeModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [VTSRMDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'EmployeeModels'
CREATE TABLE [dbo].[EmployeeModels] (
    [EmpId] int IDENTITY(1,1) NOT NULL,
    [EmpName] nvarchar(max)  NOT NULL,
    [EmpSalary] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [EmpId] in table 'EmployeeModels'
ALTER TABLE [dbo].[EmployeeModels]
ADD CONSTRAINT [PK_EmployeeModels]
    PRIMARY KEY CLUSTERED ([EmpId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------