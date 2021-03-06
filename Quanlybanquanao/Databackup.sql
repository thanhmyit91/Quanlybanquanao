USE [master]
GO
/****** Object:  Database [Quanlybanhang]    Script Date: 09/08/2016 23:26:45 ******/
CREATE DATABASE [Quanlybanhang] ON  PRIMARY 
( NAME = N'BANHANG', FILENAME = N'D:\MY-LIENTHONG\NOP\Database\Quanlybanhang.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'BANHANG_log', FILENAME = N'D:\MY-LIENTHONG\NOP\Database\Quanlybanhang_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Quanlybanhang] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Quanlybanhang].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Quanlybanhang] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [Quanlybanhang] SET ANSI_NULLS OFF
GO
ALTER DATABASE [Quanlybanhang] SET ANSI_PADDING OFF
GO
ALTER DATABASE [Quanlybanhang] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [Quanlybanhang] SET ARITHABORT OFF
GO
ALTER DATABASE [Quanlybanhang] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [Quanlybanhang] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [Quanlybanhang] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [Quanlybanhang] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [Quanlybanhang] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [Quanlybanhang] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [Quanlybanhang] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [Quanlybanhang] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [Quanlybanhang] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [Quanlybanhang] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [Quanlybanhang] SET  DISABLE_BROKER
GO
ALTER DATABASE [Quanlybanhang] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [Quanlybanhang] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [Quanlybanhang] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [Quanlybanhang] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [Quanlybanhang] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [Quanlybanhang] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [Quanlybanhang] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [Quanlybanhang] SET  READ_WRITE
GO
ALTER DATABASE [Quanlybanhang] SET RECOVERY FULL
GO
ALTER DATABASE [Quanlybanhang] SET  MULTI_USER
GO
ALTER DATABASE [Quanlybanhang] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [Quanlybanhang] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'Quanlybanhang', N'ON'
GO
USE [Quanlybanhang]
GO
/****** Object:  Table [dbo].[tbl_User]    Script Date: 09/08/2016 23:26:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_User](
	[User_ID] [varchar](50) NOT NULL,
	[User_Pass] [nvarchar](250) NOT NULL,
	[User_Name] [nvarchar](50) NOT NULL,
	[IsActive] [bit] NULL,
	[IsDelete] [bit] NULL,
	[CreatedDate] [smalldatetime] NULL,
	[CreatedBy] [varchar](50) NULL,
	[ModifiedDate] [smalldatetime] NULL,
	[ModifiedBy] [varchar](50) NULL,
 CONSTRAINT [PK_tbl_User] PRIMARY KEY CLUSTERED 
(
	[User_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tbl_User] ([User_ID], [User_Pass], [User_Name], [IsActive], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy]) VALUES (N'aa', N'E10ADC3949BA59ABBE56E057F20F883E', N'aa', 1, 1, CAST(0xA64D042D AS SmallDateTime), N'admin', NULL, NULL)
INSERT [dbo].[tbl_User] ([User_ID], [User_Pass], [User_Name], [IsActive], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy]) VALUES (N'admin', N'E10ADC3949BA59ABBE56E057F20F883E', N'Quản trị', 1, 0, CAST(0xA64D042D AS SmallDateTime), N'admin', NULL, NULL)
/****** Object:  Table [dbo].[tbl_Supplier]    Script Date: 09/08/2016 23:26:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Supplier](
	[Supplier_ID] [varchar](20) NOT NULL,
	[Supplier_Name] [nvarchar](50) NOT NULL,
	[Supplier_Phone] [varchar](20) NULL,
	[Supplier_Address] [nvarchar](500) NULL,
	[Supplier_Email] [nvarchar](250) NULL,
	[Supplier_Facbook] [nvarchar](250) NULL,
	[Supplier_Zalo] [nvarchar](250) NULL,
	[Supplier_Description] [nvarchar](500) NULL,
	[IsActive] [bit] NULL,
	[IsDelete] [bit] NULL,
	[CreatedDate] [smalldatetime] NULL,
	[CreatedBy] [varchar](50) NULL,
	[ModifiedDate] [smalldatetime] NULL,
	[ModifiedBy] [varchar](50) NULL,
 CONSTRAINT [PK_tbl_Supplier] PRIMARY KEY CLUSTERED 
(
	[Supplier_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tbl_Supplier] ([Supplier_ID], [Supplier_Name], [Supplier_Phone], [Supplier_Address], [Supplier_Email], [Supplier_Facbook], [Supplier_Zalo], [Supplier_Description], [IsActive], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy]) VALUES (N'1', N'Chị tuyến', N'093433333', N'', N'', N'', N'', N'', 1, 0, CAST(0xA64D042C AS SmallDateTime), N'admin', NULL, NULL)
INSERT [dbo].[tbl_Supplier] ([Supplier_ID], [Supplier_Name], [Supplier_Phone], [Supplier_Address], [Supplier_Email], [Supplier_Facbook], [Supplier_Zalo], [Supplier_Description], [IsActive], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy]) VALUES (N'NCC0000002', N'Khách mặc định', N'09321222221', N'', N'', N'', N'', N'', 1, 0, CAST(0xA64D042C AS SmallDateTime), N'admin', NULL, NULL)
INSERT [dbo].[tbl_Supplier] ([Supplier_ID], [Supplier_Name], [Supplier_Phone], [Supplier_Address], [Supplier_Email], [Supplier_Facbook], [Supplier_Zalo], [Supplier_Description], [IsActive], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy]) VALUES (N'NCC0000003', N'NCC 002', N'0912345333', N'', N'', N'', N'', N'', 1, 0, CAST(0xA64D042C AS SmallDateTime), N'admin', NULL, NULL)
INSERT [dbo].[tbl_Supplier] ([Supplier_ID], [Supplier_Name], [Supplier_Phone], [Supplier_Address], [Supplier_Email], [Supplier_Facbook], [Supplier_Zalo], [Supplier_Description], [IsActive], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy]) VALUES (N'NCC0000004', N'my', N'0932123992', N'', N'', N'', N'', N'', 1, 0, CAST(0xA64D042C AS SmallDateTime), N'admin', NULL, NULL)
/****** Object:  Table [dbo].[tbl_SendType]    Script Date: 09/08/2016 23:26:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_SendType](
	[SendType_ID] [int] IDENTITY(1,1) NOT NULL,
	[SendType_Name] [nvarchar](50) NOT NULL,
	[SendType_Description] [nvarchar](250) NULL,
	[IsActive] [bit] NULL,
	[IsDelete] [bit] NULL,
	[CreatedDate] [smalldatetime] NULL,
	[CreatedBy] [varchar](50) NULL,
	[ModifiedDate] [smalldatetime] NULL,
	[ModifiedBy] [varchar](50) NULL,
	[Orderindex] [int] NULL,
 CONSTRAINT [PK_tbl_SendType] PRIMARY KEY CLUSTERED 
(
	[SendType_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_SendType] ON
INSERT [dbo].[tbl_SendType] ([SendType_ID], [SendType_Name], [SendType_Description], [IsActive], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Orderindex]) VALUES (1, N'Gửi xe', N'Gửi xe', 1, 0, CAST(0xA64D042C AS SmallDateTime), N'admin', NULL, NULL, 2)
INSERT [dbo].[tbl_SendType] ([SendType_ID], [SendType_Name], [SendType_Description], [IsActive], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Orderindex]) VALUES (2, N'Gửi bưu điện', N'', 1, 0, CAST(0xA64D042C AS SmallDateTime), N'admin', NULL, NULL, 0)
INSERT [dbo].[tbl_SendType] ([SendType_ID], [SendType_Name], [SendType_Description], [IsActive], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Orderindex]) VALUES (3, N'Giao hàng trong nội thành', N'', 1, 0, CAST(0xA64D042C AS SmallDateTime), N'admin', NULL, NULL, 1)
SET IDENTITY_INSERT [dbo].[tbl_SendType] OFF
/****** Object:  Table [dbo].[tbl_ProductQuantity]    Script Date: 09/08/2016 23:26:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_ProductQuantity](
	[ProductID] [varchar](10) NOT NULL,
	[Quantity] [numeric](18, 0) NOT NULL,
	[QuantitySale] [numeric](18, 0) NOT NULL,
 CONSTRAINT [PK_tbl_ProductQuantity] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tbl_ProductQuantity] ([ProductID], [Quantity], [QuantitySale]) VALUES (N'SP001', CAST(13 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)))
INSERT [dbo].[tbl_ProductQuantity] ([ProductID], [Quantity], [QuantitySale]) VALUES (N'SP002', CAST(39 AS Numeric(18, 0)), CAST(25 AS Numeric(18, 0)))
INSERT [dbo].[tbl_ProductQuantity] ([ProductID], [Quantity], [QuantitySale]) VALUES (N'SP003', CAST(36 AS Numeric(18, 0)), CAST(-3 AS Numeric(18, 0)))
/****** Object:  Table [dbo].[tbl_Product]    Script Date: 09/08/2016 23:26:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Product](
	[Product_ID] [varchar](50) NOT NULL,
	[Product_ColorID] [int] NOT NULL,
	[Product_ModelID] [varchar](50) NOT NULL,
	[Product_Name] [nvarchar](250) NOT NULL,
	[Product_Description] [nvarchar](500) NULL,
	[IsActive] [bit] NULL,
	[IsDelete] [bit] NULL,
	[CreatedDate] [smalldatetime] NULL,
	[CreatedBy] [varchar](50) NULL,
	[ModifiedDate] [smalldatetime] NULL,
	[ModifiedBy] [varchar](50) NULL,
 CONSTRAINT [PK_tbl_Product] PRIMARY KEY CLUSTERED 
(
	[Product_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tbl_Product] ([Product_ID], [Product_ColorID], [Product_ModelID], [Product_Name], [Product_Description], [IsActive], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy]) VALUES (N'SP001', 2, N'A01', N'Sản phẩm 1', N'Mô tả', 1, 0, CAST(0xA64D042C AS SmallDateTime), N'admin', NULL, NULL)
INSERT [dbo].[tbl_Product] ([Product_ID], [Product_ColorID], [Product_ModelID], [Product_Name], [Product_Description], [IsActive], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy]) VALUES (N'SP002', 3, N'A01', N'SP 002', N'', 1, 0, CAST(0xA64D042C AS SmallDateTime), N'admin', NULL, NULL)
INSERT [dbo].[tbl_Product] ([Product_ID], [Product_ColorID], [Product_ModelID], [Product_Name], [Product_Description], [IsActive], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy]) VALUES (N'SP003', 2, N'A01', N'Sản phẩm test 001', N'', 1, 0, CAST(0xA64D042C AS SmallDateTime), N'admin', NULL, NULL)
/****** Object:  Table [dbo].[tbl_PriceType]    Script Date: 09/08/2016 23:26:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_PriceType](
	[PriceType_ID] [int] IDENTITY(1,1) NOT NULL,
	[PriceType_Name] [nvarchar](50) NOT NULL,
	[PriceType_Description] [nvarchar](250) NULL,
	[IsActive] [bit] NULL,
	[IsDelete] [bit] NULL,
	[CreatedDate] [smalldatetime] NULL,
	[CreatedBy] [varchar](50) NULL,
	[ModifiedDate] [smalldatetime] NULL,
	[ModifiedBy] [varchar](50) NULL,
	[Orderindex] [int] NULL,
	[Isdefault] [bit] NULL,
 CONSTRAINT [PK_tbl_PriceType] PRIMARY KEY CLUSTERED 
(
	[PriceType_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_PriceType] ON
INSERT [dbo].[tbl_PriceType] ([PriceType_ID], [PriceType_Name], [PriceType_Description], [IsActive], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Orderindex], [Isdefault]) VALUES (1, N'Giá sỉ', N'', 1, 0, CAST(0xA64D042C AS SmallDateTime), N'admin', NULL, NULL, 1, 0)
INSERT [dbo].[tbl_PriceType] ([PriceType_ID], [PriceType_Name], [PriceType_Description], [IsActive], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Orderindex], [Isdefault]) VALUES (2, N'Giá lẻ', N'', 1, 0, CAST(0xA64D042C AS SmallDateTime), N'admin', NULL, NULL, 0, 1)
SET IDENTITY_INSERT [dbo].[tbl_PriceType] OFF
/****** Object:  Table [dbo].[tbl_Price]    Script Date: 09/08/2016 23:26:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Price](
	[Price_Type] [int] NOT NULL,
	[Price_Product] [varchar](50) NOT NULL,
	[Price_Now] [decimal](18, 4) NOT NULL,
	[Price_Old] [decimal](18, 4) NOT NULL,
	[Price_Description] [nvarchar](250) NULL,
	[ModifiedDate] [smalldatetime] NULL,
	[ModifiedBy] [varchar](50) NULL,
 CONSTRAINT [PK_tbl_Price] PRIMARY KEY CLUSTERED 
(
	[Price_Type] ASC,
	[Price_Product] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tbl_Price] ([Price_Type], [Price_Product], [Price_Now], [Price_Old], [Price_Description], [ModifiedDate], [ModifiedBy]) VALUES (2, N'SP001', CAST(80000.0000 AS Decimal(18, 4)), CAST(200002.0000 AS Decimal(18, 4)), N'ghi chú thay đổi', CAST(0xA64D0548 AS SmallDateTime), N'admin')
INSERT [dbo].[tbl_Price] ([Price_Type], [Price_Product], [Price_Now], [Price_Old], [Price_Description], [ModifiedDate], [ModifiedBy]) VALUES (2, N'SP002', CAST(70000.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), N'', CAST(0xA64D0548 AS SmallDateTime), N'admin')
INSERT [dbo].[tbl_Price] ([Price_Type], [Price_Product], [Price_Now], [Price_Old], [Price_Description], [ModifiedDate], [ModifiedBy]) VALUES (2, N'SP003', CAST(100000.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), N'', CAST(0xA64D0548 AS SmallDateTime), N'admin')
/****** Object:  Table [dbo].[tbl_Payments]    Script Date: 09/08/2016 23:26:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Payments](
	[Payments_ID] [varchar](20) NOT NULL,
	[Payments_Date] [smalldatetime] NULL,
	[Payments_Amount] [decimal](18, 4) NULL,
	[Payments_CustomerID] [varchar](20) NULL,
	[Payments_Vouchers] [varchar](20) NULL,
	[Payments_Description] [nvarchar](2000) NULL,
	[Payments_Type] [int] NULL,
	[IsDelete] [bit] NULL,
	[CreatedDate] [smalldatetime] NULL,
	[CreatedBy] [varchar](50) NULL,
	[ModifiedDate] [smalldatetime] NULL,
	[ModifiedBy] [varchar](50) NULL,
 CONSTRAINT [PK_tbl_Payments] PRIMARY KEY CLUSTERED 
(
	[Payments_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0 phiếu thu; 1 phiếu chi' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tbl_Payments', @level2type=N'COLUMN',@level2name=N'Payments_Type'
GO
INSERT [dbo].[tbl_Payments] ([Payments_ID], [Payments_Date], [Payments_Amount], [Payments_CustomerID], [Payments_Vouchers], [Payments_Description], [Payments_Type], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy]) VALUES (N'TC00000003', CAST(0xA64D042B AS SmallDateTime), CAST(200000.0000 AS Decimal(18, 4)), N'1', N'OD00000023', N'Thu tiền đơn hàng - OD00000023', 0, 0, CAST(0xA64D042B AS SmallDateTime), N'', NULL, NULL)
INSERT [dbo].[tbl_Payments] ([Payments_ID], [Payments_Date], [Payments_Amount], [Payments_CustomerID], [Payments_Vouchers], [Payments_Description], [Payments_Type], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy]) VALUES (N'TC00000004', CAST(0xA64D042B AS SmallDateTime), CAST(12000.0000 AS Decimal(18, 4)), N'1', N'', N'Mỹ kiểm traxxxxxxxxddđ', 0, 1, CAST(0xA64D042B AS SmallDateTime), N'', NULL, NULL)
INSERT [dbo].[tbl_Payments] ([Payments_ID], [Payments_Date], [Payments_Amount], [Payments_CustomerID], [Payments_Vouchers], [Payments_Description], [Payments_Type], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy]) VALUES (N'TC00000005', CAST(0xA64D042B AS SmallDateTime), CAST(200000.0000 AS Decimal(18, 4)), N'1', N'OD00000021', N'Thu tiền đơn hàng - OD00000021', 0, 0, CAST(0xA64D042B AS SmallDateTime), N'', NULL, NULL)
INSERT [dbo].[tbl_Payments] ([Payments_ID], [Payments_Date], [Payments_Amount], [Payments_CustomerID], [Payments_Vouchers], [Payments_Description], [Payments_Type], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy]) VALUES (N'TC00000006', CAST(0xA64D042B AS SmallDateTime), CAST(0.0000 AS Decimal(18, 4)), N'1', N'', N'', 0, 0, CAST(0xA64D042B AS SmallDateTime), N'admin', NULL, NULL)
INSERT [dbo].[tbl_Payments] ([Payments_ID], [Payments_Date], [Payments_Amount], [Payments_CustomerID], [Payments_Vouchers], [Payments_Description], [Payments_Type], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy]) VALUES (N'TC00000007', CAST(0xA64D042B AS SmallDateTime), CAST(10000.0000 AS Decimal(18, 4)), N'NCC0000004', N'', N'mỹ kiểm', 1, 0, CAST(0xA64D042B AS SmallDateTime), N'admin', NULL, NULL)
INSERT [dbo].[tbl_Payments] ([Payments_ID], [Payments_Date], [Payments_Amount], [Payments_CustomerID], [Payments_Vouchers], [Payments_Description], [Payments_Type], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy]) VALUES (N'TC00000008', CAST(0xA64D042B AS SmallDateTime), CAST(10000.0000 AS Decimal(18, 4)), N'NCC0000004', N'', N'', 1, 0, CAST(0xA64D042B AS SmallDateTime), N'', NULL, NULL)
INSERT [dbo].[tbl_Payments] ([Payments_ID], [Payments_Date], [Payments_Amount], [Payments_CustomerID], [Payments_Vouchers], [Payments_Description], [Payments_Type], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy]) VALUES (N'TC00000009', CAST(0xA64D042B AS SmallDateTime), CAST(600000.0000 AS Decimal(18, 4)), N'1', N'OD00000027', N'Thu tiền đơn hàng - OD00000027', 0, 0, CAST(0xA64D042B AS SmallDateTime), N'', NULL, NULL)
INSERT [dbo].[tbl_Payments] ([Payments_ID], [Payments_Date], [Payments_Amount], [Payments_CustomerID], [Payments_Vouchers], [Payments_Description], [Payments_Type], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy]) VALUES (N'TC00000010', CAST(0xA64D042B AS SmallDateTime), CAST(6889.0000 AS Decimal(18, 4)), N'1', N'IV00000005', N'Chi tiền đơn hàng - IV00000005', 1, 0, CAST(0xA64D042B AS SmallDateTime), N'', NULL, NULL)
INSERT [dbo].[tbl_Payments] ([Payments_ID], [Payments_Date], [Payments_Amount], [Payments_CustomerID], [Payments_Vouchers], [Payments_Description], [Payments_Type], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy]) VALUES (N'TC00000011', CAST(0xA64D042B AS SmallDateTime), CAST(5000.0000 AS Decimal(18, 4)), N'NCC0000003', N'IV00000006', N'Chi tiền phiếu nhập - IV00000006', 1, 0, CAST(0xA64D042B AS SmallDateTime), N'', NULL, NULL)
INSERT [dbo].[tbl_Payments] ([Payments_ID], [Payments_Date], [Payments_Amount], [Payments_CustomerID], [Payments_Vouchers], [Payments_Description], [Payments_Type], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy]) VALUES (N'TC00000012', CAST(0xA64D042B AS SmallDateTime), CAST(199999.0000 AS Decimal(18, 4)), N'1', N'OD00000018', N'Thu tiền đơn hàng - OD00000018', 0, 0, CAST(0xA64D042B AS SmallDateTime), N'', NULL, NULL)
INSERT [dbo].[tbl_Payments] ([Payments_ID], [Payments_Date], [Payments_Amount], [Payments_CustomerID], [Payments_Vouchers], [Payments_Description], [Payments_Type], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy]) VALUES (N'TC00000013', CAST(0xA64D042B AS SmallDateTime), CAST(100000.0000 AS Decimal(18, 4)), N'NCC0000002', N'IV00000007', N'Chi tiền phiếu nhập - IV00000007', 1, 0, CAST(0xA64D042B AS SmallDateTime), N'', NULL, NULL)
INSERT [dbo].[tbl_Payments] ([Payments_ID], [Payments_Date], [Payments_Amount], [Payments_CustomerID], [Payments_Vouchers], [Payments_Description], [Payments_Type], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy]) VALUES (N'TC00000014', CAST(0xA64D042B AS SmallDateTime), CAST(3100000.0000 AS Decimal(18, 4)), N'1', N'IV00000008', N'Chi tiền phiếu nhập - IV00000008', 1, 0, CAST(0xA64D042B AS SmallDateTime), N'admin', NULL, NULL)
INSERT [dbo].[tbl_Payments] ([Payments_ID], [Payments_Date], [Payments_Amount], [Payments_CustomerID], [Payments_Vouchers], [Payments_Description], [Payments_Type], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy]) VALUES (N'TC00000015', CAST(0xA64D042B AS SmallDateTime), CAST(340000.0000 AS Decimal(18, 4)), N'1', N'OD00000029', N'Thu tiền đơn hàng - OD00000029', 0, 0, CAST(0xA64D042B AS SmallDateTime), N'admin', NULL, NULL)
INSERT [dbo].[tbl_Payments] ([Payments_ID], [Payments_Date], [Payments_Amount], [Payments_CustomerID], [Payments_Vouchers], [Payments_Description], [Payments_Type], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy]) VALUES (N'TC00000016', CAST(0xA64D042B AS SmallDateTime), CAST(79000.0000 AS Decimal(18, 4)), N'1', N'OD00000031', N'Thu tiền đơn hàng - OD00000031', 0, 0, CAST(0xA64D042B AS SmallDateTime), N'', NULL, NULL)
INSERT [dbo].[tbl_Payments] ([Payments_ID], [Payments_Date], [Payments_Amount], [Payments_CustomerID], [Payments_Vouchers], [Payments_Description], [Payments_Type], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy]) VALUES (N'TC00000017', CAST(0xA64D042B AS SmallDateTime), CAST(4200000.0000 AS Decimal(18, 4)), N'NCC0000002', N'IV00000009', N'Chi tiền phiếu nhập - IV00000009', 1, 0, CAST(0xA64D042B AS SmallDateTime), N'admin', NULL, NULL)
INSERT [dbo].[tbl_Payments] ([Payments_ID], [Payments_Date], [Payments_Amount], [Payments_CustomerID], [Payments_Vouchers], [Payments_Description], [Payments_Type], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy]) VALUES (N'TC00000018', CAST(0xA64D042B AS SmallDateTime), CAST(336000.0000 AS Decimal(18, 4)), N'KH00000007', N'OD00000036', N'Thu tiền đơn hàng - OD00000036', 0, 0, CAST(0xA64D042B AS SmallDateTime), N'admin', NULL, NULL)
INSERT [dbo].[tbl_Payments] ([Payments_ID], [Payments_Date], [Payments_Amount], [Payments_CustomerID], [Payments_Vouchers], [Payments_Description], [Payments_Type], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy]) VALUES (N'TC00000019', CAST(0xA64D042B AS SmallDateTime), CAST(2400000.0000 AS Decimal(18, 4)), N'1', N'OD00000032', N'Thu tiền đơn hàng - OD00000032', 0, 0, CAST(0xA64D042B AS SmallDateTime), N'admin', NULL, NULL)
INSERT [dbo].[tbl_Payments] ([Payments_ID], [Payments_Date], [Payments_Amount], [Payments_CustomerID], [Payments_Vouchers], [Payments_Description], [Payments_Type], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy]) VALUES (N'TC00000021', CAST(0xA67B057C AS SmallDateTime), CAST(180000.0000 AS Decimal(18, 4)), N'KH00000007', N'OD00000041', N'Thu tiền đơn hàng - OD00000041', 0, 0, CAST(0xA67B057C AS SmallDateTime), N'admin', NULL, NULL)
INSERT [dbo].[tbl_Payments] ([Payments_ID], [Payments_Date], [Payments_Amount], [Payments_CustomerID], [Payments_Vouchers], [Payments_Description], [Payments_Type], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy]) VALUES (N'TC00000022', CAST(0xA67B057D AS SmallDateTime), CAST(0.0000 AS Decimal(18, 4)), N'NCC0000002', N'IV00000011', N'Chi tiền phiếu nhập - IV00000011', 1, 0, CAST(0xA67B057D AS SmallDateTime), N'admin', NULL, NULL)
/****** Object:  Table [dbo].[tbl_OutputDetail]    Script Date: 09/08/2016 23:26:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_OutputDetail](
	[OutputDetail_ProductID] [varchar](50) NOT NULL,
	[OutputDetail_OutputID] [varchar](20) NOT NULL,
	[OutputDetail_Price] [decimal](18, 4) NOT NULL,
	[OutputDetail_Quantity] [int] NOT NULL,
 CONSTRAINT [PK_tbl_OutputDetail] PRIMARY KEY CLUSTERED 
(
	[OutputDetail_ProductID] ASC,
	[OutputDetail_OutputID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tbl_OutputDetail] ([OutputDetail_ProductID], [OutputDetail_OutputID], [OutputDetail_Price], [OutputDetail_Quantity]) VALUES (N'SP001', N'OV00000002', CAST(10000.0000 AS Decimal(18, 4)), 1)
INSERT [dbo].[tbl_OutputDetail] ([OutputDetail_ProductID], [OutputDetail_OutputID], [OutputDetail_Price], [OutputDetail_Quantity]) VALUES (N'SP001', N'OV00000003', CAST(100000.0000 AS Decimal(18, 4)), 1)
INSERT [dbo].[tbl_OutputDetail] ([OutputDetail_ProductID], [OutputDetail_OutputID], [OutputDetail_Price], [OutputDetail_Quantity]) VALUES (N'SP001', N'OV00000005', CAST(200000.0000 AS Decimal(18, 4)), 1)
INSERT [dbo].[tbl_OutputDetail] ([OutputDetail_ProductID], [OutputDetail_OutputID], [OutputDetail_Price], [OutputDetail_Quantity]) VALUES (N'SP001', N'OV00000006', CAST(200000.0000 AS Decimal(18, 4)), 1)
INSERT [dbo].[tbl_OutputDetail] ([OutputDetail_ProductID], [OutputDetail_OutputID], [OutputDetail_Price], [OutputDetail_Quantity]) VALUES (N'SP001', N'OV00000007', CAST(200000.0000 AS Decimal(18, 4)), 3)
INSERT [dbo].[tbl_OutputDetail] ([OutputDetail_ProductID], [OutputDetail_OutputID], [OutputDetail_Price], [OutputDetail_Quantity]) VALUES (N'SP001', N'OV00000008', CAST(0.0000 AS Decimal(18, 4)), 1)
INSERT [dbo].[tbl_OutputDetail] ([OutputDetail_ProductID], [OutputDetail_OutputID], [OutputDetail_Price], [OutputDetail_Quantity]) VALUES (N'SP001', N'OV00000009', CAST(200000.0000 AS Decimal(18, 4)), 1)
INSERT [dbo].[tbl_OutputDetail] ([OutputDetail_ProductID], [OutputDetail_OutputID], [OutputDetail_Price], [OutputDetail_Quantity]) VALUES (N'SP001', N'OV00000010', CAST(200000.0000 AS Decimal(18, 4)), 2)
INSERT [dbo].[tbl_OutputDetail] ([OutputDetail_ProductID], [OutputDetail_OutputID], [OutputDetail_Price], [OutputDetail_Quantity]) VALUES (N'SP001', N'OV00000011', CAST(200000.0000 AS Decimal(18, 4)), 1)
INSERT [dbo].[tbl_OutputDetail] ([OutputDetail_ProductID], [OutputDetail_OutputID], [OutputDetail_Price], [OutputDetail_Quantity]) VALUES (N'SP001', N'OV00000012', CAST(80000.0000 AS Decimal(18, 4)), 1)
INSERT [dbo].[tbl_OutputDetail] ([OutputDetail_ProductID], [OutputDetail_OutputID], [OutputDetail_Price], [OutputDetail_Quantity]) VALUES (N'SP001', N'OV00000013', CAST(80000.0000 AS Decimal(18, 4)), 30)
INSERT [dbo].[tbl_OutputDetail] ([OutputDetail_ProductID], [OutputDetail_OutputID], [OutputDetail_Price], [OutputDetail_Quantity]) VALUES (N'SP001', N'OV00000014', CAST(80000.0000 AS Decimal(18, 4)), 1)
INSERT [dbo].[tbl_OutputDetail] ([OutputDetail_ProductID], [OutputDetail_OutputID], [OutputDetail_Price], [OutputDetail_Quantity]) VALUES (N'SP001', N'OV00000021', CAST(80000.0000 AS Decimal(18, 4)), 1)
INSERT [dbo].[tbl_OutputDetail] ([OutputDetail_ProductID], [OutputDetail_OutputID], [OutputDetail_Price], [OutputDetail_Quantity]) VALUES (N'SP001', N'OV00000022', CAST(0.0000 AS Decimal(18, 4)), 1)
INSERT [dbo].[tbl_OutputDetail] ([OutputDetail_ProductID], [OutputDetail_OutputID], [OutputDetail_Price], [OutputDetail_Quantity]) VALUES (N'SP002', N'OV00000014', CAST(70000.0000 AS Decimal(18, 4)), 1)
INSERT [dbo].[tbl_OutputDetail] ([OutputDetail_ProductID], [OutputDetail_OutputID], [OutputDetail_Price], [OutputDetail_Quantity]) VALUES (N'SP003', N'OV00000002', CAST(12222.0000 AS Decimal(18, 4)), 1)
INSERT [dbo].[tbl_OutputDetail] ([OutputDetail_ProductID], [OutputDetail_OutputID], [OutputDetail_Price], [OutputDetail_Quantity]) VALUES (N'SP003', N'OV00000004', CAST(100000.0000 AS Decimal(18, 4)), 6)
INSERT [dbo].[tbl_OutputDetail] ([OutputDetail_ProductID], [OutputDetail_OutputID], [OutputDetail_Price], [OutputDetail_Quantity]) VALUES (N'SP003', N'OV00000011', CAST(100000.0000 AS Decimal(18, 4)), 1)
INSERT [dbo].[tbl_OutputDetail] ([OutputDetail_ProductID], [OutputDetail_OutputID], [OutputDetail_Price], [OutputDetail_Quantity]) VALUES (N'SP003', N'OV00000014', CAST(100000.0000 AS Decimal(18, 4)), 2)
INSERT [dbo].[tbl_OutputDetail] ([OutputDetail_ProductID], [OutputDetail_OutputID], [OutputDetail_Price], [OutputDetail_Quantity]) VALUES (N'SP003', N'OV00000021', CAST(100000.0000 AS Decimal(18, 4)), 1)
INSERT [dbo].[tbl_OutputDetail] ([OutputDetail_ProductID], [OutputDetail_OutputID], [OutputDetail_Price], [OutputDetail_Quantity]) VALUES (N'SP003', N'OV00000022', CAST(0.0000 AS Decimal(18, 4)), 1)
/****** Object:  Table [dbo].[tbl_Output]    Script Date: 09/08/2016 23:26:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Output](
	[Output_ID] [varchar](20) NOT NULL,
	[Output_Date] [smalldatetime] NOT NULL,
	[Output_CustomerID] [varchar](20) NULL,
	[Output_Description] [nvarchar](500) NULL,
	[Output_Total] [decimal](18, 4) NULL,
	[Output_Vouchers] [varchar](20) NULL,
	[IsDelete] [bit] NULL,
	[CreatedDate] [smalldatetime] NULL,
	[CreatedBy] [varchar](50) NULL,
	[ModifiedDate] [smalldatetime] NULL,
	[ModifiedBy] [varchar](50) NULL,
 CONSTRAINT [PK_tbl_Output] PRIMARY KEY CLUSTERED 
(
	[Output_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tbl_Output] ([Output_ID], [Output_Date], [Output_CustomerID], [Output_Description], [Output_Total], [Output_Vouchers], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy]) VALUES (N'OV00000002', CAST(0xA64D042A AS SmallDateTime), N'KH00000007', N'', CAST(22222.0000 AS Decimal(18, 4)), N'', 1, CAST(0xA64D042A AS SmallDateTime), N'', NULL, NULL)
INSERT [dbo].[tbl_Output] ([Output_ID], [Output_Date], [Output_CustomerID], [Output_Description], [Output_Total], [Output_Vouchers], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy]) VALUES (N'OV00000003', CAST(0xA64D042A AS SmallDateTime), N'KH00000012', N'', CAST(100000.0000 AS Decimal(18, 4)), N'', 0, CAST(0xA64D042A AS SmallDateTime), N'', NULL, NULL)
INSERT [dbo].[tbl_Output] ([Output_ID], [Output_Date], [Output_CustomerID], [Output_Description], [Output_Total], [Output_Vouchers], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy]) VALUES (N'OV00000004', CAST(0xA64D042A AS SmallDateTime), N'', N'Xuất hàng cho đơn hàng - OD00000027', CAST(600000.0000 AS Decimal(18, 4)), N'OD00000027', 0, CAST(0xA64D042A AS SmallDateTime), N'', NULL, NULL)
INSERT [dbo].[tbl_Output] ([Output_ID], [Output_Date], [Output_CustomerID], [Output_Description], [Output_Total], [Output_Vouchers], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy]) VALUES (N'OV00000005', CAST(0xA64D042A AS SmallDateTime), N'', N'Xuất hàng cho đơn hàng - OD00000023', CAST(200000.0000 AS Decimal(18, 4)), N'OD00000023', 0, CAST(0xA64D042A AS SmallDateTime), N'', NULL, NULL)
INSERT [dbo].[tbl_Output] ([Output_ID], [Output_Date], [Output_CustomerID], [Output_Description], [Output_Total], [Output_Vouchers], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy]) VALUES (N'OV00000006', CAST(0xA64D042A AS SmallDateTime), N'', N'Xuất hàng cho đơn hàng - OD00000018', CAST(200000.0000 AS Decimal(18, 4)), N'OD00000018', 0, CAST(0xA64D042A AS SmallDateTime), N'', NULL, NULL)
INSERT [dbo].[tbl_Output] ([Output_ID], [Output_Date], [Output_CustomerID], [Output_Description], [Output_Total], [Output_Vouchers], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy]) VALUES (N'OV00000007', CAST(0xA64D042A AS SmallDateTime), N'', N'Xuất hàng cho đơn hàng - OD00000028', CAST(600000.0000 AS Decimal(18, 4)), N'OD00000028', 0, CAST(0xA64D042A AS SmallDateTime), N'', NULL, NULL)
INSERT [dbo].[tbl_Output] ([Output_ID], [Output_Date], [Output_CustomerID], [Output_Description], [Output_Total], [Output_Vouchers], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy]) VALUES (N'OV00000008', CAST(0xA64D042A AS SmallDateTime), N'KH00000011', N'', CAST(0.0000 AS Decimal(18, 4)), N'', 0, CAST(0xA64D042A AS SmallDateTime), N'', NULL, NULL)
INSERT [dbo].[tbl_Output] ([Output_ID], [Output_Date], [Output_CustomerID], [Output_Description], [Output_Total], [Output_Vouchers], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy]) VALUES (N'OV00000009', CAST(0xA64D042A AS SmallDateTime), N'', N'Xuất hàng cho đơn hàng - OD00000021', CAST(200000.0000 AS Decimal(18, 4)), N'OD00000021', 0, CAST(0xA64D042A AS SmallDateTime), N'', NULL, NULL)
INSERT [dbo].[tbl_Output] ([Output_ID], [Output_Date], [Output_CustomerID], [Output_Description], [Output_Total], [Output_Vouchers], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy]) VALUES (N'OV00000010', CAST(0xA64D042A AS SmallDateTime), N'', N'Xuất hàng cho đơn hàng - OD00000026', CAST(400000.0000 AS Decimal(18, 4)), N'OD00000026', 0, CAST(0xA64D042A AS SmallDateTime), N'', NULL, NULL)
INSERT [dbo].[tbl_Output] ([Output_ID], [Output_Date], [Output_CustomerID], [Output_Description], [Output_Total], [Output_Vouchers], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy]) VALUES (N'OV00000011', CAST(0xA64D042A AS SmallDateTime), N'', N'Xuất hàng cho đơn hàng - OD00000029', CAST(300000.0000 AS Decimal(18, 4)), N'OD00000029', 0, CAST(0xA64D042A AS SmallDateTime), N'admin', NULL, NULL)
INSERT [dbo].[tbl_Output] ([Output_ID], [Output_Date], [Output_CustomerID], [Output_Description], [Output_Total], [Output_Vouchers], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy]) VALUES (N'OV00000012', CAST(0xA64D042A AS SmallDateTime), N'', N'Xuất hàng cho đơn hàng - OD00000031', CAST(79000.0000 AS Decimal(18, 4)), N'OD00000031', 0, CAST(0xA64D042A AS SmallDateTime), N'', NULL, NULL)
INSERT [dbo].[tbl_Output] ([Output_ID], [Output_Date], [Output_CustomerID], [Output_Description], [Output_Total], [Output_Vouchers], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy]) VALUES (N'OV00000013', CAST(0xA64D042A AS SmallDateTime), N'', N'Xuất hàng cho đơn hàng - OD00000032', CAST(2400000.0000 AS Decimal(18, 4)), N'OD00000032', 0, CAST(0xA64D042A AS SmallDateTime), N'', NULL, NULL)
INSERT [dbo].[tbl_Output] ([Output_ID], [Output_Date], [Output_CustomerID], [Output_Description], [Output_Total], [Output_Vouchers], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy]) VALUES (N'OV00000014', CAST(0xA64D042A AS SmallDateTime), N'', N'Xuất hàng cho đơn hàng - OD00000036', CAST(346000.0000 AS Decimal(18, 4)), N'OD00000036', 0, CAST(0xA64D042A AS SmallDateTime), N'admin', NULL, NULL)
INSERT [dbo].[tbl_Output] ([Output_ID], [Output_Date], [Output_CustomerID], [Output_Description], [Output_Total], [Output_Vouchers], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy]) VALUES (N'OV00000021', CAST(0xA67B057C AS SmallDateTime), N'', N'Xuất hàng cho đơn hàng - OD00000041', CAST(180000.0000 AS Decimal(18, 4)), N'OD00000041', 0, CAST(0xA67B057C AS SmallDateTime), N'admin', NULL, NULL)
INSERT [dbo].[tbl_Output] ([Output_ID], [Output_Date], [Output_CustomerID], [Output_Description], [Output_Total], [Output_Vouchers], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy]) VALUES (N'OV00000022', CAST(0xA67B057D AS SmallDateTime), N'KH00000007', N'', CAST(0.0000 AS Decimal(18, 4)), N'', 0, CAST(0xA67B057D AS SmallDateTime), N'admin', NULL, NULL)
/****** Object:  Table [dbo].[tbl_OrderDetail]    Script Date: 09/08/2016 23:26:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_OrderDetail](
	[OrderDetail_ProductID] [varchar](50) NOT NULL,
	[OrderDetail_OrderID] [varchar](20) NOT NULL,
	[OrderDetail_Price] [decimal](18, 4) NOT NULL,
	[OrderDetail_Quantity] [int] NOT NULL,
	[OrderDetail_Sale] [decimal](18, 4) NOT NULL,
	[OrderDetail_PriceType] [int] NOT NULL,
 CONSTRAINT [PK_tbl_OrderDetail] PRIMARY KEY CLUSTERED 
(
	[OrderDetail_ProductID] ASC,
	[OrderDetail_OrderID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tbl_OrderDetail] ([OrderDetail_ProductID], [OrderDetail_OrderID], [OrderDetail_Price], [OrderDetail_Quantity], [OrderDetail_Sale], [OrderDetail_PriceType]) VALUES (N'SP001', N'OD00000005', CAST(200000.0000 AS Decimal(18, 4)), 3, CAST(0.0000 AS Decimal(18, 4)), 0)
INSERT [dbo].[tbl_OrderDetail] ([OrderDetail_ProductID], [OrderDetail_OrderID], [OrderDetail_Price], [OrderDetail_Quantity], [OrderDetail_Sale], [OrderDetail_PriceType]) VALUES (N'SP001', N'OD00000006', CAST(200000.0000 AS Decimal(18, 4)), 5, CAST(0.0000 AS Decimal(18, 4)), 0)
INSERT [dbo].[tbl_OrderDetail] ([OrderDetail_ProductID], [OrderDetail_OrderID], [OrderDetail_Price], [OrderDetail_Quantity], [OrderDetail_Sale], [OrderDetail_PriceType]) VALUES (N'SP001', N'OD00000008', CAST(200000.0000 AS Decimal(18, 4)), 4, CAST(0.0000 AS Decimal(18, 4)), 0)
INSERT [dbo].[tbl_OrderDetail] ([OrderDetail_ProductID], [OrderDetail_OrderID], [OrderDetail_Price], [OrderDetail_Quantity], [OrderDetail_Sale], [OrderDetail_PriceType]) VALUES (N'SP001', N'OD00000010', CAST(200000.0000 AS Decimal(18, 4)), 3, CAST(0.0000 AS Decimal(18, 4)), 0)
INSERT [dbo].[tbl_OrderDetail] ([OrderDetail_ProductID], [OrderDetail_OrderID], [OrderDetail_Price], [OrderDetail_Quantity], [OrderDetail_Sale], [OrderDetail_PriceType]) VALUES (N'SP001', N'OD00000012', CAST(200000.0000 AS Decimal(18, 4)), 5, CAST(0.0000 AS Decimal(18, 4)), 0)
INSERT [dbo].[tbl_OrderDetail] ([OrderDetail_ProductID], [OrderDetail_OrderID], [OrderDetail_Price], [OrderDetail_Quantity], [OrderDetail_Sale], [OrderDetail_PriceType]) VALUES (N'SP001', N'OD00000013', CAST(200000.0000 AS Decimal(18, 4)), 1, CAST(0.0000 AS Decimal(18, 4)), 0)
INSERT [dbo].[tbl_OrderDetail] ([OrderDetail_ProductID], [OrderDetail_OrderID], [OrderDetail_Price], [OrderDetail_Quantity], [OrderDetail_Sale], [OrderDetail_PriceType]) VALUES (N'SP001', N'OD00000014', CAST(200000.0000 AS Decimal(18, 4)), 1, CAST(0.0000 AS Decimal(18, 4)), 0)
INSERT [dbo].[tbl_OrderDetail] ([OrderDetail_ProductID], [OrderDetail_OrderID], [OrderDetail_Price], [OrderDetail_Quantity], [OrderDetail_Sale], [OrderDetail_PriceType]) VALUES (N'SP001', N'OD00000015', CAST(200000.0000 AS Decimal(18, 4)), 3, CAST(0.0000 AS Decimal(18, 4)), 0)
INSERT [dbo].[tbl_OrderDetail] ([OrderDetail_ProductID], [OrderDetail_OrderID], [OrderDetail_Price], [OrderDetail_Quantity], [OrderDetail_Sale], [OrderDetail_PriceType]) VALUES (N'SP001', N'OD00000016', CAST(200000.0000 AS Decimal(18, 4)), 2, CAST(0.0000 AS Decimal(18, 4)), 0)
INSERT [dbo].[tbl_OrderDetail] ([OrderDetail_ProductID], [OrderDetail_OrderID], [OrderDetail_Price], [OrderDetail_Quantity], [OrderDetail_Sale], [OrderDetail_PriceType]) VALUES (N'SP001', N'OD00000017', CAST(200000.0000 AS Decimal(18, 4)), 1, CAST(0.0000 AS Decimal(18, 4)), 0)
INSERT [dbo].[tbl_OrderDetail] ([OrderDetail_ProductID], [OrderDetail_OrderID], [OrderDetail_Price], [OrderDetail_Quantity], [OrderDetail_Sale], [OrderDetail_PriceType]) VALUES (N'SP001', N'OD00000018', CAST(200000.0000 AS Decimal(18, 4)), 1, CAST(0.0000 AS Decimal(18, 4)), 0)
INSERT [dbo].[tbl_OrderDetail] ([OrderDetail_ProductID], [OrderDetail_OrderID], [OrderDetail_Price], [OrderDetail_Quantity], [OrderDetail_Sale], [OrderDetail_PriceType]) VALUES (N'SP001', N'OD00000019', CAST(200000.0000 AS Decimal(18, 4)), 3, CAST(0.0000 AS Decimal(18, 4)), 0)
INSERT [dbo].[tbl_OrderDetail] ([OrderDetail_ProductID], [OrderDetail_OrderID], [OrderDetail_Price], [OrderDetail_Quantity], [OrderDetail_Sale], [OrderDetail_PriceType]) VALUES (N'SP001', N'OD00000021', CAST(200000.0000 AS Decimal(18, 4)), 1, CAST(0.0000 AS Decimal(18, 4)), 0)
INSERT [dbo].[tbl_OrderDetail] ([OrderDetail_ProductID], [OrderDetail_OrderID], [OrderDetail_Price], [OrderDetail_Quantity], [OrderDetail_Sale], [OrderDetail_PriceType]) VALUES (N'SP001', N'OD00000023', CAST(200000.0000 AS Decimal(18, 4)), 1, CAST(0.0000 AS Decimal(18, 4)), 0)
INSERT [dbo].[tbl_OrderDetail] ([OrderDetail_ProductID], [OrderDetail_OrderID], [OrderDetail_Price], [OrderDetail_Quantity], [OrderDetail_Sale], [OrderDetail_PriceType]) VALUES (N'SP001', N'OD00000025', CAST(200000.0000 AS Decimal(18, 4)), 2, CAST(0.0000 AS Decimal(18, 4)), 0)
INSERT [dbo].[tbl_OrderDetail] ([OrderDetail_ProductID], [OrderDetail_OrderID], [OrderDetail_Price], [OrderDetail_Quantity], [OrderDetail_Sale], [OrderDetail_PriceType]) VALUES (N'SP001', N'OD00000026', CAST(200000.0000 AS Decimal(18, 4)), 2, CAST(0.0000 AS Decimal(18, 4)), 0)
INSERT [dbo].[tbl_OrderDetail] ([OrderDetail_ProductID], [OrderDetail_OrderID], [OrderDetail_Price], [OrderDetail_Quantity], [OrderDetail_Sale], [OrderDetail_PriceType]) VALUES (N'SP001', N'OD00000028', CAST(200000.0000 AS Decimal(18, 4)), 3, CAST(0.0000 AS Decimal(18, 4)), 0)
INSERT [dbo].[tbl_OrderDetail] ([OrderDetail_ProductID], [OrderDetail_OrderID], [OrderDetail_Price], [OrderDetail_Quantity], [OrderDetail_Sale], [OrderDetail_PriceType]) VALUES (N'SP001', N'OD00000029', CAST(200000.0000 AS Decimal(18, 4)), 1, CAST(0.0000 AS Decimal(18, 4)), 0)
INSERT [dbo].[tbl_OrderDetail] ([OrderDetail_ProductID], [OrderDetail_OrderID], [OrderDetail_Price], [OrderDetail_Quantity], [OrderDetail_Sale], [OrderDetail_PriceType]) VALUES (N'SP001', N'OD00000030', CAST(200000.0000 AS Decimal(18, 4)), 1, CAST(0.0000 AS Decimal(18, 4)), 0)
INSERT [dbo].[tbl_OrderDetail] ([OrderDetail_ProductID], [OrderDetail_OrderID], [OrderDetail_Price], [OrderDetail_Quantity], [OrderDetail_Sale], [OrderDetail_PriceType]) VALUES (N'SP001', N'OD00000031', CAST(80000.0000 AS Decimal(18, 4)), 1, CAST(1000.0000 AS Decimal(18, 4)), 2)
INSERT [dbo].[tbl_OrderDetail] ([OrderDetail_ProductID], [OrderDetail_OrderID], [OrderDetail_Price], [OrderDetail_Quantity], [OrderDetail_Sale], [OrderDetail_PriceType]) VALUES (N'SP001', N'OD00000032', CAST(80000.0000 AS Decimal(18, 4)), 30, CAST(0.0000 AS Decimal(18, 4)), 2)
INSERT [dbo].[tbl_OrderDetail] ([OrderDetail_ProductID], [OrderDetail_OrderID], [OrderDetail_Price], [OrderDetail_Quantity], [OrderDetail_Sale], [OrderDetail_PriceType]) VALUES (N'SP001', N'OD00000033', CAST(80000.0000 AS Decimal(18, 4)), 1, CAST(0.0000 AS Decimal(18, 4)), 2)
INSERT [dbo].[tbl_OrderDetail] ([OrderDetail_ProductID], [OrderDetail_OrderID], [OrderDetail_Price], [OrderDetail_Quantity], [OrderDetail_Sale], [OrderDetail_PriceType]) VALUES (N'SP001', N'OD00000036', CAST(80000.0000 AS Decimal(18, 4)), 1, CAST(2000.0000 AS Decimal(18, 4)), 2)
INSERT [dbo].[tbl_OrderDetail] ([OrderDetail_ProductID], [OrderDetail_OrderID], [OrderDetail_Price], [OrderDetail_Quantity], [OrderDetail_Sale], [OrderDetail_PriceType]) VALUES (N'SP001', N'OD00000041', CAST(80000.0000 AS Decimal(18, 4)), 1, CAST(0.0000 AS Decimal(18, 4)), 2)
INSERT [dbo].[tbl_OrderDetail] ([OrderDetail_ProductID], [OrderDetail_OrderID], [OrderDetail_Price], [OrderDetail_Quantity], [OrderDetail_Sale], [OrderDetail_PriceType]) VALUES (N'SP002', N'OD00000017', CAST(10000.0000 AS Decimal(18, 4)), 2, CAST(0.0000 AS Decimal(18, 4)), 0)
INSERT [dbo].[tbl_OrderDetail] ([OrderDetail_ProductID], [OrderDetail_OrderID], [OrderDetail_Price], [OrderDetail_Quantity], [OrderDetail_Sale], [OrderDetail_PriceType]) VALUES (N'SP002', N'OD00000035', CAST(70000.0000 AS Decimal(18, 4)), 25, CAST(0.0000 AS Decimal(18, 4)), 2)
INSERT [dbo].[tbl_OrderDetail] ([OrderDetail_ProductID], [OrderDetail_OrderID], [OrderDetail_Price], [OrderDetail_Quantity], [OrderDetail_Sale], [OrderDetail_PriceType]) VALUES (N'SP002', N'OD00000036', CAST(70000.0000 AS Decimal(18, 4)), 1, CAST(0.0000 AS Decimal(18, 4)), 2)
INSERT [dbo].[tbl_OrderDetail] ([OrderDetail_ProductID], [OrderDetail_OrderID], [OrderDetail_Price], [OrderDetail_Quantity], [OrderDetail_Sale], [OrderDetail_PriceType]) VALUES (N'SP003', N'OD00000027', CAST(100000.0000 AS Decimal(18, 4)), 6, CAST(0.0000 AS Decimal(18, 4)), 0)
INSERT [dbo].[tbl_OrderDetail] ([OrderDetail_ProductID], [OrderDetail_OrderID], [OrderDetail_Price], [OrderDetail_Quantity], [OrderDetail_Sale], [OrderDetail_PriceType]) VALUES (N'SP003', N'OD00000029', CAST(100000.0000 AS Decimal(18, 4)), 1, CAST(0.0000 AS Decimal(18, 4)), 0)
INSERT [dbo].[tbl_OrderDetail] ([OrderDetail_ProductID], [OrderDetail_OrderID], [OrderDetail_Price], [OrderDetail_Quantity], [OrderDetail_Sale], [OrderDetail_PriceType]) VALUES (N'SP003', N'OD00000034', CAST(100000.0000 AS Decimal(18, 4)), 20, CAST(0.0000 AS Decimal(18, 4)), 2)
INSERT [dbo].[tbl_OrderDetail] ([OrderDetail_ProductID], [OrderDetail_OrderID], [OrderDetail_Price], [OrderDetail_Quantity], [OrderDetail_Sale], [OrderDetail_PriceType]) VALUES (N'SP003', N'OD00000036', CAST(100000.0000 AS Decimal(18, 4)), 2, CAST(1000.0000 AS Decimal(18, 4)), 2)
INSERT [dbo].[tbl_OrderDetail] ([OrderDetail_ProductID], [OrderDetail_OrderID], [OrderDetail_Price], [OrderDetail_Quantity], [OrderDetail_Sale], [OrderDetail_PriceType]) VALUES (N'SP003', N'OD00000041', CAST(100000.0000 AS Decimal(18, 4)), 1, CAST(0.0000 AS Decimal(18, 4)), 2)
/****** Object:  Table [dbo].[tbl_Order]    Script Date: 09/08/2016 23:26:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Order](
	[Order_ID] [varchar](20) NOT NULL,
	[Order_Date] [smalldatetime] NOT NULL,
	[Order_CustomerID] [varchar](20) NOT NULL,
	[Order_Description] [nvarchar](500) NULL,
	[Order_IsSend] [int] NULL,
	[Order_SendType] [int] NULL,
	[IsDelete] [bit] NULL,
	[CreatedDate] [smalldatetime] NULL,
	[CreatedBy] [varchar](50) NULL,
	[ModifiedDate] [smalldatetime] NULL,
	[ModifiedBy] [varchar](50) NULL,
	[Order_IsVoucher] [int] NULL,
	[Order_VoucherID] [varchar](20) NULL,
	[Order_IsOutput] [int] NULL,
	[Order_OutputID] [varchar](20) NULL,
	[Order_SendMoney] [decimal](18, 4) NULL,
	[Order_Total] [decimal](18, 4) NULL,
	[Order_TotalVAT] [decimal](18, 4) NULL,
	[Order_VAT] [float] NULL,
	[Order_SaleMoney] [decimal](18, 4) NULL,
 CONSTRAINT [PK_tbl_Order] PRIMARY KEY CLUSTERED 
(
	[Order_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tbl_Order] ([Order_ID], [Order_Date], [Order_CustomerID], [Order_Description], [Order_IsSend], [Order_SendType], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Order_IsVoucher], [Order_VoucherID], [Order_IsOutput], [Order_OutputID], [Order_SendMoney], [Order_Total], [Order_TotalVAT], [Order_VAT], [Order_SaleMoney]) VALUES (N'OD00000005', CAST(0xA64D0429 AS SmallDateTime), N'1', N'Chú ý', 0, 3, 0, CAST(0xA64D0429 AS SmallDateTime), N'admin', NULL, NULL, 0, NULL, 0, NULL, CAST(10.0000 AS Decimal(18, 4)), CAST(600000.0000 AS Decimal(18, 4)), CAST(599010.0000 AS Decimal(18, 4)), 10, CAST(1000.0000 AS Decimal(18, 4)))
INSERT [dbo].[tbl_Order] ([Order_ID], [Order_Date], [Order_CustomerID], [Order_Description], [Order_IsSend], [Order_SendType], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Order_IsVoucher], [Order_VoucherID], [Order_IsOutput], [Order_OutputID], [Order_SendMoney], [Order_Total], [Order_TotalVAT], [Order_VAT], [Order_SaleMoney]) VALUES (N'OD00000006', CAST(0xA64D0429 AS SmallDateTime), N'1', N'dddd', 0, 2, 0, CAST(0xA64D0429 AS SmallDateTime), N'', NULL, NULL, 0, NULL, 0, NULL, CAST(11111.0000 AS Decimal(18, 4)), CAST(1000000.0000 AS Decimal(18, 4)), CAST(1010000.0000 AS Decimal(18, 4)), 12, CAST(1111.0000 AS Decimal(18, 4)))
INSERT [dbo].[tbl_Order] ([Order_ID], [Order_Date], [Order_CustomerID], [Order_Description], [Order_IsSend], [Order_SendType], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Order_IsVoucher], [Order_VoucherID], [Order_IsOutput], [Order_OutputID], [Order_SendMoney], [Order_Total], [Order_TotalVAT], [Order_VAT], [Order_SaleMoney]) VALUES (N'OD00000008', CAST(0xA64D0429 AS SmallDateTime), N'1', N'', 0, -1, 0, CAST(0xA64D0429 AS SmallDateTime), N'', NULL, NULL, 0, NULL, 0, NULL, CAST(0.0000 AS Decimal(18, 4)), CAST(800000.0000 AS Decimal(18, 4)), CAST(800000.0000 AS Decimal(18, 4)), 0, CAST(0.0000 AS Decimal(18, 4)))
INSERT [dbo].[tbl_Order] ([Order_ID], [Order_Date], [Order_CustomerID], [Order_Description], [Order_IsSend], [Order_SendType], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Order_IsVoucher], [Order_VoucherID], [Order_IsOutput], [Order_OutputID], [Order_SendMoney], [Order_Total], [Order_TotalVAT], [Order_VAT], [Order_SaleMoney]) VALUES (N'OD00000012', CAST(0xA64D0429 AS SmallDateTime), N'1', N'', 0, -1, 0, CAST(0xA64D0429 AS SmallDateTime), N'', NULL, NULL, 0, NULL, 0, NULL, CAST(0.0000 AS Decimal(18, 4)), CAST(1000000.0000 AS Decimal(18, 4)), CAST(1000000.0000 AS Decimal(18, 4)), 0, CAST(0.0000 AS Decimal(18, 4)))
INSERT [dbo].[tbl_Order] ([Order_ID], [Order_Date], [Order_CustomerID], [Order_Description], [Order_IsSend], [Order_SendType], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Order_IsVoucher], [Order_VoucherID], [Order_IsOutput], [Order_OutputID], [Order_SendMoney], [Order_Total], [Order_TotalVAT], [Order_VAT], [Order_SaleMoney]) VALUES (N'OD00000013', CAST(0xA64D0429 AS SmallDateTime), N'1', N'', 0, -1, 0, CAST(0xA64D0429 AS SmallDateTime), N'admin', NULL, NULL, 0, NULL, 0, NULL, CAST(0.0000 AS Decimal(18, 4)), CAST(200000.0000 AS Decimal(18, 4)), CAST(200000.0000 AS Decimal(18, 4)), 0, CAST(0.0000 AS Decimal(18, 4)))
INSERT [dbo].[tbl_Order] ([Order_ID], [Order_Date], [Order_CustomerID], [Order_Description], [Order_IsSend], [Order_SendType], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Order_IsVoucher], [Order_VoucherID], [Order_IsOutput], [Order_OutputID], [Order_SendMoney], [Order_Total], [Order_TotalVAT], [Order_VAT], [Order_SaleMoney]) VALUES (N'OD00000014', CAST(0xA64D0429 AS SmallDateTime), N'1', N'', 0, -1, 0, CAST(0xA64D0429 AS SmallDateTime), N'admin', NULL, NULL, 0, NULL, 0, NULL, CAST(0.0000 AS Decimal(18, 4)), CAST(600000.0000 AS Decimal(18, 4)), CAST(600000.0000 AS Decimal(18, 4)), 0, CAST(0.0000 AS Decimal(18, 4)))
INSERT [dbo].[tbl_Order] ([Order_ID], [Order_Date], [Order_CustomerID], [Order_Description], [Order_IsSend], [Order_SendType], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Order_IsVoucher], [Order_VoucherID], [Order_IsOutput], [Order_OutputID], [Order_SendMoney], [Order_Total], [Order_TotalVAT], [Order_VAT], [Order_SaleMoney]) VALUES (N'OD00000015', CAST(0xA64D0429 AS SmallDateTime), N'1', N'', 0, -1, 0, CAST(0xA64D0429 AS SmallDateTime), N'', NULL, NULL, 0, NULL, 0, NULL, CAST(0.0000 AS Decimal(18, 4)), CAST(2000000.0000 AS Decimal(18, 4)), CAST(2000000.0000 AS Decimal(18, 4)), 0, CAST(0.0000 AS Decimal(18, 4)))
INSERT [dbo].[tbl_Order] ([Order_ID], [Order_Date], [Order_CustomerID], [Order_Description], [Order_IsSend], [Order_SendType], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Order_IsVoucher], [Order_VoucherID], [Order_IsOutput], [Order_OutputID], [Order_SendMoney], [Order_Total], [Order_TotalVAT], [Order_VAT], [Order_SaleMoney]) VALUES (N'OD00000016', CAST(0xA64D0429 AS SmallDateTime), N'1', N'', 0, -1, 0, CAST(0xA64D0429 AS SmallDateTime), N'admin', NULL, NULL, 0, NULL, 0, NULL, CAST(0.0000 AS Decimal(18, 4)), CAST(2000000.0000 AS Decimal(18, 4)), CAST(2000000.0000 AS Decimal(18, 4)), 0, CAST(0.0000 AS Decimal(18, 4)))
INSERT [dbo].[tbl_Order] ([Order_ID], [Order_Date], [Order_CustomerID], [Order_Description], [Order_IsSend], [Order_SendType], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Order_IsVoucher], [Order_VoucherID], [Order_IsOutput], [Order_OutputID], [Order_SendMoney], [Order_Total], [Order_TotalVAT], [Order_VAT], [Order_SaleMoney]) VALUES (N'OD00000017', CAST(0xA64D0429 AS SmallDateTime), N'1', N'', 0, -1, 0, CAST(0xA64D0429 AS SmallDateTime), N'', NULL, NULL, 0, NULL, 0, NULL, CAST(0.0000 AS Decimal(18, 4)), CAST(220000.0000 AS Decimal(18, 4)), CAST(220000.0000 AS Decimal(18, 4)), 0, CAST(0.0000 AS Decimal(18, 4)))
INSERT [dbo].[tbl_Order] ([Order_ID], [Order_Date], [Order_CustomerID], [Order_Description], [Order_IsSend], [Order_SendType], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Order_IsVoucher], [Order_VoucherID], [Order_IsOutput], [Order_OutputID], [Order_SendMoney], [Order_Total], [Order_TotalVAT], [Order_VAT], [Order_SaleMoney]) VALUES (N'OD00000018', CAST(0xA64D0429 AS SmallDateTime), N'1', N'2222', 1, 3, 0, CAST(0xA64D0429 AS SmallDateTime), N'', NULL, NULL, 1, N'TC00000012', 1, N'OV00000006', CAST(2.0000 AS Decimal(18, 4)), CAST(200000.0000 AS Decimal(18, 4)), CAST(199999.0000 AS Decimal(18, 4)), 1, CAST(3.0000 AS Decimal(18, 4)))
INSERT [dbo].[tbl_Order] ([Order_ID], [Order_Date], [Order_CustomerID], [Order_Description], [Order_IsSend], [Order_SendType], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Order_IsVoucher], [Order_VoucherID], [Order_IsOutput], [Order_OutputID], [Order_SendMoney], [Order_Total], [Order_TotalVAT], [Order_VAT], [Order_SaleMoney]) VALUES (N'OD00000019', CAST(0xA64D0429 AS SmallDateTime), N'1', N'', 1, -1, 0, CAST(0xA64D0429 AS SmallDateTime), N'', NULL, NULL, 1, NULL, 1, NULL, CAST(0.0000 AS Decimal(18, 4)), CAST(600000.0000 AS Decimal(18, 4)), CAST(600000.0000 AS Decimal(18, 4)), 0, CAST(0.0000 AS Decimal(18, 4)))
INSERT [dbo].[tbl_Order] ([Order_ID], [Order_Date], [Order_CustomerID], [Order_Description], [Order_IsSend], [Order_SendType], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Order_IsVoucher], [Order_VoucherID], [Order_IsOutput], [Order_OutputID], [Order_SendMoney], [Order_Total], [Order_TotalVAT], [Order_VAT], [Order_SaleMoney]) VALUES (N'OD00000021', CAST(0xA64D0429 AS SmallDateTime), N'1', N'', 0, -1, 0, CAST(0xA64D0429 AS SmallDateTime), N'', NULL, NULL, 1, N'TC00000005', 1, N'OV00000009', CAST(0.0000 AS Decimal(18, 4)), CAST(200000.0000 AS Decimal(18, 4)), CAST(200000.0000 AS Decimal(18, 4)), 0, CAST(0.0000 AS Decimal(18, 4)))
INSERT [dbo].[tbl_Order] ([Order_ID], [Order_Date], [Order_CustomerID], [Order_Description], [Order_IsSend], [Order_SendType], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Order_IsVoucher], [Order_VoucherID], [Order_IsOutput], [Order_OutputID], [Order_SendMoney], [Order_Total], [Order_TotalVAT], [Order_VAT], [Order_SaleMoney]) VALUES (N'OD00000023', CAST(0xA64D0429 AS SmallDateTime), N'1', N'', 0, -1, 0, CAST(0xA64D0429 AS SmallDateTime), N'', NULL, NULL, 1, N'TC00000003', 1, N'OV00000005', CAST(0.0000 AS Decimal(18, 4)), CAST(200000.0000 AS Decimal(18, 4)), CAST(200000.0000 AS Decimal(18, 4)), 0, CAST(0.0000 AS Decimal(18, 4)))
INSERT [dbo].[tbl_Order] ([Order_ID], [Order_Date], [Order_CustomerID], [Order_Description], [Order_IsSend], [Order_SendType], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Order_IsVoucher], [Order_VoucherID], [Order_IsOutput], [Order_OutputID], [Order_SendMoney], [Order_Total], [Order_TotalVAT], [Order_VAT], [Order_SaleMoney]) VALUES (N'OD00000025', CAST(0xA64D0429 AS SmallDateTime), N'KH00000013', N'', 0, -1, 1, CAST(0xA64D0429 AS SmallDateTime), N'', NULL, NULL, 0, NULL, 0, NULL, CAST(0.0000 AS Decimal(18, 4)), CAST(400000.0000 AS Decimal(18, 4)), CAST(400000.0000 AS Decimal(18, 4)), 0, CAST(0.0000 AS Decimal(18, 4)))
INSERT [dbo].[tbl_Order] ([Order_ID], [Order_Date], [Order_CustomerID], [Order_Description], [Order_IsSend], [Order_SendType], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Order_IsVoucher], [Order_VoucherID], [Order_IsOutput], [Order_OutputID], [Order_SendMoney], [Order_Total], [Order_TotalVAT], [Order_VAT], [Order_SaleMoney]) VALUES (N'OD00000026', CAST(0xA64D0429 AS SmallDateTime), N'1', N'', 0, -1, 0, CAST(0xA64D0429 AS SmallDateTime), N'', NULL, NULL, 0, NULL, 1, N'OV00000010', CAST(0.0000 AS Decimal(18, 4)), CAST(400000.0000 AS Decimal(18, 4)), CAST(400000.0000 AS Decimal(18, 4)), 0, CAST(0.0000 AS Decimal(18, 4)))
INSERT [dbo].[tbl_Order] ([Order_ID], [Order_Date], [Order_CustomerID], [Order_Description], [Order_IsSend], [Order_SendType], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Order_IsVoucher], [Order_VoucherID], [Order_IsOutput], [Order_OutputID], [Order_SendMoney], [Order_Total], [Order_TotalVAT], [Order_VAT], [Order_SaleMoney]) VALUES (N'OD00000027', CAST(0xA64D0429 AS SmallDateTime), N'1', N'', 1, -1, 0, CAST(0xA64D0429 AS SmallDateTime), N'', NULL, NULL, 1, N'TC00000009', 1, N'OV00000004', CAST(0.0000 AS Decimal(18, 4)), CAST(600000.0000 AS Decimal(18, 4)), CAST(600000.0000 AS Decimal(18, 4)), 0, CAST(0.0000 AS Decimal(18, 4)))
INSERT [dbo].[tbl_Order] ([Order_ID], [Order_Date], [Order_CustomerID], [Order_Description], [Order_IsSend], [Order_SendType], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Order_IsVoucher], [Order_VoucherID], [Order_IsOutput], [Order_OutputID], [Order_SendMoney], [Order_Total], [Order_TotalVAT], [Order_VAT], [Order_SaleMoney]) VALUES (N'OD00000028', CAST(0xA64D0429 AS SmallDateTime), N'KH00000007', N'', 0, -1, 0, CAST(0xA64D0429 AS SmallDateTime), N'', NULL, NULL, 0, NULL, 1, N'OV00000007', CAST(0.0000 AS Decimal(18, 4)), CAST(600000.0000 AS Decimal(18, 4)), CAST(600000.0000 AS Decimal(18, 4)), 0, CAST(0.0000 AS Decimal(18, 4)))
INSERT [dbo].[tbl_Order] ([Order_ID], [Order_Date], [Order_CustomerID], [Order_Description], [Order_IsSend], [Order_SendType], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Order_IsVoucher], [Order_VoucherID], [Order_IsOutput], [Order_OutputID], [Order_SendMoney], [Order_Total], [Order_TotalVAT], [Order_VAT], [Order_SaleMoney]) VALUES (N'OD00000029', CAST(0xA64D0429 AS SmallDateTime), N'1', N'giao hàng', 1, 2, 0, CAST(0xA64D0429 AS SmallDateTime), N'admin', NULL, NULL, 1, N'TC00000015', 1, N'OV00000011', CAST(50000.0000 AS Decimal(18, 4)), CAST(300000.0000 AS Decimal(18, 4)), CAST(340000.0000 AS Decimal(18, 4)), 0, CAST(10000.0000 AS Decimal(18, 4)))
INSERT [dbo].[tbl_Order] ([Order_ID], [Order_Date], [Order_CustomerID], [Order_Description], [Order_IsSend], [Order_SendType], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Order_IsVoucher], [Order_VoucherID], [Order_IsOutput], [Order_OutputID], [Order_SendMoney], [Order_Total], [Order_TotalVAT], [Order_VAT], [Order_SaleMoney]) VALUES (N'OD00000030', CAST(0xA64D0429 AS SmallDateTime), N'KH00000007', N'', 0, -1, 0, CAST(0xA64D0429 AS SmallDateTime), N'admin', NULL, NULL, 0, NULL, 0, NULL, CAST(0.0000 AS Decimal(18, 4)), CAST(200000.0000 AS Decimal(18, 4)), CAST(200000.0000 AS Decimal(18, 4)), 0, CAST(0.0000 AS Decimal(18, 4)))
INSERT [dbo].[tbl_Order] ([Order_ID], [Order_Date], [Order_CustomerID], [Order_Description], [Order_IsSend], [Order_SendType], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Order_IsVoucher], [Order_VoucherID], [Order_IsOutput], [Order_OutputID], [Order_SendMoney], [Order_Total], [Order_TotalVAT], [Order_VAT], [Order_SaleMoney]) VALUES (N'OD00000031', CAST(0xA64D0429 AS SmallDateTime), N'1', N'', 1, -1, 0, CAST(0xA64D0429 AS SmallDateTime), N'', NULL, NULL, 1, N'TC00000016', 1, N'OV00000012', CAST(0.0000 AS Decimal(18, 4)), CAST(79000.0000 AS Decimal(18, 4)), CAST(79000.0000 AS Decimal(18, 4)), 0, CAST(0.0000 AS Decimal(18, 4)))
INSERT [dbo].[tbl_Order] ([Order_ID], [Order_Date], [Order_CustomerID], [Order_Description], [Order_IsSend], [Order_SendType], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Order_IsVoucher], [Order_VoucherID], [Order_IsOutput], [Order_OutputID], [Order_SendMoney], [Order_Total], [Order_TotalVAT], [Order_VAT], [Order_SaleMoney]) VALUES (N'OD00000032', CAST(0xA64D0429 AS SmallDateTime), N'1', N'', 0, -1, 0, CAST(0xA64D0429 AS SmallDateTime), N'', NULL, NULL, 1, N'TC00000019', 1, N'OV00000013', CAST(0.0000 AS Decimal(18, 4)), CAST(2400000.0000 AS Decimal(18, 4)), CAST(2400000.0000 AS Decimal(18, 4)), 0, CAST(0.0000 AS Decimal(18, 4)))
INSERT [dbo].[tbl_Order] ([Order_ID], [Order_Date], [Order_CustomerID], [Order_Description], [Order_IsSend], [Order_SendType], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Order_IsVoucher], [Order_VoucherID], [Order_IsOutput], [Order_OutputID], [Order_SendMoney], [Order_Total], [Order_TotalVAT], [Order_VAT], [Order_SaleMoney]) VALUES (N'OD00000033', CAST(0xA64D0429 AS SmallDateTime), N'1', N'', 0, -1, 0, CAST(0xA64D0429 AS SmallDateTime), N'', NULL, NULL, 0, NULL, 0, NULL, CAST(0.0000 AS Decimal(18, 4)), CAST(80000.0000 AS Decimal(18, 4)), CAST(80000.0000 AS Decimal(18, 4)), 0, CAST(0.0000 AS Decimal(18, 4)))
INSERT [dbo].[tbl_Order] ([Order_ID], [Order_Date], [Order_CustomerID], [Order_Description], [Order_IsSend], [Order_SendType], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Order_IsVoucher], [Order_VoucherID], [Order_IsOutput], [Order_OutputID], [Order_SendMoney], [Order_Total], [Order_TotalVAT], [Order_VAT], [Order_SaleMoney]) VALUES (N'OD00000034', CAST(0xA64D0429 AS SmallDateTime), N'1', N'', 0, -1, 1, CAST(0xA64D0429 AS SmallDateTime), N'', NULL, NULL, 0, NULL, 0, NULL, CAST(0.0000 AS Decimal(18, 4)), CAST(2000000.0000 AS Decimal(18, 4)), CAST(2000000.0000 AS Decimal(18, 4)), 0, CAST(0.0000 AS Decimal(18, 4)))
INSERT [dbo].[tbl_Order] ([Order_ID], [Order_Date], [Order_CustomerID], [Order_Description], [Order_IsSend], [Order_SendType], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Order_IsVoucher], [Order_VoucherID], [Order_IsOutput], [Order_OutputID], [Order_SendMoney], [Order_Total], [Order_TotalVAT], [Order_VAT], [Order_SaleMoney]) VALUES (N'OD00000035', CAST(0xA64D0429 AS SmallDateTime), N'1', N'', 0, -1, 0, CAST(0xA64D0429 AS SmallDateTime), N'', NULL, NULL, 0, NULL, 0, NULL, CAST(0.0000 AS Decimal(18, 4)), CAST(1750000.0000 AS Decimal(18, 4)), CAST(1750000.0000 AS Decimal(18, 4)), 0, CAST(0.0000 AS Decimal(18, 4)))
INSERT [dbo].[tbl_Order] ([Order_ID], [Order_Date], [Order_CustomerID], [Order_Description], [Order_IsSend], [Order_SendType], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Order_IsVoucher], [Order_VoucherID], [Order_IsOutput], [Order_OutputID], [Order_SendMoney], [Order_Total], [Order_TotalVAT], [Order_VAT], [Order_SaleMoney]) VALUES (N'OD00000036', CAST(0xA64D0429 AS SmallDateTime), N'KH00000007', N'', 1, -1, 0, CAST(0xA64D0429 AS SmallDateTime), N'admin', NULL, NULL, 1, N'TC00000018', 1, N'OV00000014', CAST(0.0000 AS Decimal(18, 4)), CAST(346000.0000 AS Decimal(18, 4)), CAST(336000.0000 AS Decimal(18, 4)), 0, CAST(10000.0000 AS Decimal(18, 4)))
INSERT [dbo].[tbl_Order] ([Order_ID], [Order_Date], [Order_CustomerID], [Order_Description], [Order_IsSend], [Order_SendType], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Order_IsVoucher], [Order_VoucherID], [Order_IsOutput], [Order_OutputID], [Order_SendMoney], [Order_Total], [Order_TotalVAT], [Order_VAT], [Order_SaleMoney]) VALUES (N'OD00000041', CAST(0xA67B057C AS SmallDateTime), N'KH00000007', N'', 1, -1, 0, CAST(0xA67B057C AS SmallDateTime), N'admin', NULL, NULL, 1, N'TC00000021', 1, N'OV00000021', CAST(0.0000 AS Decimal(18, 4)), CAST(180000.0000 AS Decimal(18, 4)), CAST(180000.0000 AS Decimal(18, 4)), 0, CAST(0.0000 AS Decimal(18, 4)))
/****** Object:  Table [dbo].[tbl_Model]    Script Date: 09/08/2016 23:26:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Model](
	[Model_ID] [varchar](50) NOT NULL,
	[Model_CategoryID] [int] NOT NULL,
	[Model_Name] [nvarchar](250) NOT NULL,
	[Model_Description] [nvarchar](500) NULL,
	[IsActive] [bit] NULL,
	[IsDelete] [bit] NULL,
	[CreatedDate] [smalldatetime] NULL,
	[CreatedBy] [varchar](50) NULL,
	[ModifiedDate] [smalldatetime] NULL,
	[ModifiedBy] [varchar](50) NULL,
 CONSTRAINT [PK_tabl_Model] PRIMARY KEY CLUSTERED 
(
	[Model_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tbl_Model] ([Model_ID], [Model_CategoryID], [Model_Name], [Model_Description], [IsActive], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy]) VALUES (N'A01', 2, N'Đầm xòa1', N'Đầm xòa1', 1, 0, CAST(0xA64D0596 AS SmallDateTime), N'admin', CAST(0xA64D0005 AS SmallDateTime), N'admin')
INSERT [dbo].[tbl_Model] ([Model_ID], [Model_CategoryID], [Model_Name], [Model_Description], [IsActive], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy]) VALUES (N'A02', 1, N'Váy 01', N'Váy 01', 1, 1, CAST(0xA64D0596 AS SmallDateTime), N'admin', CAST(0xA64D0005 AS SmallDateTime), N'admin')
/****** Object:  Table [dbo].[tbl_InputDetail]    Script Date: 09/08/2016 23:26:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_InputDetail](
	[InputDetail_ProductID] [varchar](50) NOT NULL,
	[InputDetail_InputID] [varchar](20) NOT NULL,
	[InputDetail_Price] [decimal](18, 4) NOT NULL,
	[InputDetail_Quantity] [int] NOT NULL,
 CONSTRAINT [PK_tbl_InputDetail] PRIMARY KEY CLUSTERED 
(
	[InputDetail_ProductID] ASC,
	[InputDetail_InputID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tbl_InputDetail] ([InputDetail_ProductID], [InputDetail_InputID], [InputDetail_Price], [InputDetail_Quantity]) VALUES (N'SP001', N'IV00000005', CAST(9000.0000 AS Decimal(18, 4)), 1)
INSERT [dbo].[tbl_InputDetail] ([InputDetail_ProductID], [InputDetail_InputID], [InputDetail_Price], [InputDetail_Quantity]) VALUES (N'SP001', N'IV00000006', CAST(1000.0000 AS Decimal(18, 4)), 5)
INSERT [dbo].[tbl_InputDetail] ([InputDetail_ProductID], [InputDetail_InputID], [InputDetail_Price], [InputDetail_Quantity]) VALUES (N'SP001', N'IV00000007', CAST(10000.0000 AS Decimal(18, 4)), 10)
INSERT [dbo].[tbl_InputDetail] ([InputDetail_ProductID], [InputDetail_InputID], [InputDetail_Price], [InputDetail_Quantity]) VALUES (N'SP001', N'IV00000008', CAST(50000.0000 AS Decimal(18, 4)), 20)
INSERT [dbo].[tbl_InputDetail] ([InputDetail_ProductID], [InputDetail_InputID], [InputDetail_Price], [InputDetail_Quantity]) VALUES (N'SP001', N'IV00000009', CAST(40000.0000 AS Decimal(18, 4)), 20)
INSERT [dbo].[tbl_InputDetail] ([InputDetail_ProductID], [InputDetail_InputID], [InputDetail_Price], [InputDetail_Quantity]) VALUES (N'SP001', N'IV00000011', CAST(0.0000 AS Decimal(18, 4)), 1)
INSERT [dbo].[tbl_InputDetail] ([InputDetail_ProductID], [InputDetail_InputID], [InputDetail_Price], [InputDetail_Quantity]) VALUES (N'SP002', N'IV00000008', CAST(40000.0000 AS Decimal(18, 4)), 20)
INSERT [dbo].[tbl_InputDetail] ([InputDetail_ProductID], [InputDetail_InputID], [InputDetail_Price], [InputDetail_Quantity]) VALUES (N'SP002', N'IV00000009', CAST(100000.0000 AS Decimal(18, 4)), 20)
INSERT [dbo].[tbl_InputDetail] ([InputDetail_ProductID], [InputDetail_InputID], [InputDetail_Price], [InputDetail_Quantity]) VALUES (N'SP003', N'IV00000008', CAST(70000.0000 AS Decimal(18, 4)), 20)
INSERT [dbo].[tbl_InputDetail] ([InputDetail_ProductID], [InputDetail_InputID], [InputDetail_Price], [InputDetail_Quantity]) VALUES (N'SP003', N'IV00000009', CAST(70000.0000 AS Decimal(18, 4)), 20)
INSERT [dbo].[tbl_InputDetail] ([InputDetail_ProductID], [InputDetail_InputID], [InputDetail_Price], [InputDetail_Quantity]) VALUES (N'SP003', N'IV00000011', CAST(0.0000 AS Decimal(18, 4)), 1)
/****** Object:  Table [dbo].[tbl_Input]    Script Date: 09/08/2016 23:26:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Input](
	[Input_ID] [varchar](20) NOT NULL,
	[Input_Date] [smalldatetime] NOT NULL,
	[Input_SupplierID] [varchar](20) NOT NULL,
	[Input_IsVoucher] [int] NULL,
	[Input_VoucherID] [varchar](20) NULL,
	[Input_Description] [nvarchar](500) NULL,
	[IsDelete] [int] NULL,
	[CreatedDate] [smalldatetime] NULL,
	[CreatedBy] [varchar](50) NULL,
	[ModifiedDate] [smalldatetime] NULL,
	[ModifiedBy] [varchar](50) NULL,
	[Input_Total] [decimal](18, 4) NULL,
	[Input_TotalVAT] [decimal](18, 4) NULL,
	[Input_VAT] [float] NULL,
	[Input_SaleMoney] [decimal](18, 4) NULL,
 CONSTRAINT [PK_tbl_Input] PRIMARY KEY CLUSTERED 
(
	[Input_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tbl_Input] ([Input_ID], [Input_Date], [Input_SupplierID], [Input_IsVoucher], [Input_VoucherID], [Input_Description], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Input_Total], [Input_TotalVAT], [Input_VAT], [Input_SaleMoney]) VALUES (N'IV00000005', CAST(0xA64D0577 AS SmallDateTime), N'1', 1, N'TC00000010', N'', 0, CAST(0xA64D0578 AS SmallDateTime), N'', NULL, N'', CAST(9000.0000 AS Decimal(18, 4)), CAST(6889.0000 AS Decimal(18, 4)), 100, CAST(11111.0000 AS Decimal(18, 4)))
INSERT [dbo].[tbl_Input] ([Input_ID], [Input_Date], [Input_SupplierID], [Input_IsVoucher], [Input_VoucherID], [Input_Description], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Input_Total], [Input_TotalVAT], [Input_VAT], [Input_SaleMoney]) VALUES (N'IV00000006', CAST(0xA64D0028 AS SmallDateTime), N'NCC0000003', 1, N'TC00000011', N'', 0, CAST(0xA64D0029 AS SmallDateTime), N'', NULL, NULL, CAST(5000.0000 AS Decimal(18, 4)), CAST(5000.0000 AS Decimal(18, 4)), 0, CAST(0.0000 AS Decimal(18, 4)))
INSERT [dbo].[tbl_Input] ([Input_ID], [Input_Date], [Input_SupplierID], [Input_IsVoucher], [Input_VoucherID], [Input_Description], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Input_Total], [Input_TotalVAT], [Input_VAT], [Input_SaleMoney]) VALUES (N'IV00000007', CAST(0xA64D0044 AS SmallDateTime), N'NCC0000002', 1, N'TC00000013', N'', 0, CAST(0xA64D0045 AS SmallDateTime), N'', NULL, NULL, CAST(100000.0000 AS Decimal(18, 4)), CAST(100000.0000 AS Decimal(18, 4)), 0, CAST(0.0000 AS Decimal(18, 4)))
INSERT [dbo].[tbl_Input] ([Input_ID], [Input_Date], [Input_SupplierID], [Input_IsVoucher], [Input_VoucherID], [Input_Description], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Input_Total], [Input_TotalVAT], [Input_VAT], [Input_SaleMoney]) VALUES (N'IV00000008', CAST(0xA64D04EF AS SmallDateTime), N'1', 1, N'TC00000014', N'', 0, CAST(0xA64D04F1 AS SmallDateTime), N'admin', NULL, NULL, CAST(3200000.0000 AS Decimal(18, 4)), CAST(3100000.0000 AS Decimal(18, 4)), 0, CAST(100000.0000 AS Decimal(18, 4)))
INSERT [dbo].[tbl_Input] ([Input_ID], [Input_Date], [Input_SupplierID], [Input_IsVoucher], [Input_VoucherID], [Input_Description], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Input_Total], [Input_TotalVAT], [Input_VAT], [Input_SaleMoney]) VALUES (N'IV00000009', CAST(0xA64D046E AS SmallDateTime), N'NCC0000002', 1, N'TC00000017', N'', 0, CAST(0xA64D046F AS SmallDateTime), N'admin', NULL, NULL, CAST(4200000.0000 AS Decimal(18, 4)), CAST(4200000.0000 AS Decimal(18, 4)), 0, CAST(0.0000 AS Decimal(18, 4)))
INSERT [dbo].[tbl_Input] ([Input_ID], [Input_Date], [Input_SupplierID], [Input_IsVoucher], [Input_VoucherID], [Input_Description], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Input_Total], [Input_TotalVAT], [Input_VAT], [Input_SaleMoney]) VALUES (N'IV00000011', CAST(0xA67B057D AS SmallDateTime), N'NCC0000002', 1, N'TC00000022', N'', 0, CAST(0xA67B057D AS SmallDateTime), N'admin', NULL, NULL, CAST(0.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), 0, CAST(0.0000 AS Decimal(18, 4)))
/****** Object:  Table [dbo].[tbl_Customer]    Script Date: 09/08/2016 23:26:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Customer](
	[Customer_ID] [varchar](20) NOT NULL,
	[Customer_Name] [nvarchar](50) NOT NULL,
	[Customer_Phone] [varchar](20) NULL,
	[Customer_Address] [nvarchar](500) NULL,
	[Customer_Email] [nvarchar](250) NULL,
	[Customer_Facbook] [nvarchar](250) NULL,
	[Customer_Zalo] [nvarchar](250) NULL,
	[Customer_Description] [nvarchar](500) NULL,
	[IsActive] [bit] NULL,
	[IsDelete] [bit] NULL,
	[CreatedDate] [smalldatetime] NULL,
	[CreatedBy] [varchar](50) NULL,
	[ModifiedDate] [smalldatetime] NULL,
	[ModifiedBy] [varchar](50) NULL,
 CONSTRAINT [PK_tbl_Customer] PRIMARY KEY CLUSTERED 
(
	[Customer_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tbl_Customer] ([Customer_ID], [Customer_Name], [Customer_Phone], [Customer_Address], [Customer_Email], [Customer_Facbook], [Customer_Zalo], [Customer_Description], [IsActive], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy]) VALUES (N'1', N'Hà Thanh Mỹ', N'0932123992', N'địa chi', N'email', N'facbook', N'zalo', N'ghi chu', 1, 0, CAST(0xA64D052E AS SmallDateTime), N'admin', NULL, NULL)
INSERT [dbo].[tbl_Customer] ([Customer_ID], [Customer_Name], [Customer_Phone], [Customer_Address], [Customer_Email], [Customer_Facbook], [Customer_Zalo], [Customer_Description], [IsActive], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy]) VALUES (N'2', N'my', N'0932123993', N'', N'', N'', N'', N'', 1, 0, CAST(0xA64D053B AS SmallDateTime), N'admin', NULL, NULL)
INSERT [dbo].[tbl_Customer] ([Customer_ID], [Customer_Name], [Customer_Phone], [Customer_Address], [Customer_Email], [Customer_Facbook], [Customer_Zalo], [Customer_Description], [IsActive], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy]) VALUES (N'KH00000007', N'My 002', N'0987765655', N'', N'', N'', N'', N'', 1, 0, CAST(0xA64D0019 AS SmallDateTime), N'admin', NULL, NULL)
INSERT [dbo].[tbl_Customer] ([Customer_ID], [Customer_Name], [Customer_Phone], [Customer_Address], [Customer_Email], [Customer_Facbook], [Customer_Zalo], [Customer_Description], [IsActive], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy]) VALUES (N'KH00000008', N'Hà Thanh Mỹ', N'0932123992', N'địa chi', N'email', N'facbook', N'zalo', N'', 0, 1, CAST(0xA64D058E AS SmallDateTime), N'', NULL, NULL)
INSERT [dbo].[tbl_Customer] ([Customer_ID], [Customer_Name], [Customer_Phone], [Customer_Address], [Customer_Email], [Customer_Facbook], [Customer_Zalo], [Customer_Description], [IsActive], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy]) VALUES (N'KH00000009', N'Hà Thanh Mỹ', N'0932123992', N'địa chi', N'email', N'facbook', N'zalo', N'', 0, 1, CAST(0xA64D058E AS SmallDateTime), N'', NULL, NULL)
INSERT [dbo].[tbl_Customer] ([Customer_ID], [Customer_Name], [Customer_Phone], [Customer_Address], [Customer_Email], [Customer_Facbook], [Customer_Zalo], [Customer_Description], [IsActive], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy]) VALUES (N'KH00000010', N'dđ', N'ddd', N'', N'', N'', N'', N'', 1, 0, CAST(0xA64D0039 AS SmallDateTime), N'', NULL, NULL)
INSERT [dbo].[tbl_Customer] ([Customer_ID], [Customer_Name], [Customer_Phone], [Customer_Address], [Customer_Email], [Customer_Facbook], [Customer_Zalo], [Customer_Description], [IsActive], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy]) VALUES (N'KH00000011', N'MY KT', N'0987362627', N'', N'', N'', N'', N'', 1, 0, CAST(0xA64D0525 AS SmallDateTime), N'', NULL, NULL)
INSERT [dbo].[tbl_Customer] ([Customer_ID], [Customer_Name], [Customer_Phone], [Customer_Address], [Customer_Email], [Customer_Facbook], [Customer_Zalo], [Customer_Description], [IsActive], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy]) VALUES (N'KH00000012', N'MY KT', N'0932123995', N'', N'', N'', N'', N'', 1, 0, CAST(0xA64D052F AS SmallDateTime), N'', NULL, NULL)
INSERT [dbo].[tbl_Customer] ([Customer_ID], [Customer_Name], [Customer_Phone], [Customer_Address], [Customer_Email], [Customer_Facbook], [Customer_Zalo], [Customer_Description], [IsActive], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy]) VALUES (N'KH00000013', N'MY KT', N'0932123996', N'', N'', N'', N'', N'', 1, 0, CAST(0xA64D0534 AS SmallDateTime), N'', NULL, NULL)
/****** Object:  Table [dbo].[tbl_Config]    Script Date: 09/08/2016 23:26:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Config](
	[Config_Id] [nvarchar](50) NOT NULL,
	[Config_Value] [nvarchar](250) NOT NULL,
	[Config_Name] [nvarchar](50) NOT NULL,
	[Config_Description] [nvarchar](250) NULL,
	[IsActive] [bit] NULL,
	[IsDelete] [bit] NULL,
	[CreatedDate] [smalldatetime] NULL,
	[CreatedBy] [varchar](50) NULL,
	[ModifiedDate] [smalldatetime] NULL,
	[ModifiedBy] [varchar](50) NULL,
 CONSTRAINT [PK_tbl_Config] PRIMARY KEY CLUSTERED 
(
	[Config_Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_Color]    Script Date: 09/08/2016 23:26:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Color](
	[Color_Id] [int] IDENTITY(1,1) NOT NULL,
	[Color_Name] [nvarchar](50) NOT NULL,
	[Color_Description] [nvarchar](250) NULL,
	[IsActive] [bit] NULL,
	[IsDelete] [bit] NULL,
	[CreatedDate] [smalldatetime] NULL,
	[CreatedBy] [varchar](50) NULL,
	[ModifiedDate] [smalldatetime] NULL,
	[ModifiedBy] [varchar](50) NULL,
	[Orderindex] [int] NULL,
 CONSTRAINT [PK_tabl_Color] PRIMARY KEY CLUSTERED 
(
	[Color_Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_Color] ON
INSERT [dbo].[tbl_Color] ([Color_Id], [Color_Name], [Color_Description], [IsActive], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Orderindex]) VALUES (1, N'Xanh', N'Xanh', 1, 0, CAST(0xA64D000A AS SmallDateTime), N'admin', NULL, NULL, 1)
INSERT [dbo].[tbl_Color] ([Color_Id], [Color_Name], [Color_Description], [IsActive], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Orderindex]) VALUES (2, N'Đỏ', N'', 1, 0, CAST(0xA64D000A AS SmallDateTime), N'admin', NULL, NULL, 0)
INSERT [dbo].[tbl_Color] ([Color_Id], [Color_Name], [Color_Description], [IsActive], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Orderindex]) VALUES (3, N'Vàng', N'', 1, 0, CAST(0xA64D000A AS SmallDateTime), N'admin', NULL, NULL, 3)
INSERT [dbo].[tbl_Color] ([Color_Id], [Color_Name], [Color_Description], [IsActive], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Orderindex]) VALUES (4, N'Xóa', N'', 1, 1, CAST(0xA64D0287 AS SmallDateTime), N'admin', NULL, NULL, 0)
SET IDENTITY_INSERT [dbo].[tbl_Color] OFF
/****** Object:  Table [dbo].[tbl_Category]    Script Date: 09/08/2016 23:26:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Category](
	[Category_ID] [int] IDENTITY(1,1) NOT NULL,
	[Category_Name] [nvarchar](50) NOT NULL,
	[Category_Description] [nvarchar](250) NULL,
	[IsActive] [bit] NULL,
	[IsDelete] [bit] NULL,
	[CreatedDate] [smalldatetime] NULL,
	[CreatedBy] [varchar](50) NULL,
	[ModifiedDate] [smalldatetime] NULL,
	[ModifiedBy] [varchar](50) NULL,
	[Orderindex] [int] NULL,
 CONSTRAINT [PK_tbl_Category] PRIMARY KEY CLUSTERED 
(
	[Category_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_Category] ON
INSERT [dbo].[tbl_Category] ([Category_ID], [Category_Name], [Category_Description], [IsActive], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Orderindex]) VALUES (1, N'Váy', NULL, 1, 0, CAST(0xA64D0570 AS SmallDateTime), NULL, NULL, NULL, 1)
INSERT [dbo].[tbl_Category] ([Category_ID], [Category_Name], [Category_Description], [IsActive], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Orderindex]) VALUES (2, N'Đầm', N'', 1, 0, CAST(0xA64D0571 AS SmallDateTime), NULL, CAST(0xA67A04DA AS SmallDateTime), N'admin', 0)
INSERT [dbo].[tbl_Category] ([Category_ID], [Category_Name], [Category_Description], [IsActive], [IsDelete], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Orderindex]) VALUES (7, N'Thêm', N'', 1, 0, CAST(0xA67A04DA AS SmallDateTime), N'admin', NULL, NULL, 2)
SET IDENTITY_INSERT [dbo].[tbl_Category] OFF
/****** Object:  Table [dbo].[tbl_AutomaticValues]    Script Date: 09/08/2016 23:26:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_AutomaticValues](
	[ObjectName] [nvarchar](50) NOT NULL,
	[PrefixOfDefaultValueForId] [varchar](50) NULL,
	[LengthOfDefaultValueForId] [tinyint] NULL,
	[LastValueOfColumnId] [varchar](50) NULL,
	[DefaultValueForSelection] [varchar](50) NULL,
 CONSTRAINT [PK_tbl_AutomaticValues] PRIMARY KEY CLUSTERED 
(
	[ObjectName] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tbl_AutomaticValues] ([ObjectName], [PrefixOfDefaultValueForId], [LengthOfDefaultValueForId], [LastValueOfColumnId], [DefaultValueForSelection]) VALUES (N'tbl_Customer', N'KH', 10, N'KH00000014', NULL)
INSERT [dbo].[tbl_AutomaticValues] ([ObjectName], [PrefixOfDefaultValueForId], [LengthOfDefaultValueForId], [LastValueOfColumnId], [DefaultValueForSelection]) VALUES (N'tbl_Input', N'IV', 10, N'IV00000011', NULL)
INSERT [dbo].[tbl_AutomaticValues] ([ObjectName], [PrefixOfDefaultValueForId], [LengthOfDefaultValueForId], [LastValueOfColumnId], [DefaultValueForSelection]) VALUES (N'tbl_Order', N'OD', 10, N'OD00000041', NULL)
INSERT [dbo].[tbl_AutomaticValues] ([ObjectName], [PrefixOfDefaultValueForId], [LengthOfDefaultValueForId], [LastValueOfColumnId], [DefaultValueForSelection]) VALUES (N'tbl_Output', N'OV', 10, N'OV00000022', NULL)
INSERT [dbo].[tbl_AutomaticValues] ([ObjectName], [PrefixOfDefaultValueForId], [LengthOfDefaultValueForId], [LastValueOfColumnId], [DefaultValueForSelection]) VALUES (N'tbl_Payments', N'TC', 10, N'TC00000022', NULL)
INSERT [dbo].[tbl_AutomaticValues] ([ObjectName], [PrefixOfDefaultValueForId], [LengthOfDefaultValueForId], [LastValueOfColumnId], [DefaultValueForSelection]) VALUES (N'tbl_Supplier', N'NCC', 10, N'NCC0000005', NULL)
/****** Object:  StoredProcedure [dbo].[prt_Banhang]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[prt_Banhang]
	@Order_ID varchar(20)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT tbl_Order.[Order_ID] 
      ,tbl_Order.[Order_Date]
      ,tbl_Order.[Order_CustomerID]
      ,tbl_Customer.Customer_Name
      ,tbl_Customer.Customer_Phone
      ,tbl_Customer.Customer_Email
      ,tbl_Customer.Customer_Address
      ,tbl_Order.[Order_Description]
      ,tbl_Order.[Order_IsVoucher]
      ,tbl_Order.[Order_SendMoney]
      ,tbl_Order.[Order_Total]
      ,tbl_Order.[Order_TotalVAT]
      ,tbl_Order.[Order_VAT]
      ,tbl_Order.[Order_SaleMoney]
      ,tbl_OrderDetail.OrderDetail_Quantity
      ,tbl_OrderDetail.OrderDetail_ProductID
      ,tbl_OrderDetail.OrderDetail_Price
      ,tbl_OrderDetail.OrderDetail_Sale
      ,(tbl_OrderDetail.OrderDetail_Price *tbl_OrderDetail.OrderDetail_Quantity)-tbl_OrderDetail.OrderDetail_Sale as thanhtien
      ,tbl_Product.Product_Name
      ,tbl_Color.Color_Name
      ,tbl_Model.Model_Name
	FROM [dbo].[tbl_Order]
	join tbl_OrderDetail on tbl_OrderDetail.OrderDetail_OrderID = tbl_Order.Order_ID
	join tbl_Product on tbl_OrderDetail.OrderDetail_ProductID = tbl_Product.Product_ID
	join tbl_Color  on tbl_Product.Product_ColorID = tbl_Product.Product_ColorID
	join tbl_Model on tbl_Product.Product_ModelID = tbl_Model.Model_ID
	join tbl_Customer on tbl_Order.Order_CustomerID = tbl_Customer.Customer_ID
	WHERE [Order_ID] = @Order_ID
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_User_UpdatePass]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_User_UpdatePass]
	@User_ID varchar(50),
	@User_Pass nvarchar(250),
	@ModifiedBy varchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE [dbo].[tbl_User]
	   SET [User_Pass] = @User_Pass
		  ,[ModifiedDate] = GETDATE()
		  ,[ModifiedBy] = @ModifiedBy
		WHERE [User_ID] = @User_ID
END
GO
/****** Object:  StoredProcedure [dbo].[pr_User_Update]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_User_Update]
	@User_ID varchar(50),
	@User_Name nvarchar(50),
	@IsActive int,
	@ModifiedBy varchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE [dbo].[tbl_User]
	   SET [User_Name] = @User_Name
		  ,[IsActive] = @IsActive
		  ,[ModifiedDate] = GETDATE()
		  ,[ModifiedBy] = @ModifiedBy
		WHERE [User_ID] = @User_ID
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_User_Select]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_User_Select]
	@User_ID varchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT [User_ID]
      ,[User_Name]
      ,[User_Pass]
      ,[IsActive]
      ,[IsDelete]
      ,[CreatedDate]
      ,[CreatedBy]
      ,[ModifiedDate]
      ,[ModifiedBy]
	FROM [dbo].[tbl_User]
	WHERE [User_ID] = @User_ID
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_User_Seach]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_User_Seach]
	@Keyword nvarchar(50)= '',
	@IsDelete bit
AS
BEGIN
	SET NOCOUNT ON;
	SELECT [User_ID]
      ,[User_Name]
      ,[IsActive]
      ,[IsDelete]
      ,[CreatedDate]
      ,[CreatedBy]
      ,[ModifiedDate]
      ,[ModifiedBy]
	FROM [dbo].[tbl_User]
	WHERE IsDelete = @IsDelete 
	and (@Keyword = '' or (User_ID like '%'+@Keyword+'%' or User_Name like '%'+@Keyword+'%'))
	order by [User_Name]
END
GO
/****** Object:  StoredProcedure [dbo].[pr_User_Login]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_User_Login]
	@User_ID varchar(50),
	@User_Pass nvarchar(250)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT [User_ID]
      ,[User_Name]
      ,[User_Pass]
      ,[IsActive]
      ,[IsDelete]
      ,[CreatedDate]
      ,[CreatedBy]
      ,[ModifiedDate]
      ,[ModifiedBy]
	FROM [dbo].[tbl_User]
	WHERE [User_ID] = @User_ID and [User_Pass] = @User_Pass and IsActive = 1 and isDelete = 0
END
GO
/****** Object:  StoredProcedure [dbo].[pr_User_Delete]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_User_Delete]
	@User_ID varchar(50),
	@ModifiedBy varchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE [dbo].[tbl_User]
	   SET 
		   [IsDelete] = 1
		  ,[ModifiedDate] = GETDATE()
		  ,[ModifiedBy] = @ModifiedBy
		WHERE [User_ID] = @User_ID
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_User_Check]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_User_Check]
	@User_ID varchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT [User_ID]
	FROM [dbo].[tbl_User]
	WHERE User_ID = @User_ID 
END
GO
/****** Object:  StoredProcedure [dbo].[pr_User_Add]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_User_Add]
	@User_ID varchar(50),
	@User_Pass nvarchar(250),
	@User_Name nvarchar(50),
	@IsActive bit,
	@CreatedBy varchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO [dbo].[tbl_User]
           ([User_ID]
           ,[User_Pass]
           ,[User_Name]
           ,[IsActive]
           ,[CreatedBy])
     VALUES
           (@User_ID
           ,@User_Pass
           ,@User_Name
           ,@IsActive
           ,@CreatedBy)
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_UpdLastAutoId]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[pr_UpdLastAutoId]
	@TableName nvarchar(50),
	@LastId nvarchar(50) 
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE [tbl_AutomaticValues]
	SET LastValueOfColumnId = @LastId
	WHERE ObjectName = @TableName 
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Supplier_Update]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Supplier_Update]
	@Supplier_ID varchar(20),
	@Supplier_Name nvarchar(50),
	@Supplier_Phone varchar(20),
	@Supplier_Address nvarchar(500),
	@Supplier_Email nvarchar(250),
	@Supplier_Facbook nvarchar(250),
	@Supplier_Zalo nvarchar(250),
	@Supplier_Description nvarchar(250),
	@IsActive bit,
	@ModifiedBy varchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE [dbo].[tbl_Supplier]
	   SET [Supplier_Name] = @Supplier_Name
		  ,Supplier_Phone = @Supplier_Phone
		  ,Supplier_Address = @Supplier_Address
		  ,Supplier_Email = @Supplier_Email
		  ,Supplier_Facbook = @Supplier_Facbook
		  ,Supplier_Zalo = @Supplier_Zalo
		  ,[Supplier_Description] = @Supplier_Description
		  ,[IsActive] = @IsActive
		  ,[ModifiedDate] = GETDATE()
		  ,[ModifiedBy] = @ModifiedBy
		WHERE [Supplier_ID] = @Supplier_ID
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Supplier_SelectByPhone]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Supplier_SelectByPhone]
	@Supplier_Phone varchar(20)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT [Supplier_ID]
      ,[Supplier_Name]
       ,Supplier_Phone
       ,Supplier_Address
       ,Supplier_Email
       ,Supplier_Facbook
       ,Supplier_Zalo
       ,[Supplier_Description]
      ,[IsActive]
      ,[IsDelete]
      ,[CreatedDate]
      ,[CreatedBy]
      ,[ModifiedDate]
      ,[ModifiedBy]
	FROM [dbo].[tbl_Supplier]
	WHERE Supplier_Phone = @Supplier_Phone
	and IsDelete = 0 and IsActive = 1
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Supplier_Select]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Supplier_Select]
	@Supplier_ID varchar(20)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT [Supplier_ID]
      ,[Supplier_Name]
       ,Supplier_Phone
       ,Supplier_Address
       ,Supplier_Email
       ,Supplier_Facbook
       ,Supplier_Zalo
       ,[Supplier_Description]
      ,[IsActive]
      ,[IsDelete]
      ,[CreatedDate]
      ,[CreatedBy]
      ,[ModifiedDate]
      ,[ModifiedBy]
	FROM [dbo].[tbl_Supplier]
	WHERE [Supplier_ID] = @Supplier_ID
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Supplier_Seach_Use]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Supplier_Seach_Use]
	@Keyword nvarchar(50)= null,
	@Type int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT RTRIM(Supplier_ID) Supplier_ID
      ,[Supplier_Name]
       ,Supplier_Phone
       ,Supplier_Address
       ,Supplier_Email
       ,Supplier_Facbook
       ,Supplier_Zalo
       ,[Supplier_Description]
      ,[IsActive]
      ,[IsDelete]
      ,[CreatedDate]
      ,[CreatedBy]
      ,[ModifiedDate]
      ,[ModifiedBy]
	FROM [dbo].[tbl_Supplier]
	WHERE IsDelete = 0 and IsActive = 1 
	and 
		(
			@Type = 0 and (@Keyword = '' or Supplier_ID like '%'+@Keyword+'%')
			or @Type = 1 and (@Keyword = '' or Supplier_Name like '%'+@Keyword+'%')
			or @Type = 2 and (@Keyword = '' or Supplier_Phone like '%'+@Keyword+'%')
			or @Type = 3 and (@Keyword = '' or Supplier_Facbook like '%'+@Keyword+'%')
			or @Type = 4 and (@Keyword = '' or Supplier_Zalo like '%'+@Keyword+'%')
			or @Type = -1 and (@Keyword = '' or Supplier_ID like '%'+@Keyword+'%' 
								or Supplier_Name like '%'+@Keyword+'%' or Supplier_Phone like '%'+@Keyword+'%'
								or Supplier_Facbook like '%'+@Keyword+'%' or Supplier_Zalo like '%'+@Keyword+'%')
		)
	order by [Supplier_Name]
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Supplier_Seach]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Supplier_Seach]
	@Keyword nvarchar(50)= null,
	@IsDelete bit
AS
BEGIN
	SET NOCOUNT ON;
	SELECT [Supplier_ID]
      ,[Supplier_Name]
       ,Supplier_Phone
       ,Supplier_Address
       ,Supplier_Email
       ,Supplier_Facbook
       ,Supplier_Zalo
       ,[Supplier_Description]
      ,[IsActive]
      ,[IsDelete]
      ,[CreatedDate]
      ,[CreatedBy]
      ,[ModifiedDate]
      ,[ModifiedBy]
	FROM [dbo].[tbl_Supplier]
	WHERE IsDelete = @IsDelete 
	and (@Keyword = null 
		or (Supplier_ID like '%'+@Keyword+'%' 
		or Supplier_Name like '%'+@Keyword+'%' or Supplier_Phone like '%'+@Keyword+'%' or Supplier_Address like '%'+@Keyword+'%' 
		or Supplier_Email like '%'+@Keyword+'%'
		or Supplier_Facbook like '%'+@Keyword+'%'
		or Supplier_Zalo like '%'+@Keyword+'%'
		)
	)
	order by [Supplier_Name]
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Supplier_Delete]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Supplier_Delete]
	@Supplier_ID varchar(20),
	@ModifiedBy varchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE [dbo].[tbl_Supplier]
	   SET 
		   [IsDelete] = 1
		  ,[ModifiedDate] = GETDATE()
		  ,[ModifiedBy] = @ModifiedBy
		WHERE [Supplier_ID] = @Supplier_ID
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Supplier_Check]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Supplier_Check]
	@Supplier_ID varchar(20) = null,
	@Supplier_Phone varchar(20) = null

AS
BEGIN
	SET NOCOUNT ON;
	SELECT [Supplier_ID]
	FROM [dbo].[tbl_Supplier]
	WHERE Supplier_Phone = @Supplier_Phone
	and IsDelete = 0
	and (@Supplier_ID is null or Supplier_ID <> @Supplier_ID)
	
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Supplier_Add]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Supplier_Add]
	@Supplier_ID varchar(20),
	@Supplier_Name nvarchar(50),
	@Supplier_Phone varchar(20),
	@Supplier_Address nvarchar(500),
	@Supplier_Email nvarchar(250),
	@Supplier_Facbook nvarchar(250),
	@Supplier_Zalo nvarchar(250),
	@Supplier_Description nvarchar(250),
	@IsActive bit,
	@CreatedBy varchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO [dbo].[tbl_Supplier]
           (Supplier_ID
           ,[Supplier_Name]
           ,Supplier_Phone
           ,Supplier_Address
           ,Supplier_Email
           ,Supplier_Facbook
           ,Supplier_Zalo
           ,[Supplier_Description]
           ,[IsActive]
           ,[CreatedBy])
     VALUES
           (
				@Supplier_ID
			   ,@Supplier_Name
			   ,@Supplier_Phone
			   ,@Supplier_Address
			   ,@Supplier_Email
			   ,@Supplier_Facbook
			   ,@Supplier_Zalo
			   ,@Supplier_Description
			   ,@IsActive
			   ,@CreatedBy
           )
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_SendType_Update_Index]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_SendType_Update_Index]
	@SendType_ID int,
	@Orderindex int
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE [dbo].[tbl_SendType]
	   SET Orderindex = @Orderindex
		WHERE [SendType_ID] = @SendType_ID
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_SendType_Update]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_SendType_Update]
	@SendType_ID int,
	@SendType_Name nvarchar(50),
	@SendType_Description nvarchar(250),
	@IsActive bit,
	@ModifiedBy varchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE [dbo].[tbl_SendType]
	   SET [SendType_Name] = @SendType_Name
		  ,[SendType_Description] = @SendType_Description
		  ,[IsActive] = @IsActive
		  ,[ModifiedDate] = GETDATE()
		  ,[ModifiedBy] = @ModifiedBy
		WHERE [SendType_ID] = @SendType_ID
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_SendType_Select]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_SendType_Select]
	@SendType_ID int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT [SendType_ID]
      ,[SendType_Name]
      ,[SendType_Description]
      ,[IsActive]
      ,[IsDelete]
      ,[CreatedDate]
      ,[CreatedBy]
      ,[ModifiedDate]
      ,[ModifiedBy]
	FROM [dbo].[tbl_SendType]
	WHERE [SendType_ID] = @SendType_ID
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_SendType_Seach]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_SendType_Seach]
	@Keyword nvarchar(50)= null,
	@IsDelete bit
AS
BEGIN
	SET NOCOUNT ON;
	SELECT [SendType_ID]
      ,[SendType_Name]
      ,[SendType_Description]
      ,[IsActive]
      ,[IsDelete]
      ,[CreatedDate]
      ,[CreatedBy]
      ,[ModifiedDate]
      ,[ModifiedBy]
	FROM [dbo].[tbl_SendType]
	WHERE IsDelete = @IsDelete 
	and (@Keyword = null or (SendType_ID like '%'+@Keyword+'%' or SendType_Name like '%'+@Keyword+'%'))
	order by Orderindex
END
GO
/****** Object:  StoredProcedure [dbo].[pr_SendType_Delete]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_SendType_Delete]
	@SendType_ID int,
	@ModifiedBy varchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE [dbo].[tbl_SendType]
	   SET 
		   [IsDelete] = 1
		  ,[ModifiedDate] = GETDATE()
		  ,[ModifiedBy] = @ModifiedBy
		WHERE [SendType_ID] = @SendType_ID
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_SendType_Cache]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_SendType_Cache]
AS
BEGIN
	SET NOCOUNT ON;
	SELECT [SendType_ID]
      ,[SendType_Name]
	FROM [dbo].[tbl_SendType]
	WHERE [IsActive] = 1 and [IsDelete] = 0
	order by Orderindex
END
GO
/****** Object:  StoredProcedure [dbo].[pr_SendType_Add]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_SendType_Add]
	@SendType_Name nvarchar(50),
	@SendType_Description nvarchar(250),
	@IsActive bit,
	@CreatedBy varchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	--Lấy số thự tự lớn nhất
	BEGIN
		DECLARE @IndexMax INT = 0
		SELECT @IndexMax = COUNT(*) FROM tbl_SendType WHERE IsDelete = 0
	END
	INSERT INTO [dbo].[tbl_SendType]
           ([SendType_Name]
           ,[SendType_Description]
           ,[Orderindex]
           ,[IsActive]
           ,[CreatedBy])
     VALUES
           (@SendType_Name
           ,@SendType_Description
           ,@IndexMax
           ,@IsActive
           ,@CreatedBy)
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_ProductQuantity_Update]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_ProductQuantity_Update]
	@ProductID varchar(10),
	@Quantity numeric(18, 0)
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE [dbo].[tbl_ProductQuantity]
	   SET [Quantity] = @Quantity
		WHERE [ProductID] = @Quantity
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_ProductQuantity_Select]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_ProductQuantity_Select]
	@ProductID varchar(10)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT [ProductID]
      ,[Quantity]
      ,QuantitySale
      ,([Quantity] - QuantitySale) as Total
	FROM [dbo].[tbl_ProductQuantity]
	WHERE [ProductID] = @ProductID
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_ProductQuantity_Seach]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_ProductQuantity_Seach]
	@Keyword nvarchar(50)= null,
	@Type int = -1,
	@IsQuantity int = 0
AS
BEGIN
	SET NOCOUNT ON;
	SELECT
	  0 as ISSELECT
	  ,tbl_Model.Model_ID + '-'+ tbl_Model.Model_Name as Model
	  ,tbl_Product.Product_ID
	  ,tbl_Product.Product_Name
      ,tbl_Color.Color_Name
      ,ISNULL(tbl_ProductQuantity.[Quantity],0) as Quantity
      ,ISNULL(tbl_ProductQuantity.QuantitySale,0) as QuantitySale
      ,ISNULL([Quantity] - QuantitySale,0) as Total
	FROM tbl_Product
	left join [tbl_ProductQuantity] on tbl_Product.Product_ID = tbl_ProductQuantity.ProductID
	join tbl_Model on tbl_Model.Model_ID = tbl_Product.Product_ModelID
	join tbl_Color on tbl_Color.Color_Id = tbl_Product.Product_ColorID
	WHERE tbl_Product.IsActive = 1 and tbl_Product.IsDelete = 0
	and 
		(
			@Type = 0 and (@Keyword = '' or tbl_Product.Product_ID like '%'+@Keyword+'%' or tbl_Product.Product_Name like '%'+@Keyword+'%')
			or @Type = 1 and (@Keyword = '' or tbl_Model.Model_ID like '%'+@Keyword+'%' or tbl_Model.Model_Name like '%'+@Keyword+'%')
			or @Type = 2 and (@Keyword = '' or tbl_Color.Color_Name like '%'+@Keyword+'%')
			or @Type = -1 and 
							(
								@Keyword = '' or tbl_Product.Product_ID like '%'+@Keyword+'%' or tbl_Product.Product_Name like '%'+@Keyword+'%'
								or tbl_Model.Model_ID like '%'+@Keyword+'%' or tbl_Model.Model_Name like '%'+@Keyword+'%'
								or tbl_Color.Color_Name like '%'+@Keyword+'%'
							)
		)
	and 
		(
			@IsQuantity = -1
			or (@IsQuantity = 0 and ISNULL([Quantity] - QuantitySale,0) > 0)
			or (@IsQuantity = 1 and ISNULL([Quantity] - QuantitySale,0) <= 0)
		)
	order by tbl_Model.Model_Name, tbl_Product.Product_Name
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_ProductQuantity_Sale]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_ProductQuantity_Sale]
	@ProductID varchar(50),
	@Quantity numeric(18, 0)
AS
BEGIN
	SET NOCOUNT ON;
	IF EXISTS(SELECT 1 FROM tbl_ProductQuantity WHERE ProductID = @ProductID) 
		UPDATE [dbo].[tbl_ProductQuantity]
		SET [QuantitySale] = QuantitySale + @Quantity
		WHERE [ProductID] = @ProductID
	ELSE
		INSERT INTO [dbo].[tbl_ProductQuantity]([ProductID],[Quantity],QuantitySale)
		 VALUES(@ProductID,0,@Quantity)
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_ProductQuantity_OutputSale]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_ProductQuantity_OutputSale]
	@ProductID varchar(50),
	@Quantity numeric(18, 0)
AS
BEGIN
	SET NOCOUNT ON;
		UPDATE [dbo].[tbl_ProductQuantity]
		SET [Quantity] = Quantity - @Quantity,
		[QuantitySale] = QuantitySale - @Quantity
		WHERE [ProductID] = @ProductID
END
GO
/****** Object:  StoredProcedure [dbo].[pr_ProductQuantity_Output]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_ProductQuantity_Output]
	@ProductID varchar(50),
	@Quantity numeric(18, 0)
AS
BEGIN
	SET NOCOUNT ON;
		UPDATE [dbo].[tbl_ProductQuantity]
		SET [Quantity] = Quantity - @Quantity
		WHERE [ProductID] = @ProductID
END
GO
/****** Object:  StoredProcedure [dbo].[pr_ProductQuantity_Input]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_ProductQuantity_Input]
	@ProductID varchar(50),
	@Quantity numeric(18, 0)
AS
BEGIN
	SET NOCOUNT ON;
	IF EXISTS(SELECT 1 FROM tbl_ProductQuantity WHERE ProductID = @ProductID) 
		UPDATE [dbo].[tbl_ProductQuantity]
		SET [Quantity] = Quantity + @Quantity
		WHERE [ProductID] = @ProductID
	ELSE
		INSERT INTO [dbo].[tbl_ProductQuantity]([ProductID],[Quantity],QuantitySale)
		 VALUES(@ProductID,@Quantity,0)
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_ProductQuantity_Add]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_ProductQuantity_Add]
	@ProductID varchar(10),
	@Quantity numeric(18, 0)
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO [dbo].[tbl_ProductQuantity]
           ([ProductID]
           ,[Quantity])
     VALUES
           (@ProductID
           ,@Quantity)
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Product_Update]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Product_Update]
	@Product_Id nvarchar(50),
	@Product_ColorID int,
	@Product_ModelID varchar(50),
	@Product_Name nvarchar(250),
	@Product_Description nvarchar(500),
	@IsActive bit,
	@ModifiedBy varchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE [dbo].[tbl_Product]
	   SET [Product_Name] = @Product_Name
	      ,Product_ColorID = @Product_ColorID
	      ,Product_ModelID = @Product_ModelID
		  ,[Product_Description] = @Product_Description
		  ,[IsActive] = @IsActive
		  ,[ModifiedDate] = GETDATE()
		  ,[ModifiedBy] = @ModifiedBy
		WHERE [Product_ID] = @Product_ID
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Product_Select]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Product_Select]
	@Product_Id nvarchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT [Product_ID]
      ,[Product_ColorID]
      ,[Product_ModelID]
      ,[Product_Name]
      ,[Product_Description]
      ,[IsActive]
      ,[IsDelete]
      ,[CreatedDate]
      ,[CreatedBy]
      ,[ModifiedDate]
      ,[ModifiedBy]
	FROM [dbo].[tbl_Product]
	WHERE [Product_ID] = @Product_ID
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Product_Seach]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Product_Seach]
	@Keyword nvarchar(50)= null,
	@Product_ColorID int,
	@Product_ModelID varchar(50),
	@IsDelete bit
AS
BEGIN
	SET NOCOUNT ON;
	SELECT [Product_ID]
	  ,tbl_Model.Model_Name
      ,tbl_Color.Color_Name
      ,tbl_Product.[Product_Name]
      ,tbl_Product.[Product_Description]
      ,tbl_Product.[IsActive]
      ,tbl_Product.[IsDelete]
      ,tbl_Product.[CreatedDate]
      ,tbl_Product.[CreatedBy]
      ,tbl_Product.[ModifiedDate]
      ,tbl_Product.[ModifiedBy]
	FROM [dbo].[tbl_Product]
	join tbl_Model on tbl_Model.Model_ID = tbl_Product.Product_ModelID
	join tbl_Color on tbl_Color.Color_Id = tbl_Product.Product_ColorID
	WHERE tbl_Product.IsDelete = @IsDelete 
	and (@Product_ColorID = -1 or tbl_Product.[Product_ColorID] = @Product_ColorID)
	and (@Product_ModelID = '-1' or tbl_Product.[Product_ModelID] = @Product_ModelID)
	and (@Keyword = null or (tbl_Product.Product_ID like '%'+@Keyword+'%' or tbl_Product.Product_Name like '%'+@Keyword+'%'))
	order by tbl_Product.[Product_Name]
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Product_Delete]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Product_Delete]
	@Product_Id nvarchar(50),
	@ModifiedBy varchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE [dbo].[tbl_Product]
	   SET 
		   [IsDelete] = 1
		  ,[ModifiedDate] = GETDATE()
		  ,[ModifiedBy] = @ModifiedBy
		WHERE [Product_ID] = @Product_ID
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Product_Check]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Product_Check]
	@Product_ID varchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT [Product_ID]
	FROM [dbo].[tbl_Product]
	WHERE Product_ID = @Product_ID 
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Product_Cache]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Product_Cache]
AS
BEGIN
	SET NOCOUNT ON;
	SELECT tbl_Product.[Product_ID]
		  ,tbl_Product.[Product_ColorID]
		  ,tbl_Product.[Product_ModelID]
		  ,tbl_Product.[Product_Name]
		  ,tbl_Product.[Product_Description]
		  ,tbl_Color.Color_Name
	FROM [dbo].[tbl_Product]
	join tbl_Color on tbl_Color.Color_Id = tbl_Product.Product_ColorID
	WHERE tbl_Product.[IsActive] = 1 and tbl_Product.[IsDelete] = 0
	order by tbl_Product.[Product_Name] 
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Product_Add]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Product_Add]
	@Product_Id nvarchar(50),
	@Product_ColorID int,
	@Product_ModelID varchar(50),
	@Product_Name nvarchar(250),
	@Product_Description nvarchar(500),
	@IsActive bit,
	@CreatedBy varchar(50)
AS
BEGIN
	SET NOCOUNT ON;
INSERT INTO [dbo].[tbl_Product]
           ([Product_ID]
           ,[Product_ColorID]
           ,[Product_ModelID]
           ,[Product_Name]
           ,[Product_Description]
           ,[IsActive]
           ,[CreatedBy])
     VALUES
           (@Product_ID,
			@Product_ColorID,
			@Product_ModelID,
			@Product_Name,
			@Product_Description,
			@IsActive,
			@CreatedBy
           )
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_PriceType_Update_Index]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_PriceType_Update_Index]
	@PriceType_ID int,
	@Orderindex int
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE [dbo].[tbl_PriceType]
	   SET Orderindex = @Orderindex
		WHERE [PriceType_ID] = @PriceType_ID
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_PriceType_Update]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_PriceType_Update]
	@PriceType_ID int,
	@PriceType_Name nvarchar(50),
	@PriceType_Description nvarchar(250),
	@IsActive bit,
	@Isdefault bit,
	@ModifiedBy varchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	BEGIN
		IF @Isdefault = 1
			UPDATE tbl_PriceType SET Isdefault = 0
	END
	UPDATE [dbo].[tbl_PriceType]
	   SET [PriceType_Name] = @PriceType_Name
		  ,[PriceType_Description] = @PriceType_Description
		  ,[IsActive] = @IsActive
		  ,Isdefault = @Isdefault
		  ,[ModifiedDate] = GETDATE()
		  ,[ModifiedBy] = @ModifiedBy
		WHERE [PriceType_ID] = @PriceType_ID
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_PriceType_Select]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_PriceType_Select]
	@PriceType_ID int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT [PriceType_ID]
      ,[PriceType_Name]
      ,[PriceType_Description]
      ,Isdefault
      ,[IsActive]
      ,[IsDelete]
      ,[CreatedDate]
      ,[CreatedBy]
      ,[ModifiedDate]
      ,[ModifiedBy]
	FROM [dbo].[tbl_PriceType]
	WHERE [PriceType_ID] = @PriceType_ID
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_PriceType_Seach]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_PriceType_Seach]
	@Keyword nvarchar(50)= null,
	@IsDelete bit
AS
BEGIN
	SET NOCOUNT ON;
	SELECT [PriceType_ID]
      ,[PriceType_Name]
      ,[PriceType_Description]
      ,Isdefault
      ,[IsActive]
      ,[IsDelete]
      ,[CreatedDate]
      ,[CreatedBy]
      ,[ModifiedDate]
      ,[ModifiedBy]
	FROM [dbo].[tbl_PriceType]
	WHERE IsDelete = @IsDelete 
	and (@Keyword is null or (PriceType_ID like '%'+@Keyword+'%' or PriceType_Name like '%'+@Keyword+'%'))
	order by Orderindex
END
GO
/****** Object:  StoredProcedure [dbo].[pr_PriceType_Delete]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_PriceType_Delete]
	@PriceType_ID int,
	@ModifiedBy varchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE [dbo].[tbl_PriceType]
	   SET 
		   [IsDelete] = 1
		  ,[ModifiedDate] = GETDATE()
		  ,[ModifiedBy] = @ModifiedBy
		WHERE [PriceType_ID] = @PriceType_ID
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_PriceType_Cache]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_PriceType_Cache]
AS
BEGIN
	SET NOCOUNT ON;
	SELECT [PriceType_ID]
      ,[PriceType_Name]
      ,Isdefault
	FROM [dbo].[tbl_PriceType]
	WHERE [IsActive] = 1 and [IsDelete] = 0
	order by Orderindex
END
GO
/****** Object:  StoredProcedure [dbo].[pr_PriceType_Add]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_PriceType_Add]
	@PriceType_Name nvarchar(50),
	@PriceType_Description nvarchar(250),
	@IsActive bit,
	@Isdefault bit,
	@CreatedBy varchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	--Lấy số thự tự lớn nhất
	BEGIN
		DECLARE @IndexMax INT = 0
		SELECT @IndexMax = COUNT(*) FROM tbl_PriceType WHERE IsDelete = 0
	END
	BEGIN
		IF @Isdefault = 1
			UPDATE tbl_PriceType SET Isdefault = 0
	END
	INSERT INTO [dbo].[tbl_PriceType]
           ([PriceType_Name]
           ,[PriceType_Description]
           ,Isdefault
           ,[Orderindex]
           ,[IsActive]
           ,[CreatedBy])
     VALUES
           (@PriceType_Name
           ,@PriceType_Description
           ,@Isdefault
           ,@IndexMax
           ,@IsActive
           ,@CreatedBy)
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Price_Update]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Price_Update]
	@Price_Type int,
	@Price_Product varchar(50),
	@Price_Now decimal(18, 4),
	@Price_Old decimal(18, 4),
	@Price_Description nvarchar(250),
	@ModifiedBy varchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	IF EXISTS(SELECT 1 FROM tbl_Price WHERE Price_Type = @Price_Type and Price_Product = @Price_Product)
	BEGIN
	UPDATE [dbo].[tbl_Price]
	   SET Price_Now = @Price_Now
		  ,[Price_Description] = @Price_Description
		  ,Price_Old = @Price_Old
		  ,[ModifiedDate] = GETDATE()
		  ,[ModifiedBy] = @ModifiedBy
		WHERE Price_Type = @Price_Type and Price_Product = @Price_Product
   END 
   ELSE
   BEGIN
	INSERT INTO [dbo].[tbl_Price]
           ([Price_Type]
           ,[Price_Product]
           ,Price_Now
           ,[Price_Old]
           ,[Price_Description]
           ,[ModifiedDate]
           ,[ModifiedBy])
     VALUES
           (@Price_Type
           ,@Price_Product
           ,@Price_Now
           ,@Price_Old
           ,@Price_Description
           ,GETDATE()
           ,@ModifiedBy)
   END
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Price_Seach]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Price_Seach]
	@Price_Type int = -1,
	@Product_ModelID varchar(50) = -1,
	@Keyword nvarchar(50)= null
AS
BEGIN
	SET NOCOUNT ON;
	SELECT 
	   0 as 'ISSELECT'
      ,tbl_Product.Product_ID
      ,tbl_Product.Product_Name
      ,tbl_Price.[Price_Now]
      ,tbl_Price.Price_Description
       ,tbl_Price.Price_Old
      ,tbl_Price.ModifiedDate
      ,tbl_Price.ModifiedBy
      ,tbl_Price.Price_Type
      ,tbl_Price.[Price_Now] as 'OLD'
	FROM tbl_Product 
	left join [tbl_Price] on tbl_Product.Product_ID = tbl_Price.Price_Product and tbl_Price.[Price_Type] = @Price_Type
	join tbl_Model on tbl_Model.Model_ID = tbl_Product.Product_ModelID
	WHERE 
	 tbl_Product.IsActive = 1 and tbl_Product.IsDelete = 0
	and (@Product_ModelID = '-1' or tbl_Product.[Product_ModelID] = @Product_ModelID)
	and (@Keyword = null or (tbl_Product.Product_ID like '%'+@Keyword+'%' or tbl_Product.Product_Name like '%'+@Keyword+'%'))
	order by tbl_Product.Product_Name
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Price_Cache]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Price_Cache]
AS
BEGIN
	SET NOCOUNT ON;
	select Price_Type
      ,Price_Product
      ,Price_Now
	FROM tbl_Price
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Payments_Update]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Payments_Update]
	@Payments_ID varchar(20),
	@Payments_Description nvarchar(500),
	@ModifiedBy varchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE [dbo].[tbl_Payments]
	   SET Payments_Description = @Payments_Description
		  ,[ModifiedDate] = GETDATE()
		  ,[ModifiedBy] = @ModifiedBy
		WHERE [Payments_ID] = @Payments_ID
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Payments_Select]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Payments_Select]
	@Payments_ID varchar(20)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT  [Payments_ID]
      ,[Payments_Date]
      ,[Payments_Amount]
      ,[Payments_CustomerID]
      ,[Payments_Vouchers]
      ,[Payments_Description]
      ,[Payments_Type]
      ,[IsDelete]
      ,[CreatedDate]
      ,[CreatedBy]
      ,[ModifiedDate]
      ,[ModifiedBy]
	FROM [dbo].[tbl_Payments]
	WHERE [Payments_ID] = @Payments_ID
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Payments_Seach]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Payments_Seach]
	@Keyword nvarchar(50)= null,
	@Type int = -1,
	@Payments_Type int = -1,
	@Fromdate smalldatetime,
	@Todate	smalldatetime,
	@IsDelete bit = 0
AS
BEGIN
	SET NOCOUNT ON;
	IF @Payments_Type = 1
		SELECT tbl_Payments.[Payments_ID]
		  ,tbl_Payments.[Payments_Date]
		  ,tbl_Supplier.Supplier_Name as Name
		  ,tbl_Supplier.Supplier_Phone as Phone
		  ,tbl_Payments.Payments_Amount
		  ,tbl_Payments.Payments_Vouchers
		  ,tbl_Payments.Payments_Description
		  ,tbl_Payments.[CreatedDate]
		  ,tbl_Payments.[CreatedBy]
		  ,tbl_Payments.[ModifiedDate]
		  ,tbl_Payments.[ModifiedBy]
	  FROM [tbl_Payments]
	  join tbl_Supplier on tbl_Supplier.Supplier_ID = tbl_Payments.Payments_CustomerID
		WHERE tbl_Payments.IsDelete = @IsDelete 
		and tbl_Payments.Payments_Date >= cast(cast(@Fromdate as DATE) as DATETIME)
		and tbl_Payments.Payments_Date < cast(cast(@Todate as DATE) as DATETIME)+1
		and tbl_Payments.Payments_Type = 1
		and 
		(
			@Type = 0 and (@Keyword = '' or tbl_Payments.[Payments_ID] like '%'+@Keyword+'%')
			or @Type = 1 and (@Keyword = '' or tbl_Payments.Payments_Vouchers like '%'+@Keyword+'%')
			or @Type = 2 and (@Keyword = '' or tbl_Supplier.Supplier_Phone like '%'+@Keyword+'%')
			or @Type = 3 and (@Keyword = '' or tbl_Supplier.Supplier_Name like '%'+@Keyword+'%')
		)
		order by tbl_Payments.Payments_Date desc
	ELSE
		SELECT tbl_Payments.[Payments_ID]
		  ,tbl_Payments.[Payments_Date]
		  ,tbl_Customer.Customer_Name as Name
		  ,tbl_Customer.Customer_Phone as Phone
		  ,tbl_Payments.Payments_Amount
		  ,tbl_Payments.Payments_Vouchers
		  ,tbl_Payments.Payments_Description
		  ,tbl_Payments.[CreatedDate]
		  ,tbl_Payments.[CreatedBy]
		  ,tbl_Payments.[ModifiedDate]
		  ,tbl_Payments.[ModifiedBy]
		  FROM [tbl_Payments]
		  join tbl_Customer on tbl_Customer.Customer_ID = tbl_Payments.Payments_CustomerID
			WHERE tbl_Payments.IsDelete = @IsDelete 
			and tbl_Payments.Payments_Date >= cast(cast(@Fromdate as DATE) as DATETIME)
			and tbl_Payments.Payments_Date < cast(cast(@Todate as DATE) as DATETIME)+1
			and tbl_Payments.Payments_Type = 0
			and 
			(
				@Type = 0 and (@Keyword = '' or tbl_Payments.[Payments_ID] like '%'+@Keyword+'%')
				or @Type = 1 and (@Keyword = '' or tbl_Payments.Payments_Vouchers like '%'+@Keyword+'%')
				or @Type = 2 and (@Keyword = '' or tbl_Customer.Customer_Phone like '%'+@Keyword+'%')
				or @Type = 3 and (@Keyword = '' or tbl_Customer.Customer_Name like '%'+@Keyword+'%')
			)
			order by tbl_Payments.Payments_Date desc
	
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Payments_Delete]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Payments_Delete]
	@Payments_ID varchar(20),
	@ModifiedBy varchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE [dbo].[tbl_Payments]
	   SET 
		   [IsDelete] = 1
		  ,[ModifiedDate] = GETDATE()
		  ,[ModifiedBy] = @ModifiedBy
		WHERE [Payments_ID] = @Payments_ID
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Payments_Add]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Payments_Add]
	@Payments_ID varchar(20),
	@Payments_Date smalldatetime,
	@Payments_CustomerID varchar(20),
	@Payments_Description nvarchar(2000),
	@Payments_Vouchers varchar(20),
	@Payments_Amount decimal(18, 4),
	@Payments_Type int,
	@CreatedBy varchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO [dbo].[tbl_Payments]
           (Payments_ID
           ,Payments_Date
           ,Payments_CustomerID
           ,Payments_Description
           ,Payments_Vouchers
           ,Payments_Amount
           ,Payments_Type
           ,CreatedBy)
     VALUES
           (@Payments_ID
           ,@Payments_Date
           ,@Payments_CustomerID
           ,@Payments_Description
           ,@Payments_Vouchers
           ,@Payments_Amount
           ,@Payments_Type
           ,@CreatedBy)
    IF @Payments_Vouchers <> '' and @Payments_Type = 0
		UPDATE [dbo].[tbl_Order]
		   SET 
			  Order_IsVoucher = 1
			  ,Order_VoucherID = @Payments_ID
			WHERE [Order_ID] = @Payments_Vouchers
	ELSE IF @Payments_Vouchers <> '' and @Payments_Type = 1
		UPDATE [tbl_Input]
		   SET 
			  [Input_IsVoucher] = 1
			  ,[Input_VoucherID] = @Payments_ID
		 WHERE Input_ID = @Payments_Vouchers
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_OutputDetail_Update]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_OutputDetail_Update]
	@OutputDetail_ProductID varchar(50),
	@OutputDetail_OutputID varchar(20),
	@OutputDetail_Price decimal(18, 4),
	@OutputDetail_Quantity int
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE [dbo].[tbl_OutputDetail]
	   SET [OutputDetail_Price] = @OutputDetail_Price
	      ,[OutputDetail_Quantity] = @OutputDetail_Quantity
		WHERE [OutputDetail_ProductID] = @OutputDetail_ProductID
		and [OutputDetail_OutputID] = @OutputDetail_OutputID
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_OutputDetail_SelectLIST]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_OutputDetail_SelectLIST]
	@OutputDetail_OutputID varchar(20)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT tbl_OutputDetail.[OutputDetail_ProductID]
      ,tbl_OutputDetail.[OutputDetail_OutputID]
      ,tbl_OutputDetail.[OutputDetail_Price]
      ,tbl_OutputDetail.[OutputDetail_Quantity]
      ,tbl_Product.Product_Name
      ,tbl_Color.Color_Name
	FROM [dbo].[tbl_OutputDetail]
	join tbl_Product on tbl_Product.Product_ID = tbl_OutputDetail.OutputDetail_ProductID
	join tbl_Color on tbl_Color.Color_Id = tbl_Product.Product_ColorID
	WHERE tbl_OutputDetail.OutputDetail_OutputID = @OutputDetail_OutputID
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_OutputDetail_Select]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_OutputDetail_Select]
	@OutputDetail_ProductID varchar(50),
	@OutputDetail_OutputID varchar(20)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT tbl_OutputDetail.[OutputDetail_ProductID]
      ,tbl_OutputDetail.[OutputDetail_OutputID]
      ,tbl_OutputDetail.[OutputDetail_Price]
      ,tbl_OutputDetail.[OutputDetail_Quantity]
      ,tbl_Product.Product_Name
      ,tbl_Color.Color_Name
	FROM [dbo].[tbl_OutputDetail]
	join tbl_Product on tbl_Product.Product_ID = tbl_OutputDetail.OutputDetail_ProductID
	join tbl_Color on tbl_Color.Color_Id = tbl_Product.Product_ColorID
	WHERE tbl_OutputDetail.OutputDetail_ProductID = @OutputDetail_ProductID  
		and tbl_OutputDetail.OutputDetail_OutputID = @OutputDetail_OutputID
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_OutputDetail_Delete]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_OutputDetail_Delete]
	@OutputDetail_ProductID varchar(50),
	@OutputDetail_OutputID varchar(20)
AS
BEGIN
	SET NOCOUNT ON;
	Delete [dbo].[tbl_OutputDetail]
		WHERE [OutputDetail_ProductID] = @OutputDetail_ProductID
		and [OutputDetail_OutputID] = @OutputDetail_OutputID
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_OutputDetail_Add]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_OutputDetail_Add]
	@OutputDetail_ProductID varchar(50),
	@OutputDetail_OutputID varchar(20),
	@OutputDetail_Price decimal(18, 4),
	@OutputDetail_Quantity int
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO [dbo].[tbl_OutputDetail]
           ([OutputDetail_ProductID]
           ,[OutputDetail_OutputID]
           ,[OutputDetail_Price]
           ,[OutputDetail_Quantity])
     VALUES
           (@OutputDetail_ProductID
           ,@OutputDetail_OutputID
           ,@OutputDetail_Price
           ,@OutputDetail_Quantity)
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Output_Update]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Output_Update]
	@Output_ID varchar(20),
	@Output_Description nvarchar(500),
	@Output_Total decimal(18, 4),
	@ModifiedBy varchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE [dbo].[tbl_Output]
	   SET Output_Description = @Output_Description
		  ,Output_Total = @Output_Total
		  ,[ModifiedDate] = GETDATE()
		  ,[ModifiedBy] = @ModifiedBy
		WHERE [Output_ID] = @Output_ID
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Output_Select]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Output_Select]
	@Output_ID varchar(20)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT [Output_ID]
      ,[Output_Date]
      ,[Output_CustomerID]
      ,[Output_Description]
      ,Output_Vouchers
      ,[IsDelete]
      ,[CreatedDate]
      ,[CreatedBy]
      ,[ModifiedDate]
      ,[ModifiedBy]
      ,[Output_Total]
	FROM [dbo].[tbl_Output]
	WHERE [Output_ID] = @Output_ID
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Output_Seach]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Output_Seach]
	@Keyword nvarchar(50)= null,
	@Type int = -1,
	@Fromdate smalldatetime,
	@Todate	smalldatetime,
	@IsDelete bit = 0
AS
BEGIN
	SET NOCOUNT ON;
	SELECT tbl_Output.[Output_ID]
      ,tbl_Output.[Output_Date]
      ,tbl_Customer.Customer_Name
      ,tbl_Customer.Customer_Phone
      ,tbl_Output.Output_Vouchers
      ,tbl_Output.[CreatedDate]
      ,tbl_Output.[CreatedBy]
      ,tbl_Output.[ModifiedDate]
      ,tbl_Output.[ModifiedBy]
      ,tbl_Output.[Output_Description]
  FROM [tbl_Output]
  join tbl_Customer on tbl_Customer.Customer_ID = tbl_Output.Output_CustomerID
	WHERE tbl_Output.IsDelete = @IsDelete 
	and tbl_Output.Output_Date >= cast(cast(@Fromdate as DATE) as DATETIME)
	and tbl_Output.Output_Date < cast(cast(@Todate as DATE) as DATETIME)+1
	and 
	(
		@Type = 0 and (@Keyword = '' or tbl_Output.Output_ID like '%'+@Keyword+'%')
		or @Type = 1 and (@Keyword = '' or tbl_Customer.Customer_Name like '%'+@Keyword+'%')
		or @Type = 2 and (@Keyword = '' or tbl_Customer.Customer_Phone like '%'+@Keyword+'%')
		or @Type = 3 and (@Keyword = '' or tbl_Output.Output_Vouchers like '%'+@Keyword+'%')
	)
	order by tbl_Output.Output_Date desc
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Output_Delete]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Output_Delete]
	@Output_ID varchar(20),
	@ModifiedBy varchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE [dbo].[tbl_Output]
	   SET 
		   [IsDelete] = 1
		  ,[ModifiedDate] = GETDATE()
		  ,[ModifiedBy] = @ModifiedBy
		WHERE [Output_ID] = @Output_ID
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Output_Add]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Output_Add]
	@Output_ID varchar(20),
	@Output_Date smalldatetime,
	@Output_CustomerID varchar(20),
	@Output_Description nvarchar(500),
	@CreatedBy varchar(50),
	@Output_Vouchers varchar(20),
	@Output_Total decimal(18, 4)
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO [dbo].[tbl_Output]
           (Output_ID
           ,Output_Date
           ,Output_CustomerID
           ,[Output_Description]
           ,Output_Total
           ,Output_Vouchers
           ,[CreatedBy])
     VALUES
           (@Output_ID
           ,@Output_Date
           ,@Output_CustomerID
           ,@Output_Description
           ,@Output_Total
           ,@Output_Vouchers
           ,@CreatedBy)
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_OrderDetail_Update]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_OrderDetail_Update]
	@OrderDetail_ProductID varchar(50),
	@OrderDetail_OrderID varchar(20),
	@OrderDetail_Price decimal(18, 4),
	@OrderDetail_Sale decimal(18, 4),
	@OrderDetail_Quantity int,
	@OrderDetail_PriceType int
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE [dbo].[tbl_OrderDetail]
	   SET [OrderDetail_Price] = @OrderDetail_Price
	      ,[OrderDetail_Quantity] = @OrderDetail_Quantity
	      ,OrderDetail_Sale = @OrderDetail_Sale
	      ,OrderDetail_PriceType =@OrderDetail_PriceType
		WHERE [OrderDetail_ProductID] = @OrderDetail_ProductID
		and [OrderDetail_OrderID] = @OrderDetail_OrderID
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_OrderDetail_SelectLIST]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_OrderDetail_SelectLIST]
	@OrderDetail_OrderID varchar(20)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT tbl_OrderDetail.[OrderDetail_ProductID]
      ,tbl_OrderDetail.[OrderDetail_OrderID]
      ,tbl_OrderDetail.[OrderDetail_Price]
      ,tbl_OrderDetail.OrderDetail_Sale
      ,tbl_OrderDetail.OrderDetail_PriceType
      ,tbl_OrderDetail.[OrderDetail_Quantity]
      ,tbl_Product.Product_Name
      ,tbl_Color.Color_Name
	FROM [dbo].[tbl_OrderDetail]
	join tbl_Product on tbl_Product.Product_ID = tbl_OrderDetail.OrderDetail_ProductID
	join tbl_Color on tbl_Color.Color_Id = tbl_Product.Product_ColorID
	WHERE tbl_OrderDetail.OrderDetail_OrderID = @OrderDetail_OrderID
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_OrderDetail_Select]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_OrderDetail_Select]
	@OrderDetail_ProductID varchar(50),
	@OrderDetail_OrderID varchar(20)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT tbl_OrderDetail.[OrderDetail_ProductID]
	  ,tbl_Product.Product_Name
      ,tbl_Color.Color_Name
      ,tbl_OrderDetail.[OrderDetail_OrderID]
      ,tbl_OrderDetail.OrderDetail_PriceType
      ,tbl_OrderDetail.[OrderDetail_Price]
      ,tbl_OrderDetail.OrderDetail_Sale
      ,tbl_OrderDetail.[OrderDetail_Quantity]
      
	FROM [dbo].[tbl_OrderDetail]
	join tbl_Product on tbl_Product.Product_ID = tbl_OrderDetail.OrderDetail_ProductID
	join tbl_Color on tbl_Color.Color_Id = tbl_Product.Product_ColorID
	WHERE tbl_OrderDetail.OrderDetail_ProductID = @OrderDetail_ProductID  
		and tbl_OrderDetail.OrderDetail_OrderID = @OrderDetail_OrderID
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_OrderDetail_Delete]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_OrderDetail_Delete]
	@OrderDetail_ProductID varchar(50),
	@OrderDetail_OrderID varchar(20)
AS
BEGIN
	SET NOCOUNT ON;
	Delete [dbo].[tbl_OrderDetail]
		WHERE [OrderDetail_ProductID] = @OrderDetail_ProductID
		and [OrderDetail_OrderID] = @OrderDetail_OrderID
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_OrderDetail_Add]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_OrderDetail_Add]
	@OrderDetail_ProductID varchar(50),
	@OrderDetail_OrderID varchar(20),
	@OrderDetail_Price decimal(18, 4),
	@OrderDetail_Quantity int,
	@OrderDetail_Sale decimal(18, 4),
	@OrderDetail_PriceType int
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO [dbo].[tbl_OrderDetail]
           ([OrderDetail_ProductID]
           ,[OrderDetail_OrderID]
           ,[OrderDetail_Price]
           ,[OrderDetail_Quantity]
           ,OrderDetail_Sale
           ,OrderDetail_PriceType)
     VALUES
           (@OrderDetail_ProductID
           ,@OrderDetail_OrderID
           ,@OrderDetail_Price
           ,@OrderDetail_Quantity
           ,@OrderDetail_Sale
           ,@OrderDetail_PriceType)
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Order_Update_Status]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Order_Update_Status]
	@Order_ID varchar(20),
	@Order_IsSend int = -1,
	@Order_IsVoucher int = -1,
	@Order_VoucherID varchar(20) = null,
	@Order_IsOutput int = -1,
	@Order_OutputID varchar(20) = null
AS
BEGIN
	SET NOCOUNT ON;
	IF @Order_IsSend <> -1
		UPDATE [dbo].[tbl_Order]
	   SET Order_IsSend = @Order_IsSend
		WHERE [Order_ID] = @Order_ID
	IF (@Order_IsVoucher <> -1 and @Order_VoucherID is not null)
		UPDATE [dbo].[tbl_Order]
		 SET Order_IsVoucher = @Order_IsVoucher
		 ,Order_VoucherID = @Order_VoucherID
		 WHERE [Order_ID] = @Order_ID
	IF (@Order_IsOutput <> -1 and @Order_OutputID is not null)
		UPDATE [dbo].[tbl_Order]
		 SET Order_IsOutput = @Order_IsOutput
		 ,Order_OutputID = @Order_OutputID
		 WHERE [Order_ID] = @Order_ID
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Order_Update]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Order_Update]
	@Order_ID varchar(20),
	@Order_Description nvarchar(500),
	@Order_SendType int,
	@Order_SendMoney decimal(18, 4),
	@Order_Total decimal(18, 4),
	@Order_TotalVAT decimal(18, 4),
	@Order_VAT float,
	@Order_SaleMoney decimal(18, 4),
	@ModifiedBy varchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE [dbo].[tbl_Order]
	   SET Order_Description = @Order_Description
	      ,Order_SendType = @Order_SendType
		  ,Order_SendMoney = @Order_SendMoney
		  ,Order_Total = @Order_Total
		  ,Order_TotalVAT = @Order_TotalVAT
		  ,Order_VAT = @Order_VAT
		  ,Order_SaleMoney  = @Order_SaleMoney 
		  ,[ModifiedDate] = GETDATE()
		  ,[ModifiedBy] = @ModifiedBy
		WHERE [Order_ID] = @Order_ID
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Order_Select]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Order_Select]
	@Order_ID varchar(20)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT [Order_ID]
      ,[Order_Date]
      ,[Order_CustomerID]
      ,[Order_Description]
      ,[Order_IsSend]
      ,[Order_SendType]
      ,[IsDelete]
      ,[CreatedDate]
      ,[CreatedBy]
      ,[ModifiedDate]
      ,[ModifiedBy]
      ,[Order_IsVoucher]
      ,[Order_VoucherID]
      ,[Order_IsOutput]
      ,[Order_OutputID]
      ,[Order_SendMoney]
      ,[Order_Total]
      ,[Order_TotalVAT]
      ,[Order_VAT]
      ,[Order_SaleMoney]
	FROM [dbo].[tbl_Order]
	WHERE [Order_ID] = @Order_ID
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Order_Seach]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Order_Seach]
	@Keyword nvarchar(50)= null,
	@Type int = -1,
	@Fromdate smalldatetime,
	@Todate	smalldatetime,
	@Order_IsSend int = -1,
	@Order_SendType int = -1,
	@Order_IsVoucher int = -1,
	@Order_IsOutput int = -1,
	@IsDelete bit = 0
AS
BEGIN
	SET NOCOUNT ON;
	SELECT tbl_Order.[Order_ID]
      ,tbl_Order.[Order_Date]
      ,tbl_Customer.Customer_Name
      ,tbl_Customer.Customer_Phone
      ,tbl_SendType.SendType_Name
      ,tbl_Order.[Order_TotalVAT]
      ,tbl_Order.[Order_IsVoucher]
      ,tbl_Order.[Order_VoucherID]
      ,tbl_Order.[Order_IsOutput]
      ,tbl_Order.[Order_OutputID]
      ,tbl_Order.[Order_IsSend]
      ,tbl_Order.[CreatedDate]
      ,tbl_Order.[CreatedBy]
      ,tbl_Order.[ModifiedDate]
      ,tbl_Order.[ModifiedBy]
      ,tbl_Order.[Order_Description]
  FROM [tbl_Order]
  join tbl_Customer on tbl_Customer.Customer_ID = tbl_Order.Order_CustomerID
  Left join tbl_SendType on tbl_SendType.SendType_ID = tbl_Order.Order_SendType
 
	WHERE tbl_Order.IsDelete = @IsDelete 
	and tbl_Order.Order_Date >= cast(cast(@Fromdate as DATE) as DATETIME)
	and tbl_Order.Order_Date < cast(cast(@Todate as DATE) as DATETIME)+1
	and (@Order_IsSend<0 or tbl_Order.Order_IsSend = @Order_IsSend)
	and (@Order_IsVoucher<0 or tbl_Order.Order_IsVoucher = @Order_IsVoucher)
	and (@Order_IsOutput<0 or tbl_Order.Order_IsOutput = @Order_IsOutput)
	and (@Order_SendType<0 or tbl_Order.Order_SendType = @Order_SendType)
	and 
	(
		@Type = 0 and (@Keyword = '' or tbl_Order.Order_ID like '%'+@Keyword+'%')
		or @Type = 1 and (@Keyword = '' or tbl_Customer.Customer_Name like '%'+@Keyword+'%')
		or @Type = 2 and (@Keyword = '' or tbl_Customer.Customer_Phone like '%'+@Keyword+'%')
		or @Type = 3 and (@Keyword = '' or tbl_Order.Order_VoucherID like '%'+@Keyword+'%')
		or @Type = 4 and (@Keyword = '' or tbl_Order.Order_OutputID like '%'+@Keyword+'%')
	)
	order by tbl_Order.Order_Date desc
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Order_Delete]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Order_Delete]
	@Order_ID varchar(20),
	@ModifiedBy varchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE [dbo].[tbl_Order]
	   SET 
		   [IsDelete] = 1
		  ,[ModifiedDate] = GETDATE()
		  ,[ModifiedBy] = @ModifiedBy
		WHERE [Order_ID] = @Order_ID
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Order_Add]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Order_Add]
	@Order_ID varchar(20),
	@Order_Date smalldatetime,
	@Order_CustomerID varchar(20),
	@Order_Description nvarchar(500),
	@Order_SendType int,
	@CreatedBy varchar(50),
	@Order_SendMoney decimal(18, 4),
	@Order_Total decimal(18, 4),
	@Order_TotalVAT decimal(18, 4),
	@Order_VAT float,
	@Order_SaleMoney decimal(18, 4)
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO [dbo].[tbl_Order]
           (Order_ID
           ,Order_Date
           ,Order_CustomerID
           ,[Order_Description]
           ,Order_SendType
           ,Order_SendMoney
           ,Order_Total
           ,Order_TotalVAT
           ,Order_VAT
           ,Order_SaleMoney
           ,[CreatedBy])
     VALUES
           (@Order_ID
           ,@Order_Date
           ,@Order_CustomerID
           ,@Order_Description
           ,@Order_SendType
           ,@Order_SendMoney
           ,@Order_Total
           ,@Order_TotalVAT
           ,@Order_VAT
           ,@Order_SaleMoney
           ,@CreatedBy)
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Model_Update]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Model_Update]
	@Model_ID varchar(50),
	@Model_CategoryID int,
	@Model_Name nvarchar(50),
	@Model_Description nvarchar(250),
	@IsActive bit,
	@ModifiedBy varchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE [dbo].[tbl_Model]
	   SET [Model_Name] = @Model_Name
	      ,[Model_CategoryID] = @Model_CategoryID
		  ,[Model_Description] = @Model_Description
		  ,[IsActive] = @IsActive
		  ,[ModifiedDate] = GETDATE()
		  ,[ModifiedBy] = @ModifiedBy
		WHERE [Model_ID] = @Model_ID
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Model_Select]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Model_Select]
	@Model_ID varchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT [Model_ID]
	  ,[Model_CategoryID]
      ,[Model_Name]
      ,[Model_Description]
      ,[IsActive]
      ,[IsDelete]
      ,[CreatedDate]
      ,[CreatedBy]
      ,[ModifiedDate]
      ,[ModifiedBy]
	FROM [dbo].[tbl_Model]
	WHERE [Model_ID] = @Model_ID
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Model_Seach]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Model_Seach]
	@Keyword nvarchar(50)= null,
	@Model_CategoryID int = -1,
	@IsDelete bit
AS
BEGIN
	SET NOCOUNT ON;
	SELECT tbl_Model.[Model_ID]
	  ,tbl_Category.[Category_Name]
      ,tbl_Model.[Model_Name]
      ,tbl_Model.[Model_Description]
      ,tbl_Model.[IsActive]
      ,tbl_Model.[IsDelete]
      ,tbl_Model.[CreatedDate]
      ,tbl_Model.[CreatedBy]
      ,tbl_Model.[ModifiedDate]
      ,tbl_Model.[ModifiedBy]
	FROM [dbo].[tbl_Model]
	left join tbl_Category on tbl_Category.Category_ID = tbl_Model.Model_CategoryID
	WHERE tbl_Model.IsDelete = @IsDelete 
	and (@Model_CategoryID<0 or tbl_Model.[Model_CategoryID]=@Model_CategoryID)
	and (@Keyword = null or (tbl_Model.Model_ID like '%'+@Keyword+'%' or tbl_Model.Model_Name like '%'+@Keyword+'%'))
	order by tbl_Model.[Model_Name]
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Model_Delete]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Model_Delete]
	@Model_ID varchar(50),
	@ModifiedBy varchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE [dbo].[tbl_Model]
	   SET 
		   [IsDelete] = 1
		  ,[ModifiedDate] = GETDATE()
		  ,[ModifiedBy] = @ModifiedBy
		WHERE [Model_ID] = @Model_ID
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Model_Check]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Model_Check]
	@Model_ID nvarchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT [Model_ID]
	FROM [dbo].[tbl_Model]
	WHERE [Model_ID] = @Model_ID
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Model_Cache]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Model_Cache]
AS
BEGIN
	SET NOCOUNT ON;
	SELECT [Model_ID]
      ,[Model_Name]
      ,[Model_CategoryID]
	FROM [dbo].[tbl_Model]
	WHERE [IsActive] = 1 and [IsDelete] = 0
	order by [Model_Name]
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Model_Add]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Model_Add]
	@Model_ID varchar(50),
	@Model_CategoryID int,
	@Model_Name nvarchar(50),
	@Model_Description nvarchar(250),
	@IsActive bit,
	@CreatedBy varchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	
	INSERT INTO [dbo].[tbl_Model]
           ([Model_ID]
           ,[Model_CategoryID]
           ,[Model_Name]
           ,[Model_Description]
           ,[IsActive]
           ,[CreatedBy])
     VALUES
           (@Model_ID
           ,@Model_CategoryID
           ,@Model_Name
           ,@Model_Description
           ,@IsActive
           ,@CreatedBy)
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_InputDetail_Update]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_InputDetail_Update]
	@InputDetail_ProductID varchar(50),
	@InputDetail_InputID varchar(20),
	@InputDetail_Price decimal(18, 4),
	@InputDetail_Quantity int
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE [dbo].[tbl_InputDetail]
	   SET [InputDetail_Price] = @InputDetail_Price
	      ,[InputDetail_Quantity] = @InputDetail_Quantity
		WHERE [InputDetail_ProductID] = @InputDetail_ProductID
		and [InputDetail_InputID] = @InputDetail_InputID
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_InputDetail_SelectLIST]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_InputDetail_SelectLIST]
	@InputDetail_InputID varchar(20)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT tbl_InputDetail.[InputDetail_ProductID]
      ,tbl_InputDetail.[InputDetail_InputID]
      ,tbl_InputDetail.[InputDetail_Price]
      ,tbl_InputDetail.[InputDetail_Quantity]
      ,tbl_Product.Product_Name
      ,tbl_Color.Color_Name
	FROM [dbo].[tbl_InputDetail]
	join tbl_Product on tbl_Product.Product_ID = tbl_InputDetail.InputDetail_ProductID
	join tbl_Color on tbl_Color.Color_Id = tbl_Product.Product_ColorID
	WHERE tbl_InputDetail.InputDetail_InputID = @InputDetail_InputID
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_InputDetail_Select]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_InputDetail_Select]
	@InputDetail_ProductID varchar(50),
	@InputDetail_InputID varchar(20)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT tbl_InputDetail.[InputDetail_ProductID]
      ,tbl_InputDetail.[InputDetail_InputID]
      ,tbl_InputDetail.[InputDetail_Price]
      ,tbl_InputDetail.[InputDetail_Quantity]
      ,tbl_Product.Product_Name
      ,tbl_Color.Color_Name
	FROM [dbo].[tbl_InputDetail]
	join tbl_Product on tbl_Product.Product_ID = tbl_InputDetail.InputDetail_ProductID
	join tbl_Color on tbl_Color.Color_Id = tbl_Product.Product_ColorID
	WHERE tbl_InputDetail.InputDetail_ProductID = @InputDetail_ProductID  
		and tbl_InputDetail.InputDetail_InputID = @InputDetail_InputID
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_InputDetail_Delete]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_InputDetail_Delete]
	@InputDetail_ProductID varchar(50),
	@InputDetail_InputID varchar(20)
AS
BEGIN
	SET NOCOUNT ON;
	Delete [dbo].[tbl_InputDetail]
		WHERE [InputDetail_ProductID] = @InputDetail_ProductID
		and [InputDetail_InputID] = @InputDetail_InputID
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_InputDetail_Add]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_InputDetail_Add]
	@InputDetail_ProductID varchar(50),
	@InputDetail_InputID varchar(20),
	@InputDetail_Price decimal(18, 4),
	@InputDetail_Quantity int
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO [dbo].[tbl_InputDetail]
           ([InputDetail_ProductID]
           ,[InputDetail_InputID]
           ,[InputDetail_Price]
           ,[InputDetail_Quantity])
     VALUES
           (@InputDetail_ProductID
           ,@InputDetail_InputID
           ,@InputDetail_Price
           ,@InputDetail_Quantity)
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Input_Update_Status]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Input_Update_Status]
	@Input_ID varchar(20),
	@Input_IsVoucher int = -1,
	@Input_VoucherID varchar(20) = null
AS
BEGIN
	SET NOCOUNT ON;
	IF (@Input_IsVoucher <> -1 and @Input_VoucherID is not null)
		UPDATE [dbo].[tbl_Input]
		 SET Input_IsVoucher = @Input_IsVoucher
		 ,Input_VoucherID = @Input_VoucherID
		 WHERE [Input_ID] = @Input_ID
	
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Input_Update]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Input_Update]
	@Input_ID varchar(20),
	@Input_Description nvarchar(500),
	@Input_Total decimal(18, 4),
	@Input_TotalVAT decimal(18, 4),
	@Input_VAT float,
	@Input_SaleMoney decimal(18, 4),
	@ModifiedBy varchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE [dbo].[tbl_Input]
	   SET Input_Description = @Input_Description
		  ,Input_Total = @Input_Total
		  ,Input_TotalVAT = @Input_TotalVAT
		  ,Input_VAT = @Input_VAT
		  ,Input_SaleMoney  = @Input_SaleMoney 
		  ,[ModifiedDate] = GETDATE()
		  ,[ModifiedBy] = @ModifiedBy
		WHERE [Input_ID] = @Input_ID
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Input_Select]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Input_Select]
	@Input_ID varchar(20)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT [Input_ID]
      ,[Input_Date]
      ,[Input_SupplierID]
      ,[Input_Description]
      ,[IsDelete]
      ,[CreatedDate]
      ,[CreatedBy]
      ,[ModifiedDate]
      ,[ModifiedBy]
      ,[Input_IsVoucher]
      ,[Input_VoucherID]
      ,[Input_Total]
      ,[Input_TotalVAT]
      ,[Input_VAT]
      ,[Input_SaleMoney]
	FROM [dbo].[tbl_Input]
	WHERE [Input_ID] = @Input_ID
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Input_Seach]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Input_Seach]
	@Keyword nvarchar(50)= null,
	@Type int = -1,
	@Fromdate smalldatetime,
	@Todate	smalldatetime,
	@Input_IsVoucher int = -1,
	@IsDelete bit = 0
AS
BEGIN
	SET NOCOUNT ON;
	SELECT tbl_Input.[Input_ID]
      ,tbl_Input.[Input_Date]
      ,tbl_Supplier.Supplier_Name
      ,tbl_Supplier.Supplier_Phone
      ,tbl_Input.[Input_TotalVAT]
      ,tbl_Input.[Input_IsVoucher]
      ,tbl_Input.[Input_VoucherID]
      ,tbl_Input.[CreatedDate]
      ,tbl_Input.[CreatedBy]
      ,tbl_Input.[ModifiedDate]
      ,tbl_Input.[ModifiedBy]
      ,tbl_Input.[Input_Description]
  FROM [tbl_Input]
  join tbl_Supplier on tbl_Supplier.Supplier_ID = tbl_Input.Input_SupplierID
	WHERE tbl_Input.IsDelete = @IsDelete 
	and tbl_Input.Input_Date >= cast(cast(@Fromdate as DATE) as DATETIME)
	and tbl_Input.Input_Date < cast(cast(@Todate as DATE) as DATETIME)+1
	and (@Input_IsVoucher<0 or tbl_Input.Input_IsVoucher = @Input_IsVoucher)
	and 
	(
		@Type = 0 and (@Keyword = '' or tbl_Input.Input_ID like '%'+@Keyword+'%')
		or @Type = 1 and (@Keyword = '' or tbl_Supplier.Supplier_Name like '%'+@Keyword+'%')
		or @Type = 2 and (@Keyword = '' or tbl_Supplier.Supplier_Phone like '%'+@Keyword+'%')
		or @Type = 3 and (@Keyword = '' or tbl_Input.Input_VoucherID like '%'+@Keyword+'%')
	)
	order by tbl_Input.Input_Date desc
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Input_Delete]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Input_Delete]
	@Input_ID varchar(20),
	@ModifiedBy varchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE [dbo].[tbl_Input]
	   SET 
		   [IsDelete] = 1
		  ,[ModifiedDate] = GETDATE()
		  ,[ModifiedBy] = @ModifiedBy
		WHERE [Input_ID] = @Input_ID
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Input_Add]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Input_Add]
	@Input_ID varchar(20),
	@Input_Date smalldatetime,
	@Input_SupplierID varchar(20),
	@Input_Description nvarchar(500),
	@CreatedBy varchar(50),
	@Input_Total decimal(18, 4),
	@Input_TotalVAT decimal(18, 4),
	@Input_VAT float,
	@Input_SaleMoney decimal(18, 4)
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO [dbo].[tbl_Input]
           (Input_ID
           ,Input_Date
           ,Input_SupplierID
           ,[Input_Description]
           ,Input_Total
           ,Input_TotalVAT
           ,Input_VAT
           ,Input_SaleMoney
           ,[CreatedBy])
     VALUES
           (@Input_ID
           ,@Input_Date
           ,@Input_SupplierID
           ,@Input_Description
           ,@Input_Total
           ,@Input_TotalVAT
           ,@Input_VAT
           ,@Input_SaleMoney
           ,@CreatedBy)
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_GetAutoId]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[pr_GetAutoId]
	@TableName nvarchar(50)
AS
	SELECT PrefixOfDefaultValueForId,
	LengthOfDefaultValueForId,
	LastValueOfColumnId
	FROM tbl_AutomaticValues 
	WHERE ObjectName = @TableName
GO
/****** Object:  StoredProcedure [dbo].[pr_Customer_Update]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Customer_Update]
	@Customer_ID varchar(20),
	@Customer_Name nvarchar(50),
	@Customer_Phone varchar(20),
	@Customer_Address nvarchar(500),
	@Customer_Email nvarchar(250),
	@Customer_Facbook nvarchar(250),
	@Customer_Zalo nvarchar(250),
	@Customer_Description nvarchar(250),
	@IsActive bit,
	@ModifiedBy varchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE [dbo].[tbl_Customer]
	   SET [Customer_Name] = @Customer_Name
		  ,Customer_Phone = @Customer_Phone
		  ,Customer_Address = @Customer_Address
		  ,Customer_Email = @Customer_Email
		  ,Customer_Facbook = @Customer_Facbook
		  ,Customer_Zalo = @Customer_Zalo
		  ,[Customer_Description] = @Customer_Description
		  ,[IsActive] = @IsActive
		  ,[ModifiedDate] = GETDATE()
		  ,[ModifiedBy] = @ModifiedBy
		WHERE [Customer_ID] = @Customer_ID
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Customer_SelectByPhone]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Customer_SelectByPhone]
	@Customer_Phone varchar(20)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT [Customer_ID]
      ,[Customer_Name]
       ,Customer_Phone
       ,Customer_Address
       ,Customer_Email
       ,Customer_Facbook
       ,Customer_Zalo
       ,[Customer_Description]
      ,[IsActive]
      ,[IsDelete]
      ,[CreatedDate]
      ,[CreatedBy]
      ,[ModifiedDate]
      ,[ModifiedBy]
	FROM [dbo].[tbl_Customer]
	WHERE Customer_Phone = @Customer_Phone
	and IsDelete = 0 and IsActive = 1
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Customer_Select]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Customer_Select]
	@Customer_ID varchar(20)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT [Customer_ID]
      ,[Customer_Name]
       ,Customer_Phone
       ,Customer_Address
       ,Customer_Email
       ,Customer_Facbook
       ,Customer_Zalo
       ,[Customer_Description]
      ,[IsActive]
      ,[IsDelete]
      ,[CreatedDate]
      ,[CreatedBy]
      ,[ModifiedDate]
      ,[ModifiedBy]
	FROM [dbo].[tbl_Customer]
	WHERE [Customer_ID] = @Customer_ID
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Customer_Seach_Use]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Customer_Seach_Use]
	@Keyword nvarchar(50)= null,
	@Type int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT RTRIM(Customer_ID) Customer_ID
      ,[Customer_Name]
       ,Customer_Phone
       ,Customer_Address
       ,Customer_Email
       ,Customer_Facbook
       ,Customer_Zalo
       ,[Customer_Description]
      ,[IsActive]
      ,[IsDelete]
      ,[CreatedDate]
      ,[CreatedBy]
      ,[ModifiedDate]
      ,[ModifiedBy]
	FROM [dbo].[tbl_Customer]
	WHERE IsDelete = 0 and IsActive = 1 
	and 
		(
			@Type = 0 and (@Keyword = '' or Customer_ID like '%'+@Keyword+'%')
			or @Type = 1 and (@Keyword = '' or Customer_Name like '%'+@Keyword+'%')
			or @Type = 2 and (@Keyword = '' or Customer_Phone like '%'+@Keyword+'%')
			or @Type = 3 and (@Keyword = '' or Customer_Facbook like '%'+@Keyword+'%')
			or @Type = 4 and (@Keyword = '' or Customer_Zalo like '%'+@Keyword+'%')
			or @Type = -1 and (@Keyword = '' or Customer_ID like '%'+@Keyword+'%' 
								or Customer_Name like '%'+@Keyword+'%' or Customer_Phone like '%'+@Keyword+'%'
								or Customer_Facbook like '%'+@Keyword+'%' or Customer_Zalo like '%'+@Keyword+'%')
		)
	order by [Customer_Name]
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Customer_Seach]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Customer_Seach]
	@Keyword nvarchar(50)= null,
	@IsDelete bit
AS
BEGIN
	SET NOCOUNT ON;
	SELECT RTRIM(Customer_ID) Customer_ID
      ,[Customer_Name]
       ,Customer_Phone
       ,Customer_Address
       ,Customer_Email
       ,Customer_Facbook
       ,Customer_Zalo
       ,[Customer_Description]
      ,[IsActive]
      ,[IsDelete]
      ,[CreatedDate]
      ,[CreatedBy]
      ,[ModifiedDate]
      ,[ModifiedBy]
	FROM [dbo].[tbl_Customer]
	WHERE IsDelete = @IsDelete 
	and (@Keyword = null 
		or (Customer_ID like '%'+@Keyword+'%' 
		or Customer_Name like '%'+@Keyword+'%' or Customer_Phone like '%'+@Keyword+'%' or Customer_Address like '%'+@Keyword+'%' 
		or Customer_Email like '%'+@Keyword+'%'
		or Customer_Facbook like '%'+@Keyword+'%'
		or Customer_Zalo like '%'+@Keyword+'%'
		)
	)
	order by [Customer_Name]
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Customer_Delete]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Customer_Delete]
	@Customer_ID varchar(20),
	@ModifiedBy varchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE [dbo].[tbl_Customer]
	   SET 
		   [IsDelete] = 1
		  ,[ModifiedDate] = GETDATE()
		  ,[ModifiedBy] = @ModifiedBy
		WHERE [Customer_ID] = @Customer_ID
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Customer_Check]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Customer_Check]
	@Customer_ID varchar(20) = null,
	@Customer_Phone varchar(20) = null

AS
BEGIN
	SET NOCOUNT ON;
	SELECT [Customer_ID]
	FROM [dbo].[tbl_Customer]
	WHERE  Customer_Phone = @Customer_Phone
	and IsDelete = 0
	and (@Customer_ID is null or Customer_ID <> @Customer_ID)
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Customer_Add]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Customer_Add]
	@Customer_ID varchar(20),
	@Customer_Name nvarchar(50),
	@Customer_Phone varchar(20),
	@Customer_Address nvarchar(500),
	@Customer_Email nvarchar(250),
	@Customer_Facbook nvarchar(250),
	@Customer_Zalo nvarchar(250),
	@Customer_Description nvarchar(250),
	@IsActive bit,
	@CreatedBy varchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO [dbo].[tbl_Customer]
           (Customer_ID
           ,[Customer_Name]
           ,Customer_Phone
           ,Customer_Address
           ,Customer_Email
           ,Customer_Facbook
           ,Customer_Zalo
           ,[Customer_Description]
           ,[IsActive]
           ,[CreatedBy])
     VALUES
           (
				@Customer_ID
			   ,@Customer_Name
			   ,@Customer_Phone
			   ,@Customer_Address
			   ,@Customer_Email
			   ,@Customer_Facbook
			   ,@Customer_Zalo
			   ,@Customer_Description
			   ,@IsActive
			   ,@CreatedBy
           )
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Config_Update]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Config_Update]
	@Config_ID nvarchar(50),
	@Config_Value nvarchar(250),
	@Config_Name nvarchar(50),
	@Config_Description nvarchar(250),
	@IsActive bit,
	@ModifiedBy varchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE [dbo].[tbl_Config]
	   SET [Config_Name] = @Config_Name
		  ,[Config_Value] = @Config_Value
		  ,[Config_Description] = @Config_Description
		  ,[IsActive] = @IsActive
		  ,[ModifiedDate] = GETDATE()
		  ,[ModifiedBy] = @ModifiedBy
		WHERE [Config_ID] = @Config_ID
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Config_Select]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Config_Select]
	@Config_ID nvarchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT [Config_ID]
	  ,[Config_Value]
      ,[Config_Name]
      ,[Config_Description]
      ,[IsActive]
      ,[IsDelete]
      ,[CreatedDate]
      ,[CreatedBy]
      ,[ModifiedDate]
      ,[ModifiedBy]
	FROM [dbo].[tbl_Config]
	WHERE [Config_ID] = @Config_ID
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Config_Seach]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Config_Seach]
	@Keyword nvarchar(50)= null,
	@IsDelete bit
AS
BEGIN
	SET NOCOUNT ON;
	SELECT [Config_Id]
	  ,[Config_Value]
      ,[Config_Name]
      ,[Config_Description]
      ,[IsActive]
      ,[IsDelete]
      ,[CreatedDate]
      ,[CreatedBy]
      ,[ModifiedDate]
      ,[ModifiedBy]
	FROM [dbo].[tbl_Config]
	WHERE IsDelete = @IsDelete 
	and (@Keyword = null or (Config_Id like '%'+@Keyword+'%' or Config_Name like '%'+@Keyword+'%' or Config_Value like '%'+@Keyword+'%'))
	order by [Config_Name]
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Config_Delete]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Config_Delete]
	@Config_Id nvarchar(50),
	@ModifiedBy varchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE [dbo].[tbl_Config]
	   SET 
		   [IsDelete] = 1
		  ,[ModifiedDate] = GETDATE()
		  ,[ModifiedBy] = @ModifiedBy
		WHERE [Config_Id] = @Config_Id
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Config_Check]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Config_Check]
	@Config_ID nvarchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT [Config_ID]
	FROM [dbo].[tbl_Config]
	WHERE [Config_ID] = @Config_ID
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Config_Cache]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Config_Cache]
AS
BEGIN
	SET NOCOUNT ON;
	SELECT [Config_ID]
	  ,[Config_Value]
      ,[Config_Name]
	FROM [dbo].[tbl_Config]
	WHERE [IsActive] = 1 and [IsDelete] = 0
	order by [Config_Name]
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Config_Add]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Config_Add]
	@Config_Id nvarchar(50),
	@Config_Value nvarchar(250),
	@Config_Name nvarchar(50),
	@Config_Description nvarchar(250),
	@IsActive bit,
	@CreatedBy varchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO [dbo].[tbl_Config]
           ([Config_Id]
           ,[Config_Value]
           ,[Config_Name]
           ,[Config_Description]
           ,[IsActive]
           ,[CreatedBy])
     VALUES
           (@Config_Id
           ,@Config_Value
           ,@Config_Name
           ,@Config_Description
           ,@IsActive
           ,@CreatedBy)
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Color_Update_Index]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Color_Update_Index]
	@Color_ID int,
	@Orderindex int
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE [dbo].[tbl_Color]
	   SET Orderindex = @Orderindex
		WHERE [Color_ID] = @Color_ID
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Color_Update]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Color_Update]
	@Color_ID int,
	@Color_Name nvarchar(50),
	@Color_Description nvarchar(250),
	@IsActive bit,
	@ModifiedBy varchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE [dbo].[tbl_Color]
	   SET [Color_Name] = @Color_Name
		  ,[Color_Description] = @Color_Description
		  ,[IsActive] = @IsActive
		  ,[ModifiedDate] = GETDATE()
		  ,[ModifiedBy] = @ModifiedBy
		WHERE [Color_ID] = @Color_ID
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Color_Select]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Color_Select]
	@Color_ID int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT [Color_ID]
      ,[Color_Name]
      ,[Color_Description]
      ,[IsActive]
      ,[IsDelete]
      ,[CreatedDate]
      ,[CreatedBy]
      ,[ModifiedDate]
      ,[ModifiedBy]
	FROM [dbo].[tbl_Color]
	WHERE [Color_ID] = @Color_ID
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Color_Seach]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Color_Seach]
	@Keyword nvarchar(50)= null,
	@IsDelete bit
AS
BEGIN
	SET NOCOUNT ON;
	SELECT [Color_ID]
      ,[Color_Name]
      ,[Color_Description]
      ,[IsActive]
      ,[IsDelete]
      ,[CreatedDate]
      ,[CreatedBy]
      ,[ModifiedDate]
      ,[ModifiedBy]
	FROM [dbo].[tbl_Color]
	WHERE IsDelete = @IsDelete 
	and (@Keyword is null or (Color_ID like '%'+@Keyword+'%' or Color_Name like '%'+@Keyword+'%'))
	order by Orderindex 
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Color_Delete]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Color_Delete]
	@Color_ID int,
	@ModifiedBy varchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE [dbo].[tbl_Color]
	   SET 
		   [IsDelete] = 1
		  ,[ModifiedDate] = GETDATE()
		  ,[ModifiedBy] = @ModifiedBy
		WHERE [Color_ID] = @Color_ID
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Color_Cache]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Color_Cache]
AS
BEGIN
	SET NOCOUNT ON;
	SELECT [Color_ID]
      ,[Color_Name]
	FROM [dbo].[tbl_Color]
	WHERE [IsActive] = 1 and [IsDelete] = 0
	order by Orderindex 
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Color_Add]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Color_Add]
	@Color_Name nvarchar(50),
	@Color_Description nvarchar(250),
	@IsActive bit,
	@CreatedBy varchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	--Lấy số thự tự lớn nhất
	BEGIN
		DECLARE @IndexMax INT = 0
		SELECT @IndexMax = COUNT(*) FROM tbl_Color WHERE IsDelete = 0
	END
	
	INSERT INTO [dbo].[tbl_Color]
           ([Color_Name]
           ,[Color_Description]
           ,[Orderindex]
           ,[IsActive]
           ,[CreatedBy])
     VALUES
           (@Color_Name
           ,@Color_Description
           ,@IndexMax
           ,@IsActive
           ,@CreatedBy)
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Category_Update_Index]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Category_Update_Index]
	@Category_ID int,
	@Orderindex int
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE [dbo].[tbl_Category]
	   SET Orderindex = @Orderindex
		WHERE [Category_ID] = @Category_ID
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Category_Update]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Category_Update]
	@Category_ID int,
	@Category_Name nvarchar(50),
	@Category_Description nvarchar(250),
	@IsActive bit,
	@ModifiedBy varchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE [dbo].[tbl_Category]
	   SET [Category_Name] = @Category_Name
		  ,[Category_Description] = @Category_Description
		  ,[IsActive] = @IsActive
		  ,[ModifiedDate] = GETDATE()
		  ,[ModifiedBy] = @ModifiedBy
		WHERE [Category_ID] = @Category_ID
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Category_Select]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Category_Select]
	@Category_ID int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT [Category_ID]
      ,[Category_Name]
      ,[Category_Description]
      ,[IsActive]
      ,[IsDelete]
      ,[CreatedDate]
      ,[CreatedBy]
      ,[ModifiedDate]
      ,[ModifiedBy]
	FROM [dbo].[tbl_Category]
	WHERE [Category_ID] = @Category_ID
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Category_Seach]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Category_Seach]
	@Keyword nvarchar(50)= null,
	@IsDelete int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT [Category_ID]
      ,[Category_Name]
      ,[Category_Description]
      ,[IsActive]
      ,[IsDelete]
      ,[CreatedDate]
      ,[CreatedBy]
      ,[ModifiedDate]
      ,[ModifiedBy]
	FROM [dbo].[tbl_Category]
	WHERE IsDelete = @IsDelete 
	and (@Keyword is null or (Category_ID like '%'+@Keyword+'%' or Category_Name like '%'+@Keyword+'%'))
	order by OrderIndex
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Category_Delete]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Category_Delete]
	@Category_ID int,
	@ModifiedBy varchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE [dbo].[tbl_Category]
	   SET 
		   [IsDelete] = 1
		  ,[ModifiedDate] = GETDATE()
		  ,[ModifiedBy] = @ModifiedBy
		WHERE [Category_ID] = @Category_ID
   
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Category_Cache]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Category_Cache]
AS
BEGIN
	SET NOCOUNT ON;
	SELECT [Category_ID]
      ,[Category_Name]
	FROM [dbo].[tbl_Category]
	WHERE [IsActive] = 1 and [IsDelete] = 0
	order by OrderIndex
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Category_Add]    Script Date: 09/08/2016 23:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Category_Add]
	@Category_Name nvarchar(50),
	@Category_Description nvarchar(250),
	@IsActive bit,
	@CreatedBy varchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	--Lấy số thự tự lớn nhất
	BEGIN
		DECLARE @IndexMax INT = 0
		SELECT @IndexMax = COUNT(*) FROM tbl_Category WHERE IsDelete = 0
	END
	
	INSERT INTO [dbo].[tbl_Category]
           ([Category_Name]
           ,[Category_Description]
           ,[Orderindex]
           ,[IsActive]
           ,[CreatedBy])
     VALUES
           (@Category_Name
           ,@Category_Description
           ,@IndexMax
           ,@IsActive
           ,@CreatedBy)
   
END
GO
/****** Object:  Default [DF_tbl_User_IsActive]    Script Date: 09/08/2016 23:26:46 ******/
ALTER TABLE [dbo].[tbl_User] ADD  CONSTRAINT [DF_tbl_User_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
/****** Object:  Default [DF_tbl_User_IsDelete]    Script Date: 09/08/2016 23:26:46 ******/
ALTER TABLE [dbo].[tbl_User] ADD  CONSTRAINT [DF_tbl_User_IsDelete]  DEFAULT ((0)) FOR [IsDelete]
GO
/****** Object:  Default [DF_tbl_User_CreatedDate]    Script Date: 09/08/2016 23:26:46 ******/
ALTER TABLE [dbo].[tbl_User] ADD  CONSTRAINT [DF_tbl_User_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
/****** Object:  Default [DF_tbl_Supplier_IsActive]    Script Date: 09/08/2016 23:26:46 ******/
ALTER TABLE [dbo].[tbl_Supplier] ADD  CONSTRAINT [DF_tbl_Supplier_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
/****** Object:  Default [DF_tbl_Supplier_IsDelete]    Script Date: 09/08/2016 23:26:46 ******/
ALTER TABLE [dbo].[tbl_Supplier] ADD  CONSTRAINT [DF_tbl_Supplier_IsDelete]  DEFAULT ((0)) FOR [IsDelete]
GO
/****** Object:  Default [DF_tbl_Supplier_CreatedDate]    Script Date: 09/08/2016 23:26:46 ******/
ALTER TABLE [dbo].[tbl_Supplier] ADD  CONSTRAINT [DF_tbl_Supplier_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
/****** Object:  Default [DF_tbl_SendType_IsActive]    Script Date: 09/08/2016 23:26:46 ******/
ALTER TABLE [dbo].[tbl_SendType] ADD  CONSTRAINT [DF_tbl_SendType_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
/****** Object:  Default [DF_tbl_SendType_IsDelete]    Script Date: 09/08/2016 23:26:46 ******/
ALTER TABLE [dbo].[tbl_SendType] ADD  CONSTRAINT [DF_tbl_SendType_IsDelete]  DEFAULT ((0)) FOR [IsDelete]
GO
/****** Object:  Default [DF_tbl_SendType_CreatedDate]    Script Date: 09/08/2016 23:26:46 ******/
ALTER TABLE [dbo].[tbl_SendType] ADD  CONSTRAINT [DF_tbl_SendType_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
/****** Object:  Default [DF_tbl_SendType_Orderindex]    Script Date: 09/08/2016 23:26:46 ******/
ALTER TABLE [dbo].[tbl_SendType] ADD  CONSTRAINT [DF_tbl_SendType_Orderindex]  DEFAULT ((0)) FOR [Orderindex]
GO
/****** Object:  Default [DF_tbl_ProductQuantity_Quantity]    Script Date: 09/08/2016 23:26:46 ******/
ALTER TABLE [dbo].[tbl_ProductQuantity] ADD  CONSTRAINT [DF_tbl_ProductQuantity_Quantity]  DEFAULT ((0)) FOR [Quantity]
GO
/****** Object:  Default [DF_tbl_ProductQuantity_QuantitySale]    Script Date: 09/08/2016 23:26:46 ******/
ALTER TABLE [dbo].[tbl_ProductQuantity] ADD  CONSTRAINT [DF_tbl_ProductQuantity_QuantitySale]  DEFAULT ((0)) FOR [QuantitySale]
GO
/****** Object:  Default [DF_tbl_Product_Product_ColorID]    Script Date: 09/08/2016 23:26:46 ******/
ALTER TABLE [dbo].[tbl_Product] ADD  CONSTRAINT [DF_tbl_Product_Product_ColorID]  DEFAULT ((-1)) FOR [Product_ColorID]
GO
/****** Object:  Default [DF_tbl_Product_Product_ModelID]    Script Date: 09/08/2016 23:26:46 ******/
ALTER TABLE [dbo].[tbl_Product] ADD  CONSTRAINT [DF_tbl_Product_Product_ModelID]  DEFAULT ((-1)) FOR [Product_ModelID]
GO
/****** Object:  Default [DF_tbl_Product_IsActive]    Script Date: 09/08/2016 23:26:46 ******/
ALTER TABLE [dbo].[tbl_Product] ADD  CONSTRAINT [DF_tbl_Product_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
/****** Object:  Default [DF_tbl_Product_IsDelete]    Script Date: 09/08/2016 23:26:46 ******/
ALTER TABLE [dbo].[tbl_Product] ADD  CONSTRAINT [DF_tbl_Product_IsDelete]  DEFAULT ((0)) FOR [IsDelete]
GO
/****** Object:  Default [DF_tbl_Product_CreatedDate]    Script Date: 09/08/2016 23:26:46 ******/
ALTER TABLE [dbo].[tbl_Product] ADD  CONSTRAINT [DF_tbl_Product_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
/****** Object:  Default [DF_tbl_PriceType_IsActive]    Script Date: 09/08/2016 23:26:46 ******/
ALTER TABLE [dbo].[tbl_PriceType] ADD  CONSTRAINT [DF_tbl_PriceType_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
/****** Object:  Default [DF_tbl_PriceType_IsDelete]    Script Date: 09/08/2016 23:26:46 ******/
ALTER TABLE [dbo].[tbl_PriceType] ADD  CONSTRAINT [DF_tbl_PriceType_IsDelete]  DEFAULT ((0)) FOR [IsDelete]
GO
/****** Object:  Default [DF_tbl_PriceType_CreatedDate]    Script Date: 09/08/2016 23:26:46 ******/
ALTER TABLE [dbo].[tbl_PriceType] ADD  CONSTRAINT [DF_tbl_PriceType_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
/****** Object:  Default [DF_tbl_PriceType_Orderindex]    Script Date: 09/08/2016 23:26:46 ******/
ALTER TABLE [dbo].[tbl_PriceType] ADD  CONSTRAINT [DF_tbl_PriceType_Orderindex]  DEFAULT ((0)) FOR [Orderindex]
GO
/****** Object:  Default [DF_tbl_PriceType_Isdefault]    Script Date: 09/08/2016 23:26:46 ******/
ALTER TABLE [dbo].[tbl_PriceType] ADD  CONSTRAINT [DF_tbl_PriceType_Isdefault]  DEFAULT ((0)) FOR [Isdefault]
GO
/****** Object:  Default [DF_tbl_Price_Price_Now]    Script Date: 09/08/2016 23:26:46 ******/
ALTER TABLE [dbo].[tbl_Price] ADD  CONSTRAINT [DF_tbl_Price_Price_Now]  DEFAULT ((0)) FOR [Price_Now]
GO
/****** Object:  Default [DF_tbl_Price_Price_Old]    Script Date: 09/08/2016 23:26:46 ******/
ALTER TABLE [dbo].[tbl_Price] ADD  CONSTRAINT [DF_tbl_Price_Price_Old]  DEFAULT ((0)) FOR [Price_Old]
GO
/****** Object:  Default [DF_tbl_Payments_Payments_Date]    Script Date: 09/08/2016 23:26:46 ******/
ALTER TABLE [dbo].[tbl_Payments] ADD  CONSTRAINT [DF_tbl_Payments_Payments_Date]  DEFAULT (getdate()) FOR [Payments_Date]
GO
/****** Object:  Default [DF_tbl_Payments_Payments_Type]    Script Date: 09/08/2016 23:26:46 ******/
ALTER TABLE [dbo].[tbl_Payments] ADD  CONSTRAINT [DF_tbl_Payments_Payments_Type]  DEFAULT ((0)) FOR [Payments_Type]
GO
/****** Object:  Default [DF_tbl_Payments_IsDelete]    Script Date: 09/08/2016 23:26:46 ******/
ALTER TABLE [dbo].[tbl_Payments] ADD  CONSTRAINT [DF_tbl_Payments_IsDelete]  DEFAULT ((0)) FOR [IsDelete]
GO
/****** Object:  Default [DF_tbl_Payments_CreatedDate]    Script Date: 09/08/2016 23:26:46 ******/
ALTER TABLE [dbo].[tbl_Payments] ADD  CONSTRAINT [DF_tbl_Payments_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
/****** Object:  Default [DF_tbl_OutputDetail_OutputDetail_Price]    Script Date: 09/08/2016 23:26:46 ******/
ALTER TABLE [dbo].[tbl_OutputDetail] ADD  CONSTRAINT [DF_tbl_OutputDetail_OutputDetail_Price]  DEFAULT ((0)) FOR [OutputDetail_Price]
GO
/****** Object:  Default [DF_tbl_OutputDetail_OutputDetail_Quantity]    Script Date: 09/08/2016 23:26:46 ******/
ALTER TABLE [dbo].[tbl_OutputDetail] ADD  CONSTRAINT [DF_tbl_OutputDetail_OutputDetail_Quantity]  DEFAULT ((0)) FOR [OutputDetail_Quantity]
GO
/****** Object:  Default [DF_tbl_Output_Output_Date]    Script Date: 09/08/2016 23:26:46 ******/
ALTER TABLE [dbo].[tbl_Output] ADD  CONSTRAINT [DF_tbl_Output_Output_Date]  DEFAULT (getdate()) FOR [Output_Date]
GO
/****** Object:  Default [DF_tbl_Output_IsDelete]    Script Date: 09/08/2016 23:26:46 ******/
ALTER TABLE [dbo].[tbl_Output] ADD  CONSTRAINT [DF_tbl_Output_IsDelete]  DEFAULT ((0)) FOR [IsDelete]
GO
/****** Object:  Default [DF_tbl_Output_CreatedDate]    Script Date: 09/08/2016 23:26:46 ******/
ALTER TABLE [dbo].[tbl_Output] ADD  CONSTRAINT [DF_tbl_Output_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
/****** Object:  Default [DF_tbl_OrderDetail_OrderDetail_Price]    Script Date: 09/08/2016 23:26:46 ******/
ALTER TABLE [dbo].[tbl_OrderDetail] ADD  CONSTRAINT [DF_tbl_OrderDetail_OrderDetail_Price]  DEFAULT ((0)) FOR [OrderDetail_Price]
GO
/****** Object:  Default [DF_tbl_OrderDetail_OrderDetail_Sale]    Script Date: 09/08/2016 23:26:46 ******/
ALTER TABLE [dbo].[tbl_OrderDetail] ADD  CONSTRAINT [DF_tbl_OrderDetail_OrderDetail_Sale]  DEFAULT ((0)) FOR [OrderDetail_Sale]
GO
/****** Object:  Default [DF_tbl_OrderDetail_OrderDetail_PriceType]    Script Date: 09/08/2016 23:26:46 ******/
ALTER TABLE [dbo].[tbl_OrderDetail] ADD  CONSTRAINT [DF_tbl_OrderDetail_OrderDetail_PriceType]  DEFAULT ((0)) FOR [OrderDetail_PriceType]
GO
/****** Object:  Default [DF_tbl_Order_Order_Date]    Script Date: 09/08/2016 23:26:46 ******/
ALTER TABLE [dbo].[tbl_Order] ADD  CONSTRAINT [DF_tbl_Order_Order_Date]  DEFAULT (getdate()) FOR [Order_Date]
GO
/****** Object:  Default [DF_tbl_Order_IsSend]    Script Date: 09/08/2016 23:26:46 ******/
ALTER TABLE [dbo].[tbl_Order] ADD  CONSTRAINT [DF_tbl_Order_IsSend]  DEFAULT ((0)) FOR [Order_IsSend]
GO
/****** Object:  Default [DF_tbl_Order_Order_SendType]    Script Date: 09/08/2016 23:26:46 ******/
ALTER TABLE [dbo].[tbl_Order] ADD  CONSTRAINT [DF_tbl_Order_Order_SendType]  DEFAULT ((-1)) FOR [Order_SendType]
GO
/****** Object:  Default [DF_tbl_Order_IsDelete]    Script Date: 09/08/2016 23:26:46 ******/
ALTER TABLE [dbo].[tbl_Order] ADD  CONSTRAINT [DF_tbl_Order_IsDelete]  DEFAULT ((0)) FOR [IsDelete]
GO
/****** Object:  Default [DF_tbl_Order_CreatedDate]    Script Date: 09/08/2016 23:26:46 ******/
ALTER TABLE [dbo].[tbl_Order] ADD  CONSTRAINT [DF_tbl_Order_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
/****** Object:  Default [DF_tbl_Order_IsVoucher]    Script Date: 09/08/2016 23:26:46 ******/
ALTER TABLE [dbo].[tbl_Order] ADD  CONSTRAINT [DF_tbl_Order_IsVoucher]  DEFAULT ((0)) FOR [Order_IsVoucher]
GO
/****** Object:  Default [DF_tbl_Order_IsOutput]    Script Date: 09/08/2016 23:26:46 ******/
ALTER TABLE [dbo].[tbl_Order] ADD  CONSTRAINT [DF_tbl_Order_IsOutput]  DEFAULT ((0)) FOR [Order_IsOutput]
GO
/****** Object:  Default [DF_tbl_Order_SendMoney]    Script Date: 09/08/2016 23:26:46 ******/
ALTER TABLE [dbo].[tbl_Order] ADD  CONSTRAINT [DF_tbl_Order_SendMoney]  DEFAULT ((0)) FOR [Order_SendMoney]
GO
/****** Object:  Default [DF_tbl_Order_Total]    Script Date: 09/08/2016 23:26:46 ******/
ALTER TABLE [dbo].[tbl_Order] ADD  CONSTRAINT [DF_tbl_Order_Total]  DEFAULT ((0)) FOR [Order_Total]
GO
/****** Object:  Default [DF_tbl_Order_TotalVAT]    Script Date: 09/08/2016 23:26:46 ******/
ALTER TABLE [dbo].[tbl_Order] ADD  CONSTRAINT [DF_tbl_Order_TotalVAT]  DEFAULT ((0)) FOR [Order_TotalVAT]
GO
/****** Object:  Default [DF_tbl_Order_VAT]    Script Date: 09/08/2016 23:26:46 ******/
ALTER TABLE [dbo].[tbl_Order] ADD  CONSTRAINT [DF_tbl_Order_VAT]  DEFAULT ((0)) FOR [Order_VAT]
GO
/****** Object:  Default [DF_tbl_Order_SaleMoney]    Script Date: 09/08/2016 23:26:46 ******/
ALTER TABLE [dbo].[tbl_Order] ADD  CONSTRAINT [DF_tbl_Order_SaleMoney]  DEFAULT ((0)) FOR [Order_SaleMoney]
GO
/****** Object:  Default [DF_tbl_Model_Model_CategoryID]    Script Date: 09/08/2016 23:26:46 ******/
ALTER TABLE [dbo].[tbl_Model] ADD  CONSTRAINT [DF_tbl_Model_Model_CategoryID]  DEFAULT ((0)) FOR [Model_CategoryID]
GO
/****** Object:  Default [DF_tabl_Model_IsActive]    Script Date: 09/08/2016 23:26:46 ******/
ALTER TABLE [dbo].[tbl_Model] ADD  CONSTRAINT [DF_tabl_Model_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
/****** Object:  Default [DF_tabl_Model_IsDelete]    Script Date: 09/08/2016 23:26:46 ******/
ALTER TABLE [dbo].[tbl_Model] ADD  CONSTRAINT [DF_tabl_Model_IsDelete]  DEFAULT ((0)) FOR [IsDelete]
GO
/****** Object:  Default [DF_tabl_Model_CreatedDate]    Script Date: 09/08/2016 23:26:46 ******/
ALTER TABLE [dbo].[tbl_Model] ADD  CONSTRAINT [DF_tabl_Model_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
/****** Object:  Default [DF_tbl_InputDetail_InputDetail_Price]    Script Date: 09/08/2016 23:26:46 ******/
ALTER TABLE [dbo].[tbl_InputDetail] ADD  CONSTRAINT [DF_tbl_InputDetail_InputDetail_Price]  DEFAULT ((0)) FOR [InputDetail_Price]
GO
/****** Object:  Default [DF_tbl_InputDetail_InputDetaill_Quantity]    Script Date: 09/08/2016 23:26:46 ******/
ALTER TABLE [dbo].[tbl_InputDetail] ADD  CONSTRAINT [DF_tbl_InputDetail_InputDetaill_Quantity]  DEFAULT ((0)) FOR [InputDetail_Quantity]
GO
/****** Object:  Default [DF_tbl_Input_Input_Date]    Script Date: 09/08/2016 23:26:46 ******/
ALTER TABLE [dbo].[tbl_Input] ADD  CONSTRAINT [DF_tbl_Input_Input_Date]  DEFAULT (getdate()) FOR [Input_Date]
GO
/****** Object:  Default [DF_tbl_Input_Input_IsVoucher]    Script Date: 09/08/2016 23:26:46 ******/
ALTER TABLE [dbo].[tbl_Input] ADD  CONSTRAINT [DF_tbl_Input_Input_IsVoucher]  DEFAULT ((0)) FOR [Input_IsVoucher]
GO
/****** Object:  Default [DF_tbl_Input_IsDelete]    Script Date: 09/08/2016 23:26:46 ******/
ALTER TABLE [dbo].[tbl_Input] ADD  CONSTRAINT [DF_tbl_Input_IsDelete]  DEFAULT ((0)) FOR [IsDelete]
GO
/****** Object:  Default [DF_tbl_Input_CreatedDate]    Script Date: 09/08/2016 23:26:46 ******/
ALTER TABLE [dbo].[tbl_Input] ADD  CONSTRAINT [DF_tbl_Input_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
/****** Object:  Default [DF_tbl_Customer_IsActive]    Script Date: 09/08/2016 23:26:46 ******/
ALTER TABLE [dbo].[tbl_Customer] ADD  CONSTRAINT [DF_tbl_Customer_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
/****** Object:  Default [DF_tbl_Customer_IsDelete]    Script Date: 09/08/2016 23:26:46 ******/
ALTER TABLE [dbo].[tbl_Customer] ADD  CONSTRAINT [DF_tbl_Customer_IsDelete]  DEFAULT ((0)) FOR [IsDelete]
GO
/****** Object:  Default [DF_tbl_Customer_CreatedDate]    Script Date: 09/08/2016 23:26:46 ******/
ALTER TABLE [dbo].[tbl_Customer] ADD  CONSTRAINT [DF_tbl_Customer_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
/****** Object:  Default [DF_tbl_Config_IsActive]    Script Date: 09/08/2016 23:26:46 ******/
ALTER TABLE [dbo].[tbl_Config] ADD  CONSTRAINT [DF_tbl_Config_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
/****** Object:  Default [DF_tbl_Config_IsDelete]    Script Date: 09/08/2016 23:26:46 ******/
ALTER TABLE [dbo].[tbl_Config] ADD  CONSTRAINT [DF_tbl_Config_IsDelete]  DEFAULT ((0)) FOR [IsDelete]
GO
/****** Object:  Default [DF_tbl_Config_CreatedDate]    Script Date: 09/08/2016 23:26:46 ******/
ALTER TABLE [dbo].[tbl_Config] ADD  CONSTRAINT [DF_tbl_Config_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
/****** Object:  Default [DF_tabl_Color_IsActive]    Script Date: 09/08/2016 23:26:46 ******/
ALTER TABLE [dbo].[tbl_Color] ADD  CONSTRAINT [DF_tabl_Color_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
/****** Object:  Default [DF_tabl_Color_IsDelete]    Script Date: 09/08/2016 23:26:46 ******/
ALTER TABLE [dbo].[tbl_Color] ADD  CONSTRAINT [DF_tabl_Color_IsDelete]  DEFAULT ((0)) FOR [IsDelete]
GO
/****** Object:  Default [DF_tabl_Color_CreatedDate]    Script Date: 09/08/2016 23:26:46 ******/
ALTER TABLE [dbo].[tbl_Color] ADD  CONSTRAINT [DF_tabl_Color_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
/****** Object:  Default [DF_tbl_Color_Orderindex]    Script Date: 09/08/2016 23:26:46 ******/
ALTER TABLE [dbo].[tbl_Color] ADD  CONSTRAINT [DF_tbl_Color_Orderindex]  DEFAULT ((0)) FOR [Orderindex]
GO
/****** Object:  Default [DF_tbl_Category_IsActive]    Script Date: 09/08/2016 23:26:46 ******/
ALTER TABLE [dbo].[tbl_Category] ADD  CONSTRAINT [DF_tbl_Category_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
/****** Object:  Default [DF_tbl_Category_IsDelete]    Script Date: 09/08/2016 23:26:46 ******/
ALTER TABLE [dbo].[tbl_Category] ADD  CONSTRAINT [DF_tbl_Category_IsDelete]  DEFAULT ((0)) FOR [IsDelete]
GO
/****** Object:  Default [DF_tbl_Category_CreatedDate]    Script Date: 09/08/2016 23:26:46 ******/
ALTER TABLE [dbo].[tbl_Category] ADD  CONSTRAINT [DF_tbl_Category_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
/****** Object:  Default [DF_tbl_Category_Orderindex]    Script Date: 09/08/2016 23:26:46 ******/
ALTER TABLE [dbo].[tbl_Category] ADD  CONSTRAINT [DF_tbl_Category_Orderindex]  DEFAULT ((0)) FOR [Orderindex]
GO
/****** Object:  Default [DF_tbl_AutomaticValues_ValueForIdLenght]    Script Date: 09/08/2016 23:26:46 ******/
ALTER TABLE [dbo].[tbl_AutomaticValues] ADD  CONSTRAINT [DF_tbl_AutomaticValues_ValueForIdLenght]  DEFAULT ((10)) FOR [LengthOfDefaultValueForId]
GO
