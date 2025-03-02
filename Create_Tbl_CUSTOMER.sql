USE [QAPortal]
GO

/****** Object:  Table [dbo].[CUSTOMER]    Script Date: 3/1/2025 3:58:29 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CUSTOMER](
	[First_Name] [varchar](50) NULL,
	[Last_Name] [varchar](50) NULL,
	[Address] [varchar](150) NULL,
	[Phone] [varchar](50) NULL,
	[Start_Date] [datetime] NULL,
	[cust_id] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[cust_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


