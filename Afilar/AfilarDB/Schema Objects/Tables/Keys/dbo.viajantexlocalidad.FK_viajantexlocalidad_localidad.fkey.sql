ALTER TABLE [dbo].[viajantexlocalidad] WITH NOCHECK ADD
CONSTRAINT [FK_viajantexlocalidad_localidad] FOREIGN KEY ([idlocalidad]) REFERENCES [dbo].[localidad] ([idlocalidad])


