ALTER TABLE [dbo].[fresaxmaquina] WITH NOCHECK ADD
CONSTRAINT [FK_fresaxmaquina_modelofresa] FOREIGN KEY ([idmodelo]) REFERENCES [dbo].[modelofresa] ([idmodelo])


