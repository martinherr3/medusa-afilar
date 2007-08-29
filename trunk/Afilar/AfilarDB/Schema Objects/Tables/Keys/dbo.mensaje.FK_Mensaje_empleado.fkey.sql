ALTER TABLE [dbo].[mensaje] ADD
CONSTRAINT [FK_Mensaje_empleado] FOREIGN KEY ([idRemitente]) REFERENCES [dbo].[empleado] ([idlegajo])


