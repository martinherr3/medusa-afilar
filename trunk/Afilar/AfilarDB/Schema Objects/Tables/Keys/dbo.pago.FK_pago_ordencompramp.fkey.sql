ALTER TABLE [dbo].[pago] WITH NOCHECK ADD
CONSTRAINT [FK_pago_ordencompramp] FOREIGN KEY ([idordencompra]) REFERENCES [dbo].[ordencompramp] ([idordencompra])


