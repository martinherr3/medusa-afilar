ALTER TABLE [dbo].[modelofresa] WITH NOCHECK ADD
CONSTRAINT [FK_modelofresa_tipoacabado] FOREIGN KEY ([tipoacabado]) REFERENCES [dbo].[tipoacabado] ([nombre])


