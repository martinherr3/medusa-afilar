ALTER TABLE [dbo].[detalleordencompra] WITH NOCHECK ADD
CONSTRAINT [FK_detalleordencompra_tipomateriaprima] FOREIGN KEY ([idtipomateriaprima]) REFERENCES [dbo].[tipomateriaprima] ([idtipomateriaprima])


