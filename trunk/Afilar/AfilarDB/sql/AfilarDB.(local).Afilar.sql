SET  ARITHABORT, CONCAT_NULL_YIELDS_NULL, ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, QUOTED_IDENTIFIER ON 
SET  NUMERIC_ROUNDABORT OFF
GO
:setvar databasename "Afilar"

USE [master]

GO

:on error exit

IF  (   DB_ID(N'$(databasename)') IS NOT NULL
    AND DATABASEPROPERTYEX(N'$(databasename)','Status') <> N'ONLINE')
BEGIN
    RAISERROR(N'El estado de la base de datos de destino, %s, no está establecido en ONLINE. Para implementarlo en esta base de datos, debe tener el estado ONLINE.', 16, 127,N'$(databasename)') WITH NOWAIT
    RETURN
END
GO

:on error resume
     
IF (DB_ID(N'$(databasename)') IS NOT NULL) 
BEGIN
    ALTER DATABASE [$(databasename)]
    SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE [$(databasename)];
END
GO
CREATE DATABASE [$(databasename)] COLLATE Traditional_Spanish_CI_AS;

GO

EXEC sp_dbcmptlevel N'$(databasename)', 90

GO

IF EXISTS (SELECT 1 FROM [sys].[databases] WHERE [name] = N'$(databasename)') 
    ALTER DATABASE [$(databasename)] SET  
	ALLOW_SNAPSHOT_ISOLATION OFF
GO

IF EXISTS (SELECT 1 FROM [sys].[databases] WHERE [name] = N'$(databasename)') 
    ALTER DATABASE [$(databasename)] SET  
	READ_COMMITTED_SNAPSHOT OFF
GO

IF EXISTS (SELECT 1 FROM [sys].[databases] WHERE [name] = N'$(databasename)') 
    ALTER DATABASE [$(databasename)] SET  
	MULTI_USER,
	CURSOR_CLOSE_ON_COMMIT OFF,
	CURSOR_DEFAULT LOCAL,
	AUTO_CLOSE OFF,
	AUTO_CREATE_STATISTICS ON,
	AUTO_SHRINK OFF,
	AUTO_UPDATE_STATISTICS ON,
	AUTO_UPDATE_STATISTICS_ASYNC ON,
	ANSI_NULL_DEFAULT ON,
	ANSI_NULLS ON,
	ANSI_PADDING ON,
	ANSI_WARNINGS ON,
	ARITHABORT ON,
	CONCAT_NULL_YIELDS_NULL ON,
	NUMERIC_ROUNDABORT OFF,
	QUOTED_IDENTIFIER ON,
	RECURSIVE_TRIGGERS OFF,
	RECOVERY FULL,
	PAGE_VERIFY NONE,
	DISABLE_BROKER,
	PARAMETERIZATION SIMPLE
	WITH ROLLBACK IMMEDIATE
GO

IF IS_SRVROLEMEMBER ('sysadmin') = 1
BEGIN

IF EXISTS (SELECT 1 FROM [sys].[databases] WHERE [name] = N'$(databasename)') 
    EXEC sp_executesql N'
    ALTER DATABASE [$(databasename)] SET  
	DB_CHAINING OFF,
	TRUSTWORTHY OFF'

END
ELSE
BEGIN
    RAISERROR(N'No se puede modificar la configuración de la base de datos para DB_CHAINING o TRUSTWORTHY. Debe ser un administrador del sistema para poder aplicar esta configuración.',0,1)
END

GO

USE [$(databasename)]

GO
-- Plantilla de script anterior a la implementación							
----------------------------------------------------------------------------------------
-- Este archivo contiene instrucciones de SQL que se ejecutarán antes del script de generación	
-- Use sintaxis de SQLCMD para incluir un archivo en el script anterior a la implementación			
-- Ejemplo:      :r .\nombreDeArchivo.sql								
-- Use sintaxis de SQLCMD para hacer referencia a una variable del script anterior a la implementación		
-- Ejemplo:      :setvar $TableName Mi tabla							
--               SELECT * FROM [$(TableName)]					
----------------------------------------------------------------------------------------








