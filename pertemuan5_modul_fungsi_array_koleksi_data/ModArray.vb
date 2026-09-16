Module ModArray
    Function Hitung(panjang As Integer, lebar As Integer) As Integer
        Dim result
        If panjang > 50 Then
            result = panjang * lebar
        Else
            result = 2 * panjang + 2 * lebar

        End If
        Return result
    End Function

    Public nilai() As Integer = {70, 80, 90, 100}
    Public nilai2D(,) As Integer = {
        {55, 58, 65},
        {70, 75, 82},
        {84, 86, 90}
    }
End Module
