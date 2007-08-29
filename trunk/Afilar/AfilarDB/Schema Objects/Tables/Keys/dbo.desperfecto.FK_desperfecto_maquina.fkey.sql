ALTER TABLE [dbo].[desperfecto] WITH NOCHECK ADD
CONSTRAINT [FK_desperfecto_maquina] FOREIGN KEY ([idmaquina]) REFERENCES [dbo].[maquina] ([idmaquina])


