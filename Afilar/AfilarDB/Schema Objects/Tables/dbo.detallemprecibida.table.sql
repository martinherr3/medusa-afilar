CREATE TABLE [dbo].[detallemprecibida]
(
[idmprecibida] [int] NOT NULL,
[cantidad] [int] NULL,
[preciol] [float] NULL,
[causarechazo] [char] (20) COLLATE Traditional_Spanish_CI_AS NULL,
[idestado] [int] NULL,
[idtipomateriaprima] [int] NOT NULL
) ON [PRIMARY]


