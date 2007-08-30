CREATE TABLE [dbo].[cliente]
(
[idcliente] [int] NOT NULL,
[nombre] [char] (50) COLLATE Traditional_Spanish_CI_AS NOT NULL,
[apellido] [char] (50) COLLATE Traditional_Spanish_CI_AS NULL,
[idtipodocumento] [int] NULL,
[direccion] [char] (50) COLLATE Traditional_Spanish_CI_AS NULL,
[localidad] [int] NULL,
[mail] [char] (50) COLLATE Traditional_Spanish_CI_AS NULL,
[telefono] [char] (20) COLLATE Traditional_Spanish_CI_AS NULL,
[documento] [numeric] (18, 0) NULL,
[celular] [char] (20) COLLATE Traditional_Spanish_CI_AS NULL
) ON [PRIMARY]


