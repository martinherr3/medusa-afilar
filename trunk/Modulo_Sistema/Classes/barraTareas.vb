Imports Infragistics.Win.UltraWinStatusBar

Public Class BarraDeEstado
    Private x As UltraStatusBar
    Private panel(50) As UltraStatusPanel
    Private formulario(50) 'As Form
    Private frmActivo As Integer = -1
    Private NroPanel As Integer = 0



    Sub New(ByRef barra As Infragistics.Win.UltraWinStatusBar.UltraStatusBar)
        x = barra
    End Sub


    Function agregarBoton(ByRef F As Form)

        panel(x.Panels.Count()) = x.Panels.Add("P" & NroPanel, PanelStyle.StateButton) ' agrega el boton
        NroPanel += 1

        With panel(x.Panels.Count() - 1)
            'panel(x.Panels.Count() - 1).Text = F.Text
            If F.Text.Length > 18 Then
                .Text = F.Text.Substring(0, 14) & "..."
            Else
                .Text = F.Text
            End If
            '.Text = F.Text      



            .Appearance.BackColor = Color.LightSteelBlue
            .Appearance.BorderColor3DBase = Color.Gainsboro

        End With


        formulario(x.Panels.Count() - 1) = F    ' carga la referencia al form en el vector

        'frmActivo = x.Panels.Count - 1

        panel(x.Panels.Count - 1).Checked = True  ' activa el boton del formulario recien cargado

        'System.Diagnostics.Debug.WriteLine("frmActivo: " & frmActivo & " | Paneles: " & x.Panels.Count() - 1)

        'Return frmActivo
        Return x.Panels.Count - 1

    End Function


    Sub eliminarBoton() 'elimina el boton que corresponde al form activo (eso espero!!!)
        'Try
        Dim lst As New lista
        If frmActivo <> -1 Then
            x.Panels.Remove(panel(frmActivo))       ' elimina el boton del form activo
            lst.eliminarItem(formulario, frmActivo) ' elimina la ref al form en el vector
            lst.eliminarItem(panel, frmActivo)      ' elimina la ref al panel en el vector
            frmActivo = x.Panels.Count() - 1        ' el form activo ahora es el ultimo
        End If

        If x.Panels.Count() > 0 Then
            x.Panels(frmActivo).Checked = True
            formulario(x.Panels.Count() - 1).Visible = True
        End If
        'Catch

        'End Try
        'System.Diagnostics.Debug.WriteLine("frmActivo: " & frmActivo & " | Paneles: " & x.Panels.Count() - 1)

    End Sub


    Function formActivo() ' devuelve el nro de form activo
        Dim i As Integer
        For i = 0 To x.Panels.Count - 1
            If x.Panels(i).Checked Then
                Return i
            End If
        Next
        'System.Diagnostics.Debug.Write("frmActivo: " & frmActivo)
    End Function


    Sub click()
        Dim n As Integer = 0
        Dim i As Integer
        For i = 0 To x.Panels.Count - 1
            If x.Panels(i).Checked Then
                'Return frmActivo
                n += 1
            End If
        Next

        If n = 0 Then
            x.Panels(frmActivo).Checked = True
            'ElseIf n = 1 Then
        ElseIf n = 2 Then
            x.Panels(frmActivo).Checked = False
        End If

        For i = 0 To x.Panels.Count - 1
            If x.Panels(i).Checked Then
                frmActivo = i
            End If

        Next
        formulario(frmActivo).Activate()
        princ.etiPrin.Text = formulario(frmActivo).text


        'System.Diagnostics.Debug.WriteLine("frmActivo: " & frmActivo & " | Paneles: " & x.Panels.Count() - 1)
        ' formulario(frmActivo).Show()
        'MsgBox("formulario(" & frmActivo & ").Show()")
    End Sub
End Class


Public Class lista
    Sub eliminarItem(ByRef x(), ByVal n) ' x el vector n el nro de item a eliminar
        Dim i, j                        ' este metodo elimina el espacio vacio q queda despues de quitar
        j = 0                           ' un elemento del vector
        For Each i In x
            If j >= n And j < 50 Then
                x(j) = x(j + 1)
            End If
            j += 1
        Next
        'x(j) = Nothing
    End Sub
End Class
