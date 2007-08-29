ALTER TABLE [dbo].[tipofresa] WITH NOCHECK ADD
CONSTRAINT [FK_tipofresa_modelofresa] FOREIGN KEY ([idmodelo]) REFERENCES [dbo].[modelofresa] ([idmodelo])


