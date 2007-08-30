CREATE TABLE [dbo].[operacion]
(
[idoperacion] [int] NOT NULL,
[nombre] [char] (40) COLLATE Traditional_Spanish_CI_AS NULL,
[maquina] [char] (40) COLLATE Traditional_Spanish_CI_AS NULL,
[duracionpromedio] [float] NULL,
[idgradodificultad] [int] NULL,
[tolerancia] [float] NULL,
[descripcion] [text] COLLATE Traditional_Spanish_CI_AS NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]


