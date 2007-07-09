SELECT 'EXEC sp_generate_inserts ' + 
'[' + name + ']' + 
',@owner = ' + 
'[' + RTRIM(USER_NAME(uid)) + '],' + 
'@ommit_images = 1, @disable_constraints = 1'
FROM sysobjects 
WHERE type = 'U' AND 
OBJECTPROPERTY(id,'ismsshipped') = 0

EXEC sp_generate_inserts [estado],@owner = [dbo],@ommit_images = 1, @disable_constraints = 1
EXEC sp_generate_inserts [provincia],@owner = [dbo],@ommit_images = 1, @disable_constraints = 1
EXEC sp_generate_inserts [tornero],@owner = [dbo],@ommit_images = 1, @disable_constraints = 1
EXEC sp_generate_inserts [tipodocumento],@owner = [dbo],@ommit_images = 1, @disable_constraints = 1
EXEC sp_generate_inserts [cargo],@owner = [dbo],@ommit_images = 1, @disable_constraints = 1
EXEC sp_generate_inserts [tipoacabado],@owner = [dbo],@ommit_images = 1, @disable_constraints = 1
EXEC sp_generate_inserts [mododeavance],@owner = [dbo],@ommit_images = 1, @disable_constraints = 1
EXEC sp_generate_inserts [empresatransporte],@owner = [dbo],@ommit_images = 1, @disable_constraints = 1
EXEC sp_generate_inserts [materialatrabajar],@owner = [dbo],@ommit_images = 1, @disable_constraints = 1
EXEC sp_generate_inserts [gradodificultad],@owner = [dbo],@ommit_images = 1, @disable_constraints = 1
EXEC sp_generate_inserts [tipoparte],@owner = [dbo],@ommit_images = 1, @disable_constraints = 1
EXEC sp_generate_inserts [tipomaquina],@owner = [dbo],@ommit_images = 1, @disable_constraints = 1
EXEC sp_generate_inserts [modulo],@owner = [dbo],@ommit_images = 1, @disable_constraints = 1
EXEC sp_generate_inserts [unidaddemedida],@owner = [dbo],@ommit_images = 1, @disable_constraints = 1
EXEC sp_generate_inserts [menupadre],@owner = [dbo],@ommit_images = 1, @disable_constraints = 1
EXEC sp_generate_inserts [ordencompramp],@owner = [dbo],@ommit_images = 1, @disable_constraints = 1
EXEC sp_generate_inserts [hojaderuta],@owner = [dbo],@ommit_images = 1, @disable_constraints = 1
EXEC sp_generate_inserts [tipodesperfecto],@owner = [dbo],@ommit_images = 1, @disable_constraints = 1
EXEC sp_generate_inserts [Pedido],@owner = [dbo],@ommit_images = 1, @disable_constraints = 1
EXEC sp_generate_inserts [fresaxmaquina],@owner = [dbo],@ommit_images = 1, @disable_constraints = 1
EXEC sp_generate_inserts [detalleordenservicio],@owner = [dbo],@ommit_images = 1, @disable_constraints = 1
EXEC sp_generate_inserts [detalleordencompra],@owner = [dbo],@ommit_images = 1, @disable_constraints = 1
EXEC sp_generate_inserts [fresa],@owner = [dbo],@ommit_images = 1, @disable_constraints = 1
EXEC sp_generate_inserts [detallemprecibida],@owner = [dbo],@ommit_images = 1, @disable_constraints = 1
EXEC sp_generate_inserts [localidad],@owner = [dbo],@ommit_images = 1, @disable_constraints = 1
EXEC sp_generate_inserts [torneado],@owner = [dbo],@ommit_images = 1, @disable_constraints = 1
EXEC sp_generate_inserts [cliente],@owner = [dbo],@ommit_images = 1, @disable_constraints = 1
EXEC sp_generate_inserts [empleado],@owner = [dbo],@ommit_images = 1, @disable_constraints = 1
EXEC sp_generate_inserts [modelofresa],@owner = [dbo],@ommit_images = 1, @disable_constraints = 1
EXEC sp_generate_inserts [empresaxlocalidad],@owner = [dbo],@ommit_images = 1, @disable_constraints = 1
EXEC sp_generate_inserts [operacion],@owner = [dbo],@ommit_images = 1, @disable_constraints = 1
EXEC sp_generate_inserts [MPxTP],@owner = [dbo],@ommit_images = 1, @disable_constraints = 1
EXEC sp_generate_inserts [parte],@owner = [dbo],@ommit_images = 1, @disable_constraints = 1
EXEC sp_generate_inserts [maquina],@owner = [dbo],@ommit_images = 1, @disable_constraints = 1
EXEC sp_generate_inserts [formulario],@owner = [dbo],@ommit_images = 1, @disable_constraints = 1
EXEC sp_generate_inserts [tipomateriaprima],@owner = [dbo],@ommit_images = 1, @disable_constraints = 1
EXEC sp_generate_inserts [formxperfil],@owner = [dbo],@ommit_images = 1, @disable_constraints = 1
EXEC sp_generate_inserts [formxempleado],@owner = [dbo],@ommit_images = 1, @disable_constraints = 1
EXEC sp_generate_inserts [controlcalidad],@owner = [dbo],@ommit_images = 1, @disable_constraints = 1
EXEC sp_generate_inserts [partepedido],@owner = [dbo],@ommit_images = 1, @disable_constraints = 1
EXEC sp_generate_inserts [detallepresupuesto],@owner = [dbo],@ommit_images = 1, @disable_constraints = 1
EXEC sp_generate_inserts [detallehojaderuta],@owner = [dbo],@ommit_images = 1, @disable_constraints = 1
EXEC sp_generate_inserts [viajantexlocalidad],@owner = [dbo],@ommit_images = 1, @disable_constraints = 1
EXEC sp_generate_inserts [proveedor],@owner = [dbo],@ommit_images = 1, @disable_constraints = 1
EXEC sp_generate_inserts [presupuesto],@owner = [dbo],@ommit_images = 1, @disable_constraints = 1
EXEC sp_generate_inserts [tipofresa],@owner = [dbo],@ommit_images = 1, @disable_constraints = 1
EXEC sp_generate_inserts [parteadicional],@owner = [dbo],@ommit_images = 1, @disable_constraints = 1
EXEC sp_generate_inserts [etapadefabricacion],@owner = [dbo],@ommit_images = 1, @disable_constraints = 1
EXEC sp_generate_inserts [proveedorxtipomateriaprima],@owner = [dbo],@ommit_images = 1, @disable_constraints = 1
EXEC sp_generate_inserts [desperfecto],@owner = [dbo],@ommit_images = 1, @disable_constraints = 1
EXEC sp_generate_inserts [cuentausuario],@owner = [dbo],@ommit_images = 1, @disable_constraints = 1
EXEC sp_generate_inserts [perfil],@owner = [dbo],@ommit_images = 1, @disable_constraints = 1
EXEC sp_generate_inserts [mprecibida],@owner = [dbo],@ommit_images = 1, @disable_constraints = 1
EXEC sp_generate_inserts [pago],@owner = [dbo],@ommit_images = 1, @disable_constraints = 1
EXEC sp_generate_inserts [formadeentrega],@owner = [dbo],@ommit_images = 1, @disable_constraints = 1
EXEC sp_generate_inserts [maquinaFresa],@owner = [dbo],@ommit_images = 1, @disable_constraints = 1
EXEC sp_generate_inserts [objetodelservicio],@owner = [dbo],@ommit_images = 1, @disable_constraints = 1