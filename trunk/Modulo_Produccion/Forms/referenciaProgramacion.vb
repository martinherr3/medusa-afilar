Public Class referenciaProgramacion
  Private _fresas As Collection
  Private _maquinas As Collection

  Public WriteOnly Property fresas() As Collection
    Set(ByVal value As Collection)
      _fresas = value
    End Set
  End Property

  Public WriteOnly Property maquinas() As Collection
    Set(ByVal value As Collection)
      _maquinas = value
    End Set
    End Property

    Private Sub referenciaProgramacion_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        princ.barra.eliminarBoton()
    End Sub



  Private Sub referenciaProgramacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        princ.barra.agregarBoton(Me)
        Dim allTasksCollection As New Collection

        For Each maq As MaquinaProd In _maquinas
            For Each tar As tareasProd In maq.tareas
                allTasksCollection.Add(tar)
            Next
        Next




        For Each fre As fresaProd In _fresas
            TreeProgramacion.Nodes.Add("Fresa: " & fre.id_fresa)
            'TreeProgramacion.Nodes.Item(TreeProgramacion.Nodes.Count - 1).BackColor = fre.colorGrafico
            TreeProgramacion.Nodes.Item(TreeProgramacion.Nodes.Count - 1).ForeColor = fre.colorGrafico
            Dim orden As Integer = 1
            Dim i As Boolean

            Do
                i = False
                For Each tar As tareasProd In allTasksCollection
                    If tar.idFresa = fre.id_fresa And tar.orden = orden Then
                        TreeProgramacion.Nodes.Item(TreeProgramacion.Nodes.Count - 1).Nodes.Add(tar.orden.ToString.PadRight(3) & " - " & tar.idMaquina.Trim & " | Inicio: " & tar.inicio & " | Fin: " & tar.fin)
                        orden += 1
                        i = True
                    End If
                Next
            Loop While (i)


        Next
  End Sub

  Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click
        Me.Close()
  End Sub
End Class