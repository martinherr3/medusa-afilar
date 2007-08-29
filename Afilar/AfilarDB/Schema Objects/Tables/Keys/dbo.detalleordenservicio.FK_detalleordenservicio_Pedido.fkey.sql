ALTER TABLE [dbo].[detalleordenservicio] WITH NOCHECK ADD
CONSTRAINT [FK_detalleordenservicio_Pedido] FOREIGN KEY ([idpedido]) REFERENCES [dbo].[Pedido] ([idpedido])


