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
        Me.chkMember = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtHargaBarang = New System.Windows.Forms.TextBox()
        Me.txtJumlahBarang = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTotalBayar = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'chkMember
        '
        Me.chkMember.AutoSize = True
        Me.chkMember.Location = New System.Drawing.Point(139, 177)
        Me.chkMember.Name = "chkMember"
        Me.chkMember.Size = New System.Drawing.Size(93, 24)
        Me.chkMember.TabIndex = 0
        Me.chkMember.Text = "Member"
        Me.chkMember.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(288, 171)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 35)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Hitung Total" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtHargaBarang
        '
        Me.txtHargaBarang.Location = New System.Drawing.Point(139, 55)
        Me.txtHargaBarang.Multiline = True
        Me.txtHargaBarang.Name = "txtHargaBarang"
        Me.txtHargaBarang.Size = New System.Drawing.Size(254, 36)
        Me.txtHargaBarang.TabIndex = 2
        '
        'txtJumlahBarang
        '
        Me.txtJumlahBarang.Location = New System.Drawing.Point(139, 114)
        Me.txtJumlahBarang.Multiline = True
        Me.txtJumlahBarang.Name = "txtJumlahBarang"
        Me.txtJumlahBarang.Size = New System.Drawing.Size(254, 36)
        Me.txtJumlahBarang.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Harga Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Jumlah Barang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(144, 289)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(279, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Hilyah Haula Salsabiila 200511071 R3"
        '
        'lblTotalBayar
        '
        Me.lblTotalBayar.AutoSize = True
        Me.lblTotalBayar.Location = New System.Drawing.Point(37, 247)
        Me.lblTotalBayar.Name = "lblTotalBayar"
        Me.lblTotalBayar.Size = New System.Drawing.Size(89, 20)
        Me.lblTotalBayar.TabIndex = 8
        Me.lblTotalBayar.Text = "Total Bayar"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(548, 347)
        Me.Controls.Add(Me.lblTotalBayar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtJumlahBarang)
        Me.Controls.Add(Me.txtHargaBarang)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.chkMember)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkMember As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtHargaBarang As TextBox
    Friend WithEvents txtJumlahBarang As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTotalBayar As Label
End Class
