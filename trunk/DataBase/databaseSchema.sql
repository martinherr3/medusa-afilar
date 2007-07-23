DROP DATABASE [Afilar]
GO
CREATE DATABASE [Afilar]
GO
USE [Afilar]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[estado]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[estado](
	[idestado] [int] NOT NULL,
	[nombre] [char](40) NULL,
	[descripcion] [char](40) NULL,
 CONSTRAINT [PK_estado] PRIMARY KEY CLUSTERED 
(
	[idestado] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[provincia]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[provincia](
	[idprovincia] [int] NOT NULL,
	[nombre] [char](20) NULL,
	[descripcion] [char](30) NULL,
 CONSTRAINT [PK_provincia] PRIMARY KEY CLUSTERED 
(
	[idprovincia] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tornero]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tornero](
	[idtornero] [int] NOT NULL,
	[nombre] [char](50) NULL,
	[apellido] [char](50) NULL,
	[domicilio] [char](50) NULL,
	[telefono] [char](25) NULL,
	[celular] [char](25) NULL,
	[cantidadtorneados] [int] NULL,
	[efectividad] [float] NULL,
	[observaciones] [text] NULL,
 CONSTRAINT [PK_tornero] PRIMARY KEY CLUSTERED 
(
	[idtornero] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tipodocumento]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tipodocumento](
	[idtipodocumento] [int] NOT NULL,
	[nombre] [char](10) NULL,
	[descipcion] [char](10) NULL,
 CONSTRAINT [PK_tipodocumento] PRIMARY KEY CLUSTERED 
(
	[idtipodocumento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[cargo]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[cargo](
	[idcargo] [int] NOT NULL,
	[nombre] [char](20) NULL,
	[descripcion] [char](20) NULL,
 CONSTRAINT [PK_cargo] PRIMARY KEY CLUSTERED 
(
	[idcargo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tipoacabado]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tipoacabado](
	[nombre] [char](40) NOT NULL,
	[descripcion] [char](10) NULL,
 CONSTRAINT [PK_tipoacabado] PRIMARY KEY CLUSTERED 
(
	[nombre] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[mododeavance]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[mododeavance](
	[nombre] [char](40) NOT NULL,
	[descripcion] [char](10) NULL,
 CONSTRAINT [PK_mododeavance] PRIMARY KEY CLUSTERED 
(
	[nombre] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[empresatransporte]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[empresatransporte](
	[nombre] [char](30) NULL,
	[direccion] [char](50) NULL,
	[telefono] [char](15) NULL,
	[idempresa] [int] NOT NULL,
 CONSTRAINT [PK_empresatransporte] PRIMARY KEY CLUSTERED 
(
	[idempresa] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[materialatrabajar]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[materialatrabajar](
	[nombre] [char](40) NOT NULL,
	[descripcion] [text] NULL,
 CONSTRAINT [PK_materialatrabajar] PRIMARY KEY CLUSTERED 
(
	[nombre] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[gradodificultad]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[gradodificultad](
	[idgradodificultad] [int] NOT NULL,
	[nombre] [char](20) NULL,
	[descripcion] [text] NULL,
 CONSTRAINT [PK_gradodificultad] PRIMARY KEY CLUSTERED 
(
	[idgradodificultad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tipoparte]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tipoparte](
	[nombre] [char](40) NOT NULL,
	[descripcion] [text] NULL,
 CONSTRAINT [PK_tipoparte] PRIMARY KEY CLUSTERED 
(
	[nombre] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tipomaquina]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tipomaquina](
	[nombre] [char](40) NOT NULL,
	[descripcion] [text] NULL,
	[idtipo] [int] NULL,
 CONSTRAINT [PK_tipomaquina] PRIMARY KEY CLUSTERED 
(
	[nombre] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[modulo]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[modulo](
	[idmodulo] [int] NOT NULL,
	[descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_modulo] PRIMARY KEY CLUSTERED 
(
	[idmodulo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[unidaddemedida]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[unidaddemedida](
	[idunidadmedida] [int] NOT NULL,
	[nombre] [char](20) NULL,
	[descripcion] [char](20) NULL,
	[abreviacion] [char](20) NULL,
	[escala] [char](20) NULL,
 CONSTRAINT [PK_unidaddemedida] PRIMARY KEY CLUSTERED 
(
	[idunidadmedida] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[menupadre]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[menupadre](
	[idmenu] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[activo] [bit] NULL,
 CONSTRAINT [PK_menupadre] PRIMARY KEY CLUSTERED 
(
	[idmenu] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ordencompramp]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ordencompramp](
	[fecharealizacion] [datetime] NULL,
	[plazodeentrega] [datetime] NULL,
	[idordencompra] [int] NOT NULL,
	[nroorden] [int] NULL,
	[condicionesdepago] [char](40) NULL,
	[causa] [char](40) NULL,
	[idestado] [int] NULL,
	[idproveedor] [int] NULL,
 CONSTRAINT [PK_ordencompramp] PRIMARY KEY CLUSTERED 
(
	[idordencompra] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[hojaderuta]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[hojaderuta](
	[idhojaderuta] [int] NOT NULL,
	[fechainicioproduccion] [datetime] NULL,
 CONSTRAINT [PK_hojaderuta] PRIMARY KEY CLUSTERED 
(
	[idhojaderuta] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tipodesperfecto]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tipodesperfecto](
	[idtipodesperfecto] [int] NOT NULL,
	[nombre] [char](20) NULL,
	[descripcion] [char](30) NULL,
 CONSTRAINT [PK_tipodesperfecto] PRIMARY KEY CLUSTERED 
(
	[idtipodesperfecto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[formadeentrega]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[formadeentrega](
	[idformadeentrega] [int] NOT NULL,
	[nombre] [char](20) NULL,
	[descripcion] [char](10) NULL,
 CONSTRAINT [PK_formadeentrega] PRIMARY KEY CLUSTERED 
(
	[idformadeentrega] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[maquinaFresa]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[maquinaFresa](
	[idmaquina] [int] NOT NULL,
	[nombre] [text] NOT NULL,
	[potencia] [float] NULL,
	[rpmdeleje] [float] NULL,
	[sentidodegiro] [char](30) NULL,
	[caracteristicas] [text] NULL,
	[estado] [char](25) NULL,
 CONSTRAINT [PK_maquinaFresa] PRIMARY KEY CLUSTERED 
(
	[idmaquina] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[objetodelservicio]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[objetodelservicio](
	[idobjetodelservicio] [int] NOT NULL,
	[nombre] [char](20) NULL,
	[descripcion] [char](30) NULL,
	[nroserie] [int] NULL,
	[cantidad] [int] NULL,
 CONSTRAINT [PK_objetodelservicio] PRIMARY KEY CLUSTERED 
(
	[idobjetodelservicio] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Pedido]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Pedido](
	[idpedido] [numeric](18, 0) NOT NULL,
	[fechaentrega] [datetime] NULL,
	[fecharealizacion] [datetime] NULL,
	[idestado] [int] NULL,
	[prioridad] [int] NULL,
	[idcliente] [int] NULL,
	[idvendedor] [int] NULL,
	[idformadeentrega] [int] NULL,
	[idempresa] [int] NULL,
	[idviajante] [int] NULL,
	[fecharealentrega] [datetime] NULL,
 CONSTRAINT [PK_Pedido] PRIMARY KEY CLUSTERED 
(
	[idpedido] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[detalleordencompra]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[detalleordencompra](
	[idordencompra] [int] NOT NULL,
	[idtipomateriaprima] [int] NOT NULL,
	[cantidad] [int] NULL,
	[precio] [float] NULL,
	[idestado] [int] NOT NULL,
 CONSTRAINT [PK_detalleordencompra] PRIMARY KEY CLUSTERED 
(
	[idordencompra] ASC,
	[idtipomateriaprima] ASC,
	[idestado] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fresa]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[fresa](
	[nroserie] [int] NOT NULL,
	[fechafinfabricacion] [datetime] NULL,
	[costofabricacion] [decimal](18, 0) NULL,
	[estado] [int] NULL,
	[nropedido] [numeric](18, 0) NOT NULL,
	[controlcalidad] [int] NULL,
	[idhojaderuta] [int] NULL,
	[precio] [decimal](18, 0) NULL,
	[idtipo] [int] NULL,
	[idmodelo] [int] NULL,
 CONSTRAINT [PK_fresa] PRIMARY KEY CLUSTERED 
(
	[nroserie] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[detallemprecibida]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[detallemprecibida](
	[idmprecibida] [int] NOT NULL,
	[cantidad] [int] NULL,
	[preciol] [float] NULL,
	[causarechazo] [char](20) NULL,
	[idestado] [int] NULL,
	[idtipomateriaprima] [int] NOT NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[localidad]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[localidad](
	[idlocalidad] [int] NOT NULL,
	[codigopostal] [int] NULL,
	[zona] [char](20) NULL,
	[provincia] [char](20) NULL,
	[distancia] [char](20) NULL,
	[nombre] [char](20) NULL,
	[idprovincia] [int] NULL,
 CONSTRAINT [PK_localidad] PRIMARY KEY CLUSTERED 
(
	[idlocalidad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[torneado]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[torneado](
	[idtorneado] [int] NOT NULL,
	[fechasalidad] [datetime] NULL,
	[fecharecepcion] [datetime] NULL,
	[idtornero] [int] NULL,
	[costo] [float] NULL,
 CONSTRAINT [PK_torneado] PRIMARY KEY CLUSTERED 
(
	[idtorneado] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[cliente]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[cliente](
	[idcliente] [int] NOT NULL,
	[nombre] [char](50) NOT NULL,
	[apellido] [char](50) NULL,
	[idtipodocumento] [int] NULL,
	[direccion] [char](50) NULL,
	[localidad] [int] NULL,
	[mail] [char](50) NULL,
	[telefono] [char](20) NULL,
	[documento] [numeric](18, 0) NULL,
	[celular] [char](20) NULL,
 CONSTRAINT [PK_cliente] PRIMARY KEY CLUSTERED 
(
	[idcliente] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[empleado]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[empleado](
	[idlegajo] [int] NOT NULL,
	[nombre] [char](50) NULL,
	[apellido] [char](50) NULL,
	[direccion] [char](20) NULL,
	[telefono] [char](20) NULL,
	[idcargo] [int] NULL,
	[email] [char](30) NULL,
	[titulo] [char](30) NULL,
	[idlocalidad] [int] NULL,
	[turno] [char](30) NULL,
 CONSTRAINT [PK_empleado] PRIMARY KEY CLUSTERED 
(
	[idlegajo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[modelofresa]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[modelofresa](
	[idmodelo] [int] NOT NULL,
	[nombre] [char](40) NULL,
	[grupomodelo] [char](50) NULL,
	[descripcion] [text] NULL,
	[materialatrabajar] [char](40) NULL,
	[mododeavance] [char](40) NULL,
	[tipoacabado] [char](40) NULL,
	[velocidaddeavance] [float] NULL,
	[tipomodelo] [char](40) NULL,
	[precio] [float] NULL,
	[estado] [char](15) NULL,
 CONSTRAINT [PK_modelofresa] PRIMARY KEY CLUSTERED 
(
	[idmodelo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[empresaxlocalidad]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[empresaxlocalidad](
	[idempresa] [int] NOT NULL,
	[idlocalidad] [int] NOT NULL,
 CONSTRAINT [PK_empresaxlocalidad] PRIMARY KEY CLUSTERED 
(
	[idempresa] ASC,
	[idlocalidad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[operacion]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[operacion](
	[idoperacion] [int] NOT NULL,
	[nombre] [char](40) NULL,
	[maquina] [char](40) NULL,
	[duracionpromedio] [float] NULL,
	[idgradodificultad] [int] NULL,
	[tolerancia] [float] NULL,
	[descripcion] [text] NULL,
 CONSTRAINT [PK_operacion] PRIMARY KEY CLUSTERED 
(
	[idoperacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MPxTP]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[MPxTP](
	[nombre] [char](40) NOT NULL,
	[idmp] [int] NOT NULL,
 CONSTRAINT [PK_MPxTP] PRIMARY KEY CLUSTERED 
(
	[nombre] ASC,
	[idmp] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[parte]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[parte](
	[idmodelo] [int] NOT NULL,
	[idtipofresa] [int] NOT NULL,
	[idparte] [int] NOT NULL,
	[cantidad] [float] NULL,
	[nombre] [char](40) NULL,
	[descripcion] [text] NULL,
	[idtipomateriaprima] [int] NULL,
 CONSTRAINT [PK_parte] PRIMARY KEY CLUSTERED 
(
	[idtipofresa] ASC,
	[idparte] ASC,
	[idmodelo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[maquina]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[maquina](
	[idmaquina] [int] NOT NULL,
	[nombre] [char](40) NOT NULL,
	[descripcion] [text] NULL,
	[numerodeserie] [char](20) NULL,
	[potencia] [char](20) NULL,
	[costodecompra] [decimal](18, 0) NULL,
	[estadodeadquisicion] [char](20) NULL,
	[idestado] [int] NULL,
	[horasdeuso] [datetime] NULL,
	[tipomaquina] [char](40) NULL,
 CONSTRAINT [PK_maquina] PRIMARY KEY CLUSTERED 
(
	[idmaquina] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[formulario]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[formulario](
	[idformulario] [int] NOT NULL,
	[descripcion] [char](50) NULL,
	[idmodulo] [int] NULL,
	[nombre] [char](50) NOT NULL,
	[idmenu] [int] NULL,
	[activo] [bit] NULL,
 CONSTRAINT [PK_formulario] PRIMARY KEY CLUSTERED 
(
	[idformulario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tipomateriaprima]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tipomateriaprima](
	[idtipomateriaprima] [int] NOT NULL,
	[nombre] [char](40) NULL,
	[direccion] [char](40) NULL,
	[stockactual] [int] NULL,
	[stockminimo] [int] NULL,
	[stockseguridad] [int] NULL,
	[loteeconomico] [int] NULL,
	[idunidadmedida] [int] NULL,
 CONSTRAINT [PK_tipomateriaprima] PRIMARY KEY CLUSTERED 
(
	[idtipomateriaprima] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[mprecibida]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[mprecibida](
	[idmprecibida] [int] NOT NULL,
	[fecharecepcion] [char](20) NULL,
	[numremito] [int] NULL,
	[idordencompramp] [int] NULL,
 CONSTRAINT [PK_mprecibida] PRIMARY KEY CLUSTERED 
(
	[idmprecibida] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pago]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[pago](
	[monto] [float] NULL,
	[fechadepago] [datetime] NULL,
	[formadepago] [char](10) NULL,
	[idordencompra] [int] NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[detalleordenservicio]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[detalleordenservicio](
	[idpedido] [numeric](18, 0) NOT NULL,
	[idoperacion] [int] NOT NULL,
	[idobjetodelservicio] [int] NOT NULL,
	[preciodeservicio] [decimal](18, 0) NULL,
	[observacion] [char](30) NULL,
	[idhojaderuta] [int] NULL,
	[precio] [decimal](18, 0) NULL,
 CONSTRAINT [PK_detalleordenservicio] PRIMARY KEY CLUSTERED 
(
	[idpedido] ASC,
	[idoperacion] ASC,
	[idobjetodelservicio] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[detallehojaderuta]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[detallehojaderuta](
	[idhojaderuta] [int] NOT NULL,
	[idetapadefabricacion] [int] NOT NULL,
	[idlegajo] [int] NULL,
	[idtorneado] [int] NULL,
	[fechahorainicioreal] [datetime] NULL,
	[fechahorainicioplanificada] [datetime] NULL,
	[fechahorafinreal] [datetime] NULL,
	[fechahorafinplanificada] [datetime] NULL,
	[observaciones] [char](30) NULL,
 CONSTRAINT [PK_detallehojaderuta] PRIMARY KEY CLUSTERED 
(
	[idhojaderuta] ASC,
	[idetapadefabricacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[desperfecto]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[desperfecto](
	[iddesperfecto] [int] NOT NULL,
	[idtipodesperfecto] [int] NULL,
	[fecharotura] [datetime] NULL,
	[causa] [char](30) NULL,
	[fechareparacion] [datetime] NULL,
	[costo] [decimal](18, 0) NULL,
	[idmaquina] [int] NULL,
 CONSTRAINT [PK_desperfecto] PRIMARY KEY CLUSTERED 
(
	[iddesperfecto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[partepedido]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[partepedido](
	[idpedido] [numeric](18, 0) NOT NULL,
	[idpartepedida] [int] NOT NULL,
	[idmodelo] [int] NULL,
	[idadicional] [int] NULL,
	[cantidad] [int] NULL,
	[precio] [decimal](18, 0) NULL,
 CONSTRAINT [PK_partepedido] PRIMARY KEY CLUSTERED 
(
	[idpedido] ASC,
	[idpartepedida] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[controlcalidad]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[controlcalidad](
	[idcontrol] [int] NOT NULL,
	[observaciones] [char](250) NULL,
	[medidas] [char](10) NULL,
	[pintura] [char](10) NULL,
	[soldadura] [char](10) NULL,
	[torneado] [char](10) NULL,
	[idfresa] [int] NULL,
	[fechahoracontrol] [nvarchar](50) NULL,
 CONSTRAINT [PK_controlcalidad] PRIMARY KEY CLUSTERED 
(
	[idcontrol] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[viajantexlocalidad]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[viajantexlocalidad](
	[idviajante] [int] NOT NULL,
	[idlocalidad] [int] NOT NULL,
 CONSTRAINT [PK_viajantexlocalidad] PRIMARY KEY CLUSTERED 
(
	[idviajante] ASC,
	[idlocalidad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proveedor]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[proveedor](
	[idproveedor] [int] NOT NULL,
	[nombre] [char](80) NULL,
	[direccion] [char](80) NULL,
	[telefono] [char](20) NULL,
	[mail] [char](80) NULL,
	[nombrecontacto] [char](80) NULL,
	[idlocalidad] [int] NULL,
 CONSTRAINT [PK_proveedor] PRIMARY KEY CLUSTERED 
(
	[idproveedor] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[presupuesto]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[presupuesto](
	[idpresupuesto] [int] NOT NULL,
	[fecha] [datetime] NULL,
	[idcliente] [int] NULL,
	[idempleado] [int] NULL,
 CONSTRAINT [PK_presupuesto] PRIMARY KEY CLUSTERED 
(
	[idpresupuesto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[formxempleado]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[formxempleado](
	[idformulario] [int] NOT NULL,
	[idlegajo] [int] NOT NULL,
 CONSTRAINT [PK_formxempleado] PRIMARY KEY CLUSTERED 
(
	[idformulario] ASC,
	[idlegajo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[cuentausuario]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[cuentausuario](
	[usuario] [char](6) NOT NULL,
	[contraseña] [char](100) NOT NULL,
	[creacion] [datetime] NULL,
	[idlegajo] [int] NOT NULL,
 CONSTRAINT [PK_cuentausuario] PRIMARY KEY CLUSTERED 
(
	[usuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[perfil]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[perfil](
	[idperfil] [int] NOT NULL,
	[descripcion] [char](50) NULL,
	[idlegajo] [int] NULL,
 CONSTRAINT [PK_perfil] PRIMARY KEY CLUSTERED 
(
	[idperfil] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tipofresa]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tipofresa](
	[idtipo] [int] NOT NULL,
	[idmodelo] [int] NOT NULL,
	[nombre] [char](20) NULL,
	[diametroexterior] [decimal](18, 0) NULL,
	[diametroagujero] [decimal](18, 0) NULL,
	[cantidaddientes] [int] NULL,
	[plano] [char](80) NULL,
	[posiciondetrabajo] [char](40) NULL,
	[caracteristicas] [text] NULL,
	[costo] [decimal](18, 0) NULL,
	[precio] [decimal](18, 0) NULL,
	[estado] [char](15) NULL,
 CONSTRAINT [PK_tipofresa] PRIMARY KEY CLUSTERED 
(
	[idtipo] ASC,
	[idmodelo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[parteadicional]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[parteadicional](
	[idadicional] [int] NOT NULL,
	[idmodelo] [int] NOT NULL,
	[nombre] [char](60) NULL,
	[plano] [char](80) NULL,
	[imagen] [image] NULL,
	[idmateriaprima] [int] NULL,
	[cantidad] [float] NULL,
	[descripcion] [text] NULL,
	[tiempo] [float] NULL,
	[costo] [float] NULL,
	[precio] [float] NULL,
 CONSTRAINT [PK_parteadicional] PRIMARY KEY CLUSTERED 
(
	[idadicional] ASC,
	[idmodelo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fresaxmaquina]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[fresaxmaquina](
	[idmodelo] [int] NOT NULL,
	[idmaquina] [int] NOT NULL,
 CONSTRAINT [PK_fresaxmaquina] PRIMARY KEY CLUSTERED 
(
	[idmodelo] ASC,
	[idmaquina] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[etapadefabricacion]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[etapadefabricacion](
	[idetapafabricacion] [int] NOT NULL,
	[idmodelo] [int] NOT NULL,
	[idtipofresa] [int] NOT NULL,
	[idoperacion] [int] NULL,
	[orden] [int] NULL,
	[tiempoadicional] [float] NULL,
	[detalle] [text] NULL,
 CONSTRAINT [PK_etapadefabricacion] PRIMARY KEY CLUSTERED 
(
	[idetapafabricacion] ASC,
	[idtipofresa] ASC,
	[idmodelo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[formxperfil]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[formxperfil](
	[idformulario] [int] NOT NULL,
	[idperfil] [int] NOT NULL,
 CONSTRAINT [PK_formxperfil] PRIMARY KEY CLUSTERED 
(
	[idformulario] ASC,
	[idperfil] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proveedorxtipomateriaprima]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[proveedorxtipomateriaprima](
	[idproveedor] [int] NOT NULL,
	[idtipomateriaprima] [int] NOT NULL,
 CONSTRAINT [PK_proveedorxtipomateriaprima] PRIMARY KEY CLUSTERED 
(
	[idproveedor] ASC,
	[idtipomateriaprima] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[detallepresupuesto]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[detallepresupuesto](
	[iddetpre] [int] NOT NULL,
	[idpresupuesto] [int] NOT NULL,
	[idmodelo] [int] NULL,
	[idproducto] [int] NULL,
	[tipo] [int] NULL,
	[cantidad] [int] NULL,
	[precio] [float] NULL,
 CONSTRAINT [PK_detallepresupuesto] PRIMARY KEY CLUSTERED 
(
	[idpresupuesto] ASC,
	[iddetpre] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Pedido_cliente]') AND parent_object_id = OBJECT_ID(N'[dbo].[Pedido]'))
ALTER TABLE [dbo].[Pedido]  WITH NOCHECK ADD  CONSTRAINT [FK_Pedido_cliente] FOREIGN KEY([idcliente])
REFERENCES [dbo].[cliente] ([idcliente])
GO
ALTER TABLE [dbo].[Pedido] CHECK CONSTRAINT [FK_Pedido_cliente]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Pedido_empleado]') AND parent_object_id = OBJECT_ID(N'[dbo].[Pedido]'))
ALTER TABLE [dbo].[Pedido]  WITH NOCHECK ADD  CONSTRAINT [FK_Pedido_empleado] FOREIGN KEY([idvendedor])
REFERENCES [dbo].[empleado] ([idlegajo])
GO
ALTER TABLE [dbo].[Pedido] CHECK CONSTRAINT [FK_Pedido_empleado]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Pedido_empresatransporte]') AND parent_object_id = OBJECT_ID(N'[dbo].[Pedido]'))
ALTER TABLE [dbo].[Pedido]  WITH NOCHECK ADD  CONSTRAINT [FK_Pedido_empresatransporte] FOREIGN KEY([idempresa])
REFERENCES [dbo].[empresatransporte] ([idempresa])
GO
ALTER TABLE [dbo].[Pedido] CHECK CONSTRAINT [FK_Pedido_empresatransporte]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Pedido_estado]') AND parent_object_id = OBJECT_ID(N'[dbo].[Pedido]'))
ALTER TABLE [dbo].[Pedido]  WITH NOCHECK ADD  CONSTRAINT [FK_Pedido_estado] FOREIGN KEY([idestado])
REFERENCES [dbo].[estado] ([idestado])
GO
ALTER TABLE [dbo].[Pedido] CHECK CONSTRAINT [FK_Pedido_estado]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Pedido_formadeentrega]') AND parent_object_id = OBJECT_ID(N'[dbo].[Pedido]'))
ALTER TABLE [dbo].[Pedido]  WITH NOCHECK ADD  CONSTRAINT [FK_Pedido_formadeentrega] FOREIGN KEY([idformadeentrega])
REFERENCES [dbo].[formadeentrega] ([idformadeentrega])
GO
ALTER TABLE [dbo].[Pedido] CHECK CONSTRAINT [FK_Pedido_formadeentrega]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_detalleordencompra_estado]') AND parent_object_id = OBJECT_ID(N'[dbo].[detalleordencompra]'))
ALTER TABLE [dbo].[detalleordencompra]  WITH NOCHECK ADD  CONSTRAINT [FK_detalleordencompra_estado] FOREIGN KEY([idestado])
REFERENCES [dbo].[estado] ([idestado])
GO
ALTER TABLE [dbo].[detalleordencompra] CHECK CONSTRAINT [FK_detalleordencompra_estado]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_detalleordencompra_ordencompramp1]') AND parent_object_id = OBJECT_ID(N'[dbo].[detalleordencompra]'))
ALTER TABLE [dbo].[detalleordencompra]  WITH NOCHECK ADD  CONSTRAINT [FK_detalleordencompra_ordencompramp1] FOREIGN KEY([idordencompra])
REFERENCES [dbo].[ordencompramp] ([idordencompra])
GO
ALTER TABLE [dbo].[detalleordencompra] CHECK CONSTRAINT [FK_detalleordencompra_ordencompramp1]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_detalleordencompra_tipomateriaprima]') AND parent_object_id = OBJECT_ID(N'[dbo].[detalleordencompra]'))
ALTER TABLE [dbo].[detalleordencompra]  WITH NOCHECK ADD  CONSTRAINT [FK_detalleordencompra_tipomateriaprima] FOREIGN KEY([idtipomateriaprima])
REFERENCES [dbo].[tipomateriaprima] ([idtipomateriaprima])
GO
ALTER TABLE [dbo].[detalleordencompra] CHECK CONSTRAINT [FK_detalleordencompra_tipomateriaprima]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_fresa_estado]') AND parent_object_id = OBJECT_ID(N'[dbo].[fresa]'))
ALTER TABLE [dbo].[fresa]  WITH NOCHECK ADD  CONSTRAINT [FK_fresa_estado] FOREIGN KEY([estado])
REFERENCES [dbo].[estado] ([idestado])
GO
ALTER TABLE [dbo].[fresa] CHECK CONSTRAINT [FK_fresa_estado]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_fresa_hojaderuta]') AND parent_object_id = OBJECT_ID(N'[dbo].[fresa]'))
ALTER TABLE [dbo].[fresa]  WITH NOCHECK ADD  CONSTRAINT [FK_fresa_hojaderuta] FOREIGN KEY([idhojaderuta])
REFERENCES [dbo].[hojaderuta] ([idhojaderuta])
GO
ALTER TABLE [dbo].[fresa] CHECK CONSTRAINT [FK_fresa_hojaderuta]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_fresa_Pedido]') AND parent_object_id = OBJECT_ID(N'[dbo].[fresa]'))
ALTER TABLE [dbo].[fresa]  WITH NOCHECK ADD  CONSTRAINT [FK_fresa_Pedido] FOREIGN KEY([nropedido])
REFERENCES [dbo].[Pedido] ([idpedido])
GO
ALTER TABLE [dbo].[fresa] CHECK CONSTRAINT [FK_fresa_Pedido]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_fresa_tipofresa]') AND parent_object_id = OBJECT_ID(N'[dbo].[fresa]'))
ALTER TABLE [dbo].[fresa]  WITH NOCHECK ADD  CONSTRAINT [FK_fresa_tipofresa] FOREIGN KEY([idtipo], [idmodelo])
REFERENCES [dbo].[tipofresa] ([idtipo], [idmodelo])
GO
ALTER TABLE [dbo].[fresa] CHECK CONSTRAINT [FK_fresa_tipofresa]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_detallemprecibida_estado1]') AND parent_object_id = OBJECT_ID(N'[dbo].[detallemprecibida]'))
ALTER TABLE [dbo].[detallemprecibida]  WITH NOCHECK ADD  CONSTRAINT [FK_detallemprecibida_estado1] FOREIGN KEY([idestado])
REFERENCES [dbo].[estado] ([idestado])
GO
ALTER TABLE [dbo].[detallemprecibida] CHECK CONSTRAINT [FK_detallemprecibida_estado1]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_detallemprecibida_mprecibida]') AND parent_object_id = OBJECT_ID(N'[dbo].[detallemprecibida]'))
ALTER TABLE [dbo].[detallemprecibida]  WITH NOCHECK ADD  CONSTRAINT [FK_detallemprecibida_mprecibida] FOREIGN KEY([idmprecibida])
REFERENCES [dbo].[mprecibida] ([idmprecibida])
GO
ALTER TABLE [dbo].[detallemprecibida] CHECK CONSTRAINT [FK_detallemprecibida_mprecibida]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_detallemprecibida_mprecibida1]') AND parent_object_id = OBJECT_ID(N'[dbo].[detallemprecibida]'))
ALTER TABLE [dbo].[detallemprecibida]  WITH NOCHECK ADD  CONSTRAINT [FK_detallemprecibida_mprecibida1] FOREIGN KEY([idmprecibida])
REFERENCES [dbo].[mprecibida] ([idmprecibida])
GO
ALTER TABLE [dbo].[detallemprecibida] CHECK CONSTRAINT [FK_detallemprecibida_mprecibida1]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_detallemprecibida_tipomateriaprima]') AND parent_object_id = OBJECT_ID(N'[dbo].[detallemprecibida]'))
ALTER TABLE [dbo].[detallemprecibida]  WITH NOCHECK ADD  CONSTRAINT [FK_detallemprecibida_tipomateriaprima] FOREIGN KEY([idtipomateriaprima])
REFERENCES [dbo].[tipomateriaprima] ([idtipomateriaprima])
GO
ALTER TABLE [dbo].[detallemprecibida] CHECK CONSTRAINT [FK_detallemprecibida_tipomateriaprima]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_localidad_provincia]') AND parent_object_id = OBJECT_ID(N'[dbo].[localidad]'))
ALTER TABLE [dbo].[localidad]  WITH NOCHECK ADD  CONSTRAINT [FK_localidad_provincia] FOREIGN KEY([idprovincia])
REFERENCES [dbo].[provincia] ([idprovincia])
GO
ALTER TABLE [dbo].[localidad] CHECK CONSTRAINT [FK_localidad_provincia]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_torneado_tornero]') AND parent_object_id = OBJECT_ID(N'[dbo].[torneado]'))
ALTER TABLE [dbo].[torneado]  WITH NOCHECK ADD  CONSTRAINT [FK_torneado_tornero] FOREIGN KEY([idtornero])
REFERENCES [dbo].[tornero] ([idtornero])
GO
ALTER TABLE [dbo].[torneado] CHECK CONSTRAINT [FK_torneado_tornero]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_cliente_localidad]') AND parent_object_id = OBJECT_ID(N'[dbo].[cliente]'))
ALTER TABLE [dbo].[cliente]  WITH NOCHECK ADD  CONSTRAINT [FK_cliente_localidad] FOREIGN KEY([localidad])
REFERENCES [dbo].[localidad] ([idlocalidad])
GO
ALTER TABLE [dbo].[cliente] CHECK CONSTRAINT [FK_cliente_localidad]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_cliente_tipodocumento]') AND parent_object_id = OBJECT_ID(N'[dbo].[cliente]'))
ALTER TABLE [dbo].[cliente]  WITH NOCHECK ADD  CONSTRAINT [FK_cliente_tipodocumento] FOREIGN KEY([idtipodocumento])
REFERENCES [dbo].[tipodocumento] ([idtipodocumento])
GO
ALTER TABLE [dbo].[cliente] CHECK CONSTRAINT [FK_cliente_tipodocumento]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_empleado_cargo]') AND parent_object_id = OBJECT_ID(N'[dbo].[empleado]'))
ALTER TABLE [dbo].[empleado]  WITH NOCHECK ADD  CONSTRAINT [FK_empleado_cargo] FOREIGN KEY([idcargo])
REFERENCES [dbo].[cargo] ([idcargo])
GO
ALTER TABLE [dbo].[empleado] CHECK CONSTRAINT [FK_empleado_cargo]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_empleado_localidad]') AND parent_object_id = OBJECT_ID(N'[dbo].[empleado]'))
ALTER TABLE [dbo].[empleado]  WITH NOCHECK ADD  CONSTRAINT [FK_empleado_localidad] FOREIGN KEY([idlocalidad])
REFERENCES [dbo].[localidad] ([idlocalidad])
GO
ALTER TABLE [dbo].[empleado] CHECK CONSTRAINT [FK_empleado_localidad]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_modelofresa_materialatrabajar]') AND parent_object_id = OBJECT_ID(N'[dbo].[modelofresa]'))
ALTER TABLE [dbo].[modelofresa]  WITH NOCHECK ADD  CONSTRAINT [FK_modelofresa_materialatrabajar] FOREIGN KEY([materialatrabajar])
REFERENCES [dbo].[materialatrabajar] ([nombre])
GO
ALTER TABLE [dbo].[modelofresa] CHECK CONSTRAINT [FK_modelofresa_materialatrabajar]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_modelofresa_mododeavance]') AND parent_object_id = OBJECT_ID(N'[dbo].[modelofresa]'))
ALTER TABLE [dbo].[modelofresa]  WITH NOCHECK ADD  CONSTRAINT [FK_modelofresa_mododeavance] FOREIGN KEY([mododeavance])
REFERENCES [dbo].[mododeavance] ([nombre])
GO
ALTER TABLE [dbo].[modelofresa] CHECK CONSTRAINT [FK_modelofresa_mododeavance]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_modelofresa_tipoacabado]') AND parent_object_id = OBJECT_ID(N'[dbo].[modelofresa]'))
ALTER TABLE [dbo].[modelofresa]  WITH NOCHECK ADD  CONSTRAINT [FK_modelofresa_tipoacabado] FOREIGN KEY([tipoacabado])
REFERENCES [dbo].[tipoacabado] ([nombre])
GO
ALTER TABLE [dbo].[modelofresa] CHECK CONSTRAINT [FK_modelofresa_tipoacabado]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_empresaxlocalidad_empresatransporte]') AND parent_object_id = OBJECT_ID(N'[dbo].[empresaxlocalidad]'))
ALTER TABLE [dbo].[empresaxlocalidad]  WITH NOCHECK ADD  CONSTRAINT [FK_empresaxlocalidad_empresatransporte] FOREIGN KEY([idempresa])
REFERENCES [dbo].[empresatransporte] ([idempresa])
GO
ALTER TABLE [dbo].[empresaxlocalidad] CHECK CONSTRAINT [FK_empresaxlocalidad_empresatransporte]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_empresaxlocalidad_localidad]') AND parent_object_id = OBJECT_ID(N'[dbo].[empresaxlocalidad]'))
ALTER TABLE [dbo].[empresaxlocalidad]  WITH NOCHECK ADD  CONSTRAINT [FK_empresaxlocalidad_localidad] FOREIGN KEY([idlocalidad])
REFERENCES [dbo].[localidad] ([idlocalidad])
GO
ALTER TABLE [dbo].[empresaxlocalidad] CHECK CONSTRAINT [FK_empresaxlocalidad_localidad]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_operacion_gradodificultad]') AND parent_object_id = OBJECT_ID(N'[dbo].[operacion]'))
ALTER TABLE [dbo].[operacion]  WITH NOCHECK ADD  CONSTRAINT [FK_operacion_gradodificultad] FOREIGN KEY([idgradodificultad])
REFERENCES [dbo].[gradodificultad] ([idgradodificultad])
GO
ALTER TABLE [dbo].[operacion] CHECK CONSTRAINT [FK_operacion_gradodificultad]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_operacion_tipomaquina]') AND parent_object_id = OBJECT_ID(N'[dbo].[operacion]'))
ALTER TABLE [dbo].[operacion]  WITH NOCHECK ADD  CONSTRAINT [FK_operacion_tipomaquina] FOREIGN KEY([maquina])
REFERENCES [dbo].[tipomaquina] ([nombre])
GO
ALTER TABLE [dbo].[operacion] CHECK CONSTRAINT [FK_operacion_tipomaquina]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MPxTP_tipomateriaprima]') AND parent_object_id = OBJECT_ID(N'[dbo].[MPxTP]'))
ALTER TABLE [dbo].[MPxTP]  WITH NOCHECK ADD  CONSTRAINT [FK_MPxTP_tipomateriaprima] FOREIGN KEY([idmp])
REFERENCES [dbo].[tipomateriaprima] ([idtipomateriaprima])
GO
ALTER TABLE [dbo].[MPxTP] CHECK CONSTRAINT [FK_MPxTP_tipomateriaprima]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MPxTP_tipoparte]') AND parent_object_id = OBJECT_ID(N'[dbo].[MPxTP]'))
ALTER TABLE [dbo].[MPxTP]  WITH NOCHECK ADD  CONSTRAINT [FK_MPxTP_tipoparte] FOREIGN KEY([nombre])
REFERENCES [dbo].[tipoparte] ([nombre])
GO
ALTER TABLE [dbo].[MPxTP] CHECK CONSTRAINT [FK_MPxTP_tipoparte]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_parte_tipofresa1]') AND parent_object_id = OBJECT_ID(N'[dbo].[parte]'))
ALTER TABLE [dbo].[parte]  WITH NOCHECK ADD  CONSTRAINT [FK_parte_tipofresa1] FOREIGN KEY([idtipofresa], [idmodelo])
REFERENCES [dbo].[tipofresa] ([idtipo], [idmodelo])
GO
ALTER TABLE [dbo].[parte] CHECK CONSTRAINT [FK_parte_tipofresa1]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_parte_tipomateriaprima]') AND parent_object_id = OBJECT_ID(N'[dbo].[parte]'))
ALTER TABLE [dbo].[parte]  WITH NOCHECK ADD  CONSTRAINT [FK_parte_tipomateriaprima] FOREIGN KEY([idtipomateriaprima])
REFERENCES [dbo].[tipomateriaprima] ([idtipomateriaprima])
GO
ALTER TABLE [dbo].[parte] CHECK CONSTRAINT [FK_parte_tipomateriaprima]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_parte_tipoparte]') AND parent_object_id = OBJECT_ID(N'[dbo].[parte]'))
ALTER TABLE [dbo].[parte]  WITH NOCHECK ADD  CONSTRAINT [FK_parte_tipoparte] FOREIGN KEY([nombre])
REFERENCES [dbo].[tipoparte] ([nombre])
GO
ALTER TABLE [dbo].[parte] CHECK CONSTRAINT [FK_parte_tipoparte]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_maquina_tipomaquina]') AND parent_object_id = OBJECT_ID(N'[dbo].[maquina]'))
ALTER TABLE [dbo].[maquina]  WITH NOCHECK ADD  CONSTRAINT [FK_maquina_tipomaquina] FOREIGN KEY([tipomaquina])
REFERENCES [dbo].[tipomaquina] ([nombre])
GO
ALTER TABLE [dbo].[maquina] CHECK CONSTRAINT [FK_maquina_tipomaquina]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_formulario_menupadre]') AND parent_object_id = OBJECT_ID(N'[dbo].[formulario]'))
ALTER TABLE [dbo].[formulario]  WITH NOCHECK ADD  CONSTRAINT [FK_formulario_menupadre] FOREIGN KEY([idmenu])
REFERENCES [dbo].[menupadre] ([idmenu])
GO
ALTER TABLE [dbo].[formulario] CHECK CONSTRAINT [FK_formulario_menupadre]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_formulario_modulo]') AND parent_object_id = OBJECT_ID(N'[dbo].[formulario]'))
ALTER TABLE [dbo].[formulario]  WITH NOCHECK ADD  CONSTRAINT [FK_formulario_modulo] FOREIGN KEY([idmodulo])
REFERENCES [dbo].[modulo] ([idmodulo])
GO
ALTER TABLE [dbo].[formulario] CHECK CONSTRAINT [FK_formulario_modulo]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tipomateriaprima_unidaddemedida]') AND parent_object_id = OBJECT_ID(N'[dbo].[tipomateriaprima]'))
ALTER TABLE [dbo].[tipomateriaprima]  WITH NOCHECK ADD  CONSTRAINT [FK_tipomateriaprima_unidaddemedida] FOREIGN KEY([idunidadmedida])
REFERENCES [dbo].[unidaddemedida] ([idunidadmedida])
GO
ALTER TABLE [dbo].[tipomateriaprima] CHECK CONSTRAINT [FK_tipomateriaprima_unidaddemedida]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_mprecibida_ordencompramp]') AND parent_object_id = OBJECT_ID(N'[dbo].[mprecibida]'))
ALTER TABLE [dbo].[mprecibida]  WITH NOCHECK ADD  CONSTRAINT [FK_mprecibida_ordencompramp] FOREIGN KEY([idordencompramp])
REFERENCES [dbo].[ordencompramp] ([idordencompra])
GO
ALTER TABLE [dbo].[mprecibida] CHECK CONSTRAINT [FK_mprecibida_ordencompramp]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_pago_ordencompramp]') AND parent_object_id = OBJECT_ID(N'[dbo].[pago]'))
ALTER TABLE [dbo].[pago]  WITH NOCHECK ADD  CONSTRAINT [FK_pago_ordencompramp] FOREIGN KEY([idordencompra])
REFERENCES [dbo].[ordencompramp] ([idordencompra])
GO
ALTER TABLE [dbo].[pago] CHECK CONSTRAINT [FK_pago_ordencompramp]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_detalleordenservicio_hojaderuta]') AND parent_object_id = OBJECT_ID(N'[dbo].[detalleordenservicio]'))
ALTER TABLE [dbo].[detalleordenservicio]  WITH NOCHECK ADD  CONSTRAINT [FK_detalleordenservicio_hojaderuta] FOREIGN KEY([idhojaderuta])
REFERENCES [dbo].[hojaderuta] ([idhojaderuta])
GO
ALTER TABLE [dbo].[detalleordenservicio] CHECK CONSTRAINT [FK_detalleordenservicio_hojaderuta]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_detalleordenservicio_objetodelservicio]') AND parent_object_id = OBJECT_ID(N'[dbo].[detalleordenservicio]'))
ALTER TABLE [dbo].[detalleordenservicio]  WITH NOCHECK ADD  CONSTRAINT [FK_detalleordenservicio_objetodelservicio] FOREIGN KEY([idobjetodelservicio])
REFERENCES [dbo].[objetodelservicio] ([idobjetodelservicio])
GO
ALTER TABLE [dbo].[detalleordenservicio] CHECK CONSTRAINT [FK_detalleordenservicio_objetodelservicio]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_detalleordenservicio_operacion]') AND parent_object_id = OBJECT_ID(N'[dbo].[detalleordenservicio]'))
ALTER TABLE [dbo].[detalleordenservicio]  WITH NOCHECK ADD  CONSTRAINT [FK_detalleordenservicio_operacion] FOREIGN KEY([idoperacion])
REFERENCES [dbo].[operacion] ([idoperacion])
GO
ALTER TABLE [dbo].[detalleordenservicio] CHECK CONSTRAINT [FK_detalleordenservicio_operacion]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_detalleordenservicio_Pedido]') AND parent_object_id = OBJECT_ID(N'[dbo].[detalleordenservicio]'))
ALTER TABLE [dbo].[detalleordenservicio]  WITH NOCHECK ADD  CONSTRAINT [FK_detalleordenservicio_Pedido] FOREIGN KEY([idpedido])
REFERENCES [dbo].[Pedido] ([idpedido])
GO
ALTER TABLE [dbo].[detalleordenservicio] CHECK CONSTRAINT [FK_detalleordenservicio_Pedido]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_detallehojaderuta_empleado]') AND parent_object_id = OBJECT_ID(N'[dbo].[detallehojaderuta]'))
ALTER TABLE [dbo].[detallehojaderuta]  WITH NOCHECK ADD  CONSTRAINT [FK_detallehojaderuta_empleado] FOREIGN KEY([idlegajo])
REFERENCES [dbo].[empleado] ([idlegajo])
GO
ALTER TABLE [dbo].[detallehojaderuta] CHECK CONSTRAINT [FK_detallehojaderuta_empleado]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_detallehojaderuta_hojaderuta]') AND parent_object_id = OBJECT_ID(N'[dbo].[detallehojaderuta]'))
ALTER TABLE [dbo].[detallehojaderuta]  WITH NOCHECK ADD  CONSTRAINT [FK_detallehojaderuta_hojaderuta] FOREIGN KEY([idhojaderuta])
REFERENCES [dbo].[hojaderuta] ([idhojaderuta])
GO
ALTER TABLE [dbo].[detallehojaderuta] CHECK CONSTRAINT [FK_detallehojaderuta_hojaderuta]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_detallehojaderuta_torneado]') AND parent_object_id = OBJECT_ID(N'[dbo].[detallehojaderuta]'))
ALTER TABLE [dbo].[detallehojaderuta]  WITH NOCHECK ADD  CONSTRAINT [FK_detallehojaderuta_torneado] FOREIGN KEY([idtorneado])
REFERENCES [dbo].[torneado] ([idtorneado])
GO
ALTER TABLE [dbo].[detallehojaderuta] CHECK CONSTRAINT [FK_detallehojaderuta_torneado]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_desperfecto_maquina]') AND parent_object_id = OBJECT_ID(N'[dbo].[desperfecto]'))
ALTER TABLE [dbo].[desperfecto]  WITH NOCHECK ADD  CONSTRAINT [FK_desperfecto_maquina] FOREIGN KEY([idmaquina])
REFERENCES [dbo].[maquina] ([idmaquina])
GO
ALTER TABLE [dbo].[desperfecto] CHECK CONSTRAINT [FK_desperfecto_maquina]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_desperfecto_tipodesperfecto]') AND parent_object_id = OBJECT_ID(N'[dbo].[desperfecto]'))
ALTER TABLE [dbo].[desperfecto]  WITH NOCHECK ADD  CONSTRAINT [FK_desperfecto_tipodesperfecto] FOREIGN KEY([idtipodesperfecto])
REFERENCES [dbo].[tipodesperfecto] ([idtipodesperfecto])
GO
ALTER TABLE [dbo].[desperfecto] CHECK CONSTRAINT [FK_desperfecto_tipodesperfecto]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_partepedido_parteadicional]') AND parent_object_id = OBJECT_ID(N'[dbo].[partepedido]'))
ALTER TABLE [dbo].[partepedido]  WITH NOCHECK ADD  CONSTRAINT [FK_partepedido_parteadicional] FOREIGN KEY([idadicional], [idmodelo])
REFERENCES [dbo].[parteadicional] ([idadicional], [idmodelo])
GO
ALTER TABLE [dbo].[partepedido] CHECK CONSTRAINT [FK_partepedido_parteadicional]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_partepedido_Pedido]') AND parent_object_id = OBJECT_ID(N'[dbo].[partepedido]'))
ALTER TABLE [dbo].[partepedido]  WITH NOCHECK ADD  CONSTRAINT [FK_partepedido_Pedido] FOREIGN KEY([idpedido])
REFERENCES [dbo].[Pedido] ([idpedido])
GO
ALTER TABLE [dbo].[partepedido] CHECK CONSTRAINT [FK_partepedido_Pedido]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_controlcalidad_fresa]') AND parent_object_id = OBJECT_ID(N'[dbo].[controlcalidad]'))
ALTER TABLE [dbo].[controlcalidad]  WITH NOCHECK ADD  CONSTRAINT [FK_controlcalidad_fresa] FOREIGN KEY([idfresa])
REFERENCES [dbo].[fresa] ([nroserie])
GO
ALTER TABLE [dbo].[controlcalidad] CHECK CONSTRAINT [FK_controlcalidad_fresa]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_viajantexlocalidad_empleado]') AND parent_object_id = OBJECT_ID(N'[dbo].[viajantexlocalidad]'))
ALTER TABLE [dbo].[viajantexlocalidad]  WITH NOCHECK ADD  CONSTRAINT [FK_viajantexlocalidad_empleado] FOREIGN KEY([idviajante])
REFERENCES [dbo].[empleado] ([idlegajo])
GO
ALTER TABLE [dbo].[viajantexlocalidad] CHECK CONSTRAINT [FK_viajantexlocalidad_empleado]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_viajantexlocalidad_localidad]') AND parent_object_id = OBJECT_ID(N'[dbo].[viajantexlocalidad]'))
ALTER TABLE [dbo].[viajantexlocalidad]  WITH NOCHECK ADD  CONSTRAINT [FK_viajantexlocalidad_localidad] FOREIGN KEY([idlocalidad])
REFERENCES [dbo].[localidad] ([idlocalidad])
GO
ALTER TABLE [dbo].[viajantexlocalidad] CHECK CONSTRAINT [FK_viajantexlocalidad_localidad]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_proveedor_localidad]') AND parent_object_id = OBJECT_ID(N'[dbo].[proveedor]'))
ALTER TABLE [dbo].[proveedor]  WITH NOCHECK ADD  CONSTRAINT [FK_proveedor_localidad] FOREIGN KEY([idlocalidad])
REFERENCES [dbo].[localidad] ([idlocalidad])
GO
ALTER TABLE [dbo].[proveedor] CHECK CONSTRAINT [FK_proveedor_localidad]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_presupuesto_cliente]') AND parent_object_id = OBJECT_ID(N'[dbo].[presupuesto]'))
ALTER TABLE [dbo].[presupuesto]  WITH NOCHECK ADD  CONSTRAINT [FK_presupuesto_cliente] FOREIGN KEY([idcliente])
REFERENCES [dbo].[cliente] ([idcliente])
GO
ALTER TABLE [dbo].[presupuesto] CHECK CONSTRAINT [FK_presupuesto_cliente]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_presupuesto_empleado]') AND parent_object_id = OBJECT_ID(N'[dbo].[presupuesto]'))
ALTER TABLE [dbo].[presupuesto]  WITH NOCHECK ADD  CONSTRAINT [FK_presupuesto_empleado] FOREIGN KEY([idempleado])
REFERENCES [dbo].[empleado] ([idlegajo])
GO
ALTER TABLE [dbo].[presupuesto] CHECK CONSTRAINT [FK_presupuesto_empleado]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_formxempleado_empleado]') AND parent_object_id = OBJECT_ID(N'[dbo].[formxempleado]'))
ALTER TABLE [dbo].[formxempleado]  WITH NOCHECK ADD  CONSTRAINT [FK_formxempleado_empleado] FOREIGN KEY([idlegajo])
REFERENCES [dbo].[empleado] ([idlegajo])
GO
ALTER TABLE [dbo].[formxempleado] CHECK CONSTRAINT [FK_formxempleado_empleado]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_formxempleado_formulario]') AND parent_object_id = OBJECT_ID(N'[dbo].[formxempleado]'))
ALTER TABLE [dbo].[formxempleado]  WITH NOCHECK ADD  CONSTRAINT [FK_formxempleado_formulario] FOREIGN KEY([idformulario])
REFERENCES [dbo].[formulario] ([idformulario])
GO
ALTER TABLE [dbo].[formxempleado] CHECK CONSTRAINT [FK_formxempleado_formulario]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_cuentausuario_empleado]') AND parent_object_id = OBJECT_ID(N'[dbo].[cuentausuario]'))
ALTER TABLE [dbo].[cuentausuario]  WITH NOCHECK ADD  CONSTRAINT [FK_cuentausuario_empleado] FOREIGN KEY([idlegajo])
REFERENCES [dbo].[empleado] ([idlegajo])
GO
ALTER TABLE [dbo].[cuentausuario] CHECK CONSTRAINT [FK_cuentausuario_empleado]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_perfil_empleado]') AND parent_object_id = OBJECT_ID(N'[dbo].[perfil]'))
ALTER TABLE [dbo].[perfil]  WITH NOCHECK ADD  CONSTRAINT [FK_perfil_empleado] FOREIGN KEY([idlegajo])
REFERENCES [dbo].[empleado] ([idlegajo])
GO
ALTER TABLE [dbo].[perfil] CHECK CONSTRAINT [FK_perfil_empleado]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tipofresa_modelofresa]') AND parent_object_id = OBJECT_ID(N'[dbo].[tipofresa]'))
ALTER TABLE [dbo].[tipofresa]  WITH NOCHECK ADD  CONSTRAINT [FK_tipofresa_modelofresa] FOREIGN KEY([idmodelo])
REFERENCES [dbo].[modelofresa] ([idmodelo])
GO
ALTER TABLE [dbo].[tipofresa] CHECK CONSTRAINT [FK_tipofresa_modelofresa]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_parteadicional_modelofresa]') AND parent_object_id = OBJECT_ID(N'[dbo].[parteadicional]'))
ALTER TABLE [dbo].[parteadicional]  WITH NOCHECK ADD  CONSTRAINT [FK_parteadicional_modelofresa] FOREIGN KEY([idmodelo])
REFERENCES [dbo].[modelofresa] ([idmodelo])
GO
ALTER TABLE [dbo].[parteadicional] CHECK CONSTRAINT [FK_parteadicional_modelofresa]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_fresaxmaquina_maquinaFresa]') AND parent_object_id = OBJECT_ID(N'[dbo].[fresaxmaquina]'))
ALTER TABLE [dbo].[fresaxmaquina]  WITH NOCHECK ADD  CONSTRAINT [FK_fresaxmaquina_maquinaFresa] FOREIGN KEY([idmaquina])
REFERENCES [dbo].[maquinaFresa] ([idmaquina])
GO
ALTER TABLE [dbo].[fresaxmaquina] CHECK CONSTRAINT [FK_fresaxmaquina_maquinaFresa]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_fresaxmaquina_modelofresa]') AND parent_object_id = OBJECT_ID(N'[dbo].[fresaxmaquina]'))
ALTER TABLE [dbo].[fresaxmaquina]  WITH NOCHECK ADD  CONSTRAINT [FK_fresaxmaquina_modelofresa] FOREIGN KEY([idmodelo])
REFERENCES [dbo].[modelofresa] ([idmodelo])
GO
ALTER TABLE [dbo].[fresaxmaquina] CHECK CONSTRAINT [FK_fresaxmaquina_modelofresa]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_etapadefabricacion_operacion]') AND parent_object_id = OBJECT_ID(N'[dbo].[etapadefabricacion]'))
ALTER TABLE [dbo].[etapadefabricacion]  WITH NOCHECK ADD  CONSTRAINT [FK_etapadefabricacion_operacion] FOREIGN KEY([idoperacion])
REFERENCES [dbo].[operacion] ([idoperacion])
GO
ALTER TABLE [dbo].[etapadefabricacion] CHECK CONSTRAINT [FK_etapadefabricacion_operacion]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_etapadefabricacion_tipofresa1]') AND parent_object_id = OBJECT_ID(N'[dbo].[etapadefabricacion]'))
ALTER TABLE [dbo].[etapadefabricacion]  WITH NOCHECK ADD  CONSTRAINT [FK_etapadefabricacion_tipofresa1] FOREIGN KEY([idtipofresa], [idmodelo])
REFERENCES [dbo].[tipofresa] ([idtipo], [idmodelo])
GO
ALTER TABLE [dbo].[etapadefabricacion] CHECK CONSTRAINT [FK_etapadefabricacion_tipofresa1]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_formxperfil_formulario]') AND parent_object_id = OBJECT_ID(N'[dbo].[formxperfil]'))
ALTER TABLE [dbo].[formxperfil]  WITH NOCHECK ADD  CONSTRAINT [FK_formxperfil_formulario] FOREIGN KEY([idformulario])
REFERENCES [dbo].[formulario] ([idformulario])
GO
ALTER TABLE [dbo].[formxperfil] CHECK CONSTRAINT [FK_formxperfil_formulario]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_formxperfil_perfil]') AND parent_object_id = OBJECT_ID(N'[dbo].[formxperfil]'))
ALTER TABLE [dbo].[formxperfil]  WITH NOCHECK ADD  CONSTRAINT [FK_formxperfil_perfil] FOREIGN KEY([idperfil])
REFERENCES [dbo].[perfil] ([idperfil])
GO
ALTER TABLE [dbo].[formxperfil] CHECK CONSTRAINT [FK_formxperfil_perfil]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_proveedorxtipomateriaprima_proveedor]') AND parent_object_id = OBJECT_ID(N'[dbo].[proveedorxtipomateriaprima]'))
ALTER TABLE [dbo].[proveedorxtipomateriaprima]  WITH NOCHECK ADD  CONSTRAINT [FK_proveedorxtipomateriaprima_proveedor] FOREIGN KEY([idproveedor])
REFERENCES [dbo].[proveedor] ([idproveedor])
GO
ALTER TABLE [dbo].[proveedorxtipomateriaprima] CHECK CONSTRAINT [FK_proveedorxtipomateriaprima_proveedor]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_proveedorxtipomateriaprima_tipomateriaprima]') AND parent_object_id = OBJECT_ID(N'[dbo].[proveedorxtipomateriaprima]'))
ALTER TABLE [dbo].[proveedorxtipomateriaprima]  WITH NOCHECK ADD  CONSTRAINT [FK_proveedorxtipomateriaprima_tipomateriaprima] FOREIGN KEY([idtipomateriaprima])
REFERENCES [dbo].[tipomateriaprima] ([idtipomateriaprima])
GO
ALTER TABLE [dbo].[proveedorxtipomateriaprima] CHECK CONSTRAINT [FK_proveedorxtipomateriaprima_tipomateriaprima]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_detallepresupuesto_presupuesto]') AND parent_object_id = OBJECT_ID(N'[dbo].[detallepresupuesto]'))
ALTER TABLE [dbo].[detallepresupuesto]  WITH NOCHECK ADD  CONSTRAINT [FK_detallepresupuesto_presupuesto] FOREIGN KEY([idpresupuesto])
REFERENCES [dbo].[presupuesto] ([idpresupuesto])
GO
ALTER TABLE [dbo].[detallepresupuesto] CHECK CONSTRAINT [FK_detallepresupuesto_presupuesto]
