<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class STOCK_ENTRY_FORM
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.SAVE_BTN = New System.Windows.Forms.Button
        Me.QUANTITY_TXT = New System.Windows.Forms.TextBox
        Me.EXIT_BTN = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.UPDATE_BTN = New System.Windows.Forms.Button
        Me.DELETE_BTN = New System.Windows.Forms.Button
        Me.DATE_DTP = New System.Windows.Forms.DateTimePicker
        Me.EXPIRY_DATE_DTP = New System.Windows.Forms.DateTimePicker
        Me.PRODUCT_ID_CMB = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.PURCHASE_PRODUCT_TXT = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.DISTRIBUTER_NAME_TXT = New System.Windows.Forms.TextBox
        Me.SELLING_PRICE_TXT = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.COST_PRICE_TXT = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.MANUFACTURING_DATE_DTP = New System.Windows.Forms.DateTimePicker
        Me.Label9 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.SAVE_BTN)
        Me.GroupBox1.Controls.Add(Me.QUANTITY_TXT)
        Me.GroupBox1.Controls.Add(Me.EXIT_BTN)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.UPDATE_BTN)
        Me.GroupBox1.Controls.Add(Me.DELETE_BTN)
        Me.GroupBox1.Controls.Add(Me.DATE_DTP)
        Me.GroupBox1.Controls.Add(Me.EXPIRY_DATE_DTP)
        Me.GroupBox1.Controls.Add(Me.PRODUCT_ID_CMB)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.PURCHASE_PRODUCT_TXT)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.DISTRIBUTER_NAME_TXT)
        Me.GroupBox1.Controls.Add(Me.SELLING_PRICE_TXT)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.COST_PRICE_TXT)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.MANUFACTURING_DATE_DTP)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Font = New System.Drawing.Font("Modern No. 20", 39.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1342, 286)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "                      STOCK ENTRY DETAILS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Black", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label2.Location = New System.Drawing.Point(6, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "DATE"
        '
        'SAVE_BTN
        '
        Me.SAVE_BTN.BackColor = System.Drawing.Color.SteelBlue
        Me.SAVE_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SAVE_BTN.Location = New System.Drawing.Point(12, 228)
        Me.SAVE_BTN.Name = "SAVE_BTN"
        Me.SAVE_BTN.Size = New System.Drawing.Size(87, 33)
        Me.SAVE_BTN.TabIndex = 10
        Me.SAVE_BTN.Text = "SAVE"
        Me.SAVE_BTN.UseVisualStyleBackColor = False
        '
        'QUANTITY_TXT
        '
        Me.QUANTITY_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QUANTITY_TXT.Location = New System.Drawing.Point(761, 225)
        Me.QUANTITY_TXT.Name = "QUANTITY_TXT"
        Me.QUANTITY_TXT.Size = New System.Drawing.Size(216, 30)
        Me.QUANTITY_TXT.TabIndex = 9
        '
        'EXIT_BTN
        '
        Me.EXIT_BTN.BackColor = System.Drawing.Color.SteelBlue
        Me.EXIT_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EXIT_BTN.Location = New System.Drawing.Point(400, 228)
        Me.EXIT_BTN.Name = "EXIT_BTN"
        Me.EXIT_BTN.Size = New System.Drawing.Size(71, 33)
        Me.EXIT_BTN.TabIndex = 13
        Me.EXIT_BTN.Text = "EXIT"
        Me.EXIT_BTN.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Black", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label10.Location = New System.Drawing.Point(477, 227)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(130, 28)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "QUANTITY"
        '
        'UPDATE_BTN
        '
        Me.UPDATE_BTN.BackColor = System.Drawing.Color.SteelBlue
        Me.UPDATE_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UPDATE_BTN.Location = New System.Drawing.Point(121, 228)
        Me.UPDATE_BTN.Name = "UPDATE_BTN"
        Me.UPDATE_BTN.Size = New System.Drawing.Size(115, 33)
        Me.UPDATE_BTN.TabIndex = 11
        Me.UPDATE_BTN.Text = "UPDATE"
        Me.UPDATE_BTN.UseVisualStyleBackColor = False
        '
        'DELETE_BTN
        '
        Me.DELETE_BTN.BackColor = System.Drawing.Color.SteelBlue
        Me.DELETE_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DELETE_BTN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DELETE_BTN.Location = New System.Drawing.Point(272, 228)
        Me.DELETE_BTN.Name = "DELETE_BTN"
        Me.DELETE_BTN.Size = New System.Drawing.Size(100, 33)
        Me.DELETE_BTN.TabIndex = 12
        Me.DELETE_BTN.Text = "DELETE"
        Me.DELETE_BTN.UseVisualStyleBackColor = False
        '
        'DATE_DTP
        '
        Me.DATE_DTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DATE_DTP.Location = New System.Drawing.Point(265, 77)
        Me.DATE_DTP.Name = "DATE_DTP"
        Me.DATE_DTP.Size = New System.Drawing.Size(211, 30)
        Me.DATE_DTP.TabIndex = 1
        '
        'EXPIRY_DATE_DTP
        '
        Me.EXPIRY_DATE_DTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EXPIRY_DATE_DTP.Location = New System.Drawing.Point(761, 117)
        Me.EXPIRY_DATE_DTP.Name = "EXPIRY_DATE_DTP"
        Me.EXPIRY_DATE_DTP.Size = New System.Drawing.Size(216, 30)
        Me.EXPIRY_DATE_DTP.TabIndex = 6
        '
        'PRODUCT_ID_CMB
        '
        Me.PRODUCT_ID_CMB.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PRODUCT_ID_CMB.FormattingEnabled = True
        Me.PRODUCT_ID_CMB.Location = New System.Drawing.Point(265, 113)
        Me.PRODUCT_ID_CMB.Name = "PRODUCT_ID_CMB"
        Me.PRODUCT_ID_CMB.Size = New System.Drawing.Size(211, 33)
        Me.PRODUCT_ID_CMB.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Black", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label4.Location = New System.Drawing.Point(6, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(153, 28)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "PRODUCT ID"
        '
        'PURCHASE_PRODUCT_TXT
        '
        Me.PURCHASE_PRODUCT_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PURCHASE_PRODUCT_TXT.Location = New System.Drawing.Point(265, 152)
        Me.PURCHASE_PRODUCT_TXT.Name = "PURCHASE_PRODUCT_TXT"
        Me.PURCHASE_PRODUCT_TXT.Size = New System.Drawing.Size(211, 30)
        Me.PURCHASE_PRODUCT_TXT.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Black", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label6.Location = New System.Drawing.Point(6, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(253, 28)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "PURCHASE PRODUCT"
        '
        'DISTRIBUTER_NAME_TXT
        '
        Me.DISTRIBUTER_NAME_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DISTRIBUTER_NAME_TXT.Location = New System.Drawing.Point(265, 188)
        Me.DISTRIBUTER_NAME_TXT.Name = "DISTRIBUTER_NAME_TXT"
        Me.DISTRIBUTER_NAME_TXT.Size = New System.Drawing.Size(211, 30)
        Me.DISTRIBUTER_NAME_TXT.TabIndex = 4
        '
        'SELLING_PRICE_TXT
        '
        Me.SELLING_PRICE_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SELLING_PRICE_TXT.Location = New System.Drawing.Point(761, 189)
        Me.SELLING_PRICE_TXT.Name = "SELLING_PRICE_TXT"
        Me.SELLING_PRICE_TXT.Size = New System.Drawing.Size(216, 30)
        Me.SELLING_PRICE_TXT.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Black", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label8.Location = New System.Drawing.Point(7, 191)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(237, 28)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "DISTRIBUTER NAME"
        '
        'COST_PRICE_TXT
        '
        Me.COST_PRICE_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.COST_PRICE_TXT.Location = New System.Drawing.Point(761, 153)
        Me.COST_PRICE_TXT.Name = "COST_PRICE_TXT"
        Me.COST_PRICE_TXT.Size = New System.Drawing.Size(216, 30)
        Me.COST_PRICE_TXT.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Black", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label5.Location = New System.Drawing.Point(477, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(160, 28)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "EXPIRY DATE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Black", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label3.Location = New System.Drawing.Point(477, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(278, 28)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "MANUFACTURING DATE"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Black", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label7.Location = New System.Drawing.Point(477, 155)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(148, 28)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "COST PRICE"
        '
        'MANUFACTURING_DATE_DTP
        '
        Me.MANUFACTURING_DATE_DTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MANUFACTURING_DATE_DTP.Location = New System.Drawing.Point(761, 81)
        Me.MANUFACTURING_DATE_DTP.Name = "MANUFACTURING_DATE_DTP"
        Me.MANUFACTURING_DATE_DTP.Size = New System.Drawing.Size(216, 30)
        Me.MANUFACTURING_DATE_DTP.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Black", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label9.Location = New System.Drawing.Point(477, 191)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(183, 28)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "SELLING PRICE"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 304)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1342, 248)
        Me.DataGridView1.TabIndex = 32
        '
        'STOCK_ENTRY_FORM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(1020, 563)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "STOCK_ENTRY_FORM"
        Me.Text = "STOCK ENTRY DETAILS FORM"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SAVE_BTN As System.Windows.Forms.Button
    Friend WithEvents QUANTITY_TXT As System.Windows.Forms.TextBox
    Friend WithEvents EXIT_BTN As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents UPDATE_BTN As System.Windows.Forms.Button
    Friend WithEvents DELETE_BTN As System.Windows.Forms.Button
    Friend WithEvents DATE_DTP As System.Windows.Forms.DateTimePicker
    Friend WithEvents EXPIRY_DATE_DTP As System.Windows.Forms.DateTimePicker
    Friend WithEvents PRODUCT_ID_CMB As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PURCHASE_PRODUCT_TXT As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DISTRIBUTER_NAME_TXT As System.Windows.Forms.TextBox
    Friend WithEvents SELLING_PRICE_TXT As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents COST_PRICE_TXT As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents MANUFACTURING_DATE_DTP As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
