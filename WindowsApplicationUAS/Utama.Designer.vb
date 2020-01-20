<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Utama
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Utama))
        Me.MenuStripUtama = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItemHome = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataTransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenjualanToolStripMenuItemDB = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBoxUtama = New System.Windows.Forms.GroupBox()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.MenuStripUtama.SuspendLayout()
        Me.GroupBoxUtama.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStripUtama
        '
        Me.MenuStripUtama.BackColor = System.Drawing.SystemColors.Window
        Me.MenuStripUtama.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItemHome, Me.FormToolStripMenuItem, Me.InfoToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStripUtama.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripUtama.Name = "MenuStripUtama"
        Me.MenuStripUtama.Size = New System.Drawing.Size(430, 24)
        Me.MenuStripUtama.TabIndex = 1
        Me.MenuStripUtama.Text = "MenuStrip1"
        '
        'ToolStripMenuItemHome
        '
        Me.ToolStripMenuItemHome.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.ToolStripMenuItem1, Me.ExitToolStripMenuItem})
        Me.ToolStripMenuItemHome.Name = "ToolStripMenuItemHome"
        Me.ToolStripMenuItemHome.Size = New System.Drawing.Size(52, 20)
        Me.ToolStripMenuItemHome.Text = "Home"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Image = Global.WindowsApplicationUAS.My.Resources.Resources.Login
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Image = Global.WindowsApplicationUAS.My.Resources.Resources.logout
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(109, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = Global.WindowsApplicationUAS.My.Resources.Resources.Exit1
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'FormToolStripMenuItem
        '
        Me.FormToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PenjualanToolStripMenuItem})
        Me.FormToolStripMenuItem.Name = "FormToolStripMenuItem"
        Me.FormToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.FormToolStripMenuItem.Text = "Transaksi"
        '
        'PenjualanToolStripMenuItem
        '
        Me.PenjualanToolStripMenuItem.Image = CType(resources.GetObject("PenjualanToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PenjualanToolStripMenuItem.Name = "PenjualanToolStripMenuItem"
        Me.PenjualanToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.PenjualanToolStripMenuItem.Text = "Penjualan"
        '
        'InfoToolStripMenuItem
        '
        Me.InfoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataTransaksiToolStripMenuItem, Me.ToolStripMenuItem2, Me.AccountToolStripMenuItem})
        Me.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem"
        Me.InfoToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.InfoToolStripMenuItem.Text = "Info"
        '
        'DataTransaksiToolStripMenuItem
        '
        Me.DataTransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PenjualanToolStripMenuItemDB})
        Me.DataTransaksiToolStripMenuItem.Image = Global.WindowsApplicationUAS.My.Resources.Resources.percetakan
        Me.DataTransaksiToolStripMenuItem.Name = "DataTransaksiToolStripMenuItem"
        Me.DataTransaksiToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.DataTransaksiToolStripMenuItem.Text = "Data Transaksi"
        '
        'PenjualanToolStripMenuItemDB
        '
        Me.PenjualanToolStripMenuItemDB.Image = Global.WindowsApplicationUAS.My.Resources.Resources.Pembelian
        Me.PenjualanToolStripMenuItemDB.Name = "PenjualanToolStripMenuItemDB"
        Me.PenjualanToolStripMenuItemDB.Size = New System.Drawing.Size(126, 22)
        Me.PenjualanToolStripMenuItemDB.Text = "Penjualan"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(145, 6)
        '
        'AccountToolStripMenuItem
        '
        Me.AccountToolStripMenuItem.Image = Global.WindowsApplicationUAS.My.Resources.Resources.admin2
        Me.AccountToolStripMenuItem.Name = "AccountToolStripMenuItem"
        Me.AccountToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.AccountToolStripMenuItem.Text = "Account"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'GroupBoxUtama
        '
        Me.GroupBoxUtama.BackColor = System.Drawing.SystemColors.Window
        Me.GroupBoxUtama.BackgroundImage = Global.WindowsApplicationUAS.My.Resources.Resources.BG
        Me.GroupBoxUtama.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBoxUtama.Controls.Add(Me.ButtonExit)
        Me.GroupBoxUtama.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxUtama.Location = New System.Drawing.Point(0, 24)
        Me.GroupBoxUtama.Name = "GroupBoxUtama"
        Me.GroupBoxUtama.Size = New System.Drawing.Size(430, 370)
        Me.GroupBoxUtama.TabIndex = 0
        Me.GroupBoxUtama.TabStop = False
        '
        'ButtonExit
        '
        Me.ButtonExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonExit.Location = New System.Drawing.Point(280, 318)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(114, 25)
        Me.ButtonExit.TabIndex = 21
        Me.ButtonExit.Text = "Keluar"
        Me.ButtonExit.UseVisualStyleBackColor = True
        '
        'Utama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(430, 394)
        Me.Controls.Add(Me.GroupBoxUtama)
        Me.Controls.Add(Me.MenuStripUtama)
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStripUtama
        Me.MaximizeBox = False
        Me.Name = "Utama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Utama"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStripUtama.ResumeLayout(False)
        Me.MenuStripUtama.PerformLayout()
        Me.GroupBoxUtama.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBoxUtama As System.Windows.Forms.GroupBox
    Friend WithEvents MenuStripUtama As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItemHome As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FormToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PenjualanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataTransaksiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AccountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PenjualanToolStripMenuItemDB As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ButtonExit As System.Windows.Forms.Button
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
