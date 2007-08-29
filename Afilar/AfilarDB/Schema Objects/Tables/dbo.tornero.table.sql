CREATE TABLE [dbo].[tornero]
(
[idtornero] [int] NOT NULL,
[nombre] [char] (50) NULL,
[apellido] [char] (50) NULL,
[domicilio] [char] (50) NULL,
[telefono] [char] (25) NULL,
[celular] [char] (25) NULL,
[cantidadtorneados] [int] NULL,
[efectividad] [float] NULL,
[observaciones] [text] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]


