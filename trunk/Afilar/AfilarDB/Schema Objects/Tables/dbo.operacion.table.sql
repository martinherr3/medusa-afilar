CREATE TABLE [dbo].[operacion]
(
[idoperacion] [int] NOT NULL,
[nombre] [char] (40) NULL,
[maquina] [char] (40) NULL,
[duracionpromedio] [float] NULL,
[idgradodificultad] [int] NULL,
[tolerancia] [float] NULL,
[descripcion] [text] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]


