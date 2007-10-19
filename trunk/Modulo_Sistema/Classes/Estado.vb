Public Class Estado

    'Estados para clase PEDIDO
    Public Const PEDIDO_PENDIENTE As Integer = 1
    Public Const PEDIDO_PROGRAMADO As Integer = 2
    Public Const PEDIDO_EN_PRODUCCION As Integer = 3
    Public Const PEDIDO_FINALIZADO As Integer = 4
    Public Const PEDIDO_ENTREGADO As Integer = 5
    Public Const PEDIDO_CANCELADO As Integer = 6

    'Estados para clase ORDEN DE COMPRA
    Public Const ORDEN_DE_COMPRA_PENDIENTE As Integer = 11
    Public Const ORDEN_DE_COMPRA_RECIBIDO As Integer = 12
    Public Const ORDEN_DE_COMPRA_RECHAZADO As Integer = 13
    Public Const ORDEN_DE_COMPRA_PARCIALMENTE_ENTREGADO As Integer = 14

    'Estados para clase FRESA
    Public Const FRESA_PENDIENTE As Integer = 21
    Public Const FRESA_PARA_TORNEAR As Integer = 22
    Public Const FRESA_TORNEANDO As Integer = 23
    Public Const FRESA_FABRICANDO As Integer = 24
    Public Const FRESA_FINALIZADO As Integer = 25
    Public Const FRESA_RECHAZADA As Integer = 26

    'Estados para clase MAQUINA
    Public Const MAQUINA_OPERANDO As Integer = 31
    Public Const MAQUINA_REPARANDOSE As Integer = 32
    Public Const MAQUINA_DE_BAJA As Integer = 33

    'Estados para clase ORDEN DE SERVICIO
    Public Const ORDEN_DE_SERVICIO_PENDIENTE As Integer = 41
    Public Const ORDEN_DE_SERVICIO_EJECUTANDO As Integer = 41
    Public Const ORDEN_DE_SERVICIO_FINALIZADO As Integer = 41

    'Estados para clase HOJA DE RUTA
    Public Const HOJA_DE_RUTA_CREADA As Integer = 51
    Public Const HOJA_DE_RUTA_EMITIDA As Integer = 52
    Public Const HOJA_DE_RUTA_REGISTRADA As Integer = 53


End Class
