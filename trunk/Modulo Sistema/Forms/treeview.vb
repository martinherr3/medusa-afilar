Imports Infragistics.Win
Imports Infragistics.Win.UltraWinTree
Imports System.Data.SqlClient

Public Class treeview
    'validar cuando cargo un formulario que solo puede haber un nombre por cada uno 
    ' esto es por el campo key de 
    Dim DS As New DataSet
    Dim permisos As Permiso

    Private Sub treeview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        permisos = New Permiso
        DS = permisos.cargarDSPermisos()
        Dim elementop As DataRow
        Dim elementoh As DataRow
        Dim hijos As Array
        Dim padre As DataRowCollection

        padre = DS.Tables("modulo").Rows()
        For Each elementop In padre
            Dim rootNode As UltraTreeNode = Me.UltraTree1.Nodes.Add(elementop.Item("idmodulo"), elementop.Item("descripcion").ToString())

            hijos = obtenerHijos(elementop, "relacion")
            For Each elementoh In hijos
                Dim childNode As UltraTreeNode
                'key es nodo & form para facilitar la busqueda
                childNode = rootNode.Nodes.Add(Trim(elementop.Item("idmodulo")) & "-" & Trim(elementoh.Item("idformulario")), Trim(elementoh.Item("descripcion").ToString()))


            Next

        Next

        Me.UltraTree1.NodeLevelOverrides(0).NodeStyle = NodeStyle.CheckBoxTriState
        Me.UltraTree1.NodeLevelOverrides(1).NodeStyle = NodeStyle.CheckBox
        Me.UltraTree1.ExpandAll()
        cargarUltraCombo("select nombre, idlegajo from empleado", UltraComboEditor1, "nombre", "idlegajo")


    End Sub
    Private Sub VerifyParentNodeCheckState(ByVal descendantNode As UltraTreeNode)

        Dim parentNode As UltraTreeNode = descendantNode.Parent
        If Not parentNode Is Nothing Then

            Dim nodesCollection As TreeNodesCollection = descendantNode.ParentNodesCollection

            Dim checkedNodesCount As Integer = 0
            Dim i As Integer
            For i = 0 To nodesCollection.Count - 1

                Dim node As UltraTreeNode = nodesCollection(i)

                If node.CheckedState = CheckState.Checked Then checkedNodesCount += 1

            Next i


            If checkedNodesCount = nodesCollection.Count Then
                parentNode.CheckedState = CheckState.Checked
            ElseIf checkedNodesCount <> 0 Then
                parentNode.CheckedState = CheckState.Indeterminate
            Else
                parentNode.CheckedState = CheckState.Unchecked
            End If

        End If

    End Sub

    Private Sub UltraTree1_AfterCheck(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinTree.NodeEventArgs) Handles UltraTree1.AfterCheck
        If e.TreeNode.Level = 1 Then

            Me.VerifyParentNodeCheckState(e.TreeNode)
        Else
            If e.TreeNode.CheckedState = CheckState.Checked Then
                Dim nodo As TreeNodesCollection = e.TreeNode.Nodes
                Dim i As Integer
                For i = 0 To nodo.Count - 1

                    Dim node As UltraTreeNode = nodo(i)

                    node.CheckedState = CheckState.Checked
                Next i
            End If

            If e.TreeNode.CheckedState = CheckState.Unchecked Then
                Dim nodo As TreeNodesCollection = e.TreeNode.Nodes
                Dim i As Integer
                For i = 0 To nodo.Count - 1

                    Dim node As UltraTreeNode = nodo(i)

                    node.CheckedState = CheckState.Unchecked
                Next i
            End If
        End If
    End Sub

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click
        ''permisos.actualizarArbol(UltraTree1, 5)
        'Dim nodo As UltraTreeNode
        'For Each nodo In Me.UltraTree1.Nodes
        '    Dim nodoshijos As TreeNodesCollection = nodo.Nodes
        '    Dim nodoh As UltraTreeNode
        '    For Each nodoh In nodoshijos
        '        If nodoh.CheckedState = CheckState.Checked Then
        '            MsgBox(nodoh.Key)
        '            MsgBox(nodoh.DataKey)
        '        End If

        '    Next
        '    'MsgBox(nodo.Key)
        '    ' MsgBox(nodo.DataKey)

        'Next
        If MsgBox("Seguro desea asignar estos permisos?", MsgBoxStyle.Question, "Confirmacion") = MsgBoxResult.Ok Then
            permisos.asignarPermiso(UltraTree1, 2)
        End If

    End Sub

    Private Sub UltraComboEditor1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraComboEditor1.ValueChanged
        Dim empleado As New Empleado
        Dim ds As New DataSet
        If Not UltraComboEditor1.SelectedItem() Is Nothing Then
            ds = empleado.cargarDSEmpleado("select e.nombre as nombre, e.apellido as apellido, e.turno as turno, c.nombre as cargo, p.descripcion as perfil from cargo c inner join (empleado as e left join perfil as p on e.idperfil = p.idperfil) on c.idcargo = e.idcargo and e.idlegajo= " & UltraComboEditor1.SelectedItem.DataValue(), cnn)
            If ds.Tables(0).Rows.Count() <> 0 Then
                Label2.Text = Trim(ds.Tables(0).Rows(0).Item("apellido")) & ", " & Trim(ds.Tables(0).Rows(0).Item("nombre"))
                Label4.Text = Trim(ds.Tables(0).Rows(0).Item("cargo"))
                If Not IsDBNull(ds.Tables(0).Rows(0).Item("perfil")) Then
                    Label6.Text = Trim(ds.Tables(0).Rows(0).Item("perfil"))
                Else
                    Label6.Text = ""
                End If

                permisos.actualizarArbol(UltraTree1, UltraComboEditor1.SelectedItem.DataValue())
            End If
        End If
        

    End Sub

    Private Sub UltraButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton2.Click
        Me.Close()
    End Sub
End Class