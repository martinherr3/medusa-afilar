ALTER TABLE [dbo].[partepedido] WITH NOCHECK ADD
CONSTRAINT [FK_partepedido_Pedido] FOREIGN KEY ([idpedido]) REFERENCES [dbo].[Pedido] ([idpedido])


