ALTER TABLE [dbo].[viajantexlocalidad] WITH NOCHECK ADD
CONSTRAINT [FK_viajantexlocalidad_empleado] FOREIGN KEY ([idviajante]) REFERENCES [dbo].[empleado] ([idlegajo])


