CREATE TABLE [dbo].[detallepresupuesto]
(
[iddetpre] [int] NOT NULL,
[idpresupuesto] [int] NOT NULL,
[idmodelo] [int] NULL,
[idproducto] [int] NULL,
[tipo] [int] NULL,
[cantidad] [int] NULL,
[precio] [float] NULL,
[nombreProducto] [varchar] (100) COLLATE Traditional_Spanish_CI_AS NULL
) ON [PRIMARY]


