<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Persegi_panjang
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.panjang = New System.Windows.Forms.TextBox()
        Me.lebar = New System.Windows.Forms.TextBox()
        Me.luas = New System.Windows.Forms.TextBox()
        Me.keliling = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(316, 167)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 20)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "200511071"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(279, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(169, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Hilyah Haula Salsabiila"
        '
        'panjang
        '
        Me.panjang.Location = New System.Drawing.Point(114, 35)
        Me.panjang.Multiline = True
        Me.panjang.Name = "panjang"
        Me.panjang.Size = New System.Drawing.Size(140, 31)
        Me.panjang.TabIndex = 13
        '
        'lebar
        '
        Me.lebar.Location = New System.Drawing.Point(114, 93)
        Me.lebar.Multiline = True
        Me.lebar.Name = "lebar"
        Me.lebar.Size = New System.Drawing.Size(140, 31)
        Me.lebar.TabIndex = 14
        '
        'luas
        '
        Me.luas.Location = New System.Drawing.Point(114, 194)
        Me.luas.Multiline = True
        Me.luas.Name = "luas"
        Me.luas.Size = New System.Drawing.Size(140, 31)
        Me.luas.TabIndex = 15
        '
        'keliling
        '
        Me.keliling.Location = New System.Drawing.Point(114, 247)
        Me.keliling.Multiline = True
        Me.keliling.Name = "keliling"
        Me.keliling.Size = New System.Drawing.Size(140, 31)
        Me.keliling.TabIndex = 16
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(114, 140)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 35)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Hitung"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 20)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Panjang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 20)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Lebar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 201)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 20)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Luas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 254)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 20)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Keliling"
        '
        'Persegi_panjang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(477, 306)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.keliling)
        Me.Controls.Add(Me.luas)
        Me.Controls.Add(Me.lebar)
        Me.Controls.Add(Me.panjang)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Name = "Persegi_panjang"
        Me.Text = "Persegi_panjang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents panjang As TextBox
    Friend WithEvents lebar As TextBox
    Friend WithEvents luas As TextBox
    Friend WithEvents keliling As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
