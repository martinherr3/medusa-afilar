ALTER TABLE [dbo].[Pedido] WITH NOCHECK ADD
CONSTRAINT [FK_Pedido_empresatransporte] FOREIGN KEY ([idempresa]) REFERENCES [dbo].[empresatransporte] ([idempresa])


