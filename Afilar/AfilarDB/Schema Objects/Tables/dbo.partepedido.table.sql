CREATE TABLE [dbo].[partepedido]
(
[idpedido] [numeric] (18, 0) NOT NULL,
[idpartepedida] [int] NOT NULL,
[idmodelo] [int] NULL,
[idadicional] [int] NULL,
[cantidad] [int] NULL,
[precio] [decimal] (18, 0) NULL
) ON [PRIMARY]


