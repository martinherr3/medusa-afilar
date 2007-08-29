ALTER TABLE [dbo].[empleado] WITH NOCHECK ADD
CONSTRAINT [FK_empleado_cargo] FOREIGN KEY ([idcargo]) REFERENCES [dbo].[cargo] ([idcargo])


