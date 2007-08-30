CREATE TABLE [dbo].[mensaje]
(
[idMensaje] [int] NOT NULL,
[asunto] [varchar] (100) COLLATE Traditional_Spanish_CI_AS NULL,
[idRemitente] [int] NULL,
[idDestinatario] [int] NULL,
[mensaje] [varchar] (555) COLLATE Traditional_Spanish_CI_AS NULL,
[prioridad] [int] NULL,
[leido] [bit] NULL,
[fechaRecepion] [datetime] NULL,
[fechaLectura] [datetime] NULL
) ON [PRIMARY]


