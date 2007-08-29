CREATE TABLE [dbo].[mensaje]
(
[idMensaje] [int] NOT NULL,
[asunto] [varchar] (100) NULL,
[idRemitente] [int] NULL,
[idDestinatario] [int] NULL,
[mensaje] [varchar] (555) NULL,
[prioridad] [int] NULL,
[leido] [bit] NULL,
[fechaRecepion] [datetime] NULL,
[fechaLectura] [datetime] NULL
) ON [PRIMARY]


