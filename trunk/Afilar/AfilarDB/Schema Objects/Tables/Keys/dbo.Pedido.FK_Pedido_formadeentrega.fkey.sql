ALTER TABLE [dbo].[Pedido] WITH NOCHECK ADD
CONSTRAINT [FK_Pedido_formadeentrega] FOREIGN KEY ([idformadeentrega]) REFERENCES [dbo].[formadeentrega] ([idformadeentrega])


