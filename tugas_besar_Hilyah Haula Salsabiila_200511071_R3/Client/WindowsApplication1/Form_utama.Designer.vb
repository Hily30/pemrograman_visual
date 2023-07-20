<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_utama
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginBar = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutBar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitBar = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuAdminBar = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataBarangBar = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataPelangganBar = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataTransaksiBar = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.MenuAdminBar})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(867, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginBar, Me.LogoutBar, Me.ExitBar})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(50, 29)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LoginBar
        '
        Me.LoginBar.Name = "LoginBar"
        Me.LoginBar.Size = New System.Drawing.Size(210, 30)
        Me.LoginBar.Text = "Login"
        '
        'LogoutBar
        '
        Me.LogoutBar.Name = "LogoutBar"
        Me.LogoutBar.Size = New System.Drawing.Size(210, 30)
        Me.LogoutBar.Text = "Logout"
        '
        'ExitBar
        '
        Me.ExitBar.Name = "ExitBar"
        Me.ExitBar.Size = New System.Drawing.Size(210, 30)
        Me.ExitBar.Text = "Exit"
        '
        'MenuAdminBar
        '
        Me.MenuAdminBar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataBarangBar, Me.DataPelangganBar, Me.DataTransaksiBar})
        Me.MenuAdminBar.MergeAction = System.Windows.Forms.MergeAction.Replace
        Me.MenuAdminBar.Name = "MenuAdminBar"
        Me.MenuAdminBar.Size = New System.Drawing.Size(127, 29)
        Me.MenuAdminBar.Text = "Menu Admin"
        '
        'DataBarangBar
        '
        Me.DataBarangBar.Name = "DataBarangBar"
        Me.DataBarangBar.Size = New System.Drawing.Size(220, 30)
        Me.DataBarangBar.Text = "Data Barang"
        '
        'DataPelangganBar
        '
        Me.DataPelangganBar.Name = "DataPelangganBar"
        Me.DataPelangganBar.Size = New System.Drawing.Size(220, 30)
        Me.DataPelangganBar.Text = "Data Pelanggan"
        '
        'DataTransaksiBar
        '
        Me.DataTransaksiBar.Name = "DataTransaksiBar"
        Me.DataTransaksiBar.Size = New System.Drawing.Size(220, 30)
        Me.DataTransaksiBar.Text = "Data Transaksi"
        '
        'Form_utama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(867, 433)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form_utama"
        Me.Text = "Form_utama"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginBar As ToolStripMenuItem
    Friend WithEvents LogoutBar As ToolStripMenuItem
    Friend WithEvents ExitBar As ToolStripMenuItem
    Friend WithEvents MenuAdminBar As ToolStripMenuItem
    Friend WithEvents DataBarangBar As ToolStripMenuItem
    Friend WithEvents DataPelangganBar As ToolStripMenuItem
    Friend WithEvents DataTransaksiBar As ToolStripMenuItem
End Class
