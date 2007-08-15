Public Class ParametrosCompras
    Private _StockActual As Integer
    Private _StockSeguridad As Integer
    Private _StockMinimo As Integer
    Private _LoteEconomico As Integer

    Public Property StockActual() As Integer
        Get
            Return _StockActual
        End Get
        Set(ByVal value As Integer)
            _StockActual = value
        End Set
    End Property

    Public Property StockMinimo() As Integer
        Get
            Return _StockMinimo
        End Get
        Set(ByVal value As Integer)
            _StockMinimo = value
        End Set
    End Property

    Public Property StockSeguridad() As Integer
        Get
            Return _StockSeguridad
        End Get
        Set(ByVal value As Integer)
            _StockSeguridad = value
        End Set
    End Property

    Public Property LoteEconomico() As Integer
        Get
            Return _LoteEconomico
        End Get
        Set(ByVal value As Integer)
            _LoteEconomico = value
        End Set
    End Property

    Public Function ObtenerLote() As String

        Return "hhh"

    End Function

End Class
