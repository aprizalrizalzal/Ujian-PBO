<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPenjualan
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
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPenjualan))
        Me.GroupBoxBiaya = New System.Windows.Forms.GroupBox()
        Me.ButtonCetak = New System.Windows.Forms.Button()
        Me.GroupBoxSemua = New System.Windows.Forms.GroupBox()
        Me.DataGridViewTambah = New System.Windows.Forms.DataGridView()
        Me.ColumnC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnU1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnU2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnH = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBoxKembalian = New System.Windows.Forms.TextBox()
        Me.LabelKem = New System.Windows.Forms.Label()
        Me.TextBoxTotalBiaya = New System.Windows.Forms.TextBox()
        Me.LabelTotalS = New System.Windows.Forms.Label()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.TextBoxJmlhU = New System.Windows.Forms.TextBox()
        Me.LabelJU = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.ButtonBersihkan = New System.Windows.Forms.Button()
        Me.TextBoxNohpDP = New System.Windows.Forms.TextBox()
        Me.LabelNoHp = New System.Windows.Forms.Label()
        Me.TextBoxAlamat = New System.Windows.Forms.TextBox()
        Me.LabelAlamat = New System.Windows.Forms.Label()
        Me.GroupBoxPenjualan = New System.Windows.Forms.GroupBox()
        Me.GroupBoxDPen = New System.Windows.Forms.GroupBox()
        Me.CheckBoxLembar = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMeter = New System.Windows.Forms.CheckBox()
        Me.TextBoxTotal = New System.Windows.Forms.TextBox()
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ComboBoxHar = New System.Windows.Forms.ComboBox()
        Me.LabelHar = New System.Windows.Forms.Label()
        Me.TextBoxULeb = New System.Windows.Forms.TextBox()
        Me.LabelUL = New System.Windows.Forms.Label()
        Me.TextBoxUPan = New System.Windows.Forms.TextBox()
        Me.LabelUP = New System.Windows.Forms.Label()
        Me.ComboBoxC = New System.Windows.Forms.ComboBox()
        Me.LabelC = New System.Windows.Forms.Label()
        Me.ComboBoxJC = New System.Windows.Forms.ComboBox()
        Me.LabelJC = New System.Windows.Forms.Label()
        Me.ButtonOK = New System.Windows.Forms.Button()
        Me.TextBoxKdTrans = New System.Windows.Forms.TextBox()
        Me.LabelKTrns = New System.Windows.Forms.Label()
        Me.TextBoxTglTrns = New System.Windows.Forms.TextBox()
        Me.LabelTrns = New System.Windows.Forms.Label()
        Me.GroupBoxPel = New System.Windows.Forms.GroupBox()
        Me.CheckBoxAddMem = New System.Windows.Forms.CheckBox()
        Me.ComboBoxIDMem = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxNamaDP = New System.Windows.Forms.TextBox()
        Me.LabelNama = New System.Windows.Forms.Label()
        Me.PictureBoxPenjualan = New System.Windows.Forms.PictureBox()
        Me.PrintForm = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.GroupBoxBiaya.SuspendLayout()
        Me.GroupBoxSemua.SuspendLayout()
        CType(Me.DataGridViewTambah, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxPenjualan.SuspendLayout()
        Me.GroupBoxDPen.SuspendLayout()
        Me.GroupBoxPel.SuspendLayout()
        CType(Me.PictureBoxPenjualan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxBiaya
        '
        Me.GroupBoxBiaya.Controls.Add(Me.ButtonCetak)
        Me.GroupBoxBiaya.Controls.Add(Me.GroupBoxSemua)
        Me.GroupBoxBiaya.Controls.Add(Me.TextBoxKembalian)
        Me.GroupBoxBiaya.Controls.Add(Me.LabelKem)
        Me.GroupBoxBiaya.Controls.Add(Me.TextBoxTotalBiaya)
        Me.GroupBoxBiaya.Controls.Add(Me.LabelTotalS)
        Me.GroupBoxBiaya.Controls.Add(Me.ButtonExit)
        Me.GroupBoxBiaya.Controls.Add(Me.TextBoxJmlhU)
        Me.GroupBoxBiaya.Controls.Add(Me.LabelJU)
        Me.GroupBoxBiaya.Controls.Add(Me.Label19)
        Me.GroupBoxBiaya.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBoxBiaya.Location = New System.Drawing.Point(612, 16)
        Me.GroupBoxBiaya.Name = "GroupBoxBiaya"
        Me.GroupBoxBiaya.Padding = New System.Windows.Forms.Padding(15)
        Me.GroupBoxBiaya.Size = New System.Drawing.Size(307, 467)
        Me.GroupBoxBiaya.TabIndex = 20
        Me.GroupBoxBiaya.TabStop = False
        Me.GroupBoxBiaya.Text = "Biaya"
        '
        'ButtonCetak
        '
        Me.ButtonCetak.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonCetak.Location = New System.Drawing.Point(12, 433)
        Me.ButtonCetak.Name = "ButtonCetak"
        Me.ButtonCetak.Size = New System.Drawing.Size(172, 25)
        Me.ButtonCetak.TabIndex = 18
        Me.ButtonCetak.Text = "Cetak"
        Me.ButtonCetak.UseVisualStyleBackColor = True
        '
        'GroupBoxSemua
        '
        Me.GroupBoxSemua.Controls.Add(Me.DataGridViewTambah)
        Me.GroupBoxSemua.Location = New System.Drawing.Point(12, 163)
        Me.GroupBoxSemua.Name = "GroupBoxSemua"
        Me.GroupBoxSemua.Size = New System.Drawing.Size(277, 256)
        Me.GroupBoxSemua.TabIndex = 0
        Me.GroupBoxSemua.TabStop = False
        '
        'DataGridViewTambah
        '
        Me.DataGridViewTambah.AllowUserToAddRows = False
        Me.DataGridViewTambah.AllowUserToDeleteRows = False
        Me.DataGridViewTambah.AllowUserToResizeColumns = False
        Me.DataGridViewTambah.AllowUserToResizeRows = False
        Me.DataGridViewTambah.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewTambah.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridViewTambah.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridViewTambah.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTambah.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle19
        Me.DataGridViewTambah.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewTambah.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnC, Me.ColumnU1, Me.ColumnU2, Me.ColumnH, Me.ColumnT})
        Me.DataGridViewTambah.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewTambah.GridColor = System.Drawing.SystemColors.Window
        Me.DataGridViewTambah.Location = New System.Drawing.Point(3, 16)
        Me.DataGridViewTambah.MultiSelect = False
        Me.DataGridViewTambah.Name = "DataGridViewTambah"
        Me.DataGridViewTambah.ReadOnly = True
        Me.DataGridViewTambah.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DataGridViewTambah.RowHeadersVisible = False
        Me.DataGridViewTambah.Size = New System.Drawing.Size(271, 237)
        Me.DataGridViewTambah.TabIndex = 0
        Me.DataGridViewTambah.TabStop = False
        '
        'ColumnC
        '
        Me.ColumnC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.ColumnC.DefaultCellStyle = DataGridViewCellStyle20
        Me.ColumnC.HeaderText = "Cetak"
        Me.ColumnC.Name = "ColumnC"
        Me.ColumnC.ReadOnly = True
        Me.ColumnC.Width = 5
        '
        'ColumnU1
        '
        Me.ColumnU1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle21.Format = "N0"
        DataGridViewCellStyle21.NullValue = Nothing
        DataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.ColumnU1.DefaultCellStyle = DataGridViewCellStyle21
        Me.ColumnU1.HeaderText = "Ukuran"
        Me.ColumnU1.Name = "ColumnU1"
        Me.ColumnU1.ReadOnly = True
        Me.ColumnU1.Width = 67
        '
        'ColumnU2
        '
        Me.ColumnU2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle22.Format = "N0"
        DataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.ColumnU2.DefaultCellStyle = DataGridViewCellStyle22
        Me.ColumnU2.HeaderText = "Ukuran"
        Me.ColumnU2.Name = "ColumnU2"
        Me.ColumnU2.ReadOnly = True
        Me.ColumnU2.Width = 67
        '
        'ColumnH
        '
        Me.ColumnH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        DataGridViewCellStyle23.Format = "C0"
        DataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.ColumnH.DefaultCellStyle = DataGridViewCellStyle23
        Me.ColumnH.HeaderText = "Harga"
        Me.ColumnH.Name = "ColumnH"
        Me.ColumnH.ReadOnly = True
        Me.ColumnH.Width = 5
        '
        'ColumnT
        '
        Me.ColumnT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        DataGridViewCellStyle24.Format = "C0"
        DataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.ColumnT.DefaultCellStyle = DataGridViewCellStyle24
        Me.ColumnT.HeaderText = "Total"
        Me.ColumnT.Name = "ColumnT"
        Me.ColumnT.ReadOnly = True
        Me.ColumnT.Width = 5
        '
        'TextBoxKembalian
        '
        Me.TextBoxKembalian.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxKembalian.Location = New System.Drawing.Point(15, 137)
        Me.TextBoxKembalian.MaxLength = 20
        Me.TextBoxKembalian.Name = "TextBoxKembalian"
        Me.TextBoxKembalian.ReadOnly = True
        Me.TextBoxKembalian.Size = New System.Drawing.Size(274, 20)
        Me.TextBoxKembalian.TabIndex = 17
        '
        'LabelKem
        '
        Me.LabelKem.AutoSize = True
        Me.LabelKem.Location = New System.Drawing.Point(15, 114)
        Me.LabelKem.Name = "LabelKem"
        Me.LabelKem.Padding = New System.Windows.Forms.Padding(0, 5, 5, 5)
        Me.LabelKem.Size = New System.Drawing.Size(61, 23)
        Me.LabelKem.TabIndex = 0
        Me.LabelKem.Text = "Kembalian"
        '
        'TextBoxTotalBiaya
        '
        Me.TextBoxTotalBiaya.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxTotalBiaya.Location = New System.Drawing.Point(15, 94)
        Me.TextBoxTotalBiaya.MaxLength = 20
        Me.TextBoxTotalBiaya.Name = "TextBoxTotalBiaya"
        Me.TextBoxTotalBiaya.ReadOnly = True
        Me.TextBoxTotalBiaya.Size = New System.Drawing.Size(274, 20)
        Me.TextBoxTotalBiaya.TabIndex = 16
        '
        'LabelTotalS
        '
        Me.LabelTotalS.AutoSize = True
        Me.LabelTotalS.Location = New System.Drawing.Point(15, 71)
        Me.LabelTotalS.Name = "LabelTotalS"
        Me.LabelTotalS.Padding = New System.Windows.Forms.Padding(0, 5, 5, 5)
        Me.LabelTotalS.Size = New System.Drawing.Size(36, 23)
        Me.LabelTotalS.TabIndex = 0
        Me.LabelTotalS.Text = "Total"
        '
        'ButtonExit
        '
        Me.ButtonExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonExit.Location = New System.Drawing.Point(186, 433)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(103, 25)
        Me.ButtonExit.TabIndex = 20
        Me.ButtonExit.Text = "Keluar"
        Me.ButtonExit.UseVisualStyleBackColor = True
        '
        'TextBoxJmlhU
        '
        Me.TextBoxJmlhU.Location = New System.Drawing.Point(15, 51)
        Me.TextBoxJmlhU.MaxLength = 20
        Me.TextBoxJmlhU.Name = "TextBoxJmlhU"
        Me.TextBoxJmlhU.Size = New System.Drawing.Size(274, 20)
        Me.TextBoxJmlhU.TabIndex = 15
        '
        'LabelJU
        '
        Me.LabelJU.AutoSize = True
        Me.LabelJU.Location = New System.Drawing.Point(15, 28)
        Me.LabelJU.Name = "LabelJU"
        Me.LabelJU.Padding = New System.Windows.Forms.Padding(0, 5, 5, 5)
        Me.LabelJU.Size = New System.Drawing.Size(74, 23)
        Me.LabelJU.TabIndex = 0
        Me.LabelJU.Text = "Jumlah Uang"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(22, 103)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(0, 13)
        Me.Label19.TabIndex = 19
        '
        'ButtonBersihkan
        '
        Me.ButtonBersihkan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonBersihkan.Location = New System.Drawing.Point(265, 276)
        Me.ButtonBersihkan.Name = "ButtonBersihkan"
        Me.ButtonBersihkan.Size = New System.Drawing.Size(122, 25)
        Me.ButtonBersihkan.TabIndex = 19
        Me.ButtonBersihkan.Text = "Bersihkan"
        Me.ButtonBersihkan.UseVisualStyleBackColor = True
        '
        'TextBoxNohpDP
        '
        Me.TextBoxNohpDP.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxNohpDP.Location = New System.Drawing.Point(139, 109)
        Me.TextBoxNohpDP.MaxLength = 12
        Me.TextBoxNohpDP.Name = "TextBoxNohpDP"
        Me.TextBoxNohpDP.Size = New System.Drawing.Size(185, 20)
        Me.TextBoxNohpDP.TabIndex = 3
        '
        'LabelNoHp
        '
        Me.LabelNoHp.AutoSize = True
        Me.LabelNoHp.Location = New System.Drawing.Point(16, 109)
        Me.LabelNoHp.Name = "LabelNoHp"
        Me.LabelNoHp.Padding = New System.Windows.Forms.Padding(0, 5, 5, 5)
        Me.LabelNoHp.Size = New System.Drawing.Size(43, 23)
        Me.LabelNoHp.TabIndex = 0
        Me.LabelNoHp.Text = "No.Hp"
        '
        'TextBoxAlamat
        '
        Me.TextBoxAlamat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxAlamat.Location = New System.Drawing.Point(139, 83)
        Me.TextBoxAlamat.MaxLength = 250
        Me.TextBoxAlamat.Name = "TextBoxAlamat"
        Me.TextBoxAlamat.Size = New System.Drawing.Size(224, 20)
        Me.TextBoxAlamat.TabIndex = 2
        '
        'LabelAlamat
        '
        Me.LabelAlamat.AutoSize = True
        Me.LabelAlamat.Location = New System.Drawing.Point(15, 83)
        Me.LabelAlamat.Name = "LabelAlamat"
        Me.LabelAlamat.Padding = New System.Windows.Forms.Padding(0, 5, 5, 5)
        Me.LabelAlamat.Size = New System.Drawing.Size(44, 23)
        Me.LabelAlamat.TabIndex = 0
        Me.LabelAlamat.Text = "Alamat"
        '
        'GroupBoxPenjualan
        '
        Me.GroupBoxPenjualan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.GroupBoxPenjualan.Controls.Add(Me.GroupBoxDPen)
        Me.GroupBoxPenjualan.Controls.Add(Me.GroupBoxPel)
        Me.GroupBoxPenjualan.Controls.Add(Me.GroupBoxBiaya)
        Me.GroupBoxPenjualan.Controls.Add(Me.PictureBoxPenjualan)
        Me.GroupBoxPenjualan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxPenjualan.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.GroupBoxPenjualan.Location = New System.Drawing.Point(0, 0)
        Me.GroupBoxPenjualan.Name = "GroupBoxPenjualan"
        Me.GroupBoxPenjualan.Size = New System.Drawing.Size(922, 486)
        Me.GroupBoxPenjualan.TabIndex = 0
        Me.GroupBoxPenjualan.TabStop = False
        '
        'GroupBoxDPen
        '
        Me.GroupBoxDPen.Controls.Add(Me.CheckBoxLembar)
        Me.GroupBoxDPen.Controls.Add(Me.ButtonBersihkan)
        Me.GroupBoxDPen.Controls.Add(Me.CheckBoxMeter)
        Me.GroupBoxDPen.Controls.Add(Me.TextBoxTotal)
        Me.GroupBoxDPen.Controls.Add(Me.LabelTotal)
        Me.GroupBoxDPen.Controls.Add(Me.Label10)
        Me.GroupBoxDPen.Controls.Add(Me.ComboBoxHar)
        Me.GroupBoxDPen.Controls.Add(Me.LabelHar)
        Me.GroupBoxDPen.Controls.Add(Me.TextBoxULeb)
        Me.GroupBoxDPen.Controls.Add(Me.LabelUL)
        Me.GroupBoxDPen.Controls.Add(Me.TextBoxUPan)
        Me.GroupBoxDPen.Controls.Add(Me.LabelUP)
        Me.GroupBoxDPen.Controls.Add(Me.ComboBoxC)
        Me.GroupBoxDPen.Controls.Add(Me.LabelC)
        Me.GroupBoxDPen.Controls.Add(Me.ComboBoxJC)
        Me.GroupBoxDPen.Controls.Add(Me.LabelJC)
        Me.GroupBoxDPen.Controls.Add(Me.ButtonOK)
        Me.GroupBoxDPen.Controls.Add(Me.TextBoxKdTrans)
        Me.GroupBoxDPen.Controls.Add(Me.LabelKTrns)
        Me.GroupBoxDPen.Controls.Add(Me.TextBoxTglTrns)
        Me.GroupBoxDPen.Controls.Add(Me.LabelTrns)
        Me.GroupBoxDPen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxDPen.Location = New System.Drawing.Point(207, 173)
        Me.GroupBoxDPen.Name = "GroupBoxDPen"
        Me.GroupBoxDPen.Padding = New System.Windows.Forms.Padding(15)
        Me.GroupBoxDPen.Size = New System.Drawing.Size(405, 310)
        Me.GroupBoxDPen.TabIndex = 10
        Me.GroupBoxDPen.TabStop = False
        Me.GroupBoxDPen.Text = "Data Penjualan"
        '
        'CheckBoxLembar
        '
        Me.CheckBoxLembar.AutoSize = True
        Me.CheckBoxLembar.Location = New System.Drawing.Point(198, 189)
        Me.CheckBoxLembar.Name = "CheckBoxLembar"
        Me.CheckBoxLembar.Size = New System.Drawing.Size(61, 17)
        Me.CheckBoxLembar.TabIndex = 15
        Me.CheckBoxLembar.Text = "Lembar"
        Me.CheckBoxLembar.UseVisualStyleBackColor = True
        '
        'CheckBoxMeter
        '
        Me.CheckBoxMeter.AutoSize = True
        Me.CheckBoxMeter.Location = New System.Drawing.Point(139, 189)
        Me.CheckBoxMeter.Name = "CheckBoxMeter"
        Me.CheckBoxMeter.Size = New System.Drawing.Size(53, 17)
        Me.CheckBoxMeter.TabIndex = 14
        Me.CheckBoxMeter.Text = "Meter"
        Me.CheckBoxMeter.UseVisualStyleBackColor = True
        '
        'TextBoxTotal
        '
        Me.TextBoxTotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxTotal.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxTotal.Location = New System.Drawing.Point(139, 239)
        Me.TextBoxTotal.MaxLength = 20
        Me.TextBoxTotal.Name = "TextBoxTotal"
        Me.TextBoxTotal.ReadOnly = True
        Me.TextBoxTotal.Size = New System.Drawing.Size(224, 20)
        Me.TextBoxTotal.TabIndex = 11
        '
        'LabelTotal
        '
        Me.LabelTotal.AutoSize = True
        Me.LabelTotal.Location = New System.Drawing.Point(14, 239)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Padding = New System.Windows.Forms.Padding(0, 5, 5, 5)
        Me.LabelTotal.Size = New System.Drawing.Size(36, 23)
        Me.LabelTotal.TabIndex = 0
        Me.LabelTotal.Text = "Total"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(23, 375)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 13)
        Me.Label10.TabIndex = 10
        '
        'ComboBoxHar
        '
        Me.ComboBoxHar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxHar.FormatString = "C0"
        Me.ComboBoxHar.FormattingEnabled = True
        Me.ComboBoxHar.Location = New System.Drawing.Point(139, 212)
        Me.ComboBoxHar.Name = "ComboBoxHar"
        Me.ComboBoxHar.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxHar.TabIndex = 10
        '
        'LabelHar
        '
        Me.LabelHar.AutoSize = True
        Me.LabelHar.Location = New System.Drawing.Point(14, 212)
        Me.LabelHar.Name = "LabelHar"
        Me.LabelHar.Padding = New System.Windows.Forms.Padding(0, 5, 5, 5)
        Me.LabelHar.Size = New System.Drawing.Size(41, 23)
        Me.LabelHar.TabIndex = 0
        Me.LabelHar.Text = "Harga"
        '
        'TextBoxULeb
        '
        Me.TextBoxULeb.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxULeb.Location = New System.Drawing.Point(139, 163)
        Me.TextBoxULeb.MaxLength = 3
        Me.TextBoxULeb.Name = "TextBoxULeb"
        Me.TextBoxULeb.Size = New System.Drawing.Size(40, 20)
        Me.TextBoxULeb.TabIndex = 9
        '
        'LabelUL
        '
        Me.LabelUL.AutoSize = True
        Me.LabelUL.Location = New System.Drawing.Point(12, 163)
        Me.LabelUL.Name = "LabelUL"
        Me.LabelUL.Padding = New System.Windows.Forms.Padding(0, 5, 5, 5)
        Me.LabelUL.Size = New System.Drawing.Size(47, 23)
        Me.LabelUL.TabIndex = 0
        Me.LabelUL.Text = "Ukuran"
        '
        'TextBoxUPan
        '
        Me.TextBoxUPan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxUPan.Location = New System.Drawing.Point(139, 137)
        Me.TextBoxUPan.MaxLength = 3
        Me.TextBoxUPan.Name = "TextBoxUPan"
        Me.TextBoxUPan.Size = New System.Drawing.Size(40, 20)
        Me.TextBoxUPan.TabIndex = 8
        '
        'LabelUP
        '
        Me.LabelUP.AutoSize = True
        Me.LabelUP.Location = New System.Drawing.Point(12, 140)
        Me.LabelUP.Name = "LabelUP"
        Me.LabelUP.Padding = New System.Windows.Forms.Padding(0, 5, 5, 5)
        Me.LabelUP.Size = New System.Drawing.Size(47, 23)
        Me.LabelUP.TabIndex = 0
        Me.LabelUP.Text = "Ukuran"
        '
        'ComboBoxC
        '
        Me.ComboBoxC.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxC.FormattingEnabled = True
        Me.ComboBoxC.Location = New System.Drawing.Point(139, 110)
        Me.ComboBoxC.Name = "ComboBoxC"
        Me.ComboBoxC.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxC.TabIndex = 7
        '
        'LabelC
        '
        Me.LabelC.AutoSize = True
        Me.LabelC.Location = New System.Drawing.Point(15, 113)
        Me.LabelC.Name = "LabelC"
        Me.LabelC.Padding = New System.Windows.Forms.Padding(0, 5, 5, 5)
        Me.LabelC.Size = New System.Drawing.Size(40, 23)
        Me.LabelC.TabIndex = 0
        Me.LabelC.Text = "Cetak"
        '
        'ComboBoxJC
        '
        Me.ComboBoxJC.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxJC.FormattingEnabled = True
        Me.ComboBoxJC.Items.AddRange(New Object() {"Vinil", "Opset"})
        Me.ComboBoxJC.Location = New System.Drawing.Point(139, 83)
        Me.ComboBoxJC.Name = "ComboBoxJC"
        Me.ComboBoxJC.Size = New System.Drawing.Size(65, 21)
        Me.ComboBoxJC.TabIndex = 6
        '
        'LabelJC
        '
        Me.LabelJC.AutoSize = True
        Me.LabelJC.Location = New System.Drawing.Point(15, 83)
        Me.LabelJC.Name = "LabelJC"
        Me.LabelJC.Padding = New System.Windows.Forms.Padding(0, 5, 5, 5)
        Me.LabelJC.Size = New System.Drawing.Size(67, 23)
        Me.LabelJC.TabIndex = 0
        Me.LabelJC.Text = "Jenis Cetak"
        '
        'ButtonOK
        '
        Me.ButtonOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonOK.Location = New System.Drawing.Point(139, 276)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(120, 25)
        Me.ButtonOK.TabIndex = 13
        Me.ButtonOK.Text = "OK"
        Me.ButtonOK.UseVisualStyleBackColor = True
        '
        'TextBoxKdTrans
        '
        Me.TextBoxKdTrans.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxKdTrans.Location = New System.Drawing.Point(139, 57)
        Me.TextBoxKdTrans.MaxLength = 16
        Me.TextBoxKdTrans.Name = "TextBoxKdTrans"
        Me.TextBoxKdTrans.ReadOnly = True
        Me.TextBoxKdTrans.Size = New System.Drawing.Size(220, 20)
        Me.TextBoxKdTrans.TabIndex = 5
        '
        'LabelKTrns
        '
        Me.LabelKTrns.AutoSize = True
        Me.LabelKTrns.Location = New System.Drawing.Point(15, 57)
        Me.LabelKTrns.Name = "LabelKTrns"
        Me.LabelKTrns.Padding = New System.Windows.Forms.Padding(0, 5, 5, 5)
        Me.LabelKTrns.Size = New System.Drawing.Size(86, 23)
        Me.LabelKTrns.TabIndex = 0
        Me.LabelKTrns.Text = "Kode Transaksi"
        '
        'TextBoxTglTrns
        '
        Me.TextBoxTglTrns.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxTglTrns.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxTglTrns.Location = New System.Drawing.Point(139, 31)
        Me.TextBoxTglTrns.MaxLength = 17
        Me.TextBoxTglTrns.Name = "TextBoxTglTrns"
        Me.TextBoxTglTrns.ReadOnly = True
        Me.TextBoxTglTrns.Size = New System.Drawing.Size(121, 20)
        Me.TextBoxTglTrns.TabIndex = 4
        '
        'LabelTrns
        '
        Me.LabelTrns.AutoSize = True
        Me.LabelTrns.Location = New System.Drawing.Point(15, 28)
        Me.LabelTrns.Name = "LabelTrns"
        Me.LabelTrns.Padding = New System.Windows.Forms.Padding(0, 5, 5, 5)
        Me.LabelTrns.Size = New System.Drawing.Size(100, 23)
        Me.LabelTrns.TabIndex = 0
        Me.LabelTrns.Text = "Tanggal Transaksi"
        '
        'GroupBoxPel
        '
        Me.GroupBoxPel.Controls.Add(Me.CheckBoxAddMem)
        Me.GroupBoxPel.Controls.Add(Me.ComboBoxIDMem)
        Me.GroupBoxPel.Controls.Add(Me.Label1)
        Me.GroupBoxPel.Controls.Add(Me.TextBoxNohpDP)
        Me.GroupBoxPel.Controls.Add(Me.LabelNoHp)
        Me.GroupBoxPel.Controls.Add(Me.TextBoxAlamat)
        Me.GroupBoxPel.Controls.Add(Me.LabelAlamat)
        Me.GroupBoxPel.Controls.Add(Me.TextBoxNamaDP)
        Me.GroupBoxPel.Controls.Add(Me.LabelNama)
        Me.GroupBoxPel.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBoxPel.Location = New System.Drawing.Point(207, 16)
        Me.GroupBoxPel.Name = "GroupBoxPel"
        Me.GroupBoxPel.Padding = New System.Windows.Forms.Padding(15)
        Me.GroupBoxPel.Size = New System.Drawing.Size(405, 157)
        Me.GroupBoxPel.TabIndex = 0
        Me.GroupBoxPel.TabStop = False
        Me.GroupBoxPel.Text = "Data Pelanggan"
        '
        'CheckBoxAddMem
        '
        Me.CheckBoxAddMem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBoxAddMem.AutoSize = True
        Me.CheckBoxAddMem.Location = New System.Drawing.Point(282, 30)
        Me.CheckBoxAddMem.Name = "CheckBoxAddMem"
        Me.CheckBoxAddMem.Size = New System.Drawing.Size(117, 17)
        Me.CheckBoxAddMem.TabIndex = 7
        Me.CheckBoxAddMem.Text = "Add New Memeber"
        Me.CheckBoxAddMem.UseVisualStyleBackColor = True
        '
        'ComboBoxIDMem
        '
        Me.ComboBoxIDMem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxIDMem.FormattingEnabled = True
        Me.ComboBoxIDMem.Location = New System.Drawing.Point(139, 28)
        Me.ComboBoxIDMem.Name = "ComboBoxIDMem"
        Me.ComboBoxIDMem.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxIDMem.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(0, 5, 5, 5)
        Me.Label1.Size = New System.Drawing.Size(64, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ID Member"
        '
        'TextBoxNamaDP
        '
        Me.TextBoxNamaDP.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxNamaDP.Location = New System.Drawing.Point(139, 57)
        Me.TextBoxNamaDP.MaxLength = 25
        Me.TextBoxNamaDP.Name = "TextBoxNamaDP"
        Me.TextBoxNamaDP.Size = New System.Drawing.Size(185, 20)
        Me.TextBoxNamaDP.TabIndex = 1
        '
        'LabelNama
        '
        Me.LabelNama.AutoSize = True
        Me.LabelNama.Location = New System.Drawing.Point(15, 57)
        Me.LabelNama.Name = "LabelNama"
        Me.LabelNama.Padding = New System.Windows.Forms.Padding(0, 5, 5, 5)
        Me.LabelNama.Size = New System.Drawing.Size(40, 23)
        Me.LabelNama.TabIndex = 0
        Me.LabelNama.Text = "Nama"
        '
        'PictureBoxPenjualan
        '
        Me.PictureBoxPenjualan.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBoxPenjualan.Image = CType(resources.GetObject("PictureBoxPenjualan.Image"), System.Drawing.Image)
        Me.PictureBoxPenjualan.Location = New System.Drawing.Point(3, 16)
        Me.PictureBoxPenjualan.Name = "PictureBoxPenjualan"
        Me.PictureBoxPenjualan.Size = New System.Drawing.Size(204, 467)
        Me.PictureBoxPenjualan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxPenjualan.TabIndex = 9
        Me.PictureBoxPenjualan.TabStop = False
        '
        'PrintForm
        '
        Me.PrintForm.DocumentName = "document"
        Me.PrintForm.Form = Me
        Me.PrintForm.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview
        Me.PrintForm.PrinterSettings = CType(resources.GetObject("PrintForm.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm.PrintFileName = Nothing
        '
        'FormPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(922, 486)
        Me.Controls.Add(Me.GroupBoxPenjualan)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(938, 525)
        Me.MinimumSize = New System.Drawing.Size(938, 525)
        Me.Name = "FormPenjualan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormPenjualan"
        Me.GroupBoxBiaya.ResumeLayout(False)
        Me.GroupBoxBiaya.PerformLayout()
        Me.GroupBoxSemua.ResumeLayout(False)
        CType(Me.DataGridViewTambah, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxPenjualan.ResumeLayout(False)
        Me.GroupBoxDPen.ResumeLayout(False)
        Me.GroupBoxDPen.PerformLayout()
        Me.GroupBoxPel.ResumeLayout(False)
        Me.GroupBoxPel.PerformLayout()
        CType(Me.PictureBoxPenjualan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBoxBiaya As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxKembalian As System.Windows.Forms.TextBox
    Friend WithEvents LabelKem As System.Windows.Forms.Label
    Friend WithEvents TextBoxTotalBiaya As System.Windows.Forms.TextBox
    Friend WithEvents LabelTotalS As System.Windows.Forms.Label
    Friend WithEvents ButtonExit As System.Windows.Forms.Button
    Friend WithEvents TextBoxJmlhU As System.Windows.Forms.TextBox
    Friend WithEvents LabelJU As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TextBoxNohpDP As System.Windows.Forms.TextBox
    Friend WithEvents LabelNoHp As System.Windows.Forms.Label
    Friend WithEvents PictureBoxPenjualan As System.Windows.Forms.PictureBox
    Friend WithEvents TextBoxAlamat As System.Windows.Forms.TextBox
    Friend WithEvents LabelAlamat As System.Windows.Forms.Label
    Friend WithEvents GroupBoxPenjualan As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBoxDPen As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonOK As System.Windows.Forms.Button
    Friend WithEvents LabelHar As System.Windows.Forms.Label
    Friend WithEvents TextBoxULeb As System.Windows.Forms.TextBox
    Friend WithEvents LabelUL As System.Windows.Forms.Label
    Friend WithEvents TextBoxUPan As System.Windows.Forms.TextBox
    Friend WithEvents LabelUP As System.Windows.Forms.Label
    Friend WithEvents LabelC As System.Windows.Forms.Label
    Friend WithEvents TextBoxKdTrans As System.Windows.Forms.TextBox
    Friend WithEvents LabelKTrns As System.Windows.Forms.Label
    Friend WithEvents TextBoxTglTrns As System.Windows.Forms.TextBox
    Friend WithEvents LabelTrns As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxPel As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxNamaDP As System.Windows.Forms.TextBox
    Friend WithEvents LabelNama As System.Windows.Forms.Label
    Friend WithEvents TextBoxTotal As System.Windows.Forms.TextBox
    Friend WithEvents LabelTotal As System.Windows.Forms.Label
    Friend WithEvents PrintForm As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents ComboBoxC As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBoxSemua As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonBersihkan As System.Windows.Forms.Button
    Friend WithEvents ComboBoxJC As System.Windows.Forms.ComboBox
    Friend WithEvents LabelJC As System.Windows.Forms.Label
    Friend WithEvents ComboBoxHar As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridViewTambah As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonCetak As System.Windows.Forms.Button
    Friend WithEvents ColumnC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnU1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnU2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnH As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxIDMem As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBoxLembar As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxMeter As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxAddMem As System.Windows.Forms.CheckBox
End Class
