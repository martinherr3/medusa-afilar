CREATE TABLE [dbo].[parte]
(
[idmodelo] [int] NOT NULL,
[idtipofresa] [int] NOT NULL,
[idparte] [int] NOT NULL,
[cantidad] [float] NULL,
[nombre] [char] (40) COLLATE Traditional_Spanish_CI_AS NULL,
[descripcion] [text] COLLATE Traditional_Spanish_CI_AS NULL,
[idtipomateriaprima] [int] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]


