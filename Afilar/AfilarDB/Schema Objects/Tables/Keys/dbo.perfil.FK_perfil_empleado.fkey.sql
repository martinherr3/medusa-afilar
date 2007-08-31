ALTER TABLE [dbo].[perfil] WITH NOCHECK ADD
CONSTRAINT [FK_perfil_empleado] FOREIGN KEY ([idlegajo]) REFERENCES [dbo].[empleado] ([idlegajo])


