ALTER TABLE [dbo].[cliente] WITH NOCHECK ADD
CONSTRAINT [FK_cliente_tipodocumento] FOREIGN KEY ([idtipodocumento]) REFERENCES [dbo].[tipodocumento] ([idtipodocumento])


