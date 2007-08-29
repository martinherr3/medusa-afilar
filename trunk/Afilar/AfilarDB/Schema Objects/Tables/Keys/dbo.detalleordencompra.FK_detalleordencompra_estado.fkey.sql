ALTER TABLE [dbo].[detalleordencompra] WITH NOCHECK ADD
CONSTRAINT [FK_detalleordencompra_estado] FOREIGN KEY ([idestado]) REFERENCES [dbo].[estado] ([idestado])


