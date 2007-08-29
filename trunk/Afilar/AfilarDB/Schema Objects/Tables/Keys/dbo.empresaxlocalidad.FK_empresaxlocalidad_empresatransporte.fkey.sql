ALTER TABLE [dbo].[empresaxlocalidad] WITH NOCHECK ADD
CONSTRAINT [FK_empresaxlocalidad_empresatransporte] FOREIGN KEY ([idempresa]) REFERENCES [dbo].[empresatransporte] ([idempresa])


