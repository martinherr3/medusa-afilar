ALTER TABLE [dbo].[detallemprecibida] WITH NOCHECK ADD
CONSTRAINT [FK_detallemprecibida_tipomateriaprima] FOREIGN KEY ([idtipomateriaprima]) REFERENCES [dbo].[tipomateriaprima] ([idtipomateriaprima])


