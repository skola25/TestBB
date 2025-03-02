USE [QAPortal]
GO

/****** Object:  Table [dbo].[SALES]    Script Date: 3/1/2025 3:52:53 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SALES](
	[s_id] [int] IDENTITY(1,1) NOT NULL,
	[prod_id] [varchar](10) NULL,
	[sp_id] [varchar](10) NULL,
	[cust_id] [varchar](10) NULL,
	[Sales_Date] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[s_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[SALES]  WITH CHECK ADD FOREIGN KEY([cust_id])
REFERENCES [dbo].[CUSTOMER] ([cust_id])
GO

ALTER TABLE [dbo].[SALES]  WITH CHECK ADD FOREIGN KEY([prod_id])
REFERENCES [dbo].[PRODUCTS] ([prod_id])
GO

ALTER TABLE [dbo].[SALES]  WITH CHECK ADD FOREIGN KEY([sp_id])
REFERENCES [dbo].[SALESPERSON] ([sp_id])
GO


