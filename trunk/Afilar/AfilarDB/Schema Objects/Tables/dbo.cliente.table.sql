CREATE TABLE [dbo].[cliente]
(
[idcliente] [int] NOT NULL,
[nombre] [char] (50) NOT NULL,
[apellido] [char] (50) NULL,
[idtipodocumento] [int] NULL,
[direccion] [char] (50) NULL,
[localidad] [int] NULL,
[mail] [char] (50) NULL,
[telefono] [char] (20) NULL,
[documento] [numeric] (18, 0) NULL,
[celular] [char] (20) NULL
) ON [PRIMARY]


