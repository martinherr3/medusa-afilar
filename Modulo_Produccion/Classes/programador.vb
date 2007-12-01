Public Class programador


  Private _tareas As Collection
  'coleccion de tareas por programar, a medida q se programan salen de la coleccion
  Private _maquinas As Collection
  'coleccion de maquinas, a medida q se programan tareas se van asignando a las maquinas correspondientes
  Private _horarioCierre(6, 1) As Integer

  Private _horaInicioGeneral As DateTime = Date.Now
  'es la hora a partir de la cual van a comenzar a programarse las tareas
  Private _fresas As Collection
  'array de fresas a programar

  Private _cierres As New Collection
  'coleccion de tareas 'CIERRE'



  Public Sub New()
    setHorarios()
  End Sub

  Public Property tareas() As Collection
    Get
      Return _tareas
    End Get
    Set(ByVal value As Collection)
      _tareas = value
    End Set
  End Property

  Public Property maquinas() As Collection
    Get
      Return _maquinas
    End Get
    Set(ByVal value As Collection)
      _maquinas = value
    End Set
  End Property

  Public Property horaInicioGeneral() As DateTime
    Get
      Return _horaInicioGeneral
    End Get
    Set(ByVal value As DateTime)
      _horaInicioGeneral = value
    End Set
  End Property

  Public Property fresas() As Collection
    Get
      Return _fresas
    End Get
    Set(ByVal value As Collection)
      _fresas = value
    End Set
  End Property


  'Public Function estaCerrado(ByVal hora As DateTime) As Boolean ' TRUE = CERRADO
  'Dim dia As Integer = hora.DayOfWeek
  'Dim minutos As Decimal = hora.TimeOfDay.TotalMinutes
  '
  '    If _horarioCierre(dia, 0) = _horarioCierre(dia, 1) Then
  'Return True
  'Else
  'If _horarioCierre(dia, 0) > minutos Or _horarioCierre(dia, 1) < minutos Then
  'Return True
  'End If
  'End If
  '
  '    Return False

  '  For Each tar As tareasProd In _tareasCierre
  '   If tar.inicio.DayOfWeek = hora.DayOfWeek Then
  '    If hora > tar.inicio And hora < tar.inicio.AddMinutes(tar.duracion) Then
  '     Return True
  '   End If
  ' End If
  'Next


  'End Function

  'Public Function checkHorarioCierre(ByVal hora As DateTime, ByVal duracion As Integer) As Boolean
  ''checkea q ni el inicio ni el find de la tarea caiga en un horario de cierre
  '
  '   If (estaCerrado(hora) Or estaCerrado(hora.AddMinutes(duracion))) Then
  ''si encontro horario de cierre prograsmar tarea "cerrado" para todas las maquinas
  '    For i As Integer = 1 To _maquinas.Count
  'Dim tar As New tareasProd
  '      tar.idFresa = -1
  '      tar.nombre = "CERRADO"
  '      tar.inicio = hora.Date.AddMinutes(_horarioCierre(hora.DayOfWeek, 1))
  '      If (hora.DayOfWeek = 5) Then ''o sea si es viernes... programar la tarea "cerrado" para todo el finde
  '        tar.duracion = 3720
  '      Else
  '        tar.duracion = 840
  '      End If
  '
  '
  '       _maquinas.Item(i).programarTarea(tar)
  '    Next
  '   Return True
  'End If
  'Return False
  '
  ' End Function

  Private Sub setHorarios()
    '_horarioCierre(0, 0) = 0     'domingo inicio
    '_horarioCierre(0, 1) = 0     'domingo fin
    '_horarioCierre(1, 0) = 480   'lunes inicio
    '_horarioCierre(1, 1) = 1080  'lunes fin
    '_horarioCierre(2, 0) = 480   'martes inicio
    '_horarioCierre(2, 1) = 1080  'martes fin
    '_horarioCierre(3, 0) = 480   'miercoles inicio
    '_horarioCierre(3, 1) = 1080  'miercoles fin
    '_horarioCierre(4, 0) = 480   'jueves inicio
    '_horarioCierre(4, 1) = 1080  'jueves fin
    '_horarioCierre(5, 0) = 480   'viernes inicio
    '_horarioCierre(5, 1) = 1080  'viernes fin
    '_horarioCierre(6, 0) = 0     'sabado inicio
    '_horarioCierre(6, 1) = 0     'sabado fin


    ''Para las tareas CIERRE usamos ORDEN como dia de la semana
    'For i As Integer = 1 To 4 'dias de la semana
    '_tareasCierre.Add(New tareasProd(-1, 0, "Cierre", "", 720, i, "Cierre"))
    'Next
    '_tareasCierre.Add(New tareasProd(-1, 0, "Cierre", "", 3600, 5, "Cierre"))

    '--------------------------------------------------

    Dim a As New cierre(0, 1440)
    Dim b As New cierre(1440, 480)
    Dim c As New cierre(2640, 720)
    Dim d As New cierre(4080, 720)
    Dim e As New cierre(5520, 720)
    Dim f As New cierre(6960, 720)
    Dim g As New cierre(7200, 240)
    Dim h As New cierre(8640, 1440)

    _cierres.Add(a)
    _cierres.Add(b)
    _cierres.Add(c)
    _cierres.Add(d)
    _cierres.Add(e)
    _cierres.Add(f)
    _cierres.Add(g)
    _cierres.Add(h)



  End Sub

  Private Function getMaquinaByType(ByVal tipo As String) As Collection
    Dim collection As New Collection
    For Each maquina As MaquinaProd In _maquinas
      If maquina.tipo.Trim.ToLower = tipo.Trim.ToLower Then
        Debug.WriteLine("ID Maquina Encontrada: " & maquina.idMaquina)
        collection.Add(maquina)
      End If
    Next
    Return collection
  End Function

  Private Function programarTarea(ByVal tarea As tareasProd) As Boolean

    For i As Integer = 1 To _maquinas.Count
      If _maquinas.Item(i).idMaquina = tarea.maquinaAUsar Then
        tarea.fin = Date.Now
        tarea.fin = tarea.inicio.AddMinutes(tarea.duracion) 'conviene aca esto???
        Debug.WriteLine("----PROGRAMADA----")
        Debug.WriteLine("Maquina: " & _maquinas.Item(i).idMaquina & " - " & _maquinas.Item(i).tipo)
        Debug.WriteLine("-->> Hora Fin: " & tarea.fin)
        Debug.WriteLine("Hora Inicio:   " & tarea.inicio)
        _maquinas.Item(i).programarTarea(tarea)
      End If
    Next

    For i As Integer = 1 To _fresas.Count
      If _fresas.Item(i).id_fresa = tarea.idFresa Then
        _fresas.Item(i).avanzarOperacion()
        Debug.WriteLine("id Fresa Programada: " & _fresas.Item(i).id_fresa)
        Debug.WriteLine("# Operacion: " & _fresas.Item(i).lastOperacion)
      End If

    Next

    For i As Integer = 1 To _tareas.Count
      If tarea.idFresa = _tareas.Item(i).idFresa And tarea.orden = _tareas.Item(i).orden Then
        _tareas.Remove(i)
        Return True
      End If
    Next
    Return False
  End Function

  Private Function buscarProgramables() As Collection
    Dim coll As New Collection
    For Each fresa As fresaProd In _fresas
      For Each tarea As tareasProd In _tareas
        If tarea.idFresa = fresa.id_fresa And tarea.orden = fresa.lastOperacion + 1 Then
          coll.Add(tarea)
        End If
      Next
    Next
    Return coll
  End Function

  Private Function getUltimoFin(ByVal tarea As tareasProd) As DateTime

    For Each maq As MaquinaProd In _maquinas
      For Each tar As tareasProd In maq.tareas
        If tar.idFresa = tarea.idFresa And tar.orden = tarea.orden - 1 Then
          Return tar.fin
        End If
      Next
    Next

  End Function







    Public Function Programar() As Boolean

        Dim deb As Boolean = True

        Dim maquinasTipo As Collection
        'NOTA: para hacer mas facil, los horarios de cierre se setearan antes de aomenzar a programar, 
        'digamos se setearan para el proximo siglo...
        Dim tareasProgramables As Collection

        Dim proxDisponible As DateTime

        '_horaInicioGeneral = Date.Now

        'recorrer las tareas hasta q no queden mas
        'For Each tarea As tareasProd In _tareas
        While _tareas.Count

            Debug.WriteLine("---------> # tareas: " & _tareas.Count)

            'buscar las programables
            tareasProgramables = buscarProgramables()
            If tareasProgramables.Count = 0 Then
                MsgBox("ERROR: tareas programables")
                Return False
            End If


            'For Each tarea As tareasProd In tareasProgramables

            For i As Integer = 1 To tareasProgramables.Count

                'por cada una buscar su hora de inicio posible
                'para eso:
                'obtener la/s maquina/s en donde podria realizarse la tarea

                Debug.WriteLine("Tipo maquina necesaria: " & tareasProgramables.Item(i).idMaquina)

                maquinasTipo = Me.getMaquinaByType(tareasProgramables.Item(i).idMaquina)
                If maquinasTipo.Count = 0 Then
                    MsgBox("ERROR: No hay maquinas del tipo necesario")
                    Exit Function
                End If

                Dim menor As DateTime
                Dim b As Boolean = False
                'Dim maqSelected As MaquinaProd

                Dim horaInicio As DateTime = _horaInicioGeneral

                '
                'HORA INICIO
                ' La hora de inicio debe ser igual o mayor a la hora de fin de la tarea de orden anterior

                If tareasProgramables.Item(i).orden > 1 Then
                    tareasProgramables.Item(i).inicio = getUltimoFin(tareasProgramables.Item(i))
                    horaInicio = tareasProgramables.Item(i).inicio '' esto deberia ir solo en el atrib inicio y modificar getproxdiponible...
                    Debug.WriteLine("Ultimo fin: " & tareasProgramables.Item(i).inicio & " - Fresa: " & tareasProgramables.Item(i).idFresa)
                End If


                '
                'por cada tarea q se programa registrar el idFresa, la hora fin de tarea y el orden
                'para saber su hora de inicio
                ' 

                'por cada maquina del tipo buscar la de menor hora de inicio y usar esa maquina
                For Each maq As MaquinaProd In maquinasTipo

                    Do
                        proxDisponible = maq.getProximoDisponible(horaInicio, tareasProgramables.Item(i).duracion)
                        'Loop While (Not Me.checkHorarioCierre(proxDisponible, tareasProgramables.Item(i).duracion))
                    Loop While (checkearCierre(proxDisponible.AddMinutes(tareasProgramables.Item(i).duracion)))


                    If Not b Or proxDisponible < menor Then
                        ''Debug.WriteLine("Hora Inicio: " & horaInicio)
                        menor = maq.getProximoDisponible(horaInicio, tareasProgramables.Item(i).duracion)
                        tareasProgramables.Item(i).maquinaAUsar = maq.idMaquina
                        tareasProgramables.Item(i).inicio = menor
                        b = True
                    End If
                Next

                'ahora tenemos la maquina a donde se programara la tarea
                'y la hora de inicio

            Next

            'buscamos la de menor inicio de todas las programables
            'A HACER --> si hay mas de una con inicio menor, programar la menor
            Dim aProgramar As tareasProd
            Dim ba As Boolean = False
            For Each tarea As tareasProd In tareasProgramables
                If Not ba Then
                    aProgramar = tarea
                    ba = True
                ElseIf aProgramar.inicio > tarea.inicio Then
                    aProgramar = tarea
                End If
            Next

            'ahora programar esa tarea
            If Not programarTarea(aProgramar) Then
                'si hubo un error
                MsgBox("ERROR al programar la tarea")
            End If

            'Next
        End While

        Return True
    End Function

  '----- Manejo del horario de Cierre -----

  Private Function checkearCierre(ByVal hora As DateTime) As Boolean

    Dim DOW As Integer
    Dim minutosDia As Integer
    Dim min As Integer ' minutos de la semana corresp al parametro hora

    min = (hora.DayOfWeek * 1440) + (hora.Hour * 60) + hora.Minute


    For Each cie As cierre In _cierres
      If cie.inicio < min And min < (cie.inicio + cie.duracion) Then
        'esta cerrado

        DOW = [Decimal].Truncate(cie.inicio / 1440)
        minutosDia = cie.inicio Mod 1440

        ''ahora calcular el datetime para programar la tareaCierre
        Dim fechaAProg As DateTime
        If (hora.DayOfWeek = DOW) Then
          'fecha a prog es hora.date
          fechaAProg = hora.Date
        Else
          'fecha a prog es hora.date - 1 dia
          fechaAProg = hora.Date.AddDays(-1)
        End If

        'esta es la fecha a programar el cierre
        fechaAProg = fechaAProg.AddMinutes(minutosDia)
        Dim tar As New tareasProd
        tar.inicio = fechaAProg
        tar.duracion = cie.duracion
        tar.fin = tar.inicio.AddMinutes(cie.duracion)
        tar.nombre = "CIERRE"
        tar.idFresa = -1

        For Each maq As MaquinaProd In _maquinas
          maq.programarTarea(tar)
        Next

        Return True

      End If
    Next

    Return False

  End Function

  Public Function guardarProgramacion() As Boolean
    Dim constante As New Constantes
    Dim commd As New SqlClient.SqlCommand
    Dim orden As Integer = 1
    Dim i As Boolean
    Dim allTasksCollection As New Collection
    Dim idHR As Integer
    Dim DS As DataSet
    Dim idTorneado As Integer


    For Each maq As MaquinaProd In _maquinas
      For Each tar As tareasProd In maq.tareas
        tar.idMaquina = maq.idMaquina
        allTasksCollection.Add(tar)
      Next
    Next
    cnn.Open()

    commd.Connection = cnn

    For Each fre As fresaProd In _fresas

      commd.CommandText = "SELECT max(idhojaderuta) FROM hojaderuta"
      If IsDBNull(commd.ExecuteScalar()) Then
        idHR = 1
      Else
        idHR = commd.ExecuteScalar() + 1
      End If

      ''traer el ds con las materiasa primas a usar por fresa
      DS = getDSMateriaPartes(fre.id_fresa)
      For Each row As DataRow In DS.Tables.Item(0).Rows

        'idtipomateriaprima, cantidad, nroserie
        commd.CommandText = "UPDATE tipomateriaprima SET stockactual = stockactual - " & row.Item(1) & " WHERE idtipomateriaprima = " & row.Item(0)
        commd.ExecuteNonQuery()

      Next
      commd.CommandText = "INSERT INTO hojaderuta (idhojaderuta) VALUES (" & idHR & ")"
      commd.ExecuteNonQuery()

      commd.CommandText = "SELECT max(idhojaderuta) FROM hojaderuta"
      idHR = commd.ExecuteScalar()

      commd.CommandText = "UPDATE fresa SET idhojaderuta = " & idHR & ", estado = 2 WHERE nroserie = " & fre.id_fresa
      commd.ExecuteNonQuery()
      orden = 1
      Do
        i = False
        For Each tar As tareasProd In allTasksCollection
          If tar.idFresa = fre.id_fresa And tar.orden = orden Then

            If tar.idEtapa = constante.OperacionTorneado Then

              commd.CommandText = "SELECT max(idtorneado) FROM torneado"
              If IsDBNull(commd.ExecuteScalar()) Then
                idTorneado = 1
              Else
                idTorneado = commd.ExecuteScalar() + 1
              End If
              commd.CommandText = "INSERT INTO torneado (idtorneado) VALUES (" & idTorneado & ")"
              commd.ExecuteNonQuery()
              commd.CommandText = "INSERT INTO detallehojaderuta (idhojaderuta, idetapadefabricacion, idtorneado, fechahorainicioplanificada, fechahorafinplanificada, idmaquina) " & _
                                  "VALUES (" & idHR & ", " & tar.idEtapa & ", " & idTorneado & ", '" & tar.inicio.ToString("s") & "', '" & tar.fin.ToString("s") & "', " & tar.idMaquina & " )"
            Else
              commd.CommandText = "INSERT INTO detallehojaderuta (idhojaderuta, idetapadefabricacion, fechahorainicioplanificada, fechahorafinplanificada, idmaquina) " & _
                                  "VALUES (" & idHR & ", " & tar.idEtapa & ", '" & tar.inicio.ToString("s") & "', '" & tar.fin.ToString("s") & "', " & tar.idMaquina & " )"
            End If
            commd.ExecuteNonQuery()
            orden += 1
            i = True
          End If
        Next
      Loop While (i)
    Next
    cnn.Close()

  End Function

  Public Function getDSMateriaPartes(ByVal nroSerie As Integer) As DataSet

    Dim Sql As String
    'Sql = "SELECT * FROM parte WHERE idmodelo = ** AND idtipofresa = "
    Sql = "SELECT p.idtipomateriaprima, p.cantidad, f.nroserie FROM parte p, fresa f WHERE f.idtipo = p.idtipofresa AND f.idmodelo = p.idmodelo " & _
      "AND f.nroserie = " & nroSerie

    Dim comm As New SqlClient.SqlCommand(Sql, cnn)
    Dim DA As New SqlClient.SqlDataAdapter(comm)

    Dim DS As New DataSet
    DA.Fill(DS, "partes")

    Return DS
  End Function

  '--- cargar programacion guardada ---
  Public Function cargarProgramacion() As Integer
    Dim DS As New DataSet
    Dim sql As String

    sql = "SELECT idhojaderuta, idetapadefabricacion, fechahorainicioplanificada, fechahorafinplanificada, idmaquina " & _
          "FROM detallehojaderuta " & _
          "WHERE fechahorafinplanificada > '" & _horaInicioGeneral.ToString("s") & "'"

    Dim comm As New SqlClient.SqlCommand(sql, cnn)
    Dim DA As New SqlClient.SqlDataAdapter(comm)

    DA.Fill(DS, "planificados")

    Dim tar As tareasProd
    For Each DR As DataRow In DS.Tables.Item(0).Rows
      ' por cada row crear el objeto tarea y asignarlo a la maquina correspondiente
      tar = New tareasProd
      tar.inicio = DR("fechahorainicioplanificada")
      tar.fin = DR("fechahorafinplanificada")
      tar.idEtapa = DR("idetapadefabricacion")
      tar.idFresa = -2 'idFresa = -2 --> tarea ya programada y guardada (idFresa = -1 --> tarea cierre)

      For Each maq As MaquinaProd In _maquinas
        If maq.idMaquina = DR("idmaquina") Then
          maq.programarTarea(tar)
          Exit For
        End If
      Next

    Next
    ''ver tema de los colores para las tareas cargadas de la BD
  End Function
End Class


'esto queda feo. Ver si conviene hacer una clase y ponerla en otro archivo...
Public Structure fresaProd
  Public id_fresa As Integer
  Public lastOperacion As Integer
  Public horaFin As DateTime
  Public colorGrafico As Color 'color de la fresa en el grafico


  Public Sub avanzarOperacion()
    lastOperacion += 1
  End Sub
End Structure


