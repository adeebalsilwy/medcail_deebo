
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/23/2023 23:51:48
-- Generated from EDMX file: D:\مشاريعي المهمه\العياده الطبيه\medcail_deebo\medcail_deebo\db\medcil_midel.edmx
-- --------------------------------------------------
create database CLINIC_DATABASE_2020;
SET QUOTED_IDENTIFIER OFF;
GO
USE [CLINIC_DATABASE_2020];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_APO_BDOCTORS_TBL]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[APO_TBL] DROP CONSTRAINT [FK_APO_BDOCTORS_TBL];
GO
IF OBJECT_ID(N'[dbo].[FK_APO_TBL_CLINC_TBL]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[APO_TBL] DROP CONSTRAINT [FK_APO_TBL_CLINC_TBL];
GO
IF OBJECT_ID(N'[dbo].[FK_APO_TBL_CUST_TBL]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[APO_TBL] DROP CONSTRAINT [FK_APO_TBL_CUST_TBL];
GO
IF OBJECT_ID(N'[dbo].[FK_CARD_TBL_CLINC_TBL]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CARD_TBL] DROP CONSTRAINT [FK_CARD_TBL_CLINC_TBL];
GO
IF OBJECT_ID(N'[dbo].[FK_CARD_TBL_COMPANY_TBL]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CARD_TBL] DROP CONSTRAINT [FK_CARD_TBL_COMPANY_TBL];
GO
IF OBJECT_ID(N'[dbo].[FK_COMPANY_TBL_CLINC_TBL]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[COMPANY_TBL] DROP CONSTRAINT [FK_COMPANY_TBL_CLINC_TBL];
GO
IF OBJECT_ID(N'[dbo].[FK_CUST_TBL_CARD_TBL]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CUST_TBL] DROP CONSTRAINT [FK_CUST_TBL_CARD_TBL];
GO
IF OBJECT_ID(N'[dbo].[FK_CUST_TBL_CLINC_TBL]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CUST_TBL] DROP CONSTRAINT [FK_CUST_TBL_CLINC_TBL];
GO
IF OBJECT_ID(N'[dbo].[FK_DIAGNOIS_TBL_CLINC_TBL]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DIAGNOIS_TBL] DROP CONSTRAINT [FK_DIAGNOIS_TBL_CLINC_TBL];
GO
IF OBJECT_ID(N'[dbo].[FK_DIGLIST_TBL_CLINC_TBL]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DIGLIST_TBL] DROP CONSTRAINT [FK_DIGLIST_TBL_CLINC_TBL];
GO
IF OBJECT_ID(N'[dbo].[FK_DIGLIST_TBL_DIAGNOIS_TBL]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DIGLIST_TBL] DROP CONSTRAINT [FK_DIGLIST_TBL_DIAGNOIS_TBL];
GO
IF OBJECT_ID(N'[dbo].[FK_DIGLIST_TBL_VISIT_TBL]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DIGLIST_TBL] DROP CONSTRAINT [FK_DIGLIST_TBL_VISIT_TBL];
GO
IF OBJECT_ID(N'[dbo].[FK_DOCTORS_TBL_CLINC_TBL]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DOCTORS_TBL] DROP CONSTRAINT [FK_DOCTORS_TBL_CLINC_TBL];
GO
IF OBJECT_ID(N'[dbo].[FK_DOS_TBL_CLINC_TBL]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DOS_TBL] DROP CONSTRAINT [FK_DOS_TBL_CLINC_TBL];
GO
IF OBJECT_ID(N'[dbo].[FK_MEDCHEK_TBL_CLINC_TBL]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MEDCHEK_TBL] DROP CONSTRAINT [FK_MEDCHEK_TBL_CLINC_TBL];
GO
IF OBJECT_ID(N'[dbo].[FK_MEDCIN_TBL_CLINC_TBL]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MEDCIN_TBL] DROP CONSTRAINT [FK_MEDCIN_TBL_CLINC_TBL];
GO
IF OBJECT_ID(N'[dbo].[FK_MEDLIST_TBL_CUST_TBL]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MEDLIST_TBL] DROP CONSTRAINT [FK_MEDLIST_TBL_CUST_TBL];
GO
IF OBJECT_ID(N'[dbo].[FK_MEDLIST_TBL_DOS_TBL]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MEDLIST_TBL] DROP CONSTRAINT [FK_MEDLIST_TBL_DOS_TBL];
GO
IF OBJECT_ID(N'[dbo].[FK_MEDLIST_TBL_MEDCIN_TBL]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MEDLIST_TBL] DROP CONSTRAINT [FK_MEDLIST_TBL_MEDCIN_TBL];
GO
IF OBJECT_ID(N'[dbo].[FK_MEDREQ_TBL_CLINC_TBL]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MEDREQ_TBL] DROP CONSTRAINT [FK_MEDREQ_TBL_CLINC_TBL];
GO
IF OBJECT_ID(N'[dbo].[FK_MEDREQ_TBL_MEDCHEK_TBL]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MEDREQ_TBL] DROP CONSTRAINT [FK_MEDREQ_TBL_MEDCHEK_TBL];
GO
IF OBJECT_ID(N'[dbo].[FK_ORDER_TBL_CUST_TBL]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ORDER_TBL] DROP CONSTRAINT [FK_ORDER_TBL_CUST_TBL];
GO
IF OBJECT_ID(N'[dbo].[FK_ORDER_TBL_ToTable]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ORDER_TBL] DROP CONSTRAINT [FK_ORDER_TBL_ToTable];
GO
IF OBJECT_ID(N'[dbo].[FK_SERLIST_TBL_CLINC_TBL]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SERLIST_TBL] DROP CONSTRAINT [FK_SERLIST_TBL_CLINC_TBL];
GO
IF OBJECT_ID(N'[dbo].[FK_SERLIST_TBL_SERLIST_TBL]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SERLIST_TBL] DROP CONSTRAINT [FK_SERLIST_TBL_SERLIST_TBL];
GO
IF OBJECT_ID(N'[dbo].[FK_SERVICE_TBL_CLINC_TBL]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SERVICE_TBL] DROP CONSTRAINT [FK_SERVICE_TBL_CLINC_TBL];
GO
IF OBJECT_ID(N'[dbo].[FK_USERS_TBL_CLINC_TBL]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[USERS_TBL] DROP CONSTRAINT [FK_USERS_TBL_CLINC_TBL];
GO
IF OBJECT_ID(N'[dbo].[FK_VISIT_TBL_CLINC_TBL]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VISIT_TBL] DROP CONSTRAINT [FK_VISIT_TBL_CLINC_TBL];
GO
IF OBJECT_ID(N'[dbo].[FK_VISIT_TBL_CUST_TBL]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VISIT_TBL] DROP CONSTRAINT [FK_VISIT_TBL_CUST_TBL];
GO
IF OBJECT_ID(N'[dbo].[FK_VISIT_TBL_DOCTORS_TBL]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VISIT_TBL] DROP CONSTRAINT [FK_VISIT_TBL_DOCTORS_TBL];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[APO_TBL]', 'U') IS NOT NULL
    DROP TABLE [dbo].[APO_TBL];
GO
IF OBJECT_ID(N'[dbo].[CARD_TBL]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CARD_TBL];
GO
IF OBJECT_ID(N'[dbo].[CLINC_TBL]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CLINC_TBL];
GO
IF OBJECT_ID(N'[dbo].[COMPANY_TBL]', 'U') IS NOT NULL
    DROP TABLE [dbo].[COMPANY_TBL];
GO
IF OBJECT_ID(N'[dbo].[CUST_TBL]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CUST_TBL];
GO
IF OBJECT_ID(N'[dbo].[DIAGNOIS_TBL]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DIAGNOIS_TBL];
GO
IF OBJECT_ID(N'[dbo].[DIGLIST_TBL]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DIGLIST_TBL];
GO
IF OBJECT_ID(N'[dbo].[DOCTORS_TBL]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DOCTORS_TBL];
GO
IF OBJECT_ID(N'[dbo].[DOS_TBL]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DOS_TBL];
GO
IF OBJECT_ID(N'[dbo].[MEDCHEK_TBL]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MEDCHEK_TBL];
GO
IF OBJECT_ID(N'[dbo].[MEDCIN_TBL]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MEDCIN_TBL];
GO
IF OBJECT_ID(N'[dbo].[MEDLIST_TBL]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MEDLIST_TBL];
GO
IF OBJECT_ID(N'[dbo].[MEDREQ_TBL]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MEDREQ_TBL];
GO
IF OBJECT_ID(N'[dbo].[ORDER_TBL]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ORDER_TBL];
GO
IF OBJECT_ID(N'[dbo].[SERLIST_TBL]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SERLIST_TBL];
GO
IF OBJECT_ID(N'[dbo].[SERVICE_TBL]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SERVICE_TBL];
GO
IF OBJECT_ID(N'[dbo].[USERS_TBL]', 'U') IS NOT NULL
    DROP TABLE [dbo].[USERS_TBL];
GO
IF OBJECT_ID(N'[dbo].[VISIT_TBL]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VISIT_TBL];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'APO_TBL'
CREATE TABLE [dbo].[APO_TBL] (
    [APO_ID] decimal(18,0) IDENTITY(1,1) NOT NULL,
    [APO_CODE] decimal(18,0)  NULL,
    [APO_DATE] datetime  NULL,
    [APO_TIME] varchar(50)  NULL,
    [APO_NAME] varchar(50)  NULL,
    [APO_NOTE] varchar(50)  NULL,
    [CLI_ID] decimal(18,0)  NULL,
    [CUST_ID] decimal(18,0)  NULL,
    [DOC_ID] decimal(18,0)  NULL,
    [VIS_ID] decimal(18,0)  NULL
);
GO

-- Creating table 'CARD_TBL'
CREATE TABLE [dbo].[CARD_TBL] (
    [CARD_ID] decimal(18,0) IDENTITY(1,1) NOT NULL,
    [CARD_CODE] decimal(18,0)  NULL,
    [CARD_NAME] varchar(50)  NULL,
    [CARD_DATE] datetime  NULL,
    [CARD_STATE] varchar(50)  NULL,
    [CARD_PER] int  NULL,
    [CARD_NOTE] varchar(max)  NULL,
    [COM_ID] decimal(18,0)  NULL,
    [CLI_ID] decimal(18,0)  NULL
);
GO

-- Creating table 'CLINC_TBL'
CREATE TABLE [dbo].[CLINC_TBL] (
    [CLI_ID] decimal(18,0) IDENTITY(1,1) NOT NULL,
    [CLI_CODE] decimal(18,0)  NULL,
    [CLI_NAME] varchar(50)  NULL,
    [CLI_LOC] varchar(50)  NULL,
    [CLI_NOTE] varchar(50)  NULL
);
GO

-- Creating table 'COMPANY_TBL'
CREATE TABLE [dbo].[COMPANY_TBL] (
    [COM_ID] decimal(18,0) IDENTITY(1,1) NOT NULL,
    [COM_CODE] decimal(18,0)  NULL,
    [COM_NAME] varchar(50)  NULL,
    [COM_ADDRESS] varchar(50)  NULL,
    [COM_MOBILE1] varchar(50)  NULL,
    [COM_STATE] varchar(50)  NULL,
    [CLI_ID] decimal(18,0)  NULL
);
GO

-- Creating table 'CUST_TBL'
CREATE TABLE [dbo].[CUST_TBL] (
    [CUST_ID] decimal(18,0) IDENTITY(1,1) NOT NULL,
    [CUST_CODE] decimal(18,0)  NULL,
    [CUST_F_NAME] varchar(50)  NULL,
    [CUST_S_NAME] varchar(50)  NULL,
    [CUST_T_NAME] varchar(50)  NULL,
    [CUST_L_NAME] varchar(50)  NULL,
    [CUST_AGE] varchar(50)  NULL,
    [CUST_BD] datetime  NULL,
    [CUST_MOBLIE1] varchar(50)  NULL,
    [CUST_MOBILE2] varchar(50)  NULL,
    [CUST_ADDRESS] varchar(50)  NULL,
    [CUST_SAVE_STATE] varchar(50)  NULL,
    [CARD_ID] decimal(18,0)  NULL,
    [CLI_ID] decimal(18,0)  NULL,
    [CUST_NOTE] nvarchar(max)  NULL
);
GO

-- Creating table 'DIAGNOIS_TBL'
CREATE TABLE [dbo].[DIAGNOIS_TBL] (
    [DIG_ID] decimal(18,0) IDENTITY(1,1) NOT NULL,
    [DIG_CODE] decimal(18,0)  NULL,
    [DIG_NAME] varchar(200)  NULL,
    [DIG_TYPE] varchar(50)  NULL,
    [DIG_NOTE] varchar(max)  NULL,
    [CLI_ID] decimal(18,0)  NULL
);
GO

-- Creating table 'DIGLIST_TBL'
CREATE TABLE [dbo].[DIGLIST_TBL] (
    [DIGLIST_ID] decimal(18,0) IDENTITY(1,1) NOT NULL,
    [DIGLIST_CODE] decimal(18,0)  NULL,
    [DIGLIST_NAME] varchar(50)  NULL,
    [DIGLIST_DATE] datetime  NULL,
    [DIGLIST_TIME] nvarchar(50)  NULL,
    [DIG_ID] decimal(18,0)  NULL,
    [CUST_ID] decimal(18,0)  NULL,
    [VIS_ID] decimal(18,0)  NULL,
    [CLI_ID] decimal(18,0)  NULL
);
GO

-- Creating table 'DOCTORS_TBL'
CREATE TABLE [dbo].[DOCTORS_TBL] (
    [DOC_ID] decimal(18,0) IDENTITY(1,1) NOT NULL,
    [DOC_CODE] decimal(18,0)  NULL,
    [DOC_NAME] varchar(max)  NULL,
    [DOC_MAJOR] varchar(50)  NULL,
    [DOC_EXP] varchar(50)  NULL,
    [DOC_BD] datetime  NULL,
    [DOC_MOBILE] varchar(50)  NULL,
    [DOC_ADDRESS] varchar(50)  NULL,
    [CLI_ID] decimal(18,0)  NULL,
    [USER_ID] int  NULL
);
GO

-- Creating table 'MEDCHEK_TBL'
CREATE TABLE [dbo].[MEDCHEK_TBL] (
    [MEDCHECK_ID] decimal(18,0) IDENTITY(1,1) NOT NULL,
    [MEDCHEK_CODE] decimal(18,0)  NULL,
    [MEDCHEK_NAME] varchar(50)  NULL,
    [MEDCHEK_TYPE] varchar(50)  NULL,
    [MEDCHEK_PRICE] decimal(18,2)  NULL,
    [MEDCHEK_NOTE] varchar(50)  NULL,
    [CLI_ID] decimal(18,0)  NULL
);
GO

-- Creating table 'MEDCIN_TBL'
CREATE TABLE [dbo].[MEDCIN_TBL] (
    [MED_ID] decimal(18,0) IDENTITY(1,1) NOT NULL,
    [MED_CODE] decimal(18,0)  NULL,
    [MED_NAME] varchar(max)  NULL,
    [MED_S_NAME] varchar(max)  NULL,
    [MED_SOURSE] varchar(50)  NULL,
    [MED_PRICE] decimal(18,2)  NULL,
    [CLI_ID] decimal(18,0)  NULL
);
GO

-- Creating table 'MEDLIST_TBL'
CREATE TABLE [dbo].[MEDLIST_TBL] (
    [MEDLIST_ID] decimal(18,0) IDENTITY(1,1) NOT NULL,
    [MEDLIST_CODE] decimal(18,0)  NULL,
    [MEDLIST_NAME] varchar(50)  NULL,
    [MEDLIST_DATE] datetime  NULL,
    [MEDLIST_TIME] time  NULL,
    [MED_ID] decimal(18,0)  NULL,
    [DOS_ID] decimal(18,0)  NULL,
    [CUST_ID] decimal(18,0)  NULL,
    [VIS_ID] decimal(18,0)  NULL
);
GO

-- Creating table 'MEDREQ_TBL'
CREATE TABLE [dbo].[MEDREQ_TBL] (
    [MEDREQ_ID] decimal(18,0) IDENTITY(1,1) NOT NULL,
    [MEDREQ_CODE] decimal(18,0)  NULL,
    [MEDREQ_NAME] varchar(50)  NULL,
    [MEDREQ_DATE] datetime  NULL,
    [MEDREQ_TIME] nvarchar(50)  NULL,
    [MEDREQ_RESULT] varchar(50)  NULL,
    [MEDREQ_NOTE] varchar(50)  NULL,
    [MEDCHECK_ID] decimal(18,0)  NULL,
    [CUST_ID] decimal(18,0)  NULL,
    [CLI_ID] decimal(18,0)  NULL,
    [VIS_ID] decimal(18,0)  NULL,
    [MEDREQ_STATE] varchar(50)  NULL
);
GO

-- Creating table 'SERLIST_TBL'
CREATE TABLE [dbo].[SERLIST_TBL] (
    [SERLIST_ID] decimal(18,0) IDENTITY(1,1) NOT NULL,
    [SERLIST_CODE] decimal(18,0)  NULL,
    [SERLIST_NAME] varchar(50)  NULL,
    [SERLIST_DATE] datetime  NULL,
    [SERLIST_TIME] nvarchar(50)  NULL,
    [SER_PRICE_TOTAL] decimal(18,0)  NULL,
    [SERLIST_NOTE] varchar(50)  NULL,
    [SER_ID] decimal(18,0)  NULL,
    [CLI_ID] decimal(18,0)  NULL,
    [CUST_ID] decimal(18,0)  NULL,
    [VIS_ID] decimal(18,0)  NULL
);
GO

-- Creating table 'SERVICE_TBL'
CREATE TABLE [dbo].[SERVICE_TBL] (
    [SER_ID] decimal(18,0) IDENTITY(1,1) NOT NULL,
    [SER_CODE] decimal(18,0)  NULL,
    [SER_NAME] varchar(50)  NULL,
    [SER_TYPE] varchar(50)  NULL,
    [SER_PRICE] varchar(50)  NULL,
    [SER_NOTE] varchar(50)  NULL,
    [CLI_ID] decimal(18,0)  NULL
);
GO

-- Creating table 'USERS_TBL'
CREATE TABLE [dbo].[USERS_TBL] (
    [USER_ID] decimal(18,0) IDENTITY(1,1) NOT NULL,
    [USER_CODE] decimal(18,0)  NULL,
    [USER_NAME] varchar(50)  NULL,
    [USER_PASSWORD] varchar(50)  NULL,
    [USER_TYPE] varchar(50)  NULL,
    [CLI_ID] decimal(18,0)  NULL
);
GO

-- Creating table 'VISIT_TBL'
CREATE TABLE [dbo].[VISIT_TBL] (
    [VIS_ID] decimal(18,0) IDENTITY(1,1) NOT NULL,
    [VIS_CODE] decimal(18,0)  NULL,
    [VIS_NAME] varchar(50)  NULL,
    [VIS_DATE] datetime  NULL,
    [VIS_TIME] nvarchar(50)  NULL,
    [VIS_TYPE] varchar(50)  NULL,
    [CUST_ID] decimal(18,0)  NULL,
    [CLI_ID] decimal(18,0)  NULL,
    [DOC_ID] decimal(18,0)  NULL,
    [VIS_PRICE] decimal(18,0)  NULL,
    [VIS_DIS_COUNT] decimal(18,0)  NULL,
    [VIS_TOTAL] decimal(18,0)  NULL,
    [VIS_NOTE] nvarchar(50)  NULL,
    [VIS_PAY_TYPE] nvarchar(50)  NULL
);
GO

-- Creating table 'ORDER_TBL'
CREATE TABLE [dbo].[ORDER_TBL] (
    [ORDER_ID] decimal(18,0) IDENTITY(1,1) NOT NULL,
    [ORDER_CODE] decimal(18,0)  NULL,
    [ORDER_DATE] datetime  NULL,
    [ORDER_TIME] nvarchar(50)  NULL,
    [ORDER_NOTE] nvarchar(50)  NULL,
    [CUST_ID] decimal(18,0)  NULL,
    [CLI_ID] decimal(18,0)  NULL
);
GO

-- Creating table 'DOS_TBL'
CREATE TABLE [dbo].[DOS_TBL] (
    [DOS_ID] decimal(18,0) IDENTITY(1,1) NOT NULL,
    [DOS_CODE] decimal(18,0)  NULL,
    [DOS_NAME] varchar(50)  NULL,
    [DOS_TYPE] varchar(50)  NULL,
    [CLI_ID] decimal(18,0)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [APO_ID] in table 'APO_TBL'
ALTER TABLE [dbo].[APO_TBL]
ADD CONSTRAINT [PK_APO_TBL]
    PRIMARY KEY CLUSTERED ([APO_ID] ASC);
GO

-- Creating primary key on [CARD_ID] in table 'CARD_TBL'
ALTER TABLE [dbo].[CARD_TBL]
ADD CONSTRAINT [PK_CARD_TBL]
    PRIMARY KEY CLUSTERED ([CARD_ID] ASC);
GO

-- Creating primary key on [CLI_ID] in table 'CLINC_TBL'
ALTER TABLE [dbo].[CLINC_TBL]
ADD CONSTRAINT [PK_CLINC_TBL]
    PRIMARY KEY CLUSTERED ([CLI_ID] ASC);
GO

-- Creating primary key on [COM_ID] in table 'COMPANY_TBL'
ALTER TABLE [dbo].[COMPANY_TBL]
ADD CONSTRAINT [PK_COMPANY_TBL]
    PRIMARY KEY CLUSTERED ([COM_ID] ASC);
GO

-- Creating primary key on [CUST_ID] in table 'CUST_TBL'
ALTER TABLE [dbo].[CUST_TBL]
ADD CONSTRAINT [PK_CUST_TBL]
    PRIMARY KEY CLUSTERED ([CUST_ID] ASC);
GO

-- Creating primary key on [DIG_ID] in table 'DIAGNOIS_TBL'
ALTER TABLE [dbo].[DIAGNOIS_TBL]
ADD CONSTRAINT [PK_DIAGNOIS_TBL]
    PRIMARY KEY CLUSTERED ([DIG_ID] ASC);
GO

-- Creating primary key on [DIGLIST_ID] in table 'DIGLIST_TBL'
ALTER TABLE [dbo].[DIGLIST_TBL]
ADD CONSTRAINT [PK_DIGLIST_TBL]
    PRIMARY KEY CLUSTERED ([DIGLIST_ID] ASC);
GO

-- Creating primary key on [DOC_ID] in table 'DOCTORS_TBL'
ALTER TABLE [dbo].[DOCTORS_TBL]
ADD CONSTRAINT [PK_DOCTORS_TBL]
    PRIMARY KEY CLUSTERED ([DOC_ID] ASC);
GO

-- Creating primary key on [MEDCHECK_ID] in table 'MEDCHEK_TBL'
ALTER TABLE [dbo].[MEDCHEK_TBL]
ADD CONSTRAINT [PK_MEDCHEK_TBL]
    PRIMARY KEY CLUSTERED ([MEDCHECK_ID] ASC);
GO

-- Creating primary key on [MED_ID] in table 'MEDCIN_TBL'
ALTER TABLE [dbo].[MEDCIN_TBL]
ADD CONSTRAINT [PK_MEDCIN_TBL]
    PRIMARY KEY CLUSTERED ([MED_ID] ASC);
GO

-- Creating primary key on [MEDLIST_ID] in table 'MEDLIST_TBL'
ALTER TABLE [dbo].[MEDLIST_TBL]
ADD CONSTRAINT [PK_MEDLIST_TBL]
    PRIMARY KEY CLUSTERED ([MEDLIST_ID] ASC);
GO

-- Creating primary key on [MEDREQ_ID] in table 'MEDREQ_TBL'
ALTER TABLE [dbo].[MEDREQ_TBL]
ADD CONSTRAINT [PK_MEDREQ_TBL]
    PRIMARY KEY CLUSTERED ([MEDREQ_ID] ASC);
GO

-- Creating primary key on [SERLIST_ID] in table 'SERLIST_TBL'
ALTER TABLE [dbo].[SERLIST_TBL]
ADD CONSTRAINT [PK_SERLIST_TBL]
    PRIMARY KEY CLUSTERED ([SERLIST_ID] ASC);
GO

-- Creating primary key on [SER_ID] in table 'SERVICE_TBL'
ALTER TABLE [dbo].[SERVICE_TBL]
ADD CONSTRAINT [PK_SERVICE_TBL]
    PRIMARY KEY CLUSTERED ([SER_ID] ASC);
GO

-- Creating primary key on [USER_ID] in table 'USERS_TBL'
ALTER TABLE [dbo].[USERS_TBL]
ADD CONSTRAINT [PK_USERS_TBL]
    PRIMARY KEY CLUSTERED ([USER_ID] ASC);
GO

-- Creating primary key on [VIS_ID] in table 'VISIT_TBL'
ALTER TABLE [dbo].[VISIT_TBL]
ADD CONSTRAINT [PK_VISIT_TBL]
    PRIMARY KEY CLUSTERED ([VIS_ID] ASC);
GO

-- Creating primary key on [ORDER_ID] in table 'ORDER_TBL'
ALTER TABLE [dbo].[ORDER_TBL]
ADD CONSTRAINT [PK_ORDER_TBL]
    PRIMARY KEY CLUSTERED ([ORDER_ID] ASC);
GO

-- Creating primary key on [DOS_ID] in table 'DOS_TBL'
ALTER TABLE [dbo].[DOS_TBL]
ADD CONSTRAINT [PK_DOS_TBL]
    PRIMARY KEY CLUSTERED ([DOS_ID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CLI_ID] in table 'APO_TBL'
ALTER TABLE [dbo].[APO_TBL]
ADD CONSTRAINT [FK_APO_TBL_CLINC_TBL]
    FOREIGN KEY ([CLI_ID])
    REFERENCES [dbo].[CLINC_TBL]
        ([CLI_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_APO_TBL_CLINC_TBL'
CREATE INDEX [IX_FK_APO_TBL_CLINC_TBL]
ON [dbo].[APO_TBL]
    ([CLI_ID]);
GO

-- Creating foreign key on [CUST_ID] in table 'APO_TBL'
ALTER TABLE [dbo].[APO_TBL]
ADD CONSTRAINT [FK_APO_TBL_CUST_TBL]
    FOREIGN KEY ([CUST_ID])
    REFERENCES [dbo].[CUST_TBL]
        ([CUST_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_APO_TBL_CUST_TBL'
CREATE INDEX [IX_FK_APO_TBL_CUST_TBL]
ON [dbo].[APO_TBL]
    ([CUST_ID]);
GO

-- Creating foreign key on [CLI_ID] in table 'CARD_TBL'
ALTER TABLE [dbo].[CARD_TBL]
ADD CONSTRAINT [FK_CARD_TBL_CLINC_TBL]
    FOREIGN KEY ([CLI_ID])
    REFERENCES [dbo].[CLINC_TBL]
        ([CLI_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CARD_TBL_CLINC_TBL'
CREATE INDEX [IX_FK_CARD_TBL_CLINC_TBL]
ON [dbo].[CARD_TBL]
    ([CLI_ID]);
GO

-- Creating foreign key on [COM_ID] in table 'CARD_TBL'
ALTER TABLE [dbo].[CARD_TBL]
ADD CONSTRAINT [FK_CARD_TBL_COMPANY_TBL]
    FOREIGN KEY ([COM_ID])
    REFERENCES [dbo].[COMPANY_TBL]
        ([COM_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CARD_TBL_COMPANY_TBL'
CREATE INDEX [IX_FK_CARD_TBL_COMPANY_TBL]
ON [dbo].[CARD_TBL]
    ([COM_ID]);
GO

-- Creating foreign key on [CARD_ID] in table 'CUST_TBL'
ALTER TABLE [dbo].[CUST_TBL]
ADD CONSTRAINT [FK_CUST_TBL_CARD_TBL]
    FOREIGN KEY ([CARD_ID])
    REFERENCES [dbo].[CARD_TBL]
        ([CARD_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CUST_TBL_CARD_TBL'
CREATE INDEX [IX_FK_CUST_TBL_CARD_TBL]
ON [dbo].[CUST_TBL]
    ([CARD_ID]);
GO

-- Creating foreign key on [CLI_ID] in table 'COMPANY_TBL'
ALTER TABLE [dbo].[COMPANY_TBL]
ADD CONSTRAINT [FK_COMPANY_TBL_CLINC_TBL]
    FOREIGN KEY ([CLI_ID])
    REFERENCES [dbo].[CLINC_TBL]
        ([CLI_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_COMPANY_TBL_CLINC_TBL'
CREATE INDEX [IX_FK_COMPANY_TBL_CLINC_TBL]
ON [dbo].[COMPANY_TBL]
    ([CLI_ID]);
GO

-- Creating foreign key on [CLI_ID] in table 'CUST_TBL'
ALTER TABLE [dbo].[CUST_TBL]
ADD CONSTRAINT [FK_CUST_TBL_CLINC_TBL]
    FOREIGN KEY ([CLI_ID])
    REFERENCES [dbo].[CLINC_TBL]
        ([CLI_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CUST_TBL_CLINC_TBL'
CREATE INDEX [IX_FK_CUST_TBL_CLINC_TBL]
ON [dbo].[CUST_TBL]
    ([CLI_ID]);
GO

-- Creating foreign key on [CLI_ID] in table 'DIAGNOIS_TBL'
ALTER TABLE [dbo].[DIAGNOIS_TBL]
ADD CONSTRAINT [FK_DIAGNOIS_TBL_CLINC_TBL]
    FOREIGN KEY ([CLI_ID])
    REFERENCES [dbo].[CLINC_TBL]
        ([CLI_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DIAGNOIS_TBL_CLINC_TBL'
CREATE INDEX [IX_FK_DIAGNOIS_TBL_CLINC_TBL]
ON [dbo].[DIAGNOIS_TBL]
    ([CLI_ID]);
GO

-- Creating foreign key on [CLI_ID] in table 'DIGLIST_TBL'
ALTER TABLE [dbo].[DIGLIST_TBL]
ADD CONSTRAINT [FK_DIGLIST_TBL_CLINC_TBL]
    FOREIGN KEY ([CLI_ID])
    REFERENCES [dbo].[CLINC_TBL]
        ([CLI_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DIGLIST_TBL_CLINC_TBL'
CREATE INDEX [IX_FK_DIGLIST_TBL_CLINC_TBL]
ON [dbo].[DIGLIST_TBL]
    ([CLI_ID]);
GO

-- Creating foreign key on [CLI_ID] in table 'DOCTORS_TBL'
ALTER TABLE [dbo].[DOCTORS_TBL]
ADD CONSTRAINT [FK_DOCTORS_TBL_CLINC_TBL]
    FOREIGN KEY ([CLI_ID])
    REFERENCES [dbo].[CLINC_TBL]
        ([CLI_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DOCTORS_TBL_CLINC_TBL'
CREATE INDEX [IX_FK_DOCTORS_TBL_CLINC_TBL]
ON [dbo].[DOCTORS_TBL]
    ([CLI_ID]);
GO

-- Creating foreign key on [CLI_ID] in table 'MEDCHEK_TBL'
ALTER TABLE [dbo].[MEDCHEK_TBL]
ADD CONSTRAINT [FK_MEDCHEK_TBL_CLINC_TBL]
    FOREIGN KEY ([CLI_ID])
    REFERENCES [dbo].[CLINC_TBL]
        ([CLI_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MEDCHEK_TBL_CLINC_TBL'
CREATE INDEX [IX_FK_MEDCHEK_TBL_CLINC_TBL]
ON [dbo].[MEDCHEK_TBL]
    ([CLI_ID]);
GO

-- Creating foreign key on [CLI_ID] in table 'MEDCIN_TBL'
ALTER TABLE [dbo].[MEDCIN_TBL]
ADD CONSTRAINT [FK_MEDCIN_TBL_CLINC_TBL]
    FOREIGN KEY ([CLI_ID])
    REFERENCES [dbo].[CLINC_TBL]
        ([CLI_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MEDCIN_TBL_CLINC_TBL'
CREATE INDEX [IX_FK_MEDCIN_TBL_CLINC_TBL]
ON [dbo].[MEDCIN_TBL]
    ([CLI_ID]);
GO

-- Creating foreign key on [CLI_ID] in table 'MEDREQ_TBL'
ALTER TABLE [dbo].[MEDREQ_TBL]
ADD CONSTRAINT [FK_MEDREQ_TBL_CLINC_TBL]
    FOREIGN KEY ([CLI_ID])
    REFERENCES [dbo].[CLINC_TBL]
        ([CLI_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MEDREQ_TBL_CLINC_TBL'
CREATE INDEX [IX_FK_MEDREQ_TBL_CLINC_TBL]
ON [dbo].[MEDREQ_TBL]
    ([CLI_ID]);
GO

-- Creating foreign key on [CLI_ID] in table 'SERLIST_TBL'
ALTER TABLE [dbo].[SERLIST_TBL]
ADD CONSTRAINT [FK_SERLIST_TBL_CLINC_TBL]
    FOREIGN KEY ([CLI_ID])
    REFERENCES [dbo].[CLINC_TBL]
        ([CLI_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SERLIST_TBL_CLINC_TBL'
CREATE INDEX [IX_FK_SERLIST_TBL_CLINC_TBL]
ON [dbo].[SERLIST_TBL]
    ([CLI_ID]);
GO

-- Creating foreign key on [CLI_ID] in table 'SERVICE_TBL'
ALTER TABLE [dbo].[SERVICE_TBL]
ADD CONSTRAINT [FK_SERVICE_TBL_CLINC_TBL]
    FOREIGN KEY ([CLI_ID])
    REFERENCES [dbo].[CLINC_TBL]
        ([CLI_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SERVICE_TBL_CLINC_TBL'
CREATE INDEX [IX_FK_SERVICE_TBL_CLINC_TBL]
ON [dbo].[SERVICE_TBL]
    ([CLI_ID]);
GO

-- Creating foreign key on [CLI_ID] in table 'USERS_TBL'
ALTER TABLE [dbo].[USERS_TBL]
ADD CONSTRAINT [FK_USERS_TBL_CLINC_TBL]
    FOREIGN KEY ([CLI_ID])
    REFERENCES [dbo].[CLINC_TBL]
        ([CLI_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_USERS_TBL_CLINC_TBL'
CREATE INDEX [IX_FK_USERS_TBL_CLINC_TBL]
ON [dbo].[USERS_TBL]
    ([CLI_ID]);
GO

-- Creating foreign key on [CLI_ID] in table 'VISIT_TBL'
ALTER TABLE [dbo].[VISIT_TBL]
ADD CONSTRAINT [FK_VISIT_TBL_CLINC_TBL]
    FOREIGN KEY ([CLI_ID])
    REFERENCES [dbo].[CLINC_TBL]
        ([CLI_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_VISIT_TBL_CLINC_TBL'
CREATE INDEX [IX_FK_VISIT_TBL_CLINC_TBL]
ON [dbo].[VISIT_TBL]
    ([CLI_ID]);
GO

-- Creating foreign key on [CUST_ID] in table 'MEDLIST_TBL'
ALTER TABLE [dbo].[MEDLIST_TBL]
ADD CONSTRAINT [FK_MEDLIST_TBL_CUST_TBL]
    FOREIGN KEY ([CUST_ID])
    REFERENCES [dbo].[CUST_TBL]
        ([CUST_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MEDLIST_TBL_CUST_TBL'
CREATE INDEX [IX_FK_MEDLIST_TBL_CUST_TBL]
ON [dbo].[MEDLIST_TBL]
    ([CUST_ID]);
GO

-- Creating foreign key on [CUST_ID] in table 'VISIT_TBL'
ALTER TABLE [dbo].[VISIT_TBL]
ADD CONSTRAINT [FK_VISIT_TBL_CUST_TBL]
    FOREIGN KEY ([CUST_ID])
    REFERENCES [dbo].[CUST_TBL]
        ([CUST_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_VISIT_TBL_CUST_TBL'
CREATE INDEX [IX_FK_VISIT_TBL_CUST_TBL]
ON [dbo].[VISIT_TBL]
    ([CUST_ID]);
GO

-- Creating foreign key on [DIG_ID] in table 'DIGLIST_TBL'
ALTER TABLE [dbo].[DIGLIST_TBL]
ADD CONSTRAINT [FK_DIGLIST_TBL_DIAGNOIS_TBL]
    FOREIGN KEY ([DIG_ID])
    REFERENCES [dbo].[DIAGNOIS_TBL]
        ([DIG_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DIGLIST_TBL_DIAGNOIS_TBL'
CREATE INDEX [IX_FK_DIGLIST_TBL_DIAGNOIS_TBL]
ON [dbo].[DIGLIST_TBL]
    ([DIG_ID]);
GO

-- Creating foreign key on [VIS_ID] in table 'DIGLIST_TBL'
ALTER TABLE [dbo].[DIGLIST_TBL]
ADD CONSTRAINT [FK_DIGLIST_TBL_VISIT_TBL]
    FOREIGN KEY ([VIS_ID])
    REFERENCES [dbo].[VISIT_TBL]
        ([VIS_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DIGLIST_TBL_VISIT_TBL'
CREATE INDEX [IX_FK_DIGLIST_TBL_VISIT_TBL]
ON [dbo].[DIGLIST_TBL]
    ([VIS_ID]);
GO

-- Creating foreign key on [DOC_ID] in table 'VISIT_TBL'
ALTER TABLE [dbo].[VISIT_TBL]
ADD CONSTRAINT [FK_VISIT_TBL_DOCTORS_TBL]
    FOREIGN KEY ([DOC_ID])
    REFERENCES [dbo].[DOCTORS_TBL]
        ([DOC_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_VISIT_TBL_DOCTORS_TBL'
CREATE INDEX [IX_FK_VISIT_TBL_DOCTORS_TBL]
ON [dbo].[VISIT_TBL]
    ([DOC_ID]);
GO

-- Creating foreign key on [MEDCHECK_ID] in table 'MEDREQ_TBL'
ALTER TABLE [dbo].[MEDREQ_TBL]
ADD CONSTRAINT [FK_MEDREQ_TBL_MEDCHEK_TBL]
    FOREIGN KEY ([MEDCHECK_ID])
    REFERENCES [dbo].[MEDCHEK_TBL]
        ([MEDCHECK_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MEDREQ_TBL_MEDCHEK_TBL'
CREATE INDEX [IX_FK_MEDREQ_TBL_MEDCHEK_TBL]
ON [dbo].[MEDREQ_TBL]
    ([MEDCHECK_ID]);
GO

-- Creating foreign key on [MED_ID] in table 'MEDLIST_TBL'
ALTER TABLE [dbo].[MEDLIST_TBL]
ADD CONSTRAINT [FK_MEDLIST_TBL_MEDCIN_TBL]
    FOREIGN KEY ([MED_ID])
    REFERENCES [dbo].[MEDCIN_TBL]
        ([MED_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MEDLIST_TBL_MEDCIN_TBL'
CREATE INDEX [IX_FK_MEDLIST_TBL_MEDCIN_TBL]
ON [dbo].[MEDLIST_TBL]
    ([MED_ID]);
GO

-- Creating foreign key on [SER_ID] in table 'SERLIST_TBL'
ALTER TABLE [dbo].[SERLIST_TBL]
ADD CONSTRAINT [FK_SERLIST_TBL_SERLIST_TBL]
    FOREIGN KEY ([SER_ID])
    REFERENCES [dbo].[SERVICE_TBL]
        ([SER_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SERLIST_TBL_SERLIST_TBL'
CREATE INDEX [IX_FK_SERLIST_TBL_SERLIST_TBL]
ON [dbo].[SERLIST_TBL]
    ([SER_ID]);
GO

-- Creating foreign key on [DOC_ID] in table 'APO_TBL'
ALTER TABLE [dbo].[APO_TBL]
ADD CONSTRAINT [FK_APO_BDOCTORS_TBL]
    FOREIGN KEY ([DOC_ID])
    REFERENCES [dbo].[DOCTORS_TBL]
        ([DOC_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_APO_BDOCTORS_TBL'
CREATE INDEX [IX_FK_APO_BDOCTORS_TBL]
ON [dbo].[APO_TBL]
    ([DOC_ID]);
GO

-- Creating foreign key on [CLI_ID] in table 'ORDER_TBL'
ALTER TABLE [dbo].[ORDER_TBL]
ADD CONSTRAINT [FK_ORDER_TBL_ToTable]
    FOREIGN KEY ([CLI_ID])
    REFERENCES [dbo].[CLINC_TBL]
        ([CLI_ID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ORDER_TBL_ToTable'
CREATE INDEX [IX_FK_ORDER_TBL_ToTable]
ON [dbo].[ORDER_TBL]
    ([CLI_ID]);
GO

-- Creating foreign key on [CUST_ID] in table 'ORDER_TBL'
ALTER TABLE [dbo].[ORDER_TBL]
ADD CONSTRAINT [FK_ORDER_TBL_CUST_TBL]
    FOREIGN KEY ([CUST_ID])
    REFERENCES [dbo].[CUST_TBL]
        ([CUST_ID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ORDER_TBL_CUST_TBL'
CREATE INDEX [IX_FK_ORDER_TBL_CUST_TBL]
ON [dbo].[ORDER_TBL]
    ([CUST_ID]);
GO

-- Creating foreign key on [CLI_ID] in table 'DOS_TBL'
ALTER TABLE [dbo].[DOS_TBL]
ADD CONSTRAINT [FK_DOS_TBL_CLINC_TBL]
    FOREIGN KEY ([CLI_ID])
    REFERENCES [dbo].[CLINC_TBL]
        ([CLI_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DOS_TBL_CLINC_TBL'
CREATE INDEX [IX_FK_DOS_TBL_CLINC_TBL]
ON [dbo].[DOS_TBL]
    ([CLI_ID]);
GO

-- Creating foreign key on [DOS_ID] in table 'MEDLIST_TBL'
ALTER TABLE [dbo].[MEDLIST_TBL]
ADD CONSTRAINT [FK_MEDLIST_TBL_DOS_TBL]
    FOREIGN KEY ([DOS_ID])
    REFERENCES [dbo].[DOS_TBL]
        ([DOS_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MEDLIST_TBL_DOS_TBL'
CREATE INDEX [IX_FK_MEDLIST_TBL_DOS_TBL]
ON [dbo].[MEDLIST_TBL]
    ([DOS_ID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------