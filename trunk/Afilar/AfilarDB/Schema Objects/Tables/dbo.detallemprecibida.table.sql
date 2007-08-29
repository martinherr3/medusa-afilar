CREATE TABLE [dbo].[detallemprecibida]
(
[idmprecibida] [int] NOT NULL,
[cantidad] [int] NULL,
[preciol] [float] NULL,
[causarechazo] [char] (20) NULL,
[idestado] [int] NULL,
[idtipomateriaprima] [int] NOT NULL
) ON [PRIMARY]


