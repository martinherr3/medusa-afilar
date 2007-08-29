CREATE TABLE [dbo].[modelofresa]
(
[idmodelo] [int] NOT NULL,
[nombre] [char] (40) NULL,
[grupomodelo] [char] (50) NULL,
[descripcion] [text] NULL,
[materialatrabajar] [char] (40) NULL,
[mododeavance] [char] (40) NULL,
[tipoacabado] [char] (40) NULL,
[velocidaddeavance] [float] NULL,
[tipomodelo] [char] (40) NULL,
[precio] [float] NULL,
[estado] [char] (15) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]


