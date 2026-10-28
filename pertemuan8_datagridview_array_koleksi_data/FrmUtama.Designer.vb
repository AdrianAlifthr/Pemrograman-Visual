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
        btnDariArray = New System.Windows.Forms.Button()
        btnDariList = New System.Windows.Forms.Button()
        btnDataTable = New System.Windows.Forms.Button()
        btnCariList = New System.Windows.Forms.Button()
        SuspendLayout()
        '
        'lblJudul
        '
        lblJudul.AutoSize = True
        lblJudul.Font = New System.Drawing.Font("Segoe UI", 14.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblJudul.Location = New System.Drawing.Point(30, 20)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New System.Drawing.Size(189, 25)
        lblJudul.TabIndex = 0
        lblJudul.Text = "Contoh Pertemuan 8"
        '
        'btnDariArray
        '
        btnDariArray.Font = New System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        btnDariArray.Location = New System.Drawing.Point(30, 65)
        btnDariArray.Name = "btnDariArray"
        btnDariArray.Size = New System.Drawing.Size(380, 42)
        btnDariArray.TabIndex = 1
        btnDariArray.Text = "1. DataGridView dari Array"
        btnDariArray.UseVisualStyleBackColor = True
        '
        'btnDariList
        '
        btnDariList.Font = New System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        btnDariList.Location = New System.Drawing.Point(30, 117)
        btnDariList.Name = "btnDariList"
        btnDariList.Size = New System.Drawing.Size(380, 42)
        btnDariList.TabIndex = 2
        btnDariList.Text = "2. Binding List(Of Mahasiswa)"
        btnDariList.UseVisualStyleBackColor = True
        '
        'btnDataTable
        '
        btnDataTable.Font = New System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        btnDataTable.Location = New System.Drawing.Point(30, 169)
        btnDataTable.Name = "btnDataTable"
        btnDataTable.Size = New System.Drawing.Size(380, 42)
        btnDataTable.TabIndex = 3
        btnDataTable.Text = "3. DataTable, Rapikan Kolom dan Filter"
        btnDataTable.UseVisualStyleBackColor = True
        '
        'btnCariList
        '
        btnCariList.Font = New System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        btnCariList.Location = New System.Drawing.Point(30, 221)
        btnCariList.Name = "btnCariList"
        btnCariList.Size = New System.Drawing.Size(380, 42)
        btnCariList.TabIndex = 4
        btnCariList.Text = "4. Pencarian dengan Perulangan"
        btnCariList.UseVisualStyleBackColor = True
        '
        'FrmUtama
        '
        AutoScaleDimensions = New System.Drawing.SizeF(7.0F, 15.0F)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        ClientSize = New System.Drawing.Size(440, 300)
        Controls.Add(btnCariList)
        Controls.Add(btnDataTable)
        Controls.Add(btnDariList)
        Controls.Add(btnDariArray)
        Controls.Add(lblJudul)
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "FrmUtama"
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Text = "Pertemuan 8 - DataGridView, Array & Koleksi Data"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents btnDariArray As System.Windows.Forms.Button
    Friend WithEvents btnDariList As System.Windows.Forms.Button
    Friend WithEvents btnDataTable As System.Windows.Forms.Button
    Friend WithEvents btnCariList As System.Windows.Forms.Button
End Class
