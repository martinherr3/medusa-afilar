CREATE TABLE [dbo].[controlcalidad]
(
[idcontrol] [int] NOT NULL,
[observaciones] [char] (250) COLLATE Traditional_Spanish_CI_AS NULL,
[medidas] [char] (10) COLLATE Traditional_Spanish_CI_AS NULL,
[pintura] [char] (10) COLLATE Traditional_Spanish_CI_AS NULL,
[soldadura] [char] (10) COLLATE Traditional_Spanish_CI_AS NULL,
[torneado] [char] (10) COLLATE Traditional_Spanish_CI_AS NULL,
[idfresa] [int] NULL,
[fechahoracontrol] [nvarchar] (50) COLLATE Traditional_Spanish_CI_AS NULL
) ON [PRIMARY]


