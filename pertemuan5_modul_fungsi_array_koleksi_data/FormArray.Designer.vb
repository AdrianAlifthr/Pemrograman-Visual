<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormArray
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
        components = New ComponentModel.Container()
        btnTampilkan = New Button()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        txtPanjang = New TextBox()
        lblPanjang = New Label()
        txtLebar = New TextBox()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        lblLebar = New Label()
        lstNilai = New ListBox()
        SuspendLayout()
        ' 
        ' btnTampilkan
        ' 
        btnTampilkan.Font = New Font("Segoe UI", 12F)
        btnTampilkan.Location = New Point(415, 414)
        btnTampilkan.Name = "btnTampilkan"
        btnTampilkan.Size = New Size(130, 52)
        btnTampilkan.TabIndex = 0
        btnTampilkan.Text = "Tampilkan"
        btnTampilkan.UseVisualStyleBackColor = True
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' txtPanjang
        ' 
        txtPanjang.Location = New Point(425, 97)
        txtPanjang.Name = "txtPanjang"
        txtPanjang.Size = New Size(173, 23)
        txtPanjang.TabIndex = 2
        ' 
        ' lblPanjang
        ' 
        lblPanjang.AutoSize = True
        lblPanjang.Location = New Point(363, 100)
        lblPanjang.Name = "lblPanjang"
        lblPanjang.Size = New Size(56, 15)
        lblPanjang.TabIndex = 4
        lblPanjang.Text = "Panjang :"
        ' 
        ' txtLebar
        ' 
        txtLebar.Location = New Point(425, 138)
        txtLebar.Name = "txtLebar"
        txtLebar.Size = New Size(173, 23)
        txtLebar.TabIndex = 5
        ' 
        ' lblLebar
        ' 
        lblLebar.AutoSize = True
        lblLebar.Location = New Point(363, 141)
        lblLebar.Name = "lblLebar"
        lblLebar.Size = New Size(42, 15)
        lblLebar.TabIndex = 6
        lblLebar.Text = "Lebar :"
        ' 
        ' lstNilai
        ' 
        lstNilai.FormattingEnabled = True
        lstNilai.Location = New Point(363, 196)
        lstNilai.Name = "lstNilai"
        lstNilai.Size = New Size(235, 184)
        lstNilai.TabIndex = 7
        ' 
        ' FormArray
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1015, 596)
        Controls.Add(lstNilai)
        Controls.Add(lblLebar)
        Controls.Add(txtLebar)
        Controls.Add(lblPanjang)
        Controls.Add(txtPanjang)
        Controls.Add(btnTampilkan)
        Name = "FormArray"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnTampilkan As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents txtPanjang As TextBox
    Friend WithEvents lblPanjang As Label
    Friend WithEvents txtLebar As TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblLebar As Label
    Friend WithEvents lstNilai As ListBox

End Class
