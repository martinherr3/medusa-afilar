Create Trigger trig_insert_Empleado 
on [Afilar].[dbo].[empleado]
For INSERT 
As 
INSERT INTO [Afilar].[dbo].[cuentausuario]
select I.apellido,'Default', getdate(), I.idlegajo From inserted I


