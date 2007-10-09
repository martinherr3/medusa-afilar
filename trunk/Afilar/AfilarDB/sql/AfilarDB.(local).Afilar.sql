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
     
:on error exit

IF (@@servername != 'DESKTOP')
BEGIN
    RAISERROR(N'El nombre del servidor del script de generación %s no coincide con el nombre del servidor de destino %s. Compruebe si es correcta la configuración del proyecto de base de datos y si el script de generación está actualizado.', 16, 127,N'DESKTOP',@@servername) WITH NOWAIT
    RETURN
END
GO


DECLARE @sqlver as INT;
SET @sqlver = cast(((@@microsoftversion / 0x1000000) * 10) as int);
IF (@sqlver != 90)
BEGIN
    RAISERROR(N'La versión de SQL Server del script de generación %i no coincide con la versión del servidor de destino %i. Compruebe si es correcta la configuración del proyecto de base de datos y si el script de generación está actualizado.', 16, 127,90,@sqlver) WITH NOWAIT;
    RETURN;
END
GO


IF NOT EXISTS (SELECT 1 FROM [master].[dbo].[sysdatabases] WHERE [name] = N'Afilar')
BEGIN
    RAISERROR(N'No puede implementar este script de actualización en el destino DESKTOP. La base de datos para la que se generó este script, Afilar, no existe en este servidor.', 16, 127) WITH NOWAIT
    RETURN
END
GO


IF (N'$(databasename)' ! = N'Afilar')
BEGIN
    RAISERROR(N'El nombre de la base de datos del script de generación %s no coincide con el nombre de la base de datos de destino %s. Compruebe si es correcta la configuración del proyecto de base de datos y si el script de generación está actualizado.', 16, 127,N'$(databasename)',N'Afilar') WITH NOWAIT;
    RETURN
END
GO


DECLARE @dbcompatlvl as int;
SELECT  @dbcompatlvl = cmptlevel
FROM    [master].[dbo].[sysdatabases]
WHERE   [name] = N'$(databasename)';
IF (ISNULL(@dbcompatlvl, 0) != 90)
BEGIN
    RAISERROR(N'El nivel de compatibilidad con la base de datos del script de generación %i no coincide con el nivel de compatibilidad de la base de datos de destino %i. Compruebe si la configuración del proyecto de base de datos es correcta y si el script de generación está actualizado.', 16, 127, 90, @dbcompatlvl) WITH NOWAIT;
    RETURN;
END
GO


IF CAST(DATABASEPROPERTY(N'$(databasename)','IsReadOnly') as bit) = 1
BEGIN
    RAISERROR(N'No puede implementar este script de actualización porque la base de datos para la que se generó el script, %s , tiene el estado READ_ONLY.', 16, 127, N'$(databasename)') WITH NOWAIT
    RETURN
END
GO

:on error resume
     
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

:on error exit
GO
/* El tipo del campo horasdeuso de la tabla [dbo].[maquina] es actualmente [datetime], pero se va a cambiar a [int]. */
IF EXISTS (select top 1 1 from [dbo].[maquina])
	RAISERROR ('Filas detectadas, no se actualizará el esquema debido a posible pérdida de datos.', 16, 127) WITH NOWAIT
GO

