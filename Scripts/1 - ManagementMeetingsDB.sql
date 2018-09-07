USE [master]
GO

/****** Object:  Database [Management_Meetings]    Script Date: 07 Sep 2018 9:18:46 AM ******/
CREATE DATABASE [Management_Meetings]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Management_Meetings', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Management_Meetings.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Management_Meetings_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Management_Meetings_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO

ALTER DATABASE [Management_Meetings] SET COMPATIBILITY_LEVEL = 140
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Management_Meetings].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [Management_Meetings] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [Management_Meetings] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [Management_Meetings] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [Management_Meetings] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [Management_Meetings] SET ARITHABORT OFF 
GO

ALTER DATABASE [Management_Meetings] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [Management_Meetings] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [Management_Meetings] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [Management_Meetings] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [Management_Meetings] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [Management_Meetings] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [Management_Meetings] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [Management_Meetings] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [Management_Meetings] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [Management_Meetings] SET  DISABLE_BROKER 
GO

ALTER DATABASE [Management_Meetings] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [Management_Meetings] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [Management_Meetings] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [Management_Meetings] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [Management_Meetings] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [Management_Meetings] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [Management_Meetings] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [Management_Meetings] SET RECOVERY FULL 
GO

ALTER DATABASE [Management_Meetings] SET  MULTI_USER 
GO

ALTER DATABASE [Management_Meetings] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [Management_Meetings] SET DB_CHAINING OFF 
GO

ALTER DATABASE [Management_Meetings] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [Management_Meetings] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [Management_Meetings] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [Management_Meetings] SET QUERY_STORE = OFF
GO

USE [Management_Meetings]
GO

ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO

ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO

ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO

ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO

ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO

ALTER DATABASE [Management_Meetings] SET  READ_WRITE 
GO