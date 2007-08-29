CREATE TABLE [dbo].[fresa]
(
[nroserie] [int] NOT NULL,
[fechafinfabricacion] [datetime] NULL,
[costofabricacion] [decimal] (18, 0) NULL,
[estado] [int] NULL,
[nropedido] [numeric] (18, 0) NOT NULL,
[controlcalidad] [int] NULL,
[idhojaderuta] [int] NULL,
[precio] [decimal] (18, 0) NULL,
[idtipo] [int] NULL,
[idmodelo] [int] NULL
) ON [PRIMARY]


