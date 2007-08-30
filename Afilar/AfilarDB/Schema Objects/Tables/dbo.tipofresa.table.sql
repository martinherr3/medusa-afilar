CREATE TABLE [dbo].[tipofresa]
(
[idtipo] [int] NOT NULL,
[idmodelo] [int] NOT NULL,
[nombre] [char] (20) COLLATE Traditional_Spanish_CI_AS NULL,
[diametroexterior] [decimal] (18, 0) NULL,
[diametroagujero] [decimal] (18, 0) NULL,
[cantidaddientes] [int] NULL,
[plano] [char] (80) COLLATE Traditional_Spanish_CI_AS NULL,
[posiciondetrabajo] [char] (40) COLLATE Traditional_Spanish_CI_AS NULL,
[caracteristicas] [text] COLLATE Traditional_Spanish_CI_AS NULL,
[costo] [decimal] (18, 0) NULL,
[precio] [decimal] (18, 0) NULL,
[estado] [char] (15) COLLATE Traditional_Spanish_CI_AS NULL,
[imagen] [image] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]


