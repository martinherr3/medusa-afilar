ALTER TABLE [dbo].[Pedido] WITH NOCHECK ADD
CONSTRAINT [FK_Pedido_cliente] FOREIGN KEY ([idcliente]) REFERENCES [dbo].[cliente] ([idcliente])


