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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        picLogo = New PictureBox()
        LabelJudul = New Label()
        LabelUsername = New Label()
        LabelPassword = New Label()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        btnLogin = New Button()
        CType(picLogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picLogo
        ' 
        picLogo.Image = CType(resources.GetObject("picLogo.Image"), Image)
        picLogo.Location = New Point(280, 42)
        picLogo.Name = "picLogo"
        picLogo.Size = New Size(209, 195)
        picLogo.SizeMode = PictureBoxSizeMode.StretchImage
        picLogo.TabIndex = 0
        picLogo.TabStop = False
        ' 
        ' LabelJudul
        ' 
        LabelJudul.AutoSize = True
        LabelJudul.Font = New Font("Papyrus", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelJudul.Location = New Point(315, 266)
        LabelJudul.Name = "LabelJudul"
        LabelJudul.Size = New Size(137, 24)
        LabelJudul.TabIndex = 1
        LabelJudul.Text = "Identify Yourself"
        ' 
        ' LabelUsername
        ' 
        LabelUsername.AutoSize = True
        LabelUsername.Font = New Font("Papyrus", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelUsername.Location = New Point(280, 308)
        LabelUsername.Name = "LabelUsername"
        LabelUsername.Size = New Size(67, 19)
        LabelUsername.TabIndex = 2
        LabelUsername.Text = "Username"
        ' 
        ' LabelPassword
        ' 
        LabelPassword.AutoSize = True
        LabelPassword.Font = New Font("Papyrus", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelPassword.Location = New Point(280, 345)
        LabelPassword.Name = "LabelPassword"
        LabelPassword.Size = New Size(61, 19)
        LabelPassword.TabIndex = 3
        LabelPassword.Text = "Password"
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Papyrus", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsername.Location = New Point(371, 305)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(100, 26)
        txtUsername.TabIndex = 4
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Papyrus", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPassword.Location = New Point(371, 342)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(100, 26)
        txtPassword.TabIndex = 5
        ' 
        ' btnLogin
        ' 
        btnLogin.Font = New Font("Papyrus", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.Location = New Point(344, 393)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(75, 31)
        btnLogin.TabIndex = 6
        btnLogin.Text = "Enter"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnLogin)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(LabelPassword)
        Controls.Add(LabelUsername)
        Controls.Add(LabelJudul)
        Controls.Add(picLogo)
        Name = "Form1"
        Text = "Form1"
        CType(picLogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picLogo As PictureBox
    Friend WithEvents LabelJudul As Label
    Friend WithEvents LabelUsername As Label
    Friend WithEvents LabelPassword As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text

        ' Data siswa
        If username = "harry" And password = "expelliarmus" Then

            Dim profile As New FormProfile(
                    "Harry Potter",
                    "Student",
                    "Gryffindor",
                    "3rd Year",
                    "Holly, Phoenix Feather"
                )

            profile.Show()
            Me.Hide()

        ElseIf username = "hermione" And password = "leviosa" Then

            Dim profile As New FormProfile(
                    "Hermione Granger",
                    "Student",
                    "Gryffindor",
                    "3rd Year",
                    "Vine Wood, Dragon Heartstring"
                )

            profile.Show()
            Me.Hide()

        ElseIf username = "draco" And password = "pureblood" Then

            Dim profile As New FormProfile(
                    "Draco Malfoy",
                    "Student",
                    "Slytherin",
                    "3rd Year",
                    "Hawthorn, Unicorn Hair"
                )

            profile.Show()
            Me.Hide()

        ElseIf username = "snape" And password = "always" Then

            Dim profile As New FormProfile(
                    "Severus Snape",
                    "Professor",
                    "Slytherin",
                    "Potions Master",
                    "Yew, Phoenix Feather"
                )

            profile.Show()
            Me.Hide()

        Else

            MessageBox.Show(
                    "Unauthorized access detected." & vbCrLf &
                    "You are not recognized as a member of Hogwarts." & vbCrLf &
                    "Perhaps you should reconsider your choice of password.",
                    "HOGWARTS SECURITY",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )

        End If


    End Sub
End Class

