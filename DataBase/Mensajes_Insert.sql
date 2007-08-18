USE [Afilar]
GO
/****** Objeto:  Table [dbo].[mensaje]    Fecha de la secuencia de comandos: 08/18/2007 13:00:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[mensaje](
	[idMensaje] [int] NOT NULL,
	[asunto] [varchar](100) NULL,
	[idRemitente] [int] NULL,
	[idDestinatario] [int] NULL,
	[mensaje] [varchar](555) NULL,
	[prioridad] [int] NULL,
	[leido] [bit] NULL,
	[fechaRecepion] [datetime] NULL,
	[fechaLectura] [datetime] NULL,
 CONSTRAINT [PK_Mensaje] PRIMARY KEY CLUSTERED 
(
	[idMensaje] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[mensaje]  WITH CHECK ADD  CONSTRAINT [FK_Mensaje_empleado] FOREIGN KEY([idRemitente])
REFERENCES [dbo].[empleado] ([idlegajo])
GO
ALTER TABLE [dbo].[mensaje] CHECK CONSTRAINT [FK_Mensaje_empleado]
GO
ALTER TABLE [dbo].[mensaje]  WITH CHECK ADD  CONSTRAINT [FK_Mensaje_empleado1] FOREIGN KEY([idDestinatario])
REFERENCES [dbo].[empleado] ([idlegajo])
GO
ALTER TABLE [dbo].[mensaje] CHECK CONSTRAINT [FK_Mensaje_empleado1]