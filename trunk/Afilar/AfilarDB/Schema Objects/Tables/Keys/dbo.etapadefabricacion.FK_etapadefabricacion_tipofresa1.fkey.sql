ALTER TABLE [dbo].[etapadefabricacion] WITH NOCHECK ADD
CONSTRAINT [FK_etapadefabricacion_tipofresa1] FOREIGN KEY ([idtipofresa], [idmodelo]) REFERENCES [dbo].[tipofresa] ([idtipo], [idmodelo])


