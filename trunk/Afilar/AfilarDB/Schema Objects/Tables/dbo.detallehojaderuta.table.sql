CREATE TABLE [dbo].[detallehojaderuta]
(
[idhojaderuta] [int] NOT NULL,
[idetapadefabricacion] [int] NOT NULL,
[idlegajo] [int] NULL,
[idtorneado] [int] NULL,
[fechahorainicioreal] [datetime] NULL,
[fechahorainicioplanificada] [datetime] NULL,
[fechahorafinreal] [datetime] NULL,
[fechahorafinplanificada] [datetime] NULL,
[observaciones] [char] (30) COLLATE Traditional_Spanish_CI_AS NULL
) ON [PRIMARY]


