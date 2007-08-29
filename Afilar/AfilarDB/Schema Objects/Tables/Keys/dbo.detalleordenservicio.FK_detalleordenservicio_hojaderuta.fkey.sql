ALTER TABLE [dbo].[detalleordenservicio] WITH NOCHECK ADD
CONSTRAINT [FK_detalleordenservicio_hojaderuta] FOREIGN KEY ([idhojaderuta]) REFERENCES [dbo].[hojaderuta] ([idhojaderuta])


