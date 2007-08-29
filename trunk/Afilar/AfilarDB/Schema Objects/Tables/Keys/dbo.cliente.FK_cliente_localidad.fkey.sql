ALTER TABLE [dbo].[cliente] WITH NOCHECK ADD
CONSTRAINT [FK_cliente_localidad] FOREIGN KEY ([localidad]) REFERENCES [dbo].[localidad] ([idlocalidad])


