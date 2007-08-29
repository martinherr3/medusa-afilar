ALTER TABLE [dbo].[formulario] WITH NOCHECK ADD
CONSTRAINT [FK_formulario_menupadre] FOREIGN KEY ([idmenu]) REFERENCES [dbo].[menupadre] ([idmenu])


