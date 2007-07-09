Public Class ProgramacionProduccion
    Private coleccion As New TareasCollection
    Private colMarcados As New TareasCollection
    Private maqColeccion As New maquinasColeccion

    Dim max, min As Integer


    Public Sub New(ByVal cTareas As TareasCollection, ByVal cMaquinas As maquinasColeccion)

        coleccion = cTareas
        maqColeccion = cMaquinas

        Dim en As System.Collections.IEnumerator = coleccion.GetEnumerator

        en.MoveNext()
        max = en.Current.orden
        min = en.Current.orden

        While en.MoveNext()
            If en.Current.orden > max Then
                max = en.Current.orden
            ElseIf en.Current.orden < min Then
                min = en.Current.orden
            End If
        End While

    End Sub



    Public Function programar() As maquinasColeccion



        Dim k As Integer
        Dim j As Integer

        Dim etapa As Integer = 0 'no estan al pedo estos tres
        Dim i As tareas
        Dim n As Integer = 0 'cuenta la etapa de fabricacion (orden)


        For j = min To max 'recorrer todo una vez por cada etapa p/ej 3

            Dim h As Integer = 0
            For k = 0 To colMarcados.Count - 1
                'While colMarcados.Count > 0

                i = colMarcados.Item(h)

                If i.tiempo > -1 Then
                    Dim maq As Integer
                    maq = maqColeccion.buscarMaq(i.id_maquina) 'busca una maquina con ese id
                    If maq > -1 Then
                        If maqColeccion.tiempoFin(maq) >= maqColeccion.tiempoFinTarea(i.id_producto, i.orden - 1) And maqColeccion.tiempoFinTarea(i.id_producto, i.orden - 1) > -1 Then
                            i.inicio = maqColeccion.tiempoFin(maq)
                            maqColeccion.agregarTarea(maq, i)  'agrega la tarea i a esa maquina

                            colMarcados.RemoveAt(h)
                            h -= 1

                            'Else                     'para no dejar tiempo muerto
                            'i.enEspera = True
                            'colMarcados.add(i)    ' la volvemos a la coleccion con una marca   
                        End If
                    End If
                End If
                h += 1
                'End While
            Next




            For k = 0 To coleccion.Count - 1
                i = coleccion.Menor(j)  'devuelve la tarea de menor tiempo de los que tengan ESE ORDEN O MENOR
                'si no hay mas con ese orden devuelve una con TIEMPO -1
                If i.tiempo > -1 Then ' para todos las tareas con oreden menor o igua a j
                    Dim maq As Integer
                    maq = maqColeccion.buscarMaq(i.id_maquina) 'busca una maquina con ese id
                    If maq > -1 Then
                        'i.inicio = maqColeccion.tiempoFin(maq)
                        If maqColeccion.tiempoFin(maq) >= maqColeccion.tiempoFinTarea(i.id_producto, i.orden - 1) And maqColeccion.tiempoFinTarea(i.id_producto, i.orden - 1) > -1 Or maqColeccion.tiempoFin(maq) >= maqColeccion.tiempoFinTarea(i.id_producto, i.orden - 1) And i.orden = min Then
                            i.inicio = maqColeccion.tiempoFin(maq)
                            maqColeccion.agregarTarea(maq, i)  'agrega la tarea i a esa maquina
                        Else                     'para no dejar tiempo muerto
                            'i.enEspera = True
                            colMarcados.add(i)    ' la volvemos a la coleccion con una marca   
                        End If
                    End If
                End If
            Next
        Next


        For j = min To max
            For k = 0 To colMarcados.Count - 1
                'While colMarcados.Count > 0
                i = colMarcados.menorInicio(j)
                If i.tiempo > -1 Then
                    Dim maq As Integer
                    maq = maqColeccion.buscarMaq(i.id_maquina) 'busca una maquina con ese id
                    If maq > -1 Then

                        If maqColeccion.tiempoFinTarea(i.id_producto, i.orden - 1) >= maqColeccion.tiempoFin(maq) Then
                            i.inicio = maqColeccion.tiempoFinTarea(i.id_producto, i.orden - 1)
                        Else
                            i.inicio = maqColeccion.tiempoFin(maq)
                        End If

                        maqColeccion.agregarTarea(maq, i)
                    End If
                End If
                'End While
            Next
        Next


        'EL ORDEN DE LAS TAREAS TIENE QUE SER CORRELATIVO, NO TIENE QUE HABER SALTOS EN LOS NROS 
        Return maqColeccion
    End Function
