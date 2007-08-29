ALTER TABLE [dbo].[empleado] WITH NOCHECK ADD
CONSTRAINT [FK_empleado_localidad] FOREIGN KEY ([idlocalidad]) REFERENCES [dbo].[localidad] ([idlocalidad])


