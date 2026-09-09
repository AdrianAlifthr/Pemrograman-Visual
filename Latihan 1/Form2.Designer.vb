<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProfile
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        picProfile = New PictureBox()
        lblName = New Label()
        lblHouse = New Label()
        lblRole = New Label()
        lblYear = New Label()
        lblWand = New Label()
        btnLogout = New Button()
        CType(picProfile, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picProfile
        ' 
        picProfile.Location = New Point(280, 42)
        picProfile.Name = "picProfile"
        picProfile.Size = New Size(209, 195)
        picProfile.SizeMode = PictureBoxSizeMode.StretchImage
        picProfile.TabIndex = 0
        picProfile.TabStop = False
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Font = New Font("Papyrus", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblName.Location = New Point(280, 252)
        lblName.Name = "lblName"
        lblName.Size = New Size(56, 19)
        lblName.TabIndex = 1
        lblName.Text = "lblName"
        ' 
        ' lblHouse
        ' 
        lblHouse.AutoSize = True
        lblHouse.Font = New Font("Papyrus", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblHouse.Location = New Point(280, 281)
        lblHouse.Name = "lblHouse"
        lblHouse.Size = New Size(61, 19)
        lblHouse.TabIndex = 2
        lblHouse.Text = "lblHouse"
        ' 
        ' lblRole
        ' 
        lblRole.AutoSize = True
        lblRole.Font = New Font("Papyrus", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblRole.Location = New Point(280, 309)
        lblRole.Name = "lblRole"
        lblRole.Size = New Size(49, 19)
        lblRole.TabIndex = 3
        lblRole.Text = "lblRole"
        ' 
        ' lblYear
        ' 
        lblYear.AutoSize = True
        lblYear.Font = New Font("Papyrus", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblYear.Location = New Point(280, 337)
        lblYear.Name = "lblYear"
        lblYear.Size = New Size(50, 19)
        lblYear.TabIndex = 4
        lblYear.Text = "lblYear"
        ' 
        ' lblWand
        ' 
        lblWand.AutoSize = True
        lblWand.Font = New Font("Papyrus", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblWand.Location = New Point(281, 365)
        lblWand.Name = "lblWand"
        lblWand.Size = New Size(55, 19)
        lblWand.TabIndex = 5
        lblWand.Text = "lblWand"
        ' 
        ' btnLogout
        ' 
        btnLogout.Font = New Font("Papyrus", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogout.Location = New Point(341, 404)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(75, 34)
        btnLogout.TabIndex = 6
        btnLogout.Text = "Log Out"
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' FormProfile
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnLogout)
        Controls.Add(lblWand)
        Controls.Add(lblYear)
        Controls.Add(lblRole)
        Controls.Add(lblHouse)
        Controls.Add(lblName)
        Controls.Add(picProfile)
        Name = "FormProfile"
        Text = "FormProfile.vb"
        CType(picProfile, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picProfile As PictureBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblHouse As Label
    Friend WithEvents lblRole As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents lblWand As Label
    Friend WithEvents btnLogout As Button
End Class
