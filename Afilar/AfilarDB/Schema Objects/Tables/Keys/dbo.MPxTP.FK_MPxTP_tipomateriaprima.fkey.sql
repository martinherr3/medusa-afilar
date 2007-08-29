ALTER TABLE [dbo].[MPxTP] WITH NOCHECK ADD
CONSTRAINT [FK_MPxTP_tipomateriaprima] FOREIGN KEY ([idmp]) REFERENCES [dbo].[tipomateriaprima] ([idtipomateriaprima])


