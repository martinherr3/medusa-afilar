CREATE TABLE [dbo].[maquinaFresa]
(
[idmaquina] [int] NOT NULL,
[nombre] [text] NOT NULL,
[potencia] [float] NULL,
[rpmdeleje] [float] NULL,
[sentidodegiro] [char] (30) NULL,
[caracteristicas] [text] NULL,
[estado] [char] (25) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]


