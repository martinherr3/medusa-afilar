CREATE TABLE [dbo].[tornero]
(
[idtornero] [int] NOT NULL,
[nombre] [char] (50) COLLATE Traditional_Spanish_CI_AS NULL,
[apellido] [char] (50) COLLATE Traditional_Spanish_CI_AS NULL,
[domicilio] [char] (50) COLLATE Traditional_Spanish_CI_AS NULL,
[telefono] [char] (25) COLLATE Traditional_Spanish_CI_AS NULL,
[celular] [char] (25) COLLATE Traditional_Spanish_CI_AS NULL,
[cantidadtorneados] [int] NULL,
[efectividad] [float] NULL,
[observaciones] [text] COLLATE Traditional_Spanish_CI_AS NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]


