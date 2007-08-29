ALTER TABLE [dbo].[Pedido] WITH NOCHECK ADD
CONSTRAINT [FK_Pedido_empleado] FOREIGN KEY ([idvendedor]) REFERENCES [dbo].[empleado] ([idlegajo])


