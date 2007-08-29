ALTER TABLE [dbo].[parte] WITH NOCHECK ADD
CONSTRAINT [FK_parte_tipoparte] FOREIGN KEY ([nombre]) REFERENCES [dbo].[tipoparte] ([nombre])


