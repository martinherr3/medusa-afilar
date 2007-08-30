CREATE TABLE [dbo].[parteadicional]
(
[idadicional] [int] NOT NULL,
[idmodelo] [int] NOT NULL,
[nombre] [char] (60) COLLATE Traditional_Spanish_CI_AS NULL,
[plano] [char] (80) COLLATE Traditional_Spanish_CI_AS NULL,
[imagen] [image] NULL,
[idmateriaprima] [int] NULL,
[cantidad] [float] NULL,
[descripcion] [text] COLLATE Traditional_Spanish_CI_AS NULL,
[tiempo] [float] NULL,
[costo] [float] NULL,
[precio] [float] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]


