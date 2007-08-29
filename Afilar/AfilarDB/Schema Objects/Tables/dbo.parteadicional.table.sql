CREATE TABLE [dbo].[parteadicional]
(
[idadicional] [int] NOT NULL,
[idmodelo] [int] NOT NULL,
[nombre] [char] (60) NULL,
[plano] [char] (80) NULL,
[imagen] [image] NULL,
[idmateriaprima] [int] NULL,
[cantidad] [float] NULL,
[descripcion] [text] NULL,
[tiempo] [float] NULL,
[costo] [float] NULL,
[precio] [float] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]


