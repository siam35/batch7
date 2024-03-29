USE [AccountDB]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 10/11/2019 2:30:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AccountNo] [int] NULL,
	[Amount] [int] NULL,
UNIQUE NONCLUSTERED 
(
	[AccountNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Customer]    Script Date: 10/11/2019 2:30:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Customer](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](255) NULL,
	[Email] [varchar](255) NULL,
	[AccountNo] [int] NULL,
	[Date] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[AccountNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[CustomerDetailsView]    Script Date: 10/11/2019 2:30:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[CustomerDetailsView] AS
SELECT Customer.AccountNo,Customer.Name, Customer.Date, Account.Amount FROM Customer LEFT JOIN Account ON Account.AccountNo = Customer.AccountNo WHERE Customer.AccountNo =11008899 
GO
ALTER TABLE [dbo].[Account]  WITH CHECK ADD FOREIGN KEY([AccountNo])
REFERENCES [dbo].[Customer] ([AccountNo])
GO
