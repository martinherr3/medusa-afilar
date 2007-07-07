Imports System.Data.SqlClient
Imports Infragistics.Win.UltraWinTree
Imports Infragistics.Win
Public Class Permiso
    Dim DS As New DataSet
    Dim Sqldataadapter1 As New SqlDataAdapter("select * from modulo ", cnn)
    Dim Sqldataadapter2 As New SqlDataAdapter("select * from formulario ", cnn)
    Public Function cargarDSPermisos() As DataSet
        cnn.Open()
        Sqldataadapter1.Fill(DS, "modulo")
        Sqldataadapter2.Fill(DS, "formulario")
        cnn.Close()

        crearRelacion(DS, "modulo", "formulario", "idmodulo", "idmodulo", "relacion")
        Return DS

    End Function
    Public Sub asignarPermiso(ByVal tree As UltraTree, ByVal usuario As Integer)
        Dim comando As SqlCommand
        Dim nodo As UltraTreeNode
        Dim Form As String
        Dim trans As SqlTransaction
        cnn.Open()
        trans = cnn.BeginTransaction()
        Try
            comando = New SqlClient.SqlCommand("DELETE FROM formxempleado WHERE idlegajo = " & usuario, cnn)
            comando.Transaction = trans
            comando.ExecuteNonQuery()
            For Each nodo In tree.Nodes
                Dim nodoshijos As TreeNodesCollection = nodo.Nodes
                Dim nodoh As UltraTreeNode
                For Each nodoh In nodoshijos
                    If nodoh.CheckedState = CheckState.Checked Then
                        Form = Mid(nodoh.Key(), InStr(nodoh.Key(), "-") + 1)
                        comando = New SqlClient.SqlCommand("INSERT INTO formxempleado(idformulario, idlegajo) VALUES( '" & Form & "', '" & usuario & "')", cnn)
                        comando.Transaction = trans
                        comando.ExecuteNonQuery()
                    End If
                Next
            Next
            trans.Commit()
            MsgBox("Permisos asignados")
        Catch ex As Exception
            trans.Rollback()
            MsgBox("Error de asignacion")

        End Try
        cnn.Close()


       
    End Sub
    Public Sub actualizarArbol(ByVal tree As UltraTree, ByVal usuario As Integer)
        Dim nodo As UltraTreeNode
        For Each nodo In tree.Nodes
            nodo.CheckedState = CheckState.Unchecked
        Next
        DS.Clear()
        Dim sqlDA As New SqlDataAdapter("select cast(idmodulo as varchar) + '-' + cast(idformulario as varchar) as code from formulario where idformulario in (select idformulario from formxempleado where idlegajo = " & usuario & " )", cnn)
        sqlDA.Fill(DS, "formspermitidos")

        Dim dr As DataRow
        For Each dr In DS.Tables("formspermitidos").Rows
            nodo = tree.GetNodeByKey(dr.Item("code"))
            If Not nodo Is Nothing Then
                nodo.CheckedState = CheckState.Checked
            End If
        Next
        




    End Sub
End Class
