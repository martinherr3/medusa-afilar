CREATE TABLE [dbo].[controlcalidad]
(
[idcontrol] [int] NOT NULL,
[observaciones] [char] (250) NULL,
[medidas] [char] (10) NULL,
[pintura] [char] (10) NULL,
[soldadura] [char] (10) NULL,
[torneado] [char] (10) NULL,
[idfresa] [int] NULL,
[fechahoracontrol] [nvarchar] (50) NULL
) ON [PRIMARY]


