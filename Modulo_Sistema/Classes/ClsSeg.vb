Imports System.Data.SqlClient

#Region "Explicacion de clase de seguridad"
' Esta clase se encarga de verificar si un usuario tiene privilegios para acceder
' a ciertos forms dependiendo del work space al que pertenece.
' ya es tarde como para agragar este esquema de seguridad a nivel de funcionalidad
' de formulario asi que lo hago directamente a nivel de forms 
#End Region

Public Class ClsSeg
    Private idusuario As Integer
    'Private pass As String
    'Private WS As Int32
#Region "Propertys"
    Private Property id() As Integer
        Get
            Return idusuario
        End Get
        Set(ByVal Value As Integer)
            idusuario = Value
        End Set
    End Property

    
#End Region

    'Public Sub New(ByVal usuario As String, ByVal pass As String)

    'End Sub
    Public Function Validar(ByVal usuario As String, ByVal contraseña As String) As Boolean
        Dim da As New SqlDataAdapter("select idlegajo from cuentausuario where usuario = '" & Trim(usuario) & "' and contraseña = '" & Trim(contraseña) & "'", cnn)
        Dim ds As New DataSet
        da.Fill(ds, "cuentausuario")
        If ds.Tables("cuentausuario").Rows.Count() = 0 Then
            Return False
        Else
            idusuario = ds.Tables("cuentausuario").Rows(0).Item(0).ToString()
            Return True
        End If
    End Function

#Region "HasPrivilege"
    Public Function HasPrivilege(ByVal idform As Integer) As Boolean
        Dim da As New SqlDataAdapter("select * from formxempleado where idformulario = " & idform & " and idlegajo = " & idusuario, cnn)
        Dim ds As New DataSet
        da.Fill(ds, "formxempleado")
        If ds.Tables("formxempleado").Rows.Count() = 0 Then
            Return False
        Else
            Return True
        End If
    End Function
#End Region


    

End Class
