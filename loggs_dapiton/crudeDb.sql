USE [master]
GO
/****** Object:  Database [login]    Script Date: 02/06/2023 10:11:53 pm ******/
CREATE DATABASE [login]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'login', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\login.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'login_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\login_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [login] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [login].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [login] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [login] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [login] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [login] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [login] SET ARITHABORT OFF 
GO
ALTER DATABASE [login] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [login] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [login] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [login] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [login] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [login] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [login] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [login] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [login] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [login] SET  ENABLE_BROKER 
GO
ALTER DATABASE [login] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [login] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [login] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [login] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [login] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [login] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [login] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [login] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [login] SET  MULTI_USER 
GO
ALTER DATABASE [login] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [login] SET DB_CHAINING OFF 
GO
ALTER DATABASE [login] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [login] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [login] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [login] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [login] SET QUERY_STORE = OFF
GO
USE [login]
GO
/****** Object:  Table [dbo].[admin]    Script Date: 02/06/2023 10:11:53 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[admin](
	[userName] [varchar](20) NULL,
	[pass] [varchar](20) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 02/06/2023 10:11:54 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[category_ID] [int] IDENTITY(1,1) NOT NULL,
	[category_name] [varchar](50) NOT NULL,
	[date_added] [datetime] NULL,
	[archive] [tinyint] NULL,
PRIMARY KEY CLUSTERED 
(
	[category_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 02/06/2023 10:11:54 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[Product_ID] [int] IDENTITY(1,1) NOT NULL,
	[Code] [varchar](20) NOT NULL,
	[ProductName] [varchar](50) NOT NULL,
	[size] [varchar](10) NOT NULL,
	[quantity] [int] NOT NULL,
	[price] [decimal](18, 2) NOT NULL,
	[date_added] [datetime] NULL,
	[Category_ID] [int] NOT NULL,
	[archive] [tinyint] NULL,
PRIMARY KEY CLUSTERED 
(
	[Product_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[admin] ([userName], [pass]) VALUES (N'user', N'admin')
INSERT [dbo].[admin] ([userName], [pass]) VALUES (N'hello', N'world')
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([category_ID], [category_name], [date_added], [archive]) VALUES (1, N'Shoes', CAST(N'2023-06-02T17:13:07.227' AS DateTime), 0)
INSERT [dbo].[Categories] ([category_ID], [category_name], [date_added], [archive]) VALUES (2, N'Clothes', CAST(N'2023-06-02T17:13:15.813' AS DateTime), 0)
INSERT [dbo].[Categories] ([category_ID], [category_name], [date_added], [archive]) VALUES (3, N'T-Shirt', CAST(N'2023-06-02T17:13:22.620' AS DateTime), 0)
INSERT [dbo].[Categories] ([category_ID], [category_name], [date_added], [archive]) VALUES (4, N'Pants', CAST(N'2023-06-02T17:13:27.457' AS DateTime), 0)
INSERT [dbo].[Categories] ([category_ID], [category_name], [date_added], [archive]) VALUES (5, N'', CAST(N'2023-06-02T20:45:24.110' AS DateTime), 0)
INSERT [dbo].[Categories] ([category_ID], [category_name], [date_added], [archive]) VALUES (6, N'Cloooothes', CAST(N'2023-06-02T21:28:35.663' AS DateTime), 0)
INSERT [dbo].[Categories] ([category_ID], [category_name], [date_added], [archive]) VALUES (7, N'shu', CAST(N'2023-06-02T21:30:42.960' AS DateTime), 0)
INSERT [dbo].[Categories] ([category_ID], [category_name], [date_added], [archive]) VALUES (8, N'mew', CAST(N'2023-06-02T21:33:37.960' AS DateTime), 0)
INSERT [dbo].[Categories] ([category_ID], [category_name], [date_added], [archive]) VALUES (9, N'Meow', CAST(N'2023-06-02T21:35:53.330' AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
ALTER TABLE [dbo].[Categories] ADD  CONSTRAINT [df_date]  DEFAULT (getdate()) FOR [date_added]
GO
ALTER TABLE [dbo].[Categories] ADD  DEFAULT ((0)) FOR [archive]
GO
ALTER TABLE [dbo].[Product] ADD  DEFAULT (getdate()) FOR [date_added]
GO
ALTER TABLE [dbo].[Product] ADD  DEFAULT ((0)) FOR [archive]
GO
USE [master]
GO
ALTER DATABASE [login] SET  READ_WRITE 
GO
