CREATE TABLE [dbo].[desperfecto]
(
[iddesperfecto] [int] NOT NULL,
[idtipodesperfecto] [int] NULL,
[fecharotura] [datetime] NULL,
[causa] [char] (30) NULL,
[fechareparacion] [datetime] NULL,
[costo] [decimal] (18, 0) NULL,
[idmaquina] [int] NULL,
[reparado] [bit] NULL
) ON [PRIMARY]


