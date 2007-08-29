ALTER TABLE [dbo].[empleado] ADD
CONSTRAINT [FK_empleado_perfil] FOREIGN KEY ([idperfil]) REFERENCES [dbo].[perfil] ([idperfil])


