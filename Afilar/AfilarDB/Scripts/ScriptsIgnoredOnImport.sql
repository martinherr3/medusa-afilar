
/*
Este script se creó con Visual Studio el 29/08/2007 a las 22:27.
Ejecute el script en AfilarDB para que sea igual que desktop.Afilar.dbo.
Realice una copia de seguridad de la base de datos de destino antes de ejecutar el script.
*/

GO
SET NUMERIC_ROUNDABORT OFF
GO
SET ANSI_PADDING ON
GO
SET ANSI_WARNINGS ON
GO
SET CONCAT_NULL_YIELDS_NULL ON
GO
SET ARITHABORT ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
/* La intercalación para el campo nombre en la tabla [dbo].[cargo] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/* La intercalación para el campo descripcion en la tabla [dbo].[cargo] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
IF EXISTS (select top 1 1 from [dbo].[cargo])
	RAISERROR ('Filas detectadas, no se actualizará el esquema debido a posible pérdida de datos.', 16, 127) WITH NOWAIT
GO
/* La intercalación para el campo nombre en la tabla [dbo].[cliente] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/* La intercalación para el campo apellido en la tabla [dbo].[cliente] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/* La intercalación para el campo direccion en la tabla [dbo].[cliente] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/* La intercalación para el campo mail en la tabla [dbo].[cliente] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/* La intercalación para el campo telefono en la tabla [dbo].[cliente] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/* La intercalación para el campo celular en la tabla [dbo].[cliente] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
IF EXISTS (select top 1 1 from [dbo].[cliente])
	RAISERROR ('Filas detectadas, no se actualizará el esquema debido a posible pérdida de datos.', 16, 127) WITH NOWAIT
GO
/* La intercalación para el campo observaciones en la tabla [dbo].[controlcalidad] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/* La intercalación para el campo medidas en la tabla [dbo].[controlcalidad] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/* La intercalación para el campo pintura en la tabla [dbo].[controlcalidad] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/* La intercalación para el campo soldadura en la tabla [dbo].[controlcalidad] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/* La intercalación para el campo torneado en la tabla [dbo].[controlcalidad] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/* La intercalación para el campo fechahoracontrol en la tabla [dbo].[controlcalidad] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
IF EXISTS (select top 1 1 from [dbo].[controlcalidad])
	RAISERROR ('Filas detectadas, no se actualizará el esquema debido a posible pérdida de datos.', 16, 127) WITH NOWAIT
GO
/* La intercalación para el campo usuario en la tabla [dbo].[cuentausuario] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/* La intercalación para el campo contraseña en la tabla [dbo].[cuentausuario] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
IF EXISTS (select top 1 1 from [dbo].[cuentausuario])
	RAISERROR ('Filas detectadas, no se actualizará el esquema debido a posible pérdida de datos.', 16, 127) WITH NOWAIT
GO
/* La intercalación para el campo causa en la tabla [dbo].[desperfecto] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/*The column:  reparado is being dropped from table:  [dbo].[desperfecto].*/
IF EXISTS (select top 1 1 from [dbo].[desperfecto])
	RAISERROR ('Filas detectadas, no se actualizará el esquema debido a posible pérdida de datos.', 16, 127) WITH NOWAIT
GO
/* La intercalación para el campo observaciones en la tabla [dbo].[detallehojaderuta] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
IF EXISTS (select top 1 1 from [dbo].[detallehojaderuta])
	RAISERROR ('Filas detectadas, no se actualizará el esquema debido a posible pérdida de datos.', 16, 127) WITH NOWAIT
GO
/* La intercalación para el campo causarechazo en la tabla [dbo].[detallemprecibida] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
IF EXISTS (select top 1 1 from [dbo].[detallemprecibida])
	RAISERROR ('Filas detectadas, no se actualizará el esquema debido a posible pérdida de datos.', 16, 127) WITH NOWAIT
GO
/* El tipo del campo precio de la tabla [dbo].[detalleordencompra] es actualmente [float], pero se va a cambiar a [money]. */
IF EXISTS (select top 1 1 from [dbo].[detalleordencompra])
	RAISERROR ('Filas detectadas, no se actualizará el esquema debido a posible pérdida de datos.', 16, 127) WITH NOWAIT
