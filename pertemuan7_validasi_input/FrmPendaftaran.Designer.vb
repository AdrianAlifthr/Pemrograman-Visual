<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPendaftaran
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
        components = New System.ComponentModel.Container()
        lblJudul = New System.Windows.Forms.Label()
        lblNim = New System.Windows.Forms.Label()
        txtNim = New System.Windows.Forms.TextBox()
        lblNama = New System.Windows.Forms.Label()
        txtNama = New System.Windows.Forms.TextBox()
        lblJurusan = New System.Windows.Forms.Label()
        cboJurusan = New System.Windows.Forms.ComboBox()
        lblAngkatan = New System.Windows.Forms.Label()
        txtAngkatan = New System.Windows.Forms.TextBox()
        lblIpk = New System.Windows.Forms.Label()
        txtIpk = New System.Windows.Forms.TextBox()
        btnSimpan = New System.Windows.Forms.Button()
        btnBersihkan = New System.Windows.Forms.Button()
        lblDaftar = New System.Windows.Forms.Label()
        lstMahasiswa = New System.Windows.Forms.ListBox()
        btnEkspor = New System.Windows.Forms.Button()
        lblStatus = New System.Windows.Forms.Label()
        errInput = New System.Windows.Forms.ErrorProvider(components)
        CType(errInput, System.ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        '
        'lblJudul
        '
        lblJudul.AutoSize = True
        lblJudul.Font = New System.Drawing.Font("Segoe UI", 14.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblJudul.Location = New System.Drawing.Point(25, 20)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New System.Drawing.Size(222, 25)
        lblJudul.TabIndex = 0
        lblJudul.Text = "Pendaftaran Mahasiswa"
        '
        'lblNim
        '
        lblNim.AutoSize = True
        lblNim.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblNim.Location = New System.Drawing.Point(25, 62)
        lblNim.Name = "lblNim"
        lblNim.Size = New System.Drawing.Size(30, 15)
        lblNim.TabIndex = 1
        lblNim.Text = "NIM"
        '
        'txtNim
        '
        txtNim.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        txtNim.Location = New System.Drawing.Point(25, 84)
        txtNim.MaxLength = 9
        txtNim.Name = "txtNim"
        txtNim.Size = New System.Drawing.Size(270, 23)
        txtNim.TabIndex = 2
        '
        'lblNama
        '
        lblNama.AutoSize = True
        lblNama.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblNama.Location = New System.Drawing.Point(25, 118)
        lblNama.Name = "lblNama"
        lblNama.Size = New System.Drawing.Size(39, 15)
        lblNama.TabIndex = 3
        lblNama.Text = "Nama"
        '
        'txtNama
        '
        txtNama.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        txtNama.Location = New System.Drawing.Point(25, 140)
        txtNama.MaxLength = 100
        txtNama.Name = "txtNama"
        txtNama.Size = New System.Drawing.Size(270, 23)
        txtNama.TabIndex = 4
        '
        'lblJurusan
        '
        lblJurusan.AutoSize = True
        lblJurusan.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblJurusan.Location = New System.Drawing.Point(25, 174)
        lblJurusan.Name = "lblJurusan"
        lblJurusan.Size = New System.Drawing.Size(47, 15)
        lblJurusan.TabIndex = 5
        lblJurusan.Text = "Jurusan"
        '
        'cboJurusan
        '
        cboJurusan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        cboJurusan.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        cboJurusan.FormattingEnabled = True
        cboJurusan.Items.AddRange(New Object() {"Teknik Informatika", "Sistem Informasi", "Manajemen Informatika", "Teknik Komputer"})
        cboJurusan.Location = New System.Drawing.Point(25, 196)
        cboJurusan.Name = "cboJurusan"
        cboJurusan.Size = New System.Drawing.Size(270, 23)
        cboJurusan.TabIndex = 6
        '
        'lblAngkatan
        '
        lblAngkatan.AutoSize = True
        lblAngkatan.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblAngkatan.Location = New System.Drawing.Point(25, 230)
        lblAngkatan.Name = "lblAngkatan"
        lblAngkatan.Size = New System.Drawing.Size(58, 15)
        lblAngkatan.TabIndex = 7
        lblAngkatan.Text = "Angkatan"
        '
        'txtAngkatan
        '
        txtAngkatan.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        txtAngkatan.Location = New System.Drawing.Point(25, 252)
        txtAngkatan.MaxLength = 4
        txtAngkatan.Name = "txtAngkatan"
        txtAngkatan.Size = New System.Drawing.Size(270, 23)
        txtAngkatan.TabIndex = 8
        '
        'lblIpk
        '
        lblIpk.AutoSize = True
        lblIpk.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblIpk.Location = New System.Drawing.Point(25, 286)
        lblIpk.Name = "lblIpk"
        lblIpk.Size = New System.Drawing.Size(24, 15)
        lblIpk.TabIndex = 9
        lblIpk.Text = "IPK"
        '
        'txtIpk
        '
        txtIpk.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        txtIpk.Location = New System.Drawing.Point(25, 308)
        txtIpk.MaxLength = 4
        txtIpk.Name = "txtIpk"
        txtIpk.Size = New System.Drawing.Size(270, 23)
        txtIpk.TabIndex = 10
        '
        'btnSimpan
        '
        btnSimpan.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        btnSimpan.Location = New System.Drawing.Point(25, 355)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New System.Drawing.Size(130, 35)
        btnSimpan.TabIndex = 11
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        '
        'btnBersihkan
        '
        btnBersihkan.CausesValidation = False
        btnBersihkan.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        btnBersihkan.Location = New System.Drawing.Point(165, 355)
        btnBersihkan.Name = "btnBersihkan"
        btnBersihkan.Size = New System.Drawing.Size(130, 35)
        btnBersihkan.TabIndex = 12
        btnBersihkan.Text = "Bersihkan"
        btnBersihkan.UseVisualStyleBackColor = True
        '
        'lblDaftar
        '
        lblDaftar.AutoSize = True
        lblDaftar.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblDaftar.Location = New System.Drawing.Point(330, 62)
        lblDaftar.Name = "lblDaftar"
        lblDaftar.Size = New System.Drawing.Size(84, 15)
        lblDaftar.TabIndex = 13
        lblDaftar.Text = "Data tersimpan"
        '
        'lstMahasiswa
        '
        lstMahasiswa.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lstMahasiswa.FormattingEnabled = True
        lstMahasiswa.HorizontalScrollbar = True
        lstMahasiswa.IntegralHeight = False
        lstMahasiswa.ItemHeight = 15
        lstMahasiswa.Location = New System.Drawing.Point(330, 84)
        lstMahasiswa.Name = "lstMahasiswa"
        lstMahasiswa.Size = New System.Drawing.Size(425, 250)
        lstMahasiswa.TabIndex = 14
        '
        'btnEkspor
        '
        btnEkspor.CausesValidation = False
        btnEkspor.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        btnEkspor.Location = New System.Drawing.Point(330, 355)
        btnEkspor.Name = "btnEkspor"
        btnEkspor.Size = New System.Drawing.Size(425, 35)
        btnEkspor.TabIndex = 15
        btnEkspor.Text = "Ekspor ke CSV"
        btnEkspor.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        lblStatus.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblStatus.Location = New System.Drawing.Point(25, 415)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New System.Drawing.Size(730, 30)
        lblStatus.TabIndex = 16
        lblStatus.Text = "Siap."
        lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'errInput
        '
        errInput.ContainerControl = Me
        '
        'FrmPendaftaran
        '
        AcceptButton = btnSimpan
        AutoScaleDimensions = New System.Drawing.SizeF(7.0F, 15.0F)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        ClientSize = New System.Drawing.Size(780, 470)
        Controls.Add(lblStatus)
        Controls.Add(btnEkspor)
        Controls.Add(lstMahasiswa)
        Controls.Add(lblDaftar)
        Controls.Add(btnBersihkan)
        Controls.Add(btnSimpan)
        Controls.Add(txtIpk)
        Controls.Add(lblIpk)
        Controls.Add(txtAngkatan)
        Controls.Add(lblAngkatan)
        Controls.Add(cboJurusan)
        Controls.Add(lblJurusan)
        Controls.Add(txtNama)
        Controls.Add(lblNama)
        Controls.Add(txtNim)
        Controls.Add(lblNim)
        Controls.Add(lblJudul)
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "FrmPendaftaran"
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Text = "Pendaftaran Mahasiswa"
        CType(errInput, System.ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents lblNim As System.Windows.Forms.Label
    Friend WithEvents txtNim As System.Windows.Forms.TextBox
    Friend WithEvents lblNama As System.Windows.Forms.Label
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents lblJurusan As System.Windows.Forms.Label
    Friend WithEvents cboJurusan As System.Windows.Forms.ComboBox
    Friend WithEvents lblAngkatan As System.Windows.Forms.Label
    Friend WithEvents txtAngkatan As System.Windows.Forms.TextBox
    Friend WithEvents lblIpk As System.Windows.Forms.Label
    Friend WithEvents txtIpk As System.Windows.Forms.TextBox
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnBersihkan As System.Windows.Forms.Button
    Friend WithEvents lblDaftar As System.Windows.Forms.Label
    Friend WithEvents lstMahasiswa As System.Windows.Forms.ListBox
    Friend WithEvents btnEkspor As System.Windows.Forms.Button
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents errInput As System.Windows.Forms.ErrorProvider
End Class
