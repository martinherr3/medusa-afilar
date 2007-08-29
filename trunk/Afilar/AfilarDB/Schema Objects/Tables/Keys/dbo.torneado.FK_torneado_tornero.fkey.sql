ALTER TABLE [dbo].[torneado] WITH NOCHECK ADD
CONSTRAINT [FK_torneado_tornero] FOREIGN KEY ([idtornero]) REFERENCES [dbo].[tornero] ([idtornero])


