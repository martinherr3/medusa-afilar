ALTER TABLE [dbo].[detalleordenservicio] WITH NOCHECK ADD
CONSTRAINT [FK_detalleordenservicio_objetodelservicio] FOREIGN KEY ([idobjetodelservicio]) REFERENCES [dbo].[objetodelservicio] ([idobjetodelservicio])


