ALTER TABLE [dbo].[MPxTP] WITH NOCHECK ADD
CONSTRAINT [FK_MPxTP_tipoparte] FOREIGN KEY ([nombre]) REFERENCES [dbo].[tipoparte] ([nombre])


