CREATE Trigger [dbo].[trig_update_TipoMateriaPrima]
on [Afilar].[dbo].[tipomateriaprima]
For Update
as
INSERT INTO [Afilar].[dbo].[mensaje]
select row_number()over (order by idtipomateriaprima)+ (select max(idmensaje) from mensaje) as idmensaje, 'Sotck critico', 1000, s.id,  'La materia prima: ' + s.nombre + ' a alcanzado niveles citicos de stock, es necesario realizar una compra.' ,1 ,0 ,getdate(), getdate()  from (
select * from  inserted i, (select idlegajo as id from empleado where idperfil = 2) t where i.stockactual < i.stockminimo) s


