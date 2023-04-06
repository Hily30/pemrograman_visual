<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Segitiga
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.alas = New System.Windows.Forms.TextBox()
        Me.tinggi = New System.Windows.Forms.TextBox()
        Me.luas = New System.Windows.Forms.TextBox()
        Me.keliling = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(119, 157)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 35)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Hitung"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Alas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tinggi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 221)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Luas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 266)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Keliling"
        '
        'alas
        '
        Me.alas.Location = New System.Drawing.Point(119, 48)
        Me.alas.Multiline = True
        Me.alas.Name = "alas"
        Me.alas.Size = New System.Drawing.Size(140, 31)
        Me.alas.TabIndex = 5
        '
        'tinggi
        '
        Me.tinggi.Location = New System.Drawing.Point(119, 98)
        Me.tinggi.Multiline = True
        Me.tinggi.Name = "tinggi"
        Me.tinggi.Size = New System.Drawing.Size(140, 31)
        Me.tinggi.TabIndex = 6
        '
        'luas
        '
        Me.luas.Location = New System.Drawing.Point(119, 216)
        Me.luas.Multiline = True
        Me.luas.Name = "luas"
        Me.luas.Size = New System.Drawing.Size(140, 31)
        Me.luas.TabIndex = 7
        '
        'keliling
        '
        Me.keliling.Location = New System.Drawing.Point(119, 266)
        Me.keliling.Multiline = True
        Me.keliling.Name = "keliling"
        Me.keliling.Size = New System.Drawing.Size(140, 31)
        Me.keliling.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(308, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(169, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Hilyah Haula Salsabiila"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(345, 164)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "200511071"
        '
        'Segitiga
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(513, 335)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.keliling)
        Me.Controls.Add(Me.luas)
        Me.Controls.Add(Me.tinggi)
        Me.Controls.Add(Me.alas)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Segitiga"
        Me.Text = "Menghitung Segitiga"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents alas As TextBox
    Friend WithEvents tinggi As TextBox
    Friend WithEvents luas As TextBox
    Friend WithEvents keliling As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
