ALTER TABLE [dbo].[cuentausuario] WITH NOCHECK ADD
CONSTRAINT [FK_cuentausuario_empleado] FOREIGN KEY ([idlegajo]) REFERENCES [dbo].[empleado] ([idlegajo])


