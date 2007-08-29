ALTER TABLE [dbo].[detalleordencompra] WITH NOCHECK ADD
CONSTRAINT [FK_detalleordencompra_ordencompramp1] FOREIGN KEY ([idordencompra]) REFERENCES [dbo].[ordencompramp] ([idordencompra])


