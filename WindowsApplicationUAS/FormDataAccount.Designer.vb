<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDataAccount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDataAccount))
        Me.GroupBoxBtn = New System.Windows.Forms.GroupBox()
        Me.CheckBoxDel = New System.Windows.Forms.CheckBox()
        Me.CheckBoxUpdate = New System.Windows.Forms.CheckBox()
        Me.CheckBoxAdd = New System.Windows.Forms.CheckBox()
        Me.TextBoxPriority = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxUser = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxSel = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.ButtonOK = New System.Windows.Forms.Button()
        Me.ButtonRefresh = New System.Windows.Forms.Button()
        Me.GroupBoxDataAccount = New System.Windows.Forms.GroupBox()
        Me.DataGridViewAccount = New System.Windows.Forms.DataGridView()
        Me.GroupBoxBtn.SuspendLayout()
        Me.GroupBoxDataAccount.SuspendLayout()
        CType(Me.DataGridViewAccount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxBtn
        '
        Me.GroupBoxBtn.Controls.Add(Me.CheckBoxDel)
        Me.GroupBoxBtn.Controls.Add(Me.CheckBoxUpdate)
        Me.GroupBoxBtn.Controls.Add(Me.CheckBoxAdd)
        Me.GroupBoxBtn.Controls.Add(Me.TextBoxPriority)
        Me.GroupBoxBtn.Controls.Add(Me.Label3)
        Me.GroupBoxBtn.Controls.Add(Me.TextBoxPassword)
        Me.GroupBoxBtn.Controls.Add(Me.Label2)
        Me.GroupBoxBtn.Controls.Add(Me.TextBoxUser)
        Me.GroupBoxBtn.Controls.Add(Me.Label1)
        Me.GroupBoxBtn.Controls.Add(Me.ComboBoxSel)
        Me.GroupBoxBtn.Controls.Add(Me.Label4)
        Me.GroupBoxBtn.Controls.Add(Me.ButtonClose)
        Me.GroupBoxBtn.Controls.Add(Me.ButtonOK)
        Me.GroupBoxBtn.Controls.Add(Me.ButtonRefresh)
        Me.GroupBoxBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBoxBtn.Location = New System.Drawing.Point(15, 28)
        Me.GroupBoxBtn.Name = "GroupBoxBtn"
        Me.GroupBoxBtn.Padding = New System.Windows.Forms.Padding(15)
        Me.GroupBoxBtn.Size = New System.Drawing.Size(454, 225)
        Me.GroupBoxBtn.TabIndex = 3
        Me.GroupBoxBtn.TabStop = False
        '
        'CheckBoxDel
        '
        Me.CheckBoxDel.AutoSize = True
        Me.CheckBoxDel.Location = New System.Drawing.Point(284, 60)
        Me.CheckBoxDel.Name = "CheckBoxDel"
        Me.CheckBoxDel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CheckBoxDel.Size = New System.Drawing.Size(57, 17)
        Me.CheckBoxDel.TabIndex = 6
        Me.CheckBoxDel.Text = "Delete"
        Me.CheckBoxDel.UseVisualStyleBackColor = True
        '
        'CheckBoxUpdate
        '
        Me.CheckBoxUpdate.AutoSize = True
        Me.CheckBoxUpdate.Location = New System.Drawing.Point(218, 60)
        Me.CheckBoxUpdate.Name = "CheckBoxUpdate"
        Me.CheckBoxUpdate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CheckBoxUpdate.Size = New System.Drawing.Size(61, 17)
        Me.CheckBoxUpdate.TabIndex = 5
        Me.CheckBoxUpdate.Text = "Update"
        Me.CheckBoxUpdate.UseVisualStyleBackColor = True
        '
        'CheckBoxAdd
        '
        Me.CheckBoxAdd.AutoSize = True
        Me.CheckBoxAdd.Location = New System.Drawing.Point(167, 60)
        Me.CheckBoxAdd.Name = "CheckBoxAdd"
        Me.CheckBoxAdd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CheckBoxAdd.Size = New System.Drawing.Size(45, 17)
        Me.CheckBoxAdd.TabIndex = 4
        Me.CheckBoxAdd.Text = "Add"
        Me.CheckBoxAdd.UseVisualStyleBackColor = True
        '
        'TextBoxPriority
        '
        Me.TextBoxPriority.Location = New System.Drawing.Point(167, 135)
        Me.TextBoxPriority.Name = "TextBoxPriority"
        Me.TextBoxPriority.Size = New System.Drawing.Size(162, 20)
        Me.TextBoxPriority.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(0, 5, 5, 5)
        Me.Label3.Size = New System.Drawing.Size(43, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Priority"
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Location = New System.Drawing.Point(168, 109)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.Size = New System.Drawing.Size(221, 20)
        Me.TextBoxPassword.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(0, 5, 5, 5)
        Me.Label2.Size = New System.Drawing.Size(58, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password"
        '
        'TextBoxUser
        '
        Me.TextBoxUser.Location = New System.Drawing.Point(167, 83)
        Me.TextBoxUser.Name = "TextBoxUser"
        Me.TextBoxUser.Size = New System.Drawing.Size(270, 20)
        Me.TextBoxUser.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(0, 5, 5, 5)
        Me.Label1.Size = New System.Drawing.Size(60, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Username"
        '
        'ComboBoxSel
        '
        Me.ComboBoxSel.FormattingEnabled = True
        Me.ComboBoxSel.Items.AddRange(New Object() {"Data Account Admin", "Data Account User"})
        Me.ComboBoxSel.Location = New System.Drawing.Point(167, 33)
        Me.ComboBoxSel.Name = "ComboBoxSel"
        Me.ComboBoxSel.Size = New System.Drawing.Size(269, 21)
        Me.ComboBoxSel.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(0, 5, 5, 5)
        Me.Label4.Size = New System.Drawing.Size(137, 23)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Select Data Admin or User"
        '
        'ButtonClose
        '
        Me.ButtonClose.Location = New System.Drawing.Point(362, 179)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(75, 25)
        Me.ButtonClose.TabIndex = 12
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'ButtonOK
        '
        Me.ButtonOK.Location = New System.Drawing.Point(13, 179)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(75, 25)
        Me.ButtonOK.TabIndex = 10
        Me.ButtonOK.Text = "OK"
        Me.ButtonOK.UseVisualStyleBackColor = True
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.Location = New System.Drawing.Point(94, 179)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.Size = New System.Drawing.Size(75, 25)
        Me.ButtonRefresh.TabIndex = 11
        Me.ButtonRefresh.Text = "Refresh"
        Me.ButtonRefresh.UseVisualStyleBackColor = True
        '
        'GroupBoxDataAccount
        '
        Me.GroupBoxDataAccount.Controls.Add(Me.DataGridViewAccount)
        Me.GroupBoxDataAccount.Controls.Add(Me.GroupBoxBtn)
        Me.GroupBoxDataAccount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxDataAccount.Location = New System.Drawing.Point(0, 0)
        Me.GroupBoxDataAccount.Name = "GroupBoxDataAccount"
        Me.GroupBoxDataAccount.Padding = New System.Windows.Forms.Padding(15)
        Me.GroupBoxDataAccount.Size = New System.Drawing.Size(484, 461)
        Me.GroupBoxDataAccount.TabIndex = 2
        Me.GroupBoxDataAccount.TabStop = False
        '
        'DataGridViewAccount
        '
        Me.DataGridViewAccount.AllowUserToAddRows = False
        Me.DataGridViewAccount.AllowUserToDeleteRows = False
        Me.DataGridViewAccount.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DataGridViewAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewAccount.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataGridViewAccount.GridColor = System.Drawing.SystemColors.WindowText
        Me.DataGridViewAccount.Location = New System.Drawing.Point(15, 253)
        Me.DataGridViewAccount.Name = "DataGridViewAccount"
        Me.DataGridViewAccount.ReadOnly = True
        Me.DataGridViewAccount.Size = New System.Drawing.Size(454, 154)
        Me.DataGridViewAccount.TabIndex = 13
        '
        'FormDataAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.GroupBoxDataAccount)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(500, 500)
        Me.MinimumSize = New System.Drawing.Size(500, 500)
        Me.Name = "FormDataAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormDataAccount"
        Me.GroupBoxBtn.ResumeLayout(False)
        Me.GroupBoxBtn.PerformLayout()
        Me.GroupBoxDataAccount.ResumeLayout(False)
        CType(Me.DataGridViewAccount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBoxBtn As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents ButtonOK As System.Windows.Forms.Button
    Friend WithEvents ButtonRefresh As System.Windows.Forms.Button
    Friend WithEvents TextBoxPriority As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxUser As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxDataAccount As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxSel As System.Windows.Forms.ComboBox
    Public WithEvents DataGridViewAccount As System.Windows.Forms.DataGridView
    Friend WithEvents CheckBoxUpdate As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxAdd As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxDel As System.Windows.Forms.CheckBox
End Class
