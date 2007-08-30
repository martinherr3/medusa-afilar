CREATE TABLE [dbo].[modelofresa]
(
[idmodelo] [int] NOT NULL,
[nombre] [char] (40) COLLATE Traditional_Spanish_CI_AS NULL,
[grupomodelo] [char] (50) COLLATE Traditional_Spanish_CI_AS NULL,
[descripcion] [text] COLLATE Traditional_Spanish_CI_AS NULL,
[materialatrabajar] [char] (40) COLLATE Traditional_Spanish_CI_AS NULL,
[mododeavance] [char] (40) COLLATE Traditional_Spanish_CI_AS NULL,
[tipoacabado] [char] (40) COLLATE Traditional_Spanish_CI_AS NULL,
[velocidaddeavance] [float] NULL,
[tipomodelo] [char] (40) COLLATE Traditional_Spanish_CI_AS NULL,
[precio] [float] NULL,
[estado] [char] (15) COLLATE Traditional_Spanish_CI_AS NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]


