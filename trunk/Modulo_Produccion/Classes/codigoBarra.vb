Imports System
Imports System.Text


Public Class CodigoBarra
    Private _sName As String = "EAN13"
    Private _fMinimumAllowableScale As Single = 0.8F
    Private _fMaximumAllowableScale As Single = 2.0F
    Private _fWidth As Single = 37.29F
    Private _fHeight As Single = 25.93F
    Private _fFontSize As Single = 8.0F
    Private _fScale As Single = 1.0F
    Private _aOddLeft As String() = {"0001101", "0011001", "0010011", "0111101", "0100011", "0110001", "0101111", "0111011", "0110111", "0001011"}
    Private _aEvenLeft As String() = {"0100111", "0110011", "0011011", "0100001", "0011101", "0111001", "0000101", "0010001", "0001001", "0010111"}
    Private _aRight As String() = {"1110010", "1100110", "1101100", "1000010", "1011100", "1001110", "1010000", "1000100", "1001000", "1110100"}
    Private _sQuiteZone As String = "000000000"
    Private _sLeadTail As String = "101"
    Private _sSeparator As String = "01010"
    Private _sCountryCode As String = "00"
    Private _sManufacturerCode As String
    Private _sProductCode As String
    Private _sChecksumDigit As String

    Public Sub New()
    End Sub

    Public Sub New(ByVal mfgNumber As String, ByVal productId As String)
        Me.CountryCode = "00"
        Me.ManufacturerCode = mfgNumber
        Me.ProductCode = productId
        Me.CalculateChecksumDigit()
    End Sub

    Public Sub New(ByVal countryCode As String, ByVal mfgNumber As String, ByVal productId As String)
        Me.CountryCode = countryCode
        Me.ManufacturerCode = mfgNumber
        Me.ProductCode = productId
        Me.CalculateChecksumDigit()
    End Sub

    Public Sub New(ByVal countryCode As String, ByVal mfgNumber As String, ByVal productId As String, ByVal checkDigit As String)
        Me.CountryCode = countryCode
        Me.ManufacturerCode = mfgNumber
        Me.ProductCode = productId
        Me.ChecksumDigit = checkDigit
    End Sub

    Public Sub DrawEan13Barcode(ByVal g As System.Drawing.Graphics, ByVal pt As System.Drawing.Point)
        Dim width As Single = Me.Width * Me.Scale
        Dim height As Single = Me.Height * Me.Scale
        Dim lineWidth As Single = width / 113.0F
        Dim gs As System.Drawing.Drawing2D.GraphicsState = g.Save
        g.PageUnit = System.Drawing.GraphicsUnit.Millimeter
        g.PageScale = 1
        Dim brush As System.Drawing.SolidBrush = New System.Drawing.SolidBrush(System.Drawing.Color.Black)
        Dim xPosition As Single = 0
        Dim strbEAN13 As System.Text.StringBuilder = New System.Text.StringBuilder
        Dim sbTemp As System.Text.StringBuilder = New System.Text.StringBuilder
        Dim xStart As Single = pt.X
        Dim yStart As Single = pt.Y
        Dim xEnd As Single = 0
        Dim font As System.Drawing.Font = New System.Drawing.Font("Arial", Me._fFontSize * Me.Scale)
        Me.CalculateChecksumDigit()
        sbTemp.AppendFormat("{0}{1}{2}{3}", Me.CountryCode, Me.ManufacturerCode, Me.ProductCode, Me.ChecksumDigit)
        Dim sTemp As String = sbTemp.ToString
        Dim sLeftPattern As String = ""
        sLeftPattern = ConvertLeftPattern(sTemp.Substring(0, 7))
        strbEAN13.AppendFormat("{0}{1}{2}{3}{4}{1}{0}", Me._sQuiteZone, Me._sLeadTail, sLeftPattern, Me._sSeparator, ConvertToDigitPatterns(sTemp.Substring(7), Me._aRight))
        Dim sTempUPC As String = strbEAN13.ToString
        Dim fTextHeight As Single = g.MeasureString(sTempUPC, font).Height
        Dim i As Integer = 0
        While i < strbEAN13.Length
            If sTempUPC.Substring(i, 1) = "1" Then
                If xStart = pt.X Then
                    xStart = xPosition
                End If
                If (i > 12 AndAlso i < 55) OrElse (i > 57 AndAlso i < 101) Then
                    g.FillRectangle(brush, xPosition, yStart, lineWidth, height - fTextHeight)
                Else
                    g.FillRectangle(brush, xPosition, yStart, lineWidth, height)
                End If
            End If
            xPosition += lineWidth
            xEnd = xPosition
            System.Math.Min(System.Threading.Interlocked.Increment(i), i - 1)
        End While
        xPosition = xStart - g.MeasureString(Me.CountryCode.Substring(0, 1), font).Width
        Dim yPosition As Single = yStart + (height - fTextHeight)
        g.DrawString(sTemp.Substring(0, 1), font, brush, New System.Drawing.PointF(xPosition, yPosition))
        xPosition += (g.MeasureString(sTemp.Substring(0, 1), font).Width + 43 * lineWidth) - (g.MeasureString(sTemp.Substring(1, 6), font).Width)
        g.DrawString(sTemp.Substring(1, 6), font, brush, New System.Drawing.PointF(xPosition, yPosition))
        xPosition += g.MeasureString(sTemp.Substring(1, 6), font).Width + (11 * lineWidth)
        g.DrawString(sTemp.Substring(7), font, brush, New System.Drawing.PointF(xPosition, yPosition))
        g.Restore(gs)
    End Sub

    Public Function CreateBitmap() As System.Drawing.Bitmap
        Dim tempWidth As Single = (Me.Width * Me.Scale) * 100
        Dim tempHeight As Single = (Me.Height * Me.Scale) * 100
        Dim bmp As System.Drawing.Bitmap = New System.Drawing.Bitmap(CType(tempWidth, Integer), CType(tempHeight, Integer))
        Dim g As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(bmp)
        Me.DrawEan13Barcode(g, New System.Drawing.Point(0, 0))
        g.Dispose()
        Return bmp
    End Function

    Private Function ConvertLeftPattern(ByVal sLeft As String) As String
        Select Case sLeft.Substring(0, 1)
            Case "0"
                Return CountryCode0(sLeft.Substring(1))
            Case "1"
                Return CountryCode1(sLeft.Substring(1))
            Case "2"
                Return CountryCode2(sLeft.Substring(1))
            Case "3"
                Return CountryCode3(sLeft.Substring(1))
            Case "4"
                Return CountryCode4(sLeft.Substring(1))
            Case "5"
                Return CountryCode5(sLeft.Substring(1))
            Case "6"
                Return CountryCode6(sLeft.Substring(1))
            Case "7"
                Return CountryCode7(sLeft.Substring(1))
            Case "8"
                Return CountryCode8(sLeft.Substring(1))
            Case "9"
                Return CountryCode9(sLeft.Substring(1))
            Case Else
                Return ""
        End Select
    End Function

    Private Function CountryCode0(ByVal sLeft As String) As String
        Return ConvertToDigitPatterns(sLeft, Me._aOddLeft)
    End Function

    Private Function CountryCode1(ByVal sLeft As String) As String
        Dim sReturn As System.Text.StringBuilder = New StringBuilder
        sReturn.Append(ConvertToDigitPatterns(sLeft.Substring(0, 1), Me._aOddLeft))
        sReturn.Append(ConvertToDigitPatterns(sLeft.Substring(1, 1), Me._aOddLeft))
        sReturn.Append(ConvertToDigitPatterns(sLeft.Substring(2, 1), Me._aEvenLeft))
        sReturn.Append(ConvertToDigitPatterns(sLeft.Substring(3, 1), Me._aOddLeft))
        sReturn.Append(ConvertToDigitPatterns(sLeft.Substring(4, 1), Me._aEvenLeft))
        sReturn.Append(ConvertToDigitPatterns(sLeft.Substring(5, 1), Me._aEvenLeft))
        Return sReturn.ToString
    End Function

    Private Function CountryCode2(ByVal sLeft As String) As String
        Dim sReturn As System.Text.StringBuilder = New StringBuilder
        sReturn.Append(ConvertToDigitPatterns(sLeft.Substring(0, 1), Me._aOddLeft))
        sReturn.Append(ConvertToDigitPatterns(sLeft.Substring(1, 1), Me._aOddLeft))
        sReturn.Append(ConvertToDigitPatterns(sLeft.Substring(2, 1), Me._aEvenLeft))
        sReturn.Append(ConvertToDigitPatterns(sLeft.Substring(3, 1), Me._aEvenLeft))
        sReturn.Append(ConvertToDigitPatterns(sLeft.Substring(4, 1), Me._aOddLeft))
        sReturn.Append(ConvertToDigitPatterns(sLeft.Substring(5, 1), Me._aEvenLeft))
        Return sReturn.ToString
    End Function

    Private Function CountryCode3(ByVal sLeft As String) As String
        Dim sReturn As System.Text.StringBuilder = New StringBuilder
        sReturn.Append(ConvertToDigitPatterns(sLeft.Substring(0, 1), Me._aOddLeft))
        sReturn.Append(ConvertToDigitPatterns(sLeft.Substring(1, 1), Me._aOddLeft))
        sReturn.Append(ConvertToDigitPatterns(sLeft.Substring(2, 1), Me._aEvenLeft))
        sReturn.Append(ConvertToDigitPatterns(sLeft.Substring(3, 1), Me._aEvenLeft))
        sReturn.Append(ConvertToDigitPatterns(sLeft.Substring(4, 1), Me._aEvenLeft))
        sReturn.Append(ConvertToDigitPatterns(sLeft.Substring(5, 1), Me._aOddLeft))
        Return sReturn.ToString
    End Function

    Private Function CountryCode4(ByVal sLeft As String) As String
        Dim sReturn As System.Text.StringBuilder = New StringBuilder
        sReturn.Append(ConvertToDigitPatterns(sLeft.Substring(0, 1), Me._aOddLeft))
        sReturn.Append(ConvertToDigitPatterns(sLeft.Substring(1, 1), Me._aEvenLeft))
        sReturn.Append(ConvertToDigitPatterns(sLeft.Substring(2, 1), Me._aOddLeft))
        sReturn.Append(ConvertToDigitPatterns(sLeft.Substring(3, 1), Me._aOddLeft))
        sReturn.Append(ConvertToDigitPatterns(sLeft.Substring(4, 1), Me._aEvenLeft))
        sReturn.Append(ConvertToDigitPatterns(sLeft.Substring(5, 1), Me._aEvenLeft))
        Return sReturn.ToString
    End Function

    Private Function CountryCode5(ByVal sLeft As String) As String
        Dim sReturn As System.Text.StringBuilder = New StringBuilder
        sReturn.Append(ConvertToDigitPatterns(sLeft.Substring(0, 1), Me._aOddLeft))
        sReturn.Append(ConvertToDigitPatterns(sLeft.Substring(1, 1), Me._aEvenLeft))
        sReturn.Append(ConvertToDigitPatterns(sLeft.Substring(2, 1), Me._aEvenLeft))
        sReturn.Append(ConvertToDigitPatterns(sLeft.Substring(3, 1), Me._aOddLeft))
        sReturn.Append(ConvertToDigitPatterns(sLeft.Substring(4, 1), Me._aOddLeft))
        sReturn.Append(ConvertToDigitPatterns(sLeft.Substring(5, 1), Me._aEvenLeft))
        Return sReturn.ToString
    End Function

    Private Function CountryCode6(ByVal sLeft As String) As String
        Dim sReturn As System.Text.StringBuilder = New StringBuilder
        sReturn.Append(ConvertToDigitPatterns(sLeft.Substring(0, 1), Me._aOddLeft))
        sReturn.Append(ConvertToDigitPatterns(sLeft.Substring(1, 1), Me._aEvenLeft))
        sReturn.Append(ConvertToDigitPatterns(sLeft.Substring(2, 1), Me._aEvenLeft))
        sReturn.Append(ConvertToDigitPatterns(sLeft.Substring(3, 1), Me._aEvenLeft))
        sReturn.Append(ConvertToDigitPatterns(sLeft.Substring(4, 1), Me._aOddLeft))
        sReturn.Append(ConvertToDigitPatterns(sLeft.Substring(5, 1), Me._aOddLeft))
        Return sReturn.ToString
    End Function

    Private Function CountryCode7(ByVal sLeft As String) As String
        Dim sReturn As System.Text.StringBuilder = New StringBuilder
        sReturn.Append(ConvertToDigitPatterns(sLeft.Substring(0, 1), Me._aOddLeft))
        sReturn.Append(ConvertToDigitPatterns(sLeft.Substring(1, 1), Me._aEvenLeft))
        sReturn.Append(ConvertToDigitPatterns(sLeft.Substring(2, 1), Me._aOddLeft))
        sReturn.Append(ConvertToDigitPatterns(sLeft.Substring(3, 1), Me._aEvenLeft))
        sReturn.Append(ConvertToDigitPatterns(sLeft.Substring(4, 1), Me._aOddLeft))
        sReturn.Append(ConvertToDigitPatterns(sLeft.Substring(5, 1), Me._aEvenLeft))
        Return sReturn.ToString
    End Function

    Private Function CountryCode8(ByVal sLeft As String) As String
        Dim sReturn As System.Text.StringBuilder = New StringBuilder
        sReturn.Append(ConvertToDigitPatterns(sLeft.Substring(0, 1), Me._aOddLeft))
        sReturn.Append(ConvertToDigitPatterns(sLeft.Substring(1, 1), Me._aEvenLeft))
        sReturn.Append(ConvertToDigitPatterns(sLeft.Substring(2, 1), Me._aOddLeft))
        sReturn.Append(ConvertToDigitPatterns(sLeft.Substring(3, 1), Me._aEvenLeft))
        sReturn.Append(ConvertToDigitPatterns(sLeft.Substring(4, 1), Me._aEvenLeft))
        sReturn.Append(ConvertToDigitPatterns(sLeft.Substring(5, 1), Me._aOddLeft))
        Return sReturn.ToString
    End Function

    Private Function CountryCode9(ByVal sLeft As String) As String
        Dim sReturn As System.Text.StringBuilder = New StringBuilder
        sReturn.Append(ConvertToDigitPatterns(sLeft.Substring(0, 1), Me._aOddLeft))
        sReturn.Append(ConvertToDigitPatterns(sLeft.Substring(1, 1), Me._aEvenLeft))
        sReturn.Append(ConvertToDigitPatterns(sLeft.Substring(2, 1), Me._aEvenLeft))
        sReturn.Append(ConvertToDigitPatterns(sLeft.Substring(3, 1), Me._aOddLeft))
        sReturn.Append(ConvertToDigitPatterns(sLeft.Substring(4, 1), Me._aEvenLeft))
        sReturn.Append(ConvertToDigitPatterns(sLeft.Substring(5, 1), Me._aOddLeft))
        Return sReturn.ToString
    End Function

    Private Function ConvertToDigitPatterns(ByVal inputNumber As String, ByVal patterns As String()) As String
        Dim sbTemp As System.Text.StringBuilder = New StringBuilder
        Dim iIndex As Integer = 0
        Dim i As Integer = 0
        While i < inputNumber.Length
            iIndex = Convert.ToInt32(inputNumber.Substring(i, 1))
            sbTemp.Append(patterns(iIndex))
            System.Math.Min(System.Threading.Interlocked.Increment(i), i - 1)
        End While
        Return sbTemp.ToString
    End Function

    Public Sub CalculateChecksumDigit()
        Dim sTemp As String = Me.CountryCode + Me.ManufacturerCode + Me.ProductCode
        Dim iSum As Integer = 0
        Dim iDigit As Integer = 0
        Dim i As Integer = sTemp.Length
        While i >= 1
            iDigit = Convert.ToInt32(sTemp.Substring(i - 1, 1))
            If i Mod 2 = 0 Then
                iSum += iDigit * 3
            Else
                iSum += iDigit * 1
            End If
            System.Math.Max(System.Threading.Interlocked.Decrement(i), i + 1)
        End While
        Dim iCheckSum As Integer = (10 - (iSum Mod 10)) Mod 10
        Me.ChecksumDigit = iCheckSum.ToString
    End Sub

    Public ReadOnly Property Name() As String
        Get
            Return _sName
        End Get
    End Property

    Public ReadOnly Property MinimumAllowableScale() As Single
        Get
            Return _fMinimumAllowableScale
        End Get
    End Property

    Public ReadOnly Property MaximumAllowableScale() As Single
        Get
            Return _fMaximumAllowableScale
        End Get
    End Property

    Public ReadOnly Property Width() As Single
        Get
            Return _fWidth
        End Get
    End Property

    Public ReadOnly Property Height() As Single
        Get
            Return _fHeight
        End Get
    End Property

    Public ReadOnly Property FontSize() As Single
        Get
            Return _fFontSize
        End Get
    End Property

    Public Property Scale() As Single
        Get
            Return _fScale
        End Get
        Set(ByVal value As Single)
            If value < Me._fMinimumAllowableScale OrElse value > Me._fMaximumAllowableScale Then
                Throw New Exception("Scale value out of allowable range. Value must be between " + Me._fMinimumAllowableScale.ToString + " and " + Me._fMaximumAllowableScale.ToString)
            End If
            _fScale = value
        End Set
    End Property

    Public Property CountryCode() As String
        Get
            Return _sCountryCode
        End Get
        Set(ByVal value As String)
            While value.Length < 2
                value = "0" + value
            End While
            _sCountryCode = value
        End Set
    End Property

    Public Property ManufacturerCode() As String
        Get
            Return _sManufacturerCode
        End Get
        Set(ByVal value As String)
            _sManufacturerCode = value
        End Set
    End Property

    Public Property ProductCode() As String
        Get
            Return _sProductCode
        End Get
        Set(ByVal value As String)
            _sProductCode = value
        End Set
    End Property

    Public Property ChecksumDigit() As String
        Get
            Return _sChecksumDigit
        End Get
        Set(ByVal value As String)
            Dim iValue As Integer = Convert.ToInt32(value)
            If iValue < 0 OrElse iValue > 9 Then
                Throw New Exception("The Check Digit mst be between 0 and 9.")
            End If
            _sChecksumDigit = value
        End Set
    End Property
End Class
