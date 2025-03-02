USE [QAPortal]
GO

/****** Object:  Table [dbo].[PRODUCTS]    Script Date: 3/1/2025 4:01:05 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[PRODUCTS](
	[prod_name] [varchar](50) NOT NULL,
	[Manufacturer] [varchar](150) NULL,
	[Style] [varchar](10) NULL,
	[Purchase_Price] [decimal](18, 0) NULL,
	[Sale_Price] [decimal](18, 0) NULL,
	[Qty_On_Hand] [int] NULL,
	[Commission_Perc] [decimal](18, 0) NULL,
	[prod_id] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[prod_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


