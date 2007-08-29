ALTER TABLE [dbo].[modelofresa] WITH NOCHECK ADD
CONSTRAINT [FK_modelofresa_materialatrabajar] FOREIGN KEY ([materialatrabajar]) REFERENCES [dbo].[materialatrabajar] ([nombre])


