Imports Infragistics.Win.UltraWinExplorerBar
Imports System.Reflection
Imports System.Data.SqlClient
Imports System.Configuration.ConfigurationSettings
Public Class frmSegProd
    Public obj As ProdTacking
    Private Sub frmSegProd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        


        Dim i As Integer
        For i = 0 To 2
            Dim grupo As New UltraExplorerBarGroup
            grupo.Text = "grupo" & i
            '

            Dim projectPath As String
            projectPath = getAppPath()
            Dim Apariencia As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            'aca hay que poner el nombre de la imagen sacada de la base de datos puede ser del nombre del grupo para no poner otro campo a la base de datos
            Apariencia.Image = Image.FromFile(projectPath + AppSettings.Get("ImagesPath") + "\mailNew.GIF")
            Dim str As String
            str = projectPath + AppSettings.Get("ImagesPath") + "\Done.ico"
            grupo.Settings.AppearancesLarge.HeaderAppearance = Apariencia

            '


            grupo.Items.Add("key" & i, "text" & i)
            grupo.Items.Add("key" & i, "text" & i)
            'grupo.Enabled = False
            barra.Groups.Add(grupo)

        Next i
    End Sub

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click
        obj = New ProdTacking(1)
        obj.getDatos(barra)
        lblFresa.Text = obj.getNombreFresa()
        imagen.Image = obj.getImagen()
        
    End Sub

    Private Sub UltraButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton2.Click

        Dim proximaOP As Integer
        proximaOP = obj.getProximaOp() - 1
        If proximaOP <> -1 Then
            ProdTacking.selectGrupo(proximaOP, barra)
        Else
            MsgBox("La fabricacion de este articulo ya a finalizado", MsgBoxStyle.Information, "Hoja de ruta finalizada")
        End If

    End Sub

    
End Class









