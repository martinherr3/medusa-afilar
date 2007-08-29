ALTER TABLE [dbo].[fresa] WITH NOCHECK ADD
CONSTRAINT [FK_fresa_tipofresa] FOREIGN KEY ([idtipo], [idmodelo]) REFERENCES [dbo].[tipofresa] ([idtipo], [idmodelo])


