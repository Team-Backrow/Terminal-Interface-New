USE [TerminalInterface]
GO

/****** Object:  Table [dbo].[PaymentType]    Script Date: 4/8/2017 12:49:19 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[PaymentType](
	[PaymentId] [int] IDENTITY(1,1) NOT NULL,
	[PaymentType] [varchar](250) NOT NULL,
	[AccountNumber] [int] NOT NULL,
	[CustomerId] [int] NOT NULL,
 CONSTRAINT [PK_PaymentType] PRIMARY KEY CLUSTERED 
(
	[PaymentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[PaymentType]  WITH CHECK ADD  CONSTRAINT [FK_PaymentType_Customer] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customer] ([CustomerId])
GO

ALTER TABLE [dbo].[PaymentType] CHECK CONSTRAINT [FK_PaymentType_Customer]
GO


