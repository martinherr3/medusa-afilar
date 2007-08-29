ALTER TABLE [dbo].[operacion] WITH NOCHECK ADD
CONSTRAINT [FK_operacion_tipomaquina] FOREIGN KEY ([maquina]) REFERENCES [dbo].[tipomaquina] ([nombre])


