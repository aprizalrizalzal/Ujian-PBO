<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDataPenjualan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDataPenjualan))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBoxbtn = New System.Windows.Forms.GroupBox()
        Me.DataGridViewPenjualan = New System.Windows.Forms.DataGridView()
        Me.GroupBoxDataPenjualan = New System.Windows.Forms.GroupBox()
        Me.PrintFormDP = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.GroupBoxbtn.SuspendLayout()
        CType(Me.DataGridViewPenjualan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxDataPenjualan.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button1.Location = New System.Drawing.Point(15, 18)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(1144, 25)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Cetak Data Penjualan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBoxbtn
        '
        Me.GroupBoxbtn.Controls.Add(Me.Button1)
        Me.GroupBoxbtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBoxbtn.Location = New System.Drawing.Point(0, 404)
        Me.GroupBoxbtn.Name = "GroupBoxbtn"
        Me.GroupBoxbtn.Padding = New System.Windows.Forms.Padding(15)
        Me.GroupBoxbtn.Size = New System.Drawing.Size(1174, 58)
        Me.GroupBoxbtn.TabIndex = 0
        Me.GroupBoxbtn.TabStop = False
        '
        'DataGridViewPenjualan
        '
        Me.DataGridViewPenjualan.AllowUserToAddRows = False
        Me.DataGridViewPenjualan.AllowUserToDeleteRows = False
        Me.DataGridViewPenjualan.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DataGridViewPenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewPenjualan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewPenjualan.GridColor = System.Drawing.SystemColors.WindowText
        Me.DataGridViewPenjualan.Location = New System.Drawing.Point(15, 28)
        Me.DataGridViewPenjualan.Name = "DataGridViewPenjualan"
        Me.DataGridViewPenjualan.ReadOnly = True
        Me.DataGridViewPenjualan.Size = New System.Drawing.Size(1144, 361)
        Me.DataGridViewPenjualan.TabIndex = 1
        '
        'GroupBoxDataPenjualan
        '
        Me.GroupBoxDataPenjualan.Controls.Add(Me.DataGridViewPenjualan)
        Me.GroupBoxDataPenjualan.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBoxDataPenjualan.Location = New System.Drawing.Point(0, 0)
        Me.GroupBoxDataPenjualan.Name = "GroupBoxDataPenjualan"
        Me.GroupBoxDataPenjualan.Padding = New System.Windows.Forms.Padding(15)
        Me.GroupBoxDataPenjualan.Size = New System.Drawing.Size(1174, 404)
        Me.GroupBoxDataPenjualan.TabIndex = 0
        Me.GroupBoxDataPenjualan.TabStop = False
        '
        'PrintFormDP
        '
        Me.PrintFormDP.DocumentName = "document"
        Me.PrintFormDP.Form = Me
        Me.PrintFormDP.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintFormDP.PrinterSettings = CType(resources.GetObject("PrintFormDP.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintFormDP.PrintFileName = Nothing
        '
        'FormDataPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1174, 466)
        Me.Controls.Add(Me.GroupBoxbtn)
        Me.Controls.Add(Me.GroupBoxDataPenjualan)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1190, 505)
        Me.MinimumSize = New System.Drawing.Size(1190, 505)
        Me.Name = "FormDataPenjualan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DataPenjualan"
        Me.GroupBoxbtn.ResumeLayout(False)
        CType(Me.DataGridViewPenjualan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxDataPenjualan.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBoxbtn As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewPenjualan As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBoxDataPenjualan As System.Windows.Forms.GroupBox
    Friend WithEvents PrintFormDP As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
End Class
