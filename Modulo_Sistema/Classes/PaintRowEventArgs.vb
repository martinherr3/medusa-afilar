Public Class PaintRowEventArgs
    Inherits EventArgs

    Private _rowNum As Integer
    Private _backColor As Brush
    Private _foreColor As Brush

    Public Property RowNumber() As Integer
        Get
            Return _rowNum
        End Get
        Set(ByVal Value As Integer)
            _rowNum = Value
        End Set
    End Property

    Public Property BackColor() As Brush
        Get
            Return _backColor
        End Get
        Set(ByVal Value As Brush)
            _backColor = Value
        End Set
    End Property

    Public Property ForeColor() As Brush
        Get
            Return _foreColor
        End Get
        Set(ByVal Value As Brush)
            _foreColor = Value
        End Set
    End Property
End Class
