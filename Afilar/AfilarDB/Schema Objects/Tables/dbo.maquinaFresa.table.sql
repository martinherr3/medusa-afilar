CREATE TABLE [dbo].[maquinaFresa]
(
[idmaquina] [int] NOT NULL,
[nombre] [text] COLLATE Traditional_Spanish_CI_AS NOT NULL,
[potencia] [float] NULL,
[rpmdeleje] [float] NULL,
[sentidodegiro] [char] (30) COLLATE Traditional_Spanish_CI_AS NULL,
[caracteristicas] [text] COLLATE Traditional_Spanish_CI_AS NULL,
[estado] [char] (25) COLLATE Traditional_Spanish_CI_AS NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]


