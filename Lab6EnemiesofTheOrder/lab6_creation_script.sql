-- Created 3/28/2017 6:06:28 PM by Al Jarrah &Thompson
SET ANSI_NULLS ON
GO
Set QUOTED_IDENTIFIER On
GO
CREATE TABLE [lstAlliances] (
[allianceID] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
[allianceName] [nvarchar](25) NOT NULL,
[isActive] [char](1) NOT NULL)

SET ANSI_NULLS ON
GO
Set QUOTED_IDENTIFIER On
GO
CREATE TABLE [lstThreatLevel] (
[levelID] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
[threatLevel] [nvarchar](25) NOT NULL,
[priority] [int] NOT NULL,
[isActive] [bit] NOT NULL)

SET ANSI_NULLS ON
GO
Set QUOTED_IDENTIFIER On
GO
CREATE TABLE [datEnemy] (
[enemyID] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
[firstName] [nvarchar](25) NOT NULL,
[lastName] [nvarchar] DEFAULT('25') NULL,
[threatLevelID] [int] DEFAULT(1) NOT NULL,
[allianceID] [int] DEFAULT(1) NOT NULL,
[notes] [nvarchar](max) NOT NULL)