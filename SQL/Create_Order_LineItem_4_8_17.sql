USE [TerminalInterface]
GO

/****** Object:  Table [dbo].[OrderLineItem]    Script Date: 4/8/2017 12:48:48 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[OrderLineItem](
	[OrderLineItemID] [int] IDENTITY(1,1) NOT NULL,
	[OrderID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[Quantitiy] [int] NOT NULL,
 CONSTRAINT [PK_OrderLineItem] PRIMARY KEY CLUSTERED 
(
	[OrderLineItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[OrderLineItem]  WITH CHECK ADD  CONSTRAINT [FK_OrderLineItem_Order] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Order] ([OrderId])
GO

ALTER TABLE [dbo].[OrderLineItem] CHECK CONSTRAINT [FK_OrderLineItem_Order]
GO


