ALTER TABLE [dbo].[fresaxmaquina] WITH NOCHECK ADD
CONSTRAINT [FK_fresaxmaquina_maquinaFresa] FOREIGN KEY ([idmaquina]) REFERENCES [dbo].[maquinaFresa] ([idmaquina])


