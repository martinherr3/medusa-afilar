CREATE TABLE [dbo].[desperfecto]
(
[iddesperfecto] [int] NOT NULL,
[idtipodesperfecto] [int] NULL,
[fecharotura] [datetime] NULL,
[causa] [char] (30) COLLATE Traditional_Spanish_CI_AS NULL,
[fechareparacion] [datetime] NULL,
[costo] [decimal] (18, 0) NULL,
[idmaquina] [int] NULL
) ON [PRIMARY]


