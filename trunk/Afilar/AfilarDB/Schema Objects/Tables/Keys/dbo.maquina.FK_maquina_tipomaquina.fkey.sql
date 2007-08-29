ALTER TABLE [dbo].[maquina] WITH NOCHECK ADD
CONSTRAINT [FK_maquina_tipomaquina] FOREIGN KEY ([tipomaquina]) REFERENCES [dbo].[tipomaquina] ([nombre])


