CREATE TABLE [dbo].[etapadefabricacion]
(
[idetapafabricacion] [int] NOT NULL,
[idmodelo] [int] NOT NULL,
[idtipofresa] [int] NOT NULL,
[idoperacion] [int] NULL,
[orden] [int] NULL,
[tiempoadicional] [float] NULL,
[detalle] [text] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]


