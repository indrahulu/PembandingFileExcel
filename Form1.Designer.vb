<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFileLama = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFileBaru = New System.Windows.Forms.TextBox()
        Me.dlgPilihFile = New System.Windows.Forms.OpenFileDialog()
        Me.btnPilihFileLama = New System.Windows.Forms.Button()
        Me.btnPilihFileBaru = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnMulai = New System.Windows.Forms.Button()
        Me.btnTutup = New System.Windows.Forms.Button()
        Me.lblLaporan = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.numBarisMulai = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.numKolomMulai = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.numBarisSelesai = New System.Windows.Forms.NumericUpDown()
        Me.numKolomSelesai = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSheetName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.numBarisMulai, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numKolomMulai, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numBarisSelesai, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numKolomSelesai, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(581, 80)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(10)
        Me.Label2.Size = New System.Drawing.Size(577, 76)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Pembanding File Excel"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Pilih File Excel &LAMA"
        '
        'txtFileLama
        '
        Me.txtFileLama.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFileLama.Location = New System.Drawing.Point(12, 117)
        Me.txtFileLama.Name = "txtFileLama"
        Me.txtFileLama.ReadOnly = True
        Me.txtFileLama.Size = New System.Drawing.Size(476, 20)
        Me.txtFileLama.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Pilih File Excel &BARU"
        '
        'txtFileBaru
        '
        Me.txtFileBaru.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFileBaru.Location = New System.Drawing.Point(12, 174)
        Me.txtFileBaru.Name = "txtFileBaru"
        Me.txtFileBaru.ReadOnly = True
        Me.txtFileBaru.Size = New System.Drawing.Size(476, 20)
        Me.txtFileBaru.TabIndex = 4
        '
        'dlgPilihFile
        '
        Me.dlgPilihFile.DefaultExt = "xlsx"
        Me.dlgPilihFile.Filter = "File Excel|*.xlsx"
        '
        'btnPilihFileLama
        '
        Me.btnPilihFileLama.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPilihFileLama.Location = New System.Drawing.Point(494, 115)
        Me.btnPilihFileLama.Name = "btnPilihFileLama"
        Me.btnPilihFileLama.Size = New System.Drawing.Size(75, 23)
        Me.btnPilihFileLama.TabIndex = 2
        Me.btnPilihFileLama.Text = "Pilih File..."
        Me.btnPilihFileLama.UseVisualStyleBackColor = True
        '
        'btnPilihFileBaru
        '
        Me.btnPilihFileBaru.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPilihFileBaru.Location = New System.Drawing.Point(494, 171)
        Me.btnPilihFileBaru.Name = "btnPilihFileBaru"
        Me.btnPilihFileBaru.Size = New System.Drawing.Size(75, 23)
        Me.btnPilihFileBaru.TabIndex = 5
        Me.btnPilihFileBaru.Text = "Pilih File..."
        Me.btnPilihFileBaru.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 338)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(557, 5)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'btnMulai
        '
        Me.btnMulai.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMulai.Location = New System.Drawing.Point(494, 369)
        Me.btnMulai.Name = "btnMulai"
        Me.btnMulai.Size = New System.Drawing.Size(75, 23)
        Me.btnMulai.TabIndex = 16
        Me.btnMulai.Text = "&Mulai"
        Me.btnMulai.UseVisualStyleBackColor = True
        '
        'btnTutup
        '
        Me.btnTutup.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTutup.Location = New System.Drawing.Point(413, 369)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(75, 23)
        Me.btnTutup.TabIndex = 17
        Me.btnTutup.Text = "&Tutup"
        Me.btnTutup.UseVisualStyleBackColor = True
        '
        'lblLaporan
        '
        Me.lblLaporan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblLaporan.AutoSize = True
        Me.lblLaporan.Location = New System.Drawing.Point(13, 379)
        Me.lblLaporan.Name = "lblLaporan"
        Me.lblLaporan.Size = New System.Drawing.Size(48, 13)
        Me.lblLaporan.TabIndex = 11
        Me.lblLaporan.Text = "[laporan]"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 268)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "B&aris ke:"
        '
        'numBarisMulai
        '
        Me.numBarisMulai.Location = New System.Drawing.Point(69, 266)
        Me.numBarisMulai.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.numBarisMulai.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numBarisMulai.Name = "numBarisMulai"
        Me.numBarisMulai.Size = New System.Drawing.Size(56, 20)
        Me.numBarisMulai.TabIndex = 9
        Me.numBarisMulai.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numBarisMulai.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 294)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "K&olom ke:"
        '
        'numKolomMulai
        '
        Me.numKolomMulai.Location = New System.Drawing.Point(69, 292)
        Me.numKolomMulai.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.numKolomMulai.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numKolomMulai.Name = "numKolomMulai"
        Me.numKolomMulai.Size = New System.Drawing.Size(56, 20)
        Me.numKolomMulai.TabIndex = 13
        Me.numKolomMulai.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numKolomMulai.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(141, 268)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "s/d:"
        '
        'numBarisSelesai
        '
        Me.numBarisSelesai.Location = New System.Drawing.Point(173, 266)
        Me.numBarisSelesai.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.numBarisSelesai.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numBarisSelesai.Name = "numBarisSelesai"
        Me.numBarisSelesai.Size = New System.Drawing.Size(56, 20)
        Me.numBarisSelesai.TabIndex = 11
        Me.numBarisSelesai.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numBarisSelesai.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'numKolomSelesai
        '
        Me.numKolomSelesai.Location = New System.Drawing.Point(173, 292)
        Me.numKolomSelesai.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.numKolomSelesai.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numKolomSelesai.Name = "numKolomSelesai"
        Me.numKolomSelesai.Size = New System.Drawing.Size(56, 20)
        Me.numKolomSelesai.TabIndex = 15
        Me.numKolomSelesai.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numKolomSelesai.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(141, 294)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "s/d:"
        '
        'txtSheetName
        '
        Me.txtSheetName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSheetName.Location = New System.Drawing.Point(12, 231)
        Me.txtSheetName.Name = "txtSheetName"
        Me.txtSheetName.Size = New System.Drawing.Size(557, 20)
        Me.txtSheetName.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 215)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Masukkan nama &Worksheet:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 404)
        Me.Controls.Add(Me.txtSheetName)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.numKolomSelesai)
        Me.Controls.Add(Me.numBarisSelesai)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.numKolomMulai)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.numBarisMulai)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblLaporan)
        Me.Controls.Add(Me.btnTutup)
        Me.Controls.Add(Me.btnMulai)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnPilihFileBaru)
        Me.Controls.Add(Me.btnPilihFileLama)
        Me.Controls.Add(Me.txtFileBaru)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtFileLama)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Pembanding File Excel"
        Me.Panel1.ResumeLayout(False)
        CType(Me.numBarisMulai, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numKolomMulai, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numBarisSelesai, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numKolomSelesai, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFileLama As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtFileBaru As TextBox
    Friend WithEvents dlgPilihFile As OpenFileDialog
    Friend WithEvents btnPilihFileLama As Button
    Friend WithEvents btnPilihFileBaru As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnMulai As Button
    Friend WithEvents btnTutup As Button
    Friend WithEvents lblLaporan As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents numBarisMulai As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents numKolomMulai As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents numBarisSelesai As NumericUpDown
    Friend WithEvents numKolomSelesai As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSheetName As TextBox
    Friend WithEvents Label8 As Label
End Class
