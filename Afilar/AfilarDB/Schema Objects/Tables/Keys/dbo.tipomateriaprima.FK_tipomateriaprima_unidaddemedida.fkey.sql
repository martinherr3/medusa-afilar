ALTER TABLE [dbo].[tipomateriaprima] WITH NOCHECK ADD
CONSTRAINT [FK_tipomateriaprima_unidaddemedida] FOREIGN KEY ([idunidadmedida]) REFERENCES [dbo].[unidaddemedida] ([idunidadmedida])


