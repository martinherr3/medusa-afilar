ALTER TABLE [dbo].[modelofresa] WITH NOCHECK ADD
CONSTRAINT [FK_modelofresa_mododeavance] FOREIGN KEY ([mododeavance]) REFERENCES [dbo].[mododeavance] ([nombre])


