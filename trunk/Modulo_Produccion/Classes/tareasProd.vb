Imports System.Data.SqlClient

Public Class tareasProd

    Private _idFresa As Integer
    Private _idOperacion As Integer
  Private _idEtapa As Integer
  Private _nombre As String
  Private _idMaquina As String
  Private _duracion As String
  Private _orden As Integer
  Private _tipo As String 'fabric o servicio

  Private _maquinaAUsar As Integer 'esto es medio negro pero bue...

  Private _inicio As DateTime
  Private _fin As DateTime



  Public Sub New()
  End Sub

    Public Sub New(ByVal idFresa As Integer, ByVal idEtapa As Integer, ByVal nombre As String, ByVal idMaquina As String, ByVal duracion As String, ByVal orden As Integer, ByVal tipo As String, ByVal idoperacion As Integer)
        _idFresa = idFresa
        _idOperacion = idOperacion
        _idEtapa = idEtapa
        _nombre = nombre
        _idMaquina = idMaquina
        _duracion = duracion
        _orden = orden
        _tipo = tipo
    End Sub

  Public Property idFresa() As Integer
    Get
      Return _idFresa
    End Get
    Set(ByVal Value As Integer)
      _idFresa = Value
    End Set
    End Property

    Public Property idOperacion() As Integer
        Get
            Return _idOperacion
        End Get
        Set(ByVal Value As Integer)
            _idOperacion = Value
        End Set
    End Property

  Public Property idEtapa() As Integer
    Get
      Return _idEtapa
    End Get
    Set(ByVal Value As Integer)
      _idEtapa = Value
    End Set
  End Property

  Public Property nombre() As String
    Get
      Return _nombre
    End Get
    Set(ByVal Value As String)
      _nombre = Value
    End Set
  End Property

  Public Property idMaquina() As String
    Get
      Return _idMaquina
    End Get
    Set(ByVal Value As String)
      _idMaquina = Value
    End Set
  End Property

  Public Property duracion() As String
    Get
      Return _duracion
    End Get
    Set(ByVal Value As String)
      _duracion = Value
    End Set
  End Property

  Public Property orden() As Integer
    Get
      Return _orden
    End Get
    Set(ByVal Value As Integer)
      _orden = Value
    End Set
  End Property

  Public Property tipo() As String
    Get
      Return _tipo
    End Get
    Set(ByVal Value As String)
      _tipo = Value
    End Set
  End Property

  Public Property inicio() As DateTime
    Get
      Return _inicio
    End Get
    Set(ByVal value As DateTime)
      _inicio = value
    End Set
  End Property

  Public Property fin() As DateTime
    Get
      Return _fin
    End Get
    Set(ByVal value As DateTime)
      _fin = value
    End Set
  End Property

  Public Property maquinaAUsar() As Integer
    Get
      Return _maquinaAUsar
    End Get
    Set(ByVal value As Integer)
      _maquinaAUsar = value
    End Set
  End Property

  Public Function getDSByIdfresa() As DataSet

    Dim sqlConn As New SqlConnection(cnn.ConnectionString)
    Dim sql As String
    Dim coll As New Collection

        sql = "SELECT f.nroserie, e.idetapafabricacion, o.maquina, o.nombre, o.duracionpromedio, e.orden, e.idoperacion " & _
          "FROM etapadefabricacion e " & _
          "  INNER JOIN operacion o ON e.idoperacion = o.idoperacion " & _
          "  INNER JOIN fresa f ON f.idtipo = e.idtipofresa AND f.idmodelo = e.idmodelo " & _
          "WHERE f.nroserie = " & _idFresa

    Dim adp As New SqlDataAdapter(sql, sqlConn)
    Dim ds As New DataSet

    sqlConn.Open()
    adp.Fill(ds, "operacion")

    'For Each row As DataRow In ds.Tables("operacion").Rows
    '   coll.Add(New tareasProd(row.Item("nroserie"), row.Item("idetapafabricacion"), row.Item("nombre"), row.Item("maquina"), row.Item("duracionpromedio"), row.Item("orden"), "fresa")) 'Por ahora son todos del tipo fresa
    'Next

    sqlConn.Close()

    Return ds

    End Function

  Public Function getDSByTipo(ByVal idTipo As Integer, ByVal idModelo As Integer, ByVal nroSerie As String) As DataSet
    Dim sqlConn As New SqlConnection(cnn.ConnectionString)
    Dim sql As String
    Dim coll As New Collection

        sql = "SELECT " & nroSerie & " as nroserie, e.idetapafabricacion, o.maquina, o.nombre, o.duracionpromedio, e.orden, e.idoperacion " & _
          "FROM etapadefabricacion e " & _
          "  INNER JOIN operacion o ON e.idoperacion = o.idoperacion " & _
          "WHERE e.idtipofresa = " & idTipo & " AND e.idmodelo = " & idModelo

    Dim adp As New SqlDataAdapter(sql, sqlConn)
    Dim ds As New DataSet
    sqlConn.Open()
    adp.Fill(ds, "operacion")
    sqlConn.Close()
    Return ds
    End Function

End Class
