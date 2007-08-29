ALTER TABLE [dbo].[parteadicional] WITH NOCHECK ADD
CONSTRAINT [FK_parteadicional_modelofresa] FOREIGN KEY ([idmodelo]) REFERENCES [dbo].[modelofresa] ([idmodelo])