Public Class ProdTacking
    Private adapterfresa As SqlDataAdapter
    Private DS As DataSet
    Private IdHojaRuta As Integer



    Public Sub New(ByVal idfresa As Integer)
        adapterfresa = New SqlDataAdapter("select detallehojaderuta.idhojaderuta, detallehojaderuta.idetapadefabricacion, operacion.duracionpromedio, tipofresa.imagen, etapadefabricacion.idetapafabricacion, fresa.nroserie, etapadefabricacion.orden, operacion.nombre as nombreoperacion, detallehojaderuta.fechahorainicioreal, detallehojaderuta.fechahorainicioplanificada, detallehojaderuta.fechahorafinreal, detallehojaderuta.fechahorafinplanificada, hojaderuta.fechainicioproduccion, operacion.maquina, tipofresa.nombre from fresa inner join hojaderuta on hojaderuta.idhojaderuta = fresa.idhojaderuta inner join tipofresa on fresa.idtipo = tipofresa.idtipo and fresa.idmodelo = tipofresa.idmodelo inner join detallehojaderuta on detallehojaderuta.idhojaderuta = fresa.idhojaderuta inner join etapadefabricacion on etapadefabricacion.idetapafabricacion = detallehojaderuta.idetapadefabricacion inner join operacion on etapadefabricacion.idoperacion = operacion.idoperacion where Fresa.nroserie = " & idfresa & " order by operacion.idoperacion", cnn)
        DS = New DataSet
        adapterfresa.Fill(DS, "Fresa")
        Dim TFresa As DataTable = DS.Tables.Item("Fresa")
        If Not IsDBNull(TFresa.Rows(0).Item("idhojaderuta")) Then
            IdHojaRuta = TFresa.Rows(0).Item("idhojaderuta")
        Else
            MsgBox("Esta fresa no tiene una Hoja de ruta asociada", MsgBoxStyle.Information, "Entidad no planeada")
        End If
    End Sub



    Public Shared Sub selectGrupo(ByVal ordenOperacion As Integer, ByRef barra As UltraExplorerBar)
        'aca le paso el numero de orden de la operacion para que se seleccione el gupo adecuado 
        barra.SelectedGroup = barra.Groups.GetItem(ordenOperacion)
    End Sub

    Public Function getNombreFresa() As String
        Dim TFresa As DataTable = DS.Tables.Item("Fresa")
        If Not IsDBNull(TFresa.Rows(0).Item("nombre")) Then
            Return TFresa.Rows(0).Item("nombre")
        Else
            Return "Fresa Generica AFILAR"
        End If


    End Function
    Public Function getImagen() As Image
        Dim TFresa As DataTable = DS.Tables.Item("Fresa")
        If Not IsDBNull(TFresa.Rows(0).Item("imagen")) Then
            Return Bytes2Image(TFresa.Rows(0).Item("imagen"))
        Else : Return Nothing ' tener en cuenta esto
        End If
    End Function

    Public Function getProximaOp() As Integer
        Dim adapttemp As SqlDataAdapter
        adapttemp = New SqlDataAdapter("select min(etapadefabricacion.orden) as proximaoperacion from detallehojaderuta inner join etapadefabricacion on etapadefabricacion.idetapafabricacion = detallehojaderuta.idetapadefabricacion where fechahorainicioreal is null and idhojaderuta = " & IdHojaRuta, cnn)
        Dim DS As New DataSet
        adapttemp.Fill(DS, "Fresa")
        Dim TFresa As DataTable = DS.Tables.Item("Fresa")
        If Not IsDBNull(TFresa.Rows(0).Item("proximaoperacion")) Then
            Return TFresa.Rows(0).Item("proximaoperacion")
        Else : Return -1
        End If


    End Function

    Public Function registrarAvance() As Boolean
        Dim nextOp As Integer
        nextOp = getProximaOp()
        Dim conn As SqlConnection
        conn = cnn
        conn.Open()
        Try
            'Aca registro la fecha de fin de la operacion actual
            Dim sql1 As String = "UPDATE detallehojaderuta fechahorafinreal = getdate() where idhojaderuta = " & IdHojaRuta & " and idetapadefabricacion in (select idetapadefabricacion from etapadefabricacion where orden = " & nextOp & ")"
            Dim comm1 As New SqlCommand(sql1, conn)

            comm1.ExecuteReader()


            'Aca registro el comienzo de la proxima operacion
            Dim sql2 As String = "UPDATE detallehojaderuta fechahorainicioreal = getdate() where idhojaderuta = " & IdHojaRuta & " and idetapadefabricacion in (select idetapadefabricacion from etapadefabricacion where orden = " & nextOp - 1 & ")"
            Dim comm2 As New SqlCommand(sql1, conn)

            comm2.ExecuteReader()

            conn.Close()
            Return True
        Catch
            Return False
        End Try

    End Function
    Public Sub getDatos(ByRef barra As UltraExplorerBar)
        'Falta validar los dbnull por que se pudre todo si no 
        barra.Groups.Clear()


        Dim TFresa As DataTable = DS.Tables.Item("Fresa")
        Dim DrFresa As DataRow


        For Each DrFresa In TFresa.Rows

            Dim grupo As New UltraExplorerBarGroup
            grupo.Text = DrFresa.Item("nombreoperacion")

            '
            Dim projectPath As String
            projectPath = getAppPath()
            Dim Apariencia As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            'aca hay que poner el nombre de la imagen sacada de la base de datos puede ser del nombre del grupo para no poner otro campo a la base de datos
            If IsDBNull(DrFresa.Item("fechahorafinreal")) Then
                Apariencia.Image = Image.FromFile(projectPath + AppSettings.Get("ImagesPath") + "\Pending.png")
            Else
                Apariencia.Image = Image.FromFile(projectPath + AppSettings.Get("ImagesPath") + "\Done.png")
            End If

            Dim str As String

            grupo.Settings.AppearancesLarge.HeaderAppearance = Apariencia
            '
            'acordate de hacer un order by este capo
            grupo.Items.Add("orden", "Numero de orden:" & DrFresa.Item("orden"))
            grupo.Items.Add("fechahorainicioreal", "Inicio real de operacion: " & DrFresa.Item("fechahorainicioreal"))
            grupo.Items.Add("fechahorainicioplanificada", "Inicio planificado de operacion: " & DrFresa.Item("fechahorainicioplanificada"))
            grupo.Items.Add("fechahorafinreal", "Operacion finalizada: " & DrFresa.Item("fechahorafinreal"))
            grupo.Items.Add("fechahorafinplanificada", "Fecha planificada de finalizacion: " & DrFresa.Item("fechahorafinplanificada"))
            grupo.Items.Add("duracionpromedio", "Duracion promedio: " & DrFresa.Item("duracionpromedio"))
            If IsDBNull(DrFresa.Item("maquina")) Then
                grupo.Items.Add("maquina", "Maquina de trabajo: " & "")
            Else
                grupo.Items.Add("maquina", "Maquina de trabajo: " & DrFresa.Item("maquina"))
            End If
            grupo.Items.Add("maquina", "Operario resposable: " & "")
            barra.Groups.Add(grupo)
            Apariencia.Dispose()

        Next


    End Sub

End Class