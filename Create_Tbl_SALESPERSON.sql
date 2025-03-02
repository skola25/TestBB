USE [QAPortal]
GO

/****** Object:  Table [dbo].[SALESPERSON]    Script Date: 3/1/2025 4:02:35 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SALESPERSON](
	[First_Name] [varchar](50) NOT NULL,
	[Last_Name] [varchar](50) NOT NULL,
	[Address] [varchar](150) NULL,
	[Phone] [varchar](50) NULL,
	[Start_Date] [datetime] NULL,
	[Termination_Date] [datetime] NULL,
	[Manager] [varchar](50) NULL,
	[sp_id] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[sp_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


