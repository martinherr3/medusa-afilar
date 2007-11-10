Imports System.Data.SqlClient

Public Class MaquinaProd

  Private _idMaquina As Integer
  Private _tipo As String
  Private _nombre As String
  'Private _descripcionTipo As String


  'cada maquina devuelve su hora de inicio , 
  'luego en la clase programador se verififca si esta es menos a la hora de inicio seteada por el operador
  'si es asi, la hora de inicio para esa maquina sera la hora de inicio general

  'IDEA II
  'se comienza a partir de la hora de inicio
  'se busca en las tareas pendientes cual puede programarse antes (checkear la disponibilidad de las maquinas para y la hora de cierre)
  '
  '[[ aclaracion importante ]] si al checkear la disponibilidad de una maquina se encuentra q una tarea alcanza el horario de cierre
  'automaticamente se agrega a todas las maquinas una tarea q corresponda a las horas q no se trabajan
  '
  'la mas apropiada segun los criterios antes definidos se programa

  Private _tareas As New Collection

  Public Property idMaquina() As Integer
    Get
      Return _idMaquina
    End Get
    Set(ByVal Value As Integer)
      _idMaquina = Value
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

  Public Property nombre() As String
    Get
      Return _nombre
    End Get
    Set(ByVal Value As String)
      _nombre = Value
    End Set
  End Property

  Public ReadOnly Property tareas()
    Get
      Return _tareas
    End Get
  End Property


  'Public Property descripcionTipo() As String
  '    Get
  '        Return _descripcionTipo
  '    End Get
  '    Set(ByVal Value As String)
  '        _descripcionTipo = Value
  '    End Set
  'End Property

  'falta property para tareas VER

  Public Sub New()
  End Sub


  Public Sub New(ByVal idMaquina As Integer, ByVal tipo As String, ByVal nombre As String)
    _idMaquina = idMaquina
    _tipo = tipo
    _nombre = nombre
  End Sub


  Public Function getById() As Integer
    Dim sqlConn As New SqlConnection(cnn.ConnectionString)
    Dim sql As String

    'sql = "SELECT m.nombre, t.nombre, t.descripcion, " & _
    '      "FROM maquina m" & _
    '        "INNER JOIN  tipomaquina t ON m.tipomaquina = t.nombre" & _
    '      "WHERE idmaquina = " & _idMaquina

    sql = "SELECT * FROM maquina WHERE idmaquina = " & _idMaquina

    Dim adp As New SqlDataAdapter(sql, sqlConn)
    Dim ds As New DataSet

    sqlConn.Open()
    adp.Fill(ds, "maquina")
    _nombre = ds.Tables("maquina").Rows(0).Item("nombre")
    _tipo = ds.Tables("maquina").Rows(0).Item("tipomaquina")

    sqlConn.Close()

  End Function


  Public Function getCustom(ByVal sql As String) As Collection
    Dim sqlConn As New SqlConnection(cnn.ConnectionString)

    Dim adp As New SqlDataAdapter(sql, sqlConn)
    Dim ds As New DataSet
    Dim coll As New Collection

    sqlConn.Open()
    adp.Fill(ds, "maquina")

    Dim maq As New MaquinaProd

    For Each row As DataRow In ds.Tables("maquina").Rows
      coll.Add(New MaquinaProd(row.Item("idmaquina"), row.Item("tipomaquina"), row.Item("nombre")))
    Next

    sqlConn.Close()

    Return coll

  End Function


  Public Function getHoraInicio(ByVal duracion As Integer, ByVal inicio As DateTime) As Integer

  End Function


  Public Function getProximoInicio(ByVal hora As DateTime, ByRef proxInicio As DateTime) As Boolean

    Dim b As Boolean = False
    If _tareas.Count > 0 Then
      For Each tarea As tareasProd In _tareas
        If tarea.inicio > hora Then
          If Not b Or tarea.inicio < proxInicio Then
            b = True
            proxInicio = tarea.inicio
          End If
        End If
      Next
    End If
    Return b
  End Function


  Public Function getProximoFin(ByVal hora As DateTime, ByRef proxFin As DateTime) As Boolean

    Dim b As Boolean = False
    If _tareas.Count > 0 Then
      For Each tarea As tareasProd In _tareas
        If tarea.fin > hora Then
          If Not b Or tarea.fin < proxFin Then
            b = True
            proxFin = tarea.fin
          End If
        End If
      Next
    End If
    Return b
  End Function


  Public Function getProximoDisponible(ByVal horaInicio As DateTime, ByVal duracion As Integer) As DateTime

    Dim proxInicio As DateTime
    Dim proxFin As DateTime

    Dim hayInicio As Boolean
    Dim hayFin As Boolean

    Dim lapsoDisponible As TimeSpan

    Dim b As Boolean = False

    While b = False

      hayFin = Me.getProximoFin(horaInicio, proxFin)
      hayInicio = Me.getProximoInicio(horaInicio, proxInicio)

      If hayInicio Then
        If proxFin <= proxInicio Then
          'Ver lapso disponible (maquina ocupada)
          lapsoDisponible = (proxInicio - proxFin)
          If lapsoDisponible.Minutes >= duracion Then
            Return proxFin
          End If
          Me.getProximoFin(proxInicio, horaInicio)
        Else
          'Ver lapso disponible (maquina libre hasta proxInicio)
          lapsoDisponible = (horaInicio - proxInicio)
          If lapsoDisponible.Minutes >= duracion Then
            Return horaInicio
          End If
          Me.getProximoFin(proxInicio, horaInicio)
        End If
      ElseIf hayFin Then
        'No inicio && si fin ==> Maquina libre a partir de Fin
        Return proxFin
      Else
        'No inicio && No fin ==> Maquina libre
        Return horaInicio
      End If

    End While


  End Function

  Public Function programarTarea(ByVal tarea As tareasProd) As Integer
    _tareas.Add(tarea)
  End Function


End Class
