Imports System

Imports System.IO

Imports System.Security

Imports System.Security.Cryptography

Imports System.Text



Public Class Criptologia


#Region "Contraseñas Hash"


    Shared Function ConvertirCadenaEnMatrizDeTipoByte(ByVal Cadena As [String]) As [Byte]()

        Return (New UnicodeEncoding).GetBytes(Cadena)

    End Function


    Public Function EncriptarHash(ByVal ValorAEncriptar As String) As String

        Dim ValorToHash As [Byte]() = ConvertirCadenaEnMatrizDeTipoByte(ValorAEncriptar)

        Dim ValorHash As Byte() = CType(CryptoConfig.CreateFromName("SHA512"), HashAlgorithm).ComputeHash(ValorToHash)

        Return Convert.ToBase64String(ValorHash)

    End Function



    Public Function Comparar(ByVal ValorSinEncriptar As String, ByVal ValorEncriptado As String) As Boolean

        If EncriptarHash(ValorSinEncriptar) = ValorEncriptado Then

            Return True

        Else

            Return False

        End If

    End Function

#End Region



#Region "Encriptar/Desencriptar"



    Public Shared Function EncriptarTexto(ByVal CadenaAEncriptar As String, ByVal Clave As String, ByVal MantenerMayusculas As Boolean) As String


        Dim i As Integer, C As Integer

        Dim CadenaEncriptada As String

        If MantenerMayusculas = False Then

            Clave = Clave.ToUpper()

            CadenaAEncriptar = CadenaAEncriptar.ToUpper()

        End If

        If Len(Clave) Then

            For i = 1 To Len(CadenaAEncriptar)

                C = Asc(Mid$(CadenaAEncriptar, i, 1))

                C = C + Asc(Mid$(Clave, (i Mod Len(Clave)) + 1, 1))

                CadenaEncriptada = CadenaEncriptada & Chr(C And &HFF)

            Next i

        Else

            CadenaEncriptada = CadenaAEncriptar

        End If

        Return CadenaEncriptada

    End Function



    Public Shared Function DesencriptarTexto(ByVal CadenaADesencriptar As String, ByVal Clave As String, ByVal MantenerMayusculas As Boolean) As String

        Dim i As Integer, C As Integer

        Dim CadenaDesencriptada As String

        If MantenerMayusculas = False Then

            Clave = Clave.ToUpper

        End If

        If Len(Clave) Then

            For i = 1 To Len(CadenaADesencriptar)

                C = Asc(Mid$(CadenaADesencriptar, i, 1))

                C = C - Asc(Mid$(Clave, (i Mod Len(Clave)) + 1, 1))

                CadenaDesencriptada += Chr(C And &HFF)

            Next i

        Else

            CadenaDesencriptada = CadenaADesencriptar

        End If

        Return CadenaDesencriptada

    End Function

#End Region

End Class


