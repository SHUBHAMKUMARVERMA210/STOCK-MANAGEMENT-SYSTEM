<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LOGIN_FRM
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.US_NM_TXT = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.PS_TXT = New System.Windows.Forms.TextBox
        Me.LG_BTN = New System.Windows.Forms.Button
        Me.EX_BTN = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.LG_TYP_CMB = New System.Windows.Forms.ComboBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 39.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label1.Location = New System.Drawing.Point(71, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(597, 54)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "LOGIN VERIFICATION"
        '
        'US_NM_TXT
        '
        Me.US_NM_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.US_NM_TXT.Location = New System.Drawing.Point(408, 134)
        Me.US_NM_TXT.Name = "US_NM_TXT"
        Me.US_NM_TXT.Size = New System.Drawing.Size(260, 38)
        Me.US_NM_TXT.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Algerian", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(238, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 30)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "USERNAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Algerian", 20.25!)
        Me.Label3.Location = New System.Drawing.Point(238, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 30)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "PASSWORD"
        '
        'PS_TXT
        '
        Me.PS_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PS_TXT.Location = New System.Drawing.Point(408, 189)
        Me.PS_TXT.Name = "PS_TXT"
        Me.PS_TXT.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PS_TXT.Size = New System.Drawing.Size(260, 38)
        Me.PS_TXT.TabIndex = 3
        '
        'LG_BTN
        '
        Me.LG_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LG_BTN.Location = New System.Drawing.Point(243, 236)
        Me.LG_BTN.Name = "LG_BTN"
        Me.LG_BTN.Size = New System.Drawing.Size(109, 75)
        Me.LG_BTN.TabIndex = 5
        Me.LG_BTN.Text = "LOGIN"
        Me.LG_BTN.UseVisualStyleBackColor = True
        '
        'EX_BTN
        '
        Me.EX_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EX_BTN.Location = New System.Drawing.Point(550, 233)
        Me.EX_BTN.Name = "EX_BTN"
        Me.EX_BTN.Size = New System.Drawing.Size(118, 75)
        Me.EX_BTN.TabIndex = 6
        Me.EX_BTN.Text = "EXIT"
        Me.EX_BTN.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.STOCK_MANAGEMENT_SYSTEM.My.Resources.Resources.images
        Me.PictureBox1.Location = New System.Drawing.Point(12, 88)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(219, 223)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Algerian", 20.25!)
        Me.Label4.Location = New System.Drawing.Point(238, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(160, 30)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "LOGIN TYPE"
        '
        'LG_TYP_CMB
        '
        Me.LG_TYP_CMB.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LG_TYP_CMB.FormattingEnabled = True
        Me.LG_TYP_CMB.Location = New System.Drawing.Point(408, 85)
        Me.LG_TYP_CMB.Name = "LG_TYP_CMB"
        Me.LG_TYP_CMB.Size = New System.Drawing.Size(260, 33)
        Me.LG_TYP_CMB.TabIndex = 1
        '
        'LOGIN_FRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Blue
        Me.ClientSize = New System.Drawing.Size(718, 323)
        Me.Controls.Add(Me.LG_TYP_CMB)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.EX_BTN)
        Me.Controls.Add(Me.LG_BTN)
        Me.Controls.Add(Me.PS_TXT)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.US_NM_TXT)
        Me.Controls.Add(Me.Label1)
        Me.Name = "LOGIN_FRM"
        Me.Text = "LOGIN FORM"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents US_NM_TXT As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PS_TXT As System.Windows.Forms.TextBox
    Friend WithEvents LG_BTN As System.Windows.Forms.Button
    Friend WithEvents EX_BTN As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LG_TYP_CMB As System.Windows.Forms.ComboBox

End Class