GO
/* La intercalación para el campo observacion en la tabla [dbo].[detalleordenservicio] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
IF EXISTS (select top 1 1 from [dbo].[detalleordenservicio])
	RAISERROR ('Filas detectadas, no se actualizará el esquema debido a posible pérdida de datos.', 16, 127) WITH NOWAIT
GO
/* La intercalación para el campo nombre en la tabla [dbo].[empleado] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/* La intercalación para el campo apellido en la tabla [dbo].[empleado] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/* La intercalación para el campo direccion en la tabla [dbo].[empleado] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/* La intercalación para el campo telefono en la tabla [dbo].[empleado] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/* La intercalación para el campo email en la tabla [dbo].[empleado] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/* La intercalación para el campo titulo en la tabla [dbo].[empleado] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/* La intercalación para el campo turno en la tabla [dbo].[empleado] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/*The column:  idperfil is being dropped from table:  [dbo].[empleado].*/
IF EXISTS (select top 1 1 from [dbo].[empleado])
	RAISERROR ('Filas detectadas, no se actualizará el esquema debido a posible pérdida de datos.', 16, 127) WITH NOWAIT
GO
/* La intercalación para el campo nombre en la tabla [dbo].[empresatransporte] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/* La intercalación para el campo direccion en la tabla [dbo].[empresatransporte] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/* La intercalación para el campo telefono en la tabla [dbo].[empresatransporte] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
IF EXISTS (select top 1 1 from [dbo].[empresatransporte])
	RAISERROR ('Filas detectadas, no se actualizará el esquema debido a posible pérdida de datos.', 16, 127) WITH NOWAIT
GO
/* La intercalación para el campo nombre en la tabla [dbo].[estado] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/* La intercalación para el campo descripcion en la tabla [dbo].[estado] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
IF EXISTS (select top 1 1 from [dbo].[estado])
	RAISERROR ('Filas detectadas, no se actualizará el esquema debido a posible pérdida de datos.', 16, 127) WITH NOWAIT
GO
/* La intercalación para el campo detalle en la tabla [dbo].[etapadefabricacion] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
IF EXISTS (select top 1 1 from [dbo].[etapadefabricacion])
	RAISERROR ('Filas detectadas, no se actualizará el esquema debido a posible pérdida de datos.', 16, 127) WITH NOWAIT
GO
/* La intercalación para el campo nombre en la tabla [dbo].[formadeentrega] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/* La intercalación para el campo descripcion en la tabla [dbo].[formadeentrega] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
IF EXISTS (select top 1 1 from [dbo].[formadeentrega])
	RAISERROR ('Filas detectadas, no se actualizará el esquema debido a posible pérdida de datos.', 16, 127) WITH NOWAIT
GO
/* La intercalación para el campo descripcion en la tabla [dbo].[formulario] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/* La intercalación para el campo nombre en la tabla [dbo].[formulario] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
IF EXISTS (select top 1 1 from [dbo].[formulario])
	RAISERROR ('Filas detectadas, no se actualizará el esquema debido a posible pérdida de datos.', 16, 127) WITH NOWAIT
GO
/* La intercalación para el campo nombre en la tabla [dbo].[gradodificultad] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/* La intercalación para el campo descripcion en la tabla [dbo].[gradodificultad] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
IF EXISTS (select top 1 1 from [dbo].[gradodificultad])
	RAISERROR ('Filas detectadas, no se actualizará el esquema debido a posible pérdida de datos.', 16, 127) WITH NOWAIT
GO
/* La intercalación para el campo zona en la tabla [dbo].[localidad] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/* La intercalación para el campo provincia en la tabla [dbo].[localidad] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/* La intercalación para el campo distancia en la tabla [dbo].[localidad] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/* La intercalación para el campo nombre en la tabla [dbo].[localidad] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
IF EXISTS (select top 1 1 from [dbo].[localidad])
	RAISERROR ('Filas detectadas, no se actualizará el esquema debido a posible pérdida de datos.', 16, 127) WITH NOWAIT
GO
/* La intercalación para el campo nombre en la tabla [dbo].[maquina] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/* La intercalación para el campo descripcion en la tabla [dbo].[maquina] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/* La intercalación para el campo numerodeserie en la tabla [dbo].[maquina] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/* La intercalación para el campo potencia en la tabla [dbo].[maquina] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/* La intercalación para el campo estadodeadquisicion en la tabla [dbo].[maquina] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/* El tipo del campo horasdeuso de la tabla [dbo].[maquina] es actualmente [int], pero se va a cambiar a [datetime]. */
/* La intercalación para el campo tipomaquina en la tabla [dbo].[maquina] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
IF EXISTS (select top 1 1 from [dbo].[maquina])
	RAISERROR ('Filas detectadas, no se actualizará el esquema debido a posible pérdida de datos.', 16, 127) WITH NOWAIT
GO
/* La intercalación para el campo nombre en la tabla [dbo].[maquinaFresa] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/* La intercalación para el campo sentidodegiro en la tabla [dbo].[maquinaFresa] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/* La intercalación para el campo caracteristicas en la tabla [dbo].[maquinaFresa] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/* La intercalación para el campo estado en la tabla [dbo].[maquinaFresa] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
IF EXISTS (select top 1 1 from [dbo].[maquinaFresa])
	RAISERROR ('Filas detectadas, no se actualizará el esquema debido a posible pérdida de datos.', 16, 127) WITH NOWAIT
GO
/* La intercalación para el campo nombre en la tabla [dbo].[materialatrabajar] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/* La intercalación para el campo descripcion en la tabla [dbo].[materialatrabajar] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
IF EXISTS (select top 1 1 from [dbo].[materialatrabajar])
	RAISERROR ('Filas detectadas, no se actualizará el esquema debido a posible pérdida de datos.', 16, 127) WITH NOWAIT
GO
/* La intercalación para el campo asunto en la tabla [dbo].[mensaje] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/* La intercalación para el campo mensaje en la tabla [dbo].[mensaje] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
IF EXISTS (select top 1 1 from [dbo].[mensaje])
	RAISERROR ('Filas detectadas, no se actualizará el esquema debido a posible pérdida de datos.', 16, 127) WITH NOWAIT
GO
/* La intercalación para el campo nombre en la tabla [dbo].[menupadre] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
IF EXISTS (select top 1 1 from [dbo].[menupadre])
	RAISERROR ('Filas detectadas, no se actualizará el esquema debido a posible pérdida de datos.', 16, 127) WITH NOWAIT
GO
/* La intercalación para el campo nombre en la tabla [dbo].[modelofresa] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/* La intercalación para el campo grupomodelo en la tabla [dbo].[modelofresa] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/* La intercalación para el campo descripcion en la tabla [dbo].[modelofresa] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/* La intercalación para el campo materialatrabajar en la tabla [dbo].[modelofresa] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/* La intercalación para el campo mododeavance en la tabla [dbo].[modelofresa] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/* La intercalación para el campo tipoacabado en la tabla [dbo].[modelofresa] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/* La intercalación para el campo tipomodelo en la tabla [dbo].[modelofresa] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/* La intercalación para el campo estado en la tabla [dbo].[modelofresa] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
IF EXISTS (select top 1 1 from [dbo].[modelofresa])
	RAISERROR ('Filas detectadas, no se actualizará el esquema debido a posible pérdida de datos.', 16, 127) WITH NOWAIT
GO
/* La intercalación para el campo nombre en la tabla [dbo].[mododeavance] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/* La intercalación para el campo descripcion en la tabla [dbo].[mododeavance] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
IF EXISTS (select top 1 1 from [dbo].[mododeavance])
	RAISERROR ('Filas detectadas, no se actualizará el esquema debido a posible pérdida de datos.', 16, 127) WITH NOWAIT
GO
/* La intercalación para el campo descripcion en la tabla [dbo].[modulo] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
IF EXISTS (select top 1 1 from [dbo].[modulo])
	RAISERROR ('Filas detectadas, no se actualizará el esquema debido a posible pérdida de datos.', 16, 127) WITH NOWAIT
GO
/* La intercalación para el campo fecharecepcion en la tabla [dbo].[mprecibida] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
IF EXISTS (select top 1 1 from [dbo].[mprecibida])
	RAISERROR ('Filas detectadas, no se actualizará el esquema debido a posible pérdida de datos.', 16, 127) WITH NOWAIT
GO
/* La intercalación para el campo nombre en la tabla [dbo].[MPxTP] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
IF EXISTS (select top 1 1 from [dbo].[MPxTP])
	RAISERROR ('Filas detectadas, no se actualizará el esquema debido a posible pérdida de datos.', 16, 127) WITH NOWAIT
GO
/* La intercalación para el campo nombre en la tabla [dbo].[objetodelservicio] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/* La intercalación para el campo descripcion en la tabla [dbo].[objetodelservicio] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
IF EXISTS (select top 1 1 from [dbo].[objetodelservicio])
	RAISERROR ('Filas detectadas, no se actualizará el esquema debido a posible pérdida de datos.', 16, 127) WITH NOWAIT
GO
/* La intercalación para el campo nombre en la tabla [dbo].[operacion] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/* La intercalación para el campo maquina en la tabla [dbo].[operacion] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/* La intercalación para el campo descripcion en la tabla [dbo].[operacion] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
IF EXISTS (select top 1 1 from [dbo].[operacion])
	RAISERROR ('Filas detectadas, no se actualizará el esquema debido a posible pérdida de datos.', 16, 127) WITH NOWAIT
GO
/* La intercalación para el campo condicionesdepago en la tabla [dbo].[ordencompramp] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/* La intercalación para el campo causa en la tabla [dbo].[ordencompramp] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
IF EXISTS (select top 1 1 from [dbo].[ordencompramp])
	RAISERROR ('Filas detectadas, no se actualizará el esquema debido a posible pérdida de datos.', 16, 127) WITH NOWAIT
GO
/* La intercalación para el campo formadepago en la tabla [dbo].[pago] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
IF EXISTS (select top 1 1 from [dbo].[pago])
	RAISERROR ('Filas detectadas, no se actualizará el esquema debido a posible pérdida de datos.', 16, 127) WITH NOWAIT
GO
/* La intercalación para el campo nombre en la tabla [dbo].[parte] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/* La intercalación para el campo descripcion en la tabla [dbo].[parte] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
IF EXISTS (select top 1 1 from [dbo].[parte])
	RAISERROR ('Filas detectadas, no se actualizará el esquema debido a posible pérdida de datos.', 16, 127) WITH NOWAIT
GO
/* La intercalación para el campo nombre en la tabla [dbo].[parteadicional] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/* La intercalación para el campo plano en la tabla [dbo].[parteadicional] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/* La intercalación para el campo descripcion en la tabla [dbo].[parteadicional] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
IF EXISTS (select top 1 1 from [dbo].[parteadicional])
	RAISERROR ('Filas detectadas, no se actualizará el esquema debido a posible pérdida de datos.', 16, 127) WITH NOWAIT
GO
/* La intercalación para el campo descripcion en la tabla [dbo].[perfil] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
IF EXISTS (select top 1 1 from [dbo].[perfil])
	RAISERROR ('Filas detectadas, no se actualizará el esquema debido a posible pérdida de datos.', 16, 127) WITH NOWAIT
GO
/* La intercalación para el campo nombre en la tabla [dbo].[proveedor] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/* La intercalación para el campo direccion en la tabla [dbo].[proveedor] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/* La intercalación para el campo telefono en la tabla [dbo].[proveedor] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/* La intercalación para el campo mail en la tabla [dbo].[proveedor] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/* La intercalación para el campo nombrecontacto en la tabla [dbo].[proveedor] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
IF EXISTS (select top 1 1 from [dbo].[proveedor])
	RAISERROR ('Filas detectadas, no se actualizará el esquema debido a posible pérdida de datos.', 16, 127) WITH NOWAIT
GO
/* La intercalación para el campo nombre en la tabla [dbo].[provincia] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/* La intercalación para el campo descripcion en la tabla [dbo].[provincia] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
IF EXISTS (select top 1 1 from [dbo].[provincia])
	RAISERROR ('Filas detectadas, no se actualizará el esquema debido a posible pérdida de datos.', 16, 127) WITH NOWAIT
GO
/* La intercalación para el campo nombre en la tabla [dbo].[tipoacabado] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/* La intercalación para el campo descripcion en la tabla [dbo].[tipoacabado] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
IF EXISTS (select top 1 1 from [dbo].[tipoacabado])
	RAISERROR ('Filas detectadas, no se actualizará el esquema debido a posible pérdida de datos.', 16, 127) WITH NOWAIT
GO
/* La intercalación para el campo nombre en la tabla [dbo].[tipodesperfecto] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/* La intercalación para el campo descripcion en la tabla [dbo].[tipodesperfecto] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
IF EXISTS (select top 1 1 from [dbo].[tipodesperfecto])
	RAISERROR ('Filas detectadas, no se actualizará el esquema debido a posible pérdida de datos.', 16, 127) WITH NOWAIT
GO
/* La intercalación para el campo nombre en la tabla [dbo].[tipodocumento] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/* La intercalación para el campo descipcion en la tabla [dbo].[tipodocumento] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
IF EXISTS (select top 1 1 from [dbo].[tipodocumento])
	RAISERROR ('Filas detectadas, no se actualizará el esquema debido a posible pérdida de datos.', 16, 127) WITH NOWAIT
GO
/* La intercalación para el campo nombre en la tabla [dbo].[tipofresa] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/* La intercalación para el campo plano en la tabla [dbo].[tipofresa] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/* La intercalación para el campo posiciondetrabajo en la tabla [dbo].[tipofresa] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/* La intercalación para el campo caracteristicas en la tabla [dbo].[tipofresa] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/* La intercalación para el campo estado en la tabla [dbo].[tipofresa] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
IF EXISTS (select top 1 1 from [dbo].[tipofresa])
	RAISERROR ('Filas detectadas, no se actualizará el esquema debido a posible pérdida de datos.', 16, 127) WITH NOWAIT
GO
/* La intercalación para el campo nombre en la tabla [dbo].[tipomaquina] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/* La intercalación para el campo descripcion en la tabla [dbo].[tipomaquina] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
IF EXISTS (select top 1 1 from [dbo].[tipomaquina])
	RAISERROR ('Filas detectadas, no se actualizará el esquema debido a posible pérdida de datos.', 16, 127) WITH NOWAIT
GO
/* La intercalación para el campo nombre en la tabla [dbo].[tipomateriaprima] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/* La intercalación para el campo direccion en la tabla [dbo].[tipomateriaprima] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
IF EXISTS (select top 1 1 from [dbo].[tipomateriaprima])
	RAISERROR ('Filas detectadas, no se actualizará el esquema debido a posible pérdida de datos.', 16, 127) WITH NOWAIT
GO
/* La intercalación para el campo nombre en la tabla [dbo].[tipoparte] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/* La intercalación para el campo descripcion en la tabla [dbo].[tipoparte] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
IF EXISTS (select top 1 1 from [dbo].[tipoparte])
	RAISERROR ('Filas detectadas, no se actualizará el esquema debido a posible pérdida de datos.', 16, 127) WITH NOWAIT
GO
/* La intercalación para el campo nombre en la tabla [dbo].[tornero] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/* La intercalación para el campo apellido en la tabla [dbo].[tornero] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/* La intercalación para el campo domicilio en la tabla [dbo].[tornero] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/* La intercalación para el campo telefono en la tabla [dbo].[tornero] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/* La intercalación para el campo celular en la tabla [dbo].[tornero] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/* La intercalación para el campo observaciones en la tabla [dbo].[tornero] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
IF EXISTS (select top 1 1 from [dbo].[tornero])
	RAISERROR ('Filas detectadas, no se actualizará el esquema debido a posible pérdida de datos.', 16, 127) WITH NOWAIT
GO
/* La intercalación para el campo nombre en la tabla [dbo].[unidaddemedida] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/* La intercalación para el campo descripcion en la tabla [dbo].[unidaddemedida] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/* La intercalación para el campo abreviacion en la tabla [dbo].[unidaddemedida] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
/* La intercalación para el campo escala en la tabla [dbo].[unidaddemedida] se va a cambiar de Modern_Spanish_CI_AI a Traditional_Spanish_CI_AS. */
IF EXISTS (select top 1 1 from [dbo].[unidaddemedida])
	RAISERROR ('Filas detectadas, no se actualizará el esquema debido a posible pérdida de datos.', 16, 127) WITH NOWAIT