:on error resume
GO
PRINT N'Eliminando claves externas de [dbo].[desperfecto]'
GO
ALTER TABLE [dbo].[desperfecto] DROP
CONSTRAINT [FK_desperfecto_maquina]
GO
PRINT N'Eliminando claves externas de [dbo].[maquina]'
GO
ALTER TABLE [dbo].[maquina] DROP
CONSTRAINT [FK_maquina_tipomaquina]
GO
PRINT N'Eliminando restricciones de [dbo].[etapadefabricacion]'
GO
ALTER TABLE [dbo].[etapadefabricacion] DROP CONSTRAINT [PK_etapadefabricacion_1]
GO
PRINT N'Eliminando restricciones de [dbo].[maquina]'
GO
ALTER TABLE [dbo].[maquina] DROP CONSTRAINT [PK_maquina]
GO
PRINT N'Generando [dbo].[maquina] de nuevo'
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
SET XACT_ABORT ON
GO
BEGIN TRANSACTION
CREATE TABLE [dbo].[tmp_ms_xx_maquina]
(
[idmaquina] [int] NOT NULL,
[nombre] [char] (40) COLLATE Traditional_Spanish_CI_AS NOT NULL,
[descripcion] [text] COLLATE Traditional_Spanish_CI_AS NULL,
[numerodeserie] [char] (20) COLLATE Traditional_Spanish_CI_AS NULL,
[potencia] [char] (20) COLLATE Traditional_Spanish_CI_AS NULL,
[costodecompra] [decimal] (18, 0) NULL,
[estadodeadquisicion] [char] (20) COLLATE Traditional_Spanish_CI_AS NULL,
[idestado] [int] NULL,
[horasdeuso] [int] NULL,
[tipomaquina] [char] (40) COLLATE Traditional_Spanish_CI_AS NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
INSERT INTO [dbo].[tmp_ms_xx_maquina]([idmaquina], [nombre], [descripcion], [numerodeserie], [potencia], [costodecompra], [estadodeadquisicion], [idestado], [horasdeuso], [tipomaquina]) SELECT [idmaquina], [nombre], [descripcion], [numerodeserie], [potencia], [costodecompra], [estadodeadquisicion], [idestado], CAST([horasdeuso] AS [int]), [tipomaquina] FROM [dbo].[maquina]
DROP TABLE [dbo].[maquina]
EXEC sp_rename N'[dbo].[tmp_ms_xx_maquina]', N'maquina'
COMMIT TRANSACTION
GO
SET TRANSACTION ISOLATION LEVEL READ COMMITTED
GO
PRINT N'Creando clave principal [PK_maquina] en [dbo].[maquina]'
GO
ALTER TABLE [dbo].[maquina] ADD CONSTRAINT [PK_maquina] PRIMARY KEY CLUSTERED  ([idmaquina]) ON [PRIMARY]
GO
PRINT N'Creando [dbo].[ParametrosCompra]'
GO
CREATE TABLE [dbo].[ParametrosCompra]
(
[IdTipoMateria] [int] NOT NULL,
[CostoGestion] [float] NULL,
[CostoEnvio] [float] NULL,
[CostoAlmacenamiento] [float] NULL
) ON [PRIMARY]
GO
PRINT N'Creando clave principal [PK_ParametrosCompra] en [dbo].[ParametrosCompra]'
GO
ALTER TABLE [dbo].[ParametrosCompra] ADD CONSTRAINT [PK_ParametrosCompra] PRIMARY KEY CLUSTERED  ([IdTipoMateria]) ON [PRIMARY]
GO
PRINT N'Creando clave principal [PK_etapadefabricacion] en [dbo].[etapadefabricacion]'
GO
ALTER TABLE [dbo].[etapadefabricacion] ADD CONSTRAINT [PK_etapadefabricacion] PRIMARY KEY CLUSTERED  ([idetapafabricacion]) ON [PRIMARY]
GO
PRINT N'Agregando claves externas a [dbo].[desperfecto]'
GO
ALTER TABLE [dbo].[desperfecto] WITH NOCHECK ADD
CONSTRAINT [FK_desperfecto_maquina] FOREIGN KEY ([idmaquina]) REFERENCES [dbo].[maquina] ([idmaquina])
GO
PRINT N'Agregando claves externas a [dbo].[maquina]'
GO
ALTER TABLE [dbo].[maquina] WITH NOCHECK ADD
CONSTRAINT [FK_maquina_tipomaquina] FOREIGN KEY ([tipomaquina]) REFERENCES [dbo].[tipomaquina] ([nombre])
GO
PRINT N'Creando desencadenador [dbo].[trig_insert_Empleado] en [dbo].[empleado]'
GO
Create Trigger trig_insert_Empleado 
on [empleado]
For INSERT 
As 
INSERT INTO [Afilar].[cuentausuario]
select I.apellido,'Default', getdate(), I.idlegajo From inserted I
GO
PRINT N'Creando desencadenador [dbo].[trig_update_TipoMateriaPrima] en [dbo].[tipomateriaprima]'
GO
Create Trigger trig_update_TipoMateriaPrima
on [tipomateriaprima]
For Update
as
INSERT INTO [Afilar].[dbo].[mensaje]
select row_number()over (order by idtipomateriaprima)+ (select max(idmensaje) from mensaje) as idmensaje, 'Sotck critico', 1, s.id,  'La materia prima: ' + s.nombre + ' a alcanzado niveles citicos de stock, es necesario realizar una compra.' ,1 ,0 ,getdate(), getdate()  from (
select * from  inserted i, (select idlegajo as id from empleado where idperfil = 2) t where i.stockactual < i.stockminimo) s
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











