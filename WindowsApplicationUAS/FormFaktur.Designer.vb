<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFaktur
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormFaktur))
        Me.GroupBoxPrint = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxK = New System.Windows.Forms.TextBox()
        Me.TextBoxJU = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxT = New System.Windows.Forms.TextBox()
        Me.TextBoxN = New System.Windows.Forms.TextBox()
        Me.DataGridViewFaktur = New System.Windows.Forms.DataGridView()
        Me.ColumnCF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnU1F = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnU2F = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnHF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnTF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBoxTT = New System.Windows.Forms.TextBox()
        Me.TextBoxNama = New System.Windows.Forms.TextBox()
        Me.TextBoxJdl = New System.Windows.Forms.TextBox()
        Me.PrintFormFaktur = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.PrintDialogFaktur = New System.Windows.Forms.PrintDialog()
        Me.GroupBoxPrint.SuspendLayout()
        CType(Me.DataGridViewFaktur, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxPrint
        '
        Me.GroupBoxPrint.Controls.Add(Me.TextBox2)
        Me.GroupBoxPrint.Controls.Add(Me.Label4)
        Me.GroupBoxPrint.Controls.Add(Me.TextBoxK)
        Me.GroupBoxPrint.Controls.Add(Me.TextBoxJU)
        Me.GroupBoxPrint.Controls.Add(Me.Label3)
        Me.GroupBoxPrint.Controls.Add(Me.Label2)
        Me.GroupBoxPrint.Controls.Add(Me.Label1)
        Me.GroupBoxPrint.Controls.Add(Me.TextBoxT)
        Me.GroupBoxPrint.Controls.Add(Me.TextBoxN)
        Me.GroupBoxPrint.Controls.Add(Me.DataGridViewFaktur)
        Me.GroupBoxPrint.Controls.Add(Me.TextBoxTT)
        Me.GroupBoxPrint.Controls.Add(Me.TextBoxNama)
        Me.GroupBoxPrint.Controls.Add(Me.TextBoxJdl)
        Me.GroupBoxPrint.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxPrint.Location = New System.Drawing.Point(0, 0)
        Me.GroupBoxPrint.Name = "GroupBoxPrint"
        Me.GroupBoxPrint.Size = New System.Drawing.Size(409, 411)
        Me.GroupBoxPrint.TabIndex = 0
        Me.GroupBoxPrint.TabStop = False
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TextBox2.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(3, 395)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(403, 13)
        Me.TextBox2.TabIndex = 13
        Me.TextBox2.Text = "=================================================================================" & _
    "======="
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 372)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 14)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Kembalian"
        '
        'TextBoxK
        '
        Me.TextBoxK.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxK.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxK.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxK.Location = New System.Drawing.Point(88, 372)
        Me.TextBoxK.Name = "TextBoxK"
        Me.TextBoxK.ReadOnly = True
        Me.TextBoxK.Size = New System.Drawing.Size(304, 20)
        Me.TextBoxK.TabIndex = 11
        Me.TextBoxK.TabStop = False
        Me.TextBoxK.Text = "Kembalian"
        Me.TextBoxK.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBoxJU
        '
        Me.TextBoxJU.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxJU.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxJU.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxJU.Location = New System.Drawing.Point(88, 353)
        Me.TextBoxJU.Name = "TextBoxJU"
        Me.TextBoxJU.ReadOnly = True
        Me.TextBoxJU.Size = New System.Drawing.Size(304, 20)
        Me.TextBoxJU.TabIndex = 10
        Me.TextBoxJU.TabStop = False
        Me.TextBoxJU.Text = "Jumlah Uang"
        Me.TextBoxJU.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 353)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 14)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Jumlah Uang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 334)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 14)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Total"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 14)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Nama"
        '
        'TextBoxT
        '
        Me.TextBoxT.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxT.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxT.Location = New System.Drawing.Point(88, 334)
        Me.TextBoxT.Name = "TextBoxT"
        Me.TextBoxT.ReadOnly = True
        Me.TextBoxT.Size = New System.Drawing.Size(304, 20)
        Me.TextBoxT.TabIndex = 6
        Me.TextBoxT.TabStop = False
        Me.TextBoxT.Text = "Total"
        Me.TextBoxT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBoxN
        '
        Me.TextBoxN.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxN.Enabled = False
        Me.TextBoxN.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxN.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TextBoxN.Location = New System.Drawing.Point(17, 124)
        Me.TextBoxN.MaxLength = 20
        Me.TextBoxN.Name = "TextBoxN"
        Me.TextBoxN.ReadOnly = True
        Me.TextBoxN.Size = New System.Drawing.Size(372, 20)
        Me.TextBoxN.TabIndex = 5
        Me.TextBoxN.Text = "Nama"
        Me.TextBoxN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DataGridViewFaktur
        '
        Me.DataGridViewFaktur.AllowUserToAddRows = False
        Me.DataGridViewFaktur.AllowUserToDeleteRows = False
        Me.DataGridViewFaktur.AllowUserToResizeColumns = False
        Me.DataGridViewFaktur.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewFaktur.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewFaktur.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewFaktur.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridViewFaktur.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridViewFaktur.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewFaktur.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewFaktur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewFaktur.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnCF, Me.ColumnU1F, Me.ColumnU2F, Me.ColumnHF, Me.ColumnTF})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewFaktur.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewFaktur.EnableHeadersVisualStyles = False
        Me.DataGridViewFaktur.GridColor = System.Drawing.SystemColors.Window
        Me.DataGridViewFaktur.Location = New System.Drawing.Point(15, 150)
        Me.DataGridViewFaktur.Name = "DataGridViewFaktur"
        Me.DataGridViewFaktur.ReadOnly = True
        Me.DataGridViewFaktur.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DataGridViewFaktur.RowHeadersVisible = False
        Me.DataGridViewFaktur.Size = New System.Drawing.Size(377, 166)
        Me.DataGridViewFaktur.TabIndex = 0
        Me.DataGridViewFaktur.TabStop = False
        '
        'ColumnCF
        '
        Me.ColumnCF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ColumnCF.HeaderText = "Cetak"
        Me.ColumnCF.Name = "ColumnCF"
        Me.ColumnCF.ReadOnly = True
        Me.ColumnCF.Width = 58
        '
        'ColumnU1F
        '
        Me.ColumnU1F.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Format = "N0"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.ColumnU1F.DefaultCellStyle = DataGridViewCellStyle3
        Me.ColumnU1F.HeaderText = "Ukuran"
        Me.ColumnU1F.Name = "ColumnU1F"
        Me.ColumnU1F.ReadOnly = True
        Me.ColumnU1F.Width = 65
        '
        'ColumnU2F
        '
        Me.ColumnU2F.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Format = "N0"
        Me.ColumnU2F.DefaultCellStyle = DataGridViewCellStyle4
        Me.ColumnU2F.HeaderText = "Ukuran"
        Me.ColumnU2F.Name = "ColumnU2F"
        Me.ColumnU2F.ReadOnly = True
        Me.ColumnU2F.Width = 65
        '
        'ColumnHF
        '
        Me.ColumnHF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle5.Format = "C0"
        Me.ColumnHF.DefaultCellStyle = DataGridViewCellStyle5
        Me.ColumnHF.HeaderText = "Harga"
        Me.ColumnHF.Name = "ColumnHF"
        Me.ColumnHF.ReadOnly = True
        Me.ColumnHF.Width = 59
        '
        'ColumnTF
        '
        Me.ColumnTF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle6.Format = "C0"
        Me.ColumnTF.DefaultCellStyle = DataGridViewCellStyle6
        Me.ColumnTF.HeaderText = "Total"
        Me.ColumnTF.Name = "ColumnTF"
        Me.ColumnTF.ReadOnly = True
        Me.ColumnTF.Width = 54
        '
        'TextBoxTT
        '
        Me.TextBoxTT.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxTT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxTT.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBoxTT.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBoxTT.Location = New System.Drawing.Point(3, 84)
        Me.TextBoxTT.Name = "TextBoxTT"
        Me.TextBoxTT.ReadOnly = True
        Me.TextBoxTT.Size = New System.Drawing.Size(403, 19)
        Me.TextBoxTT.TabIndex = 0
        Me.TextBoxTT.TabStop = False
        Me.TextBoxTT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxNama
        '
        Me.TextBoxNama.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxNama.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxNama.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBoxNama.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNama.Location = New System.Drawing.Point(3, 71)
        Me.TextBoxNama.Name = "TextBoxNama"
        Me.TextBoxNama.ReadOnly = True
        Me.TextBoxNama.Size = New System.Drawing.Size(403, 13)
        Me.TextBoxNama.TabIndex = 0
        Me.TextBoxNama.TabStop = False
        Me.TextBoxNama.Text = "=================================================================================" & _
    "======="
        '
        'TextBoxJdl
        '
        Me.TextBoxJdl.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxJdl.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxJdl.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBoxJdl.Font = New System.Drawing.Font("Agency FB", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxJdl.Location = New System.Drawing.Point(3, 16)
        Me.TextBoxJdl.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBoxJdl.Multiline = True
        Me.TextBoxJdl.Name = "TextBoxJdl"
        Me.TextBoxJdl.ReadOnly = True
        Me.TextBoxJdl.Size = New System.Drawing.Size(403, 55)
        Me.TextBoxJdl.TabIndex = 0
        Me.TextBoxJdl.TabStop = False
        Me.TextBoxJdl.Text = "Terimakasih" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Atas Kepercayaanya"
        Me.TextBoxJdl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PrintFormFaktur
        '
        Me.PrintFormFaktur.DocumentName = "document"
        Me.PrintFormFaktur.Form = Me
        Me.PrintFormFaktur.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview
        Me.PrintFormFaktur.PrinterSettings = CType(resources.GetObject("PrintFormFaktur.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintFormFaktur.PrintFileName = Nothing
        '
        'PrintDialogFaktur
        '
        Me.PrintDialogFaktur.UseEXDialog = True
        '
        'FormFaktur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(409, 411)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBoxPrint)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(450, 450)
        Me.MinimumSize = New System.Drawing.Size(400, 450)
        Me.Name = "FormFaktur"
        Me.Text = "Faktur"
        Me.GroupBoxPrint.ResumeLayout(False)
        Me.GroupBoxPrint.PerformLayout()
        CType(Me.DataGridViewFaktur, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBoxPrint As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxTT As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNama As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxJdl As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewFaktur As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxT As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxN As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBoxK As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxJU As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents ColumnCF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnU1F As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnU2F As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnHF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnTF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrintFormFaktur As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents PrintDialogFaktur As System.Windows.Forms.PrintDialog
End Class
