Imports Infragistics.Win.UltraWinExplorerBar
Imports System.Reflection
Imports System.Data.SqlClient


Public Class GestorFrm
    '    Dim barra As UltraExplorerBar
    Public Shared Sub InitMenu(ByVal barra As UltraExplorerBar, ByVal mMenu As MainMenu, ByVal frm As principal)

        Dim DS As New DataSet
        Dim adapterModulo As SqlDataAdapter = New SqlDataAdapter("select idmodulo, descripcion from modulo", cnn)
        Dim adapterForm As SqlDataAdapter = New SqlDataAdapter("select * from formulario", cnn)
        Dim adapterMenu As SqlDataAdapter = New SqlDataAdapter("select * from menupadre", cnn)
        adapterModulo.Fill(DS, "Modulo")
        adapterForm.Fill(DS, "Formulario")
        adapterMenu.Fill(DS, "MenuPadre")
        Dim TMod As DataTable = DS.Tables.Item("Modulo")
        Dim TMenPadre As DataTable = DS.Tables.Item("MenuPadre")
        Dim dv As New DataView(DS.Tables.Item("Formulario"))
        Dim drMod As DataRow
        Dim drMenPadre As DataRow
        Dim i As Integer
        For Each drMod In TMod.Rows
            With mMenu.MenuItems.Add(drMod.Item("descripcion"))
                .Text = "&" & drMod.Item("descripcion")
                For Each drMenPadre In TMenPadre.Rows
                    dv.RowFilter = "idmodulo = " & drMod.Item("idmodulo") & "and idmenu = " & drMenPadre.Item("idmenu")
                    If dv.Count <> 0 And drMenPadre.Item("idmenu") <> 1 Then
                        With .MenuItems.Add(drMenPadre.Item("nombre"))
                            .Text = drMenPadre.Item("nombre")
                            For i = 0 To dv.Count - 1
                                With .MenuItems.Add(dv.Item(i).Item("nombre"), New EventHandler(AddressOf frm.mnu_Click))
                                    .Text = dv.Item(i).Item("descripcion")
                                    .tag = dv.Item(i).Item("nombre")
                                    .enabled = seguridad.HasPrivilege(dv.Item(i).Item("idformulario"))
                                End With
                            Next i
                        End With
                    ElseIf drMenPadre.Item("idmenu") = 1 And dv.Count <> 0 Then
                        For i = 0 To dv.Count - 1
                            With .MenuItems.Add(dv.Item(i).Item("nombre"), New EventHandler(AddressOf frm.mnu_Click))
                                .Text = dv.Item(i).Item("descripcion")
                                .tag = dv.Item(i).Item("nombre")
                                .enabled = seguridad.HasPrivilege(dv.Item(i).Item("idformulario"))
                            End With
                        Next i

                    End If
                Next
            End With

        Next


        For Each drMod In TMod.Rows
            Dim grupo As New UltraExplorerBarGroup
            grupo.Text = Trim(drMod.Item("descripcion"))
            'Dim Apariencia As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            'Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(principal))
            'Apariencia.Image = CType(resources.GetObject("Appearance8.Image"), Object)
            'grupo.Settings.AppearancesLarge.HeaderAppearance = Apariencia
            dv.RowFilter = "idmodulo = " & drMod.Item("idmodulo")
            If dv.Count <> 0 Then
                For i = 0 To dv.Count - 1
                    If seguridad.HasPrivilege(dv.Item(i).Item("idformulario")) Then
                        grupo.Items.Add(Trim(dv.Item(i).Item("nombre")), Trim(dv.Item(i).Item("descripcion")))
                    End If


                Next i
            End If
            barra.Groups.Add(grupo)
        Next

    End Sub

    Public Shared Sub OpenForm(ByVal formName As String, ByVal padre As Form)
        Dim t As Type

        t = Type.GetType("Afilar." & formName)

        Dim f As New Form
        Try
            f = DirectCast(Activator.CreateInstance(t), Form)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al castear el formulario")
            Exit Sub
        End Try
        If Not f Is Nothing Then
            f.Show()
            f.MdiParent = padre
        Else
            MessageBox.Show("Error al intentar abrir el formulario")
        End If
    End Sub
    

End Class