GO
ALTER TABLE [dbo].[empleado] DROP
CONSTRAINT [FK_empleado_perfil]
GO
ALTER TABLE [dbo].[modelofresa] DROP
CONSTRAINT [FK_modelofresa_mododeavance],
CONSTRAINT [FK_modelofresa_tipoacabado]
GO
ALTER TABLE [dbo].[MPxTP] DROP
CONSTRAINT [FK_MPxTP_tipoparte],
CONSTRAINT [FK_MPxTP_tipomateriaprima]
GO
ALTER TABLE [dbo].[cuentausuario] DROP CONSTRAINT [PK_cuentausuario]
GO
ALTER TABLE [dbo].[mododeavance] DROP CONSTRAINT [PK_mododeavance]
GO
ALTER TABLE [dbo].[MPxTP] DROP CONSTRAINT [PK_MPxTP]
GO
ALTER TABLE [dbo].[tipoacabado] DROP CONSTRAINT [PK_tipoacabado]

GO

/*
Este script se creó con Visual Studio el 29/08/2007 a las 22:42.
Ejecute el script en AfilarDB para que sea igual que desktop.Afilar.dbo.
Realice una copia de seguridad de la base de datos de destino antes de ejecutar el script.
*/

GO
SET NUMERIC_ROUNDABORT OFF
GO
SET ANSI_PADDING ON
GO
SET ANSI_WARNINGS ON
GO
SET CONCAT_NULL_YIELDS_NULL ON
GO
SET ARITHABORT ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON

GO

/*
Este script se creó con Visual Studio el 08/09/2007 a las 12:25.
Ejecute el script en AfilarDB para que sea igual que gerardo\sqlexpress.Afilar.dbo.
Realice una copia de seguridad de la base de datos de destino antes de ejecutar el script.
*/

GO
SET NUMERIC_ROUNDABORT OFF
GO
SET ANSI_PADDING ON
GO
SET ANSI_WARNINGS ON
GO
SET CONCAT_NULL_YIELDS_NULL ON
GO
SET ARITHABORT ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON

GO
