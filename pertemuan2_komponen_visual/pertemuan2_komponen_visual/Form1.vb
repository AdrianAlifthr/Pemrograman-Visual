Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        MessageBox.Show("Hello World! " & vbCrLf &
                        "Nama : " & txtNama.Text & vbCrLf &
                        "NIM : " & txtNIM.Text & vbCrLf &
                        "KOM : " & txtKOM.Text
        )
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClearForm.Click
        txtNama.Clear()
        txtNIM.Clear()
        txtKOM.Clear()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub
End Class
