ALTER TABLE [dbo].[parte] WITH NOCHECK ADD
CONSTRAINT [FK_parte_tipofresa1] FOREIGN KEY ([idtipofresa], [idmodelo]) REFERENCES [dbo].[tipofresa] ([idtipo], [idmodelo])


