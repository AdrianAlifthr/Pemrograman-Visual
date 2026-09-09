Public Class FormProfile

    Private userName As String
    Private userRole As String
    Private userHouse As String
    Private userYear As String
    Private userWand As String

    Public Sub New(
    name As String,
    role As String,
    house As String,
    year As String,
    wand As String
)

        InitializeComponent()

        userName = name
        userRole = role
        userHouse = house
        userYear = year
        userWand = wand

    End Sub


    Private Sub FormProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblName.Text = userName
        lblRole.Text = "Role : " & userRole
        lblHouse.Text = "House : " & userHouse
        lblYear.Text = "Year : " & userYear
        lblWand.Text = "Wand : " & userWand


        lblName.Text = userName
        lblRole.Text = "Role : " & userRole
        lblHouse.Text = "House : " & userHouse
        lblYear.Text = "Year : " & userYear
        lblWand.Text = "Wand : " & userWand

        ' Menentukan gambar berdasarkan House
        Select Case userHouse

            Case "Gryffindor"
                picProfile.Image = Image.FromFile(
                Application.StartupPath & "\Assets\gryffindor.png"
            )

            Case "Slytherin"
                picProfile.Image = Image.FromFile(
                Application.StartupPath & "\Assets\slytherin.png"
            )

            Case "Ravenclaw"
                picProfile.Image = Image.FromFile(
                Application.StartupPath & "\Assets\ravenclaw.png"
            )

            Case "Hufflepuff"
                picProfile.Image = Image.FromFile(
                Application.StartupPath & "\Assets\hufflepuff.png"
            )

        End Select


    End Sub


    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        Form1.txtUsername.Clear()
        Form1.txtPassword.Clear()

        Form1.Show()
        Me.Close()

    End Sub

    Private Sub lblHouse_Click(sender As Object, e As EventArgs) Handles lblHouse.Click

    End Sub
End Class