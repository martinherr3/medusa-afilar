-- Plantilla de script anterior a la implementación							
----------------------------------------------------------------------------------------
-- Este archivo contiene instrucciones de SQL que se ejecutarán antes del script de generación	
-- Use sintaxis de SQLCMD para incluir un archivo en el script anterior a la implementación			
-- Ejemplo:      :r .\nombreDeArchivo.sql								
-- Use sintaxis de SQLCMD para hacer referencia a una variable del script anterior a la implementación		
-- Ejemplo:      :setvar $TableName Mi tabla							
--               SELECT * FROM [$(TableName)]					
----------------------------------------------------------------------------------------
:r .\Logins.sql

:r .\LinkedServers.sql

:r .\CustomErrors.sql

:r .\EncryptionKeysAndCertificates.sql
