ALTER TABLE [dbo].[empleado] WITH NOCHECK ADD
CONSTRAINT [FK_empleado_perfil] FOREIGN KEY ([idperfil]) REFERENCES [dbo].[perfil] ([idperfil])


