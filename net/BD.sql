USE [master]
GO
/****** Object:  Database [NET TP2]    Script Date: 14/10/2018 22:19:23 ******/
CREATE DATABASE [NET TP2]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'NET TP2', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\NET TP2.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'NET TP2_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\NET TP2_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [NET TP2] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [NET TP2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [NET TP2] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [NET TP2] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [NET TP2] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [NET TP2] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [NET TP2] SET ARITHABORT OFF 
GO
ALTER DATABASE [NET TP2] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [NET TP2] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [NET TP2] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [NET TP2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [NET TP2] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [NET TP2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [NET TP2] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [NET TP2] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [NET TP2] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [NET TP2] SET  DISABLE_BROKER 
GO
ALTER DATABASE [NET TP2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [NET TP2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [NET TP2] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [NET TP2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [NET TP2] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [NET TP2] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [NET TP2] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [NET TP2] SET RECOVERY FULL 
GO
ALTER DATABASE [NET TP2] SET  MULTI_USER 
GO
ALTER DATABASE [NET TP2] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [NET TP2] SET DB_CHAINING OFF 
GO
ALTER DATABASE [NET TP2] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [NET TP2] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [NET TP2] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'NET TP2', N'ON'
GO
ALTER DATABASE [NET TP2] SET QUERY_STORE = OFF
GO
USE [NET TP2]
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
USE [NET TP2]
GO
/****** Object:  Table [dbo].[Alumno_Inscripcion]    Script Date: 14/10/2018 22:19:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alumno_Inscripcion](
	[idInscripcion] [int] IDENTITY(1,1) NOT NULL,
	[idCurso] [int] NULL,
	[idAlumno] [int] NULL,
	[condicion] [text] NULL,
	[nota] [int] NULL,
 CONSTRAINT [PK_Alumno_Inscripcion] PRIMARY KEY CLUSTERED 
(
	[idInscripcion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Comision]    Script Date: 14/10/2018 22:19:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comision](
	[idComision] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [text] NULL,
	[aula] [text] NULL,
 CONSTRAINT [PK_Comision] PRIMARY KEY CLUSTERED 
(
	[idComision] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Curso]    Script Date: 14/10/2018 22:19:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Curso](
	[idCurso] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [text] NULL,
	[cupo] [int] NULL,
	[idMateria] [int] NULL,
	[idComision] [int] NULL,
 CONSTRAINT [PK_Curso] PRIMARY KEY CLUSTERED 
(
	[idCurso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Docente_Curso]    Script Date: 14/10/2018 22:19:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Docente_Curso](
	[idDocente_Curso] [int] IDENTITY(1,1) NOT NULL,
	[idDocente] [int] NULL,
	[idCurso] [int] NULL,
 CONSTRAINT [PK_Docente_Curso] PRIMARY KEY CLUSTERED 
(
	[idDocente_Curso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Especialidad]    Script Date: 14/10/2018 22:19:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Especialidad](
	[idEspecialidad] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [text] NOT NULL,
	[descripcion] [text] NOT NULL,
 CONSTRAINT [PK_Especialidad] PRIMARY KEY CLUSTERED 
(
	[idEspecialidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Materia]    Script Date: 14/10/2018 22:19:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Materia](
	[idMateria] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [text] NULL,
	[descripcion] [text] NULL,
	[hsSemanales] [int] NULL,
	[hsTotales] [int] NULL,
	[idPlan] [int] NULL,
 CONSTRAINT [PK_Materia] PRIMARY KEY CLUSTERED 
(
	[idMateria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Persona]    Script Date: 14/10/2018 22:19:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Persona](
	[nombre] [text] NULL,
	[apellido] [text] NULL,
	[legajo] [text] NULL,
	[dni] [text] NULL,
	[telefono] [text] NULL,
	[mail] [text] NULL,
	[idPersona] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Persona] PRIMARY KEY CLUSTERED 
(
	[idPersona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Planes]    Script Date: 14/10/2018 22:19:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Planes](
	[idPlan] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [text] NULL,
	[descripcion] [text] NULL,
	[idEsp] [int] NULL,
 CONSTRAINT [PK_Planes] PRIMARY KEY CLUSTERED 
(
	[idPlan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 14/10/2018 22:19:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[NombreUsuario] [text] NOT NULL,
	[Contraseña] [text] NOT NULL,
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[TipoUsuario] [smallint] NOT NULL,
	[idPersona] [int] NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Alumno_Inscripcion] ON 

INSERT [dbo].[Alumno_Inscripcion] ([idInscripcion], [idCurso], [idAlumno], [condicion], [nota]) VALUES (2, 2, 2013, N'Promovido', 8)
INSERT [dbo].[Alumno_Inscripcion] ([idInscripcion], [idCurso], [idAlumno], [condicion], [nota]) VALUES (8, 6, 3024, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Alumno_Inscripcion] OFF
SET IDENTITY_INSERT [dbo].[Comision] ON 

INSERT [dbo].[Comision] ([idComision], [nombre], [aula]) VALUES (1, N'E302', N'205')
INSERT [dbo].[Comision] ([idComision], [nombre], [aula]) VALUES (7, N'ggg', N'525')
SET IDENTITY_INSERT [dbo].[Comision] OFF
SET IDENTITY_INSERT [dbo].[Curso] ON 

INSERT [dbo].[Curso] ([idCurso], [nombre], [cupo], [idMateria], [idComision]) VALUES (2, N'Cur01', 50, 3, 1)
INSERT [dbo].[Curso] ([idCurso], [nombre], [cupo], [idMateria], [idComision]) VALUES (6, N'cursito', 20, 3, 1)
SET IDENTITY_INSERT [dbo].[Curso] OFF
SET IDENTITY_INSERT [dbo].[Docente_Curso] ON 

INSERT [dbo].[Docente_Curso] ([idDocente_Curso], [idDocente], [idCurso]) VALUES (5, 3019, 2)
INSERT [dbo].[Docente_Curso] ([idDocente_Curso], [idDocente], [idCurso]) VALUES (7, 3019, 6)
INSERT [dbo].[Docente_Curso] ([idDocente_Curso], [idDocente], [idCurso]) VALUES (9, 3023, 2)
SET IDENTITY_INSERT [dbo].[Docente_Curso] OFF
SET IDENTITY_INSERT [dbo].[Especialidad] ON 

INSERT [dbo].[Especialidad] ([idEspecialidad], [nombre], [descripcion]) VALUES (7, N'Especiality', N'asdasd33')
SET IDENTITY_INSERT [dbo].[Especialidad] OFF
SET IDENTITY_INSERT [dbo].[Materia] ON 

INSERT [dbo].[Materia] ([idMateria], [nombre], [descripcion], [hsSemanales], [hsTotales], [idPlan]) VALUES (3, N'Fisica', N'FISICA', 6, 60, NULL)
SET IDENTITY_INSERT [dbo].[Materia] OFF
SET IDENTITY_INSERT [dbo].[Persona] ON 

INSERT [dbo].[Persona] ([nombre], [apellido], [legajo], [dni], [telefono], [mail], [idPersona]) VALUES (N'Juan', N'Gimenez', N'41499', N'38541538', N'0303456', N'asdb@asf', 2013)
INSERT [dbo].[Persona] ([nombre], [apellido], [legajo], [dni], [telefono], [mail], [idPersona]) VALUES (N'juan', N'perez', N'0303456', N'38541538', N'0303456', N'SEBYSEBY', 3019)
INSERT [dbo].[Persona] ([nombre], [apellido], [legajo], [dni], [telefono], [mail], [idPersona]) VALUES (N'jorge', N'joge', N'498884', N'321654987', N'113234', N'seby', 3023)
INSERT [dbo].[Persona] ([nombre], [apellido], [legajo], [dni], [telefono], [mail], [idPersona]) VALUES (N'pepe', N'pepe', N'030303303', N'030303', N'pepe', N'pep', 3024)
INSERT [dbo].[Persona] ([nombre], [apellido], [legajo], [dni], [telefono], [mail], [idPersona]) VALUES (N'pepe', N'tutu', N'4484684', N'3155168', N'jhjvyh', N'jbvjytfthc', 3031)
INSERT [dbo].[Persona] ([nombre], [apellido], [legajo], [dni], [telefono], [mail], [idPersona]) VALUES (N't', N't', N'498884y', N't', N't', N't', 3034)
SET IDENTITY_INSERT [dbo].[Persona] OFF
SET IDENTITY_INSERT [dbo].[Planes] ON 

INSERT [dbo].[Planes] ([idPlan], [nombre], [descripcion], [idEsp]) VALUES (2, N'2008', N'hjbasdfkldfs', 7)
INSERT [dbo].[Planes] ([idPlan], [nombre], [descripcion], [idEsp]) VALUES (7, N'444', N'4444', NULL)
SET IDENTITY_INSERT [dbo].[Planes] OFF
SET IDENTITY_INSERT [dbo].[Usuario] ON 

INSERT [dbo].[Usuario] ([NombreUsuario], [Contraseña], [IdUsuario], [TipoUsuario], [idPersona]) VALUES (N' seby', N'gimenez', 3013, 1, 2013)
INSERT [dbo].[Usuario] ([NombreUsuario], [Contraseña], [IdUsuario], [TipoUsuario], [idPersona]) VALUES (N'USU', N'CON', 4019, 2, 3019)
INSERT [dbo].[Usuario] ([NombreUsuario], [Contraseña], [IdUsuario], [TipoUsuario], [idPersona]) VALUES (N'su', N'su', 4023, 2, 3023)
INSERT [dbo].[Usuario] ([NombreUsuario], [Contraseña], [IdUsuario], [TipoUsuario], [idPersona]) VALUES (N'pepe', N'pepe', 4024, 1, 3024)
INSERT [dbo].[Usuario] ([NombreUsuario], [Contraseña], [IdUsuario], [TipoUsuario], [idPersona]) VALUES (N'jj', N'jjjj', 4030, 1, 3031)
INSERT [dbo].[Usuario] ([NombreUsuario], [Contraseña], [IdUsuario], [TipoUsuario], [idPersona]) VALUES (N't', N't', 4033, 2, 3034)
SET IDENTITY_INSERT [dbo].[Usuario] OFF
ALTER TABLE [dbo].[Alumno_Inscripcion]  WITH CHECK ADD  CONSTRAINT [FK_Alumno_Inscripcion_Curso] FOREIGN KEY([idCurso])
REFERENCES [dbo].[Curso] ([idCurso])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Alumno_Inscripcion] CHECK CONSTRAINT [FK_Alumno_Inscripcion_Curso]
GO
ALTER TABLE [dbo].[Alumno_Inscripcion]  WITH CHECK ADD  CONSTRAINT [FK_Alumno_Inscripcion_Persona] FOREIGN KEY([idAlumno])
REFERENCES [dbo].[Persona] ([idPersona])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Alumno_Inscripcion] CHECK CONSTRAINT [FK_Alumno_Inscripcion_Persona]
GO
ALTER TABLE [dbo].[Curso]  WITH CHECK ADD  CONSTRAINT [FK_Curso_Comision] FOREIGN KEY([idComision])
REFERENCES [dbo].[Comision] ([idComision])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Curso] CHECK CONSTRAINT [FK_Curso_Comision]
GO
ALTER TABLE [dbo].[Curso]  WITH CHECK ADD  CONSTRAINT [FK_Curso_Materia] FOREIGN KEY([idMateria])
REFERENCES [dbo].[Materia] ([idMateria])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Curso] CHECK CONSTRAINT [FK_Curso_Materia]
GO
ALTER TABLE [dbo].[Docente_Curso]  WITH CHECK ADD  CONSTRAINT [FK_Docente_Curso_Curso] FOREIGN KEY([idCurso])
REFERENCES [dbo].[Curso] ([idCurso])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Docente_Curso] CHECK CONSTRAINT [FK_Docente_Curso_Curso]
GO
ALTER TABLE [dbo].[Docente_Curso]  WITH CHECK ADD  CONSTRAINT [FK_Docente_Curso_Persona] FOREIGN KEY([idDocente])
REFERENCES [dbo].[Persona] ([idPersona])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Docente_Curso] CHECK CONSTRAINT [FK_Docente_Curso_Persona]
GO
ALTER TABLE [dbo].[Materia]  WITH CHECK ADD  CONSTRAINT [FK_Materia_Planes] FOREIGN KEY([idPlan])
REFERENCES [dbo].[Planes] ([idPlan])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Materia] CHECK CONSTRAINT [FK_Materia_Planes]
GO
ALTER TABLE [dbo].[Planes]  WITH CHECK ADD  CONSTRAINT [FK_Planes_Especialidad] FOREIGN KEY([idEsp])
REFERENCES [dbo].[Especialidad] ([idEspecialidad])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Planes] CHECK CONSTRAINT [FK_Planes_Especialidad]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Persona] FOREIGN KEY([idPersona])
REFERENCES [dbo].[Persona] ([idPersona])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Persona]
GO
USE [master]
GO
ALTER DATABASE [NET TP2] SET  READ_WRITE 
GO
