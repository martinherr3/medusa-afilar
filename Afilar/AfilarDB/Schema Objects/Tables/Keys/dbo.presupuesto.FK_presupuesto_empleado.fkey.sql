ALTER TABLE [dbo].[presupuesto] WITH NOCHECK ADD
CONSTRAINT [FK_presupuesto_empleado] FOREIGN KEY ([idempleado]) REFERENCES [dbo].[empleado] ([idlegajo])


