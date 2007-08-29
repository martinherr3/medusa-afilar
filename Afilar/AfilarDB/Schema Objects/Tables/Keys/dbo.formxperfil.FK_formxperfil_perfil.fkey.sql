ALTER TABLE [dbo].[formxperfil] WITH NOCHECK ADD
CONSTRAINT [FK_formxperfil_perfil] FOREIGN KEY ([idperfil]) REFERENCES [dbo].[perfil] ([idperfil])


