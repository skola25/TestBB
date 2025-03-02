USE [QAPortal]
GO

/****** Object:  Table [dbo].[DISCOUNT]    Script Date: 3/1/2025 3:59:49 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[DISCOUNT](
	[Begin_Date] [datetime] NULL,
	[End_Date] [datetime] NULL,
	[Discount_Perc] [decimal](18, 0) NULL,
	[prod_id] [varchar](10) NOT NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[DISCOUNT]  WITH CHECK ADD  CONSTRAINT [fk_prod_id] FOREIGN KEY([prod_id])
REFERENCES [dbo].[PRODUCTS] ([prod_id])
GO

ALTER TABLE [dbo].[DISCOUNT] CHECK CONSTRAINT [fk_prod_id]
GO


