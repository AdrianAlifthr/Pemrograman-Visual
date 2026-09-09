<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtPendapatan = New TextBox()
        btnHitung = New Button()
        btnKeluar = New Button()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(276, 70)
        Label1.Name = "Label1"
        Label1.Size = New Size(290, 21)
        Label1.TabIndex = 0
        Label1.Text = "Pendapatan Lebih dari 5 juta, 10 % pajak" & vbCrLf
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(272, 101)
        Label2.Name = "Label2"
        Label2.Size = New Size(298, 21)
        Label2.TabIndex = 1
        Label2.Text = "Pendapatan Lebih dari 30 juta, 20 % Pajak"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(271, 135)
        Label3.Name = "Label3"
        Label3.Size = New Size(303, 21)
        Label3.TabIndex = 2
        Label3.Text = "Pendapatan lebih dari 100 juta, 30 % Pajak"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(336, 224)
        Label4.Name = "Label4"
        Label4.Size = New Size(24, 15)
        Label4.TabIndex = 3
        Label4.Text = "Rp."
        ' 
        ' txtPendapatan
        ' 
        txtPendapatan.Location = New Point(366, 221)
        txtPendapatan.Name = "txtPendapatan"
        txtPendapatan.Size = New Size(100, 23)
        txtPendapatan.TabIndex = 4
        ' 
        ' btnHitung
        ' 
        btnHitung.Location = New Point(376, 262)
        btnHitung.Name = "btnHitung"
        btnHitung.Size = New Size(75, 23)
        btnHitung.TabIndex = 5
        btnHitung.Text = "Hitung"
        btnHitung.UseVisualStyleBackColor = True
        ' 
        ' btnKeluar
        ' 
        btnKeluar.Location = New Point(376, 301)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(75, 23)
        btnKeluar.TabIndex = 6
        btnKeluar.Text = "Keluar"
        btnKeluar.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(353, 203)
        Label5.Name = "Label5"
        Label5.Size = New Size(127, 15)
        Label5.TabIndex = 7
        Label5.Text = "Masukkan Pendapatan"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label5)
        Controls.Add(btnKeluar)
        Controls.Add(btnHitung)
        Controls.Add(txtPendapatan)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPendapatan As TextBox
    Friend WithEvents btnHitung As Button
    Friend WithEvents btnKeluar As Button
    Friend WithEvents Label5 As Label
End Class
