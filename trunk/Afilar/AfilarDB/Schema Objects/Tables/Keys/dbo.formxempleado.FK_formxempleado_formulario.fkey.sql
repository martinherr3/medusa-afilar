ALTER TABLE [dbo].[formxempleado] WITH NOCHECK ADD
CONSTRAINT [FK_formxempleado_formulario] FOREIGN KEY ([idformulario]) REFERENCES [dbo].[formulario] ([idformulario])


