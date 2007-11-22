Public Class Constantes

    'Contantes para buscar valores de la tabla app_param
    Public Const APP_PARAM_HORA_HOMBRE_OPERARIO As String = "Hora/Hombre Operario"
    Public Const APP_PARAM_GANANCIA As String = "Ganancia"

    'String que se guarda en modelo de fresa
    Public Const MODELO_FRESA_ESTADO_BAJA As String = "Baja"
    Public Const MODELO_FRESA_ESTADO_ALTA As String = "Alta"

    'Campo tipo de Emitir presupuesto
    Public Const PRESUPUESTO_TIPO_FRESA As Integer = 1
    Public Const PRESUPUESTO_PARTE_ADICIONAL As Integer = 2
    Public Const PEDIDO_PRESUPUESTO_TIEMPO As Integer = 1

    'setea el inicio de las coordenadas X e Y de los formularios, las que heredan
    'de frmBase
    Private _InicioX As Integer = 200
    Private _InicioY As Integer = 105

    'Este es el id de la operacion torneado para lo que se nescesite
    Private _OperacionTorneado As Integer = 699

    'este es el id del cargo de los operarios para el filtro de empleados del frmsegprod
    Private _CargoOperario As Integer = 1


    Public ReadOnly Property InicioX() As Integer
        Get
            InicioX = _InicioX
        End Get
    End Property


    Public ReadOnly Property InicioY() As Integer
        Get
            InicioY = _InicioY
        End Get
    End Property

    Public ReadOnly Property OperacionTorneado() As Integer
        Get
            OperacionTorneado = _OperacionTorneado
        End Get
    End Property

    Public ReadOnly Property CargoOperario() As Integer
        Get
            CargoOperario = _CargoOperario
        End Get
    End Property
End Class
