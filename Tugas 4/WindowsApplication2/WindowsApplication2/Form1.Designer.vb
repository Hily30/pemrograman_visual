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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Kelvin = New System.Windows.Forms.TextBox()
        Me.Reamur = New System.Windows.Forms.TextBox()
        Me.Celcius = New System.Windows.Forms.TextBox()
        Me.Fahrenhait = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(169, 79)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 47)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Convert"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(165, 324)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(279, 20)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Hilyah Haula Salsabiila 200511071 R3"
        '
        'Kelvin
        '
        Me.Kelvin.Location = New System.Drawing.Point(168, 33)
        Me.Kelvin.Multiline = True
        Me.Kelvin.Name = "Kelvin"
        Me.Kelvin.Size = New System.Drawing.Size(114, 40)
        Me.Kelvin.TabIndex = 18
        '
        'Reamur
        '
        Me.Reamur.Location = New System.Drawing.Point(169, 255)
        Me.Reamur.Multiline = True
        Me.Reamur.Name = "Reamur"
        Me.Reamur.Size = New System.Drawing.Size(114, 40)
        Me.Reamur.TabIndex = 17
        '
        'Celcius
        '
        Me.Celcius.Location = New System.Drawing.Point(169, 136)
        Me.Celcius.Multiline = True
        Me.Celcius.Name = "Celcius"
        Me.Celcius.Size = New System.Drawing.Size(114, 40)
        Me.Celcius.TabIndex = 16
        '
        'Fahrenhait
        '
        Me.Fahrenhait.Location = New System.Drawing.Point(168, 193)
        Me.Fahrenhait.Multiline = True
        Me.Fahrenhait.Name = "Fahrenhait"
        Me.Fahrenhait.Size = New System.Drawing.Size(114, 40)
        Me.Fahrenhait.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(68, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 20)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Kelvin"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(63, 264)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 20)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Reamur"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 205)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Fahrenhait"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 20)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Celcius"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(503, 375)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Kelvin)
        Me.Controls.Add(Me.Reamur)
        Me.Controls.Add(Me.Celcius)
        Me.Controls.Add(Me.Fahrenhait)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Suhu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Kelvin As TextBox
    Friend WithEvents Reamur As TextBox
    Friend WithEvents Celcius As TextBox
    Friend WithEvents Fahrenhait As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
