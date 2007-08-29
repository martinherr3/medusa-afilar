ALTER TABLE [dbo].[operacion] WITH NOCHECK ADD
CONSTRAINT [FK_operacion_gradodificultad] FOREIGN KEY ([idgradodificultad]) REFERENCES [dbo].[gradodificultad] ([idgradodificultad])


