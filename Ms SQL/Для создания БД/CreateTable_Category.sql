USE [TestTask]
GO

/****** Object:  Table [dbo].[Category]    Script Date: 06.02.2023 23:16:40 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Category](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NameCategory] [nchar](30) NOT NULL
) ON [PRIMARY]
GO

