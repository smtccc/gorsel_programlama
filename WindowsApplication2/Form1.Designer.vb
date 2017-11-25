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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GİRİŞYAP = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(264, 233)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(338, 33)
        Me.TextBox1.TabIndex = 2
        '
        'GİRİŞYAP
        '
        Me.GİRİŞYAP.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.GİRİŞYAP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GİRİŞYAP.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GİRİŞYAP.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GİRİŞYAP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.GİRİŞYAP.Location = New System.Drawing.Point(263, 375)
        Me.GİRİŞYAP.Margin = New System.Windows.Forms.Padding(6)
        Me.GİRİŞYAP.Name = "GİRİŞYAP"
        Me.GİRİŞYAP.Size = New System.Drawing.Size(340, 66)
        Me.GİRİŞYAP.TabIndex = 0
        Me.GİRİŞYAP.Text = "GİRİŞ"
        Me.GİRİŞYAP.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.TextBox2.Location = New System.Drawing.Point(264, 303)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(6)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox2.Size = New System.Drawing.Size(338, 33)
        Me.TextBox2.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GİRİŞYAP)
        Me.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximumSize = New System.Drawing.Size(800, 500)
        Me.MinimumSize = New System.Drawing.Size(800, 500)
        Me.Name = "Form1"
        Me.Text = "GİRİŞ EKRANI"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GİRİŞYAP As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
End Class
