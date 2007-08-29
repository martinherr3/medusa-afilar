ALTER TABLE [dbo].[mensaje] ADD
CONSTRAINT [FK_Mensaje_empleado1] FOREIGN KEY ([idDestinatario]) REFERENCES [dbo].[empleado] ([idlegajo])


