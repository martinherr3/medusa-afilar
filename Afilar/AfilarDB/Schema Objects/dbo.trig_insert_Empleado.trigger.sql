﻿Create Trigger trig_insert_Empleado 
on [empleado]
For INSERT 
As 
INSERT INTO [Afilar].[cuentausuario]
select I.apellido,'Default', getdate(), I.idlegajo From inserted I

