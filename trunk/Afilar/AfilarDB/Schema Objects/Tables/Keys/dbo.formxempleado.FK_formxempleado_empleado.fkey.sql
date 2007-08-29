ALTER TABLE [dbo].[formxempleado] WITH NOCHECK ADD
CONSTRAINT [FK_formxempleado_empleado] FOREIGN KEY ([idlegajo]) REFERENCES [dbo].[empleado] ([idlegajo])


