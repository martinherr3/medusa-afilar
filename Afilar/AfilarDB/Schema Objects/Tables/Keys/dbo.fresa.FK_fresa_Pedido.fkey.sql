ALTER TABLE [dbo].[fresa] WITH NOCHECK ADD
CONSTRAINT [FK_fresa_Pedido] FOREIGN KEY ([nropedido]) REFERENCES [dbo].[Pedido] ([idpedido])


