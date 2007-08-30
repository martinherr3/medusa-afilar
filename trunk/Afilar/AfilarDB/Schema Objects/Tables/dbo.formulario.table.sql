CREATE TABLE [dbo].[formulario]
(
[idformulario] [int] NOT NULL,
[descripcion] [char] (50) COLLATE Traditional_Spanish_CI_AS NULL,
[idmodulo] [int] NULL,
[nombre] [varchar] (50) COLLATE Traditional_Spanish_CI_AS NOT NULL,
[idmenu] [int] NULL,
[activo] [bit] NULL
) ON [PRIMARY]


