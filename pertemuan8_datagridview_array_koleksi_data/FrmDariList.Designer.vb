<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDariList
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
        btnTambah = New System.Windows.Forms.Button()
        dgvMahasiswa = New System.Windows.Forms.DataGridView()
        lblJumlah = New System.Windows.Forms.Label()
        bsMahasiswa = New System.Windows.Forms.BindingSource(components)
        errInput = New System.Windows.Forms.ErrorProvider(components)
        CType(dgvMahasiswa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(bsMahasiswa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(errInput, System.ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        '
        'lblJudul
        '
        lblJudul.AutoSize = True
        lblJudul.Font = New System.Drawing.Font("Segoe UI", 14.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblJudul.Location = New System.Drawing.Point(25, 20)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New System.Drawing.Size(342, 25)
        lblJudul.TabIndex = 0
        lblJudul.Text = "List(Of Mahasiswa) + BindingSource"
        '
        'lblNim
        '
        lblNim.AutoSize = True
        lblNim.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblNim.Location = New System.Drawing.Point(25, 60)
        lblNim.Name = "lblNim"
        lblNim.Size = New System.Drawing.Size(30, 15)
        lblNim.TabIndex = 1
        lblNim.Text = "NIM"
        '
        'txtNim
        '
        txtNim.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        txtNim.Location = New System.Drawing.Point(25, 80)
        txtNim.MaxLength = 9
        txtNim.Name = "txtNim"
        txtNim.Size = New System.Drawing.Size(120, 23)
        txtNim.TabIndex = 2
        '
        'lblNama
        '
        lblNama.AutoSize = True
        lblNama.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblNama.Location = New System.Drawing.Point(160, 60)
        lblNama.Name = "lblNama"
        lblNama.Size = New System.Drawing.Size(39, 15)
        lblNama.TabIndex = 3
        lblNama.Text = "Nama"
        '
        'txtNama
        '
        txtNama.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        txtNama.Location = New System.Drawing.Point(160, 80)
        txtNama.Name = "txtNama"
        txtNama.Size = New System.Drawing.Size(180, 23)
        txtNama.TabIndex = 4
        '
        'lblJurusan
        '
        lblJurusan.AutoSize = True
        lblJurusan.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblJurusan.Location = New System.Drawing.Point(355, 60)
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
        cboJurusan.Location = New System.Drawing.Point(355, 80)
        cboJurusan.Name = "cboJurusan"
        cboJurusan.Size = New System.Drawing.Size(170, 23)
        cboJurusan.TabIndex = 6
        '
        'lblAngkatan
        '
        lblAngkatan.AutoSize = True
        lblAngkatan.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblAngkatan.Location = New System.Drawing.Point(540, 60)
        lblAngkatan.Name = "lblAngkatan"
        lblAngkatan.Size = New System.Drawing.Size(58, 15)
        lblAngkatan.TabIndex = 7
        lblAngkatan.Text = "Angkatan"
        '
        'txtAngkatan
        '
        txtAngkatan.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        txtAngkatan.Location = New System.Drawing.Point(540, 80)
        txtAngkatan.MaxLength = 4
        txtAngkatan.Name = "txtAngkatan"
        txtAngkatan.Size = New System.Drawing.Size(80, 23)
        txtAngkatan.TabIndex = 8
        '
        'lblIpk
        '
        lblIpk.AutoSize = True
        lblIpk.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblIpk.Location = New System.Drawing.Point(635, 60)
        lblIpk.Name = "lblIpk"
        lblIpk.Size = New System.Drawing.Size(24, 15)
        lblIpk.TabIndex = 9
        lblIpk.Text = "IPK"
        '
        'txtIpk
        '
        txtIpk.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        txtIpk.Location = New System.Drawing.Point(635, 80)
        txtIpk.MaxLength = 4
        txtIpk.Name = "txtIpk"
        txtIpk.Size = New System.Drawing.Size(85, 23)
        txtIpk.TabIndex = 10
        '
        'btnTambah
        '
        btnTambah.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        btnTambah.Location = New System.Drawing.Point(25, 120)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New System.Drawing.Size(120, 32)
        btnTambah.TabIndex = 11
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        '
        'dgvMahasiswa
        '
        dgvMahasiswa.AllowUserToAddRows = False
        dgvMahasiswa.AllowUserToDeleteRows = False
        dgvMahasiswa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        dgvMahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMahasiswa.Location = New System.Drawing.Point(25, 165)
        dgvMahasiswa.MultiSelect = False
        dgvMahasiswa.Name = "dgvMahasiswa"
        dgvMahasiswa.ReadOnly = True
        dgvMahasiswa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        dgvMahasiswa.Size = New System.Drawing.Size(710, 255)
        dgvMahasiswa.TabIndex = 12
        '
        'lblJumlah
        '
        lblJumlah.AutoSize = True
        lblJumlah.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblJumlah.Location = New System.Drawing.Point(25, 435)
        lblJumlah.Name = "lblJumlah"
        lblJumlah.Size = New System.Drawing.Size(83, 15)
        lblJumlah.TabIndex = 13
        lblJumlah.Text = "Jumlah data: 0"
        '
        'errInput
        '
        errInput.ContainerControl = Me
        '
        'FrmDariList
        '
        AcceptButton = btnTambah
        AutoScaleDimensions = New System.Drawing.SizeF(7.0F, 15.0F)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        ClientSize = New System.Drawing.Size(760, 470)
        Controls.Add(lblJumlah)
        Controls.Add(dgvMahasiswa)
        Controls.Add(btnTambah)
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
        Name = "FrmDariList"
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Text = "Binding List(Of Mahasiswa)"
        CType(dgvMahasiswa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(bsMahasiswa, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents dgvMahasiswa As System.Windows.Forms.DataGridView
    Friend WithEvents lblJumlah As System.Windows.Forms.Label
    Friend WithEvents bsMahasiswa As System.Windows.Forms.BindingSource
    Friend WithEvents errInput As System.Windows.Forms.ErrorProvider
End Class
