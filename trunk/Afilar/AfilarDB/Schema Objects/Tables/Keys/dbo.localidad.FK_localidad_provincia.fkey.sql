ALTER TABLE [dbo].[localidad] WITH NOCHECK ADD
CONSTRAINT [FK_localidad_provincia] FOREIGN KEY ([idprovincia]) REFERENCES [dbo].[provincia] ([idprovincia])


