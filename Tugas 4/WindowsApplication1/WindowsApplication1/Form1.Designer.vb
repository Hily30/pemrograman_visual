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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Fahrenhait = New System.Windows.Forms.TextBox()
        Me.Celcius = New System.Windows.Forms.TextBox()
        Me.Reamur = New System.Windows.Forms.TextBox()
        Me.Kelvin = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 166)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Celcius"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 226)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fahrenhait"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Reamur"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 284)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Kelvin"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(150, 107)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 42)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Convert"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Fahrenhait
        '
        Me.Fahrenhait.Location = New System.Drawing.Point(150, 216)
        Me.Fahrenhait.Multiline = True
        Me.Fahrenhait.Name = "Fahrenhait"
        Me.Fahrenhait.Size = New System.Drawing.Size(114, 40)
        Me.Fahrenhait.TabIndex = 5
        '
        'Celcius
        '
        Me.Celcius.Location = New System.Drawing.Point(150, 157)
        Me.Celcius.Multiline = True
        Me.Celcius.Name = "Celcius"
        Me.Celcius.Size = New System.Drawing.Size(114, 40)
        Me.Celcius.TabIndex = 6
        '
        'Reamur
        '
        Me.Reamur.Location = New System.Drawing.Point(150, 51)
        Me.Reamur.Multiline = True
        Me.Reamur.Name = "Reamur"
        Me.Reamur.Size = New System.Drawing.Size(114, 40)
        Me.Reamur.TabIndex = 7
        '
        'Kelvin
        '
        Me.Kelvin.Location = New System.Drawing.Point(150, 276)
        Me.Kelvin.Multiline = True
        Me.Kelvin.Name = "Kelvin"
        Me.Kelvin.Size = New System.Drawing.Size(114, 40)
        Me.Kelvin.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(146, 345)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(279, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Hilyah Haula Salsabiila 200511071 R3"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(540, 398)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Kelvin)
        Me.Controls.Add(Me.Reamur)
        Me.Controls.Add(Me.Celcius)
        Me.Controls.Add(Me.Fahrenhait)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Suhu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Fahrenhait As TextBox
    Friend WithEvents Celcius As TextBox
    Friend WithEvents Reamur As TextBox
    Friend WithEvents Kelvin As TextBox
    Friend WithEvents Label5 As Label
End Class
