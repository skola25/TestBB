USE [QAPortal]
GO

INSERT INTO [dbo].[CUSTOMER]
           ([First_Name]
           ,[Last_Name]
           ,[Address]
           ,[Phone]
           ,[Start_Date]
           ,[cust_id])
     VALUES
           ('Ginny', 'Miller', 'Apple Street' ,'321-431-1234', Getdate(),'C001')
GO

INSERT INTO [dbo].[CUSTOMER]
           ([First_Name]
           ,[Last_Name]
           ,[Address]
           ,[Phone]
           ,[Start_Date]
           ,[cust_id])
     VALUES
           ('Georgia', 'Miller', ' 123 Apple Street' ,'321-431-4321', Getdate(),'C002')
GO

