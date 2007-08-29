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

IF (@@servername != 'ORDCORP-0DBUOLJ')
BEGIN
    RAISERROR(N'El nombre del servidor del script de generación %s no coincide con el nombre del servidor de destino %s. Compruebe si es correcta la configuración del proyecto de base de datos y si el script de generación está actualizado.', 16, 127,N'ORDCORP-0DBUOLJ',@@servername) WITH NOWAIT
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
    RAISERROR(N'No puede implementar este script de actualización en el destino ORDCORP-0DBUOLJ. La base de datos para la que se generó este script, Afilar, no existe en este servidor.', 16, 127) WITH NOWAIT
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











