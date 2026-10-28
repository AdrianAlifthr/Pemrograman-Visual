<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmUjiKonversi
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
        lblPetunjuk = New System.Windows.Forms.Label()
        lblInput = New System.Windows.Forms.Label()
        txtInput = New System.Windows.Forms.TextBox()
        btnCInt = New System.Windows.Forms.Button()
        btnVal = New System.Windows.Forms.Button()
        btnTryParse = New System.Windows.Forms.Button()
        btnTryCatch = New System.Windows.Forms.Button()
        btnCatchBertingkat = New System.Windows.Forms.Button()
        lblHasil = New System.Windows.Forms.Label()
        SuspendLayout()
        '
        'lblJudul
        '
        lblJudul.AutoSize = True
        lblJudul.Font = New System.Drawing.Font("Segoe UI", 14.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblJudul.Location = New System.Drawing.Point(24, 18)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New System.Drawing.Size(176, 25)
        lblJudul.TabIndex = 0
        lblJudul.Text = "Uji Konversi Input"
        '
        'lblPetunjuk
        '
        lblPetunjuk.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblPetunjuk.Location = New System.Drawing.Point(24, 52)
        lblPetunjuk.Name = "lblPetunjuk"
        lblPetunjuk.Size = New System.Drawing.Size(592, 38)
        lblPetunjuk.TabIndex = 1
        lblPetunjuk.Text = "Ketik sebuah nilai lalu coba setiap tombol. Coba: 25, abc, 12abc, 3,5, 99999999999, atau kosong."
        '
        'lblInput
        '
        lblInput.AutoSize = True
        lblInput.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblInput.Location = New System.Drawing.Point(24, 102)
        lblInput.Name = "lblInput"
        lblInput.Size = New System.Drawing.Size(38, 15)
        lblInput.TabIndex = 2
        lblInput.Text = "Input:"
        '
        'txtInput
        '
        txtInput.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        txtInput.Location = New System.Drawing.Point(75, 99)
        txtInput.Name = "txtInput"
        txtInput.Size = New System.Drawing.Size(200, 23)
        txtInput.TabIndex = 3
        '
        'btnCInt
        '
        btnCInt.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        btnCInt.Location = New System.Drawing.Point(24, 140)
        btnCInt.Name = "btnCInt"
        btnCInt.Size = New System.Drawing.Size(184, 35)
        btnCInt.TabIndex = 4
        btnCInt.Text = "CInt (tanpa Try)"
        btnCInt.UseVisualStyleBackColor = True
        '
        'btnVal
        '
        btnVal.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        btnVal.Location = New System.Drawing.Point(228, 140)
        btnVal.Name = "btnVal"
        btnVal.Size = New System.Drawing.Size(184, 35)
        btnVal.TabIndex = 5
        btnVal.Text = "Val"
        btnVal.UseVisualStyleBackColor = True
        '
        'btnTryParse
        '
        btnTryParse.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        btnTryParse.Location = New System.Drawing.Point(432, 140)
        btnTryParse.Name = "btnTryParse"
        btnTryParse.Size = New System.Drawing.Size(184, 35)
        btnTryParse.TabIndex = 6
        btnTryParse.Text = "TryParse"
        btnTryParse.UseVisualStyleBackColor = True
        '
        'btnTryCatch
        '
        btnTryCatch.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        btnTryCatch.Location = New System.Drawing.Point(24, 185)
        btnTryCatch.Name = "btnTryCatch"
        btnTryCatch.Size = New System.Drawing.Size(184, 35)
        btnTryCatch.TabIndex = 7
        btnTryCatch.Text = "Try...Catch"
        btnTryCatch.UseVisualStyleBackColor = True
        '
        'btnCatchBertingkat
        '
        btnCatchBertingkat.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        btnCatchBertingkat.Location = New System.Drawing.Point(228, 185)
        btnCatchBertingkat.Name = "btnCatchBertingkat"
        btnCatchBertingkat.Size = New System.Drawing.Size(184, 35)
        btnCatchBertingkat.TabIndex = 8
        btnCatchBertingkat.Text = "Catch Bertingkat"
        btnCatchBertingkat.UseVisualStyleBackColor = True
        '
        'lblHasil
        '
        lblHasil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        lblHasil.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblHasil.Location = New System.Drawing.Point(24, 235)
        lblHasil.Name = "lblHasil"
        lblHasil.Padding = New System.Windows.Forms.Padding(8)
        lblHasil.Size = New System.Drawing.Size(592, 75)
        lblHasil.TabIndex = 9
        lblHasil.Text = "Hasil akan tampil di sini."
        '
        'FrmUjiKonversi
        '
        AutoScaleDimensions = New System.Drawing.SizeF(7.0F, 15.0F)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        ClientSize = New System.Drawing.Size(640, 340)
        Controls.Add(lblHasil)
        Controls.Add(btnCatchBertingkat)
        Controls.Add(btnTryCatch)
        Controls.Add(btnTryParse)
        Controls.Add(btnVal)
        Controls.Add(btnCInt)
        Controls.Add(txtInput)
        Controls.Add(lblInput)
        Controls.Add(lblPetunjuk)
        Controls.Add(lblJudul)
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "FrmUjiKonversi"
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Text = "Uji Konversi Input"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents lblPetunjuk As System.Windows.Forms.Label
    Friend WithEvents lblInput As System.Windows.Forms.Label
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents btnCInt As System.Windows.Forms.Button
    Friend WithEvents btnVal As System.Windows.Forms.Button
    Friend WithEvents btnTryParse As System.Windows.Forms.Button
    Friend WithEvents btnTryCatch As System.Windows.Forms.Button
    Friend WithEvents btnCatchBertingkat As System.Windows.Forms.Button
    Friend WithEvents lblHasil As System.Windows.Forms.Label
End Class
