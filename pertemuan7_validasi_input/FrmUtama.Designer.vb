<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmUtama
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
        lblJudul = New System.Windows.Forms.Label()
        btnUjiKonversi = New System.Windows.Forms.Button()
        btnPendaftaran = New System.Windows.Forms.Button()
        SuspendLayout()
        '
        'lblJudul
        '
        lblJudul.AutoSize = True
        lblJudul.Font = New System.Drawing.Font("Segoe UI", 14.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblJudul.Location = New System.Drawing.Point(30, 24)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New System.Drawing.Size(189, 25)
        lblJudul.TabIndex = 0
        lblJudul.Text = "Contoh Pertemuan 7"
        '
        'btnUjiKonversi
        '
        btnUjiKonversi.Font = New System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        btnUjiKonversi.Location = New System.Drawing.Point(30, 75)
        btnUjiKonversi.Name = "btnUjiKonversi"
        btnUjiKonversi.Size = New System.Drawing.Size(360, 45)
        btnUjiKonversi.TabIndex = 1
        btnUjiKonversi.Text = "Uji Konversi: CInt, Val, TryParse, Try...Catch"
        btnUjiKonversi.UseVisualStyleBackColor = True
        '
        'btnPendaftaran
        '
        btnPendaftaran.Font = New System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        btnPendaftaran.Location = New System.Drawing.Point(30, 135)
        btnPendaftaran.Name = "btnPendaftaran"
        btnPendaftaran.Size = New System.Drawing.Size(360, 45)
        btnPendaftaran.TabIndex = 2
        btnPendaftaran.Text = "Form Pendaftaran Mahasiswa"
        btnPendaftaran.UseVisualStyleBackColor = True
        '
        'FrmUtama
        '
        AutoScaleDimensions = New System.Drawing.SizeF(7.0F, 15.0F)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        ClientSize = New System.Drawing.Size(420, 220)
        Controls.Add(btnPendaftaran)
        Controls.Add(btnUjiKonversi)
        Controls.Add(lblJudul)
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "FrmUtama"
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Text = "Pertemuan 7 - Validasi & Error Handling"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents btnUjiKonversi As System.Windows.Forms.Button
    Friend WithEvents btnPendaftaran As System.Windows.Forms.Button
End Class
