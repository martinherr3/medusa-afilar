CREATE TABLE [dbo].[tipofresa]
(
[idtipo] [int] NOT NULL,
[idmodelo] [int] NOT NULL,
[nombre] [char] (20) NULL,
[diametroexterior] [decimal] (18, 0) NULL,
[diametroagujero] [decimal] (18, 0) NULL,
[cantidaddientes] [int] NULL,
[plano] [char] (80) NULL,
[posiciondetrabajo] [char] (40) NULL,
[caracteristicas] [text] NULL,
[costo] [decimal] (18, 0) NULL,
[precio] [decimal] (18, 0) NULL,
[estado] [char] (15) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]


