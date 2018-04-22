USE [master]
GO
/****** Object:  Database [escola]    Script Date: 22/04/2018 12:24:26 ******/
CREATE DATABASE [escola]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'escola', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\escola.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'escola_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\escola_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [escola] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [escola].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [escola] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [escola] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [escola] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [escola] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [escola] SET ARITHABORT OFF 
GO
ALTER DATABASE [escola] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [escola] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [escola] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [escola] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [escola] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [escola] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [escola] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [escola] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [escola] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [escola] SET  DISABLE_BROKER 
GO
ALTER DATABASE [escola] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [escola] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [escola] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [escola] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [escola] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [escola] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [escola] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [escola] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [escola] SET  MULTI_USER 
GO
ALTER DATABASE [escola] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [escola] SET DB_CHAINING OFF 
GO
ALTER DATABASE [escola] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [escola] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [escola] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [escola] SET QUERY_STORE = OFF
GO
USE [escola]
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
USE [escola]
GO
/****** Object:  Table [dbo].[aluno]    Script Date: 22/04/2018 12:24:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[aluno](
	[cd_aluno] [int] IDENTITY(1,1) NOT NULL,
	[nm_aluno] [varchar](50) NOT NULL,
	[cd_turma] [int] NOT NULL,
	[cd_responsavel] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[cd_aluno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[chamada]    Script Date: 22/04/2018 12:24:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chamada](
	[cd_chamada] [int] IDENTITY(1,1) NOT NULL,
	[dt_chamada] [datetime] NOT NULL,
	[cd_aluno] [int] NOT NULL,
	[in_presente] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[cd_chamada] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[responsavel]    Script Date: 22/04/2018 12:24:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[responsavel](
	[cd_responsavel] [int] IDENTITY(1,1) NOT NULL,
	[nm_responsavel] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[cd_responsavel] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[turma]    Script Date: 22/04/2018 12:24:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[turma](
	[cd_turma] [int] IDENTITY(1,1) NOT NULL,
	[dc_turma] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[cd_turma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[chamada] ADD  DEFAULT (getdate()) FOR [dt_chamada]
GO
ALTER TABLE [dbo].[chamada] ADD  DEFAULT ((1)) FOR [in_presente]
GO
ALTER TABLE [dbo].[aluno]  WITH CHECK ADD FOREIGN KEY([cd_responsavel])
REFERENCES [dbo].[responsavel] ([cd_responsavel])
GO
ALTER TABLE [dbo].[aluno]  WITH CHECK ADD FOREIGN KEY([cd_turma])
REFERENCES [dbo].[turma] ([cd_turma])
GO
ALTER TABLE [dbo].[chamada]  WITH CHECK ADD FOREIGN KEY([cd_aluno])
REFERENCES [dbo].[aluno] ([cd_aluno])
GO
/****** Object:  StoredProcedure [dbo].[sp_lista_chamada]    Script Date: 22/04/2018 12:24:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_lista_chamada](@data date, @turma int) as
begin

select 
 a.cd_aluno, nm_aluno, cd_chamada, dt_chamada, in_presente
 from aluno a
left outer join chamada c on c.cd_aluno = a.cd_aluno and CONVERT(date, c.dt_chamada) = @data
where a.cd_turma = @turma
end
GO
USE [master]
GO
ALTER DATABASE [escola] SET  READ_WRITE 
GO
