ALTER TABLE dbo.perfil
	DROP CONSTRAINT FK_perfil_empleado
GO
ALTER TABLE dbo.empleado ADD
	idperfil int NULL
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.perfil
	DROP COLUMN idlegajo
GO
COMMIT
ALTER TABLE dbo.empleado ADD CONSTRAINT
	FK_empleado_perfil FOREIGN KEY
	(
	idperfil
	) REFERENCES dbo.perfil
	(
	idperfil
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 