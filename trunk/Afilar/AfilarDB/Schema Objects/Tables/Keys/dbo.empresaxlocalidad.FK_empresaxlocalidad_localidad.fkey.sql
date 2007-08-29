ALTER TABLE [dbo].[empresaxlocalidad] WITH NOCHECK ADD
CONSTRAINT [FK_empresaxlocalidad_localidad] FOREIGN KEY ([idlocalidad]) REFERENCES [dbo].[localidad] ([idlocalidad])


