Imports System.Configuration.ConfigurationSettings

Public Class BaseDatos


    Private WithEvents oBackup As New SQLDMO.Backup
    Private WithEvents oRestore As New SQLDMO.Restore
    Private oSQLServer As New SQLDMO.SQLServer
    Private strInstancia As String
    Private strNombreBD As String
    Private strLoginSecure As String
    Private strUsuario As String
    Private strPassword As String


    Public Sub New()

        strInstancia = "notebook" 'AppSettings.Get("DataBaseServer")
        strNombreBD = AppSettings.Get("DataBaseName")
        strLoginSecure = AppSettings.Get("DataBaseLoginSecure")
        strUsuario = AppSettings.Get("DataBaseUser")
        strPassword = AppSettings.Get("DataBasePwd")

    End Sub

    Public ReadOnly Property Instancia() As String
        Get
            Instancia = strInstancia
        End Get
    End Property

    Public ReadOnly Property NombreBD() As String
        Get
            NombreBD = strNombreBD
        End Get
    End Property

    Public ReadOnly Property LoginSecure() As String
        Get
            LoginSecure = strLoginSecure
        End Get
    End Property

    Public ReadOnly Property Usuario() As String
        Get
            Usuario = strUsuario
        End Get
    End Property

    Public ReadOnly Property Password() As String
        Get
            Password = strPassword
        End Get
    End Property

    Public Function GetConection() As String
        Dim strConection As String

        '"workstation id=GERARDO;packet size=4096;integrated security=SSPI;initial catalog=Afilar;persist security info=False"
        strConection = ""
        strConection &= "Initial Catalog=" & strNombreBD.Trim() & ";"
        strConection &= "Data Source=" & strInstancia.Trim() & ";"
        strConection &= "Persist Security Info=False;"

        If strLoginSecure = "TRUE" Then
            strConection &= "Integrated Security=SSPI;"
        Else
            strConection &= "User ID=" & strUsuario.Trim() & ";"
            strConection &= "Password=" & strPassword.Trim() & ";"
        End If

        Return strConection
    End Function

    Public Sub doBackup(ByVal FileBackup As String)

        With oBackup

            '.Devices = "[NorthwindBackup]"

            .Files = FileBackup

            .Database = NombreBD

            .BackupSetName = "MyDB"

            .BackupSetDescription = "Backup de Afilar"

            If LoginSecure = "TRUE" Then
                oSQLServer.LoginSecure = True  'Esta linea es necesaria si tiene Autenticacion con Windows
            End If
            oSQLServer.Connect(Instancia, Usuario, Password)
            .SQLBackup(oSQLServer)

        End With

        MessageBox.Show("Backup Se completo exitosamente", "Exito BackUp", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Public Sub doRestore(ByVal FileRestore As String)

        With oRestore

            .Files = FileRestore

            .Database = NombreBD

            .ReplaceDatabase = True

            If LoginSecure = "TRUE" Then
                oSQLServer.LoginSecure = True  'Esta linea es necesaria si tiene Autenticacion con Windows
            End If
            oSQLServer.Connect(Instancia, Usuario, Password)
            .SQLRestore(oSQLServer)

        End With

        MessageBox.Show("Restore Se completo con exito", "Exito Restore", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub
End Class
