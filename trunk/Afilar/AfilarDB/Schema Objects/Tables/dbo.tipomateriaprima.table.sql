CREATE TABLE [dbo].[tipomateriaprima]
(
[idtipomateriaprima] [int] NOT NULL,
[nombre] [char] (40) COLLATE Traditional_Spanish_CI_AS NULL,
[direccion] [char] (40) COLLATE Traditional_Spanish_CI_AS NULL,
[stockactual] [int] NULL,
[stockminimo] [int] NULL,
[stockseguridad] [int] NULL,
[loteeconomico] [int] NULL,
[idunidadmedida] [int] NULL
) ON [PRIMARY]


