CREATE TABLE [dbo].[empleado]
(
[idlegajo] [int] NOT NULL,
[nombre] [char] (50) COLLATE Traditional_Spanish_CI_AS NULL,
[apellido] [char] (50) COLLATE Traditional_Spanish_CI_AS NULL,
[direccion] [char] (20) COLLATE Traditional_Spanish_CI_AS NULL,
[telefono] [char] (20) COLLATE Traditional_Spanish_CI_AS NULL,
[idcargo] [int] NULL,
[email] [char] (30) COLLATE Traditional_Spanish_CI_AS NULL,
[titulo] [char] (30) COLLATE Traditional_Spanish_CI_AS NULL,
[idlocalidad] [int] NULL,
[turno] [char] (30) COLLATE Traditional_Spanish_CI_AS NULL,
[idperfil] [int] NULL
) ON [PRIMARY]


