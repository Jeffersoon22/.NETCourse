USE [master]
GO
/****** Object:  Database [nato_japharidze_normalization_tutorial_1]    Script Date: 2/11/2020 8:08:14 PM ******/
CREATE DATABASE [nato_japharidze_normalization_tutorial_1]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'nato_japharidze_normalization_tutorial_1', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\nato_japharidze_normalization_tutorial_1.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'nato_japharidze_normalization_tutorial_1_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\nato_japharidze_normalization_tutorial_1_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [nato_japharidze_normalization_tutorial_1] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [nato_japharidze_normalization_tutorial_1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [nato_japharidze_normalization_tutorial_1] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [nato_japharidze_normalization_tutorial_1] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [nato_japharidze_normalization_tutorial_1] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [nato_japharidze_normalization_tutorial_1] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [nato_japharidze_normalization_tutorial_1] SET ARITHABORT OFF 
GO
ALTER DATABASE [nato_japharidze_normalization_tutorial_1] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [nato_japharidze_normalization_tutorial_1] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [nato_japharidze_normalization_tutorial_1] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [nato_japharidze_normalization_tutorial_1] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [nato_japharidze_normalization_tutorial_1] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [nato_japharidze_normalization_tutorial_1] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [nato_japharidze_normalization_tutorial_1] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [nato_japharidze_normalization_tutorial_1] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [nato_japharidze_normalization_tutorial_1] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [nato_japharidze_normalization_tutorial_1] SET  ENABLE_BROKER 
GO
ALTER DATABASE [nato_japharidze_normalization_tutorial_1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [nato_japharidze_normalization_tutorial_1] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [nato_japharidze_normalization_tutorial_1] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [nato_japharidze_normalization_tutorial_1] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [nato_japharidze_normalization_tutorial_1] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [nato_japharidze_normalization_tutorial_1] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [nato_japharidze_normalization_tutorial_1] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [nato_japharidze_normalization_tutorial_1] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [nato_japharidze_normalization_tutorial_1] SET  MULTI_USER 
GO
ALTER DATABASE [nato_japharidze_normalization_tutorial_1] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [nato_japharidze_normalization_tutorial_1] SET DB_CHAINING OFF 
GO
ALTER DATABASE [nato_japharidze_normalization_tutorial_1] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [nato_japharidze_normalization_tutorial_1] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [nato_japharidze_normalization_tutorial_1] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [nato_japharidze_normalization_tutorial_1] SET QUERY_STORE = OFF
GO
USE [nato_japharidze_normalization_tutorial_1]
GO
/****** Object:  Table [dbo].[Class]    Script Date: 2/11/2020 8:08:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Class](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClassNumber] [nvarchar](10) NULL,
	[ConsultantId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Consultant]    Script Date: 2/11/2020 8:08:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Consultant](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](10) NULL,
	[Room] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 2/11/2020 8:08:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClassId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Consultant] ON 

INSERT [dbo].[Consultant] ([Id], [Name], [Room]) VALUES (1, N'Yoda', N'Academy 1')
SET IDENTITY_INSERT [dbo].[Consultant] OFF
ALTER TABLE [dbo].[Class]  WITH CHECK ADD  CONSTRAINT [FK__Class__Consultan] FOREIGN KEY([ConsultantId])
REFERENCES [dbo].[Consultant] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Class] CHECK CONSTRAINT [FK__Class__Consultan]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD FOREIGN KEY([ClassId])
REFERENCES [dbo].[Class] ([Id])
GO
USE [master]
GO
ALTER DATABASE [nato_japharidze_normalization_tutorial_1] SET  READ_WRITE 
GO
