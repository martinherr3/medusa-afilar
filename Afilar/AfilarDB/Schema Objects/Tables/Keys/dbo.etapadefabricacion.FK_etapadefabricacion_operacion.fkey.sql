ALTER TABLE [dbo].[etapadefabricacion] WITH NOCHECK ADD
CONSTRAINT [FK_etapadefabricacion_operacion] FOREIGN KEY ([idoperacion]) REFERENCES [dbo].[operacion] ([idoperacion])


