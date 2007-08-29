ALTER TABLE [dbo].[Pedido] WITH NOCHECK ADD
CONSTRAINT [FK_Pedido_estado] FOREIGN KEY ([idestado]) REFERENCES [dbo].[estado] ([idestado])


