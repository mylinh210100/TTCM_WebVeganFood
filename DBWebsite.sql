USE [master]
GO
/****** Object:  Database [VeganWebsite]    Script Date: 6/22/2021 12:16:50 AM ******/
CREATE DATABASE [VeganWebsite]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'VeganWebsite', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\VeganWebsite.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'VeganWebsite_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\VeganWebsite_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [VeganWebsite] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [VeganWebsite].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [VeganWebsite] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [VeganWebsite] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [VeganWebsite] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [VeganWebsite] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [VeganWebsite] SET ARITHABORT OFF 
GO
ALTER DATABASE [VeganWebsite] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [VeganWebsite] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [VeganWebsite] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [VeganWebsite] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [VeganWebsite] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [VeganWebsite] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [VeganWebsite] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [VeganWebsite] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [VeganWebsite] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [VeganWebsite] SET  DISABLE_BROKER 
GO
ALTER DATABASE [VeganWebsite] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [VeganWebsite] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [VeganWebsite] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [VeganWebsite] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [VeganWebsite] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [VeganWebsite] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [VeganWebsite] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [VeganWebsite] SET RECOVERY FULL 
GO
ALTER DATABASE [VeganWebsite] SET  MULTI_USER 
GO
ALTER DATABASE [VeganWebsite] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [VeganWebsite] SET DB_CHAINING OFF 
GO
ALTER DATABASE [VeganWebsite] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [VeganWebsite] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [VeganWebsite] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [VeganWebsite] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'VeganWebsite', N'ON'
GO
ALTER DATABASE [VeganWebsite] SET QUERY_STORE = OFF
GO
USE [VeganWebsite]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 6/22/2021 12:16:50 AM ******/
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
/****** Object:  Table [dbo].[Combo]    Script Date: 6/22/2021 12:16:50 AM ******/
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
/****** Object:  Table [dbo].[ComboDrinkDetail]    Script Date: 6/22/2021 12:16:50 AM ******/
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
/****** Object:  Table [dbo].[ComboFoodDetail]    Script Date: 6/22/2021 12:16:50 AM ******/
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
/****** Object:  Table [dbo].[Comment]    Script Date: 6/22/2021 12:16:50 AM ******/
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
/****** Object:  Table [dbo].[Customer]    Script Date: 6/22/2021 12:16:50 AM ******/
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
/****** Object:  Table [dbo].[Drink]    Script Date: 6/22/2021 12:16:50 AM ******/
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
/****** Object:  Table [dbo].[Food]    Script Date: 6/22/2021 12:16:50 AM ******/
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
/****** Object:  Table [dbo].[Foundation]    Script Date: 6/22/2021 12:16:50 AM ******/
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
/****** Object:  Table [dbo].[Order]    Script Date: 6/22/2021 12:16:50 AM ******/
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
/****** Object:  Table [dbo].[OrderDetail]    Script Date: 6/22/2021 12:16:50 AM ******/
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
/****** Object:  Table [dbo].[Permission]    Script Date: 6/22/2021 12:16:50 AM ******/
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
/****** Object:  Table [dbo].[Type]    Script Date: 6/22/2021 12:16:50 AM ******/
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
/****** Object:  Table [dbo].[TypePermission]    Script Date: 6/22/2021 12:16:50 AM ******/
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
/****** Object:  StoredProcedure [dbo].[sp_Check_Login]    Script Date: 6/22/2021 12:16:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Check_Login]
@UserName varchar(50),
@PassWord varchar(50)
AS
BEGIN
	DECLARE @count int
	DECLARE @rs bit

	SELECT @count = COUNT(*) FROM Account a WHERE a.UserName = @UserName and a.PaWo = @PassWord

	IF @count > 0
		SET @rs = 1
	ELSE 
		SET @rs = 0

	SELECT @rs
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Combo_Insert]    Script Date: 6/22/2021 12:16:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Combo_Insert]
	@id char(10),
	@name nvarchar(50),
	@numofperson int,
	@src varchar(500)
AS
BEGIN
	insert into Combo(IdCombo, ComboName, NumberOfPerson, ImgCombo)
	values (@id, @name, @numofperson, @src) 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_detail]    Script Date: 6/22/2021 12:16:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_detail]
@id int
as
begin
	select a.IdOrder, a.Serial, b.FoodName, c.DrinkName, d.ComboName, a.Amount, a.Price
	from OrderDetail a, Food b, Drink c, Combo d
	where a.IdOrder = @id and b.IdFood = a.IdFood and c.IdDrink = a.IdDrink and d.IdCombo = a.IdCombo
end
GO
/****** Object:  StoredProcedure [dbo].[sp_Drink_Insert]    Script Date: 6/22/2021 12:16:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Drink_Insert]
	@id varchar(50),
	@name nvarchar(50),
	@price float,
	@material nvarchar(50),
	@src varchar(500)
AS
BEGIN
	insert into Drink(IdDrink, DrinkName, DrinkPrice, Drinkmaterial, ImgDrink)
	values (@id, @name, @price, @material, @src) 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Food_Insert]    Script Date: 6/22/2021 12:16:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Food_Insert]
	@id varchar(50),
	@name nvarchar(50),
	@price float,
	@material nvarchar(500),
	@src varchar(500)
AS
BEGIN
	insert into Food(IdFood, FoodName, FoodPrice, Foodmaterial, ImgFood)
	values (@id, @name, @price, @material, @src) 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Select_idFood]    Script Date: 6/22/2021 12:16:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Select_idFood]
AS
BEGIN
	SELECT IdFood
	FROM Food
END
GO
/****** Object:  StoredProcedure [dbo].[sp_viewdetail]    Script Date: 6/22/2021 12:16:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE	PROCEDURE [dbo].[sp_viewdetail]
@id int 
AS
BEGIN
	SELECT *
	FROM  OrderDetail b
	WHERE b.IdOrder = @id 
END
GO
USE [master]
GO
ALTER DATABASE [VeganWebsite] SET  READ_WRITE 
GO
