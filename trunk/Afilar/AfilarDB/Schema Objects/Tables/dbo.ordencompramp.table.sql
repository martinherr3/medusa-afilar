CREATE TABLE [dbo].[ordencompramp]
(
[fecharealizacion] [datetime] NULL,
[plazodeentrega] [datetime] NULL,
[idordencompra] [int] NOT NULL,
[nroorden] [int] NULL,
[condicionesdepago] [char] (40) NULL,
[causa] [char] (40) NULL,
[idestado] [int] NULL,
[idproveedor] [int] NULL
) ON [PRIMARY]


