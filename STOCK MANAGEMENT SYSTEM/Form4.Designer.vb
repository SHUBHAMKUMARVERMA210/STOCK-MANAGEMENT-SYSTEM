<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BILL_VIEW_FORM
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.EXIT_BTN = New System.Windows.Forms.Button
        Me.VIEW_DATA_BTN = New System.Windows.Forms.Button
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(989, 221)
        Me.DataGridView1.TabIndex = 17
        '
        'EXIT_BTN
        '
        Me.EXIT_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.EXIT_BTN.Location = New System.Drawing.Point(12, 239)
        Me.EXIT_BTN.Name = "EXIT_BTN"
        Me.EXIT_BTN.Size = New System.Drawing.Size(87, 31)
        Me.EXIT_BTN.TabIndex = 1
        Me.EXIT_BTN.Text = "EXIT"
        Me.EXIT_BTN.UseVisualStyleBackColor = True
        '
        'VIEW_DATA_BTN
        '
        Me.VIEW_DATA_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.VIEW_DATA_BTN.Location = New System.Drawing.Point(844, 239)
        Me.VIEW_DATA_BTN.Name = "VIEW_DATA_BTN"
        Me.VIEW_DATA_BTN.Size = New System.Drawing.Size(157, 31)
        Me.VIEW_DATA_BTN.TabIndex = 2
        Me.VIEW_DATA_BTN.Text = "VIEW DATA"
        Me.VIEW_DATA_BTN.UseVisualStyleBackColor = True
        '
        'BILL_VIEW_FORM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(1013, 279)
        Me.Controls.Add(Me.VIEW_DATA_BTN)
        Me.Controls.Add(Me.EXIT_BTN)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "BILL_VIEW_FORM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "BILL VIEW FORM"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents EXIT_BTN As System.Windows.Forms.Button
    Friend WithEvents VIEW_DATA_BTN As System.Windows.Forms.Button
End Class
