Public Class Constantes

    Public Const HORA_HOMBRE_OPERARIO As String = "Hora/Hombre Operario"
    Public Const MODELO_FRESA_ESTADO_BAJA As String = "Baja"
    Public Const MODELO_FRESA_ESTADO_ALTA As String = "Alta"

    'setea el inicio de las coordenadas X e Y de los formularios, las que heredan
    'de frmBase
    Private _InicioX As Integer = 200
    Private _InicioY As Integer = 105


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

End Class