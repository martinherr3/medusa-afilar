-- Plantilla de script posterior a la implementación							
----------------------------------------------------------------------------------------
-- Este archivo contiene instrucciones de SQL que se anexarán al script de generación		
-- Use sintaxis de SQLCMD para incluir un archivo en el script posterior a la implementación			
-- Ejemplo:      :r .\nombreDeArchivo.sql								
-- Use sintaxis de SQLCMD para hacer referencia a una variable del script posterior a la implementación		
-- Ejemplo:      :setvar $TableName Mi tabla							
--               SELECT * FROM [$(TableName)]					
----------------------------------------------------------------------------------------
:r .\Storage.sql

:r .\Permissions.sql

:r .\RoleMemberships.sql

:r .\RulesAndDefaults.sql

:r .\DatabaseObjectOptions.sql

:r .\Signatures.sql
