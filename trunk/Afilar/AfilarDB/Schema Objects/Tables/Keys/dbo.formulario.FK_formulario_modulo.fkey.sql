ALTER TABLE [dbo].[formulario] WITH NOCHECK ADD
CONSTRAINT [FK_formulario_modulo] FOREIGN KEY ([idmodulo]) REFERENCES [dbo].[modulo] ([idmodulo])


