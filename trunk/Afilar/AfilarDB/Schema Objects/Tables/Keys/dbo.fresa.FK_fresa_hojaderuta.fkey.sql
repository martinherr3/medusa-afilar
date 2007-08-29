ALTER TABLE [dbo].[fresa] WITH NOCHECK ADD
CONSTRAINT [FK_fresa_hojaderuta] FOREIGN KEY ([idhojaderuta]) REFERENCES [dbo].[hojaderuta] ([idhojaderuta])


