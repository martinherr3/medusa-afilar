
Public Class registrarModeloFresa

#Region "Declaraciones"
    Inherits System.Windows.Forms.Form
    Dim consulta As String
    Dim indice As Integer
    Dim columnas() As Integer = {0, 1, 2, 3, 4}
    Dim item As New ListViewItem
    Dim ds As New DataSet
    Dim parte As New parte
    Dim etapa As New EtapaFabricacion
    Dim fresa As New TipoFresa
    Dim modelo As New ModeloFresa
    Dim adicional As New ParteAdicional
    Dim operacion As New Operacion
    Dim ofd As New OpenFileDialog
    Dim um As New UnidadDeMedida
    Dim i As Integer = 0
    Dim j As Integer = 1
    Dim bandera As Boolean = False
    Dim banderaAd As Boolean = False
    Dim banderaAd2 As Boolean = False
    Dim banderaParte As Boolean = False
    Dim banderaFresa As Boolean = False
#End Region


#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents UltraGroupBox3 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents UltraButton2 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton3 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents lista2 As System.Windows.Forms.ListView
    Friend WithEvents lista1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents UltraButton4 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents tab1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents tab As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents textID As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents textNom As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents UltraGroupBox9 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents UltraGroupBox10 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraButton14 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents lblUnidadDeMedida As System.Windows.Forms.Label
    Friend WithEvents UltraGroupBox11 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraButton15 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ColumnHeader21 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader22 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader23 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader24 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader25 As System.Windows.Forms.ColumnHeader
    Friend WithEvents UltraGroupBox12 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents UltraButton16 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents UltraGroupBox13 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraButton17 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ColumnHeader26 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader27 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader28 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader29 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader30 As System.Windows.Forms.ColumnHeader
    Friend WithEvents UltraGroupBox14 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents btnCalcularCosto As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents UltraButton19 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton20 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton21 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton22 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents UltraButton23 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton24 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents comboGrupoModelo As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents comboTipoModelo As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents textPrecioModelo As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents textDescripcion As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents textVA As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents comboTA As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents comboMA As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents comboMT As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents lista3 As System.Windows.Forms.ListView
    Friend WithEvents textCantidad As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents textIDParte As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents comboNParte As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents textDescParte As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents comboMatPrim As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents lista4 As System.Windows.Forms.ListView
    Friend WithEvents orden As System.Windows.Forms.NumericUpDown
    Friend WithEvents textTiempo As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents textDetalles As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents textIDEtapa As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents comboOperacion As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraButton5 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents UltraButton6 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents textDiamAgu As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents textDiamExt As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents comboPT As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents textCarFresa As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents textIDFresa As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents textCantDien As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents textNombreFresa As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents comboNombre As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents textPlanoTF As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents textImagenTF As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents cantidad As System.Windows.Forms.NumericUpDown
    Friend WithEvents UltraGroupBox4 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents lblUmParteAdicional As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents UltraGroupBox5 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents textPlanoA As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents textImagenA As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents UltraButton7 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton8 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton9 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents textPrecioTF As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents textCostoTF As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents imagen As System.Windows.Forms.PictureBox
    Friend WithEvents textDescAdicional As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents textIDAdicional As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents textCostoAdicional As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents comboMPAdicional As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents textCantMPAdicional As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents textPrecioAdicional As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents textTiempoAdicional As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents imagen2 As System.Windows.Forms.PictureBox
    Friend WithEvents UltraButton10 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton11 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton12 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents BotonParte As Infragistics.Win.Misc.UltraButton
    Friend WithEvents botonFresa As Infragistics.Win.Misc.UltraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim ValueListItem4 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim ValueListItem5 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim ValueListItem6 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim ValueListItem7 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim ValueListItem8 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim ValueListItem9 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim ValueListItem10 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ValueListItem11 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim ValueListItem12 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim ValueListItem13 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim ValueListItem14 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ValueListItem15 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim ValueListItem16 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim ValueListItem17 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(registrarModeloFresa))
        Me.tab1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.UltraButton10 = New Infragistics.Win.Misc.UltraButton
        Me.BotonParte = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton4 = New Infragistics.Win.Misc.UltraButton
        Me.UltraGroupBox3 = New Infragistics.Win.Misc.UltraGroupBox
        Me.UltraButton3 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton2 = New Infragistics.Win.Misc.UltraButton
        Me.lista2 = New System.Windows.Forms.ListView
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.lista1 = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.textPrecioModelo = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.Label8 = New System.Windows.Forms.Label
        Me.textDescripcion = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.comboGrupoModelo = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.comboTipoModelo = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.textVA = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.comboTA = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.comboMA = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.comboMT = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.textID = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.textNom = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.botonFresa = New Infragistics.Win.Misc.UltraButton
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.UltraButton6 = New Infragistics.Win.Misc.UltraButton
        Me.textPlanoTF = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraButton5 = New Infragistics.Win.Misc.UltraButton
        Me.imagen = New System.Windows.Forms.PictureBox
        Me.UltraButton24 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton23 = New Infragistics.Win.Misc.UltraButton
        Me.textImagenTF = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraGroupBox9 = New Infragistics.Win.Misc.UltraGroupBox
        Me.cantidad = New System.Windows.Forms.NumericUpDown
        Me.comboPT = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.textCarFresa = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.textIDFresa = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.textCantDien = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.textDiamAgu = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.textDiamExt = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.textNombreFresa = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label38 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.UltraButton19 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton20 = New Infragistics.Win.Misc.UltraButton
        Me.UltraGroupBox11 = New Infragistics.Win.Misc.UltraGroupBox
        Me.UltraButton15 = New Infragistics.Win.Misc.UltraButton
        Me.lista3 = New System.Windows.Forms.ListView
        Me.ColumnHeader21 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader22 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader23 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader24 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader25 = New System.Windows.Forms.ColumnHeader
        Me.UltraGroupBox10 = New Infragistics.Win.Misc.UltraGroupBox
        Me.UltraButton14 = New Infragistics.Win.Misc.UltraButton
        Me.textCantidad = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.textIDParte = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.Label39 = New System.Windows.Forms.Label
        Me.comboNParte = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.Label40 = New System.Windows.Forms.Label
        Me.textDescParte = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.Label41 = New System.Windows.Forms.Label
        Me.comboMatPrim = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.Label42 = New System.Windows.Forms.Label
        Me.Label43 = New System.Windows.Forms.Label
        Me.lblUnidadDeMedida = New System.Windows.Forms.Label
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.UltraButton11 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton21 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton22 = New Infragistics.Win.Misc.UltraButton
        Me.UltraGroupBox14 = New Infragistics.Win.Misc.UltraGroupBox
        Me.textPrecioTF = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.Label51 = New System.Windows.Forms.Label
        Me.btnCalcularCosto = New Infragistics.Win.Misc.UltraButton
        Me.Label52 = New System.Windows.Forms.Label
        Me.textCostoTF = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.Label53 = New System.Windows.Forms.Label
        Me.UltraGroupBox13 = New Infragistics.Win.Misc.UltraGroupBox
        Me.UltraButton17 = New Infragistics.Win.Misc.UltraButton
        Me.lista4 = New System.Windows.Forms.ListView
        Me.ColumnHeader26 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader27 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader28 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader29 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader30 = New System.Windows.Forms.ColumnHeader
        Me.UltraGroupBox12 = New Infragistics.Win.Misc.UltraGroupBox
        Me.Label45 = New System.Windows.Forms.Label
        Me.UltraButton16 = New Infragistics.Win.Misc.UltraButton
        Me.orden = New System.Windows.Forms.NumericUpDown
        Me.textTiempo = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.Label46 = New System.Windows.Forms.Label
        Me.textDetalles = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.Label47 = New System.Windows.Forms.Label
        Me.Label48 = New System.Windows.Forms.Label
        Me.Label49 = New System.Windows.Forms.Label
        Me.textIDEtapa = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.comboOperacion = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.Label50 = New System.Windows.Forms.Label
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.UltraButton12 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton9 = New Infragistics.Win.Misc.UltraButton
        Me.imagen2 = New System.Windows.Forms.PictureBox
        Me.UltraGroupBox5 = New Infragistics.Win.Misc.UltraGroupBox
        Me.UltraButton8 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton7 = New Infragistics.Win.Misc.UltraButton
        Me.textImagenA = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.textPlanoA = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.textTiempoAdicional = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.UltraGroupBox4 = New Infragistics.Win.Misc.UltraGroupBox
        Me.comboMPAdicional = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.lblUmParteAdicional = New System.Windows.Forms.Label
        Me.textCantMPAdicional = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox
        Me.textPrecioAdicional = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.comboNombre = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.textDescAdicional = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.textIDAdicional = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.textCostoAdicional = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.tab = New Infragistics.Win.UltraWinTabControl.UltraTabControl
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.tab1.SuspendLayout()
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox3.SuspendLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.textPrecioModelo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comboGrupoModelo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comboTipoModelo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textVA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comboTA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comboMA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comboMT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textNom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.textPlanoTF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imagen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textImagenTF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox9.SuspendLayout()
        CType(Me.cantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comboPT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textCarFresa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textIDFresa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textCantDien, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textDiamAgu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textDiamExt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textNombreFresa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.UltraGroupBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox11.SuspendLayout()
        CType(Me.UltraGroupBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox10.SuspendLayout()
        CType(Me.textCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textIDParte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comboNParte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textDescParte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comboMatPrim, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.UltraGroupBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox14.SuspendLayout()
        CType(Me.textPrecioTF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textCostoTF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox13.SuspendLayout()
        CType(Me.UltraGroupBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox12.SuspendLayout()
        CType(Me.orden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textTiempo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textIDEtapa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comboOperacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.imagen2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox5.SuspendLayout()
        CType(Me.textImagenA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textPlanoA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textTiempoAdicional, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox4.SuspendLayout()
        CType(Me.comboMPAdicional, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textCantMPAdicional, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.textPrecioAdicional, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comboNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textDescAdicional, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textIDAdicional, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textCostoAdicional, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab.SuspendLayout()
        Me.SuspendLayout()
        '
        'tab1
        '
        Me.tab1.Controls.Add(Me.UltraButton10)
        Me.tab1.Controls.Add(Me.BotonParte)
        Me.tab1.Controls.Add(Me.UltraButton4)
        Me.tab1.Controls.Add(Me.UltraGroupBox3)
        Me.tab1.Controls.Add(Me.UltraGroupBox1)
        Me.tab1.Controls.Add(Me.botonFresa)
        Me.tab1.Location = New System.Drawing.Point(-10000, -10000)
        Me.tab1.Name = "tab1"
        Me.tab1.Size = New System.Drawing.Size(812, 425)
        '
        'UltraButton10
        '
        Me.UltraButton10.Location = New System.Drawing.Point(616, 384)
        Me.UltraButton10.Name = "UltraButton10"
        Me.UltraButton10.Size = New System.Drawing.Size(96, 24)
        Me.UltraButton10.TabIndex = 5
        Me.UltraButton10.Text = "Finalizar"
        '
        'BotonParte
        '
        Me.BotonParte.Location = New System.Drawing.Point(512, 384)
        Me.BotonParte.Name = "BotonParte"
        Me.BotonParte.Size = New System.Drawing.Size(96, 24)
        Me.BotonParte.TabIndex = 2
        Me.BotonParte.Text = "Parte adicional"
        '
        'UltraButton4
        '
        Me.UltraButton4.Location = New System.Drawing.Point(720, 384)
        Me.UltraButton4.Name = "UltraButton4"
        Me.UltraButton4.Size = New System.Drawing.Size(80, 24)
        Me.UltraButton4.TabIndex = 4
        Me.UltraButton4.Text = "Salir"
        '
        'UltraGroupBox3
        '
        Appearance1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.UltraGroupBox3.ContentAreaAppearance = Appearance1
        Me.UltraGroupBox3.Controls.Add(Me.UltraButton3)
        Me.UltraGroupBox3.Controls.Add(Me.UltraButton2)
        Me.UltraGroupBox3.Controls.Add(Me.lista2)
        Me.UltraGroupBox3.Controls.Add(Me.lista1)
        Me.UltraGroupBox3.Location = New System.Drawing.Point(16, 208)
        Me.UltraGroupBox3.Name = "UltraGroupBox3"
        Me.UltraGroupBox3.Size = New System.Drawing.Size(784, 168)
        Me.UltraGroupBox3.SupportThemes = False
        Me.UltraGroupBox3.TabIndex = 1
        Me.UltraGroupBox3.Text = "Maquina/s donde trabajará el modelo"
        Me.UltraGroupBox3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'UltraButton3
        '
        Me.UltraButton3.Location = New System.Drawing.Point(368, 104)
        Me.UltraButton3.Name = "UltraButton3"
        Me.UltraButton3.Size = New System.Drawing.Size(72, 24)
        Me.UltraButton3.TabIndex = 2
        Me.UltraButton3.Text = "<<"
        '
        'UltraButton2
        '
        Me.UltraButton2.Location = New System.Drawing.Point(368, 56)
        Me.UltraButton2.Name = "UltraButton2"
        Me.UltraButton2.Size = New System.Drawing.Size(72, 24)
        Me.UltraButton2.TabIndex = 1
        Me.UltraButton2.Text = ">>"
        '
        'lista2
        '
        Me.lista2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lista2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader10, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.lista2.FullRowSelect = True
        Me.lista2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lista2.Location = New System.Drawing.Point(448, 32)
        Me.lista2.Name = "lista2"
        Me.lista2.Size = New System.Drawing.Size(320, 120)
        Me.lista2.TabIndex = 3
        Me.lista2.UseCompatibleStateImageBehavior = False
        Me.lista2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "ID"
        Me.ColumnHeader10.Width = 49
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Nombre"
        Me.ColumnHeader5.Width = 101
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Potencia"
        Me.ColumnHeader6.Width = 70
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "RPM del eje"
        Me.ColumnHeader7.Width = 77
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Sentido de giro"
        Me.ColumnHeader8.Width = 129
        '
        'lista1
        '
        Me.lista1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lista1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader9})
        Me.lista1.FullRowSelect = True
        Me.lista1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lista1.Location = New System.Drawing.Point(16, 32)
        Me.lista1.Name = "lista1"
        Me.lista1.Size = New System.Drawing.Size(344, 120)
        Me.lista1.TabIndex = 0
        Me.lista1.UseCompatibleStateImageBehavior = False
        Me.lista1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 51
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nombre"
        Me.ColumnHeader2.Width = 128
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Potencia"
        Me.ColumnHeader3.Width = 78
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "RPM del eje"
        Me.ColumnHeader4.Width = 84
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Sentido de giro"
        Me.ColumnHeader9.Width = 100
        '
        'UltraGroupBox1
        '
        Appearance2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.UltraGroupBox1.ContentAreaAppearance = Appearance2
        Me.UltraGroupBox1.Controls.Add(Me.Label11)
        Me.UltraGroupBox1.Controls.Add(Me.Label10)
        Me.UltraGroupBox1.Controls.Add(Me.textPrecioModelo)
        Me.UltraGroupBox1.Controls.Add(Me.Label8)
        Me.UltraGroupBox1.Controls.Add(Me.textDescripcion)
        Me.UltraGroupBox1.Controls.Add(Me.comboGrupoModelo)
        Me.UltraGroupBox1.Controls.Add(Me.comboTipoModelo)
        Me.UltraGroupBox1.Controls.Add(Me.textVA)
        Me.UltraGroupBox1.Controls.Add(Me.comboTA)
        Me.UltraGroupBox1.Controls.Add(Me.comboMA)
        Me.UltraGroupBox1.Controls.Add(Me.comboMT)
        Me.UltraGroupBox1.Controls.Add(Me.textID)
        Me.UltraGroupBox1.Controls.Add(Me.textNom)
        Me.UltraGroupBox1.Controls.Add(Me.Label2)
        Me.UltraGroupBox1.Controls.Add(Me.Label1)
        Me.UltraGroupBox1.Controls.Add(Me.Label6)
        Me.UltraGroupBox1.Controls.Add(Me.Label7)
        Me.UltraGroupBox1.Controls.Add(Me.Label3)
        Me.UltraGroupBox1.Controls.Add(Me.Label9)
        Me.UltraGroupBox1.Controls.Add(Me.Label5)
        Me.UltraGroupBox1.Controls.Add(Me.Label4)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(16, 8)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(784, 192)
        Me.UltraGroupBox1.SupportThemes = False
        Me.UltraGroupBox1.TabIndex = 0
        Me.UltraGroupBox1.Text = "Modelo de fresa"
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(571, 135)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 13)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "(modelo completo)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(520, 136)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 13)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "PRECIO"
        '
        'textPrecioModelo
        '
        Appearance3.ForeColor = System.Drawing.Color.Red
        Me.textPrecioModelo.Appearance = Appearance3
        Me.textPrecioModelo.AutoSize = True
        Me.textPrecioModelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textPrecioModelo.Location = New System.Drawing.Point(520, 152)
        Me.textPrecioModelo.Name = "textPrecioModelo"
        Me.textPrecioModelo.Size = New System.Drawing.Size(104, 26)
        Me.textPrecioModelo.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(50, 128)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Descripción"
        '
        'textDescripcion
        '
        Me.textDescripcion.AutoSize = True
        Me.textDescripcion.Location = New System.Drawing.Point(112, 128)
        Me.textDescripcion.Multiline = True
        Me.textDescripcion.Name = "textDescripcion"
        Me.textDescripcion.Size = New System.Drawing.Size(272, 56)
        Me.textDescripcion.TabIndex = 4
        '
        'comboGrupoModelo
        '
        Me.comboGrupoModelo.AutoSize = True
        ValueListItem1.DataValue = "Fresas rectas"
        ValueListItem2.DataValue = "Fresas con radios"
        ValueListItem3.DataValue = "Fresas para ensambles"
        ValueListItem4.DataValue = "Fresas para machimbres"
        ValueListItem5.DataValue = "Fresas para replanar"
        ValueListItem6.DataValue = "Fresas para moldura y contramoldura"
        ValueListItem7.DataValue = "Fresas para puertas de muebles"
        ValueListItem8.DataValue = "Fresas especiales"
        Me.comboGrupoModelo.Items.Add(ValueListItem1)
        Me.comboGrupoModelo.Items.Add(ValueListItem2)
        Me.comboGrupoModelo.Items.Add(ValueListItem3)
        Me.comboGrupoModelo.Items.Add(ValueListItem4)
        Me.comboGrupoModelo.Items.Add(ValueListItem5)
        Me.comboGrupoModelo.Items.Add(ValueListItem6)
        Me.comboGrupoModelo.Items.Add(ValueListItem7)
        Me.comboGrupoModelo.Items.Add(ValueListItem8)
        Me.comboGrupoModelo.Location = New System.Drawing.Point(112, 104)
        Me.comboGrupoModelo.Name = "comboGrupoModelo"
        Me.comboGrupoModelo.Size = New System.Drawing.Size(224, 21)
        Me.comboGrupoModelo.TabIndex = 3
        '
        'comboTipoModelo
        '
        Me.comboTipoModelo.AutoSize = True
        ValueListItem9.DataValue = "Juego de fresas"
        ValueListItem10.DataValue = "Fresa individual"
        Me.comboTipoModelo.Items.Add(ValueListItem9)
        Me.comboTipoModelo.Items.Add(ValueListItem10)
        Me.comboTipoModelo.Location = New System.Drawing.Point(112, 80)
        Me.comboTipoModelo.Name = "comboTipoModelo"
        Me.comboTipoModelo.Size = New System.Drawing.Size(224, 21)
        Me.comboTipoModelo.TabIndex = 2
        '
        'textVA
        '
        Me.textVA.AutoSize = True
        Me.textVA.Location = New System.Drawing.Point(520, 104)
        Me.textVA.Name = "textVA"
        Me.textVA.Size = New System.Drawing.Size(104, 21)
        Me.textVA.TabIndex = 8
        '
        'comboTA
        '
        Me.comboTA.AutoSize = True
        Me.comboTA.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.comboTA.Location = New System.Drawing.Point(520, 80)
        Me.comboTA.Name = "comboTA"
        Me.comboTA.Size = New System.Drawing.Size(208, 21)
        Me.comboTA.TabIndex = 7
        '
        'comboMA
        '
        Me.comboMA.AutoSize = True
        Me.comboMA.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.comboMA.Location = New System.Drawing.Point(520, 56)
        Me.comboMA.Name = "comboMA"
        Me.comboMA.Size = New System.Drawing.Size(208, 21)
        Me.comboMA.TabIndex = 6
        '
        'comboMT
        '
        Me.comboMT.AutoSize = True
        Me.comboMT.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.comboMT.Location = New System.Drawing.Point(520, 32)
        Me.comboMT.Name = "comboMT"
        Me.comboMT.Size = New System.Drawing.Size(208, 21)
        Me.comboMT.TabIndex = 5
        '
        'textID
        '
        Me.textID.AutoSize = True
        Me.textID.Location = New System.Drawing.Point(112, 32)
        Me.textID.Name = "textID"
        Me.textID.ReadOnly = True
        Me.textID.Size = New System.Drawing.Size(104, 21)
        Me.textID.TabIndex = 0
        '
        'textNom
        '
        Me.textNom.AutoSize = True
        Me.textNom.Location = New System.Drawing.Point(112, 56)
        Me.textNom.Name = "textNom"
        Me.textNom.Size = New System.Drawing.Size(224, 21)
        Me.textNom.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(68, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(94, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "ID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(48, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Tipo modelo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(40, 106)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 13)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Grupo modelo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(413, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Velocidad de avance"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(431, 36)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 13)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Material a trabajar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(433, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 13)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Modo de avance"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(433, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Tipo de acabado"
        '
        'botonFresa
        '
        Me.botonFresa.Location = New System.Drawing.Point(408, 384)
        Me.botonFresa.Name = "botonFresa"
        Me.botonFresa.Size = New System.Drawing.Size(96, 24)
        Me.botonFresa.TabIndex = 3
        Me.botonFresa.Text = "Fresa"
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.TabControl1)
        Me.UltraTabPageControl1.Enabled = False
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(812, 425)
        '
        'TabControl1
        '
        Me.TabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(816, 416)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.UltraButton6)
        Me.TabPage2.Controls.Add(Me.textPlanoTF)
        Me.TabPage2.Controls.Add(Me.UltraButton5)
        Me.TabPage2.Controls.Add(Me.imagen)
        Me.TabPage2.Controls.Add(Me.UltraButton24)
        Me.TabPage2.Controls.Add(Me.UltraButton23)
        Me.TabPage2.Controls.Add(Me.textImagenTF)
        Me.TabPage2.Controls.Add(Me.UltraGroupBox9)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Location = New System.Drawing.Point(4, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(808, 390)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Caracteristicas"
        '
        'UltraButton6
        '
        Me.UltraButton6.Location = New System.Drawing.Point(313, 291)
        Me.UltraButton6.Name = "UltraButton6"
        Me.UltraButton6.Size = New System.Drawing.Size(92, 22)
        Me.UltraButton6.TabIndex = 5
        Me.UltraButton6.Text = "Abrir Corel"
        '
        'textPlanoTF
        '
        Me.textPlanoTF.AutoSize = True
        Me.textPlanoTF.Location = New System.Drawing.Point(75, 263)
        Me.textPlanoTF.Name = "textPlanoTF"
        Me.textPlanoTF.Size = New System.Drawing.Size(228, 21)
        Me.textPlanoTF.TabIndex = 2
        '
        'UltraButton5
        '
        Me.UltraButton5.Location = New System.Drawing.Point(313, 263)
        Me.UltraButton5.Name = "UltraButton5"
        Me.UltraButton5.Size = New System.Drawing.Size(92, 22)
        Me.UltraButton5.TabIndex = 4
        Me.UltraButton5.Text = "Buscar plano"
        '
        'imagen
        '
        Me.imagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imagen.Location = New System.Drawing.Point(417, 213)
        Me.imagen.Name = "imagen"
        Me.imagen.Size = New System.Drawing.Size(357, 169)
        Me.imagen.TabIndex = 25
        Me.imagen.TabStop = False
        '
        'UltraButton24
        '
        Me.UltraButton24.Location = New System.Drawing.Point(312, 360)
        Me.UltraButton24.Name = "UltraButton24"
        Me.UltraButton24.Size = New System.Drawing.Size(93, 22)
        Me.UltraButton24.TabIndex = 6
        Me.UltraButton24.Text = "Siguiente >>"
        '
        'UltraButton23
        '
        Me.UltraButton23.Location = New System.Drawing.Point(313, 235)
        Me.UltraButton23.Name = "UltraButton23"
        Me.UltraButton23.Size = New System.Drawing.Size(92, 22)
        Me.UltraButton23.TabIndex = 3
        Me.UltraButton23.Text = "Buscar imagen"
        '
        'textImagenTF
        '
        Me.textImagenTF.AutoSize = True
        Me.textImagenTF.Location = New System.Drawing.Point(75, 235)
        Me.textImagenTF.Name = "textImagenTF"
        Me.textImagenTF.Size = New System.Drawing.Size(228, 21)
        Me.textImagenTF.TabIndex = 1
        '
        'UltraGroupBox9
        '
        Appearance4.BackColor = System.Drawing.Color.LightSteelBlue
        Me.UltraGroupBox9.ContentAreaAppearance = Appearance4
        Me.UltraGroupBox9.Controls.Add(Me.cantidad)
        Me.UltraGroupBox9.Controls.Add(Me.comboPT)
        Me.UltraGroupBox9.Controls.Add(Me.textCarFresa)
        Me.UltraGroupBox9.Controls.Add(Me.Label29)
        Me.UltraGroupBox9.Controls.Add(Me.Label30)
        Me.UltraGroupBox9.Controls.Add(Me.Label31)
        Me.UltraGroupBox9.Controls.Add(Me.textIDFresa)
        Me.UltraGroupBox9.Controls.Add(Me.textCantDien)
        Me.UltraGroupBox9.Controls.Add(Me.textDiamAgu)
        Me.UltraGroupBox9.Controls.Add(Me.textDiamExt)
        Me.UltraGroupBox9.Controls.Add(Me.textNombreFresa)
        Me.UltraGroupBox9.Controls.Add(Me.Label32)
        Me.UltraGroupBox9.Controls.Add(Me.Label33)
        Me.UltraGroupBox9.Controls.Add(Me.Label34)
        Me.UltraGroupBox9.Controls.Add(Me.Label35)
        Me.UltraGroupBox9.Controls.Add(Me.Label36)
        Me.UltraGroupBox9.Controls.Add(Me.Label37)
        Me.UltraGroupBox9.Controls.Add(Me.Label38)
        Me.UltraGroupBox9.Controls.Add(Me.Label12)
        Me.UltraGroupBox9.Location = New System.Drawing.Point(32, 24)
        Me.UltraGroupBox9.Name = "UltraGroupBox9"
        Me.UltraGroupBox9.Size = New System.Drawing.Size(744, 182)
        Me.UltraGroupBox9.SupportThemes = False
        Me.UltraGroupBox9.TabIndex = 0
        Me.UltraGroupBox9.Text = "Fresa individual"
        Me.UltraGroupBox9.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'cantidad
        '
        Me.cantidad.Location = New System.Drawing.Point(128, 152)
        Me.cantidad.Name = "cantidad"
        Me.cantidad.Size = New System.Drawing.Size(66, 20)
        Me.cantidad.TabIndex = 6
        Me.cantidad.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'comboPT
        '
        Me.comboPT.AutoSize = True
        ValueListItem11.DataValue = "De arriba"
        ValueListItem12.DataValue = "De abajo"
        ValueListItem13.DataValue = "Mitad"
        ValueListItem14.DataValue = "De arriba y de abajo"
        Me.comboPT.Items.Add(ValueListItem11)
        Me.comboPT.Items.Add(ValueListItem12)
        Me.comboPT.Items.Add(ValueListItem13)
        Me.comboPT.Items.Add(ValueListItem14)
        Me.comboPT.Location = New System.Drawing.Point(512, 32)
        Me.comboPT.Name = "comboPT"
        Me.comboPT.Size = New System.Drawing.Size(185, 21)
        Me.comboPT.TabIndex = 7
        '
        'textCarFresa
        '
        Me.textCarFresa.AutoSize = True
        Me.textCarFresa.Location = New System.Drawing.Point(416, 78)
        Me.textCarFresa.Multiline = True
        Me.textCarFresa.Name = "textCarFresa"
        Me.textCarFresa.Size = New System.Drawing.Size(310, 79)
        Me.textCarFresa.TabIndex = 8
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Location = New System.Drawing.Point(232, 131)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(50, 13)
        Me.Label29.TabIndex = 26
        Me.Label29.Text = "unidades"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Location = New System.Drawing.Point(232, 106)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(26, 13)
        Me.Label30.TabIndex = 25
        Me.Label30.Text = "mm."
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.Location = New System.Drawing.Point(232, 83)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(26, 13)
        Me.Label31.TabIndex = 24
        Me.Label31.Text = "mm."
        '
        'textIDFresa
        '
        Me.textIDFresa.AutoSize = True
        Me.textIDFresa.Location = New System.Drawing.Point(128, 32)
        Me.textIDFresa.Name = "textIDFresa"
        Me.textIDFresa.Size = New System.Drawing.Size(104, 21)
        Me.textIDFresa.TabIndex = 0
        '
        'textCantDien
        '
        Me.textCantDien.AutoSize = True
        Me.textCantDien.Location = New System.Drawing.Point(128, 128)
        Me.textCantDien.Name = "textCantDien"
        Me.textCantDien.Size = New System.Drawing.Size(104, 21)
        Me.textCantDien.TabIndex = 4
        '
        'textDiamAgu
        '
        Me.textDiamAgu.AutoSize = True
        Me.textDiamAgu.Location = New System.Drawing.Point(128, 104)
        Me.textDiamAgu.Name = "textDiamAgu"
        Me.textDiamAgu.Size = New System.Drawing.Size(104, 21)
        Me.textDiamAgu.TabIndex = 3
        '
        'textDiamExt
        '
        Me.textDiamExt.AutoSize = True
        Me.textDiamExt.Location = New System.Drawing.Point(128, 80)
        Me.textDiamExt.Name = "textDiamExt"
        Me.textDiamExt.Size = New System.Drawing.Size(104, 21)
        Me.textDiamExt.TabIndex = 2
        '
        'textNombreFresa
        '
        Me.textNombreFresa.AutoSize = True
        Me.textNombreFresa.Location = New System.Drawing.Point(128, 56)
        Me.textNombreFresa.Name = "textNombreFresa"
        Me.textNombreFresa.Size = New System.Drawing.Size(224, 21)
        Me.textNombreFresa.TabIndex = 1
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Location = New System.Drawing.Point(43, 108)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(87, 13)
        Me.Label32.TabIndex = 22
        Me.Label32.Text = "Diametro agujero"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.Location = New System.Drawing.Point(44, 84)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(86, 13)
        Me.Label33.TabIndex = 21
        Me.Label33.Text = "Diametro exterior"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.BackColor = System.Drawing.Color.Transparent
        Me.Label34.Location = New System.Drawing.Point(86, 60)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(44, 13)
        Me.Label34.TabIndex = 20
        Me.Label34.Text = "Nombre"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.BackColor = System.Drawing.Color.Transparent
        Me.Label35.Location = New System.Drawing.Point(29, 132)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(101, 13)
        Me.Label35.TabIndex = 23
        Me.Label35.Text = "Cantidad de dientes"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.BackColor = System.Drawing.Color.Transparent
        Me.Label36.Location = New System.Drawing.Point(112, 37)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(18, 13)
        Me.Label36.TabIndex = 19
        Me.Label36.Text = "ID"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.BackColor = System.Drawing.Color.Transparent
        Me.Label37.Location = New System.Drawing.Point(416, 35)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(97, 13)
        Me.Label37.TabIndex = 29
        Me.Label37.Text = "Posición de trabajo"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.BackColor = System.Drawing.Color.Transparent
        Me.Label38.Location = New System.Drawing.Point(415, 62)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(132, 13)
        Me.Label38.TabIndex = 30
        Me.Label38.Text = "Caracteristicas adicionales"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(17, 156)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(112, 13)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Cantidad en el modelo"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(34, 238)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(42, 13)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Imagen"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Location = New System.Drawing.Point(41, 266)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(34, 13)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "Plano"
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.UltraButton19)
        Me.TabPage1.Controls.Add(Me.UltraButton20)
        Me.TabPage1.Controls.Add(Me.UltraGroupBox11)
        Me.TabPage1.Controls.Add(Me.UltraGroupBox10)
        Me.TabPage1.Location = New System.Drawing.Point(4, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(808, 390)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Partes"
        '
        'UltraButton19
        '
        Me.UltraButton19.Location = New System.Drawing.Point(571, 362)
        Me.UltraButton19.Name = "UltraButton19"
        Me.UltraButton19.Size = New System.Drawing.Size(88, 24)
        Me.UltraButton19.TabIndex = 5
        Me.UltraButton19.Text = "<< Atras"
        '
        'UltraButton20
        '
        Me.UltraButton20.Location = New System.Drawing.Point(668, 362)
        Me.UltraButton20.Name = "UltraButton20"
        Me.UltraButton20.Size = New System.Drawing.Size(88, 24)
        Me.UltraButton20.TabIndex = 4
        Me.UltraButton20.Text = "Siguiente >>"
        '
        'UltraGroupBox11
        '
        Appearance5.BackColor = System.Drawing.Color.LightSteelBlue
        Me.UltraGroupBox11.ContentAreaAppearance = Appearance5
        Me.UltraGroupBox11.Controls.Add(Me.UltraButton15)
        Me.UltraGroupBox11.Controls.Add(Me.lista3)
        Me.UltraGroupBox11.Location = New System.Drawing.Point(52, 208)
        Me.UltraGroupBox11.Name = "UltraGroupBox11"
        Me.UltraGroupBox11.Size = New System.Drawing.Size(704, 152)
        Me.UltraGroupBox11.SupportThemes = False
        Me.UltraGroupBox11.TabIndex = 2
        Me.UltraGroupBox11.Text = "Partes agregadas"
        Me.UltraGroupBox11.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'UltraButton15
        '
        Me.UltraButton15.Location = New System.Drawing.Point(536, 104)
        Me.UltraButton15.Name = "UltraButton15"
        Me.UltraButton15.Size = New System.Drawing.Size(72, 32)
        Me.UltraButton15.TabIndex = 1
        Me.UltraButton15.Text = "Eliminar"
        '
        'lista3
        '
        Me.lista3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lista3.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader21, Me.ColumnHeader22, Me.ColumnHeader23, Me.ColumnHeader24, Me.ColumnHeader25})
        Me.lista3.FullRowSelect = True
        Me.lista3.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lista3.Location = New System.Drawing.Point(32, 32)
        Me.lista3.Name = "lista3"
        Me.lista3.Size = New System.Drawing.Size(488, 104)
        Me.lista3.TabIndex = 0
        Me.lista3.UseCompatibleStateImageBehavior = False
        Me.lista3.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader21
        '
        Me.ColumnHeader21.Text = "ID parte"
        Me.ColumnHeader21.Width = 86
        '
        'ColumnHeader22
        '
        Me.ColumnHeader22.Text = "Nombre"
        Me.ColumnHeader22.Width = 124
        '
        'ColumnHeader23
        '
        Me.ColumnHeader23.Text = "ID MP"
        '
        'ColumnHeader24
        '
        Me.ColumnHeader24.Text = "Materia prima"
        Me.ColumnHeader24.Width = 146
        '
        'ColumnHeader25
        '
        Me.ColumnHeader25.Text = "Cantidad"
        Me.ColumnHeader25.Width = 71
        '
        'UltraGroupBox10
        '
        Appearance6.BackColor = System.Drawing.Color.LightSteelBlue
        Me.UltraGroupBox10.ContentAreaAppearance = Appearance6
        Me.UltraGroupBox10.Controls.Add(Me.UltraButton14)
        Me.UltraGroupBox10.Controls.Add(Me.textCantidad)
        Me.UltraGroupBox10.Controls.Add(Me.textIDParte)
        Me.UltraGroupBox10.Controls.Add(Me.Label39)
        Me.UltraGroupBox10.Controls.Add(Me.comboNParte)
        Me.UltraGroupBox10.Controls.Add(Me.Label40)
        Me.UltraGroupBox10.Controls.Add(Me.textDescParte)
        Me.UltraGroupBox10.Controls.Add(Me.Label41)
        Me.UltraGroupBox10.Controls.Add(Me.comboMatPrim)
        Me.UltraGroupBox10.Controls.Add(Me.Label42)
        Me.UltraGroupBox10.Controls.Add(Me.Label43)
        Me.UltraGroupBox10.Controls.Add(Me.lblUnidadDeMedida)
        Me.UltraGroupBox10.Location = New System.Drawing.Point(52, 8)
        Me.UltraGroupBox10.Name = "UltraGroupBox10"
        Me.UltraGroupBox10.Size = New System.Drawing.Size(704, 192)
        Me.UltraGroupBox10.SupportThemes = False
        Me.UltraGroupBox10.TabIndex = 1
        Me.UltraGroupBox10.Text = "Parte de fresa"
        Me.UltraGroupBox10.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'UltraButton14
        '
        Me.UltraButton14.Location = New System.Drawing.Point(408, 144)
        Me.UltraButton14.Name = "UltraButton14"
        Me.UltraButton14.Size = New System.Drawing.Size(72, 32)
        Me.UltraButton14.TabIndex = 5
        Me.UltraButton14.Text = "Agregar"
        '
        'textCantidad
        '
        Me.textCantidad.AutoSize = True
        Me.textCantidad.Location = New System.Drawing.Point(392, 56)
        Me.textCantidad.Name = "textCantidad"
        Me.textCantidad.Size = New System.Drawing.Size(112, 21)
        Me.textCantidad.TabIndex = 3
        '
        'textIDParte
        '
        Me.textIDParte.AutoSize = True
        Me.textIDParte.Location = New System.Drawing.Point(72, 32)
        Me.textIDParte.Name = "textIDParte"
        Me.textIDParte.Size = New System.Drawing.Size(104, 21)
        Me.textIDParte.TabIndex = 0
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.BackColor = System.Drawing.Color.Transparent
        Me.Label39.Location = New System.Drawing.Point(29, 60)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(44, 13)
        Me.Label39.TabIndex = 19
        Me.Label39.Text = "Nombre"
        '
        'comboNParte
        '
        Me.comboNParte.AutoSize = True
        Me.comboNParte.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.comboNParte.Location = New System.Drawing.Point(72, 56)
        Me.comboNParte.Name = "comboNParte"
        Me.comboNParte.Size = New System.Drawing.Size(192, 21)
        Me.comboNParte.TabIndex = 1
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.BackColor = System.Drawing.Color.Transparent
        Me.Label40.Location = New System.Drawing.Point(29, 36)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(45, 13)
        Me.Label40.TabIndex = 17
        Me.Label40.Text = "ID parte"
        '
        'textDescParte
        '
        Me.textDescParte.AutoSize = True
        Me.textDescParte.Location = New System.Drawing.Point(72, 104)
        Me.textDescParte.Multiline = True
        Me.textDescParte.Name = "textDescParte"
        Me.textDescParte.Size = New System.Drawing.Size(320, 72)
        Me.textDescParte.TabIndex = 4
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.BackColor = System.Drawing.Color.Transparent
        Me.Label41.Location = New System.Drawing.Point(72, 88)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(63, 13)
        Me.Label41.TabIndex = 24
        Me.Label41.Text = "Descripción"
        '
        'comboMatPrim
        '
        Me.comboMatPrim.AutoSize = True
        Me.comboMatPrim.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.comboMatPrim.Location = New System.Drawing.Point(392, 32)
        Me.comboMatPrim.Name = "comboMatPrim"
        Me.comboMatPrim.Size = New System.Drawing.Size(248, 21)
        Me.comboMatPrim.TabIndex = 2
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.BackColor = System.Drawing.Color.Transparent
        Me.Label42.Location = New System.Drawing.Point(344, 61)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(49, 13)
        Me.Label42.TabIndex = 21
        Me.Label42.Text = "Cantidad"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.BackColor = System.Drawing.Color.Transparent
        Me.Label43.Location = New System.Drawing.Point(323, 37)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(70, 13)
        Me.Label43.TabIndex = 20
        Me.Label43.Text = "Materia prima"
        '
        'lblUnidadDeMedida
        '
        Me.lblUnidadDeMedida.AutoSize = True
        Me.lblUnidadDeMedida.BackColor = System.Drawing.Color.Transparent
        Me.lblUnidadDeMedida.Location = New System.Drawing.Point(506, 60)
        Me.lblUnidadDeMedida.Name = "lblUnidadDeMedida"
        Me.lblUnidadDeMedida.Size = New System.Drawing.Size(41, 13)
        Me.lblUnidadDeMedida.TabIndex = 23
        Me.lblUnidadDeMedida.Text = "gramos"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.UltraButton11)
        Me.TabPage3.Controls.Add(Me.UltraButton21)
        Me.TabPage3.Controls.Add(Me.UltraButton22)
        Me.TabPage3.Controls.Add(Me.UltraGroupBox14)
        Me.TabPage3.Controls.Add(Me.UltraGroupBox13)
        Me.TabPage3.Controls.Add(Me.UltraGroupBox12)
        Me.TabPage3.Location = New System.Drawing.Point(4, 4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(808, 390)
        Me.TabPage3.TabIndex = 3
        Me.TabPage3.Text = "Fabricacion y precio final"
        '
        'UltraButton11
        '
        Me.UltraButton11.Location = New System.Drawing.Point(592, 363)
        Me.UltraButton11.Name = "UltraButton11"
        Me.UltraButton11.Size = New System.Drawing.Size(88, 24)
        Me.UltraButton11.TabIndex = 15
        Me.UltraButton11.Text = "Cancelar"
        '
        'UltraButton21
        '
        Me.UltraButton21.Location = New System.Drawing.Point(500, 363)
        Me.UltraButton21.Name = "UltraButton21"
        Me.UltraButton21.Size = New System.Drawing.Size(88, 24)
        Me.UltraButton21.TabIndex = 14
        Me.UltraButton21.Text = "<< Atras"
        '
        'UltraButton22
        '
        Me.UltraButton22.Location = New System.Drawing.Point(684, 363)
        Me.UltraButton22.Name = "UltraButton22"
        Me.UltraButton22.Size = New System.Drawing.Size(88, 24)
        Me.UltraButton22.TabIndex = 13
        Me.UltraButton22.Text = "Guardar"
        '
        'UltraGroupBox14
        '
        Appearance7.BackColor = System.Drawing.Color.LightSteelBlue
        Me.UltraGroupBox14.ContentAreaAppearance = Appearance7
        Me.UltraGroupBox14.Controls.Add(Me.textPrecioTF)
        Me.UltraGroupBox14.Controls.Add(Me.Label51)
        Me.UltraGroupBox14.Controls.Add(Me.btnCalcularCosto)
        Me.UltraGroupBox14.Controls.Add(Me.Label52)
        Me.UltraGroupBox14.Controls.Add(Me.textCostoTF)
        Me.UltraGroupBox14.Controls.Add(Me.Label53)
        Me.UltraGroupBox14.Location = New System.Drawing.Point(556, 192)
        Me.UltraGroupBox14.Name = "UltraGroupBox14"
        Me.UltraGroupBox14.Size = New System.Drawing.Size(216, 168)
        Me.UltraGroupBox14.SupportThemes = False
        Me.UltraGroupBox14.TabIndex = 12
        Me.UltraGroupBox14.Text = "Precio final"
        Me.UltraGroupBox14.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'textPrecioTF
        '
        Appearance8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.textPrecioTF.Appearance = Appearance8
        Me.textPrecioTF.AutoSize = True
        Me.textPrecioTF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textPrecioTF.Location = New System.Drawing.Point(40, 136)
        Me.textPrecioTF.Name = "textPrecioTF"
        Me.textPrecioTF.Size = New System.Drawing.Size(128, 23)
        Me.textPrecioTF.TabIndex = 7
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.BackColor = System.Drawing.Color.Transparent
        Me.Label51.Location = New System.Drawing.Point(2, 87)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(49, 13)
        Me.Label51.TabIndex = 6
        Me.Label51.Text = "Costo ($)"
        '
        'btnCalcularCosto
        '
        Me.btnCalcularCosto.Location = New System.Drawing.Point(143, 82)
        Me.btnCalcularCosto.Name = "btnCalcularCosto"
        Me.btnCalcularCosto.Size = New System.Drawing.Size(64, 24)
        Me.btnCalcularCosto.TabIndex = 5
        Me.btnCalcularCosto.Text = "Calcular"
        '
        'Label52
        '
        Me.Label52.BackColor = System.Drawing.Color.Transparent
        Me.Label52.Location = New System.Drawing.Point(16, 24)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(152, 56)
        Me.Label52.TabIndex = 4
        Me.Label52.Text = "El costo estimado incluye: costos de materia prima para cada parte y costos de fa" & _
            "bricación para cada etapa."
        '
        'textCostoTF
        '
        Appearance9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.textCostoTF.Appearance = Appearance9
        Me.textCostoTF.AutoSize = True
        Me.textCostoTF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textCostoTF.Location = New System.Drawing.Point(52, 83)
        Me.textCostoTF.Name = "textCostoTF"
        Me.textCostoTF.Size = New System.Drawing.Size(88, 23)
        Me.textCostoTF.TabIndex = 3
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.BackColor = System.Drawing.Color.Transparent
        Me.Label53.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.Location = New System.Drawing.Point(37, 118)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(105, 20)
        Me.Label53.TabIndex = 8
        Me.Label53.Text = "Precio final"
        '
        'UltraGroupBox13
        '
        Appearance10.BackColor = System.Drawing.Color.LightSteelBlue
        Me.UltraGroupBox13.ContentAreaAppearance = Appearance10
        Me.UltraGroupBox13.Controls.Add(Me.UltraButton17)
        Me.UltraGroupBox13.Controls.Add(Me.lista4)
        Me.UltraGroupBox13.Location = New System.Drawing.Point(36, 192)
        Me.UltraGroupBox13.Name = "UltraGroupBox13"
        Me.UltraGroupBox13.Size = New System.Drawing.Size(504, 168)
        Me.UltraGroupBox13.SupportThemes = False
        Me.UltraGroupBox13.TabIndex = 4
        Me.UltraGroupBox13.Text = "Etapas agregadas"
        Me.UltraGroupBox13.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'UltraButton17
        '
        Me.UltraButton17.Location = New System.Drawing.Point(424, 120)
        Me.UltraButton17.Name = "UltraButton17"
        Me.UltraButton17.Size = New System.Drawing.Size(72, 32)
        Me.UltraButton17.TabIndex = 10
        Me.UltraButton17.Text = "Eliminar"
        '
        'lista4
        '
        Me.lista4.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader26, Me.ColumnHeader27, Me.ColumnHeader28, Me.ColumnHeader29, Me.ColumnHeader30})
        Me.lista4.FullRowSelect = True
        Me.lista4.Location = New System.Drawing.Point(16, 32)
        Me.lista4.Name = "lista4"
        Me.lista4.Size = New System.Drawing.Size(400, 120)
        Me.lista4.TabIndex = 0
        Me.lista4.UseCompatibleStateImageBehavior = False
        Me.lista4.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader26
        '
        Me.ColumnHeader26.Text = "ID etapa"
        Me.ColumnHeader26.Width = 54
        '
        'ColumnHeader27
        '
        Me.ColumnHeader27.Text = "ID operación"
        Me.ColumnHeader27.Width = 76
        '
        'ColumnHeader28
        '
        Me.ColumnHeader28.Text = "Operación"
        Me.ColumnHeader28.Width = 124
        '
        'ColumnHeader29
        '
        Me.ColumnHeader29.Text = "Órden"
        Me.ColumnHeader29.Width = 45
        '
        'ColumnHeader30
        '
        Me.ColumnHeader30.Text = "Tiempo adicional"
        Me.ColumnHeader30.Width = 96
        '
        'UltraGroupBox12
        '
        Appearance11.BackColor = System.Drawing.Color.LightSteelBlue
        Me.UltraGroupBox12.ContentAreaAppearance = Appearance11
        Me.UltraGroupBox12.Controls.Add(Me.Label45)
        Me.UltraGroupBox12.Controls.Add(Me.UltraButton16)
        Me.UltraGroupBox12.Controls.Add(Me.orden)
        Me.UltraGroupBox12.Controls.Add(Me.textTiempo)
        Me.UltraGroupBox12.Controls.Add(Me.Label46)
        Me.UltraGroupBox12.Controls.Add(Me.textDetalles)
        Me.UltraGroupBox12.Controls.Add(Me.Label47)
        Me.UltraGroupBox12.Controls.Add(Me.Label48)
        Me.UltraGroupBox12.Controls.Add(Me.Label49)
        Me.UltraGroupBox12.Controls.Add(Me.textIDEtapa)
        Me.UltraGroupBox12.Controls.Add(Me.comboOperacion)
        Me.UltraGroupBox12.Controls.Add(Me.Label50)
        Me.UltraGroupBox12.Location = New System.Drawing.Point(36, 16)
        Me.UltraGroupBox12.Name = "UltraGroupBox12"
        Me.UltraGroupBox12.Size = New System.Drawing.Size(736, 168)
        Me.UltraGroupBox12.SupportThemes = False
        Me.UltraGroupBox12.TabIndex = 3
        Me.UltraGroupBox12.Text = "Etapa de fabricación"
        Me.UltraGroupBox12.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.BackColor = System.Drawing.Color.Transparent
        Me.Label45.Location = New System.Drawing.Point(544, 60)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(43, 13)
        Me.Label45.TabIndex = 10
        Me.Label45.Text = "minutos"
        '
        'UltraButton16
        '
        Me.UltraButton16.Location = New System.Drawing.Point(528, 128)
        Me.UltraButton16.Name = "UltraButton16"
        Me.UltraButton16.Size = New System.Drawing.Size(72, 32)
        Me.UltraButton16.TabIndex = 9
        Me.UltraButton16.Text = "Agregar"
        '
        'orden
        '
        Me.orden.Location = New System.Drawing.Point(440, 32)
        Me.orden.Name = "orden"
        Me.orden.Size = New System.Drawing.Size(72, 20)
        Me.orden.TabIndex = 3
        Me.orden.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'textTiempo
        '
        Me.textTiempo.AutoSize = True
        Me.textTiempo.Location = New System.Drawing.Point(440, 56)
        Me.textTiempo.Name = "textTiempo"
        Me.textTiempo.Size = New System.Drawing.Size(104, 21)
        Me.textTiempo.TabIndex = 5
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.BackColor = System.Drawing.Color.Transparent
        Me.Label46.Location = New System.Drawing.Point(80, 88)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(45, 13)
        Me.Label46.TabIndex = 8
        Me.Label46.Text = "Detalles"
        '
        'textDetalles
        '
        Me.textDetalles.AutoSize = True
        Me.textDetalles.Location = New System.Drawing.Point(80, 104)
        Me.textDetalles.Multiline = True
        Me.textDetalles.Name = "textDetalles"
        Me.textDetalles.Size = New System.Drawing.Size(440, 56)
        Me.textDetalles.TabIndex = 7
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.BackColor = System.Drawing.Color.Transparent
        Me.Label47.Location = New System.Drawing.Point(354, 60)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(87, 13)
        Me.Label47.TabIndex = 6
        Me.Label47.Text = "Tiempo adicional"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.BackColor = System.Drawing.Color.Transparent
        Me.Label48.Location = New System.Drawing.Point(404, 35)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(36, 13)
        Me.Label48.TabIndex = 4
        Me.Label48.Text = "Orden"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.BackColor = System.Drawing.Color.Transparent
        Me.Label49.Location = New System.Drawing.Point(33, 32)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(48, 13)
        Me.Label49.TabIndex = 3
        Me.Label49.Text = "ID etapa"
        '
        'textIDEtapa
        '
        Me.textIDEtapa.AutoSize = True
        Me.textIDEtapa.Location = New System.Drawing.Point(80, 29)
        Me.textIDEtapa.Name = "textIDEtapa"
        Me.textIDEtapa.Size = New System.Drawing.Size(104, 21)
        Me.textIDEtapa.TabIndex = 2
        '
        'comboOperacion
        '
        Me.comboOperacion.AutoSize = True
        Me.comboOperacion.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.comboOperacion.Location = New System.Drawing.Point(80, 56)
        Me.comboOperacion.Name = "comboOperacion"
        Me.comboOperacion.Size = New System.Drawing.Size(208, 21)
        Me.comboOperacion.TabIndex = 0
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.BackColor = System.Drawing.Color.Transparent
        Me.Label50.Location = New System.Drawing.Point(25, 58)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(56, 13)
        Me.Label50.TabIndex = 1
        Me.Label50.Text = "Operación"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.UltraButton12)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraButton9)
        Me.UltraTabPageControl2.Controls.Add(Me.imagen2)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraGroupBox5)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraGroupBox4)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraGroupBox2)
        Me.UltraTabPageControl2.Enabled = False
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(2, 21)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(812, 425)
        '
        'UltraButton12
        '
        Me.UltraButton12.Location = New System.Drawing.Point(589, 391)
        Me.UltraButton12.Name = "UltraButton12"
        Me.UltraButton12.Size = New System.Drawing.Size(88, 24)
        Me.UltraButton12.TabIndex = 16
        Me.UltraButton12.Text = "Cancelar"
        '
        'UltraButton9
        '
        Me.UltraButton9.Location = New System.Drawing.Point(681, 390)
        Me.UltraButton9.Name = "UltraButton9"
        Me.UltraButton9.Size = New System.Drawing.Size(96, 24)
        Me.UltraButton9.TabIndex = 3
        Me.UltraButton9.Text = "Guardar"
        '
        'imagen2
        '
        Me.imagen2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.imagen2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imagen2.Location = New System.Drawing.Point(464, 176)
        Me.imagen2.Name = "imagen2"
        Me.imagen2.Size = New System.Drawing.Size(312, 208)
        Me.imagen2.TabIndex = 5
        Me.imagen2.TabStop = False
        '
        'UltraGroupBox5
        '
        Appearance12.BackColor = System.Drawing.Color.LightSteelBlue
        Me.UltraGroupBox5.ContentAreaAppearance = Appearance12
        Me.UltraGroupBox5.Controls.Add(Me.UltraButton8)
        Me.UltraGroupBox5.Controls.Add(Me.UltraButton7)
        Me.UltraGroupBox5.Controls.Add(Me.textImagenA)
        Me.UltraGroupBox5.Controls.Add(Me.textPlanoA)
        Me.UltraGroupBox5.Controls.Add(Me.textTiempoAdicional)
        Me.UltraGroupBox5.Controls.Add(Me.Label23)
        Me.UltraGroupBox5.Controls.Add(Me.Label25)
        Me.UltraGroupBox5.Controls.Add(Me.Label17)
        Me.UltraGroupBox5.Location = New System.Drawing.Point(34, 272)
        Me.UltraGroupBox5.Name = "UltraGroupBox5"
        Me.UltraGroupBox5.Size = New System.Drawing.Size(406, 112)
        Me.UltraGroupBox5.SupportThemes = False
        Me.UltraGroupBox5.TabIndex = 2
        Me.UltraGroupBox5.Text = "Fabricación"
        Me.UltraGroupBox5.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'UltraButton8
        '
        Me.UltraButton8.Location = New System.Drawing.Point(328, 79)
        Me.UltraButton8.Name = "UltraButton8"
        Me.UltraButton8.Size = New System.Drawing.Size(56, 24)
        Me.UltraButton8.TabIndex = 6
        Me.UltraButton8.Text = "Buscar"
        '
        'UltraButton7
        '
        Me.UltraButton7.Location = New System.Drawing.Point(328, 54)
        Me.UltraButton7.Name = "UltraButton7"
        Me.UltraButton7.Size = New System.Drawing.Size(56, 24)
        Me.UltraButton7.TabIndex = 5
        Me.UltraButton7.Text = "Buscar"
        '
        'textImagenA
        '
        Me.textImagenA.AutoSize = True
        Me.textImagenA.Location = New System.Drawing.Point(56, 80)
        Me.textImagenA.Name = "textImagenA"
        Me.textImagenA.Size = New System.Drawing.Size(264, 21)
        Me.textImagenA.TabIndex = 3
        '
        'textPlanoA
        '
        Me.textPlanoA.AutoSize = True
        Me.textPlanoA.Location = New System.Drawing.Point(56, 56)
        Me.textPlanoA.Name = "textPlanoA"
        Me.textPlanoA.Size = New System.Drawing.Size(264, 21)
        Me.textPlanoA.TabIndex = 2
        '
        'textTiempoAdicional
        '
        Me.textTiempoAdicional.AutoSize = True
        Me.textTiempoAdicional.Location = New System.Drawing.Point(149, 31)
        Me.textTiempoAdicional.Name = "textTiempoAdicional"
        Me.textTiempoAdicional.Size = New System.Drawing.Size(104, 21)
        Me.textTiempoAdicional.TabIndex = 1
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Location = New System.Drawing.Point(23, 59)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(34, 13)
        Me.Label23.TabIndex = 36
        Me.Label23.Text = "Plano"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Location = New System.Drawing.Point(16, 34)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(132, 13)
        Me.Label25.TabIndex = 35
        Me.Label25.Text = "Tiempo fabricación (horas)"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Location = New System.Drawing.Point(15, 83)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(42, 13)
        Me.Label17.TabIndex = 39
        Me.Label17.Text = "Imagen"
        '
        'UltraGroupBox4
        '
        Appearance13.BackColor = System.Drawing.Color.LightSteelBlue
        Me.UltraGroupBox4.ContentAreaAppearance = Appearance13
        Me.UltraGroupBox4.Controls.Add(Me.comboMPAdicional)
        Me.UltraGroupBox4.Controls.Add(Me.lblUmParteAdicional)
        Me.UltraGroupBox4.Controls.Add(Me.textCantMPAdicional)
        Me.UltraGroupBox4.Controls.Add(Me.Label18)
        Me.UltraGroupBox4.Controls.Add(Me.Label19)
        Me.UltraGroupBox4.Location = New System.Drawing.Point(34, 176)
        Me.UltraGroupBox4.Name = "UltraGroupBox4"
        Me.UltraGroupBox4.Size = New System.Drawing.Size(406, 88)
        Me.UltraGroupBox4.SupportThemes = False
        Me.UltraGroupBox4.TabIndex = 1
        Me.UltraGroupBox4.Text = "Composición"
        Me.UltraGroupBox4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'comboMPAdicional
        '
        Me.comboMPAdicional.AutoSize = True
        Me.comboMPAdicional.Location = New System.Drawing.Point(88, 32)
        Me.comboMPAdicional.Name = "comboMPAdicional"
        Me.comboMPAdicional.Size = New System.Drawing.Size(216, 21)
        Me.comboMPAdicional.TabIndex = 0
        '
        'lblUmParteAdicional
        '
        Me.lblUmParteAdicional.AutoSize = True
        Me.lblUmParteAdicional.BackColor = System.Drawing.Color.Transparent
        Me.lblUmParteAdicional.Location = New System.Drawing.Point(192, 59)
        Me.lblUmParteAdicional.Name = "lblUmParteAdicional"
        Me.lblUmParteAdicional.Size = New System.Drawing.Size(41, 13)
        Me.lblUmParteAdicional.TabIndex = 37
        Me.lblUmParteAdicional.Text = "gramos"
        '
        'textCantMPAdicional
        '
        Me.textCantMPAdicional.AutoSize = True
        Me.textCantMPAdicional.Location = New System.Drawing.Point(88, 56)
        Me.textCantMPAdicional.Name = "textCantMPAdicional"
        Me.textCantMPAdicional.Size = New System.Drawing.Size(104, 21)
        Me.textCantMPAdicional.TabIndex = 1
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Location = New System.Drawing.Point(41, 59)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(49, 13)
        Me.Label18.TabIndex = 36
        Me.Label18.Text = "Cantidad"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Location = New System.Drawing.Point(19, 34)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(70, 13)
        Me.Label19.TabIndex = 35
        Me.Label19.Text = "Materia prima"
        '
        'UltraGroupBox2
        '
        Appearance14.BackColor = System.Drawing.Color.LightSteelBlue
        Me.UltraGroupBox2.ContentAreaAppearance = Appearance14
        Me.UltraGroupBox2.Controls.Add(Me.textPrecioAdicional)
        Me.UltraGroupBox2.Controls.Add(Me.comboNombre)
        Me.UltraGroupBox2.Controls.Add(Me.textDescAdicional)
        Me.UltraGroupBox2.Controls.Add(Me.textIDAdicional)
        Me.UltraGroupBox2.Controls.Add(Me.textCostoAdicional)
        Me.UltraGroupBox2.Controls.Add(Me.Label20)
        Me.UltraGroupBox2.Controls.Add(Me.Label21)
        Me.UltraGroupBox2.Controls.Add(Me.Label22)
        Me.UltraGroupBox2.Controls.Add(Me.Label24)
        Me.UltraGroupBox2.Controls.Add(Me.Label16)
        Me.UltraGroupBox2.Location = New System.Drawing.Point(34, 32)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(744, 136)
        Me.UltraGroupBox2.SupportThemes = False
        Me.UltraGroupBox2.TabIndex = 0
        Me.UltraGroupBox2.Text = "General"
        Me.UltraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'textPrecioAdicional
        '
        Me.textPrecioAdicional.AutoSize = True
        Me.textPrecioAdicional.Location = New System.Drawing.Point(128, 104)
        Me.textPrecioAdicional.Name = "textPrecioAdicional"
        Me.textPrecioAdicional.Size = New System.Drawing.Size(104, 21)
        Me.textPrecioAdicional.TabIndex = 4
        '
        'comboNombre
        '
        Me.comboNombre.AutoSize = True
        ValueListItem15.DataValue = "Buje"
        ValueListItem16.DataValue = "Separador"
        ValueListItem17.DataValue = "Tope"
        Me.comboNombre.Items.Add(ValueListItem15)
        Me.comboNombre.Items.Add(ValueListItem16)
        Me.comboNombre.Items.Add(ValueListItem17)
        Me.comboNombre.Location = New System.Drawing.Point(128, 56)
        Me.comboNombre.Name = "comboNombre"
        Me.comboNombre.Size = New System.Drawing.Size(185, 21)
        Me.comboNombre.TabIndex = 2
        '
        'textDescAdicional
        '
        Me.textDescAdicional.AutoSize = True
        Me.textDescAdicional.Location = New System.Drawing.Point(416, 46)
        Me.textDescAdicional.Multiline = True
        Me.textDescAdicional.Name = "textDescAdicional"
        Me.textDescAdicional.Size = New System.Drawing.Size(310, 79)
        Me.textDescAdicional.TabIndex = 5
        '
        'textIDAdicional
        '
        Me.textIDAdicional.AutoSize = True
        Me.textIDAdicional.Location = New System.Drawing.Point(128, 32)
        Me.textIDAdicional.Name = "textIDAdicional"
        Me.textIDAdicional.ReadOnly = True
        Me.textIDAdicional.Size = New System.Drawing.Size(104, 21)
        Me.textIDAdicional.TabIndex = 1
        '
        'textCostoAdicional
        '
        Me.textCostoAdicional.AutoSize = True
        Me.textCostoAdicional.Location = New System.Drawing.Point(128, 80)
        Me.textCostoAdicional.Name = "textCostoAdicional"
        Me.textCostoAdicional.Size = New System.Drawing.Size(104, 21)
        Me.textCostoAdicional.TabIndex = 3
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Location = New System.Drawing.Point(86, 60)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(44, 13)
        Me.Label20.TabIndex = 20
        Me.Label20.Text = "Nombre"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Location = New System.Drawing.Point(81, 84)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(49, 13)
        Me.Label21.TabIndex = 23
        Me.Label21.Text = "Costo ($)"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Location = New System.Drawing.Point(112, 37)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(18, 13)
        Me.Label22.TabIndex = 19
        Me.Label22.Text = "ID"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Location = New System.Drawing.Point(415, 32)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(63, 13)
        Me.Label24.TabIndex = 30
        Me.Label24.Text = "Descripción"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Location = New System.Drawing.Point(78, 108)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(52, 13)
        Me.Label16.TabIndex = 34
        Me.Label16.Text = "Precio ($)"
        '
        'tab
        '
        Appearance15.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Appearance15.BackColor2 = System.Drawing.Color.Silver
        Me.tab.Appearance = Appearance15
        Appearance16.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Appearance16.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Appearance16.BackHatchStyle = Infragistics.Win.BackHatchStyle.None
        Me.tab.ClientAreaAppearance = Appearance16
        Me.tab.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.tab.Controls.Add(Me.tab1)
        Me.tab.Controls.Add(Me.UltraTabPageControl1)
        Me.tab.Controls.Add(Me.UltraTabPageControl2)
        Me.tab.Location = New System.Drawing.Point(0, 8)
        Me.tab.Name = "tab"
        Appearance17.BackColor = System.Drawing.Color.Silver
        Appearance17.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tab.SelectedTabAppearance = Appearance17
        Me.tab.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.tab.Size = New System.Drawing.Size(816, 448)
        Me.tab.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.PropertyPage2003
        Me.tab.TabIndex = 13
        UltraTab1.TabPage = Me.tab1
        UltraTab1.Text = "General"
        UltraTab2.TabPage = Me.UltraTabPageControl1
        UltraTab2.Text = "Tipo de fresa"
        UltraTab3.TabPage = Me.UltraTabPageControl2
        UltraTab3.Text = "Partes adicionales"
        Me.tab.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2, UltraTab3})
        Me.tab.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2003
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(812, 425)
        '
        'registrarModeloFresa
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(818, 448)
        Me.Controls.Add(Me.tab)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(196, 105)
        Me.Name = "registrarModeloFresa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Registrar modelo de fresa"
        Me.tab1.ResumeLayout(False)
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox3.ResumeLayout(False)
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.textPrecioModelo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comboGrupoModelo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comboTipoModelo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textVA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comboTA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comboMA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comboMT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textNom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.textPlanoTF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imagen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textImagenTF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox9.ResumeLayout(False)
        Me.UltraGroupBox9.PerformLayout()
        CType(Me.cantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comboPT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textCarFresa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textIDFresa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textCantDien, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textDiamAgu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textDiamExt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textNombreFresa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        CType(Me.UltraGroupBox11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox11.ResumeLayout(False)
        CType(Me.UltraGroupBox10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox10.ResumeLayout(False)
        Me.UltraGroupBox10.PerformLayout()
        CType(Me.textCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textIDParte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comboNParte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textDescParte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comboMatPrim, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.UltraGroupBox14, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox14.ResumeLayout(False)
        Me.UltraGroupBox14.PerformLayout()
        CType(Me.textPrecioTF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textCostoTF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox13.ResumeLayout(False)
        CType(Me.UltraGroupBox12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox12.ResumeLayout(False)
        Me.UltraGroupBox12.PerformLayout()
        CType(Me.orden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textTiempo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textIDEtapa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comboOperacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.imagen2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox5.ResumeLayout(False)
        Me.UltraGroupBox5.PerformLayout()
        CType(Me.textImagenA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textPlanoA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textTiempoAdicional, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox4.ResumeLayout(False)
        Me.UltraGroupBox4.PerformLayout()
        CType(Me.comboMPAdicional, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textCantMPAdicional, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        Me.UltraGroupBox2.PerformLayout()
        CType(Me.textPrecioAdicional, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comboNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textDescAdicional, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textIDAdicional, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textCostoAdicional, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region


#Region "Evento Load"
    Private Sub registrarModeloFresa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        textPrecioModelo.Text = 0

        Dim con As String

        'cargo todos los combos del formulario
        con = "select * from materialatrabajar"
        cargarCombo(con, comboMT)

        con = "select * from mododeavance"
        cargarCombo(con, comboMA)

        con = "select * from tipoacabado"
        cargarCombo(con, comboTA)

        con = "select * from tipoparte"
        cargarCombo(con, comboNParte)

        con = "select idtipomateriaprima, nombre from tipomateriaprima"
        cargarComboTag(con, comboMatPrim, 0, 2)
        comboMatPrim.SortStyle = Infragistics.Win.ValueListSortStyle.Ascending

        con = "select idoperacion, nombre, duracionpromedio from operacion"
        cargarComboOp(con, comboOperacion, 0)

        cargarComboTag("select idtipomateriaprima, nombre from tipomateriaprima", comboMPAdicional, 0, 2)
        comboMPAdicional.SortStyle = Infragistics.Win.ValueListSortStyle.Ascending

        'cargo lista de maquinas
        consulta = "select * from maquinafresa"
        indice = 0
        cargarLista(lista1, consulta, indice, columnas)


        'instancio los objetos, cargo los adaptadores y lleno el conjunto de datos(dataset) con las tres tablas
        'parte.cargarAdaptador()
        'parte.cargarDatos(ds, "parte")

        'fresa.cargarAdaptador()
        'fresa.cargarDatos(ds, "tipofresa")

        'etapa.cargarAdaptador()
        'etapa.cargarDatos(ds, "etapadefabricacion")

        modelo.cargarAdaptador()
        modelo.cargarDatos(ds, "modelofresa")

        textID.Text = ds.Tables("modelofresa").Rows.Count + 1

        princ.barra.agregarBoton(Me)

    End Sub
#End Region


#Region "Resto de eventos"
    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botonFresa.Click

        Dim band As Boolean
        band = False

        If textNom.Text = "" Then
            MsgBox("Debe ingresar nombre de la fresa", MsgBoxStyle.Information)
            band = True
            textNom.Focus()
            Exit Sub
        End If

        If comboTipoModelo.Text = "" Then
            MsgBox("Debe ingresar tipo de modelo de fresa", MsgBoxStyle.Information)
            band = True
            comboTipoModelo.Focus()
            Exit Sub
        End If

        If comboGrupoModelo.Text = "" Then
            MsgBox("Debe ingresar grupo de modelo de fresa", MsgBoxStyle.Information)
            band = True
            comboGrupoModelo.Focus()
            Exit Sub
        End If

        If comboMT.Text = "" Then
            MsgBox("Debe seleccionar material a trabajar", MsgBoxStyle.Information)
            band = True
            Exit Sub
        End If

        If comboMA.Text = "" Then
            MsgBox("Debe seleccionar modo de avance", MsgBoxStyle.Information)
            band = True
            Exit Sub
        End If

        If comboTA.Text = "" Then
            MsgBox("Debe seleccionar tipo de acabado", MsgBoxStyle.Information)
            band = True
            Exit Sub
        End If

        If textVA.Text = "" Then
            MsgBox("Debe ingresar velocidad de avance", MsgBoxStyle.Information)
            band = True
            textVA.Focus()
            Exit Sub
        End If


        If band = False Then


            If textIDFresa.Text = "" Then
                textIDFresa.Text = 1
                textNombreFresa.Text = textNom.Text & " Fresa " & textIDFresa.Text.ToString

                If banderaAd = False Then
                    parte.cargarAdaptador()
                    parte.cargarDatos(ds, "parte")

                    fresa.cargarAdaptador()
                    fresa.cargarDatos(ds, "tipofresa")

                    etapa.cargarAdaptador()
                    etapa.cargarDatos(ds, "etapadefabricacion")
                End If

            Else
                i = i + 1
                textIDFresa.Text = i


                textNombreFresa.Text = ""
                textDiamExt.Text = ""
                textDiamAgu.Text = ""
                textCantDien.Text = ""
                textPlanoTF.Text = ""
                comboPT.Text = ""
                textCarFresa.Text = ""
                textCostoTF.Text = ""
                textPrecioTF.Text = ""

                textNombreFresa.Text = textNom.Text & " Fresa " & textIDFresa.Text.ToString

            End If

            TabControl1.SelectedTab = TabControl1.TabPages(0)
            'tab.Tabs.Item(1).Selected() = True
            tab.SelectedTab = tab.Tabs(1)
            'tab.ActiveTab() = tab.Tabs(1)
            tab.Tabs(1).Enabled = True

            textIDParte.Text = 1
            textIDEtapa.Text = 1
            orden.Text = 1
            textTiempo.Text = 0


            lista3.SelectedItems.Clear()
            lista4.SelectedItems.Clear()

            botonFresa.Enabled = False
            BotonParte.Enabled = False

        End If


    End Sub


    Private Sub UltraButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton2.Click
        Dim item As ListViewItem
        Dim t As Integer



        If lista1.SelectedIndices.Count <> 0 Then

            t = lista1.SelectedItems.Item(0).SubItems(0).Text
            For Each item In lista2.Items
                If t = item.SubItems(0).Text Then
                    MsgBox("Esta máquina ya existe en la lista", MsgBoxStyle.Information)
                    Exit Sub
                End If
            Next
            item = lista2.Items.Add(lista1.SelectedItems.Item(0).SubItems(0).Text)
            item.SubItems.Add(lista1.SelectedItems.Item(0).SubItems(1).Text)
            item.SubItems.Add(lista1.SelectedItems.Item(0).SubItems(2).Text)
            item.SubItems.Add(lista1.SelectedItems.Item(0).SubItems(3).Text)
            item.SubItems.Add(lista1.SelectedItems.Item(0).SubItems(4).Text)
            item.Tag = lista1.SelectedItems.Item(0).Tag
        End If
    End Sub


    Private Sub UltraButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton3.Click
        If lista2.SelectedIndices.Count <> 0 Then
            lista2.SelectedItems.Item(0).Remove()
        End If
    End Sub


    Private Sub UltraButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton4.Click
        Me.Close()
    End Sub


    Private Sub UltraButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        tab.Tabs(2).Enabled = True
        tab.SelectedTab = tab.Tabs(2)
    End Sub


    Private Sub UltraButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim nuevaFresa As DataRow
        Dim band As Boolean = True


        If textCostoTF.Text = "" Then
            MsgBox("Debe calcular el costo de la fresa", MsgBoxStyle.Information)
            band = False
        End If

        If textPrecioTF.Text = "" Then
            MsgBox("Debe ingresar el precio de la fresa", MsgBoxStyle.Information)
            band = False
        End If

        If band = True Then
            nuevaFresa = ds.Tables("tipofresa").NewRow

            'nuevaFresa("idtipo") = textID.Text
            'nuevaFresa("nombre") = textNom.Text
            'nuevaFresa("diametroexterior") = textDiamExt.Text
            'nuevaFresa("diametroagujero") = textDiamAgu.Text
            'nuevaFresa("cantidaddientes") = textCantDien.Text
            'nuevaFresa("plano") = ""
            'nuevaFresa("materialatrabajar") = comboMT.SelectedItem.ToString
            'nuevaFresa("mododeavance") = comboMA.SelectedItem.ToString
            'nuevaFresa("tipoacabado") = comboTA.SelectedItem.ToString
            'nuevaFresa("posiciondetrabajo") = ComboPT.Text
            'nuevaFresa("velocidaddeavance") = textVelAv.Text
            'nuevaFresa("costo") = textCosto.Text
            'nuevaFresa("precio") = textPrecio.Text
            'nuevaFresa("estado") = "Alta"


            'da = fresa.adaptadorTipoFresa
            ds.Tables("tipofresa").Rows.Add(nuevaFresa)
            'da.Update(ds, "tipofresa")
            fresa.actualizarDatos(ds, "tipofresa")

            parte.actualizarDatos(ds, "parte")

            etapa.actualizarDatos(ds, "etapadefabricacion")


            Me.Close()
        End If

    End Sub


    Private Sub UltraButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim band As Boolean = True
        Dim nuevaParte As DataRow

        If comboNParte.Text = "" Then
            band = False
            MsgBox("Debe seleccionar el nombre de la parte", MsgBoxStyle.Information)
        End If

        If comboMatPrim.Text = "" Then
            band = False
            MsgBox("Debe seleccionar materia prima", MsgBoxStyle.Information)
        End If

        If textCantidad.Text = "" Then
            band = False
            MsgBox("Debe ingresar cantidad", MsgBoxStyle.Information)
        End If

        If band = True Then
            nuevaParte = ds.Tables("parte").NewRow

            nuevaParte("idtipofresa") = textID.Text
            nuevaParte("idparte") = textIDParte.Text
            nuevaParte("nombre") = comboNParte.SelectedItem.ToString
            nuevaParte("cantidad") = textCantidad.Text
            'nuevaParte("descripcion") = textDesc.Text
            nuevaParte("idtipomateriaprima") = comboMatPrim.SelectedItem.Tag


            ds.Tables("parte").Rows.Add(nuevaParte)

            item = lista3.Items.Add(textIDParte.Text)

            item.SubItems.Add(comboNParte.SelectedItem.ToString)
            item.SubItems.Add(comboMatPrim.SelectedItem.Tag)
            item.SubItems.Add(comboMatPrim.SelectedItem.ToString)
            item.SubItems.Add(textCantidad.Text)


            'da = parte.adaptadorParte
            'da.Update(ds, "parte")


            textIDParte.Text = lista3.Items.Count + 1
            comboNParte.SelectedItem = Nothing
            comboMatPrim.SelectedItem = Nothing
            textCantidad.Text = 0
            'textDesc.Text = ""
        End If




    End Sub


    Private Sub UltraButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim band As Boolean = True
        Dim nuevaEtapa As DataRow

        If comboOperacion.Text = "" Then
            MsgBox("Debe seleccionar operación", MsgBoxStyle.Information)
            band = False
        End If



        If band = True Then

            nuevaEtapa = ds.Tables("etapadefabricacion").NewRow

            nuevaEtapa.Item("idetapafabricacion") = textIDEtapa.Text
            nuevaEtapa.Item("idtipofresa") = textID.Text
            nuevaEtapa("idoperacion") = comboOperacion.SelectedItem.Tag
            nuevaEtapa("orden") = orden.Text
            nuevaEtapa("tiempoadicional") = textTiempo.Text
            nuevaEtapa("detalle") = textDetalles.Text

            ds.Tables("etapadefabricacion").Rows.Add(nuevaEtapa)

            item = lista4.Items.Add(textIDEtapa.Text)

            item.SubItems.Add(comboOperacion.SelectedItem.Tag)
            item.SubItems.Add(comboOperacion.SelectedItem.ToString)
            item.SubItems.Add(orden.Text)
            item.SubItems.Add(textTiempo.Text)

            textIDEtapa.Text = textIDEtapa.Text + 1
            comboOperacion.SelectedItem = Nothing
            textTiempo.Text = 0
            orden.UpButton()
            textDetalles.Text = ""

            'da = etapa.adaptadorEtapa
            'da.Update(ds, "etapadefabricacion")
        End If

    End Sub



    Private Sub textDiamExt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        soloNumeros(e)
    End Sub



    Private Sub textDiamAgu_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        soloNumeros(e)
    End Sub


    Private Sub textCantDien_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        soloNumeros(e)
    End Sub

    Private Sub textCantidad_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        soloNumeros(e)
    End Sub

    Private Sub textTiempo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        soloNumeros(e)
    End Sub

    Private Sub textVelAv_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        soloNumeros(e)
    End Sub

    Private Sub textIDetapa_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        soloNumeros(e)
    End Sub


    Private Sub UltraButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If lista3.SelectedItems.Count <> 0 Then

            Dim i As Integer
            Dim fila() As DataRow
            Dim criterio As String
            criterio = "idtipofresa = " & textID.Text & " and idparte = " & lista3.SelectedItems.Item(0).Text

            i = lista3.SelectedItems.Item(0).Text
            fila = ds.Tables("parte").Select(criterio)

            fila(0).Delete()
            'ds.Tables("parte").Rows.Remove(fila(0))
            textIDParte.Text = i

            'da = parte.adaptadorParte
            'da.Update(ds, "parte")

            lista3.SelectedItems.Item(0).Remove()


        End If
    End Sub

    Private Sub UltraButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If lista4.SelectedItems.Count <> 0 Then

            Dim i As Integer
            Dim fila() As DataRow
            Dim criterio As String
            criterio = "idtipofresa = " & textID.Text & " and idetapafabricacion = " & lista4.SelectedItems.Item(0).Text

            i = lista4.SelectedItems.Item(0).Text
            fila = ds.Tables("etapadefabricacion").Select(criterio)

            fila(0).Delete()
            'ds.Tables("parte").Rows.Remove(fila(0))
            textIDEtapa.Text = i

            'da = etapa.adaptadorEtapa
            'da.Update(ds, "etapadefabricacion")

            lista4.SelectedItems.Item(0).Remove()


        End If
    End Sub


    Private Sub textCosto_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        soloNumeros(e)
    End Sub


    Private Sub registrarModeloFresa_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        princ.barra.eliminarBoton()
    End Sub


    Private Sub UltraButton12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        tab.SelectedTab = tab.Tabs(0)
    End Sub

    Private Sub UltraButton13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        tab.SelectedTab = tab.Tabs(1)
    End Sub




    Private Sub UltraButton15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton15.Click
        If lista3.SelectedItems.Count <> 0 Then

            Dim i As Integer
            Dim fila() As DataRow
            Dim criterio As String
            criterio = "idtipofresa = " & textIDFresa.Text & " and idparte = " & lista3.SelectedItems.Item(0).Text & " and idmodelo = " & textID.Text

            i = lista3.SelectedItems.Item(0).Text
            fila = ds.Tables("parte").Select(criterio)

            fila(0).Delete()
            'ds.Tables("parte").Rows.Remove(fila(0))
            textIDParte.Text = i

            'da = parte.adaptadorParte
            'da.Update(ds, "parte")

            lista3.SelectedItems.Item(0).Remove()


        End If

    End Sub

    Private Sub UltraButton14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton14.Click
        Dim band As Boolean = True
        Dim nuevaParte As DataRow

        If comboNParte.Text = "" Then
            band = False
            MsgBox("Debe seleccionar el nombre de la parte", MsgBoxStyle.Information)
        End If

        If comboMatPrim.Text = "" Then
            band = False
            MsgBox("Debe seleccionar materia prima", MsgBoxStyle.Information)
        End If

        If textCantidad.Text = "" Then
            band = False
            MsgBox("Debe ingresar cantidad", MsgBoxStyle.Information)
        End If

        If band = True Then
            nuevaParte = ds.Tables("parte").NewRow

            nuevaParte("idmodelo") = textID.Text
            nuevaParte("idtipofresa") = textIDFresa.Text
            nuevaParte("idparte") = textIDParte.Text
            nuevaParte("nombre") = comboNParte.SelectedItem.ToString
            nuevaParte("cantidad") = textCantidad.Text
            nuevaParte("descripcion") = textDescParte.Text
            nuevaParte("idtipomateriaprima") = comboMatPrim.SelectedItem.Tag

            ds.Tables("parte").Rows.Add(nuevaParte)

            item = lista3.Items.Add(textIDParte.Text)

            item.SubItems.Add(comboNParte.SelectedItem.ToString)
            item.SubItems.Add(comboMatPrim.SelectedItem.Tag)
            item.SubItems.Add(comboMatPrim.SelectedItem.ToString)
            item.SubItems.Add(textCantidad.Text)

            'Los cambios son confirmados cuando finalizo la carga completa del modelo de fresa
            'da = parte.adaptadorParte
            'da.Update(ds, "parte")

            textIDParte.Text = lista3.Items.Count + 1
            comboNParte.SelectedItem = Nothing
            comboMatPrim.SelectedItem = Nothing
            textCantidad.Text = ""
            textDescParte.Text = ""
        End If

    End Sub

    Private Sub UltraButton16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton16.Click
        Dim band As Boolean = True
        Dim nuevaEtapa As DataRow

        If comboOperacion.Text = "" Then
            MsgBox("Debe seleccionar operación", MsgBoxStyle.Information)
            band = False
        End If


        If band = True Then

            nuevaEtapa = ds.Tables("etapadefabricacion").NewRow

            nuevaEtapa.Item("idmodelo") = textID.Text
            nuevaEtapa.Item("idetapafabricacion") = textIDEtapa.Text
            nuevaEtapa.Item("idtipofresa") = textIDFresa.Text
            nuevaEtapa("idoperacion") = comboOperacion.SelectedItem.Tag
            nuevaEtapa("orden") = orden.Text
            nuevaEtapa("tiempoadicional") = textTiempo.Text
            nuevaEtapa("detalle") = textDetalles.Text

            ds.Tables("etapadefabricacion").Rows.Add(nuevaEtapa)

            item = lista4.Items.Add(textIDEtapa.Text)

            item.SubItems.Add(comboOperacion.SelectedItem.Tag)
            item.SubItems.Add(comboOperacion.SelectedItem.ToString)
            item.SubItems.Add(orden.Text)
            item.SubItems.Add(textTiempo.Text)

            textIDEtapa.Text = textIDEtapa.Text + 1
            comboOperacion.SelectedItem = Nothing
            textTiempo.Text = 0
            orden.UpButton()
            textDetalles.Text = ""

            'da = etapa.adaptadorEtapa
            'da.Update(ds, "etapadefabricacion")
        End If
    End Sub

    Private Sub UltraButton17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton17.Click
        If lista4.SelectedItems.Count <> 0 Then

            Dim i As Integer
            Dim fila() As DataRow
            Dim criterio As String
            criterio = "idtipofresa = " & textIDFresa.Text & " and idetapafabricacion = " & lista4.SelectedItems.Item(0).Text & " and idmodelo = " & textID.Text

            i = lista4.SelectedItems.Item(0).Text
            fila = ds.Tables("etapadefabricacion").Select(criterio)

            fila(0).Delete()
            'ds.Tables("parte").Rows.Remove(fila(0))
            textIDEtapa.Text = i

            'da = etapa.adaptadorEtapa
            'da.Update(ds, "etapadefabricacion")

            lista4.SelectedItems.Item(0).Remove()


        End If
    End Sub

    Private Sub UltraButton22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton22.Click
        Dim nuevaFresa As DataRow
        Dim band As Boolean = True


        If textCostoTF.Text = "" Then
            MsgBox("Debe calcular el costo de la fresa", MsgBoxStyle.Information)
            band = False
            Exit Sub
        End If

        If textPrecioTF.Text = "" Then
            MsgBox("Debe ingresar el precio de la fresa", MsgBoxStyle.Information)
            band = False
            Exit Sub
        End If



        If band = True Then


            If cantidad.Text = 1 Then
                nuevaFresa = ds.Tables("tipofresa").NewRow


                nuevaFresa("idmodelo") = textID.Text
                nuevaFresa("idtipo") = textIDFresa.Text
                nuevaFresa("nombre") = textNombreFresa.Text
                nuevaFresa("diametroexterior") = textDiamExt.Text
                nuevaFresa("diametroagujero") = textDiamAgu.Text
                nuevaFresa("cantidaddientes") = textCantDien.Text
                nuevaFresa("plano") = textPlanoTF.Text
                nuevaFresa("posiciondetrabajo") = comboPT.Text
                nuevaFresa("caracteristicas") = textCarFresa.Text
                nuevaFresa("costo") = textCostoTF.Text
                nuevaFresa("precio") = textPrecioTF.Text
                nuevaFresa("estado") = "Alta"


                ds.Tables("tipofresa").Rows.Add(nuevaFresa)


            Else
                Dim i As Integer
                Dim j As Integer
                j = textIDFresa.Text

                For i = 1 To cantidad.Text
                    nuevaFresa = ds.Tables("tipofresa").NewRow


                    nuevaFresa("idmodelo") = textID.Text
                    nuevaFresa("idtipo") = j
                    nuevaFresa("nombre") = textNom.Text & " Fresa " & i
                    nuevaFresa("diametroexterior") = textDiamExt.Text
                    nuevaFresa("diametroagujero") = textDiamAgu.Text
                    nuevaFresa("cantidaddientes") = textCantDien.Text
                    nuevaFresa("plano") = textPlanoTF.Text
                    nuevaFresa("posiciondetrabajo") = comboPT.Text
                    nuevaFresa("caracteristicas") = textCarFresa.Text
                    nuevaFresa("costo") = textCostoTF.Text
                    nuevaFresa("precio") = textPrecioTF.Text
                    nuevaFresa("estado") = "Alta"


                    ds.Tables("tipofresa").Rows.Add(nuevaFresa)
                    j = j + 1

                Next

            End If


            tab.SelectedTab = tab.Tabs(0)
            tab.Tabs(1).Enabled = False

            i = i + cantidad.Text

            bandera = True
            banderaFresa = True

            botonFresa.Enabled = True
            BotonParte.Enabled = True

            textPrecioModelo.Text = CDec(textPrecioModelo.Text) + CDec(textPrecioTF.Text)

            TabControl1.SelectedTab = TabControl1.TabPages(0)
        End If
    End Sub



    Private Sub UltraButton24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton24.Click
        Dim band As Boolean
        band = False

        If textNombreFresa.Text = "" Then
            MsgBox("Debe ingresar nombre de fresa individual", MsgBoxStyle.Information)
            band = True
            textNombreFresa.Focus()
            Exit Sub
        End If

        If textDiamExt.Text = "" Then
            MsgBox("Debe ingresar diámetro exterior", MsgBoxStyle.Information)
            band = True
            textDiamExt.Focus()
            Exit Sub
        End If

        If textDiamAgu.Text = "" Then
            MsgBox("Debe ingresar diámetro del agujero", MsgBoxStyle.Information)
            band = True
            textDiamAgu.Focus()
            Exit Sub
        End If

        If textCantDien.Text = "" Then
            MsgBox("Debe ingresar cantidad de dientes", MsgBoxStyle.Information)
            band = True
            textCantDien.Focus()
            Exit Sub
        End If

        If comboPT.Text = "" Then
            MsgBox("Debe seleccionar posición de trabajo", MsgBoxStyle.Information)
            band = True
            Exit Sub
        End If

        If band = False Then
            TabControl1.SelectedTab = TabControl1.TabPages(1)
        End If
    End Sub




    Private Sub UltraButton23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton23.Click



        ofd.InitialDirectory = "c:\"
        ofd.Filter = "Imagen (*.jpg)|*.jpg|Imagen (*.bmp)|*.bmp|Imagen (*.gif)|*.gif"
        ofd.FilterIndex = 2
        ofd.RestoreDirectory = True

        If ofd.ShowDialog() = DialogResult.OK Then
            'Dim s As System.IO.Stream
            'Dim i As System.Drawing.Image
            Image.FromFile(ofd.FileName.ToString)
            's = ofd.OpenFile
            textImagenTF.Text = ofd.FileName.ToString
            'imagen.Image = i.FromStream(s)
            imagen.Image = Image.FromFile(ofd.FileName)
            imagen.Refresh()
        End If

    End Sub

    Private Sub UltraButton5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton5.Click
        ofd.InitialDirectory = "c:\"
        ofd.Filter = "Archivo de Corel (*.cdr)|*.crd"
        ofd.FilterIndex = 2
        ofd.RestoreDirectory = True

        If ofd.ShowDialog() = DialogResult.OK Then

            textPlanoTF.Text = ofd.FileName.ToString

        End If
    End Sub

    Private Sub UltraButton8_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton8.Click
        ofd.InitialDirectory = "c:\"
        ofd.Filter = "Imagen (*.jpg)|*.jpg|Imagen (*.bmp)|*.bmp|Imagen (*.gif)|*.gif"
        ofd.FilterIndex = 2
        ofd.RestoreDirectory = True

        If ofd.ShowDialog() = DialogResult.OK Then
            'Dim s As System.IO.Stream
            Dim i As System.Drawing.Image
            Image.FromFile(ofd.FileName.ToString)
            's = ofd.OpenFile
            textImagenA.Text = ofd.FileName.ToString
            'imagen.Image = i.FromStream(s)
            imagen2.Image = i.FromFile(ofd.FileName)
            imagen2.Refresh()
        End If
    End Sub

    Private Sub UltraButton7_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton7.Click
        ofd.InitialDirectory = "c:\"
        ofd.Filter = "Archivo de Corel (*.cdr)|*.crd"
        ofd.FilterIndex = 2
        ofd.RestoreDirectory = True

        If ofd.ShowDialog() = DialogResult.OK Then

            textPlanoA.Text = ofd.FileName.ToString

        End If
    End Sub



    Private Sub UltraButton25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonParte.Click
        Dim band As Boolean
        band = False

        If textNom.Text = "" Then
            MsgBox("Debe ingresar nombre de la fresa", MsgBoxStyle.Information)
            band = True
            textNom.Focus()
            Exit Sub
        End If

        If comboTipoModelo.Text = "" Then
            MsgBox("Debe ingresar tipo de modelo de fresa", MsgBoxStyle.Information)
            band = True
            comboTipoModelo.Focus()
            Exit Sub
        End If

        If comboGrupoModelo.Text = "" Then
            MsgBox("Debe ingresar grupo de modelo de fresa", MsgBoxStyle.Information)
            band = True
            comboGrupoModelo.Focus()
            Exit Sub
        End If

        If comboMT.Text = "" Then
            MsgBox("Debe seleccionar material a trabajar", MsgBoxStyle.Information)
            band = True
            Exit Sub
        End If

        If comboMA.Text = "" Then
            MsgBox("Debe seleccionar modo de avance", MsgBoxStyle.Information)
            band = True
            Exit Sub
        End If

        If comboTA.Text = "" Then
            MsgBox("Debe seleccionar tipo de acabado", MsgBoxStyle.Information)
            band = True
            Exit Sub
        End If

        If textVA.Text = "" Then
            MsgBox("Debe ingresar velocidad de avance", MsgBoxStyle.Information)
            band = True
            textVA.Focus()
            Exit Sub
        End If


        If band = False Then


            If textIDAdicional.Text = "" Then

                textIDAdicional.Text = 1

                If banderaAd2 = False Then
                    adicional.cargarAdaptador()
                    adicional.cargarDatos(ds, "parteAdicional")
                End If

            Else
                j = j + 1
                textIDAdicional.Text = j
                comboNombre.Text = ""
                textPlanoA.Text = ""
                textImagenA.Text = ""

                comboMPAdicional.Text = ""
                textCantMPAdicional.Text = ""
                textDescAdicional.Text = ""
                textTiempoAdicional.Text = ""
                textCostoAdicional.Text = ""
                textPrecioAdicional.Text = ""
            End If

            'tab.Tabs.Item(1).Selected() = True
            tab.SelectedTab = tab.Tabs(2)
            'tab.ActiveTab() = tab.Tabs(1)
            tab.Tabs(2).Enabled = True

            botonFresa.Enabled = False
            BotonParte.Enabled = False

        End If
    End Sub

    Private Sub UltraButton9_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton9.Click
        Dim fila As DataRow
        Dim band As Boolean = True


        If textCostoAdicional.Text = "" Then
            MsgBox("Debe ingresar el costo de la parte adicional", MsgBoxStyle.Information)
            band = False
        End If

        If textPrecioAdicional.Text = "" Then
            MsgBox("Debe ingresar el precio de la parte adicional", MsgBoxStyle.Information)
            band = False
        End If

        If comboNombre.Text = "" Then
            MsgBox("Debe ingresar nombre de la parte adicional", MsgBoxStyle.Information)
            band = False
        End If

        If comboMPAdicional.Text = "" Then
            MsgBox("Debe seleccionar materia prima", MsgBoxStyle.Information)
            band = False
        End If

        If textCantMPAdicional.Text = "" Then
            MsgBox("Debe ingresar cantidad de MP", MsgBoxStyle.Information)
            band = False
        End If

        If textTiempoAdicional.Text = "" Then
            MsgBox("Debe ingresar tiempo de fabricación", MsgBoxStyle.Information)
            band = False
        End If


        If band = True Then
            fila = ds.Tables("parteAdicional").NewRow


            fila("idmodelo") = textID.Text
            fila("idadicional") = textIDAdicional.Text
            fila("nombre") = comboNombre.Text
            fila("plano") = textPlanoA.Text
            'fila("imagen") = ""
            fila("idmateriaprima") = comboMPAdicional.SelectedItem.Tag
            fila("cantidad") = textCantMPAdicional.Text
            fila("descripcion") = textDescAdicional.Text
            fila("tiempo") = textTiempoAdicional.Text
            fila("costo") = textCostoAdicional.Text
            fila("precio") = textPrecioAdicional.Text



            ds.Tables("parteAdicional").Rows.Add(fila)

            tab.SelectedTab = tab.Tabs(0)
            tab.Tabs(2).Enabled = False

            bandera = True
            banderaParte = True

            botonFresa.Enabled = True
            BotonParte.Enabled = True

            textPrecioModelo.Text = CDec(textPrecioModelo.Text) + CDec(textPrecioAdicional.Text)


        End If
    End Sub

    Private Sub UltraButton21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton21.Click
        TabControl1.SelectedTab = TabControl1.TabPages(1)
    End Sub

    Private Sub UltraButton20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton20.Click
        TabControl1.SelectedTab = TabControl1.TabPages(2)
    End Sub

    Private Sub UltraButton19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton19.Click
        TabControl1.SelectedTab = TabControl1.TabPages(0)
    End Sub

    Private Sub UltraButton10_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton10.Click
        If bandera = True Then
            Dim nuevoModelo As DataRow
            Dim band As Boolean = False

            If textNom.Text = "" Then
                MsgBox("Debe ingresar nombre de la fresa", MsgBoxStyle.Information)
                band = True
                textNom.Focus()
                Exit Sub
            End If

            If comboTipoModelo.Text = "" Then
                MsgBox("Debe ingresar tipo de modelo de fresa", MsgBoxStyle.Information)
                band = True
                comboTipoModelo.Focus()
                Exit Sub
            End If

            If comboGrupoModelo.Text = "" Then
                MsgBox("Debe ingresar grupo de modelo de fresa", MsgBoxStyle.Information)
                band = True
                comboGrupoModelo.Focus()
                Exit Sub
            End If

            If comboMT.Text = "" Then
                MsgBox("Debe seleccionar material a trabajar", MsgBoxStyle.Information)
                band = True
                Exit Sub
            End If

            If comboMA.Text = "" Then
                MsgBox("Debe seleccionar modo de avance", MsgBoxStyle.Information)
                band = True
                Exit Sub
            End If

            If comboTA.Text = "" Then
                MsgBox("Debe seleccionar tipo de acabado", MsgBoxStyle.Information)
                band = True
                Exit Sub
            End If

            If textVA.Text = "" Then
                MsgBox("Debe ingresar velocidad de avance", MsgBoxStyle.Information)
                band = True
                textVA.Focus()
                Exit Sub
            End If


            If band = False Then
                nuevoModelo = ds.Tables("modelofresa").NewRow


                nuevoModelo("idmodelo") = textID.Text
                nuevoModelo("nombre") = textNom.Text
                nuevoModelo("grupomodelo") = comboGrupoModelo.Text
                nuevoModelo("descripcion") = textDescripcion.Text
                nuevoModelo("materialatrabajar") = comboMT.Text
                nuevoModelo("mododeavance") = comboMA.Text
                nuevoModelo("tipoacabado") = comboTA.Text
                nuevoModelo("velocidaddeavance") = textVA.Text
                nuevoModelo("tipomodelo") = comboTipoModelo.Text
                nuevoModelo("precio") = textPrecioModelo.Text
                nuevoModelo("estado") = "Alta"



                ds.Tables("modelofresa").Rows.Add(nuevoModelo)

                modelo.actualizarDatos(ds, "modelofresa")

                If banderaFresa = True Then
                    fresa.actualizarDatos(ds, "tipofresa")

                    parte.actualizarDatos(ds, "parte")
                    etapa.actualizarDatos(ds, "etapadefabricacion")
                End If

                If banderaParte = True Then
                    adicional.actualizarDatos(ds, "parteAdicional")
                End If

                Me.Close()

            End If
        Else
            MsgBox("Debe registrar al menos una fresa o parte adicional para el modelo", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub UltraButton11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton11.Click
        If textIDFresa.Text = 1 Then
            textIDFresa.Text = ""
            banderaAd = True

        Else
            i = i - 1
        End If

        tab.SelectedTab = tab.Tabs(0)
        tab.Tabs(1).Enabled = False
        botonFresa.Enabled = True
        BotonParte.Enabled = True
    End Sub

    Private Sub UltraButton12_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton12.Click
        If textIDAdicional.Text = 1 Then
            textIDAdicional.Text = ""
            banderaAd2 = True
        Else
            j = j - 1
        End If

        tab.SelectedTab = tab.Tabs(0)
        tab.Tabs(2).Enabled = False
        botonFresa.Enabled = True
        BotonParte.Enabled = True
        TabControl1.SelectedTab = TabControl1.TabPages(0)

    End Sub



    Private Sub textPrecioModelo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles textPrecioModelo.KeyPress
        soloNumeros(e)
    End Sub


    Private Sub textDiamExt_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles textDiamExt.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub textDiamAgu_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles textDiamAgu.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub textCantDien_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles textCantDien.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub textCostoAdicional_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles textCostoAdicional.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub textCostoTF_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles textCostoTF.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub textPrecioAdicional_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles textPrecioAdicional.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub textTiempoAdicional_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles textTiempoAdicional.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub textCantidad_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles textCantidad.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub comboMatPrim_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboMatPrim.ValueChanged


        Dim um2 As UnidadDeMedida
        If comboMatPrim.SelectedIndex <> -1 Then
            um2 = um.obtenerUnidadDeMedidaPorId(comboMatPrim.SelectedItem.Tag)
            lblUnidadDeMedida.Text = um2.Nombre
        End If

    End Sub


    Private Sub btnCalcularCosto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcularCosto.Click
        Dim materiaPrima As New MateriaPrima
        Dim costo_mp As New Double
        Dim costo_partes As New Double
        Dim costo_etapas As New Double
        Dim tiempo_operacion As New Double

        Dim fila As DataRow
        'Costo Partes
        For Each fila In ds.Tables("parte").Rows
            costo_mp = materiaPrima.obtenerPrecioMateriaPrima(fila("idtipomateriaprima"))
            costo_partes = costo_partes + (fila("cantidad") * costo_mp)
        Next

        'Costo Hora/Hombre utilizado en el calculo de Costo de operaciones
        Dim parametro As New Parametro
        Dim hora_hombre As Double = parametro.obtenerParametro(Constantes.HORA_HOMBRE_OPERARIO)

        'Costo Etapas de fabricacion / operaciones
        For Each fila In ds.Tables("etapadefabricacion").Rows
            tiempo_operacion = operacion.obtenerTiempoOperacion(fila("idoperacion"))
            costo_etapas = costo_etapas + ((hora_hombre / 60) * (tiempo_operacion + fila("tiempoadicional")))
        Next


        textCostoTF.Text = costo_etapas + costo_partes


    End Sub


    Private Sub comboMPAdicional_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboMPAdicional.ValueChanged
        Dim unidadDeMedida As UnidadDeMedida
        If comboMPAdicional.SelectedIndex <> -1 Then
            unidadDeMedida = um.obtenerUnidadDeMedidaPorId(comboMPAdicional.SelectedItem.Tag)
            lblUmParteAdicional.Text = unidadDeMedida.Nombre
        End If
    End Sub

#End Region


End Class
