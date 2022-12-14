/*    ==ScriptingParameters==

    SourceServerVersion : SQL Server 2012 (11.0.3000)
    SourceDatabaseEngineEdition : Microsoft SQL Server Express Edition
    SourceDatabaseEngineType : SQL Server independiente

    TargetServerVersion : SQL Server 2017
    TargetDatabaseEngineEdition : Microsoft SQL Server Standard Edition
    TargetDatabaseEngineType : SQL Server independiente
*/
USE [AlquilerHD]
GO
/****** Object:  Table [dbo].[Alquileres]    Script Date: 28/04/2020 12:45:48 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alquileres](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[FK_id_usuario] [int] NOT NULL,
	[FK_id_cliente] [int] NOT NULL,
	[FechaEntrega] [datetime] NOT NULL,
	[FechaDevolucion] [datetime] NOT NULL,
	[Estado] [bit] NOT NULL,
	[Total] [int] NOT NULL,
 CONSTRAINT [PK_Alquileres] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 28/04/2020 12:45:48 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Apellido] [nvarchar](50) NOT NULL,
	[Dni] [int] NOT NULL,
	[Direccion] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Celular/Telefono] [int] NOT NULL,
	[Estado] [bit] NOT NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Detalle]    Script Date: 28/04/2020 12:45:48 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalle](
	[FK_id_alquileres] [int] NOT NULL,
	[FK_id_peliculas] [int] NOT NULL,
	[idDetalle] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK__Detalle__49CAE2FB89849F7A] PRIMARY KEY CLUSTERED 
(
	[idDetalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pagos]    Script Date: 28/04/2020 12:45:48 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pagos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[tipo] [varchar](50) NOT NULL,
	[monto] [int] NOT NULL,
	[FK_id_Alquiler] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Peliculas]    Script Date: 28/04/2020 12:45:48 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Peliculas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Genero] [varchar](50) NOT NULL,
	[Duracion] [int] NOT NULL,
	[Pais] [varchar](50) NOT NULL,
	[Sinopsis] [varchar](50) NOT NULL,
	[Precio] [int] NOT NULL,
	[Imagen] [image] NOT NULL,
	[Estado] [bit] NOT NULL,
	[Stock] [int] NOT NULL,
 CONSTRAINT [PK_Peliculas] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 28/04/2020 12:45:48 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Contraseña] [nvarchar](50) NOT NULL,
	[Tipo] [nvarchar](50) NOT NULL,
	[Dni] [int] NOT NULL,
	[Estado] [bit] NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Alquileres]  WITH CHECK ADD FOREIGN KEY([FK_id_usuario])
REFERENCES [dbo].[Usuarios] ([id])
GO
ALTER TABLE [dbo].[Alquileres]  WITH CHECK ADD FOREIGN KEY([FK_id_cliente])
REFERENCES [dbo].[Clientes] ([id])
GO
ALTER TABLE [dbo].[Detalle]  WITH CHECK ADD  CONSTRAINT [FK__Detalle__FK_id_a__02FC7413] FOREIGN KEY([FK_id_alquileres])
REFERENCES [dbo].[Alquileres] ([id])
GO
ALTER TABLE [dbo].[Detalle] CHECK CONSTRAINT [FK__Detalle__FK_id_a__02FC7413]
GO
ALTER TABLE [dbo].[Detalle]  WITH CHECK ADD  CONSTRAINT [FK__Detalle__FK_id_p__03F0984C] FOREIGN KEY([FK_id_peliculas])
REFERENCES [dbo].[Peliculas] ([id])
GO
ALTER TABLE [dbo].[Detalle] CHECK CONSTRAINT [FK__Detalle__FK_id_p__03F0984C]
GO
ALTER TABLE [dbo].[Pagos]  WITH CHECK ADD FOREIGN KEY([FK_id_Alquiler])
REFERENCES [dbo].[Alquileres] ([id])
GO
