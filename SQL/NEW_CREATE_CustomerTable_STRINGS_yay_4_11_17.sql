USE [TerminalInterface]
GO

/****** Object:  Table [dbo].[Customer]    Script Date: 4/11/2017 8:25:11 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Customer](
	[CustomerId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](250) NOT NULL,
	[StreetAddress] [varchar](250) NOT NULL,
	[City] [varchar](250) NOT NULL,
	[State] [varchar](2) NOT NULL,
	[Zip] [varchar](12) NULL,
	[Phone] [varchar](50) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


