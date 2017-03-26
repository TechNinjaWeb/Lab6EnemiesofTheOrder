﻿-- Created 2017-03-22 5:14:39 PM by Mohammad  Al Jarrah & Raymonde Thompson
SET ANSI_NULLS ON
GO
Set QUOTED_IDENTIFIER On
GO
CREATE TABLE [datEnemy] (
[enemyID] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
[firstName] [nvarchar](25) NOT NULL,
[lastName] [nvarchar](25) NULL,
[theatLevelID] [int] DEFAULT(1) NOT NULL,
[allianceID] [int] DEFAULT(1) NOT NULL,
[notes] [nvarchar](max) NULL)

SET ANSI_NULLS ON
GO
Set QUOTED_IDENTIFIER On
GO
CREATE TABLE [lstThreatLevel] (
[levelID] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
[threatLevel] [nvarchar](25) NOT NULL,
[priority] [int] DEFAULT(10) NOT NULL,
[isActive] [bit] DEFAULT(1) NOT NULL)

SET ANSI_NULLS ON
GO
Set QUOTED_IDENTIFIER On
GO
CREATE TABLE [lstAllliances] (
[allianceID] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
[allianceName] [nvarchar](25) NOT NULL,
[isActive] [bit] DEFAULT(1) NOT NULL)

