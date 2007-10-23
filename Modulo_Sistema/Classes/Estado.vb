Public Enum Estado

    'Estados para clase PEDIDO
    PEDIDO_PENDIENTE = 1
    PEDIDO_PROGRAMADO = 2
    PEDIDO_EN_PRODUCCION = 3
    PEDIDO_FINALIZADO = 4
    PEDIDO_ENTREGADO = 5
    PEDIDO_CANCELADO = 6

    'Estados para clase ORDEN DE COMPRA
    ORDEN_DE_COMPRA_PENDIENTE = 11
    ORDEN_DE_COMPRA_RECIBIDO = 12
    ORDEN_DE_COMPRA_RECHAZADO = 13
    ORDEN_DE_COMPRA_PARCIALMENTE_ENTREGADO = 14

    'Estados para clase FRESA
    FRESA_PENDIENTE = 21
    FRESA_PARA_TORNEAR = 22
    FRESA_TORNEANDO = 23
    FRESA_FABRICANDO = 24
    FRESA_FINALIZADO = 25
    FRESA_RECHAZADA = 26

    'Estados para clase MAQUINA
    MAQUINA_OPERANDO = 31
    MAQUINA_REPARANDOSE = 32
    MAQUINA_DE_BAJA = 33

    'Estados para clase ORDEN DE SERVICIO
    ORDEN_DE_SERVICIO_PENDIENTE = 41
    ORDEN_DE_SERVICIO_EJECUTANDO = 41
    ORDEN_DE_SERVICIO_FINALIZADO = 41

    'Estados para clase HOJA DE RUTA
    HOJA_DE_RUTA_CREADA = 51
    HOJA_DE_RUTA_EMITIDA = 52
    HOJA_DE_RUTA_REGISTRADA = 53

End Enum




