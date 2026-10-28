<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDariArray
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
        dgvMahasiswa = New System.Windows.Forms.DataGridView()
        colNim = New System.Windows.Forms.DataGridViewTextBoxColumn()
        colNama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        colJurusan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        colAngkatan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        colIpk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        btnTampilkan = New System.Windows.Forms.Button()
        btnKosongkan = New System.Windows.Forms.Button()
        lblJumlah = New System.Windows.Forms.Label()
        CType(dgvMahasiswa, System.ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        '
        'lblJudul
        '
        lblJudul.AutoSize = True
        lblJudul.Font = New System.Drawing.Font("Segoe UI", 14.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblJudul.Location = New System.Drawing.Point(25, 20)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New System.Drawing.Size(256, 25)
        lblJudul.TabIndex = 0
        lblJudul.Text = "Data dari Array 2 Dimensi"
        '
        'dgvMahasiswa
        '
        dgvMahasiswa.AllowUserToAddRows = False
        dgvMahasiswa.AllowUserToDeleteRows = False
        dgvMahasiswa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        dgvMahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMahasiswa.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {colNim, colNama, colJurusan, colAngkatan, colIpk})
        dgvMahasiswa.Location = New System.Drawing.Point(25, 60)
        dgvMahasiswa.MultiSelect = False
        dgvMahasiswa.Name = "dgvMahasiswa"
        dgvMahasiswa.ReadOnly = True
        dgvMahasiswa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        dgvMahasiswa.Size = New System.Drawing.Size(670, 270)
        dgvMahasiswa.TabIndex = 1
        '
        'colNim
        '
        colNim.HeaderText = "NIM"
        colNim.Name = "colNim"
        colNim.ReadOnly = True
        '
        'colNama
        '
        colNama.HeaderText = "Nama"
        colNama.Name = "colNama"
        colNama.ReadOnly = True
        '
        'colJurusan
        '
        colJurusan.HeaderText = "Jurusan"
        colJurusan.Name = "colJurusan"
        colJurusan.ReadOnly = True
        '
        'colAngkatan
        '
        colAngkatan.HeaderText = "Angkatan"
        colAngkatan.Name = "colAngkatan"
        colAngkatan.ReadOnly = True
        '
        'colIpk
        '
        colIpk.HeaderText = "IPK"
        colIpk.Name = "colIpk"
        colIpk.ReadOnly = True
        '
        'btnTampilkan
        '
        btnTampilkan.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        btnTampilkan.Location = New System.Drawing.Point(25, 345)
        btnTampilkan.Name = "btnTampilkan"
        btnTampilkan.Size = New System.Drawing.Size(120, 35)
        btnTampilkan.TabIndex = 2
        btnTampilkan.Text = "Tampilkan"
        btnTampilkan.UseVisualStyleBackColor = True
        '
        'btnKosongkan
        '
        btnKosongkan.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        btnKosongkan.Location = New System.Drawing.Point(155, 345)
        btnKosongkan.Name = "btnKosongkan"
        btnKosongkan.Size = New System.Drawing.Size(120, 35)
        btnKosongkan.TabIndex = 3
        btnKosongkan.Text = "Kosongkan"
        btnKosongkan.UseVisualStyleBackColor = True
        '
        'lblJumlah
        '
        lblJumlah.AutoSize = True
        lblJumlah.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblJumlah.Location = New System.Drawing.Point(290, 355)
        lblJumlah.Name = "lblJumlah"
        lblJumlah.Size = New System.Drawing.Size(83, 15)
        lblJumlah.TabIndex = 4
        lblJumlah.Text = "Jumlah data: 0"
        '
        'FrmDariArray
        '
        AutoScaleDimensions = New System.Drawing.SizeF(7.0F, 15.0F)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        ClientSize = New System.Drawing.Size(720, 400)
        Controls.Add(lblJumlah)
        Controls.Add(btnKosongkan)
        Controls.Add(btnTampilkan)
        Controls.Add(dgvMahasiswa)
        Controls.Add(lblJudul)
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "FrmDariArray"
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Text = "DataGridView dari Array"
        CType(dgvMahasiswa, System.ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents dgvMahasiswa As System.Windows.Forms.DataGridView
    Friend WithEvents colNim As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNama As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colJurusan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAngkatan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colIpk As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnTampilkan As System.Windows.Forms.Button
    Friend WithEvents btnKosongkan As System.Windows.Forms.Button
    Friend WithEvents lblJumlah As System.Windows.Forms.Label
End Class
