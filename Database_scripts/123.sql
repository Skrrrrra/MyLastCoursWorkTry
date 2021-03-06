USE [master]
GO
/****** Object:  Database [CoursWorkDB]    Script Date: 23.05.2022 2:45:46 ******/
CREATE DATABASE [CoursWorkDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CoursWorkDB', FILENAME = N'D:\WebAppDatabases\CoursWorkDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CoursWorkDB_log', FILENAME = N'D:\WebAppDatabases\CoursWorkDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [CoursWorkDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CoursWorkDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CoursWorkDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CoursWorkDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CoursWorkDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CoursWorkDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CoursWorkDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [CoursWorkDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CoursWorkDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CoursWorkDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CoursWorkDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CoursWorkDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CoursWorkDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CoursWorkDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CoursWorkDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CoursWorkDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CoursWorkDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CoursWorkDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CoursWorkDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CoursWorkDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CoursWorkDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CoursWorkDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CoursWorkDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CoursWorkDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CoursWorkDB] SET RECOVERY FULL 
GO
ALTER DATABASE [CoursWorkDB] SET  MULTI_USER 
GO
ALTER DATABASE [CoursWorkDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CoursWorkDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CoursWorkDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CoursWorkDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CoursWorkDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CoursWorkDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'CoursWorkDB', N'ON'
GO
ALTER DATABASE [CoursWorkDB] SET QUERY_STORE = OFF
GO
USE [CoursWorkDB]
GO
/****** Object:  Table [dbo].[StudentDB]    Script Date: 23.05.2022 2:45:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentDB](
	[SecondName] [varchar](50) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[ThirdName] [varchar](50) NOT NULL,
	[Math] [int] NULL,
	[RussianLanguage] [int] NULL,
	[EnglishLanguage] [int] NULL,
	[Date] [date] NOT NULL,
	[Grade] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[studentslogpass]    Script Date: 23.05.2022 2:45:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[studentslogpass](
	[Login] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[ID] [int] IDENTITY(1,1) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[userlogpass]    Script Date: 23.05.2022 2:45:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[userlogpass](
	[login] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[sp_StudentsInsert]    Script Date: 23.05.2022 2:45:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_StudentsInsert]
-- Add the parameters for the stored procedure here
	@secondname nvarchar(50),
	@firstname nvarchar(50),
	@thirdname nvarchar(50),
	@maths int,
	@russianlanguage int,
	@englishlanguage int,
	@id int out
AS INSERT INTO Students(SecondName,FirstName,ThirdName,Maths,RussianLanguage,EnglishLanguage)
	VALUES (@secondname,@firstname,@thirdname,@maths,@russianlanguage,@englishlanguage)
	SET @id = SCOPE_IDENTITY()
GO
USE [master]
GO
ALTER DATABASE [CoursWorkDB] SET  READ_WRITE 
GO
