ALTER TABLE [dbo].[detallehojaderuta] WITH NOCHECK ADD
CONSTRAINT [FK_detallehojaderuta_hojaderuta] FOREIGN KEY ([idhojaderuta]) REFERENCES [dbo].[hojaderuta] ([idhojaderuta])


