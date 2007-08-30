CREATE TABLE [dbo].[ordencompramp]
(
[fecharealizacion] [datetime] NULL,
[plazodeentrega] [datetime] NULL,
[idordencompra] [int] NOT NULL,
[nroorden] [int] NULL,
[condicionesdepago] [char] (40) COLLATE Traditional_Spanish_CI_AS NULL,
[causa] [char] (40) COLLATE Traditional_Spanish_CI_AS NULL,
[idestado] [int] NULL,
[idproveedor] [int] NULL
) ON [PRIMARY]


