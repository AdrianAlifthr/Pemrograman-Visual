<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        lblNama = New Label()
        txtNama = New TextBox()
        lblNIM = New Label()
        txtNIM = New TextBox()
        lblKOM = New Label()
        txtKOM = New TextBox()
        btnSubmit = New Button()
        btnClearForm = New Button()
        btnKeluar = New Button()
        SuspendLayout()
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(212, 80)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(51, 15)
        lblNama.TabIndex = 0
        lblNama.Text = "Nama   :"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(269, 77)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(202, 23)
        txtNama.TabIndex = 1
        ' 
        ' lblNIM
        ' 
        lblNIM.AutoSize = True
        lblNIM.Location = New Point(212, 114)
        lblNIM.Name = "lblNIM"
        lblNIM.Size = New Size(51, 15)
        lblNIM.TabIndex = 2
        lblNIM.Text = "NIM      :"
        ' 
        ' txtNIM
        ' 
        txtNIM.Location = New Point(269, 111)
        txtNIM.Name = "txtNIM"
        txtNIM.Size = New Size(202, 23)
        txtNIM.TabIndex = 3
        ' 
        ' lblKOM
        ' 
        lblKOM.AutoSize = True
        lblKOM.Location = New Point(212, 149)
        lblKOM.Name = "lblKOM"
        lblKOM.Size = New Size(51, 15)
        lblKOM.TabIndex = 4
        lblKOM.Text = "KOM     :"
        ' 
        ' txtKOM
        ' 
        txtKOM.Location = New Point(269, 149)
        txtKOM.Name = "txtKOM"
        txtKOM.Size = New Size(202, 23)
        txtKOM.TabIndex = 5
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Location = New Point(285, 206)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(136, 45)
        btnSubmit.TabIndex = 7
        btnSubmit.Text = "Submit"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' btnClearForm
        ' 
        btnClearForm.Location = New Point(123, 205)
        btnClearForm.Name = "btnClearForm"
        btnClearForm.Size = New Size(136, 46)
        btnClearForm.TabIndex = 8
        btnClearForm.Text = "Clear Form"
        btnClearForm.UseVisualStyleBackColor = True
        ' 
        ' btnKeluar
        ' 
        btnKeluar.Location = New Point(446, 205)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(130, 45)
        btnKeluar.TabIndex = 9
        btnKeluar.Text = "Keluar"
        btnKeluar.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(714, 405)
        Controls.Add(btnKeluar)
        Controls.Add(btnClearForm)
        Controls.Add(btnSubmit)
        Controls.Add(txtKOM)
        Controls.Add(lblKOM)
        Controls.Add(txtNIM)
        Controls.Add(lblNIM)
        Controls.Add(txtNama)
        Controls.Add(lblNama)
        Name = "Form1"
        Text = "Profile Mahasiswa"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblNama As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents lblNIM As Label
    Friend WithEvents txtNIM As TextBox
    Friend WithEvents lblKOM As Label
    Friend WithEvents txtKOM As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnClearForm As Button
    Friend WithEvents btnKeluar As Button

End Class
