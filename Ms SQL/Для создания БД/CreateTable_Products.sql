USE [TestTask]
GO

/****** Object:  Table [dbo].[Products]    Script Date: 06.02.2023 23:16:26 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nchar](50) NOT NULL,
	[Price] [nchar](9) NOT NULL,
	[IdCategory] [int] NULL
) ON [PRIMARY]
GO


