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
CREATE TABLE [dbo].[formadeentrega](
	[idformadeentrega] [int] NOT NULL,
	[nombre] [char](20) NULL,
	[descripcion] [char](10) NULL,
 CONSTRAINT [PK_formadeentrega] PRIMARY KEY CLUSTERED 
(
	[idformadeentrega] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[estado](
	[idestado] [int] NOT NULL,
	[nombre] [char](40) NULL,
	[descripcion] [char](40) NULL,
 CONSTRAINT [PK_estado] PRIMARY KEY CLUSTERED 
(
	[idestado] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[provincia](
	[idprovincia] [int] NOT NULL,
	[nombre] [char](20) NULL,
	[descripcion] [char](30) NULL,
 CONSTRAINT [PK_provincia] PRIMARY KEY CLUSTERED 
(
	[idprovincia] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipodocumento](
	[idtipodocumento] [int] NOT NULL,
	[nombre] [char](10) NULL,
	[descipcion] [char](10) NULL,
 CONSTRAINT [PK_tipodocumento] PRIMARY KEY CLUSTERED 
(
	[idtipodocumento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cargo](
	[idcargo] [int] NOT NULL,
	[nombre] [char](20) NULL,
	[descripcion] [char](20) NULL,
 CONSTRAINT [PK_cargo] PRIMARY KEY CLUSTERED 
(
	[idcargo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipoacabado](
	[nombre] [char](40) NOT NULL,
	[descripcion] [char](10) NULL,
 CONSTRAINT [PK_tipoacabado] PRIMARY KEY CLUSTERED 
(
	[nombre] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[mododeavance](
	[nombre] [char](40) NOT NULL,
	[descripcion] [char](10) NULL,
 CONSTRAINT [PK_mododeavance] PRIMARY KEY CLUSTERED 
(
	[nombre] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[materialatrabajar](
	[nombre] [char](40) NOT NULL,
	[descripcion] [text] NULL,
 CONSTRAINT [PK_materialatrabajar] PRIMARY KEY CLUSTERED 
(
	[nombre] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[gradodificultad](
	[idgradodificultad] [int] NOT NULL,
	[nombre] [char](20) NULL,
	[descripcion] [text] NULL,
 CONSTRAINT [PK_gradodificultad] PRIMARY KEY CLUSTERED 
(
	[idgradodificultad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipoparte](
	[nombre] [char](40) NOT NULL,
	[descripcion] [text] NULL,
 CONSTRAINT [PK_tipoparte] PRIMARY KEY CLUSTERED 
(
	[nombre] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipomaquina](
	[nombre] [char](40) NOT NULL,
	[descripcion] [text] NULL,
	[idtipo] [int] NULL,
 CONSTRAINT [PK_tipomaquina] PRIMARY KEY CLUSTERED 
(
	[nombre] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[modulo](
	[idmodulo] [int] NOT NULL,
	[descripcion] [char](50) NULL,
 CONSTRAINT [PK_modulo] PRIMARY KEY CLUSTERED 
(
	[idmodulo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[menupadre](
	[idmenu] [int] NOT NULL,
	[nombre] [char](50) NULL,
	[activo] [bit] NULL,
 CONSTRAINT [PK_menupadre] PRIMARY KEY CLUSTERED 
(
	[idmenu] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hojaderuta](
	[idhojaderuta] [int] NOT NULL,
	[fechainicioproduccion] [datetime] NULL,
 CONSTRAINT [PK_hojaderuta] PRIMARY KEY CLUSTERED 
(
	[idhojaderuta] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipodesperfecto](
	[idtipodesperfecto] [int] NOT NULL,
	[nombre] [char](20) NULL,
	[descripcion] [char](30) NULL,
 CONSTRAINT [PK_tipodesperfecto] PRIMARY KEY CLUSTERED 
(
	[idtipodesperfecto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[fresaxmaquina](
	[idmodelo] [int] NOT NULL,
	[idmaquina] [int] NOT NULL,
 CONSTRAINT [PK_fresaxmaquina] PRIMARY KEY CLUSTERED 
(
	[idmodelo] ASC,
	[idmaquina] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detallemprecibida](
	[idmprecibida] [int] NOT NULL,
	[cantidad] [int] NULL,
	[preciol] [float] NULL,
	[causarechazo] [char](20) NULL,
	[idestado] [int] NULL,
	[idtipomateriaprima] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[empresaxlocalidad](
	[idempresa] [int] NOT NULL,
	[idlocalidad] [int] NOT NULL,
 CONSTRAINT [PK_empresaxlocalidad] PRIMARY KEY CLUSTERED 
(
	[idempresa] ASC,
	[idlocalidad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MPxTP](
	[nombre] [char](40) NOT NULL,
	[idmp] [int] NOT NULL,
 CONSTRAINT [PK_MPxTP] PRIMARY KEY CLUSTERED 
(
	[nombre] ASC,
	[idmp] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[formxperfil](
	[idformulario] [int] NOT NULL,
	[idperfil] [int] NOT NULL,
 CONSTRAINT [PK_formxperfil] PRIMARY KEY CLUSTERED 
(
	[idformulario] ASC,
	[idperfil] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[formxempleado](
	[idformulario] [int] NOT NULL,
	[idlegajo] [int] NOT NULL,
 CONSTRAINT [PK_formxempleado] PRIMARY KEY CLUSTERED 
(
	[idformulario] ASC,
	[idlegajo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[viajantexlocalidad](
	[idviajante] [int] NOT NULL,
	[idlocalidad] [int] NOT NULL,
 CONSTRAINT [PK_viajantexlocalidad] PRIMARY KEY CLUSTERED 
(
	[idviajante] ASC,
	[idlocalidad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[proveedorxtipomateriaprima](
	[idproveedor] [int] NOT NULL,
	[idtipomateriaprima] [int] NOT NULL,
 CONSTRAINT [PK_proveedorxtipomateriaprima] PRIMARY KEY CLUSTERED 
(
	[idproveedor] ASC,
	[idtipomateriaprima] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[perfil](
	[idperfil] [int] NOT NULL,
	[descripcion] [char](50) NULL,
	[idlegajo] [int] NULL,
 CONSTRAINT [PK_perfil] PRIMARY KEY CLUSTERED 
(
	[idperfil] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pago](
	[monto] [float] NULL,
	[fechadepago] [datetime] NULL,
	[formadepago] [char](10) NULL,
	[idordencompra] [int] NULL
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Pedido]  WITH NOCHECK ADD  CONSTRAINT [FK_Pedido_cliente] FOREIGN KEY([idcliente])
REFERENCES [dbo].[cliente] ([idcliente])
GO
ALTER TABLE [dbo].[Pedido] CHECK CONSTRAINT [FK_Pedido_cliente]
GO
ALTER TABLE [dbo].[Pedido]  WITH NOCHECK ADD  CONSTRAINT [FK_Pedido_empleado] FOREIGN KEY([idvendedor])
REFERENCES [dbo].[empleado] ([idlegajo])
GO
ALTER TABLE [dbo].[Pedido] CHECK CONSTRAINT [FK_Pedido_empleado]
GO
ALTER TABLE [dbo].[Pedido]  WITH CHECK ADD  CONSTRAINT [FK_Pedido_empresatransporte] FOREIGN KEY([idempresa])
REFERENCES [dbo].[empresatransporte] ([idempresa])
GO
ALTER TABLE [dbo].[Pedido] CHECK CONSTRAINT [FK_Pedido_empresatransporte]
GO
ALTER TABLE [dbo].[Pedido]  WITH NOCHECK ADD  CONSTRAINT [FK_Pedido_estado] FOREIGN KEY([idestado])
REFERENCES [dbo].[estado] ([idestado])
GO
ALTER TABLE [dbo].[Pedido] CHECK CONSTRAINT [FK_Pedido_estado]
GO
ALTER TABLE [dbo].[Pedido]  WITH NOCHECK ADD  CONSTRAINT [FK_Pedido_formadeentrega] FOREIGN KEY([idformadeentrega])
REFERENCES [dbo].[formadeentrega] ([idformadeentrega])
GO
ALTER TABLE [dbo].[Pedido] CHECK CONSTRAINT [FK_Pedido_formadeentrega]
GO
ALTER TABLE [dbo].[fresaxmaquina]  WITH NOCHECK ADD  CONSTRAINT [FK_fresaxmaquina_maquinaFresa] FOREIGN KEY([idmaquina])
REFERENCES [dbo].[maquinaFresa] ([idmaquina])
GO
ALTER TABLE [dbo].[fresaxmaquina] CHECK CONSTRAINT [FK_fresaxmaquina_maquinaFresa]
GO
ALTER TABLE [dbo].[fresaxmaquina]  WITH NOCHECK ADD  CONSTRAINT [FK_fresaxmaquina_modelofresa] FOREIGN KEY([idmodelo])
REFERENCES [dbo].[modelofresa] ([idmodelo])
GO
ALTER TABLE [dbo].[fresaxmaquina] CHECK CONSTRAINT [FK_fresaxmaquina_modelofresa]
GO
ALTER TABLE [dbo].[detalleordenservicio]  WITH CHECK ADD  CONSTRAINT [FK_detalleordenservicio_hojaderuta] FOREIGN KEY([idhojaderuta])
REFERENCES [dbo].[hojaderuta] ([idhojaderuta])
GO
ALTER TABLE [dbo].[detalleordenservicio] CHECK CONSTRAINT [FK_detalleordenservicio_hojaderuta]
GO
ALTER TABLE [dbo].[detalleordenservicio]  WITH CHECK ADD  CONSTRAINT [FK_detalleordenservicio_objetodelservicio] FOREIGN KEY([idobjetodelservicio])
REFERENCES [dbo].[objetodelservicio] ([idobjetodelservicio])
GO
ALTER TABLE [dbo].[detalleordenservicio] CHECK CONSTRAINT [FK_detalleordenservicio_objetodelservicio]
GO
ALTER TABLE [dbo].[detalleordenservicio]  WITH NOCHECK ADD  CONSTRAINT [FK_detalleordenservicio_operacion] FOREIGN KEY([idoperacion])
REFERENCES [dbo].[operacion] ([idoperacion])
GO
ALTER TABLE [dbo].[detalleordenservicio] CHECK CONSTRAINT [FK_detalleordenservicio_operacion]
GO
ALTER TABLE [dbo].[detalleordenservicio]  WITH CHECK ADD  CONSTRAINT [FK_detalleordenservicio_Pedido] FOREIGN KEY([idpedido])
REFERENCES [dbo].[Pedido] ([idpedido])
GO
ALTER TABLE [dbo].[detalleordenservicio] CHECK CONSTRAINT [FK_detalleordenservicio_Pedido]
GO
ALTER TABLE [dbo].[detalleordencompra]  WITH NOCHECK ADD  CONSTRAINT [FK_detalleordencompra_estado] FOREIGN KEY([idestado])
REFERENCES [dbo].[estado] ([idestado])
GO
ALTER TABLE [dbo].[detalleordencompra] CHECK CONSTRAINT [FK_detalleordencompra_estado]
GO
ALTER TABLE [dbo].[detalleordencompra]  WITH NOCHECK ADD  CONSTRAINT [FK_detalleordencompra_ordencompramp1] FOREIGN KEY([idordencompra])
REFERENCES [dbo].[ordencompramp] ([idordencompra])
GO
ALTER TABLE [dbo].[detalleordencompra] CHECK CONSTRAINT [FK_detalleordencompra_ordencompramp1]
GO
ALTER TABLE [dbo].[detalleordencompra]  WITH NOCHECK ADD  CONSTRAINT [FK_detalleordencompra_tipomateriaprima] FOREIGN KEY([idtipomateriaprima])
REFERENCES [dbo].[tipomateriaprima] ([idtipomateriaprima])
GO
ALTER TABLE [dbo].[detalleordencompra] CHECK CONSTRAINT [FK_detalleordencompra_tipomateriaprima]
GO
ALTER TABLE [dbo].[fresa]  WITH NOCHECK ADD  CONSTRAINT [FK_fresa_estado] FOREIGN KEY([estado])
REFERENCES [dbo].[estado] ([idestado])
GO
ALTER TABLE [dbo].[fresa] CHECK CONSTRAINT [FK_fresa_estado]
GO
ALTER TABLE [dbo].[fresa]  WITH NOCHECK ADD  CONSTRAINT [FK_fresa_hojaderuta] FOREIGN KEY([idhojaderuta])
REFERENCES [dbo].[hojaderuta] ([idhojaderuta])
GO
ALTER TABLE [dbo].[fresa] CHECK CONSTRAINT [FK_fresa_hojaderuta]
GO
ALTER TABLE [dbo].[fresa]  WITH NOCHECK ADD  CONSTRAINT [FK_fresa_Pedido] FOREIGN KEY([nropedido])
REFERENCES [dbo].[Pedido] ([idpedido])
GO
ALTER TABLE [dbo].[fresa] CHECK CONSTRAINT [FK_fresa_Pedido]
GO
ALTER TABLE [dbo].[fresa]  WITH CHECK ADD  CONSTRAINT [FK_fresa_tipofresa] FOREIGN KEY([idtipo], [idmodelo])
REFERENCES [dbo].[tipofresa] ([idtipo], [idmodelo])
GO
ALTER TABLE [dbo].[fresa] CHECK CONSTRAINT [FK_fresa_tipofresa]
GO
ALTER TABLE [dbo].[detallemprecibida]  WITH NOCHECK ADD  CONSTRAINT [FK_detallemprecibida_estado1] FOREIGN KEY([idestado])
REFERENCES [dbo].[estado] ([idestado])
GO
ALTER TABLE [dbo].[detallemprecibida] CHECK CONSTRAINT [FK_detallemprecibida_estado1]
GO
ALTER TABLE [dbo].[detallemprecibida]  WITH NOCHECK ADD  CONSTRAINT [FK_detallemprecibida_mprecibida] FOREIGN KEY([idmprecibida])
REFERENCES [dbo].[mprecibida] ([idmprecibida])
GO
ALTER TABLE [dbo].[detallemprecibida] CHECK CONSTRAINT [FK_detallemprecibida_mprecibida]
GO
ALTER TABLE [dbo].[detallemprecibida]  WITH NOCHECK ADD  CONSTRAINT [FK_detallemprecibida_mprecibida1] FOREIGN KEY([idmprecibida])
REFERENCES [dbo].[mprecibida] ([idmprecibida])
GO
ALTER TABLE [dbo].[detallemprecibida] CHECK CONSTRAINT [FK_detallemprecibida_mprecibida1]
GO
ALTER TABLE [dbo].[detallemprecibida]  WITH NOCHECK ADD  CONSTRAINT [FK_detallemprecibida_tipomateriaprima] FOREIGN KEY([idtipomateriaprima])
REFERENCES [dbo].[tipomateriaprima] ([idtipomateriaprima])
GO
ALTER TABLE [dbo].[detallemprecibida] CHECK CONSTRAINT [FK_detallemprecibida_tipomateriaprima]
GO
ALTER TABLE [dbo].[localidad]  WITH NOCHECK ADD  CONSTRAINT [FK_localidad_provincia] FOREIGN KEY([idprovincia])
REFERENCES [dbo].[provincia] ([idprovincia])
GO
ALTER TABLE [dbo].[localidad] CHECK CONSTRAINT [FK_localidad_provincia]
GO
ALTER TABLE [dbo].[torneado]  WITH NOCHECK ADD  CONSTRAINT [FK_torneado_tornero] FOREIGN KEY([idtornero])
REFERENCES [dbo].[tornero] ([idtornero])
GO
ALTER TABLE [dbo].[torneado] CHECK CONSTRAINT [FK_torneado_tornero]
GO
ALTER TABLE [dbo].[cliente]  WITH NOCHECK ADD  CONSTRAINT [FK_cliente_localidad] FOREIGN KEY([localidad])
REFERENCES [dbo].[localidad] ([idlocalidad])
GO
ALTER TABLE [dbo].[cliente] CHECK CONSTRAINT [FK_cliente_localidad]
GO
ALTER TABLE [dbo].[cliente]  WITH NOCHECK ADD  CONSTRAINT [FK_cliente_tipodocumento] FOREIGN KEY([idtipodocumento])
REFERENCES [dbo].[tipodocumento] ([idtipodocumento])
GO
ALTER TABLE [dbo].[cliente] CHECK CONSTRAINT [FK_cliente_tipodocumento]
GO
ALTER TABLE [dbo].[empleado]  WITH NOCHECK ADD  CONSTRAINT [FK_empleado_cargo] FOREIGN KEY([idcargo])
REFERENCES [dbo].[cargo] ([idcargo])
GO
ALTER TABLE [dbo].[empleado] CHECK CONSTRAINT [FK_empleado_cargo]
GO
ALTER TABLE [dbo].[empleado]  WITH NOCHECK ADD  CONSTRAINT [FK_empleado_localidad] FOREIGN KEY([idlocalidad])
REFERENCES [dbo].[localidad] ([idlocalidad])
GO
ALTER TABLE [dbo].[empleado] CHECK CONSTRAINT [FK_empleado_localidad]
GO
ALTER TABLE [dbo].[modelofresa]  WITH NOCHECK ADD  CONSTRAINT [FK_modelofresa_materialatrabajar] FOREIGN KEY([materialatrabajar])
REFERENCES [dbo].[materialatrabajar] ([nombre])
GO
ALTER TABLE [dbo].[modelofresa] CHECK CONSTRAINT [FK_modelofresa_materialatrabajar]
GO
ALTER TABLE [dbo].[modelofresa]  WITH NOCHECK ADD  CONSTRAINT [FK_modelofresa_mododeavance] FOREIGN KEY([mododeavance])
REFERENCES [dbo].[mododeavance] ([nombre])
GO
ALTER TABLE [dbo].[modelofresa] CHECK CONSTRAINT [FK_modelofresa_mododeavance]
GO
ALTER TABLE [dbo].[modelofresa]  WITH NOCHECK ADD  CONSTRAINT [FK_modelofresa_tipoacabado] FOREIGN KEY([tipoacabado])
REFERENCES [dbo].[tipoacabado] ([nombre])
GO
ALTER TABLE [dbo].[modelofresa] CHECK CONSTRAINT [FK_modelofresa_tipoacabado]
GO
ALTER TABLE [dbo].[empresaxlocalidad]  WITH CHECK ADD  CONSTRAINT [FK_empresaxlocalidad_empresatransporte] FOREIGN KEY([idempresa])
REFERENCES [dbo].[empresatransporte] ([idempresa])
GO
ALTER TABLE [dbo].[empresaxlocalidad] CHECK CONSTRAINT [FK_empresaxlocalidad_empresatransporte]
GO
ALTER TABLE [dbo].[empresaxlocalidad]  WITH NOCHECK ADD  CONSTRAINT [FK_empresaxlocalidad_localidad] FOREIGN KEY([idlocalidad])
REFERENCES [dbo].[localidad] ([idlocalidad])
GO
ALTER TABLE [dbo].[empresaxlocalidad] CHECK CONSTRAINT [FK_empresaxlocalidad_localidad]
GO
ALTER TABLE [dbo].[operacion]  WITH CHECK ADD  CONSTRAINT [FK_operacion_gradodificultad] FOREIGN KEY([idgradodificultad])
REFERENCES [dbo].[gradodificultad] ([idgradodificultad])
GO
ALTER TABLE [dbo].[operacion] CHECK CONSTRAINT [FK_operacion_gradodificultad]
GO
ALTER TABLE [dbo].[operacion]  WITH CHECK ADD  CONSTRAINT [FK_operacion_tipomaquina] FOREIGN KEY([maquina])
REFERENCES [dbo].[tipomaquina] ([nombre])
GO
ALTER TABLE [dbo].[operacion] CHECK CONSTRAINT [FK_operacion_tipomaquina]
GO
ALTER TABLE [dbo].[MPxTP]  WITH CHECK ADD  CONSTRAINT [FK_MPxTP_tipomateriaprima] FOREIGN KEY([idmp])
REFERENCES [dbo].[tipomateriaprima] ([idtipomateriaprima])
GO
ALTER TABLE [dbo].[MPxTP] CHECK CONSTRAINT [FK_MPxTP_tipomateriaprima]
GO
ALTER TABLE [dbo].[MPxTP]  WITH CHECK ADD  CONSTRAINT [FK_MPxTP_tipoparte] FOREIGN KEY([nombre])
REFERENCES [dbo].[tipoparte] ([nombre])
GO
ALTER TABLE [dbo].[MPxTP] CHECK CONSTRAINT [FK_MPxTP_tipoparte]
GO
ALTER TABLE [dbo].[parte]  WITH NOCHECK ADD  CONSTRAINT [FK_parte_tipofresa1] FOREIGN KEY([idtipofresa], [idmodelo])
REFERENCES [dbo].[tipofresa] ([idtipo], [idmodelo])
GO
ALTER TABLE [dbo].[parte] CHECK CONSTRAINT [FK_parte_tipofresa1]
GO
ALTER TABLE [dbo].[parte]  WITH CHECK ADD  CONSTRAINT [FK_parte_tipomateriaprima] FOREIGN KEY([idtipomateriaprima])
REFERENCES [dbo].[tipomateriaprima] ([idtipomateriaprima])
GO
ALTER TABLE [dbo].[parte] CHECK CONSTRAINT [FK_parte_tipomateriaprima]
GO
ALTER TABLE [dbo].[parte]  WITH NOCHECK ADD  CONSTRAINT [FK_parte_tipoparte] FOREIGN KEY([nombre])
REFERENCES [dbo].[tipoparte] ([nombre])
GO
ALTER TABLE [dbo].[parte] CHECK CONSTRAINT [FK_parte_tipoparte]
GO
ALTER TABLE [dbo].[maquina]  WITH CHECK ADD  CONSTRAINT [FK_maquina_tipomaquina] FOREIGN KEY([tipomaquina])
REFERENCES [dbo].[tipomaquina] ([nombre])
GO
ALTER TABLE [dbo].[maquina] CHECK CONSTRAINT [FK_maquina_tipomaquina]
GO
ALTER TABLE [dbo].[formulario]  WITH CHECK ADD  CONSTRAINT [FK_formulario_menupadre] FOREIGN KEY([idmenu])
REFERENCES [dbo].[menupadre] ([idmenu])
GO
ALTER TABLE [dbo].[formulario] CHECK CONSTRAINT [FK_formulario_menupadre]
GO
ALTER TABLE [dbo].[formulario]  WITH CHECK ADD  CONSTRAINT [FK_formulario_modulo] FOREIGN KEY([idmodulo])
REFERENCES [dbo].[modulo] ([idmodulo])
GO
ALTER TABLE [dbo].[formulario] CHECK CONSTRAINT [FK_formulario_modulo]
GO
ALTER TABLE [dbo].[tipomateriaprima]  WITH CHECK ADD  CONSTRAINT [FK_tipomateriaprima_unidaddemedida] FOREIGN KEY([idunidadmedida])
REFERENCES [dbo].[unidaddemedida] ([idunidadmedida])
GO
ALTER TABLE [dbo].[tipomateriaprima] CHECK CONSTRAINT [FK_tipomateriaprima_unidaddemedida]
GO
ALTER TABLE [dbo].[formxperfil]  WITH CHECK ADD  CONSTRAINT [FK_formxperfil_formulario] FOREIGN KEY([idformulario])
REFERENCES [dbo].[formulario] ([idformulario])
GO
ALTER TABLE [dbo].[formxperfil] CHECK CONSTRAINT [FK_formxperfil_formulario]
GO
ALTER TABLE [dbo].[formxperfil]  WITH CHECK ADD  CONSTRAINT [FK_formxperfil_perfil] FOREIGN KEY([idperfil])
REFERENCES [dbo].[perfil] ([idperfil])
GO
ALTER TABLE [dbo].[formxperfil] CHECK CONSTRAINT [FK_formxperfil_perfil]
GO
ALTER TABLE [dbo].[formxempleado]  WITH NOCHECK ADD  CONSTRAINT [FK_formxempleado_empleado] FOREIGN KEY([idlegajo])
REFERENCES [dbo].[empleado] ([idlegajo])
GO
ALTER TABLE [dbo].[formxempleado] CHECK CONSTRAINT [FK_formxempleado_empleado]
GO
ALTER TABLE [dbo].[formxempleado]  WITH CHECK ADD  CONSTRAINT [FK_formxempleado_formulario] FOREIGN KEY([idformulario])
REFERENCES [dbo].[formulario] ([idformulario])
GO
ALTER TABLE [dbo].[formxempleado] CHECK CONSTRAINT [FK_formxempleado_formulario]
GO
ALTER TABLE [dbo].[controlcalidad]  WITH NOCHECK ADD  CONSTRAINT [FK_controlcalidad_fresa] FOREIGN KEY([idfresa])
REFERENCES [dbo].[fresa] ([nroserie])
GO
ALTER TABLE [dbo].[controlcalidad] CHECK CONSTRAINT [FK_controlcalidad_fresa]
GO
ALTER TABLE [dbo].[partepedido]  WITH NOCHECK ADD  CONSTRAINT [FK_partepedido_parteadicional] FOREIGN KEY([idadicional], [idmodelo])
REFERENCES [dbo].[parteadicional] ([idadicional], [idmodelo])
GO
ALTER TABLE [dbo].[partepedido] CHECK CONSTRAINT [FK_partepedido_parteadicional]
GO
ALTER TABLE [dbo].[partepedido]  WITH CHECK ADD  CONSTRAINT [FK_partepedido_Pedido] FOREIGN KEY([idpedido])
REFERENCES [dbo].[Pedido] ([idpedido])
GO
ALTER TABLE [dbo].[partepedido] CHECK CONSTRAINT [FK_partepedido_Pedido]
GO
ALTER TABLE [dbo].[detallepresupuesto]  WITH NOCHECK ADD  CONSTRAINT [FK_detallepresupuesto_presupuesto] FOREIGN KEY([idpresupuesto])
REFERENCES [dbo].[presupuesto] ([idpresupuesto])
GO
ALTER TABLE [dbo].[detallepresupuesto] CHECK CONSTRAINT [FK_detallepresupuesto_presupuesto]
GO
ALTER TABLE [dbo].[detallehojaderuta]  WITH NOCHECK ADD  CONSTRAINT [FK_detallehojaderuta_empleado] FOREIGN KEY([idlegajo])
REFERENCES [dbo].[empleado] ([idlegajo])
GO
ALTER TABLE [dbo].[detallehojaderuta] CHECK CONSTRAINT [FK_detallehojaderuta_empleado]
GO
ALTER TABLE [dbo].[detallehojaderuta]  WITH CHECK ADD  CONSTRAINT [FK_detallehojaderuta_hojaderuta] FOREIGN KEY([idhojaderuta])
REFERENCES [dbo].[hojaderuta] ([idhojaderuta])
GO
ALTER TABLE [dbo].[detallehojaderuta] CHECK CONSTRAINT [FK_detallehojaderuta_hojaderuta]
GO
ALTER TABLE [dbo].[detallehojaderuta]  WITH NOCHECK ADD  CONSTRAINT [FK_detallehojaderuta_torneado] FOREIGN KEY([idtorneado])
REFERENCES [dbo].[torneado] ([idtorneado])
GO
ALTER TABLE [dbo].[detallehojaderuta] CHECK CONSTRAINT [FK_detallehojaderuta_torneado]
GO
ALTER TABLE [dbo].[viajantexlocalidad]  WITH NOCHECK ADD  CONSTRAINT [FK_viajantexlocalidad_empleado] FOREIGN KEY([idviajante])
REFERENCES [dbo].[empleado] ([idlegajo])
GO
ALTER TABLE [dbo].[viajantexlocalidad] CHECK CONSTRAINT [FK_viajantexlocalidad_empleado]
GO
ALTER TABLE [dbo].[viajantexlocalidad]  WITH NOCHECK ADD  CONSTRAINT [FK_viajantexlocalidad_localidad] FOREIGN KEY([idlocalidad])
REFERENCES [dbo].[localidad] ([idlocalidad])
GO
ALTER TABLE [dbo].[viajantexlocalidad] CHECK CONSTRAINT [FK_viajantexlocalidad_localidad]
GO
ALTER TABLE [dbo].[proveedor]  WITH NOCHECK ADD  CONSTRAINT [FK_proveedor_localidad] FOREIGN KEY([idlocalidad])
REFERENCES [dbo].[localidad] ([idlocalidad])
GO
ALTER TABLE [dbo].[proveedor] CHECK CONSTRAINT [FK_proveedor_localidad]
GO
ALTER TABLE [dbo].[presupuesto]  WITH NOCHECK ADD  CONSTRAINT [FK_presupuesto_cliente] FOREIGN KEY([idcliente])
REFERENCES [dbo].[cliente] ([idcliente])
GO
ALTER TABLE [dbo].[presupuesto] CHECK CONSTRAINT [FK_presupuesto_cliente]
GO
ALTER TABLE [dbo].[presupuesto]  WITH NOCHECK ADD  CONSTRAINT [FK_presupuesto_empleado] FOREIGN KEY([idempleado])
REFERENCES [dbo].[empleado] ([idlegajo])
GO
ALTER TABLE [dbo].[presupuesto] CHECK CONSTRAINT [FK_presupuesto_empleado]
GO
ALTER TABLE [dbo].[tipofresa]  WITH CHECK ADD  CONSTRAINT [FK_tipofresa_modelofresa] FOREIGN KEY([idmodelo])
REFERENCES [dbo].[modelofresa] ([idmodelo])
GO
ALTER TABLE [dbo].[tipofresa] CHECK CONSTRAINT [FK_tipofresa_modelofresa]
GO
ALTER TABLE [dbo].[parteadicional]  WITH NOCHECK ADD  CONSTRAINT [FK_parteadicional_modelofresa] FOREIGN KEY([idmodelo])
REFERENCES [dbo].[modelofresa] ([idmodelo])
GO
ALTER TABLE [dbo].[parteadicional] CHECK CONSTRAINT [FK_parteadicional_modelofresa]
GO
ALTER TABLE [dbo].[etapadefabricacion]  WITH NOCHECK ADD  CONSTRAINT [FK_etapadefabricacion_operacion] FOREIGN KEY([idoperacion])
REFERENCES [dbo].[operacion] ([idoperacion])
GO
ALTER TABLE [dbo].[etapadefabricacion] CHECK CONSTRAINT [FK_etapadefabricacion_operacion]
GO
ALTER TABLE [dbo].[etapadefabricacion]  WITH NOCHECK ADD  CONSTRAINT [FK_etapadefabricacion_tipofresa1] FOREIGN KEY([idtipofresa], [idmodelo])
REFERENCES [dbo].[tipofresa] ([idtipo], [idmodelo])
GO
ALTER TABLE [dbo].[etapadefabricacion] CHECK CONSTRAINT [FK_etapadefabricacion_tipofresa1]
GO
ALTER TABLE [dbo].[proveedorxtipomateriaprima]  WITH NOCHECK ADD  CONSTRAINT [FK_proveedorxtipomateriaprima_proveedor] FOREIGN KEY([idproveedor])
REFERENCES [dbo].[proveedor] ([idproveedor])
GO
ALTER TABLE [dbo].[proveedorxtipomateriaprima] CHECK CONSTRAINT [FK_proveedorxtipomateriaprima_proveedor]
GO
ALTER TABLE [dbo].[proveedorxtipomateriaprima]  WITH CHECK ADD  CONSTRAINT [FK_proveedorxtipomateriaprima_tipomateriaprima] FOREIGN KEY([idtipomateriaprima])
REFERENCES [dbo].[tipomateriaprima] ([idtipomateriaprima])
GO
ALTER TABLE [dbo].[proveedorxtipomateriaprima] CHECK CONSTRAINT [FK_proveedorxtipomateriaprima_tipomateriaprima]
GO
ALTER TABLE [dbo].[desperfecto]  WITH NOCHECK ADD  CONSTRAINT [FK_desperfecto_maquina] FOREIGN KEY([idmaquina])
REFERENCES [dbo].[maquina] ([idmaquina])
GO
ALTER TABLE [dbo].[desperfecto] CHECK CONSTRAINT [FK_desperfecto_maquina]
GO
ALTER TABLE [dbo].[desperfecto]  WITH CHECK ADD  CONSTRAINT [FK_desperfecto_tipodesperfecto] FOREIGN KEY([idtipodesperfecto])
REFERENCES [dbo].[tipodesperfecto] ([idtipodesperfecto])
GO
ALTER TABLE [dbo].[desperfecto] CHECK CONSTRAINT [FK_desperfecto_tipodesperfecto]
GO
ALTER TABLE [dbo].[cuentausuario]  WITH NOCHECK ADD  CONSTRAINT [FK_cuentausuario_empleado] FOREIGN KEY([idlegajo])
REFERENCES [dbo].[empleado] ([idlegajo])
GO
ALTER TABLE [dbo].[cuentausuario] CHECK CONSTRAINT [FK_cuentausuario_empleado]
GO
ALTER TABLE [dbo].[perfil]  WITH NOCHECK ADD  CONSTRAINT [FK_perfil_empleado] FOREIGN KEY([idlegajo])
REFERENCES [dbo].[empleado] ([idlegajo])
GO
ALTER TABLE [dbo].[perfil] CHECK CONSTRAINT [FK_perfil_empleado]
GO
ALTER TABLE [dbo].[mprecibida]  WITH NOCHECK ADD  CONSTRAINT [FK_mprecibida_ordencompramp] FOREIGN KEY([idordencompramp])
REFERENCES [dbo].[ordencompramp] ([idordencompra])
GO
ALTER TABLE [dbo].[mprecibida] CHECK CONSTRAINT [FK_mprecibida_ordencompramp]
GO
ALTER TABLE [dbo].[pago]  WITH NOCHECK ADD  CONSTRAINT [FK_pago_ordencompramp] FOREIGN KEY([idordencompra])
REFERENCES [dbo].[ordencompramp] ([idordencompra])
GO
ALTER TABLE [dbo].[pago] CHECK CONSTRAINT [FK_pago_ordencompramp]
