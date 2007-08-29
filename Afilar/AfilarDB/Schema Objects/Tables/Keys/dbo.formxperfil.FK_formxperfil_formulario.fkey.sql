ALTER TABLE [dbo].[formxperfil] WITH NOCHECK ADD
CONSTRAINT [FK_formxperfil_formulario] FOREIGN KEY ([idformulario]) REFERENCES [dbo].[formulario] ([idformulario])


