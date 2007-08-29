ALTER TABLE [dbo].[presupuesto] WITH NOCHECK ADD
CONSTRAINT [FK_presupuesto_cliente] FOREIGN KEY ([idcliente]) REFERENCES [dbo].[cliente] ([idcliente])


