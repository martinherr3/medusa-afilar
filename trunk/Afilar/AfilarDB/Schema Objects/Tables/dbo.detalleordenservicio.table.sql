CREATE TABLE [dbo].[detalleordenservicio]
(
[idpedido] [numeric] (18, 0) NOT NULL,
[idoperacion] [int] NOT NULL,
[idobjetodelservicio] [int] NOT NULL,
[preciodeservicio] [decimal] (18, 0) NULL,
[observacion] [char] (30) COLLATE Traditional_Spanish_CI_AS NULL,
[idhojaderuta] [int] NULL,
[precio] [decimal] (18, 0) NULL
) ON [PRIMARY]