End Class



Public Class tareas
    Public id_tarea As Integer
    Public id_maquina As Integer ' tipo de maquina
    Public orden As Integer
    Public tiempo As Long
    Public id_producto As Integer
    Public inicio As Long
    'Public enEspera As Boolean = False
    'Public b As Boolean = False
End Class

Public Class maquinas
    Public id_maquina As Integer
    Public id_tipo As Integer
    Public nombre As String
    Public tareas As New Stack

End Class

Public Class maquinasColeccion
    Inherits System.Collections.CollectionBase

    Public Sub add(ByVal x As maquinas)
        list.Add(x)
    End Sub

    Public Sub Remove(ByVal index As Integer)
        If index > Count - 1 Or index < 0 Then
            'System.Windows.Forms.MessageBox.Show("Index not valid!")
        Else
            List.RemoveAt(index)
        End If
    End Sub

    Public ReadOnly Property Item(ByVal index As Integer) As maquinas
        Get
            Return CType(List.Item(index), maquinas)
        End Get
    End Property

    Public Function buscarMaq(ByVal tipo As Integer) As Integer

        Dim j As Integer = -1
        For j = 0 To Count - 1
            If list.Item(j).id_tipo = tipo Then
                Return j
            End If
        Next
        MsgBox("ERROR. Buscar maq")

    End Function

    Public Function agregarTarea(ByVal index As Integer, ByVal tarea As tareas) As Integer


        list.Item(index).tareas.push(tarea)

    End Function

    Public Function tiempoFin(ByVal maq As Integer) As Long
        Dim k As tareas
        If list.Item(maq).tareas.count > 0 Then
            k = list.Item(maq).tareas.peek()
            Return k.inicio + k.tiempo
        End If
        Return 0
    End Function

    Public Function tiempoFinTarea(ByVal idProd As Integer, ByVal ord As Integer) As Long
        Dim k As Integer
        Dim l As Integer
        For k = 0 To list.Count - 1

            Dim Enu As System.Collections.IEnumerator = list.Item(k).tareas.GetEnumerator
            While Enu.MoveNext()
                If Enu.Current.id_producto = idProd And Enu.Current.orden = ord Then

                    Return Enu.Current.inicio + Enu.Current.tiempo
                End If


            End While
        Next
        'MsgBox("error")
        Return -1
    End Function

End Class

Public Class TareasCollection
    Inherits System.Collections.CollectionBase

    Public Sub add(ByVal x As tareas)
        list.Add(x)
    End Sub

    Public Sub Remove(ByVal index As Integer)
        If index > Count - 1 Or index < 0 Then
            'System.Windows.Forms.MessageBox.Show("Index not valid!")
        Else
            List.RemoveAt(index)
        End If
    End Sub

    Public Sub elimine(ByVal x As Object)
        list.Remove(x)

    End Sub

    Public ReadOnly Property Item(ByVal index As Integer) As tareas
        Get
            Return CType(List.Item(index), tareas)
        End Get
    End Property

    Public ReadOnly Property Menor(ByVal ord As Integer)
        Get                     'devuelve la tarea de menor tiempo de los que tengan ESE ORDEN O MENOR
            Dim i As New tareas ' si no hay mas con ese orden devuelve una con TIEMPO -1
            Dim j As Integer
            Dim b As Boolean = True
            Dim n As Integer
            i.tiempo = -1

            For j = 0 To Count - 1
                If list.Item(j).orden <= ord And list.Item(j).tiempo < i.tiempo Then
                    i = list.Item(j)
                    n = j
                ElseIf (list.Item(j).orden <= ord And b = True) Then
                    i = list.Item(j)
                    b = False
                    n = j
                End If
            Next

            If Not i.tiempo = -1 Then
                list.RemoveAt(n)
            End If


            Return i

        End Get
    End Property

    Public Function menorInicio(ByVal ord As Integer)
        Dim i As New tareas
        Dim b As Boolean = True
        Dim n As Integer
        i.tiempo = -1

        Dim j As Integer

        For j = 0 To Count - 1
            If list.Item(j).inicio < i.inicio And list.Item(j).orden <= ord Then
                i = list.Item(j)
                n = j
            ElseIf b And list.Item(j).orden <= ord Then
                i = list.Item(j)
                b = False
                n = j
            End If
        Next

        If Not i.tiempo = -1 Then
            list.RemoveAt(n)
        End If

        Return i
    End Function
End Class





