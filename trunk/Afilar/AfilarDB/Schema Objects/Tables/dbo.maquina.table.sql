CREATE TABLE [dbo].[maquina]
(
[idmaquina] [int] NOT NULL,
[nombre] [char] (40) NOT NULL,
[descripcion] [text] NULL,
[numerodeserie] [char] (20) NULL,
[potencia] [char] (20) NULL,
[costodecompra] [decimal] (18, 0) NULL,
[estadodeadquisicion] [char] (20) NULL,
[idestado] [int] NULL,
[horasdeuso] [int] NULL,
[tipomaquina] [char] (40) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]


