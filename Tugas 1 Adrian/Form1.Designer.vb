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
        picImage = New PictureBox()
        cmbRole = New ComboBox()
        Label1 = New Label()
        lblNama = New Label()
        lblNim = New Label()
        txtNama = New TextBox()
        txtNim = New TextBox()
        btnLogin = New Button()
        CType(picImage, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picImage
        ' 
        picImage.Location = New Point(335, 26)
        picImage.Name = "picImage"
        picImage.Size = New Size(133, 112)
        picImage.SizeMode = PictureBoxSizeMode.StretchImage
        picImage.TabIndex = 0
        picImage.TabStop = False
        ' 
        ' cmbRole
        ' 
        cmbRole.FormattingEnabled = True
        cmbRole.Items.AddRange(New Object() {"Staff", "Manajer"})
        cmbRole.Location = New Point(368, 156)
        cmbRole.Name = "cmbRole"
        cmbRole.Size = New Size(121, 23)
        cmbRole.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(274, 159)
        Label1.Name = "Label1"
        Label1.Size = New Size(30, 15)
        Label1.TabIndex = 2
        Label1.Text = "Role"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(274, 197)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(39, 15)
        lblNama.TabIndex = 3
        lblNama.Text = "Nama"
        ' 
        ' lblNim
        ' 
        lblNim.AutoSize = True
        lblNim.Location = New Point(274, 236)
        lblNim.Name = "lblNim"
        lblNim.Size = New Size(30, 15)
        lblNim.TabIndex = 4
        lblNim.Text = "NIM"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(368, 194)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(100, 23)
        txtNama.TabIndex = 5
        ' 
        ' txtNim
        ' 
        txtNim.Location = New Point(368, 228)
        txtNim.Name = "txtNim"
        txtNim.Size = New Size(100, 23)
        txtNim.TabIndex = 6
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(343, 294)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(75, 23)
        btnLogin.TabIndex = 7
        btnLogin.Text = "Log in"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnLogin)
        Controls.Add(txtNim)
        Controls.Add(txtNama)
        Controls.Add(lblNim)
        Controls.Add(lblNama)
        Controls.Add(Label1)
        Controls.Add(cmbRole)
        Controls.Add(picImage)
        Name = "Form1"
        Text = "Form1"
        CType(picImage, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picImage As PictureBox
    Friend WithEvents cmbRole As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblNim As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNim As TextBox
    Friend WithEvents btnLogin As Button

End Class
