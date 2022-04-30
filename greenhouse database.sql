USE [master]
GO
/****** Object:  Database [GreenhouseProject]    Script Date: 13-Apr-22 11:23:19 PM ******/
CREATE DATABASE [GreenhouseProject]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'GreenhouseProject', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\GreenhouseProject.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'GreenhouseProject_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\GreenhouseProject_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [GreenhouseProject] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GreenhouseProject].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GreenhouseProject] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [GreenhouseProject] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [GreenhouseProject] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [GreenhouseProject] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [GreenhouseProject] SET ARITHABORT OFF 
GO
ALTER DATABASE [GreenhouseProject] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [GreenhouseProject] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [GreenhouseProject] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [GreenhouseProject] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [GreenhouseProject] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [GreenhouseProject] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [GreenhouseProject] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [GreenhouseProject] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [GreenhouseProject] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [GreenhouseProject] SET  DISABLE_BROKER 
GO
ALTER DATABASE [GreenhouseProject] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [GreenhouseProject] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [GreenhouseProject] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [GreenhouseProject] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [GreenhouseProject] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [GreenhouseProject] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [GreenhouseProject] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [GreenhouseProject] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [GreenhouseProject] SET  MULTI_USER 
GO
ALTER DATABASE [GreenhouseProject] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [GreenhouseProject] SET DB_CHAINING OFF 
GO
ALTER DATABASE [GreenhouseProject] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [GreenhouseProject] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [GreenhouseProject] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [GreenhouseProject] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [GreenhouseProject] SET QUERY_STORE = OFF
GO
USE [GreenhouseProject]
GO
/****** Object:  Table [dbo].[Admin Information]    Script Date: 13-Apr-22 11:23:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin Information](
	[Id] [int] NOT NULL,
	[email] [nvarchar](50) NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[NumberOfGreenHouses] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Greenhouse information]    Script Date: 13-Apr-22 11:23:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Greenhouse information](
	[Id] [int] NULL,
	[GreenhouseId] [int] NULL,
	[TypeOfGreenhouse] [nvarchar](50) NULL,
	[Cultivationarea] [int] NULL,
	[NumberOfGreenHouses] [int] NULL,
	[PlantID] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Growth Information]    Script Date: 13-Apr-22 11:23:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Growth Information](
	[PlantInformationId] [int] NOT NULL,
	[CultivationStartDate] [date] NULL,
	[CultivationEndDate] [date] NULL,
	[Species] [nvarchar](250) NULL,
	[CultivationMethod] [nvarchar](250) NULL,
	[SowDate] [date] NULL,
	[TranspaltingDate] [date] NULL,
 CONSTRAINT [PK__Growth I__61614715047CD49C] PRIMARY KEY CLUSTERED 
(
	[PlantInformationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LUX Sensor]    Script Date: 13-Apr-22 11:23:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LUX Sensor](
	[SensorID] [int] NULL,
	[Light] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MoistureSensor]    Script Date: 13-Apr-22 11:23:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MoistureSensor](
	[SensorID] [int] NULL,
	[Moisture] [float] NULL,
	[SoilMoisture] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Plants information]    Script Date: 13-Apr-22 11:23:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Plants information](
	[PlantId] [int] NOT NULL,
	[PlantsCount] [int] NULL,
	[PlantInformationId] [int] NULL,
 CONSTRAINT [PK__Plants i__98FE395CA19566DB] PRIMARY KEY CLUSTERED 
(
	[PlantId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sensor allocation]    Script Date: 13-Apr-22 11:23:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sensor allocation](
	[Id] [int] NOT NULL,
	[GreenhouseId] [int] NULL,
	[Date] [date] NULL,
	[NumberOfWeek] [int] NULL,
	[SensorData] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TemperatureSensor]    Script Date: 13-Apr-22 11:23:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TemperatureSensor](
	[SensorId] [int] NULL,
	[Temperature] [float] NULL,
	[SoilTemparture] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User  Information]    Script Date: 13-Apr-22 11:23:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User  Information](
	[Id] [int] NOT NULL,
	[email] [nvarchar](50) NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[GreenHouseId] [int] NULL,
	[NumberOfGreenHouses] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User Information]    Script Date: 13-Apr-22 11:23:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User Information](
	[Id] [int] NOT NULL,
	[email] [nvarchar](50) NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[GreenHouseId] [int] NULL,
	[NumberOfGreenHouses] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Greenhouse information]  WITH CHECK ADD  CONSTRAINT [FK_Greenhouse information.NumberOfGreenHouses] FOREIGN KEY([Id])
REFERENCES [dbo].[Admin Information] ([Id])
GO
ALTER TABLE [dbo].[Greenhouse information] CHECK CONSTRAINT [FK_Greenhouse information.NumberOfGreenHouses]
GO
ALTER TABLE [dbo].[LUX Sensor]  WITH CHECK ADD  CONSTRAINT [FK_LUX Sensor.SensorID] FOREIGN KEY([SensorID])
REFERENCES [dbo].[Sensor allocation] ([Id])
GO
ALTER TABLE [dbo].[LUX Sensor] CHECK CONSTRAINT [FK_LUX Sensor.SensorID]
GO
ALTER TABLE [dbo].[MoistureSensor]  WITH CHECK ADD  CONSTRAINT [FK_MoistureSensor.SensorID] FOREIGN KEY([SensorID])
REFERENCES [dbo].[Sensor allocation] ([Id])
GO
ALTER TABLE [dbo].[MoistureSensor] CHECK CONSTRAINT [FK_MoistureSensor.SensorID]
GO
ALTER TABLE [dbo].[TemperatureSensor]  WITH CHECK ADD  CONSTRAINT [FK_TemperatureSensor.SensorId] FOREIGN KEY([SensorId])
REFERENCES [dbo].[Sensor allocation] ([Id])
GO
ALTER TABLE [dbo].[TemperatureSensor] CHECK CONSTRAINT [FK_TemperatureSensor.SensorId]
GO
USE [master]
GO
ALTER DATABASE [GreenhouseProject] SET  READ_WRITE 
GO
