USE [VeganWebsite]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 6/25/2021 9:35:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[IdAcc] [bigint] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](50) NOT NULL,
	[PassWo] [varchar](50) NOT NULL,
	[ConfirmPass] [varchar](50) NOT NULL,
	[IdType] [int] NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[IdAcc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Combo]    Script Date: 6/25/2021 9:35:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Combo](
	[IdCombo] [varchar](50) NOT NULL,
	[ComboName] [varchar](50) NOT NULL,
	[ComboPrice] [float] NULL,
	[NumberOfFoods] [int] NULL,
	[NumberOfDinks] [int] NULL,
	[NumberOfPerson] [int] NOT NULL,
	[Quantitysold] [bigint] NULL,
	[ImgCombo] [varchar](500) NOT NULL,
	[Status] [int] NULL,
 CONSTRAINT [PK_Combo] PRIMARY KEY CLUSTERED 
(
	[IdCombo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ComboDrinkDetail]    Script Date: 6/25/2021 9:35:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ComboDrinkDetail](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdCombo] [varchar](50) NOT NULL,
	[IdDrink] [varchar](50) NOT NULL,
	[Price] [float] NULL,
 CONSTRAINT [PK_ComboDrinkDetail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ComboFoodDetail]    Script Date: 6/25/2021 9:35:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ComboFoodDetail](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdCombo] [varchar](50) NOT NULL,
	[IdFood] [varchar](50) NOT NULL,
	[Price] [float] NULL,
 CONSTRAINT [PK_ComboFoodDetail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Comment]    Script Date: 6/25/2021 9:35:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comment](
	[IdComment] [int] IDENTITY(1,1) NOT NULL,
	[IdProduct] [varchar](50) NOT NULL,
	[Comments] [nvarchar](500) NOT NULL,
	[IdAcc] [bigint] NOT NULL,
 CONSTRAINT [PK_Comment] PRIMARY KEY CLUSTERED 
(
	[IdComment] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 6/25/2021 9:35:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[IdCustomer] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](100) NOT NULL,
	[Phone] [char](10) NOT NULL,
	[Address] [nvarchar](500) NOT NULL,
	[Email] [nvarchar](500) NULL,
	[IdAcc] [bigint] NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[IdCustomer] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Drink]    Script Date: 6/25/2021 9:35:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Drink](
	[IdDrink] [varchar](50) NOT NULL,
	[DrinkName] [nvarchar](50) NOT NULL,
	[DrinkPrice] [float] NOT NULL,
	[Drinkmaterial] [nvarchar](50) NULL,
	[Quantitysold] [bigint] NULL,
	[ImgDrink] [varchar](500) NOT NULL,
	[Status] [int] NULL,
 CONSTRAINT [PK_Drink] PRIMARY KEY CLUSTERED 
(
	[IdDrink] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Food]    Script Date: 6/25/2021 9:35:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Food](
	[IdFood] [varchar](50) NOT NULL,
	[FoodName] [nvarchar](100) NOT NULL,
	[FoodPrice] [float] NOT NULL,
	[Foodmaterial] [nvarchar](500) NULL,
	[Quantitysold] [bigint] NULL,
	[ImgFood] [varchar](500) NOT NULL,
	[Status] [int] NULL,
 CONSTRAINT [PK_Food] PRIMARY KEY CLUSTERED 
(
	[IdFood] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Foundation]    Script Date: 6/25/2021 9:35:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Foundation](
	[IdFound] [int] NOT NULL,
	[FoundationName] [nvarchar](500) NOT NULL,
	[ContentFound] [nvarchar](max) NULL,
	[TotalCash] [float] NOT NULL,
	[ImgFound] [varchar](500) NULL,
	[Link] [varchar](500) NULL,
	[Status] [int] NOT NULL,
 CONSTRAINT [PK_Foundation] PRIMARY KEY CLUSTERED 
(
	[IdFound] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 6/25/2021 9:35:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[IdOrder] [int] IDENTITY(1,1) NOT NULL,
	[IdCustomer] [int] NOT NULL,
	[Date] [datetime] NOT NULL,
	[SumOfProduct] [int] NULL,
	[IdFoundation] [int] NOT NULL,
	[Discount] [float] NULL,
	[TotalCash] [float] NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[IdOrder] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetail]    Script Date: 6/25/2021 9:35:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetail](
	[Serial] [int] IDENTITY(1,1) NOT NULL,
	[IdOrder] [int] NOT NULL,
	[IdFood] [varchar](50) NULL,
	[IdDrink] [varchar](50) NULL,
	[IdCombo] [varchar](50) NULL,
	[Amount] [int] NOT NULL,
	[Price] [float] NOT NULL,
	[IntoMoney] [float] NOT NULL,
 CONSTRAINT [PK_OrderDetail_1] PRIMARY KEY CLUSTERED 
(
	[Serial] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Permission]    Script Date: 6/25/2021 9:35:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permission](
	[IdPermission] [varchar](50) NOT NULL,
	[NamePer] [varchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdPermission] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Type]    Script Date: 6/25/2021 9:35:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Type](
	[IdTypeMember] [int] NOT NULL,
	[TypeName] [varchar](50) NULL,
	[Preferential] [varchar](50) NULL,
 CONSTRAINT [PK__Type__DC4FCBD52F368272] PRIMARY KEY CLUSTERED 
(
	[IdTypeMember] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TypePermission]    Script Date: 6/25/2021 9:35:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TypePermission](
	[IdType] [int] NOT NULL,
	[IdPermission] [varchar](50) NOT NULL,
	[Notes] [varchar](500) NULL,
 CONSTRAINT [PK__tmp_ms_x__AB45CC5617003E11] PRIMARY KEY CLUSTERED 
(
	[IdType] ASC,
	[IdPermission] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Account] ON 

INSERT [dbo].[Account] ([IdAcc], [Username], [PassWo], [ConfirmPass], [IdType]) VALUES (1, N'adminvegan', N'ddcd5a372f28de381c7d9253b641522f', N'ddcd5a372f28de381c7d9253b641522f', 1)
INSERT [dbo].[Account] ([IdAcc], [Username], [PassWo], [ConfirmPass], [IdType]) VALUES (2, N'hoangkhoa', N'e10adc3949ba59abbe56e057f20f883e', N'e10adc3949ba59abbe56e057f20f883e', 2)
INSERT [dbo].[Account] ([IdAcc], [Username], [PassWo], [ConfirmPass], [IdType]) VALUES (3, N'tinhvan', N'e10adc3949ba59abbe56e057f20f883e', N'e10adc3949ba59abbe56e057f20f883e', 2)
INSERT [dbo].[Account] ([IdAcc], [Username], [PassWo], [ConfirmPass], [IdType]) VALUES (4, N'minhanh', N'c97adbc39377ddd1099741b1fc291878', N'c97adbc39377ddd1099741b1fc291878', 2)
INSERT [dbo].[Account] ([IdAcc], [Username], [PassWo], [ConfirmPass], [IdType]) VALUES (5, N'mylinhit', N'e10adc3949ba59abbe56e057f20f883e', N'e10adc3949ba59abbe56e057f20f883e', 2)
INSERT [dbo].[Account] ([IdAcc], [Username], [PassWo], [ConfirmPass], [IdType]) VALUES (6, N'nhuquynh', N'202cb962ac59075b964b07152d234b70', N'202cb962ac59075b964b07152d234b70', 2)
INSERT [dbo].[Account] ([IdAcc], [Username], [PassWo], [ConfirmPass], [IdType]) VALUES (7, N'linhit', N'e042f11a6889c81bf5e743c5a0cb482b', N'e042f11a6889c81bf5e743c5a0cb482b', 2)
INSERT [dbo].[Account] ([IdAcc], [Username], [PassWo], [ConfirmPass], [IdType]) VALUES (8, N'linhtinh', N'e10adc3949ba59abbe56e057f20f883e', N'e10adc3949ba59abbe56e057f20f883e', NULL)
INSERT [dbo].[Account] ([IdAcc], [Username], [PassWo], [ConfirmPass], [IdType]) VALUES (9, N'abc', N'e10adc3949ba59abbe56e057f20f883e', N'e10adc3949ba59abbe56e057f20f883e', NULL)
SET IDENTITY_INSERT [dbo].[Account] OFF
GO
INSERT [dbo].[Combo] ([IdCombo], [ComboName], [ComboPrice], [NumberOfFoods], [NumberOfDinks], [NumberOfPerson], [Quantitysold], [ImgCombo], [Status]) VALUES (N'CB1', N'Combo 1', 12.5, 3, 2, 3, 1, N'/Content/images/combo1.jpg', 1)
INSERT [dbo].[Combo] ([IdCombo], [ComboName], [ComboPrice], [NumberOfFoods], [NumberOfDinks], [NumberOfPerson], [Quantitysold], [ImgCombo], [Status]) VALUES (N'CB2', N'Combo 2', 18.5, 6, 2, 2, 3, N'/Content/images/combo2.jpg', 1)
INSERT [dbo].[Combo] ([IdCombo], [ComboName], [ComboPrice], [NumberOfFoods], [NumberOfDinks], [NumberOfPerson], [Quantitysold], [ImgCombo], [Status]) VALUES (N'CB3', N'Combo 3', 20.5, 6, 3, 3, 2, N'/Content/images/combo3.jpg', 1)
INSERT [dbo].[Combo] ([IdCombo], [ComboName], [ComboPrice], [NumberOfFoods], [NumberOfDinks], [NumberOfPerson], [Quantitysold], [ImgCombo], [Status]) VALUES (N'CB4', N'Combo 4', 21.5, 6, 3, 3, 0, N'/Content/images/combo4.jpg', 1)
INSERT [dbo].[Combo] ([IdCombo], [ComboName], [ComboPrice], [NumberOfFoods], [NumberOfDinks], [NumberOfPerson], [Quantitysold], [ImgCombo], [Status]) VALUES (N'CB5', N'Combo 5', 26.5, 7, 4, 4, 0, N'/Content/images/combo5.jpg', 1)
INSERT [dbo].[Combo] ([IdCombo], [ComboName], [ComboPrice], [NumberOfFoods], [NumberOfDinks], [NumberOfPerson], [Quantitysold], [ImgCombo], [Status]) VALUES (N'CB6', N'Combo 6', 10.5, 3, 2, 2, 1, N'/Content/images/combo6.jpg', 1)
GO
SET IDENTITY_INSERT [dbo].[ComboDrinkDetail] ON 

INSERT [dbo].[ComboDrinkDetail] ([Id], [IdCombo], [IdDrink], [Price]) VALUES (2, N'CB1', N'JGRAPEFRUIT', 1)
INSERT [dbo].[ComboDrinkDetail] ([Id], [IdCombo], [IdDrink], [Price]) VALUES (3, N'CB1', N'WMILK', 2)
INSERT [dbo].[ComboDrinkDetail] ([Id], [IdCombo], [IdDrink], [Price]) VALUES (4, N'CB2', N'JAPPLECARROT', 2)
INSERT [dbo].[ComboDrinkDetail] ([Id], [IdCombo], [IdDrink], [Price]) VALUES (5, N'CB2', N'JCELERY', 1)
INSERT [dbo].[ComboDrinkDetail] ([Id], [IdCombo], [IdDrink], [Price]) VALUES (6, N'CB3', N'JCUCUMBER', 1)
INSERT [dbo].[ComboDrinkDetail] ([Id], [IdCombo], [IdDrink], [Price]) VALUES (7, N'CB3', N'JGUAVA', 1)
INSERT [dbo].[ComboDrinkDetail] ([Id], [IdCombo], [IdDrink], [Price]) VALUES (8, N'CB3', N'JPOME', 2)
INSERT [dbo].[ComboDrinkDetail] ([Id], [IdCombo], [IdDrink], [Price]) VALUES (9, N'CB4', N'JMULBERRY', 1)
INSERT [dbo].[ComboDrinkDetail] ([Id], [IdCombo], [IdDrink], [Price]) VALUES (10, N'CB4', N'JWATERMELON', 1)
INSERT [dbo].[ComboDrinkDetail] ([Id], [IdCombo], [IdDrink], [Price]) VALUES (11, N'CB4', N'WMILK', 2)
INSERT [dbo].[ComboDrinkDetail] ([Id], [IdCombo], [IdDrink], [Price]) VALUES (12, N'CB5', N'JAPPLE', 1)
INSERT [dbo].[ComboDrinkDetail] ([Id], [IdCombo], [IdDrink], [Price]) VALUES (13, N'CB5', N'JAPPLEPIN', 2)
INSERT [dbo].[ComboDrinkDetail] ([Id], [IdCombo], [IdDrink], [Price]) VALUES (14, N'CB5', N'JCUCUMBER', 1)
INSERT [dbo].[ComboDrinkDetail] ([Id], [IdCombo], [IdDrink], [Price]) VALUES (15, N'CB5', N'JPOME', 2)
INSERT [dbo].[ComboDrinkDetail] ([Id], [IdCombo], [IdDrink], [Price]) VALUES (16, N'CB6', N'JCELERY', 1)
INSERT [dbo].[ComboDrinkDetail] ([Id], [IdCombo], [IdDrink], [Price]) VALUES (17, N'CB6', N'JPOME', 2)
SET IDENTITY_INSERT [dbo].[ComboDrinkDetail] OFF
GO
SET IDENTITY_INSERT [dbo].[ComboFoodDetail] ON 

INSERT [dbo].[ComboFoodDetail] ([Id], [IdCombo], [IdFood], [Price]) VALUES (2, N'CB1', N'SFRUIT', 3.5)
INSERT [dbo].[ComboFoodDetail] ([Id], [IdCombo], [IdFood], [Price]) VALUES (4, N'CB1', N'TACO', 3)
INSERT [dbo].[ComboFoodDetail] ([Id], [IdCombo], [IdFood], [Price]) VALUES (6, N'CB1', N'VSPRINGROLL', 3)
INSERT [dbo].[ComboFoodDetail] ([Id], [IdCombo], [IdFood], [Price]) VALUES (7, N'CB2', N'FRYMUSH', 2.5)
INSERT [dbo].[ComboFoodDetail] ([Id], [IdCombo], [IdFood], [Price]) VALUES (8, N'CB2', N'REDBEANSOUP', 3)
INSERT [dbo].[ComboFoodDetail] ([Id], [IdCombo], [IdFood], [Price]) VALUES (9, N'CB2', N'SCUCUMBER', 2)
INSERT [dbo].[ComboFoodDetail] ([Id], [IdCombo], [IdFood], [Price]) VALUES (10, N'CB2', N'SFRUIT', 3.5)
INSERT [dbo].[ComboFoodDetail] ([Id], [IdCombo], [IdFood], [Price]) VALUES (11, N'CB2', N'SREDP', 3)
INSERT [dbo].[ComboFoodDetail] ([Id], [IdCombo], [IdFood], [Price]) VALUES (12, N'CB2', N'TOFUMUSHROOM', 2.5)
INSERT [dbo].[ComboFoodDetail] ([Id], [IdCombo], [IdFood], [Price]) VALUES (13, N'CB3', N'PUMPKINSOUP', 3)
INSERT [dbo].[ComboFoodDetail] ([Id], [IdCombo], [IdFood], [Price]) VALUES (14, N'CB3', N'SFRUIT', 3.5)
INSERT [dbo].[ComboFoodDetail] ([Id], [IdCombo], [IdFood], [Price]) VALUES (15, N'CB3', N'SPCABBAGE', 1.5)
INSERT [dbo].[ComboFoodDetail] ([Id], [IdCombo], [IdFood], [Price]) VALUES (16, N'CB3', N'TACO', 3)
INSERT [dbo].[ComboFoodDetail] ([Id], [IdCombo], [IdFood], [Price]) VALUES (17, N'CB3', N'TOFUFRY', 2.5)
INSERT [dbo].[ComboFoodDetail] ([Id], [IdCombo], [IdFood], [Price]) VALUES (18, N'CB3', N'TOFUSFRY', 3)
INSERT [dbo].[ComboFoodDetail] ([Id], [IdCombo], [IdFood], [Price]) VALUES (19, N'CB4', N'FRYMUSH', 2.5)
INSERT [dbo].[ComboFoodDetail] ([Id], [IdCombo], [IdFood], [Price]) VALUES (20, N'CB4', N'SCUCUMBER', 2)
INSERT [dbo].[ComboFoodDetail] ([Id], [IdCombo], [IdFood], [Price]) VALUES (21, N'CB4', N'SEAWEEDLOTUS', 3.5)
INSERT [dbo].[ComboFoodDetail] ([Id], [IdCombo], [IdFood], [Price]) VALUES (22, N'CB4', N'SOLIVE', 3.5)
INSERT [dbo].[ComboFoodDetail] ([Id], [IdCombo], [IdFood], [Price]) VALUES (23, N'CB4', N'SREDP', 3)
INSERT [dbo].[ComboFoodDetail] ([Id], [IdCombo], [IdFood], [Price]) VALUES (24, N'CB4', N'TOFUMUSHROOM', 3)
INSERT [dbo].[ComboFoodDetail] ([Id], [IdCombo], [IdFood], [Price]) VALUES (25, N'CB5', N'REDBEANSOUP', 3)
INSERT [dbo].[ComboFoodDetail] ([Id], [IdCombo], [IdFood], [Price]) VALUES (26, N'CB5', N'SAVOCADO', 3)
INSERT [dbo].[ComboFoodDetail] ([Id], [IdCombo], [IdFood], [Price]) VALUES (27, N'CB5', N'SFRUIT', 3.5)
INSERT [dbo].[ComboFoodDetail] ([Id], [IdCombo], [IdFood], [Price]) VALUES (28, N'CB5', N'SOLIVE', 3.5)
INSERT [dbo].[ComboFoodDetail] ([Id], [IdCombo], [IdFood], [Price]) VALUES (29, N'CB5', N'SPCABBAGE', 1.5)
INSERT [dbo].[ComboFoodDetail] ([Id], [IdCombo], [IdFood], [Price]) VALUES (30, N'CB5', N'TOFUSFRY', 3)
INSERT [dbo].[ComboFoodDetail] ([Id], [IdCombo], [IdFood], [Price]) VALUES (31, N'CB5', N'VSPRINGROLL', 3)
INSERT [dbo].[ComboFoodDetail] ([Id], [IdCombo], [IdFood], [Price]) VALUES (32, N'CB6', N'SAVOCADO', 3)
INSERT [dbo].[ComboFoodDetail] ([Id], [IdCombo], [IdFood], [Price]) VALUES (33, N'CB6', N'SPCABBAGE', 1.5)
INSERT [dbo].[ComboFoodDetail] ([Id], [IdCombo], [IdFood], [Price]) VALUES (34, N'CB6', N'TACO', 3)
SET IDENTITY_INSERT [dbo].[ComboFoodDetail] OFF
GO
SET IDENTITY_INSERT [dbo].[Comment] ON 

INSERT [dbo].[Comment] ([IdComment], [IdProduct], [Comments], [IdAcc]) VALUES (1, N'SAVOCADO', N'goooodddd', 2)
INSERT [dbo].[Comment] ([IdComment], [IdProduct], [Comments], [IdAcc]) VALUES (2, N'C1', N'delicous', 3)
INSERT [dbo].[Comment] ([IdComment], [IdProduct], [Comments], [IdAcc]) VALUES (3, N'SCUCUMBER', N'okkkkkkkkkkkkk', 4)
INSERT [dbo].[Comment] ([IdComment], [IdProduct], [Comments], [IdAcc]) VALUES (4, N'SAVOCADO', N'goooodddd', 2)
INSERT [dbo].[Comment] ([IdComment], [IdProduct], [Comments], [IdAcc]) VALUES (5, N'TACO', N'it is so delicous!', 3)
INSERT [dbo].[Comment] ([IdComment], [IdProduct], [Comments], [IdAcc]) VALUES (6, N'TACO', N'it is so delicous!', 3)
INSERT [dbo].[Comment] ([IdComment], [IdProduct], [Comments], [IdAcc]) VALUES (7, N'TACO', N'it is so delicious', 3)
INSERT [dbo].[Comment] ([IdComment], [IdProduct], [Comments], [IdAcc]) VALUES (8, N'JGRAPEFRUIT', N'amazinggggggggg!', 3)
INSERT [dbo].[Comment] ([IdComment], [IdProduct], [Comments], [IdAcc]) VALUES (9, N'REDBEANSOUP', N'it is so delicious! I''ll buy it more again', 8)
INSERT [dbo].[Comment] ([IdComment], [IdProduct], [Comments], [IdAcc]) VALUES (10, N'CB6', N'fast delivery, fresh meal, drinks so goooooooddddddd', 8)
INSERT [dbo].[Comment] ([IdComment], [IdProduct], [Comments], [IdAcc]) VALUES (11, N'SCUCUMBER', N'it is so delicious! I''ll buy it more again', 3)
INSERT [dbo].[Comment] ([IdComment], [IdProduct], [Comments], [IdAcc]) VALUES (12, N'JCELERY', N'amazinggggggggg!', 2)
SET IDENTITY_INSERT [dbo].[Comment] OFF
GO
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([IdCustomer], [FullName], [Phone], [Address], [Email], [IdAcc]) VALUES (1, N'Pham Hoang Khoa', N'0986587453', N'Ward 10, Tan Binh District, Ho Chi Minh City', N'hoangkhoa89@gmail.com', 2)
INSERT [dbo].[Customer] ([IdCustomer], [FullName], [Phone], [Address], [Email], [IdAcc]) VALUES (2, N'Tan Tinh Van', N'0896574124', N'Linh Dong Ward, Thu Duc City, Ho Chi Minh City', N'tinhvan2000@gmail.com', 3)
INSERT [dbo].[Customer] ([IdCustomer], [FullName], [Phone], [Address], [Email], [IdAcc]) VALUES (3, N'Nguyen Minh Anh', N'0325413987', N'abc, xyz, Ho Chi Minh City', N'minhanhnguyen_@gmail.com', 4)
INSERT [dbo].[Customer] ([IdCustomer], [FullName], [Phone], [Address], [Email], [IdAcc]) VALUES (4, N'Doan Le My Linh', N'1236547890', N'abc, xyz, Binh Duong', N'linhit@gmail.com', 5)
INSERT [dbo].[Customer] ([IdCustomer], [FullName], [Phone], [Address], [Email], [IdAcc]) VALUES (5, N'Doan Le My Linh', N'0213546   ', N'hcm', N'mylinh21012000@gmail.com', 8)
INSERT [dbo].[Customer] ([IdCustomer], [FullName], [Phone], [Address], [Email], [IdAcc]) VALUES (6, N'Doan Le My Linh', N'0213546   ', N'hcm', N'mylinh21012000@gmail.com', 9)
SET IDENTITY_INSERT [dbo].[Customer] OFF
GO
INSERT [dbo].[Drink] ([IdDrink], [DrinkName], [DrinkPrice], [Drinkmaterial], [Quantitysold], [ImgDrink], [Status]) VALUES (N'JAPPLE', N'Apple juice', 1, N'Apple, sugar', 0, N'/Content/images/applejuice.jpg', 1)
INSERT [dbo].[Drink] ([IdDrink], [DrinkName], [DrinkPrice], [Drinkmaterial], [Quantitysold], [ImgDrink], [Status]) VALUES (N'JAPPLECARROT', N'Apple carrot juice', 2, N'Apple, carrot, sugar', 0, N'/Content/images/eptaocarot.jpg', 1)
INSERT [dbo].[Drink] ([IdDrink], [DrinkName], [DrinkPrice], [Drinkmaterial], [Quantitysold], [ImgDrink], [Status]) VALUES (N'JAPPLEPIN', N'Apple pineapple juice', 2, N'Apple, pineapple, honey', 2, N'/Content/images/eptaodua.jpg', 1)
INSERT [dbo].[Drink] ([IdDrink], [DrinkName], [DrinkPrice], [Drinkmaterial], [Quantitysold], [ImgDrink], [Status]) VALUES (N'JCELERY', N'Celery juice', 1, N'Celery juice, sugar, green apple', 4, N'/Content/images/cantaydrink.jpg', 1)
INSERT [dbo].[Drink] ([IdDrink], [DrinkName], [DrinkPrice], [Drinkmaterial], [Quantitysold], [ImgDrink], [Status]) VALUES (N'JCUCUMBER', N'Cucuber juice', 1, N'Cucumber, sugar', 1, N'/Content/images/dualeoep.jpg', 1)
INSERT [dbo].[Drink] ([IdDrink], [DrinkName], [DrinkPrice], [Drinkmaterial], [Quantitysold], [ImgDrink], [Status]) VALUES (N'JGRAPEFRUIT', N'Grapefruit juice', 1, N'Grapefruit juice, honey', 3, N'/Content/images/epbuoi.jpg', 1)
INSERT [dbo].[Drink] ([IdDrink], [DrinkName], [DrinkPrice], [Drinkmaterial], [Quantitysold], [ImgDrink], [Status]) VALUES (N'JGUAVA', N'Guava juice', 1, N'Guava, sugar', 1, N'/Content/images/oiep.jpg', 1)
INSERT [dbo].[Drink] ([IdDrink], [DrinkName], [DrinkPrice], [Drinkmaterial], [Quantitysold], [ImgDrink], [Status]) VALUES (N'JMULBERRY', N'Mulberry juice', 1, N'Mulberry, sugar', 0, N'/Content/images/mulberry.jpg', 1)
INSERT [dbo].[Drink] ([IdDrink], [DrinkName], [DrinkPrice], [Drinkmaterial], [Quantitysold], [ImgDrink], [Status]) VALUES (N'JORANGE', N'Orange juice', 1, N'Orange, honey', 0, N'/Content/images/orange.jpg', 1)
INSERT [dbo].[Drink] ([IdDrink], [DrinkName], [DrinkPrice], [Drinkmaterial], [Quantitysold], [ImgDrink], [Status]) VALUES (N'JPASSIONFRUIT', N'Passion fruit', 1.5, N'Passion fruit, sugar or honey', 2, N'/Content/images/nuocchanhday.png', 1)
INSERT [dbo].[Drink] ([IdDrink], [DrinkName], [DrinkPrice], [Drinkmaterial], [Quantitysold], [ImgDrink], [Status]) VALUES (N'JPOME', N'Pomegranate juice', 2, N'Pomegranate, honey, lemon', 2, N'/Content/images/nuocepluu.jpg', 1)
INSERT [dbo].[Drink] ([IdDrink], [DrinkName], [DrinkPrice], [Drinkmaterial], [Quantitysold], [ImgDrink], [Status]) VALUES (N'JWATERMELON', N'Watermelon juice', 1, N'watermelon, sugar', 0, N'/Content/images/watermelonjuice.jpg', 1)
INSERT [dbo].[Drink] ([IdDrink], [DrinkName], [DrinkPrice], [Drinkmaterial], [Quantitysold], [ImgDrink], [Status]) VALUES (N'WMILK', N'Walnut milk', 2, N'Walnut, sugar', 0, N'/Content/images/suahat.jpg', 1)
GO
INSERT [dbo].[Food] ([IdFood], [FoodName], [FoodPrice], [Foodmaterial], [Quantitysold], [ImgFood], [Status]) VALUES (N'FRYMUSH', N'Deep fried mushrooms', 3, N'Mushrooms, flour', 0, N'/Content/images/namromchien.jpg', 1)
INSERT [dbo].[Food] ([IdFood], [FoodName], [FoodPrice], [Foodmaterial], [Quantitysold], [ImgFood], [Status]) VALUES (N'PORRI', N'Mushroom porridge', 2.5, N'mushroom, rice, vegetables', 0, N'/Content/images/chaochay.jpg', 1)
INSERT [dbo].[Food] ([IdFood], [FoodName], [FoodPrice], [Foodmaterial], [Quantitysold], [ImgFood], [Status]) VALUES (N'PUMPKINSOUP', N'Pumpkin Soup', 3, N'Pumpkin, peanut, coriander, green onion', 0, N'/Content/images/canhbido.jpg', 1)
INSERT [dbo].[Food] ([IdFood], [FoodName], [FoodPrice], [Foodmaterial], [Quantitysold], [ImgFood], [Status]) VALUES (N'REDBEANSOUP', N'Red bean soup', 3, N'Red bean, carrot, potato, lotus seeds, green onion, coriander, white bean', 7, N'/Content/images/supdaudo.jpg', 1)
INSERT [dbo].[Food] ([IdFood], [FoodName], [FoodPrice], [Foodmaterial], [Quantitysold], [ImgFood], [Status]) VALUES (N'SAVOCADO', N'Avocado Salad', 2, N'Avocado, carrot, tomato, apple, lollo lettuce, dressing roasted sesame', 4, N'/Content/images/saladavocado.jpg', 1)
INSERT [dbo].[Food] ([IdFood], [FoodName], [FoodPrice], [Foodmaterial], [Quantitysold], [ImgFood], [Status]) VALUES (N'SCUCUMBER', N'Cucumber Salad', 2, N'Cucumber, Walnut, Cashew, vinegar sauce', 3, N'/Content/images/saladduachuot.jpg', 1)
INSERT [dbo].[Food] ([IdFood], [FoodName], [FoodPrice], [Foodmaterial], [Quantitysold], [ImgFood], [Status]) VALUES (N'SEAWEEDLOTUS', N'Lotus seed seaweed soup', 4, N'Seaweed, lotus seeds, mushroom, ginger', 0, N'/Content/images/rongbien.jpg', 1)
INSERT [dbo].[Food] ([IdFood], [FoodName], [FoodPrice], [Foodmaterial], [Quantitysold], [ImgFood], [Status]) VALUES (N'SFRUIT', N'Fruit salad', 4, N'Strawberry, mango, cucumber, lollo lettuce, yogurt sauce', 1, N'/Content/images/saladfruit.jpg', 1)
INSERT [dbo].[Food] ([IdFood], [FoodName], [FoodPrice], [Foodmaterial], [Quantitysold], [ImgFood], [Status]) VALUES (N'SOLIVE', N'Olive salad', 4, N'Olive, cucumber, tomato, lollo lettuce, dressing roasted sesame', 0, N'/Content/images/saladolive.jpg', 1)
INSERT [dbo].[Food] ([IdFood], [FoodName], [FoodPrice], [Foodmaterial], [Quantitysold], [ImgFood], [Status]) VALUES (N'SPCABBAGE', N'Purple cabbage', 2, N'Purple cabbage, tomato, cucumber, lollo lettuce, dressing roasted sesame', 0, N'/Content/images/saladbapcai.jpg', 1)
INSERT [dbo].[Food] ([IdFood], [FoodName], [FoodPrice], [Foodmaterial], [Quantitysold], [ImgFood], [Status]) VALUES (N'SREDP', N'Red Pomegranate Salad', 3, N'Red pomegranate, cucumber, tomato, yellow bell pepper, red bell pepper, purple cabbage, lollo lettuce, dressing roasted sesame', 0, N'/Content/images/saladluudo.jpg', 1)
INSERT [dbo].[Food] ([IdFood], [FoodName], [FoodPrice], [Foodmaterial], [Quantitysold], [ImgFood], [Status]) VALUES (N'TACO', N'Vegetarian Taco', 3, N'Taco shell, purple onion, lollo lettuce, avocado, bell pepper', 4, N'/Content/images/taco.jpg', 1)
INSERT [dbo].[Food] ([IdFood], [FoodName], [FoodPrice], [Foodmaterial], [Quantitysold], [ImgFood], [Status]) VALUES (N'TOFUFRY', N'Braised tofu with lemongrass', 3, N'Tofu, lemongrass, chilli, coriander', 0, N'/Content/images/dauhukhoxa.jpg', 1)
INSERT [dbo].[Food] ([IdFood], [FoodName], [FoodPrice], [Foodmaterial], [Quantitysold], [ImgFood], [Status]) VALUES (N'TOFUMUSHROOM', N'Stir-fried tofu with mushrooms', 3, N'Tofu, mushroom, carrot, coriander', 0, N'/Content/images/dauhuxaonam.jpg', 1)
INSERT [dbo].[Food] ([IdFood], [FoodName], [FoodPrice], [Foodmaterial], [Quantitysold], [ImgFood], [Status]) VALUES (N'TOFUSFRY', N'Stir-fried tofu with vegetables', 3, N'Tofu, lotus root, carrot, turnip, mushrooms', 0, N'/Content/images/dauhuxaoraucu.jpg', 1)
INSERT [dbo].[Food] ([IdFood], [FoodName], [FoodPrice], [Foodmaterial], [Quantitysold], [ImgFood], [Status]) VALUES (N'VSPRINGROLL', N'Vegetarian spring rolls', 3, N'Mushrooms, green bean, lotus seeds, green onion, carrot, sweet potato', 0, N'/Content/images/nemchay.jpg', 1)
GO
INSERT [dbo].[Foundation] ([IdFound], [FoundationName], [ContentFound], [TotalCash], [ImgFound], [Link], [Status]) VALUES (1, N'Cặp lá yêu thương', N' “Cặp lá yêu thương” là dự án thiện nguyện do Trung tâm Sản xuất và Phát triển Nội dung Số (tiền thân là Trung tâm Tin tức VTV24) khởi xướng. Lấy hình ảnh chiếc lá bồ đề - biểu tượng thiêng liêng của Phật giáo làm hình tượng xuyên suốt, “Cặp lá yêu thương” là cầu nối để các nhà hảo tâm hỗ trợ các hoàn cảnh khó khăn vươn lên trong cuộc sống, góp phần lan tỏa tình yêu thương nhân ái trong mỗi cá nhân, mỗi gia đình Việt và xây dựng một xã hội tốt đẹp giàu tính nhân văn.', 1.3, N'/Content/images/caplayeuthuong.png', N'http://caplayeuthuong.vtv24.vtv.vn/', 1)
INSERT [dbo].[Foundation] ([IdFound], [FoundationName], [ContentFound], [TotalCash], [ImgFound], [Link], [Status]) VALUES (2, N'Quỹ Sống', N'Quỹ Sống là quỹ xã hội hoạt động không vì lợi nhuận, nhằm mục đích tham gia hỗ trợ người dân vùng bị ảnh hưởng bởi thiên tai và biến đổi khí hậu, giúp họ có được cuộc sống an toàn, ổn định và phát triển cộng đồng bền vững.', 4.65, N'/Content/images/songfoundation.jpg', N'https://song.org.vn/ve-quy-song/', 1)
INSERT [dbo].[Foundation] ([IdFound], [FoundationName], [ContentFound], [TotalCash], [ImgFound], [Link], [Status]) VALUES (3, N'Trái tim cho em', N'“Trái tim cho em” là chương trình từ thiện nhân đạo do Tập đoàn Công nghiệp - Viễn thông Quân đội (Viettel) và Quỹ Tấm Lòng Việt – Đài Truyền hình Việt Nam phối hợp thực hiện. Theo đó chương trình thực hiện phẫu thuật tim miễn phí cho trẻ em nghèo dưới 16 tuổi tại Việt Nam tài trợ nâng cao năng lực khám chữa các bệnh về tim mạch cho hệ thống y tế tại Việt Nam tổ chức các hoạt động khám sàng lọc bệnh tim bẩm sinh dành cho trẻ em khu vực vùng sâu vùng xa để giúp phát hiện và điều trị kịp thời cho các em nhỏ mắc bệnh tim bẩm sinh.', 2.65, N'/Content/images/traitimchoem.png', N'http://traitimchoem.vn/page/gioi-thieu', 1)
INSERT [dbo].[Foundation] ([IdFound], [FoundationName], [ContentFound], [TotalCash], [ImgFound], [Link], [Status]) VALUES (4, N'Quỹ Vaccine phòng Covid-19', N'Toàn thế giới hiện nay đang nỗ lực chống chọi với đại dịch Covid-19. Trong bối cảnh đó thì ngày 1/6. Thống đốc Ngân hàng Nhà nước Việt Nam Nguyễn Thị Hồng đã ký ban hành văn bản về việc miễn phí chuyển tiền ủng hộ Quỹ vaccine phòng COVID-19. Nội dung công văn nêu rõ, nhằm góp phần tạo thuận lợi cho các tổ chức, cá nhân đóng góp, hỗ trợ Quỹ vaccine phòng COVID-19, qua đó thể hiện tinh thần trách nhiệm, chia sẻ của ngành ngân hàng trong bối cảnh cả nước chung tay phòng, chống dịch COVID-19, Ngân hàng Nhà nước đề nghị các tổ chức tín dụng, chi nhánh ngân hàng nước ngoài khẩn trương xem xét, triển khai áp dụng chính sách miễn phí đối với các giao dịch chuyển tiền của các tổ chức, cá nhân tới các số tài khoản tiếp nhận tiền đóng góp cho Quỹ vaccine phòng COVID-19.', 10.600000000000001, N'/Content/images/tiem-vacxin.jpg', N'http://baochinhphu.vn/Kinh-te/Mien-phi-chuyen-tien-ung-ho-Quy-vaccine-phong-COVID19/433263.vgp', 1)
GO
SET IDENTITY_INSERT [dbo].[Order] ON 

INSERT [dbo].[Order] ([IdOrder], [IdCustomer], [Date], [SumOfProduct], [IdFoundation], [Discount], [TotalCash]) VALUES (1, 1, CAST(N'2020-12-08T00:00:00.000' AS DateTime), 3, 1, 0, 8)
INSERT [dbo].[Order] ([IdOrder], [IdCustomer], [Date], [SumOfProduct], [IdFoundation], [Discount], [TotalCash]) VALUES (2, 2, CAST(N'2020-12-20T00:00:00.000' AS DateTime), 4, 4, 0, 61)
INSERT [dbo].[Order] ([IdOrder], [IdCustomer], [Date], [SumOfProduct], [IdFoundation], [Discount], [TotalCash]) VALUES (3, 3, CAST(N'2021-06-21T00:00:00.000' AS DateTime), 5, 3, 0, 27.5)
INSERT [dbo].[Order] ([IdOrder], [IdCustomer], [Date], [SumOfProduct], [IdFoundation], [Discount], [TotalCash]) VALUES (4, 1, CAST(N'2021-06-19T02:57:20.587' AS DateTime), 1, 2, 0, 1)
INSERT [dbo].[Order] ([IdOrder], [IdCustomer], [Date], [SumOfProduct], [IdFoundation], [Discount], [TotalCash]) VALUES (5, 2, CAST(N'2021-06-19T21:40:25.620' AS DateTime), 1, 2, 0, 6)
INSERT [dbo].[Order] ([IdOrder], [IdCustomer], [Date], [SumOfProduct], [IdFoundation], [Discount], [TotalCash]) VALUES (6, 2, CAST(N'2021-06-19T21:47:23.713' AS DateTime), 2, 1, 0, 5)
INSERT [dbo].[Order] ([IdOrder], [IdCustomer], [Date], [SumOfProduct], [IdFoundation], [Discount], [TotalCash]) VALUES (7, 5, CAST(N'2021-06-20T12:40:15.463' AS DateTime), 2, 4, 0, 8)
INSERT [dbo].[Order] ([IdOrder], [IdCustomer], [Date], [SumOfProduct], [IdFoundation], [Discount], [TotalCash]) VALUES (8, 5, CAST(N'2021-06-20T12:58:15.060' AS DateTime), 2, 2, 0, 19.5)
INSERT [dbo].[Order] ([IdOrder], [IdCustomer], [Date], [SumOfProduct], [IdFoundation], [Discount], [TotalCash]) VALUES (9, 2, CAST(N'2021-06-20T23:05:53.020' AS DateTime), 1, 3, 0, 6)
INSERT [dbo].[Order] ([IdOrder], [IdCustomer], [Date], [SumOfProduct], [IdFoundation], [Discount], [TotalCash]) VALUES (10, 1, CAST(N'2021-06-22T14:28:28.040' AS DateTime), 2, 2, 0, 13)
INSERT [dbo].[Order] ([IdOrder], [IdCustomer], [Date], [SumOfProduct], [IdFoundation], [Discount], [TotalCash]) VALUES (11, 6, CAST(N'2021-06-22T14:32:50.617' AS DateTime), 1, 4, 0, 37)
SET IDENTITY_INSERT [dbo].[Order] OFF
GO
SET IDENTITY_INSERT [dbo].[OrderDetail] ON 

INSERT [dbo].[OrderDetail] ([Serial], [IdOrder], [IdFood], [IdDrink], [IdCombo], [Amount], [Price], [IntoMoney]) VALUES (1, 1, N'SAVOCADO', NULL, NULL, 1, 2, 2)
INSERT [dbo].[OrderDetail] ([Serial], [IdOrder], [IdFood], [IdDrink], [IdCombo], [Amount], [Price], [IntoMoney]) VALUES (2, 1, N'SCUCUMBER', NULL, NULL, 1, 2, 2)
INSERT [dbo].[OrderDetail] ([Serial], [IdOrder], [IdFood], [IdDrink], [IdCombo], [Amount], [Price], [IntoMoney]) VALUES (3, 1, N'SFRUIT', NULL, NULL, 1, 4, 4)
INSERT [dbo].[OrderDetail] ([Serial], [IdOrder], [IdFood], [IdDrink], [IdCombo], [Amount], [Price], [IntoMoney]) VALUES (4, 2, NULL, NULL, N'CB1', 1, 11, 11)
INSERT [dbo].[OrderDetail] ([Serial], [IdOrder], [IdFood], [IdDrink], [IdCombo], [Amount], [Price], [IntoMoney]) VALUES (5, 2, N'SAVOCADO', NULL, NULL, 3, 2, 6)
INSERT [dbo].[OrderDetail] ([Serial], [IdOrder], [IdFood], [IdDrink], [IdCombo], [Amount], [Price], [IntoMoney]) VALUES (6, 3, NULL, N'JGUAVA', NULL, 1, 1, 1)
INSERT [dbo].[OrderDetail] ([Serial], [IdOrder], [IdFood], [IdDrink], [IdCombo], [Amount], [Price], [IntoMoney]) VALUES (7, 3, NULL, N'JPASSIONFRUIT', NULL, 2, 1.5, 3)
INSERT [dbo].[OrderDetail] ([Serial], [IdOrder], [IdFood], [IdDrink], [IdCombo], [Amount], [Price], [IntoMoney]) VALUES (8, 3, N'TACO', NULL, NULL, 1, 3, 3)
INSERT [dbo].[OrderDetail] ([Serial], [IdOrder], [IdFood], [IdDrink], [IdCombo], [Amount], [Price], [IntoMoney]) VALUES (9, 3, NULL, NULL, N'CB2', 1, 18.5, 18.5)
INSERT [dbo].[OrderDetail] ([Serial], [IdOrder], [IdFood], [IdDrink], [IdCombo], [Amount], [Price], [IntoMoney]) VALUES (10, 3, NULL, N'JAPPLEPIN', NULL, 1, 2, 2)
INSERT [dbo].[OrderDetail] ([Serial], [IdOrder], [IdFood], [IdDrink], [IdCombo], [Amount], [Price], [IntoMoney]) VALUES (11, 2, NULL, NULL, N'CB3', 2, 20.5, 41)
INSERT [dbo].[OrderDetail] ([Serial], [IdOrder], [IdFood], [IdDrink], [IdCombo], [Amount], [Price], [IntoMoney]) VALUES (12, 2, N'TACO', NULL, NULL, 1, 3, 3)
INSERT [dbo].[OrderDetail] ([Serial], [IdOrder], [IdFood], [IdDrink], [IdCombo], [Amount], [Price], [IntoMoney]) VALUES (13, 4, NULL, N'JCUCUMBER', NULL, 1, 1, 1)
INSERT [dbo].[OrderDetail] ([Serial], [IdOrder], [IdFood], [IdDrink], [IdCombo], [Amount], [Price], [IntoMoney]) VALUES (14, 5, NULL, N'JGRAPEFRUIT', NULL, 3, 1, 3)
INSERT [dbo].[OrderDetail] ([Serial], [IdOrder], [IdFood], [IdDrink], [IdCombo], [Amount], [Price], [IntoMoney]) VALUES (15, 6, N'REDBEANSOUP', NULL, NULL, 1, 3, 3)
INSERT [dbo].[OrderDetail] ([Serial], [IdOrder], [IdFood], [IdDrink], [IdCombo], [Amount], [Price], [IntoMoney]) VALUES (16, 6, NULL, N'JAPPLEPIN', NULL, 1, 2, 2)
INSERT [dbo].[OrderDetail] ([Serial], [IdOrder], [IdFood], [IdDrink], [IdCombo], [Amount], [Price], [IntoMoney]) VALUES (17, 7, N'SCUCUMBER', NULL, NULL, 2, 2, 4)
INSERT [dbo].[OrderDetail] ([Serial], [IdOrder], [IdFood], [IdDrink], [IdCombo], [Amount], [Price], [IntoMoney]) VALUES (18, 7, NULL, N'JPOME', NULL, 2, 2, 4)
INSERT [dbo].[OrderDetail] ([Serial], [IdOrder], [IdFood], [IdDrink], [IdCombo], [Amount], [Price], [IntoMoney]) VALUES (19, 8, N'REDBEANSOUP', NULL, NULL, 3, 3, 9)
INSERT [dbo].[OrderDetail] ([Serial], [IdOrder], [IdFood], [IdDrink], [IdCombo], [Amount], [Price], [IntoMoney]) VALUES (20, 8, NULL, NULL, N'CB6', 1, 10.5, 10.5)
INSERT [dbo].[OrderDetail] ([Serial], [IdOrder], [IdFood], [IdDrink], [IdCombo], [Amount], [Price], [IntoMoney]) VALUES (21, 9, N'TACO', NULL, NULL, 2, 3, 6)
INSERT [dbo].[OrderDetail] ([Serial], [IdOrder], [IdFood], [IdDrink], [IdCombo], [Amount], [Price], [IntoMoney]) VALUES (22, 10, N'REDBEANSOUP', NULL, NULL, 3, 3, 9)
INSERT [dbo].[OrderDetail] ([Serial], [IdOrder], [IdFood], [IdDrink], [IdCombo], [Amount], [Price], [IntoMoney]) VALUES (23, 10, NULL, N'JCELERY', NULL, 4, 1, 4)
INSERT [dbo].[OrderDetail] ([Serial], [IdOrder], [IdFood], [IdDrink], [IdCombo], [Amount], [Price], [IntoMoney]) VALUES (24, 11, NULL, NULL, N'CB2', 2, 18.5, 37)
SET IDENTITY_INSERT [dbo].[OrderDetail] OFF
GO
INSERT [dbo].[Permission] ([IdPermission], [NamePer]) VALUES (N'Ad', N'Admin')
INSERT [dbo].[Permission] ([IdPermission], [NamePer]) VALUES (N'Mem', N'Member')
GO
INSERT [dbo].[Type] ([IdTypeMember], [TypeName], [Preferential]) VALUES (1, N'Admin', N'0')
INSERT [dbo].[Type] ([IdTypeMember], [TypeName], [Preferential]) VALUES (2, N'Customer', N'0')
GO
INSERT [dbo].[TypePermission] ([IdType], [IdPermission], [Notes]) VALUES (1, N'Ad', NULL)
INSERT [dbo].[TypePermission] ([IdType], [IdPermission], [Notes]) VALUES (1, N'Mem', NULL)
INSERT [dbo].[TypePermission] ([IdType], [IdPermission], [Notes]) VALUES (2, N'Mem', NULL)
GO
ALTER TABLE [dbo].[Account] ADD  CONSTRAINT [DF_Account_IdType]  DEFAULT ((2)) FOR [IdType]
GO
ALTER TABLE [dbo].[Combo] ADD  CONSTRAINT [DF_Combo_ComboPrice]  DEFAULT ((0)) FOR [ComboPrice]
GO
ALTER TABLE [dbo].[Combo] ADD  CONSTRAINT [DF_Combo_NumberOfFoods]  DEFAULT ((0)) FOR [NumberOfFoods]
GO
ALTER TABLE [dbo].[Combo] ADD  CONSTRAINT [DF_Combo_NumberOfDinks]  DEFAULT ((0)) FOR [NumberOfDinks]
GO
ALTER TABLE [dbo].[Combo] ADD  CONSTRAINT [DF_Combo_Quantitysold]  DEFAULT ((0)) FOR [Quantitysold]
GO
ALTER TABLE [dbo].[Combo] ADD  CONSTRAINT [DF_Combo_Status]  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[Drink] ADD  CONSTRAINT [DF_Drink_Quantitysold_1]  DEFAULT ((0)) FOR [Quantitysold]
GO
ALTER TABLE [dbo].[Drink] ADD  CONSTRAINT [DF_Drink_Status]  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[Food] ADD  CONSTRAINT [DF_Food_Quantitysold_1]  DEFAULT ((0)) FOR [Quantitysold]
GO
ALTER TABLE [dbo].[Food] ADD  CONSTRAINT [DF_Food_status]  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[Foundation] ADD  CONSTRAINT [DF_Foundation_Status]  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[Order] ADD  CONSTRAINT [DF_Order_SumOfProduct]  DEFAULT ((0)) FOR [SumOfProduct]
GO
ALTER TABLE [dbo].[Order] ADD  CONSTRAINT [DF_Order_Discount]  DEFAULT ((0)) FOR [Discount]
GO
ALTER TABLE [dbo].[Order] ADD  CONSTRAINT [DF_Order_TotalCash]  DEFAULT ((0)) FOR [TotalCash]
GO
ALTER TABLE [dbo].[Type] ADD  CONSTRAINT [DF_Type_IdTypeMember]  DEFAULT ((2)) FOR [IdTypeMember]
GO
ALTER TABLE [dbo].[Account]  WITH CHECK ADD  CONSTRAINT [FK_Account_Type] FOREIGN KEY([IdType])
REFERENCES [dbo].[Type] ([IdTypeMember])
GO
ALTER TABLE [dbo].[Account] CHECK CONSTRAINT [FK_Account_Type]
GO
ALTER TABLE [dbo].[ComboDrinkDetail]  WITH CHECK ADD  CONSTRAINT [FK_ComboDrinkDetail_Combo] FOREIGN KEY([IdCombo])
REFERENCES [dbo].[Combo] ([IdCombo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ComboDrinkDetail] CHECK CONSTRAINT [FK_ComboDrinkDetail_Combo]
GO
ALTER TABLE [dbo].[ComboDrinkDetail]  WITH CHECK ADD  CONSTRAINT [FK_ComboDrinkDetail_Drink] FOREIGN KEY([IdDrink])
REFERENCES [dbo].[Drink] ([IdDrink])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ComboDrinkDetail] CHECK CONSTRAINT [FK_ComboDrinkDetail_Drink]
GO
ALTER TABLE [dbo].[ComboFoodDetail]  WITH CHECK ADD  CONSTRAINT [FK_ComboFoodDetail_Combo] FOREIGN KEY([IdCombo])
REFERENCES [dbo].[Combo] ([IdCombo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ComboFoodDetail] CHECK CONSTRAINT [FK_ComboFoodDetail_Combo]
GO
ALTER TABLE [dbo].[ComboFoodDetail]  WITH CHECK ADD  CONSTRAINT [FK_ComboFoodDetail_Food] FOREIGN KEY([IdFood])
REFERENCES [dbo].[Food] ([IdFood])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ComboFoodDetail] CHECK CONSTRAINT [FK_ComboFoodDetail_Food]
GO
ALTER TABLE [dbo].[Comment]  WITH CHECK ADD  CONSTRAINT [FK_Comment_Account] FOREIGN KEY([IdAcc])
REFERENCES [dbo].[Account] ([IdAcc])
GO
ALTER TABLE [dbo].[Comment] CHECK CONSTRAINT [FK_Comment_Account]
GO
ALTER TABLE [dbo].[Customer]  WITH CHECK ADD  CONSTRAINT [FK_Customer_Account] FOREIGN KEY([IdAcc])
REFERENCES [dbo].[Account] ([IdAcc])
GO
ALTER TABLE [dbo].[Customer] CHECK CONSTRAINT [FK_Customer_Account]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Customer] FOREIGN KEY([IdCustomer])
REFERENCES [dbo].[Customer] ([IdCustomer])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Customer]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Foundation] FOREIGN KEY([IdFoundation])
REFERENCES [dbo].[Foundation] ([IdFound])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Foundation]
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetail_Combo] FOREIGN KEY([IdCombo])
REFERENCES [dbo].[Combo] ([IdCombo])
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK_OrderDetail_Combo]
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetail_Drink] FOREIGN KEY([IdDrink])
REFERENCES [dbo].[Drink] ([IdDrink])
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK_OrderDetail_Drink]
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetail_Food] FOREIGN KEY([IdFood])
REFERENCES [dbo].[Food] ([IdFood])
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK_OrderDetail_Food]
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetail_Order] FOREIGN KEY([IdOrder])
REFERENCES [dbo].[Order] ([IdOrder])
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK_OrderDetail_Order]
GO
ALTER TABLE [dbo].[TypePermission]  WITH CHECK ADD  CONSTRAINT [FK_TypePermission_IdPermission] FOREIGN KEY([IdPermission])
REFERENCES [dbo].[Permission] ([IdPermission])
GO
ALTER TABLE [dbo].[TypePermission] CHECK CONSTRAINT [FK_TypePermission_IdPermission]
GO
ALTER TABLE [dbo].[TypePermission]  WITH CHECK ADD  CONSTRAINT [FK_TypePermission_IdType] FOREIGN KEY([IdType])
REFERENCES [dbo].[Type] ([IdTypeMember])
GO
ALTER TABLE [dbo].[TypePermission] CHECK CONSTRAINT [FK_TypePermission_IdType]
GO
