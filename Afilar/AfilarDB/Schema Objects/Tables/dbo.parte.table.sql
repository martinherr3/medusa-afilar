CREATE TABLE [dbo].[parte]
(
[idmodelo] [int] NOT NULL,
[idtipofresa] [int] NOT NULL,
[idparte] [int] NOT NULL,
[cantidad] [float] NULL,
[nombre] [char] (40) NULL,
[descripcion] [text] NULL,
[idtipomateriaprima] [int] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]


