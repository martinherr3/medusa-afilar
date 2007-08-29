ALTER TABLE [dbo].[detalleordenservicio] WITH NOCHECK ADD
CONSTRAINT [FK_detalleordenservicio_operacion] FOREIGN KEY ([idoperacion]) REFERENCES [dbo].[operacion] ([idoperacion])


