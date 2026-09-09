<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPerulangan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblNilaiawal = New Label()
        txtNilaiAwal = New TextBox()
        lblNilaiAkhir = New Label()
        txtNilaiAkhir = New TextBox()
        btnInput = New Button()
        lstHasil = New ListBox()
        SuspendLayout()
        ' 
        ' lblNilaiawal
        ' 
        lblNilaiawal.AutoSize = True
        lblNilaiawal.Location = New Point(358, 122)
        lblNilaiawal.Name = "lblNilaiawal"
        lblNilaiawal.Size = New Size(69, 15)
        lblNilaiawal.TabIndex = 0
        lblNilaiawal.Text = "Nilai Awal : "
        ' 
        ' txtNilaiAwal
        ' 
        txtNilaiAwal.Location = New Point(342, 140)
        txtNilaiAwal.Name = "txtNilaiAwal"
        txtNilaiAwal.Size = New Size(100, 23)
        txtNilaiAwal.TabIndex = 1
        ' 
        ' lblNilaiAkhir
        ' 
        lblNilaiAkhir.AutoSize = True
        lblNilaiAkhir.Location = New Point(358, 207)
        lblNilaiAkhir.Name = "lblNilaiAkhir"
        lblNilaiAkhir.Size = New Size(62, 15)
        lblNilaiAkhir.TabIndex = 2
        lblNilaiAkhir.Text = "Nilai Akhir"
        ' 
        ' txtNilaiAkhir
        ' 
        txtNilaiAkhir.Location = New Point(342, 225)
        txtNilaiAkhir.Name = "txtNilaiAkhir"
        txtNilaiAkhir.Size = New Size(100, 23)
        txtNilaiAkhir.TabIndex = 3
        ' 
        ' btnInput
        ' 
        btnInput.Location = New Point(358, 299)
        btnInput.Name = "btnInput"
        btnInput.Size = New Size(75, 23)
        btnInput.TabIndex = 4
        btnInput.Text = "input"
        btnInput.UseVisualStyleBackColor = True
        ' 
        ' lstHasil
        ' 
        lstHasil.FormattingEnabled = True
        lstHasil.Location = New Point(336, 344)
        lstHasil.Name = "lstHasil"
        lstHasil.Size = New Size(120, 94)
        lstHasil.TabIndex = 5
        ' 
        ' FrmPerulangan
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lstHasil)
        Controls.Add(btnInput)
        Controls.Add(txtNilaiAkhir)
        Controls.Add(lblNilaiAkhir)
        Controls.Add(txtNilaiAwal)
        Controls.Add(lblNilaiawal)
        Name = "FrmPerulangan"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblNilaiawal As Label
    Friend WithEvents txtNilaiAwal As TextBox
    Friend WithEvents lblNilaiAkhir As Label
    Friend WithEvents txtNilaiAkhir As TextBox
    Friend WithEvents btnInput As Button
    Friend WithEvents lstHasil As ListBox

End Class
