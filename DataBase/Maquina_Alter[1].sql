/* Para evitar posibles problemas de pérdida de datos, debe revisar esta secuencia de comandos detalladamente antes de ejecutarla fuera del contexto del diseñador de base de datos.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.maquina
	DROP CONSTRAINT FK_maquina_tipomaquina
GO
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_maquina
	(
	idmaquina int NOT NULL,
	nombre char(40) NOT NULL,
	descripcion text NULL,
	numerodeserie char(20) NULL,
	potencia char(20) NULL,
	costodecompra decimal(18, 0) NULL,
	estadodeadquisicion char(20) NULL,
	idestado int NULL,
	horasdeuso int NULL,
	tipomaquina char(40) NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO
IF EXISTS(SELECT * FROM dbo.maquina)
	 EXEC('INSERT INTO dbo.Tmp_maquina (idmaquina, nombre, descripcion, numerodeserie, potencia, costodecompra, estadodeadquisicion, idestado, horasdeuso, tipomaquina)
		SELECT idmaquina, nombre, descripcion, numerodeserie, potencia, costodecompra, estadodeadquisicion, idestado, CONVERT(int, horasdeuso), tipomaquina FROM dbo.maquina WITH (HOLDLOCK TABLOCKX)')
GO
ALTER TABLE dbo.desperfecto
	DROP CONSTRAINT FK_desperfecto_maquina
GO
DROP TABLE dbo.maquina
GO
EXECUTE sp_rename N'dbo.Tmp_maquina', N'maquina', 'OBJECT' 
GO
ALTER TABLE dbo.maquina ADD CONSTRAINT
	PK_maquina PRIMARY KEY CLUSTERED 
	(
	idmaquina
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.maquina WITH NOCHECK ADD CONSTRAINT
	FK_maquina_tipomaquina FOREIGN KEY
	(
	tipomaquina
	) REFERENCES dbo.tipomaquina
	(
	nombre
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.desperfecto WITH NOCHECK ADD CONSTRAINT
	FK_desperfecto_maquina FOREIGN KEY
	(
	idmaquina
	) REFERENCES dbo.maquina
	(
	idmaquina
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
