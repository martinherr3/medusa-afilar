CREATE TABLE [dbo].[cuentausuario]
(
[usuario] [char] (6) COLLATE Traditional_Spanish_CI_AS NOT NULL,
[contraseña] [char] (100) COLLATE Traditional_Spanish_CI_AS NOT NULL,
[creacion] [datetime] NULL,
[idlegajo] [int] NOT NULL
) ON [PRIMARY]


