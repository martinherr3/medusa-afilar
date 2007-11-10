Public Class BarInformation

    Private _rowText As String
    Private _fromTime As Date
    Private _toTime As Date
    Private _color As Color
    Private _hoverColor As Color
  Private _index As Integer
  Private _nroFresa As String

    Public Property RowText() As String
        Get
            Return _rowText
        End Get
        Set(ByVal value As String)
            _rowText = value
        End Set
    End Property

    Public Property FromTime() As Date
        Get
            Return _fromTime
        End Get
        Set(ByVal value As Date)
            _fromTime = value
        End Set
    End Property

    Public Property ToTime() As Date
        Get
            Return _toTime
        End Get
        Set(ByVal value As Date)
            _toTime = value
        End Set
    End Property

    Public Property Color() As Color
        Get
            Return _color
        End Get
        Set(ByVal value As Color)
            _color = value
        End Set
    End Property

    Public Property HoverColor() As Color
        Get
            Return _hoverColor
        End Get
        Set(ByVal value As Color)
            _hoverColor = value
        End Set
    End Property

    Public Property Index() As Integer
        Get
            Return _index
        End Get
        Set(ByVal value As Integer)
            _index = value
        End Set
  End Property

  Public Property nroFresa() As String
    Get
      Return _nroFresa
    End Get
    Set(ByVal value As String)
      _nroFresa = value
    End Set
  End Property

  Public Sub New(ByVal rowText As String, ByVal fromTime As Date, ByVal totime As Date, ByVal color As Color, ByVal hoverColor As Color, ByVal index As Integer, ByVal nroFresa As String)
    Me.RowText = rowText
    Me.FromTime = fromTime
    Me.ToTime = totime
    Me.Color = color
    Me.HoverColor = hoverColor
    Me.Index = index
    Me.nroFresa = nroFresa
  End Sub

End Class