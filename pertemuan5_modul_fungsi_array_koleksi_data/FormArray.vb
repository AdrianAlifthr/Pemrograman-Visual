Public Class FormArray
    Private Sub btnTampilkan_Click(sender As Object, e As EventArgs) Handles btnTampilkan.Click
        'MessageBox.Show(Hitung(txtPanjang.Text, txtLebar.Text))
        'For i As Integer = 0 To nilai.Length - 1
        '    lstNilai.Items.Add(nilai(i))
        'Next
        lstNilai.Items.Add(nilai2D(1, 2))
    End Sub

    Private Sub txtPanjang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPanjang.KeyPress, txtLebar.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class
