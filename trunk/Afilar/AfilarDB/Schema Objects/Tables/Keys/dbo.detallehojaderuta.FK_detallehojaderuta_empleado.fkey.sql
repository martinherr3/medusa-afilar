ALTER TABLE [dbo].[detallehojaderuta] WITH NOCHECK ADD
CONSTRAINT [FK_detallehojaderuta_empleado] FOREIGN KEY ([idlegajo]) REFERENCES [dbo].[empleado] ([idlegajo])


