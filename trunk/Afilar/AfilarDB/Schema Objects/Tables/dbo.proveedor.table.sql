CREATE TABLE [dbo].[proveedor]
(
[idproveedor] [int] NOT NULL,
[nombre] [char] (80) COLLATE Traditional_Spanish_CI_AS NULL,
[direccion] [char] (80) COLLATE Traditional_Spanish_CI_AS NULL,
[telefono] [char] (20) COLLATE Traditional_Spanish_CI_AS NULL,
[mail] [char] (80) COLLATE Traditional_Spanish_CI_AS NULL,
[nombrecontacto] [char] (80) COLLATE Traditional_Spanish_CI_AS NULL,
[idlocalidad] [int] NULL
) ON [PRIMARY]


