ALTER TABLE [dbo].[proveedorxtipomateriaprima] WITH NOCHECK ADD
CONSTRAINT [FK_proveedorxtipomateriaprima_tipomateriaprima] FOREIGN KEY ([idtipomateriaprima]) REFERENCES [dbo].[tipomateriaprima] ([idtipomateriaprima])