GO
PRINT N'Creando [dbo].[tipoparte]'
GO
CREATE TABLE [dbo].[tipoparte]
(
[nombre] [char] (40) COLLATE Traditional_Spanish_CI_AS NOT NULL,
[descripcion] [text] COLLATE Traditional_Spanish_CI_AS NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
PRINT N'Creando clave principal [PK_tipoparte] en [dbo].[tipoparte]'
GO
ALTER TABLE [dbo].[tipoparte] ADD CONSTRAINT [PK_tipoparte] PRIMARY KEY CLUSTERED  ([nombre]) ON [PRIMARY]
GO
PRINT N'Creando [dbo].[MPxTP]'
GO
CREATE TABLE [dbo].[MPxTP]
(
[nombre] [char] (40) COLLATE Traditional_Spanish_CI_AS NOT NULL,
[idmp] [int] NOT NULL
) ON [PRIMARY]
GO
PRINT N'Creando clave principal [PK_MPxTP] en [dbo].[MPxTP]'
GO
ALTER TABLE [dbo].[MPxTP] ADD CONSTRAINT [PK_MPxTP] PRIMARY KEY CLUSTERED  ([nombre], [idmp]) ON [PRIMARY]
GO
PRINT N'Creando [dbo].[modulo]'
GO
CREATE TABLE [dbo].[modulo]
(
[idmodulo] [int] NOT NULL,
[descripcion] [varchar] (50) COLLATE Traditional_Spanish_CI_AS NULL
) ON [PRIMARY]
GO
PRINT N'Creando clave principal [PK_modulo] en [dbo].[modulo]'
GO
ALTER TABLE [dbo].[modulo] ADD CONSTRAINT [PK_modulo] PRIMARY KEY CLUSTERED  ([idmodulo]) ON [PRIMARY]
GO
PRINT N'Creando [dbo].[formulario]'
GO
CREATE TABLE [dbo].[formulario]
(
[idformulario] [int] NOT NULL,
[descripcion] [char] (50) COLLATE Traditional_Spanish_CI_AS NULL,
[idmodulo] [int] NULL,
[nombre] [varchar] (50) COLLATE Traditional_Spanish_CI_AS NOT NULL,
[idmenu] [int] NULL,
[activo] [bit] NULL
) ON [PRIMARY]
GO
PRINT N'Creando clave principal [PK_formulario] en [dbo].[formulario]'
GO
ALTER TABLE [dbo].[formulario] ADD CONSTRAINT [PK_formulario] PRIMARY KEY CLUSTERED  ([idformulario]) ON [PRIMARY]
GO
PRINT N'Creando [dbo].[Pedido]'
GO
CREATE TABLE [dbo].[Pedido]
(
[idpedido] [numeric] (18, 0) NOT NULL,
[fechaentrega] [datetime] NULL,
[fecharealizacion] [datetime] NULL,
[idestado] [int] NULL,
[prioridad] [int] NULL,
[idcliente] [int] NULL,
[idvendedor] [int] NULL,
[idformadeentrega] [int] NULL,
[idempresa] [int] NULL,
[idviajante] [int] NULL,
[fecharealentrega] [datetime] NULL
) ON [PRIMARY]
GO
PRINT N'Creando clave principal [PK_Pedido] en [dbo].[Pedido]'
GO
ALTER TABLE [dbo].[Pedido] ADD CONSTRAINT [PK_Pedido] PRIMARY KEY CLUSTERED  ([idpedido]) ON [PRIMARY]
GO
PRINT N'Creando [dbo].[detalleordenservicio]'
GO
CREATE TABLE [dbo].[detalleordenservicio]
(
[idpedido] [numeric] (18, 0) NOT NULL,
[idoperacion] [int] NOT NULL,
[idobjetodelservicio] [int] NOT NULL,
[preciodeservicio] [decimal] (18, 0) NULL,
[observacion] [char] (30) COLLATE Traditional_Spanish_CI_AS NULL,
[idhojaderuta] [int] NULL,
[precio] [decimal] (18, 0) NULL
) ON [PRIMARY]
GO
PRINT N'Creando clave principal [PK_detalleordenservicio] en [dbo].[detalleordenservicio]'
GO
ALTER TABLE [dbo].[detalleordenservicio] ADD CONSTRAINT [PK_detalleordenservicio] PRIMARY KEY CLUSTERED  ([idpedido], [idoperacion], [idobjetodelservicio]) ON [PRIMARY]
GO
PRINT N'Creando [dbo].[provincia]'
GO
CREATE TABLE [dbo].[provincia]
(
[idprovincia] [int] NOT NULL,
[nombre] [char] (20) COLLATE Traditional_Spanish_CI_AS NULL,
[descripcion] [char] (30) COLLATE Traditional_Spanish_CI_AS NULL
) ON [PRIMARY]
GO
PRINT N'Creando clave principal [PK_provincia] en [dbo].[provincia]'
GO
ALTER TABLE [dbo].[provincia] ADD CONSTRAINT [PK_provincia] PRIMARY KEY CLUSTERED  ([idprovincia]) ON [PRIMARY]
GO
PRINT N'Creando [dbo].[localidad]'
GO
CREATE TABLE [dbo].[localidad]
(
[idlocalidad] [int] NOT NULL,
[codigopostal] [int] NULL,
[zona] [char] (20) COLLATE Traditional_Spanish_CI_AS NULL,
[provincia] [char] (20) COLLATE Traditional_Spanish_CI_AS NULL,
[distancia] [char] (20) COLLATE Traditional_Spanish_CI_AS NULL,
[nombre] [char] (20) COLLATE Traditional_Spanish_CI_AS NULL,
[idprovincia] [int] NULL
) ON [PRIMARY]
GO
PRINT N'Creando clave principal [PK_localidad] en [dbo].[localidad]'
GO
ALTER TABLE [dbo].[localidad] ADD CONSTRAINT [PK_localidad] PRIMARY KEY CLUSTERED  ([idlocalidad]) ON [PRIMARY]
GO
PRINT N'Creando [dbo].[modelofresa]'
GO
CREATE TABLE [dbo].[modelofresa]
(
[idmodelo] [int] NOT NULL,
[nombre] [char] (40) COLLATE Traditional_Spanish_CI_AS NULL,
[grupomodelo] [char] (50) COLLATE Traditional_Spanish_CI_AS NULL,
[descripcion] [text] COLLATE Traditional_Spanish_CI_AS NULL,
[materialatrabajar] [char] (40) COLLATE Traditional_Spanish_CI_AS NULL,
[mododeavance] [char] (40) COLLATE Traditional_Spanish_CI_AS NULL,
[tipoacabado] [char] (40) COLLATE Traditional_Spanish_CI_AS NULL,
[velocidaddeavance] [float] NULL,
[tipomodelo] [char] (40) COLLATE Traditional_Spanish_CI_AS NULL,
[precio] [float] NULL,
[estado] [char] (15) COLLATE Traditional_Spanish_CI_AS NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
PRINT N'Creando clave principal [PK_modelofresa] en [dbo].[modelofresa]'
GO
ALTER TABLE [dbo].[modelofresa] ADD CONSTRAINT [PK_modelofresa] PRIMARY KEY CLUSTERED  ([idmodelo]) ON [PRIMARY]
GO
PRINT N'Creando [dbo].[tipofresa]'
GO
CREATE TABLE [dbo].[tipofresa]
(
[idtipo] [int] NOT NULL,
[idmodelo] [int] NOT NULL,
[nombre] [char] (20) COLLATE Traditional_Spanish_CI_AS NULL,
[diametroexterior] [decimal] (18, 0) NULL,
[diametroagujero] [decimal] (18, 0) NULL,
[cantidaddientes] [int] NULL,
[plano] [char] (80) COLLATE Traditional_Spanish_CI_AS NULL,
[posiciondetrabajo] [char] (40) COLLATE Traditional_Spanish_CI_AS NULL,
[caracteristicas] [text] COLLATE Traditional_Spanish_CI_AS NULL,
[costo] [decimal] (18, 0) NULL,
[precio] [decimal] (18, 0) NULL,
[estado] [char] (15) COLLATE Traditional_Spanish_CI_AS NULL,
[imagen] [image] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
PRINT N'Creando clave principal [PK_tipofresa] en [dbo].[tipofresa]'
GO
ALTER TABLE [dbo].[tipofresa] ADD CONSTRAINT [PK_tipofresa] PRIMARY KEY CLUSTERED  ([idtipo], [idmodelo]) ON [PRIMARY]
GO
PRINT N'Creando [dbo].[proveedor]'
GO
CREATE TABLE [dbo].[proveedor]
(
[idproveedor] [int] NOT NULL,
[nombre] [char] (80) COLLATE Traditional_Spanish_CI_AS NULL,
[direccion] [char] (80) COLLATE Traditional_Spanish_CI_AS NULL,
[telefono] [char] (20) COLLATE Traditional_Spanish_CI_AS NULL,
[mail] [char] (80) COLLATE Traditional_Spanish_CI_AS NULL,
[nombrecontacto] [char] (80) COLLATE Traditional_Spanish_CI_AS NULL,
[idlocalidad] [int] NULL
) ON [PRIMARY]
GO
PRINT N'Creando clave principal [PK_proveedor] en [dbo].[proveedor]'
GO
ALTER TABLE [dbo].[proveedor] ADD CONSTRAINT [PK_proveedor] PRIMARY KEY CLUSTERED  ([idproveedor]) ON [PRIMARY]
GO
PRINT N'Creando [dbo].[proveedorxtipomateriaprima]'
GO
CREATE TABLE [dbo].[proveedorxtipomateriaprima]
(
[idproveedor] [int] NOT NULL,
[idtipomateriaprima] [int] NOT NULL
) ON [PRIMARY]
GO
PRINT N'Creando clave principal [PK_proveedorxtipomateriaprima] en [dbo].[proveedorxtipomateriaprima]'
GO
ALTER TABLE [dbo].[proveedorxtipomateriaprima] ADD CONSTRAINT [PK_proveedorxtipomateriaprima] PRIMARY KEY CLUSTERED  ([idproveedor], [idtipomateriaprima]) ON [PRIMARY]
GO
PRINT N'Creando [dbo].[parteadicional]'
GO
CREATE TABLE [dbo].[parteadicional]
(
[idadicional] [int] NOT NULL,
[idmodelo] [int] NOT NULL,
[nombre] [char] (60) COLLATE Traditional_Spanish_CI_AS NULL,
[plano] [char] (80) COLLATE Traditional_Spanish_CI_AS NULL,
[imagen] [image] NULL,
[idmateriaprima] [int] NULL,
[cantidad] [float] NULL,
[descripcion] [text] COLLATE Traditional_Spanish_CI_AS NULL,
[tiempo] [float] NULL,
[costo] [float] NULL,
[precio] [float] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
PRINT N'Creando clave principal [PK_parteadicional] en [dbo].[parteadicional]'
GO
ALTER TABLE [dbo].[parteadicional] ADD CONSTRAINT [PK_parteadicional] PRIMARY KEY CLUSTERED  ([idadicional], [idmodelo]) ON [PRIMARY]
GO
PRINT N'Creando [dbo].[partepedido]'
GO
CREATE TABLE [dbo].[partepedido]
(
[idpedido] [numeric] (18, 0) NOT NULL,
[idpartepedida] [int] NOT NULL,
[idmodelo] [int] NULL,
[idadicional] [int] NULL,
[cantidad] [int] NULL,
[precio] [decimal] (18, 0) NULL
) ON [PRIMARY]
GO
PRINT N'Creando clave principal [PK_partepedido] en [dbo].[partepedido]'
GO
ALTER TABLE [dbo].[partepedido] ADD CONSTRAINT [PK_partepedido] PRIMARY KEY CLUSTERED  ([idpedido], [idpartepedida]) ON [PRIMARY]
GO
PRINT N'Creando [dbo].[fresa]'
GO
CREATE TABLE [dbo].[fresa]
(
[nroserie] [int] NOT NULL,
[fechafinfabricacion] [datetime] NULL,
[costofabricacion] [decimal] (18, 0) NULL,
[estado] [int] NULL,
[nropedido] [numeric] (18, 0) NOT NULL,
[controlcalidad] [int] NULL,
[idhojaderuta] [int] NULL,
[precio] [decimal] (18, 0) NULL,
[idtipo] [int] NULL,
[idmodelo] [int] NULL
) ON [PRIMARY]
GO
PRINT N'Creando clave principal [PK_fresa] en [dbo].[fresa]'
GO
ALTER TABLE [dbo].[fresa] ADD CONSTRAINT [PK_fresa] PRIMARY KEY CLUSTERED  ([nroserie]) ON [PRIMARY]
GO
PRINT N'Creando [dbo].[tornero]'
GO
CREATE TABLE [dbo].[tornero]
(
[idtornero] [int] NOT NULL,
[nombre] [char] (50) COLLATE Traditional_Spanish_CI_AS NULL,
[apellido] [char] (50) COLLATE Traditional_Spanish_CI_AS NULL,
[domicilio] [char] (50) COLLATE Traditional_Spanish_CI_AS NULL,
[telefono] [char] (25) COLLATE Traditional_Spanish_CI_AS NULL,
[celular] [char] (25) COLLATE Traditional_Spanish_CI_AS NULL,
[cantidadtorneados] [int] NULL,
[efectividad] [float] NULL,
[observaciones] [text] COLLATE Traditional_Spanish_CI_AS NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
PRINT N'Creando clave principal [PK_tornero] en [dbo].[tornero]'
GO
ALTER TABLE [dbo].[tornero] ADD CONSTRAINT [PK_tornero] PRIMARY KEY CLUSTERED  ([idtornero]) ON [PRIMARY]
GO
PRINT N'Creando [dbo].[torneado]'
GO
CREATE TABLE [dbo].[torneado]
(
[idtorneado] [int] NOT NULL,
[fechasalidad] [datetime] NULL,
[fecharecepcion] [datetime] NULL,
[idtornero] [int] NULL,
[costo] [float] NULL
) ON [PRIMARY]
GO
PRINT N'Creando clave principal [PK_torneado] en [dbo].[torneado]'
GO
ALTER TABLE [dbo].[torneado] ADD CONSTRAINT [PK_torneado] PRIMARY KEY CLUSTERED  ([idtorneado]) ON [PRIMARY]
GO
PRINT N'Creando [dbo].[tipomateriaprima]'
GO
CREATE TABLE [dbo].[tipomateriaprima]
(
[idtipomateriaprima] [int] NOT NULL,
[nombre] [char] (40) COLLATE Traditional_Spanish_CI_AS NULL,
[direccion] [char] (40) COLLATE Traditional_Spanish_CI_AS NULL,
[stockactual] [int] NULL,
[stockminimo] [int] NULL,
[stockseguridad] [int] NULL,
[loteeconomico] [int] NULL,
[idunidadmedida] [int] NULL
) ON [PRIMARY]
GO
PRINT N'Creando clave principal [PK_tipomateriaprima] en [dbo].[tipomateriaprima]'
GO
ALTER TABLE [dbo].[tipomateriaprima] ADD CONSTRAINT [PK_tipomateriaprima] PRIMARY KEY CLUSTERED  ([idtipomateriaprima]) ON [PRIMARY]
GO
PRINT N'Creando [dbo].[detallemprecibida]'
GO
CREATE TABLE [dbo].[detallemprecibida]
(
[idmprecibida] [int] NOT NULL,
[cantidad] [int] NULL,
[preciol] [float] NULL,
[causarechazo] [char] (20) COLLATE Traditional_Spanish_CI_AS NULL,
[idestado] [int] NULL,
[idtipomateriaprima] [int] NOT NULL
) ON [PRIMARY]
GO
PRINT N'Creando [dbo].[menupadre]'
GO
CREATE TABLE [dbo].[menupadre]
(
[idmenu] [int] NOT NULL,
[nombre] [varchar] (50) COLLATE Traditional_Spanish_CI_AS NULL,
[activo] [bit] NULL
) ON [PRIMARY]
GO
PRINT N'Creando clave principal [PK_menupadre] en [dbo].[menupadre]'
GO
ALTER TABLE [dbo].[menupadre] ADD CONSTRAINT [PK_menupadre] PRIMARY KEY CLUSTERED  ([idmenu]) ON [PRIMARY]
GO
PRINT N'Creando [dbo].[cargo]'
GO
CREATE TABLE [dbo].[cargo]
(
[idcargo] [int] NOT NULL,
[nombre] [char] (20) COLLATE Traditional_Spanish_CI_AS NULL,
[descripcion] [char] (20) COLLATE Traditional_Spanish_CI_AS NULL
) ON [PRIMARY]
GO
PRINT N'Creando clave principal [PK_cargo] en [dbo].[cargo]'
GO
ALTER TABLE [dbo].[cargo] ADD CONSTRAINT [PK_cargo] PRIMARY KEY CLUSTERED  ([idcargo]) ON [PRIMARY]
GO
PRINT N'Creando [dbo].[empleado]'
GO
CREATE TABLE [dbo].[empleado]
(
[idlegajo] [int] NOT NULL,
[nombre] [char] (50) COLLATE Traditional_Spanish_CI_AS NULL,
[apellido] [char] (50) COLLATE Traditional_Spanish_CI_AS NULL,
[direccion] [char] (20) COLLATE Traditional_Spanish_CI_AS NULL,
[telefono] [char] (20) COLLATE Traditional_Spanish_CI_AS NULL,
[idcargo] [int] NULL,
[email] [char] (30) COLLATE Traditional_Spanish_CI_AS NULL,
[titulo] [char] (30) COLLATE Traditional_Spanish_CI_AS NULL,
[idlocalidad] [int] NULL,
[turno] [char] (30) COLLATE Traditional_Spanish_CI_AS NULL,
[idperfil] [int] NULL
) ON [PRIMARY]
GO
PRINT N'Creando clave principal [PK_empleado] en [dbo].[empleado]'
GO
ALTER TABLE [dbo].[empleado] ADD CONSTRAINT [PK_empleado] PRIMARY KEY CLUSTERED  ([idlegajo]) ON [PRIMARY]
GO
PRINT N'Creando [dbo].[detallehojaderuta]'
GO
CREATE TABLE [dbo].[detallehojaderuta]
(
[idhojaderuta] [int] NOT NULL,
[idetapadefabricacion] [int] NOT NULL,
[idlegajo] [int] NULL,
[idtorneado] [int] NULL,
[fechahorainicioreal] [datetime] NULL,
[fechahorainicioplanificada] [datetime] NULL,
[fechahorafinreal] [datetime] NULL,
[fechahorafinplanificada] [datetime] NULL,
[observaciones] [char] (30) COLLATE Traditional_Spanish_CI_AS NULL
) ON [PRIMARY]
GO
PRINT N'Creando clave principal [PK_detallehojaderuta] en [dbo].[detallehojaderuta]'
GO
ALTER TABLE [dbo].[detallehojaderuta] ADD CONSTRAINT [PK_detallehojaderuta] PRIMARY KEY CLUSTERED  ([idhojaderuta], [idetapadefabricacion]) ON [PRIMARY]
GO
PRINT N'Creando [dbo].[tipoacabado]'
GO
CREATE TABLE [dbo].[tipoacabado]
(
[nombre] [char] (40) COLLATE Traditional_Spanish_CI_AS NOT NULL,
[descripcion] [char] (10) COLLATE Traditional_Spanish_CI_AS NULL
) ON [PRIMARY]
GO
PRINT N'Creando clave principal [PK_tipoacabado] en [dbo].[tipoacabado]'
GO
ALTER TABLE [dbo].[tipoacabado] ADD CONSTRAINT [PK_tipoacabado] PRIMARY KEY CLUSTERED  ([nombre]) ON [PRIMARY]
GO
PRINT N'Creando [dbo].[parte]'
GO
CREATE TABLE [dbo].[parte]
(
[idmodelo] [int] NOT NULL,
[idtipofresa] [int] NOT NULL,
[idparte] [int] NOT NULL,
[cantidad] [float] NULL,
[nombre] [char] (40) COLLATE Traditional_Spanish_CI_AS NULL,
[descripcion] [text] COLLATE Traditional_Spanish_CI_AS NULL,
[idtipomateriaprima] [int] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
PRINT N'Creando clave principal [PK_parte] en [dbo].[parte]'
GO
ALTER TABLE [dbo].[parte] ADD CONSTRAINT [PK_parte] PRIMARY KEY CLUSTERED  ([idtipofresa], [idparte], [idmodelo]) ON [PRIMARY]
GO
PRINT N'Creando [dbo].[empresatransporte]'
GO
CREATE TABLE [dbo].[empresatransporte]
(
[nombre] [char] (30) COLLATE Traditional_Spanish_CI_AS NULL,
[direccion] [char] (50) COLLATE Traditional_Spanish_CI_AS NULL,
[telefono] [char] (15) COLLATE Traditional_Spanish_CI_AS NULL,
[idempresa] [int] NOT NULL
) ON [PRIMARY]
GO
PRINT N'Creando clave principal [PK_empresatransporte] en [dbo].[empresatransporte]'
GO
ALTER TABLE [dbo].[empresatransporte] ADD CONSTRAINT [PK_empresatransporte] PRIMARY KEY CLUSTERED  ([idempresa]) ON [PRIMARY]
GO
PRINT N'Creando [dbo].[hojaderuta]'
GO
CREATE TABLE [dbo].[hojaderuta]
(
[idhojaderuta] [int] NOT NULL,
[fechainicioproduccion] [datetime] NULL
) ON [PRIMARY]
GO
PRINT N'Creando clave principal [PK_hojaderuta] en [dbo].[hojaderuta]'
GO
ALTER TABLE [dbo].[hojaderuta] ADD CONSTRAINT [PK_hojaderuta] PRIMARY KEY CLUSTERED  ([idhojaderuta]) ON [PRIMARY]
GO
PRINT N'Creando [dbo].[operacion]'
GO
CREATE TABLE [dbo].[operacion]
(
[idoperacion] [int] NOT NULL,
[nombre] [char] (40) COLLATE Traditional_Spanish_CI_AS NULL,
[maquina] [char] (40) COLLATE Traditional_Spanish_CI_AS NULL,
[duracionpromedio] [float] NULL,
[idgradodificultad] [int] NULL,
[tolerancia] [float] NULL,
[descripcion] [text] COLLATE Traditional_Spanish_CI_AS NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
PRINT N'Creando clave principal [PK_operacion] en [dbo].[operacion]'
GO
ALTER TABLE [dbo].[operacion] ADD CONSTRAINT [PK_operacion] PRIMARY KEY CLUSTERED  ([idoperacion]) ON [PRIMARY]
GO
PRINT N'Creando [dbo].[etapadefabricacion]'
GO
CREATE TABLE [dbo].[etapadefabricacion]
(
[idetapafabricacion] [int] NOT NULL,
[idmodelo] [int] NOT NULL,
[idtipofresa] [int] NOT NULL,
[idoperacion] [int] NULL,
[orden] [int] NULL,
[tiempoadicional] [float] NULL,
[detalle] [text] COLLATE Traditional_Spanish_CI_AS NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
PRINT N'Creando clave principal [PK_etapadefabricacion] en [dbo].[etapadefabricacion]'
GO
ALTER TABLE [dbo].[etapadefabricacion] ADD CONSTRAINT [PK_etapadefabricacion] PRIMARY KEY CLUSTERED  ([idetapafabricacion], [idtipofresa], [idmodelo]) ON [PRIMARY]
GO
PRINT N'Creando [dbo].[ordencompramp]'
GO
CREATE TABLE [dbo].[ordencompramp]
(
[fecharealizacion] [datetime] NULL,
[plazodeentrega] [datetime] NULL,
[idordencompra] [int] NOT NULL,
[nroorden] [int] NULL,
[condicionesdepago] [char] (40) COLLATE Traditional_Spanish_CI_AS NULL,
[causa] [char] (40) COLLATE Traditional_Spanish_CI_AS NULL,
[idestado] [int] NULL,
[idproveedor] [int] NULL
) ON [PRIMARY]
GO
PRINT N'Creando clave principal [PK_ordencompramp] en [dbo].[ordencompramp]'
GO
ALTER TABLE [dbo].[ordencompramp] ADD CONSTRAINT [PK_ordencompramp] PRIMARY KEY CLUSTERED  ([idordencompra]) ON [PRIMARY]
GO
PRINT N'Creando [dbo].[mprecibida]'
GO
CREATE TABLE [dbo].[mprecibida]
(
[idmprecibida] [int] NOT NULL,
[fecharecepcion] [char] (20) COLLATE Traditional_Spanish_CI_AS NULL,
[numremito] [int] NULL,
[idordencompramp] [int] NULL
) ON [PRIMARY]
GO
PRINT N'Creando clave principal [PK_mprecibida] en [dbo].[mprecibida]'
GO
ALTER TABLE [dbo].[mprecibida] ADD CONSTRAINT [PK_mprecibida] PRIMARY KEY CLUSTERED  ([idmprecibida]) ON [PRIMARY]
GO
PRINT N'Creando [dbo].[detalleordencompra]'
GO
CREATE TABLE [dbo].[detalleordencompra]
(
[idordencompra] [int] NOT NULL,
[idtipomateriaprima] [int] NOT NULL,
[cantidad] [int] NULL,
[precio] [money] NULL,
[idestado] [int] NOT NULL
) ON [PRIMARY]
GO
PRINT N'Creando clave principal [PK_detalleordencompra] en [dbo].[detalleordencompra]'
GO
ALTER TABLE [dbo].[detalleordencompra] ADD CONSTRAINT [PK_detalleordencompra] PRIMARY KEY CLUSTERED  ([idordencompra], [idtipomateriaprima], [idestado]) ON [PRIMARY]
GO
PRINT N'Creando [dbo].[empresaxlocalidad]'
GO
CREATE TABLE [dbo].[empresaxlocalidad]
(
[idempresa] [int] NOT NULL,
[idlocalidad] [int] NOT NULL
) ON [PRIMARY]
GO
PRINT N'Creando clave principal [PK_empresaxlocalidad] en [dbo].[empresaxlocalidad]'
GO
ALTER TABLE [dbo].[empresaxlocalidad] ADD CONSTRAINT [PK_empresaxlocalidad] PRIMARY KEY CLUSTERED  ([idempresa], [idlocalidad]) ON [PRIMARY]
GO
PRINT N'Creando [dbo].[tipomaquina]'
GO
CREATE TABLE [dbo].[tipomaquina]
(
[nombre] [char] (40) COLLATE Traditional_Spanish_CI_AS NOT NULL,
[descripcion] [text] COLLATE Traditional_Spanish_CI_AS NULL,
[idtipo] [int] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
PRINT N'Creando clave principal [PK_tipomaquina] en [dbo].[tipomaquina]'
GO
ALTER TABLE [dbo].[tipomaquina] ADD CONSTRAINT [PK_tipomaquina] PRIMARY KEY CLUSTERED  ([nombre]) ON [PRIMARY]
GO
PRINT N'Creando [dbo].[maquina]'
GO
CREATE TABLE [dbo].[maquina]
(
[idmaquina] [int] NOT NULL,
[nombre] [char] (40) COLLATE Traditional_Spanish_CI_AS NOT NULL,
[descripcion] [text] COLLATE Traditional_Spanish_CI_AS NULL,
[numerodeserie] [char] (20) COLLATE Traditional_Spanish_CI_AS NULL,
[potencia] [char] (20) COLLATE Traditional_Spanish_CI_AS NULL,
[costodecompra] [decimal] (18, 0) NULL,
[estadodeadquisicion] [char] (20) COLLATE Traditional_Spanish_CI_AS NULL,
[idestado] [int] NULL,
[horasdeuso] [datetime] NULL,
[tipomaquina] [char] (40) COLLATE Traditional_Spanish_CI_AS NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
PRINT N'Creando clave principal [PK_maquina] en [dbo].[maquina]'
GO
ALTER TABLE [dbo].[maquina] ADD CONSTRAINT [PK_maquina] PRIMARY KEY CLUSTERED  ([idmaquina]) ON [PRIMARY]
GO
PRINT N'Creando [dbo].[formadeentrega]'
GO
CREATE TABLE [dbo].[formadeentrega]
(
[idformadeentrega] [int] NOT NULL,
[nombre] [char] (20) COLLATE Traditional_Spanish_CI_AS NULL,
[descripcion] [char] (10) COLLATE Traditional_Spanish_CI_AS NULL
) ON [PRIMARY]
GO
PRINT N'Creando clave principal [PK_formadeentrega] en [dbo].[formadeentrega]'
GO
ALTER TABLE [dbo].[formadeentrega] ADD CONSTRAINT [PK_formadeentrega] PRIMARY KEY CLUSTERED  ([idformadeentrega]) ON [PRIMARY]
GO
PRINT N'Creando [dbo].[tipodocumento]'
GO
CREATE TABLE [dbo].[tipodocumento]
(
[idtipodocumento] [int] NOT NULL,
[nombre] [char] (10) COLLATE Traditional_Spanish_CI_AS NULL,
[descipcion] [char] (10) COLLATE Traditional_Spanish_CI_AS NULL
) ON [PRIMARY]
GO
PRINT N'Creando clave principal [PK_tipodocumento] en [dbo].[tipodocumento]'
GO
ALTER TABLE [dbo].[tipodocumento] ADD CONSTRAINT [PK_tipodocumento] PRIMARY KEY CLUSTERED  ([idtipodocumento]) ON [PRIMARY]
GO
PRINT N'Creando [dbo].[cliente]'
GO
CREATE TABLE [dbo].[cliente]
(
[idcliente] [int] NOT NULL,
[nombre] [char] (50) COLLATE Traditional_Spanish_CI_AS NOT NULL,
[apellido] [char] (50) COLLATE Traditional_Spanish_CI_AS NULL,
[idtipodocumento] [int] NULL,
[direccion] [char] (50) COLLATE Traditional_Spanish_CI_AS NULL,
[localidad] [int] NULL,
[mail] [char] (50) COLLATE Traditional_Spanish_CI_AS NULL,
[telefono] [char] (20) COLLATE Traditional_Spanish_CI_AS NULL,
[documento] [numeric] (18, 0) NULL,
[celular] [char] (20) COLLATE Traditional_Spanish_CI_AS NULL
) ON [PRIMARY]
GO
PRINT N'Creando clave principal [PK_cliente] en [dbo].[cliente]'
GO
ALTER TABLE [dbo].[cliente] ADD CONSTRAINT [PK_cliente] PRIMARY KEY CLUSTERED  ([idcliente]) ON [PRIMARY]
GO
PRINT N'Creando [dbo].[mododeavance]'
GO
CREATE TABLE [dbo].[mododeavance]
(
[nombre] [char] (40) COLLATE Traditional_Spanish_CI_AS NOT NULL,
[descripcion] [char] (10) COLLATE Traditional_Spanish_CI_AS NULL
) ON [PRIMARY]
GO
PRINT N'Creando clave principal [PK_mododeavance] en [dbo].[mododeavance]'
GO
ALTER TABLE [dbo].[mododeavance] ADD CONSTRAINT [PK_mododeavance] PRIMARY KEY CLUSTERED  ([nombre]) ON [PRIMARY]
GO
PRINT N'Creando [dbo].[viajantexlocalidad]'
GO
CREATE TABLE [dbo].[viajantexlocalidad]
(
[idviajante] [int] NOT NULL,
[idlocalidad] [int] NOT NULL
) ON [PRIMARY]
GO
PRINT N'Creando clave principal [PK_viajantexlocalidad] en [dbo].[viajantexlocalidad]'
GO
ALTER TABLE [dbo].[viajantexlocalidad] ADD CONSTRAINT [PK_viajantexlocalidad] PRIMARY KEY CLUSTERED  ([idviajante], [idlocalidad]) ON [PRIMARY]
GO
PRINT N'Creando [dbo].[estado]'
GO
CREATE TABLE [dbo].[estado]
(
[idestado] [int] NOT NULL,
[nombre] [char] (40) COLLATE Traditional_Spanish_CI_AS NULL,
[descripcion] [char] (40) COLLATE Traditional_Spanish_CI_AS NULL
) ON [PRIMARY]
GO
PRINT N'Creando clave principal [PK_estado] en [dbo].[estado]'
GO
ALTER TABLE [dbo].[estado] ADD CONSTRAINT [PK_estado] PRIMARY KEY CLUSTERED  ([idestado]) ON [PRIMARY]
GO
PRINT N'Creando [dbo].[materialatrabajar]'
GO
CREATE TABLE [dbo].[materialatrabajar]
(
[nombre] [char] (40) COLLATE Traditional_Spanish_CI_AS NOT NULL,
[descripcion] [text] COLLATE Traditional_Spanish_CI_AS NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
PRINT N'Creando clave principal [PK_materialatrabajar] en [dbo].[materialatrabajar]'
GO
ALTER TABLE [dbo].[materialatrabajar] ADD CONSTRAINT [PK_materialatrabajar] PRIMARY KEY CLUSTERED  ([nombre]) ON [PRIMARY]
GO
PRINT N'Creando [dbo].[perfil]'
GO
CREATE TABLE [dbo].[perfil]
(
[idperfil] [int] NOT NULL,
[descripcion] [char] (50) COLLATE Traditional_Spanish_CI_AS NULL,
[idlegajo] [int] NULL
) ON [PRIMARY]
GO
PRINT N'Creando clave principal [PK_perfil] en [dbo].[perfil]'
GO
ALTER TABLE [dbo].[perfil] ADD CONSTRAINT [PK_perfil] PRIMARY KEY CLUSTERED  ([idperfil]) ON [PRIMARY]
GO
PRINT N'Creando [dbo].[formxperfil]'
GO
CREATE TABLE [dbo].[formxperfil]
(
[idformulario] [int] NOT NULL,
[idperfil] [int] NOT NULL
) ON [PRIMARY]
GO
PRINT N'Creando clave principal [PK_formxperfil] en [dbo].[formxperfil]'
GO
ALTER TABLE [dbo].[formxperfil] ADD CONSTRAINT [PK_formxperfil] PRIMARY KEY CLUSTERED  ([idformulario], [idperfil]) ON [PRIMARY]
GO
PRINT N'Creando [dbo].[desperfecto]'
GO
CREATE TABLE [dbo].[desperfecto]
(
[iddesperfecto] [int] NOT NULL,
[idtipodesperfecto] [int] NULL,
[fecharotura] [datetime] NULL,
[causa] [char] (30) COLLATE Traditional_Spanish_CI_AS NULL,
[fechareparacion] [datetime] NULL,
[costo] [decimal] (18, 0) NULL,
[idmaquina] [int] NULL
) ON [PRIMARY]
GO
PRINT N'Creando clave principal [PK_desperfecto] en [dbo].[desperfecto]'
GO
ALTER TABLE [dbo].[desperfecto] ADD CONSTRAINT [PK_desperfecto] PRIMARY KEY CLUSTERED  ([iddesperfecto]) ON [PRIMARY]
GO
PRINT N'Creando [dbo].[objetodelservicio]'
GO
CREATE TABLE [dbo].[objetodelservicio]
(
[idobjetodelservicio] [int] NOT NULL,
[nombre] [char] (20) COLLATE Traditional_Spanish_CI_AS NULL,
[descripcion] [char] (30) COLLATE Traditional_Spanish_CI_AS NULL,
[nroserie] [int] NULL,
[cantidad] [int] NULL
) ON [PRIMARY]
GO
PRINT N'Creando clave principal [PK_objetodelservicio] en [dbo].[objetodelservicio]'
GO
ALTER TABLE [dbo].[objetodelservicio] ADD CONSTRAINT [PK_objetodelservicio] PRIMARY KEY CLUSTERED  ([idobjetodelservicio]) ON [PRIMARY]
GO
PRINT N'Creando [dbo].[maquinaFresa]'
GO
CREATE TABLE [dbo].[maquinaFresa]
(
[idmaquina] [int] NOT NULL,
[nombre] [text] COLLATE Traditional_Spanish_CI_AS NOT NULL,
[potencia] [float] NULL,
[rpmdeleje] [float] NULL,
[sentidodegiro] [char] (30) COLLATE Traditional_Spanish_CI_AS NULL,
[caracteristicas] [text] COLLATE Traditional_Spanish_CI_AS NULL,
[estado] [char] (25) COLLATE Traditional_Spanish_CI_AS NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
PRINT N'Creando clave principal [PK_maquinaFresa] en [dbo].[maquinaFresa]'
GO
ALTER TABLE [dbo].[maquinaFresa] ADD CONSTRAINT [PK_maquinaFresa] PRIMARY KEY CLUSTERED  ([idmaquina]) ON [PRIMARY]
GO
PRINT N'Creando [dbo].[fresaxmaquina]'
GO
CREATE TABLE [dbo].[fresaxmaquina]
(
[idmodelo] [int] NOT NULL,
[idmaquina] [int] NOT NULL
) ON [PRIMARY]
GO
PRINT N'Creando clave principal [PK_fresaxmaquina] en [dbo].[fresaxmaquina]'
GO
ALTER TABLE [dbo].[fresaxmaquina] ADD CONSTRAINT [PK_fresaxmaquina] PRIMARY KEY CLUSTERED  ([idmodelo], [idmaquina]) ON [PRIMARY]
GO
PRINT N'Creando [dbo].[pago]'
GO
CREATE TABLE [dbo].[pago]
(
[monto] [float] NULL,
[fechadepago] [datetime] NULL,
[formadepago] [char] (10) COLLATE Traditional_Spanish_CI_AS NULL,
[idordencompra] [int] NULL
) ON [PRIMARY]
GO
PRINT N'Creando [dbo].[formxempleado]'
GO
CREATE TABLE [dbo].[formxempleado]
(
[idformulario] [int] NOT NULL,
[idlegajo] [int] NOT NULL
) ON [PRIMARY]
GO
PRINT N'Creando clave principal [PK_formxempleado] en [dbo].[formxempleado]'
GO
ALTER TABLE [dbo].[formxempleado] ADD CONSTRAINT [PK_formxempleado] PRIMARY KEY CLUSTERED  ([idformulario], [idlegajo]) ON [PRIMARY]
GO
PRINT N'Creando [dbo].[unidaddemedida]'
GO
CREATE TABLE [dbo].[unidaddemedida]
(
[idunidadmedida] [int] NOT NULL,
[nombre] [char] (20) COLLATE Traditional_Spanish_CI_AS NULL,
[descripcion] [char] (20) COLLATE Traditional_Spanish_CI_AS NULL,
[abreviacion] [char] (20) COLLATE Traditional_Spanish_CI_AS NULL,
[escala] [char] (20) COLLATE Traditional_Spanish_CI_AS NULL
) ON [PRIMARY]
GO
PRINT N'Creando clave principal [PK_unidaddemedida] en [dbo].[unidaddemedida]'
GO
ALTER TABLE [dbo].[unidaddemedida] ADD CONSTRAINT [PK_unidaddemedida] PRIMARY KEY CLUSTERED  ([idunidadmedida]) ON [PRIMARY]
GO
PRINT N'Creando [dbo].[controlcalidad]'
GO
CREATE TABLE [dbo].[controlcalidad]
(
[idcontrol] [int] NOT NULL,
[observaciones] [char] (250) COLLATE Traditional_Spanish_CI_AS NULL,
[medidas] [char] (10) COLLATE Traditional_Spanish_CI_AS NULL,
[pintura] [char] (10) COLLATE Traditional_Spanish_CI_AS NULL,
[soldadura] [char] (10) COLLATE Traditional_Spanish_CI_AS NULL,
[torneado] [char] (10) COLLATE Traditional_Spanish_CI_AS NULL,
[idfresa] [int] NULL,
[fechahoracontrol] [nvarchar] (50) COLLATE Traditional_Spanish_CI_AS NULL
) ON [PRIMARY]
GO
PRINT N'Creando clave principal [PK_controlcalidad] en [dbo].[controlcalidad]'
GO
ALTER TABLE [dbo].[controlcalidad] ADD CONSTRAINT [PK_controlcalidad] PRIMARY KEY CLUSTERED  ([idcontrol]) ON [PRIMARY]
GO
PRINT N'Creando [dbo].[mensaje]'
GO
CREATE TABLE [dbo].[mensaje]
(
[idMensaje] [int] NOT NULL,
[asunto] [varchar] (100) COLLATE Traditional_Spanish_CI_AS NULL,
[idRemitente] [int] NULL,
[idDestinatario] [int] NULL,
[mensaje] [varchar] (555) COLLATE Traditional_Spanish_CI_AS NULL,
[prioridad] [int] NULL,
[leido] [bit] NULL,
[fechaRecepion] [datetime] NULL,
[fechaLectura] [datetime] NULL
) ON [PRIMARY]
GO
PRINT N'Creando clave principal [PK_Mensaje] en [dbo].[mensaje]'
GO
ALTER TABLE [dbo].[mensaje] ADD CONSTRAINT [PK_Mensaje] PRIMARY KEY CLUSTERED  ([idMensaje]) ON [PRIMARY]
GO
PRINT N'Creando [dbo].[gradodificultad]'
GO
CREATE TABLE [dbo].[gradodificultad]
(
[idgradodificultad] [int] NOT NULL,
[nombre] [char] (20) COLLATE Traditional_Spanish_CI_AS NULL,
[descripcion] [text] COLLATE Traditional_Spanish_CI_AS NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
PRINT N'Creando clave principal [PK_gradodificultad] en [dbo].[gradodificultad]'
GO
ALTER TABLE [dbo].[gradodificultad] ADD CONSTRAINT [PK_gradodificultad] PRIMARY KEY CLUSTERED  ([idgradodificultad]) ON [PRIMARY]
GO
PRINT N'Creando [dbo].[presupuesto]'
GO
CREATE TABLE [dbo].[presupuesto]
(
[idpresupuesto] [int] NOT NULL,
[fecha] [datetime] NULL,
[idcliente] [int] NULL,
[idempleado] [int] NULL
) ON [PRIMARY]
GO
PRINT N'Creando clave principal [PK_presupuesto] en [dbo].[presupuesto]'
GO
ALTER TABLE [dbo].[presupuesto] ADD CONSTRAINT [PK_presupuesto] PRIMARY KEY CLUSTERED  ([idpresupuesto]) ON [PRIMARY]
GO
PRINT N'Creando [dbo].[cuentausuario]'
GO
CREATE TABLE [dbo].[cuentausuario]
(
[usuario] [char] (6) COLLATE Traditional_Spanish_CI_AS NOT NULL,
[contraseña] [char] (100) COLLATE Traditional_Spanish_CI_AS NOT NULL,
[creacion] [datetime] NULL,
[idlegajo] [int] NOT NULL
) ON [PRIMARY]
GO
PRINT N'Creando clave principal [PK_cuentausuario] en [dbo].[cuentausuario]'
GO
ALTER TABLE [dbo].[cuentausuario] ADD CONSTRAINT [PK_cuentausuario] PRIMARY KEY CLUSTERED  ([usuario]) ON [PRIMARY]
GO
PRINT N'Creando [dbo].[tipodesperfecto]'
GO
CREATE TABLE [dbo].[tipodesperfecto]
(
[idtipodesperfecto] [int] NOT NULL,
[nombre] [char] (20) COLLATE Traditional_Spanish_CI_AS NULL,
[descripcion] [char] (30) COLLATE Traditional_Spanish_CI_AS NULL
) ON [PRIMARY]
GO
PRINT N'Creando clave principal [PK_tipodesperfecto] en [dbo].[tipodesperfecto]'
GO
ALTER TABLE [dbo].[tipodesperfecto] ADD CONSTRAINT [PK_tipodesperfecto] PRIMARY KEY CLUSTERED  ([idtipodesperfecto]) ON [PRIMARY]
GO
PRINT N'Creando [dbo].[detallepresupuesto]'
GO
CREATE TABLE [dbo].[detallepresupuesto]
(
[iddetpre] [int] NOT NULL,
[idpresupuesto] [int] NOT NULL,
[idmodelo] [int] NULL,
[idproducto] [int] NULL,
[tipo] [int] NULL,
[cantidad] [int] NULL,
[precio] [float] NULL
) ON [PRIMARY]
GO
PRINT N'Creando clave principal [PK_detallepresupuesto] en [dbo].[detallepresupuesto]'
GO
ALTER TABLE [dbo].[detallepresupuesto] ADD CONSTRAINT [PK_detallepresupuesto] PRIMARY KEY CLUSTERED  ([idpresupuesto], [iddetpre]) ON [PRIMARY]
GO
PRINT N'Creando [dbo].[app_param]'
GO
CREATE TABLE [dbo].[app_param]
(
[id] [int] NOT NULL,
[label] [varchar] (50) COLLATE Traditional_Spanish_CI_AS NULL,
[numeric_value] [decimal] (18, 4) NULL,
[string_value] [nvarchar] (max) COLLATE Traditional_Spanish_CI_AS NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
PRINT N'Creando [dbo].[sp_generate_inserts]'
GO
--Turn system object marking on
--EXEC master.dbo.sp_MS_upd_sysobj_category 1
--GO

CREATE PROC [dbo].[sp_generate_inserts]
(
	@table_name varchar(776),  		-- The table/view for which the INSERT statements will be generated using the existing data
	@target_table varchar(776) = NULL, 	-- Use this parameter to specify a different table name into which the data will be inserted
	@include_column_list bit = 1,		-- Use this parameter to include/ommit column list in the generated INSERT statement
	@from varchar(800) = NULL, 		-- Use this parameter to filter the rows based on a filter condition (using WHERE)
	@include_timestamp bit = 0, 		-- Specify 1 for this parameter, if you want to include the TIMESTAMP/ROWVERSION column's data in the INSERT statement
	@debug_mode bit = 0,			-- If @debug_mode is set to 1, the SQL statements constructed by this procedure will be printed for later examination
	@owner varchar(64) = NULL,		-- Use this parameter if you are not the owner of the table
	@ommit_images bit = 0,			-- Use this parameter to generate INSERT statements by omitting the 'image' columns
	@ommit_identity bit = 0,		-- Use this parameter to ommit the identity columns
	@top int = NULL,			-- Use this parameter to generate INSERT statements only for the TOP n rows
	@cols_to_include varchar(8000) = NULL,	-- List of columns to be included in the INSERT statement
	@cols_to_exclude varchar(8000) = NULL,	-- List of columns to be excluded from the INSERT statement
	@disable_constraints bit = 0,		-- When 1, disables foreign key constraints and enables them after the INSERT statements
	@ommit_computed_cols bit = 0		-- When 1, computed columns will not be included in the INSERT statement
	
)
AS
BEGIN

/***********************************************************************************************************
Procedure:	sp_generate_inserts  (Build 22) 
		(Copyright © 2002 Narayana Vyas Kondreddi. All rights reserved.)
                                          
Purpose:	To generate INSERT statements from existing data. 
		These INSERTS can be executed to regenerate the data at some other location.
		This procedure is also useful to create a database setup, where in you can 
		script your data along with your table definitions.

Written by:	Narayana Vyas Kondreddi
	        http://vyaskn.tripod.com

Acknowledgements:
		Divya Kalra	-- For beta testing
		Mark Charsley	-- For reporting a problem with scripting uniqueidentifier columns with NULL values
		Artur Zeygman	-- For helping me simplify a bit of code for handling non-dbo owned tables
		Joris Laperre   -- For reporting a regression bug in handling text/ntext columns

Tested on: 	SQL Server 7.0 and SQL Server 2000

Date created:	January 17th 2001 21:52 GMT

Date modified:	May 1st 2002 19:50 GMT

Email: 		vyaskn@hotmail.com

NOTE:		This procedure may not work with tables with too many columns.
		Results can be unpredictable with huge text columns or SQL Server 2000's sql_variant data types
		Whenever possible, Use @include_column_list parameter to ommit column list in the INSERT statement, for better results
		IMPORTANT: This procedure is not tested with internation data (Extended characters or Unicode). If needed
		you might want to convert the datatypes of character variables in this procedure to their respective unicode counterparts
		like nchar and nvarchar
		

Example 1:	To generate INSERT statements for table 'titles':
		
		EXEC sp_generate_inserts 'titles'

Example 2: 	To ommit the column list in the INSERT statement: (Column list is included by default)
		IMPORTANT: If you have too many columns, you are advised to ommit column list, as shown below,
		to avoid erroneous results
		
		EXEC sp_generate_inserts 'titles', @include_column_list = 0

Example 3:	To generate INSERT statements for 'titlesCopy' table from 'titles' table:

		EXEC sp_generate_inserts 'titles', 'titlesCopy'

Example 4:	To generate INSERT statements for 'titles' table for only those titles 
		which contain the word 'Computer' in them:
		NOTE: Do not complicate the FROM or WHERE clause here. It's assumed that you are good with T-SQL if you are using this parameter

		EXEC sp_generate_inserts 'titles', @from = "from titles where title like '%Computer%'"

Example 5: 	To specify that you want to include TIMESTAMP column's data as well in the INSERT statement:
		(By default TIMESTAMP column's data is not scripted)

		EXEC sp_generate_inserts 'titles', @include_timestamp = 1

Example 6:	To print the debug information:
  
		EXEC sp_generate_inserts 'titles', @debug_mode = 1

Example 7: 	If you are not the owner of the table, use @owner parameter to specify the owner name
		To use this option, you must have SELECT permissions on that table

		EXEC sp_generate_inserts Nickstable, @owner = 'Nick'

Example 8: 	To generate INSERT statements for the rest of the columns excluding images
		When using this otion, DO NOT set @include_column_list parameter to 0.

		EXEC sp_generate_inserts imgtable, @ommit_images = 1

Example 9: 	To generate INSERT statements excluding (ommiting) IDENTITY columns:
		(By default IDENTITY columns are included in the INSERT statement)

		EXEC sp_generate_inserts mytable, @ommit_identity = 1

Example 10: 	To generate INSERT statements for the TOP 10 rows in the table:
		
		EXEC sp_generate_inserts mytable, @top = 10

Example 11: 	To generate INSERT statements with only those columns you want:
		
		EXEC sp_generate_inserts titles, @cols_to_include = "'title','title_id','au_id'"

Example 12: 	To generate INSERT statements by omitting certain columns:
		
		EXEC sp_generate_inserts titles, @cols_to_exclude = "'title','title_id','au_id'"

Example 13:	To avoid checking the foreign key constraints while loading data with INSERT statements:
		
		EXEC sp_generate_inserts titles, @disable_constraints = 1

Example 14: 	To exclude computed columns from the INSERT statement:
		EXEC sp_generate_inserts MyTable, @ommit_computed_cols = 1
***********************************************************************************************************/

SET NOCOUNT ON

--Making sure user only uses either @cols_to_include or @cols_to_exclude
IF ((@cols_to_include IS NOT NULL) AND (@cols_to_exclude IS NOT NULL))
	BEGIN
		RAISERROR('Use either @cols_to_include or @cols_to_exclude. Do not use both the parameters at once',16,1)
		RETURN -1 --Failure. Reason: Both @cols_to_include and @cols_to_exclude parameters are specified
	END

--Making sure the @cols_to_include and @cols_to_exclude parameters are receiving values in proper format
IF ((@cols_to_include IS NOT NULL) AND (PATINDEX('''%''',@cols_to_include) = 0))
	BEGIN
		RAISERROR('Invalid use of @cols_to_include property',16,1)
		PRINT 'Specify column names surrounded by single quotes and separated by commas'
		PRINT 'Eg: EXEC sp_generate_inserts titles, @cols_to_include = "''title_id'',''title''"'
		RETURN -1 --Failure. Reason: Invalid use of @cols_to_include property
	END

IF ((@cols_to_exclude IS NOT NULL) AND (PATINDEX('''%''',@cols_to_exclude) = 0))
	BEGIN
		RAISERROR('Invalid use of @cols_to_exclude property',16,1)
		PRINT 'Specify column names surrounded by single quotes and separated by commas'
		PRINT 'Eg: EXEC sp_generate_inserts titles, @cols_to_exclude = "''title_id'',''title''"'
		RETURN -1 --Failure. Reason: Invalid use of @cols_to_exclude property
	END


--Checking to see if the database name is specified along wih the table name
--Your database context should be local to the table for which you want to generate INSERT statements
--specifying the database name is not allowed
IF (PARSENAME(@table_name,3)) IS NOT NULL
	BEGIN
		RAISERROR('Do not specify the database name. Be in the required database and just specify the table name.',16,1)
		RETURN -1 --Failure. Reason: Database name is specified along with the table name, which is not allowed
	END

--Checking for the existence of 'user table' or 'view'
--This procedure is not written to work on system tables
--To script the data in system tables, just create a view on the system tables and script the view instead

IF @owner IS NULL
	BEGIN
		IF ((OBJECT_ID(@table_name,'U') IS NULL) AND (OBJECT_ID(@table_name,'V') IS NULL)) 
			BEGIN
				RAISERROR('User table or view not found.',16,1)
				PRINT 'You may see this error, if you are not the owner of this table or view. In that case use @owner parameter to specify the owner name.'
				PRINT 'Make sure you have SELECT permission on that table or view.'
				RETURN -1 --Failure. Reason: There is no user table or view with this name
			END
	END
ELSE
	BEGIN
		IF NOT EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = @table_name AND (TABLE_TYPE = 'BASE TABLE' OR TABLE_TYPE = 'VIEW') AND TABLE_SCHEMA = @owner)
			BEGIN
				RAISERROR('User table or view not found.',16,1)
				PRINT 'You may see this error, if you are not the owner of this table. In that case use @owner parameter to specify the owner name.'
				PRINT 'Make sure you have SELECT permission on that table or view.'
				RETURN -1 --Failure. Reason: There is no user table or view with this name		
			END
	END

--Variable declarations
DECLARE		@Column_ID int, 		
		@Column_List varchar(8000), 
		@Column_Name varchar(128), 
		@Start_Insert varchar(786), 
		@Data_Type varchar(128), 
		@Actual_Values varchar(8000),	--This is the string that will be finally executed to generate INSERT statements
		@IDN varchar(128)		--Will contain the IDENTITY column's name in the table

--Variable Initialization
SET @IDN = ''
SET @Column_ID = 0
SET @Column_Name = ''
SET @Column_List = ''
SET @Actual_Values = ''

IF @owner IS NULL 
	BEGIN
		SET @Start_Insert = 'INSERT INTO ' + '[' + RTRIM(COALESCE(@target_table,@table_name)) + ']' 
	END
ELSE
	BEGIN
		SET @Start_Insert = 'INSERT ' + '[' + LTRIM(RTRIM(@owner)) + '].' + '[' + RTRIM(COALESCE(@target_table,@table_name)) + ']' 		
	END


--To get the first column's ID

SELECT	@Column_ID = MIN(ORDINAL_POSITION) 	
FROM	INFORMATION_SCHEMA.COLUMNS (NOLOCK) 
WHERE 	TABLE_NAME = @table_name AND
(@owner IS NULL OR TABLE_SCHEMA = @owner)



--Loop through all the columns of the table, to get the column names and their data types
WHILE @Column_ID IS NOT NULL
	BEGIN
		SELECT 	@Column_Name = QUOTENAME(COLUMN_NAME), 
		@Data_Type = DATA_TYPE 
		FROM 	INFORMATION_SCHEMA.COLUMNS (NOLOCK) 
		WHERE 	ORDINAL_POSITION = @Column_ID AND 
		TABLE_NAME = @table_name AND
		(@owner IS NULL OR TABLE_SCHEMA = @owner)



		IF @cols_to_include IS NOT NULL --Selecting only user specified columns
		BEGIN
			IF CHARINDEX( '''' + SUBSTRING(@Column_Name,2,LEN(@Column_Name)-2) + '''',@cols_to_include) = 0 
			BEGIN
				GOTO SKIP_LOOP
			END
		END

		IF @cols_to_exclude IS NOT NULL --Selecting only user specified columns
		BEGIN
			IF CHARINDEX( '''' + SUBSTRING(@Column_Name,2,LEN(@Column_Name)-2) + '''',@cols_to_exclude) <> 0 
			BEGIN
				GOTO SKIP_LOOP
			END
		END

		--Making sure to output SET IDENTITY_INSERT ON/OFF in case the table has an IDENTITY column
		IF (SELECT COLUMNPROPERTY( OBJECT_ID(QUOTENAME(COALESCE(@owner,USER_NAME())) + '.' + @table_name),SUBSTRING(@Column_Name,2,LEN(@Column_Name) - 2),'IsIdentity')) = 1 
		BEGIN
			IF @ommit_identity = 0 --Determing whether to include or exclude the IDENTITY column
				SET @IDN = @Column_Name
			ELSE
				GOTO SKIP_LOOP			
		END
		
		--Making sure whether to output computed columns or not
		IF @ommit_computed_cols = 1
		BEGIN
			IF (SELECT COLUMNPROPERTY( OBJECT_ID(QUOTENAME(COALESCE(@owner,USER_NAME())) + '.' + @table_name),SUBSTRING(@Column_Name,2,LEN(@Column_Name) - 2),'IsComputed')) = 1 
			BEGIN
				GOTO SKIP_LOOP					
			END
		END
		
		--Tables with columns of IMAGE data type are not supported for obvious reasons
		IF(@Data_Type in ('image'))
			BEGIN
				IF (@ommit_images = 0)
					BEGIN
						RAISERROR('Tables with image columns are not supported.',16,1)
						PRINT 'Use @ommit_images = 1 parameter to generate INSERTs for the rest of the columns.'
						PRINT 'DO NOT ommit Column List in the INSERT statements. If you ommit column list using @include_column_list=0, the generated INSERTs will fail.'
						RETURN -1 --Failure. Reason: There is a column with image data type
					END
				ELSE
					BEGIN
					GOTO SKIP_LOOP
					END
			END

		--Determining the data type of the column and depending on the data type, the VALUES part of
		--the INSERT statement is generated. Care is taken to handle columns with NULL values. Also
		--making sure, not to lose any data from flot, real, money, smallmomey, datetime columns
		SET @Actual_Values = @Actual_Values  +
		CASE 
			WHEN @Data_Type IN ('char','varchar','nchar','nvarchar') 
				THEN 
					'COALESCE('''''''' + REPLACE(RTRIM(' + @Column_Name + '),'''''''','''''''''''')+'''''''',''NULL'')'
			WHEN @Data_Type IN ('datetime','smalldatetime') 
				THEN 
					'COALESCE('''''''' + RTRIM(CONVERT(char,' + @Column_Name + ',109))+'''''''',''NULL'')'
			WHEN @Data_Type IN ('uniqueidentifier') 
				THEN  
					'COALESCE('''''''' + REPLACE(CONVERT(char(255),RTRIM(' + @Column_Name + ')),'''''''','''''''''''')+'''''''',''NULL'')'
			WHEN @Data_Type IN ('text','ntext') 
				THEN  
					'COALESCE('''''''' + REPLACE(CONVERT(char(8000),' + @Column_Name + '),'''''''','''''''''''')+'''''''',''NULL'')'					
			WHEN @Data_Type IN ('binary','varbinary') 
				THEN  
					'COALESCE(RTRIM(CONVERT(char,' + 'CONVERT(int,' + @Column_Name + '))),''NULL'')'  
			WHEN @Data_Type IN ('timestamp','rowversion') 
				THEN  
					CASE 
						WHEN @include_timestamp = 0 
							THEN 
								'''DEFAULT''' 
							ELSE 
								'COALESCE(RTRIM(CONVERT(char,' + 'CONVERT(int,' + @Column_Name + '))),''NULL'')'  
					END
			WHEN @Data_Type IN ('float','real','money','smallmoney')
				THEN
					'COALESCE(LTRIM(RTRIM(' + 'CONVERT(char, ' +  @Column_Name  + ',2)' + ')),''NULL'')' 
			ELSE 
				'COALESCE(LTRIM(RTRIM(' + 'CONVERT(char, ' +  @Column_Name  + ')' + ')),''NULL'')' 
		END   + '+' +  ''',''' + ' + '
		
		--Generating the column list for the INSERT statement
		SET @Column_List = @Column_List +  @Column_Name + ','	

		SKIP_LOOP: --The label used in GOTO

		SELECT 	@Column_ID = MIN(ORDINAL_POSITION) 
		FROM 	INFORMATION_SCHEMA.COLUMNS (NOLOCK) 
		WHERE 	TABLE_NAME = @table_name AND 
		ORDINAL_POSITION > @Column_ID AND
		(@owner IS NULL OR TABLE_SCHEMA = @owner)


	--Loop ends here!
	END

--To get rid of the extra characters that got concatenated during the last run through the loop
SET @Column_List = LEFT(@Column_List,len(@Column_List) - 1)
SET @Actual_Values = LEFT(@Actual_Values,len(@Actual_Values) - 6)

IF LTRIM(@Column_List) = '' 
	BEGIN
		RAISERROR('No columns to select. There should at least be one column to generate the output',16,1)
		RETURN -1 --Failure. Reason: Looks like all the columns are ommitted using the @cols_to_exclude parameter
	END

--Forming the final string that will be executed, to output the INSERT statements
IF (@include_column_list <> 0)
	BEGIN
		SET @Actual_Values = 
			'SELECT ' +  
			CASE WHEN @top IS NULL OR @top < 0 THEN '' ELSE ' TOP ' + LTRIM(STR(@top)) + ' ' END + 
			'''' + RTRIM(@Start_Insert) + 
			' ''+' + '''(' + RTRIM(@Column_List) +  '''+' + ''')''' + 
			' +''VALUES(''+ ' +  @Actual_Values  + '+'')''' + ' ' + 
			COALESCE(@from,' FROM ' + CASE WHEN @owner IS NULL THEN '' ELSE '[' + LTRIM(RTRIM(@owner)) + '].' END + '[' + rtrim(@table_name) + ']' + '(NOLOCK)')
	END
ELSE IF (@include_column_list = 0)
	BEGIN
		SET @Actual_Values = 
			'SELECT ' + 
			CASE WHEN @top IS NULL OR @top < 0 THEN '' ELSE ' TOP ' + LTRIM(STR(@top)) + ' ' END + 
			'''' + RTRIM(@Start_Insert) + 
			' '' +''VALUES(''+ ' +  @Actual_Values + '+'')''' + ' ' + 
			COALESCE(@from,' FROM ' + CASE WHEN @owner IS NULL THEN '' ELSE '[' + LTRIM(RTRIM(@owner)) + '].' END + '[' + rtrim(@table_name) + ']' + '(NOLOCK)')
	END	

--Determining whether to ouput any debug information
IF @debug_mode =1
	BEGIN
		PRINT '/*****START OF DEBUG INFORMATION*****'
		PRINT 'Beginning of the INSERT statement:'
		PRINT @Start_Insert
		PRINT ''
		PRINT 'The column list:'
		PRINT @Column_List
		PRINT ''
		PRINT 'The SELECT statement executed to generate the INSERTs'
		PRINT @Actual_Values
		PRINT ''
		PRINT '*****END OF DEBUG INFORMATION*****/'
		PRINT ''
	END
		
PRINT '--INSERTs generated by ''sp_generate_inserts'' stored procedure written by Vyas'
PRINT '--Build number: 22'
PRINT '--Problems/Suggestions? Contact Vyas @ vyaskn@hotmail.com'
PRINT '--http://vyaskn.tripod.com'
PRINT ''
PRINT 'SET NOCOUNT ON'
PRINT ''


--Determining whether to print IDENTITY_INSERT or not
IF (@IDN <> '')
	BEGIN
		PRINT 'SET IDENTITY_INSERT ' + QUOTENAME(COALESCE(@owner,USER_NAME())) + '.' + QUOTENAME(@table_name) + ' ON'
		PRINT 'GO'
		PRINT ''
	END


IF @disable_constraints = 1 AND (OBJECT_ID(QUOTENAME(COALESCE(@owner,USER_NAME())) + '.' + @table_name, 'U') IS NOT NULL)
	BEGIN
		IF @owner IS NULL
			BEGIN
				SELECT 	'ALTER TABLE ' + QUOTENAME(COALESCE(@target_table, @table_name)) + ' NOCHECK CONSTRAINT ALL' AS '--Code to disable constraints temporarily'
			END
		ELSE
			BEGIN
				SELECT 	'ALTER TABLE ' + QUOTENAME(@owner) + '.' + QUOTENAME(COALESCE(@target_table, @table_name)) + ' NOCHECK CONSTRAINT ALL' AS '--Code to disable constraints temporarily'
			END

		PRINT 'GO'
	END

PRINT ''
PRINT 'PRINT ''Inserting values into ' + '[' + RTRIM(COALESCE(@target_table,@table_name)) + ']' + ''''


--All the hard work pays off here!!! You'll get your INSERT statements, when the next line executes!
EXEC (@Actual_Values)

PRINT 'PRINT ''Done'''
PRINT ''


IF @disable_constraints = 1 AND (OBJECT_ID(QUOTENAME(COALESCE(@owner,USER_NAME())) + '.' + @table_name, 'U') IS NOT NULL)
	BEGIN
		IF @owner IS NULL
			BEGIN
				SELECT 	'ALTER TABLE ' + QUOTENAME(COALESCE(@target_table, @table_name)) + ' CHECK CONSTRAINT ALL'  AS '--Code to enable the previously disabled constraints'
			END
		ELSE
			BEGIN
				SELECT 	'ALTER TABLE ' + QUOTENAME(@owner) + '.' + QUOTENAME(COALESCE(@target_table, @table_name)) + ' CHECK CONSTRAINT ALL' AS '--Code to enable the previously disabled constraints'
			END

		PRINT 'GO'
	END

PRINT ''
IF (@IDN <> '')
	BEGIN
		PRINT 'SET IDENTITY_INSERT ' + QUOTENAME(COALESCE(@owner,USER_NAME())) + '.' + QUOTENAME(@table_name) + ' OFF'
		PRINT 'GO'
	END

PRINT 'SET NOCOUNT OFF'


SET NOCOUNT OFF
RETURN 0 --Success. We are done!
END
GO
PRINT N'Agregando claves externas a [dbo].[torneado]'
GO
ALTER TABLE [dbo].[torneado] WITH NOCHECK ADD
CONSTRAINT [FK_torneado_tornero] FOREIGN KEY ([idtornero]) REFERENCES [dbo].[tornero] ([idtornero])
GO
PRINT N'Agregando claves externas a [dbo].[detallehojaderuta]'
GO
ALTER TABLE [dbo].[detallehojaderuta] WITH NOCHECK ADD
CONSTRAINT [FK_detallehojaderuta_hojaderuta] FOREIGN KEY ([idhojaderuta]) REFERENCES [dbo].[hojaderuta] ([idhojaderuta]),
CONSTRAINT [FK_detallehojaderuta_empleado] FOREIGN KEY ([idlegajo]) REFERENCES [dbo].[empleado] ([idlegajo]),
CONSTRAINT [FK_detallehojaderuta_torneado] FOREIGN KEY ([idtorneado]) REFERENCES [dbo].[torneado] ([idtorneado])
GO
PRINT N'Agregando claves externas a [dbo].[proveedorxtipomateriaprima]'
GO
ALTER TABLE [dbo].[proveedorxtipomateriaprima] WITH NOCHECK ADD
CONSTRAINT [FK_proveedorxtipomateriaprima_proveedor] FOREIGN KEY ([idproveedor]) REFERENCES [dbo].[proveedor] ([idproveedor]),
CONSTRAINT [FK_proveedorxtipomateriaprima_tipomateriaprima] FOREIGN KEY ([idtipomateriaprima]) REFERENCES [dbo].[tipomateriaprima] ([idtipomateriaprima])
GO
PRINT N'Agregando claves externas a [dbo].[pago]'
GO
ALTER TABLE [dbo].[pago] WITH NOCHECK ADD
CONSTRAINT [FK_pago_ordencompramp] FOREIGN KEY ([idordencompra]) REFERENCES [dbo].[ordencompramp] ([idordencompra])
GO
PRINT N'Agregando claves externas a [dbo].[empleado]'
GO
ALTER TABLE [dbo].[empleado] WITH NOCHECK ADD
CONSTRAINT [FK_empleado_cargo] FOREIGN KEY ([idcargo]) REFERENCES [dbo].[cargo] ([idcargo]),
CONSTRAINT [FK_empleado_localidad] FOREIGN KEY ([idlocalidad]) REFERENCES [dbo].[localidad] ([idlocalidad])
GO
PRINT N'Agregando claves externas a [dbo].[formulario]'
GO
ALTER TABLE [dbo].[formulario] WITH NOCHECK ADD
CONSTRAINT [FK_formulario_modulo] FOREIGN KEY ([idmodulo]) REFERENCES [dbo].[modulo] ([idmodulo]),
CONSTRAINT [FK_formulario_menupadre] FOREIGN KEY ([idmenu]) REFERENCES [dbo].[menupadre] ([idmenu])
GO
PRINT N'Agregando claves externas a [dbo].[mprecibida]'
GO
ALTER TABLE [dbo].[mprecibida] WITH NOCHECK ADD
CONSTRAINT [FK_mprecibida_ordencompramp] FOREIGN KEY ([idordencompramp]) REFERENCES [dbo].[ordencompramp] ([idordencompra])
GO
PRINT N'Agregando claves externas a [dbo].[parte]'
GO
ALTER TABLE [dbo].[parte] WITH NOCHECK ADD
CONSTRAINT [FK_parte_tipofresa1] FOREIGN KEY ([idtipofresa], [idmodelo]) REFERENCES [dbo].[tipofresa] ([idtipo], [idmodelo]),
CONSTRAINT [FK_parte_tipoparte] FOREIGN KEY ([nombre]) REFERENCES [dbo].[tipoparte] ([nombre]),
CONSTRAINT [FK_parte_tipomateriaprima] FOREIGN KEY ([idtipomateriaprima]) REFERENCES [dbo].[tipomateriaprima] ([idtipomateriaprima])
GO
PRINT N'Agregando claves externas a [dbo].[tipomateriaprima]'
GO
ALTER TABLE [dbo].[tipomateriaprima] WITH NOCHECK ADD
CONSTRAINT [FK_tipomateriaprima_unidaddemedida] FOREIGN KEY ([idunidadmedida]) REFERENCES [dbo].[unidaddemedida] ([idunidadmedida])
GO
PRINT N'Agregando claves externas a [dbo].[proveedor]'
GO
ALTER TABLE [dbo].[proveedor] WITH NOCHECK ADD
CONSTRAINT [FK_proveedor_localidad] FOREIGN KEY ([idlocalidad]) REFERENCES [dbo].[localidad] ([idlocalidad])
GO
PRINT N'Agregando claves externas a [dbo].[partepedido]'
GO
ALTER TABLE [dbo].[partepedido] WITH NOCHECK ADD
CONSTRAINT [FK_partepedido_parteadicional] FOREIGN KEY ([idadicional], [idmodelo]) REFERENCES [dbo].[parteadicional] ([idadicional], [idmodelo]),
CONSTRAINT [FK_partepedido_Pedido] FOREIGN KEY ([idpedido]) REFERENCES [dbo].[Pedido] ([idpedido])
GO
PRINT N'Agregando claves externas a [dbo].[cliente]'
GO
ALTER TABLE [dbo].[cliente] WITH NOCHECK ADD
CONSTRAINT [FK_cliente_tipodocumento] FOREIGN KEY ([idtipodocumento]) REFERENCES [dbo].[tipodocumento] ([idtipodocumento]),
CONSTRAINT [FK_cliente_localidad] FOREIGN KEY ([localidad]) REFERENCES [dbo].[localidad] ([idlocalidad])
GO
PRINT N'Agregando claves externas a [dbo].[formxempleado]'
GO
ALTER TABLE [dbo].[formxempleado] WITH NOCHECK ADD
CONSTRAINT [FK_formxempleado_empleado] FOREIGN KEY ([idlegajo]) REFERENCES [dbo].[empleado] ([idlegajo]),
CONSTRAINT [FK_formxempleado_formulario] FOREIGN KEY ([idformulario]) REFERENCES [dbo].[formulario] ([idformulario])
GO
PRINT N'Agregando claves externas a [dbo].[presupuesto]'
GO
ALTER TABLE [dbo].[presupuesto] WITH NOCHECK ADD
CONSTRAINT [FK_presupuesto_cliente] FOREIGN KEY ([idcliente]) REFERENCES [dbo].[cliente] ([idcliente]),
CONSTRAINT [FK_presupuesto_empleado] FOREIGN KEY ([idempleado]) REFERENCES [dbo].[empleado] ([idlegajo])
GO
PRINT N'Agregando claves externas a [dbo].[MPxTP]'
GO
ALTER TABLE [dbo].[MPxTP] WITH NOCHECK ADD
CONSTRAINT [FK_MPxTP_tipoparte] FOREIGN KEY ([nombre]) REFERENCES [dbo].[tipoparte] ([nombre]),
CONSTRAINT [FK_MPxTP_tipomateriaprima] FOREIGN KEY ([idmp]) REFERENCES [dbo].[tipomateriaprima] ([idtipomateriaprima])
GO
PRINT N'Agregando claves externas a [dbo].[cuentausuario]'
GO
ALTER TABLE [dbo].[cuentausuario] WITH NOCHECK ADD
CONSTRAINT [FK_cuentausuario_empleado] FOREIGN KEY ([idlegajo]) REFERENCES [dbo].[empleado] ([idlegajo])
GO
PRINT N'Agregando claves externas a [dbo].[modelofresa]'
GO
ALTER TABLE [dbo].[modelofresa] WITH NOCHECK ADD
CONSTRAINT [FK_modelofresa_materialatrabajar] FOREIGN KEY ([materialatrabajar]) REFERENCES [dbo].[materialatrabajar] ([nombre]),
CONSTRAINT [FK_modelofresa_mododeavance] FOREIGN KEY ([mododeavance]) REFERENCES [dbo].[mododeavance] ([nombre]),
CONSTRAINT [FK_modelofresa_tipoacabado] FOREIGN KEY ([tipoacabado]) REFERENCES [dbo].[tipoacabado] ([nombre])
GO
PRINT N'Agregando claves externas a [dbo].[etapadefabricacion]'
GO
ALTER TABLE [dbo].[etapadefabricacion] WITH NOCHECK ADD
CONSTRAINT [FK_etapadefabricacion_tipofresa1] FOREIGN KEY ([idtipofresa], [idmodelo]) REFERENCES [dbo].[tipofresa] ([idtipo], [idmodelo]),
CONSTRAINT [FK_etapadefabricacion_operacion] FOREIGN KEY ([idoperacion]) REFERENCES [dbo].[operacion] ([idoperacion])
GO
PRINT N'Agregando claves externas a [dbo].[fresa]'
GO
ALTER TABLE [dbo].[fresa] WITH NOCHECK ADD
CONSTRAINT [FK_fresa_estado] FOREIGN KEY ([estado]) REFERENCES [dbo].[estado] ([idestado]),
CONSTRAINT [FK_fresa_Pedido] FOREIGN KEY ([nropedido]) REFERENCES [dbo].[Pedido] ([idpedido]),
CONSTRAINT [FK_fresa_hojaderuta] FOREIGN KEY ([idhojaderuta]) REFERENCES [dbo].[hojaderuta] ([idhojaderuta]),
CONSTRAINT [FK_fresa_tipofresa] FOREIGN KEY ([idtipo], [idmodelo]) REFERENCES [dbo].[tipofresa] ([idtipo], [idmodelo])
GO
PRINT N'Agregando claves externas a [dbo].[formxperfil]'
GO
ALTER TABLE [dbo].[formxperfil] WITH NOCHECK ADD
CONSTRAINT [FK_formxperfil_formulario] FOREIGN KEY ([idformulario]) REFERENCES [dbo].[formulario] ([idformulario]),
CONSTRAINT [FK_formxperfil_perfil] FOREIGN KEY ([idperfil]) REFERENCES [dbo].[perfil] ([idperfil])
GO
PRINT N'Agregando claves externas a [dbo].[perfil]'
GO
ALTER TABLE [dbo].[perfil] WITH NOCHECK ADD
CONSTRAINT [FK_perfil_empleado] FOREIGN KEY ([idlegajo]) REFERENCES [dbo].[empleado] ([idlegajo])
GO
PRINT N'Agregando claves externas a [dbo].[detallemprecibida]'
GO
ALTER TABLE [dbo].[detallemprecibida] WITH NOCHECK ADD
CONSTRAINT [FK_detallemprecibida_mprecibida] FOREIGN KEY ([idmprecibida]) REFERENCES [dbo].[mprecibida] ([idmprecibida]),
CONSTRAINT [FK_detallemprecibida_mprecibida1] FOREIGN KEY ([idmprecibida]) REFERENCES [dbo].[mprecibida] ([idmprecibida]),
CONSTRAINT [FK_detallemprecibida_estado1] FOREIGN KEY ([idestado]) REFERENCES [dbo].[estado] ([idestado]),
CONSTRAINT [FK_detallemprecibida_tipomateriaprima] FOREIGN KEY ([idtipomateriaprima]) REFERENCES [dbo].[tipomateriaprima] ([idtipomateriaprima])
GO
PRINT N'Agregando claves externas a [dbo].[detallepresupuesto]'
GO
ALTER TABLE [dbo].[detallepresupuesto] WITH NOCHECK ADD
CONSTRAINT [FK_detallepresupuesto_presupuesto] FOREIGN KEY ([idpresupuesto]) REFERENCES [dbo].[presupuesto] ([idpresupuesto])
GO
PRINT N'Agregando claves externas a [dbo].[operacion]'
GO
ALTER TABLE [dbo].[operacion] WITH NOCHECK ADD
CONSTRAINT [FK_operacion_gradodificultad] FOREIGN KEY ([idgradodificultad]) REFERENCES [dbo].[gradodificultad] ([idgradodificultad]),
CONSTRAINT [FK_operacion_tipomaquina] FOREIGN KEY ([maquina]) REFERENCES [dbo].[tipomaquina] ([nombre])
GO
PRINT N'Agregando claves externas a [dbo].[maquina]'
GO
ALTER TABLE [dbo].[maquina] WITH NOCHECK ADD
CONSTRAINT [FK_maquina_tipomaquina] FOREIGN KEY ([tipomaquina]) REFERENCES [dbo].[tipomaquina] ([nombre])
GO
PRINT N'Agregando claves externas a [dbo].[desperfecto]'
GO
ALTER TABLE [dbo].[desperfecto] WITH NOCHECK ADD
CONSTRAINT [FK_desperfecto_tipodesperfecto] FOREIGN KEY ([idtipodesperfecto]) REFERENCES [dbo].[tipodesperfecto] ([idtipodesperfecto]),
CONSTRAINT [FK_desperfecto_maquina] FOREIGN KEY ([idmaquina]) REFERENCES [dbo].[maquina] ([idmaquina])
GO
PRINT N'Agregando claves externas a [dbo].[tipofresa]'
GO
ALTER TABLE [dbo].[tipofresa] WITH NOCHECK ADD
CONSTRAINT [FK_tipofresa_modelofresa] FOREIGN KEY ([idmodelo]) REFERENCES [dbo].[modelofresa] ([idmodelo])
GO
PRINT N'Agregando claves externas a [dbo].[controlcalidad]'
GO
ALTER TABLE [dbo].[controlcalidad] WITH NOCHECK ADD
CONSTRAINT [FK_controlcalidad_fresa] FOREIGN KEY ([idfresa]) REFERENCES [dbo].[fresa] ([nroserie])
GO
PRINT N'Agregando claves externas a [dbo].[detalleordenservicio]'
GO
ALTER TABLE [dbo].[detalleordenservicio] WITH NOCHECK ADD
CONSTRAINT [FK_detalleordenservicio_Pedido] FOREIGN KEY ([idpedido]) REFERENCES [dbo].[Pedido] ([idpedido]),
CONSTRAINT [FK_detalleordenservicio_operacion] FOREIGN KEY ([idoperacion]) REFERENCES [dbo].[operacion] ([idoperacion]),
CONSTRAINT [FK_detalleordenservicio_objetodelservicio] FOREIGN KEY ([idobjetodelservicio]) REFERENCES [dbo].[objetodelservicio] ([idobjetodelservicio]),
CONSTRAINT [FK_detalleordenservicio_hojaderuta] FOREIGN KEY ([idhojaderuta]) REFERENCES [dbo].[hojaderuta] ([idhojaderuta])
GO
PRINT N'Agregando claves externas a [dbo].[Pedido]'
GO
ALTER TABLE [dbo].[Pedido] WITH NOCHECK ADD
CONSTRAINT [FK_Pedido_cliente] FOREIGN KEY ([idcliente]) REFERENCES [dbo].[cliente] ([idcliente]),
CONSTRAINT [FK_Pedido_empleado] FOREIGN KEY ([idvendedor]) REFERENCES [dbo].[empleado] ([idlegajo]),
CONSTRAINT [FK_Pedido_empresatransporte] FOREIGN KEY ([idempresa]) REFERENCES [dbo].[empresatransporte] ([idempresa]),
CONSTRAINT [FK_Pedido_estado] FOREIGN KEY ([idestado]) REFERENCES [dbo].[estado] ([idestado]),
CONSTRAINT [FK_Pedido_formadeentrega] FOREIGN KEY ([idformadeentrega]) REFERENCES [dbo].[formadeentrega] ([idformadeentrega])
GO
PRINT N'Agregando claves externas a [dbo].[empresaxlocalidad]'
GO
ALTER TABLE [dbo].[empresaxlocalidad] WITH NOCHECK ADD
CONSTRAINT [FK_empresaxlocalidad_empresatransporte] FOREIGN KEY ([idempresa]) REFERENCES [dbo].[empresatransporte] ([idempresa]),
CONSTRAINT [FK_empresaxlocalidad_localidad] FOREIGN KEY ([idlocalidad]) REFERENCES [dbo].[localidad] ([idlocalidad])
GO
PRINT N'Agregando claves externas a [dbo].[detalleordencompra]'
GO
ALTER TABLE [dbo].[detalleordencompra] WITH NOCHECK ADD
CONSTRAINT [FK_detalleordencompra_ordencompramp1] FOREIGN KEY ([idordencompra]) REFERENCES [dbo].[ordencompramp] ([idordencompra]),
CONSTRAINT [FK_detalleordencompra_tipomateriaprima] FOREIGN KEY ([idtipomateriaprima]) REFERENCES [dbo].[tipomateriaprima] ([idtipomateriaprima]),
CONSTRAINT [FK_detalleordencompra_estado] FOREIGN KEY ([idestado]) REFERENCES [dbo].[estado] ([idestado])
GO
PRINT N'Agregando claves externas a [dbo].[localidad]'
GO
ALTER TABLE [dbo].[localidad] WITH NOCHECK ADD
CONSTRAINT [FK_localidad_provincia] FOREIGN KEY ([idprovincia]) REFERENCES [dbo].[provincia] ([idprovincia])
GO
PRINT N'Agregando claves externas a [dbo].[viajantexlocalidad]'
GO
ALTER TABLE [dbo].[viajantexlocalidad] WITH NOCHECK ADD
CONSTRAINT [FK_viajantexlocalidad_empleado] FOREIGN KEY ([idviajante]) REFERENCES [dbo].[empleado] ([idlegajo]),
CONSTRAINT [FK_viajantexlocalidad_localidad] FOREIGN KEY ([idlocalidad]) REFERENCES [dbo].[localidad] ([idlocalidad])
GO
PRINT N'Agregando claves externas a [dbo].[parteadicional]'
GO
ALTER TABLE [dbo].[parteadicional] WITH NOCHECK ADD
CONSTRAINT [FK_parteadicional_modelofresa] FOREIGN KEY ([idmodelo]) REFERENCES [dbo].[modelofresa] ([idmodelo])
GO
PRINT N'Agregando claves externas a [dbo].[fresaxmaquina]'
GO
ALTER TABLE [dbo].[fresaxmaquina] WITH NOCHECK ADD
CONSTRAINT [FK_fresaxmaquina_modelofresa] FOREIGN KEY ([idmodelo]) REFERENCES [dbo].[modelofresa] ([idmodelo]),
CONSTRAINT [FK_fresaxmaquina_maquinaFresa] FOREIGN KEY ([idmaquina]) REFERENCES [dbo].[maquinaFresa] ([idmaquina])
GO
PRINT N'Agregando claves externas a [dbo].[mensaje]'
GO
ALTER TABLE [dbo].[mensaje] ADD
CONSTRAINT [FK_Mensaje_empleado] FOREIGN KEY ([idRemitente]) REFERENCES [dbo].[empleado] ([idlegajo]),
CONSTRAINT [FK_Mensaje_empleado1] FOREIGN KEY ([idDestinatario]) REFERENCES [dbo].[empleado] ([idlegajo])
GO
PRINT N'Agregando claves externas a [dbo].[empleado]'
GO
ALTER TABLE [dbo].[empleado] ADD
CONSTRAINT [FK_empleado_perfil] FOREIGN KEY ([idperfil]) REFERENCES [dbo].[perfil] ([idperfil])
GO

GO
-- Plantilla de script posterior a la implementación							
----------------------------------------------------------------------------------------
-- Este archivo contiene instrucciones de SQL que se anexarán al script de generación		
-- Use sintaxis de SQLCMD para incluir un archivo en el script posterior a la implementación			
-- Ejemplo:      :r .\nombreDeArchivo.sql								
-- Use sintaxis de SQLCMD para hacer referencia a una variable del script posterior a la implementación		
-- Ejemplo:      :setvar $TableName Mi tabla							
--               SELECT * FROM [$(TableName)]					
----------------------------------------------------------------------------------------











