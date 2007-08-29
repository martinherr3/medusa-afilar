ALTER TABLE [dbo].[proveedor] WITH NOCHECK ADD
CONSTRAINT [FK_proveedor_localidad] FOREIGN KEY ([idlocalidad]) REFERENCES [dbo].[localidad] ([idlocalidad])


