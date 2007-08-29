ALTER TABLE [dbo].[parte] WITH NOCHECK ADD
CONSTRAINT [FK_parte_tipomateriaprima] FOREIGN KEY ([idtipomateriaprima]) REFERENCES [dbo].[tipomateriaprima] ([idtipomateriaprima])


