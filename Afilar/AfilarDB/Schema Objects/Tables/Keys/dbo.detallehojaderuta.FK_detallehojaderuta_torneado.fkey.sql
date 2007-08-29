ALTER TABLE [dbo].[detallehojaderuta] WITH NOCHECK ADD
CONSTRAINT [FK_detallehojaderuta_torneado] FOREIGN KEY ([idtorneado]) REFERENCES [dbo].[torneado] ([idtorneado])


