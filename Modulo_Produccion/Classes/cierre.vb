Public Class cierre

  Private _inicio As Integer ' en minutos desde el inicio del dia
  Private _duracion As Integer


  Public Property inicio() As Integer
    Get
      Return _inicio
    End Get
    Set(ByVal value As Integer)
      _inicio = value
    End Set
  End Property

  Public Property duracion() As Integer
    Get
      Return _duracion
    End Get
    Set(ByVal value As Integer)
      _duracion = value
    End Set
  End Property

  Public Sub New(ByVal inicio As Integer, ByVal duracion As Integer)
    _inicio = inicio
    _duracion = duracion
  End Sub

End Class
