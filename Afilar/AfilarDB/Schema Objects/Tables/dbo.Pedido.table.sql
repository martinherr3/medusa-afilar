CREATE TABLE [dbo].[Pedido]
(
[idpedido] [numeric] (18, 0) NOT NULL,
[fechaentrega] [datetime] NULL,
[fecharealizacion] [datetime] NULL,
[idestado] [int] NULL,
[prioridad] [int] NULL,
[idcliente] [int] NULL,
[idvendedor] [int] NULL,
[idformadeentrega] [int] NULL,
[idempresa] [int] NULL,
[idviajante] [int] NULL,
[fecharealentrega] [datetime] NULL
) ON [PRIMARY]


