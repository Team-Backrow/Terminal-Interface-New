/*
   Tuesday, April 11, 20178:46:14 PM
   User: 
   Server: NSS-E2
   Database: TerminalInterface
   Application: 
*/

/* To prevent any potential data loss issues, you should review this script in detail before running it outside the context of the database designer.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.[Order]
	DROP CONSTRAINT FK_Order_Customer
GO
ALTER TABLE dbo.Customer SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_Order
	(
	OrderId int NOT NULL IDENTITY (1, 1),
	PaymentId int NULL,
	CustomerId int NOT NULL,
	TotalPrice int NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_Order SET (LOCK_ESCALATION = TABLE)
GO
SET IDENTITY_INSERT dbo.Tmp_Order ON
GO
IF EXISTS(SELECT * FROM dbo.[Order])
	 EXEC('INSERT INTO dbo.Tmp_Order (OrderId, PaymentId, CustomerId, TotalPrice)
		SELECT OrderId, PaymentId, CustomerId, TotalPrice FROM dbo.[Order] WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_Order OFF
GO
ALTER TABLE dbo.OrderLineItem
	DROP CONSTRAINT FK_OrderLineItem_Order
GO
DROP TABLE dbo.[Order]
GO
EXECUTE sp_rename N'dbo.Tmp_Order', N'Order', 'OBJECT' 
GO
ALTER TABLE dbo.[Order] ADD CONSTRAINT
	PK_Order PRIMARY KEY CLUSTERED 
	(
	OrderId
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.[Order] ADD CONSTRAINT
	FK_Order_Customer FOREIGN KEY
	(
	CustomerId
	) REFERENCES dbo.Customer
	(
	CustomerId
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.OrderLineItem ADD CONSTRAINT
	FK_OrderLineItem_Order FOREIGN KEY
	(
	OrderID
	) REFERENCES dbo.[Order]
	(
	OrderId
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.OrderLineItem SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
