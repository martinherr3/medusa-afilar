ALTER TABLE [dbo].[partepedido] WITH NOCHECK ADD
CONSTRAINT [FK_partepedido_parteadicional] FOREIGN KEY ([idadicional], [idmodelo]) REFERENCES [dbo].[parteadicional] ([idadicional], [idmodelo])


