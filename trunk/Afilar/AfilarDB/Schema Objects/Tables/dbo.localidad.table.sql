CREATE TABLE [dbo].[localidad]
(
[idlocalidad] [int] NOT NULL,
[codigopostal] [int] NULL,
[zona] [char] (20) COLLATE Traditional_Spanish_CI_AS NULL,
[provincia] [char] (20) COLLATE Traditional_Spanish_CI_AS NULL,
[distancia] [char] (20) COLLATE Traditional_Spanish_CI_AS NULL,
[nombre] [char] (20) COLLATE Traditional_Spanish_CI_AS NULL,
[idprovincia] [int] NULL
) ON [PRIMARY]


