USE [master]
GO
/****** Object:  Database [KsiegarniaInternetowa]    Script Date: 09.01.2020 18:00:06 ******/
CREATE DATABASE [KsiegarniaInternetowa]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'KsiegarniaInternetowa', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\KsiegarniaInternetowa.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'KsiegarniaInternetowa_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\KsiegarniaInternetowa_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [KsiegarniaInternetowa] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [KsiegarniaInternetowa].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [KsiegarniaInternetowa] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [KsiegarniaInternetowa] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [KsiegarniaInternetowa] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [KsiegarniaInternetowa] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [KsiegarniaInternetowa] SET ARITHABORT OFF 
GO
ALTER DATABASE [KsiegarniaInternetowa] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [KsiegarniaInternetowa] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [KsiegarniaInternetowa] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [KsiegarniaInternetowa] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [KsiegarniaInternetowa] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [KsiegarniaInternetowa] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [KsiegarniaInternetowa] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [KsiegarniaInternetowa] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [KsiegarniaInternetowa] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [KsiegarniaInternetowa] SET  DISABLE_BROKER 
GO
ALTER DATABASE [KsiegarniaInternetowa] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [KsiegarniaInternetowa] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [KsiegarniaInternetowa] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [KsiegarniaInternetowa] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [KsiegarniaInternetowa] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [KsiegarniaInternetowa] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [KsiegarniaInternetowa] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [KsiegarniaInternetowa] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [KsiegarniaInternetowa] SET  MULTI_USER 
GO
ALTER DATABASE [KsiegarniaInternetowa] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [KsiegarniaInternetowa] SET DB_CHAINING OFF 
GO
ALTER DATABASE [KsiegarniaInternetowa] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [KsiegarniaInternetowa] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [KsiegarniaInternetowa] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [KsiegarniaInternetowa] SET QUERY_STORE = OFF
GO
USE [KsiegarniaInternetowa]
GO
/****** Object:  Table [dbo].[tbAdministratorzy]    Script Date: 09.01.2020 18:00:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbAdministratorzy](
	[ID] [bigint] NOT NULL,
	[Imie] [nvarchar](255) NOT NULL,
	[Nazwisko] [nvarchar](255) NOT NULL,
	[Login] [nvarchar](255) NOT NULL,
	[Haslo] [nvarchar](255) NOT NULL,
	[Email] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_tbAdministratorzy] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbAdresaci]    Script Date: 09.01.2020 18:00:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbAdresaci](
	[ID] [bigint] NOT NULL,
	[Imie] [nvarchar](50) NOT NULL,
	[Nazwisko] [nvarchar](50) NOT NULL,
	[Ulica] [nvarchar](50) NOT NULL,
	[Miasto] [nvarchar](50) NOT NULL,
	[KodPocztowy] [nvarchar](50) NOT NULL,
	[NrDomu] [nvarchar](50) NOT NULL,
	[NrMieszkania] [nvarchar](50) NULL,
	[NrTelefonu] [int] NOT NULL,
 CONSTRAINT [PK_tbAdresaci] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbArchiwumZamowien]    Script Date: 09.01.2020 18:00:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbArchiwumZamowien](
	[ID] [bigint] NOT NULL,
	[Status] [int] NOT NULL,
 CONSTRAINT [PK_tbArchiwumZamowien] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbPracownicy]    Script Date: 09.01.2020 18:00:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbPracownicy](
	[ID] [bigint] NOT NULL,
	[Imie] [nvarchar](50) NOT NULL,
	[Nazwisko] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Haslo] [nvarchar](50) NOT NULL,
	[Login] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tbPracownicy] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbProdukty]    Script Date: 09.01.2020 18:00:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbProdukty](
	[ID] [bigint] NOT NULL,
	[Nazwa] [nvarchar](50) NOT NULL,
	[Cena] [money] NOT NULL,
	[Ilosc] [int] NOT NULL,
	[Dostepnosc] [bit] NOT NULL,
	[DataDodania] [datetime] NOT NULL,
	[IdZamowienia] [bigint] NULL,
 CONSTRAINT [PK_tbProdukty] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbZamowienia]    Script Date: 09.01.2020 18:00:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbZamowienia](
	[ID] [bigint] NOT NULL,
 CONSTRAINT [PK_tbZamowienia] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tbProdukty]  WITH CHECK ADD FOREIGN KEY([IdZamowienia])
REFERENCES [dbo].[tbZamowienia] ([ID])
GO
ALTER TABLE [dbo].[tbZamowienia]  WITH CHECK ADD  CONSTRAINT [FK_tbZamowienia_tbAdresaci] FOREIGN KEY([ID])
REFERENCES [dbo].[tbAdresaci] ([ID])
GO
ALTER TABLE [dbo].[tbZamowienia] CHECK CONSTRAINT [FK_tbZamowienia_tbAdresaci]
GO
ALTER TABLE [dbo].[tbZamowienia]  WITH CHECK ADD  CONSTRAINT [FK_tbZamowienia_tbArchiwumZamowien] FOREIGN KEY([ID])
REFERENCES [dbo].[tbArchiwumZamowien] ([ID])
GO
ALTER TABLE [dbo].[tbZamowienia] CHECK CONSTRAINT [FK_tbZamowienia_tbArchiwumZamowien]
GO
ALTER TABLE [dbo].[tbZamowienia]  WITH CHECK ADD  CONSTRAINT [FK_tbZamowienia_tbPracownicy] FOREIGN KEY([ID])
REFERENCES [dbo].[tbPracownicy] ([ID])
GO
ALTER TABLE [dbo].[tbZamowienia] CHECK CONSTRAINT [FK_tbZamowienia_tbPracownicy]
GO
USE [master]
GO
ALTER DATABASE [KsiegarniaInternetowa] SET  READ_WRITE 
GO
