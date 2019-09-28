USE [CoffeeShop]
GO
/****** Object:  Table [dbo].[_Order]    Script Date: 9/28/2019 12:44:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[_Order](
	[Order_ID] [int] IDENTITY(1,1) NOT NULL,
	[Customer_ID] [int] NULL,
	[Items_ID] [int] NULL,
	[Quantity] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Customer]    Script Date: 9/28/2019 12:44:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Customer](
	[Customer_ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](30) NULL,
	[Address] [varchar](30) NULL,
	[Contact] [varchar](11) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Items]    Script Date: 9/28/2019 12:44:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Items](
	[Items_ID] [int] IDENTITY(1,1) NOT NULL,
	[Items_Name] [varchar](50) NULL,
	[Price] [float] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[_Order] ON 

INSERT [dbo].[_Order] ([Order_ID], [Customer_ID], [Items_ID], [Quantity]) VALUES (1, 22, 3, 5)
INSERT [dbo].[_Order] ([Order_ID], [Customer_ID], [Items_ID], [Quantity]) VALUES (2, 21, 2, 3)
INSERT [dbo].[_Order] ([Order_ID], [Customer_ID], [Items_ID], [Quantity]) VALUES (3, 22, 2, 7)
INSERT [dbo].[_Order] ([Order_ID], [Customer_ID], [Items_ID], [Quantity]) VALUES (5, 21, 2, 9)
SET IDENTITY_INSERT [dbo].[_Order] OFF
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([Customer_ID], [Name], [Address], [Contact]) VALUES (21, N'siam', N'comilla', N'01919320888')
INSERT [dbo].[Customer] ([Customer_ID], [Name], [Address], [Contact]) VALUES (22, N'nazmul', N'comilla', N'01919320888')
SET IDENTITY_INSERT [dbo].[Customer] OFF
SET IDENTITY_INSERT [dbo].[Items] ON 

INSERT [dbo].[Items] ([Items_ID], [Items_Name], [Price]) VALUES (1, N'Black', 120)
INSERT [dbo].[Items] ([Items_ID], [Items_Name], [Price]) VALUES (2, N'Cold', 100)
INSERT [dbo].[Items] ([Items_ID], [Items_Name], [Price]) VALUES (3, N'Regular', 90)
INSERT [dbo].[Items] ([Items_ID], [Items_Name], [Price]) VALUES (4, N'Hot', 95)
SET IDENTITY_INSERT [dbo].[Items] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__Customer__737584F6D76B1AAC]    Script Date: 9/28/2019 12:44:05 PM ******/
ALTER TABLE [dbo].[Customer] ADD UNIQUE NONCLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__Items__2B66507F162589C5]    Script Date: 9/28/2019 12:44:05 PM ******/
ALTER TABLE [dbo].[Items] ADD UNIQUE NONCLUSTERED 
(
	[Items_Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
