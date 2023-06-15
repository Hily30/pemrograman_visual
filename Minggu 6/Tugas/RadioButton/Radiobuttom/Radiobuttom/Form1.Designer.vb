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
        Me.rbAnak = New System.Windows.Forms.RadioButton()
        Me.rbDewasa = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtHargaTiket = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(164, 176)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 42)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Hitung"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'rbAnak
        '
        Me.rbAnak.AutoSize = True
        Me.rbAnak.Location = New System.Drawing.Point(164, 72)
        Me.rbAnak.Name = "rbAnak"
        Me.rbAnak.Size = New System.Drawing.Size(111, 24)
        Me.rbAnak.TabIndex = 1
        Me.rbAnak.TabStop = True
        Me.rbAnak.Text = "Anak-anak"
        Me.rbAnak.UseVisualStyleBackColor = True
        '
        'rbDewasa
        '
        Me.rbDewasa.AutoSize = True
        Me.rbDewasa.Location = New System.Drawing.Point(164, 121)
        Me.rbDewasa.Name = "rbDewasa"
        Me.rbDewasa.Size = New System.Drawing.Size(92, 24)
        Me.rbDewasa.TabIndex = 2
        Me.rbDewasa.TabStop = True
        Me.rbDewasa.Text = "Dewasa"
        Me.rbDewasa.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Pilih Kategori"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 240)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Harga Tiket "
        '
        'txtHargaTiket
        '
        Me.txtHargaTiket.Location = New System.Drawing.Point(158, 240)
        Me.txtHargaTiket.Name = "txtHargaTiket"
        Me.txtHargaTiket.Size = New System.Drawing.Size(106, 26)
        Me.txtHargaTiket.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(57, 301)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(279, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Hilyah Haula Salsabiila 200511071 R3"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(571, 432)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtHargaTiket)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rbDewasa)
        Me.Controls.Add(Me.rbAnak)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents rbAnak As RadioButton
    Friend WithEvents rbDewasa As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtHargaTiket As TextBox
    Friend WithEvents Label3 As Label
End Class
