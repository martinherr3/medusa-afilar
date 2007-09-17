CREATE TABLE [dbo].[maquina]
(
[idmaquina] [int] NOT NULL,
[nombre] [char] (40) COLLATE Traditional_Spanish_CI_AS NOT NULL,
[descripcion] [text] COLLATE Traditional_Spanish_CI_AS NULL,
[numerodeserie] [char] (20) COLLATE Traditional_Spanish_CI_AS NULL,
[potencia] [char] (20) COLLATE Traditional_Spanish_CI_AS NULL,
[costodecompra] [decimal] (18, 0) NULL,
[estadodeadquisicion] [char] (20) COLLATE Traditional_Spanish_CI_AS NULL,
[idestado] [int] NULL,
[horasdeuso] [int] NULL,
[tipomaquina] [char] (40) COLLATE Traditional_Spanish_CI_AS NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]


