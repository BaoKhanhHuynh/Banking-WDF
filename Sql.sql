USE [master]
GO
/****** Object:  Database [BANKSYSTEM]    Script Date: 11/25/2024 12:20:34 AM ******/
CREATE DATABASE [BANKSYSTEM]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BANKSYSTEM', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\BANKSYSTEM.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BANKSYSTEM_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\BANKSYSTEM_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [BANKSYSTEM] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BANKSYSTEM].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BANKSYSTEM] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BANKSYSTEM] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BANKSYSTEM] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BANKSYSTEM] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BANKSYSTEM] SET ARITHABORT OFF 
GO
ALTER DATABASE [BANKSYSTEM] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BANKSYSTEM] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BANKSYSTEM] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BANKSYSTEM] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BANKSYSTEM] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BANKSYSTEM] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BANKSYSTEM] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BANKSYSTEM] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BANKSYSTEM] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BANKSYSTEM] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BANKSYSTEM] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BANKSYSTEM] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BANKSYSTEM] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BANKSYSTEM] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BANKSYSTEM] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BANKSYSTEM] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BANKSYSTEM] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BANKSYSTEM] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BANKSYSTEM] SET  MULTI_USER 
GO
ALTER DATABASE [BANKSYSTEM] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BANKSYSTEM] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BANKSYSTEM] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BANKSYSTEM] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BANKSYSTEM] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BANKSYSTEM] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [BANKSYSTEM] SET QUERY_STORE = ON
GO
ALTER DATABASE [BANKSYSTEM] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [BANKSYSTEM]
GO
/****** Object:  Table [dbo].[_Transaction]    Script Date: 11/25/2024 12:20:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[_Transaction](
	[id] [int] NOT NULL,
	[from_account_id] [int] NULL,
	[branch_id] [nvarchar](10) NULL,
	[date_of_trans] [date] NULL,
	[amount] [decimal](18, 2) NULL,
	[pin] [nvarchar](6) NULL,
	[to_account_id] [int] NULL,
	[employee_id] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 11/25/2024 12:20:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[id] [int] NOT NULL,
	[customerid] [nvarchar](10) NULL,
	[date_opened] [date] NULL,
	[balance] [decimal](18, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Branch]    Script Date: 11/25/2024 12:20:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Branch](
	[id] [nvarchar](10) NOT NULL,
	[name] [nvarchar](50) NULL,
	[house_no] [nvarchar](10) NULL,
	[city] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 11/25/2024 12:20:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[id] [nvarchar](10) NOT NULL,
	[name] [nvarchar](50) NULL,
	[phone] [nvarchar](15) NULL,
	[email] [nvarchar](50) NULL,
	[house_no] [nvarchar](10) NULL,
	[city] [nvarchar](50) NULL,
	[pin] [nvarchar](6) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 11/25/2024 12:20:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[id] [nvarchar](10) NOT NULL,
	[employee_name] [nvarchar](50) NULL,
	[password] [nvarchar](50) NULL,
	[role] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[_Transaction] ([id], [from_account_id], [branch_id], [date_of_trans], [amount], [pin], [to_account_id], [employee_id]) VALUES (1, 1, N'Bank1', CAST(N'2024-01-10' AS Date), CAST(500.00 AS Decimal(18, 2)), N'1234', 2, N'1')
INSERT [dbo].[_Transaction] ([id], [from_account_id], [branch_id], [date_of_trans], [amount], [pin], [to_account_id], [employee_id]) VALUES (2, 2, N'Bank2', CAST(N'2024-01-11' AS Date), CAST(1000.00 AS Decimal(18, 2)), N'4567', 3, N'2')
INSERT [dbo].[_Transaction] ([id], [from_account_id], [branch_id], [date_of_trans], [amount], [pin], [to_account_id], [employee_id]) VALUES (3, 3, N'Bank3', CAST(N'2024-01-12' AS Date), CAST(300.00 AS Decimal(18, 2)), N'7890', 1, N'3')
INSERT [dbo].[_Transaction] ([id], [from_account_id], [branch_id], [date_of_trans], [amount], [pin], [to_account_id], [employee_id]) VALUES (4, 2, N'Bank3', CAST(N'2024-01-01' AS Date), CAST(1500.00 AS Decimal(18, 2)), N'234', 1, N'2')
GO
INSERT [dbo].[Account] ([id], [customerid], [date_opened], [balance]) VALUES (1, N'1', CAST(N'2024-08-01' AS Date), CAST(2700.00 AS Decimal(18, 2)))
INSERT [dbo].[Account] ([id], [customerid], [date_opened], [balance]) VALUES (2, N'2', CAST(N'2024-07-02' AS Date), CAST(2000.00 AS Decimal(18, 2)))
INSERT [dbo].[Account] ([id], [customerid], [date_opened], [balance]) VALUES (3, N'3', CAST(N'2024-01-03' AS Date), CAST(1500.00 AS Decimal(18, 2)))
INSERT [dbo].[Account] ([id], [customerid], [date_opened], [balance]) VALUES (4, N'4', CAST(N'2024-10-02' AS Date), CAST(1260.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Branch] ([id], [name], [house_no], [city]) VALUES (N'Bank1', N'VietComBank', N'124', N'Ho Chi Minh')
INSERT [dbo].[Branch] ([id], [name], [house_no], [city]) VALUES (N'Bank2', N'VietTinBank ', N'168', N'Soc Trang')
INSERT [dbo].[Branch] ([id], [name], [house_no], [city]) VALUES (N'Bank3', N'VPBank', N'700', N'Tra Vinh')
GO
INSERT [dbo].[Customer] ([id], [name], [phone], [email], [house_no], [city], [pin]) VALUES (N'1', N'Pham Thi Dao', N'0223344556', N'phamthid@gmail.com', N'101', N'Can Tho', N'2705')
INSERT [dbo].[Customer] ([id], [name], [phone], [email], [house_no], [city], [pin]) VALUES (N'2', N'Khanh Quyen Dang', N'0334455667', N'dangkhaquyen@gmail.com', N'102', N'Hai Phong', N'180000')
INSERT [dbo].[Customer] ([id], [name], [phone], [email], [house_no], [city], [pin]) VALUES (N'3', N'Bui Thi F', N'0445566778', N'buithif@gmail.com', N'103', N'Hue', N'530000')
INSERT [dbo].[Customer] ([id], [name], [phone], [email], [house_no], [city], [pin]) VALUES (N'4', N'Bao Khanh Huynh', N'0785821576', N'baokhanhhuynh@gmail.com', N'1206', N'Soc Trang', N'2001')
INSERT [dbo].[Customer] ([id], [name], [phone], [email], [house_no], [city], [pin]) VALUES (N'6', N'Nguyen Binh Anh', N'0785857373', N'BinhAnh@gmail.com', N'1805', N'Tra Vinh', N'2000')
GO
INSERT [dbo].[Employee] ([id], [employee_name], [password], [role]) VALUES (N'1', N'Huynh Khanh Vy', N'1234', N'admin')
INSERT [dbo].[Employee] ([id], [employee_name], [password], [role]) VALUES (N'2', N'Huynh Ngoc Bao Khanh', N'4567', N'user')
INSERT [dbo].[Employee] ([id], [employee_name], [password], [role]) VALUES (N'3', N'Thach Thanh Nhan', N'78910', N'user')
INSERT [dbo].[Employee] ([id], [employee_name], [password], [role]) VALUES (N'4', N'Bao Ngoc', N'543', N'admin')
INSERT [dbo].[Employee] ([id], [employee_name], [password], [role]) VALUES (N'5', N'Bao Khanh Huynh', N'202cb962ac59075b964b07152d234b70', N'admin')
GO
ALTER TABLE [dbo].[_Transaction]  WITH CHECK ADD FOREIGN KEY([branch_id])
REFERENCES [dbo].[Branch] ([id])
GO
ALTER TABLE [dbo].[_Transaction]  WITH CHECK ADD FOREIGN KEY([employee_id])
REFERENCES [dbo].[Employee] ([id])
GO
ALTER TABLE [dbo].[_Transaction]  WITH CHECK ADD FOREIGN KEY([from_account_id])
REFERENCES [dbo].[Account] ([id])
GO
ALTER TABLE [dbo].[Account]  WITH CHECK ADD FOREIGN KEY([customerid])
REFERENCES [dbo].[Customer] ([id])
GO
USE [master]
GO
ALTER DATABASE [BANKSYSTEM] SET  READ_WRITE 
GO
