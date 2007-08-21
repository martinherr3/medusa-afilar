Public Class ParametrosCompras
    Private _StockActual As Integer
    Private _StockSeguridad As Integer
    Private _StockMinimo As Integer
    Private _LoteEconomico As Decimal
    Private _Periodo As Integer

    Public Property StockActual() As Integer
        Get
            Return _StockActual
        End Get
        Set(ByVal value As Integer)
            _StockActual = value
        End Set
    End Property

    Public Property StockMinimo() As Integer
        Get
            Return _StockMinimo
        End Get
        Set(ByVal value As Integer)
            _StockMinimo = value
        End Set
    End Property

    Public Property StockSeguridad() As Integer
        Get
            Return _StockSeguridad
        End Get
        Set(ByVal value As Integer)
            _StockSeguridad = value
        End Set
    End Property

    Public Property LoteEconomico() As Decimal
        Get
            Return _LoteEconomico
        End Get
        Set(ByVal value As Decimal)
            _LoteEconomico = value
        End Set
    End Property

    Public Property Periodo() As Integer
        Get
            Return _Periodo
        End Get
        Set(ByVal value As Integer)
            _Periodo = value
        End Set
    End Property

    ''' <summary>
    ''' Retorna el lote optimo para el Tipo de Materia Prima Ingresado
    ''' </summary>
    ''' <param name="IdTipoMateria">Id del Tipo de Materia Prima</param>
    ''' <returns></returns>
    ''' <remarks></remarks>

    Public Function CalcularLoteOptimo(ByVal IdTipoMateria As Integer) As Decimal
        Dim Consumo As Integer

        Consumo = RetornarConsumo(IdTipoMateria)

        Dim q As Decimal  'tamaño del lote
        Dim cp As Decimal 'costo por pedido
        Dim cs As Decimal 'costo de stock
        Dim t As Decimal  'periodo de analisis
        Dim n As Decimal  'demanda en el periodo

        cp = 10
        cs = 3
        t = Periodo
        n = Consumo
        q = Math.Round(Math.Sqrt((2 * cp * n) / (cs * t)), 2)

        LoteEconomico = q

        Return q

    End Function

    ''' <summary>
    ''' Retorna el consumo en el ultimo año del Tipo de Materia Prima seleccionada
    ''' </summary>
    ''' <param name="IdTipoMateria">Id del Tipo de Materia Prima</param>
    ''' <returns></returns>
    ''' <remarks></remarks>

    Public Function RetornarConsumo(ByVal IdTipoMateria As Integer) As Integer

        Dim sqlConsulta As String

        sqlConsulta = "select sum(PxT.cantidad) as CantidadVendida" & _
                      " from fresa F, tipoFresa T, parte PxT, tipoparte P, MPxTP MxT, tipomateriaprima TMP" & _
                      " where F.idtipo = T.idtipo and F.idmodelo=T.idmodelo and T.idtipo = PxT.idtipofresa and T.idmodelo = PxT.idmodelo and" & _
                      " PxT.nombre = P.nombre And P.nombre = MxT.nombre And MxT.idmp = TMP.idtipomateriaprima And F.fechafinfabricacion" & _
                      " between DateAdd(Year, -1, getdate()) And getdate() And TMP.idtipomateriaprima =" & IdTipoMateria & _
                      " group by TMP.idtipomateriaprima"

        Dim Ad As New SqlClient.SqlDataAdapter(sqlConsulta, cnn)
        Dim Dato As New DataSet

        Ad.Fill(Dato, "Cantidad")

        If Dato.Tables(0).Rows.Count > 0 Then
            Return CType(Dato.Tables(0).Rows(0).Item(0).ToString, Integer)
        Else
            Return 0
        End If

    End Function

    ''' <summary>
    ''' Retorna entre pedidos teniendo en cuenta ese Tipo de Materia Prima
    ''' </summary>
    ''' <param name="IdTipoMateria"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>

    Public Function TiempoEntrePedidos(ByVal IdTipoMateria As Integer) As Decimal
        Dim Tiempo As Decimal
        Dim myConsumo As Integer
        myConsumo = RetornarConsumo(IdTipoMateria)
        If myConsumo <> 0 Then
            Tiempo = (Periodo * CalcularLoteOptimo(IdTipoMateria)) / myConsumo
        Else
            Tiempo = 0
        End If

        Return Tiempo
    End Function

    ''' <summary>
    ''' Indica cuando se debe realizar el proximo pedido, en dias
    ''' </summary>
    ''' <param name="IdTipoMateria"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>

    Public Function ProximoPedido(ByVal IdTipoMateria As Integer) As Decimal
        Dim sqlConsulta As String
        sqlConsulta = "select stockactual from tipomateriaprima where idtipomateriaprima=" & IdTipoMateria
        Dim Ap As New SqlClient.SqlDataAdapter(sqlConsulta, cnn)
        Dim Dato As New DataSet
        Dim stockAct As Integer
        Ap.Fill(Dato, "tipomateriaprima")

        If Dato.Tables(0).Rows.Count > 0 Then
            stockAct = Dato.Tables(0).Rows(0).Item(0)
        Else
            stockAct = 0
        End If
        Dim myLote As Decimal
        myLote = CalcularLoteOptimo(IdTipoMateria)
        If myLote <> 0 Then
            Return (stockAct / (myLote / 360))
        Else
            Return 0
        End If

    End Function

    Public Sub ActualizarLote(ByVal IdTipoMateria As Integer)

        Dim sql As New SqlClient.SqlCommand
        Dim conn As SqlClient.SqlConnection
        conn = cnn
        sql.CommandType = CommandType.Text
        Try
            sql.CommandText = "UPDATE tipomateriaprima SET loteeconomico = " & CalcularLoteOptimo(IdTipoMateria) & _
            " WHERE idtipomateriaprima = " & IdTipoMateria
            conn.Open()
            sql.Connection = conn
            sql.ExecuteNonQuery()
            conn.Close()
        Catch ex As Exception
            Throw ex
        End Try
        
    End Sub

    Public Function RetornarDiasDemora(ByVal IdTipoMateria As Integer) As Integer

        Dim sqlConsulta As String

        sqlConsulta = "SET dateformat 'dmy'" & _
                      " Select sum(DateDiff(Day, OC.fecharealizacion, Convert(DateTime, MPR.fecharecepcion))) / count(DateDiff(Day, OC.fecharealizacion, Convert(DateTime, MPR.fecharecepcion)))" & _
                      " FROM ordencompramp OC, mprecibida MPR, detallemprecibida DMPR" & _
                      " WHERE OC.idordencompra = MPR.idordencompramp and MPR.idmprecibida = DMPR.idmprecibida and DMPR.idtipomateriaprima=" & IdTipoMateria

        Dim Ap As New SqlClient.SqlDataAdapter(sqlConsulta, cnn)
        Dim Dato As New DataSet
        Dim DiasPromedio As Integer
        Ap.Fill(Dato)

        If Dato.Tables(0).Rows.Count > 0 Then
            If IsNumeric(Dato.Tables(0).Rows(0).Item(0)) Then
                DiasPromedio = Dato.Tables(0).Rows(0).Item(0)
            Else
                DiasPromedio = 0
            End If
        Else
            DiasPromedio = 0
        End If

        Return DiasPromedio

    End Function

    Public Sub New()
        Periodo = 1
    End Sub
End Class
