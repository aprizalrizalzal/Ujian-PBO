<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        Me.ButtonCanc = New System.Windows.Forms.Button()
        Me.ButtonLog = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBoxSel = New System.Windows.Forms.ComboBox()
        Me.CheckBoxShowPass = New System.Windows.Forms.CheckBox()
        Me.TextBoxPass = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxUs = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonCanc
        '
        Me.ButtonCanc.Location = New System.Drawing.Point(465, 179)
        Me.ButtonCanc.Name = "ButtonCanc"
        Me.ButtonCanc.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCanc.TabIndex = 6
        Me.ButtonCanc.Text = "Canceled"
        Me.ButtonCanc.UseVisualStyleBackColor = True
        '
        'ButtonLog
        '
        Me.ButtonLog.Location = New System.Drawing.Point(385, 179)
        Me.ButtonLog.Name = "ButtonLog"
        Me.ButtonLog.Size = New System.Drawing.Size(75, 23)
        Me.ButtonLog.TabIndex = 5
        Me.ButtonLog.Text = "Login"
        Me.ButtonLog.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(275, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Select Priority"
        '
        'ComboBoxSel
        '
        Me.ComboBoxSel.FormattingEnabled = True
        Me.ComboBoxSel.Location = New System.Drawing.Point(385, 129)
        Me.ComboBoxSel.Name = "ComboBoxSel"
        Me.ComboBoxSel.Size = New System.Drawing.Size(155, 21)
        Me.ComboBoxSel.TabIndex = 4
        '
        'CheckBoxShowPass
        '
        Me.CheckBoxShowPass.AutoSize = True
        Me.CheckBoxShowPass.Location = New System.Drawing.Point(439, 105)
        Me.CheckBoxShowPass.Name = "CheckBoxShowPass"
        Me.CheckBoxShowPass.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBoxShowPass.Size = New System.Drawing.Size(102, 17)
        Me.CheckBoxShowPass.TabIndex = 3
        Me.CheckBoxShowPass.Text = "Show Password"
        Me.CheckBoxShowPass.UseVisualStyleBackColor = True
        '
        'TextBoxPass
        '
        Me.TextBoxPass.Location = New System.Drawing.Point(385, 79)
        Me.TextBoxPass.Name = "TextBoxPass"
        Me.TextBoxPass.Size = New System.Drawing.Size(156, 20)
        Me.TextBoxPass.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(275, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Password"
        '
        'TextBoxUs
        '
        Me.TextBoxUs.Location = New System.Drawing.Point(385, 53)
        Me.TextBoxUs.Name = "TextBoxUs"
        Me.TextBoxUs.Size = New System.Drawing.Size(156, 20)
        Me.TextBoxUs.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(275, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Window
        Me.PictureBox1.BackgroundImage = Global.WindowsApplicationUAS.My.Resources.Resources.Login
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(38, 55)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(231, 147)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(584, 261)
        Me.Controls.Add(Me.ButtonCanc)
        Me.Controls.Add(Me.ButtonLog)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBoxSel)
        Me.Controls.Add(Me.CheckBoxShowPass)
        Me.Controls.Add(Me.TextBoxPass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxUs)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(600, 300)
        Me.MinimumSize = New System.Drawing.Size(600, 300)
        Me.Name = "FormLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonCanc As System.Windows.Forms.Button
    Friend WithEvents ButtonLog As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxSel As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBoxShowPass As System.Windows.Forms.CheckBox
    Friend WithEvents TextBoxPass As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxUs As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
