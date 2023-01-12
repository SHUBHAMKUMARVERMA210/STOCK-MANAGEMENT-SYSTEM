<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BILL_PRINT_FORM
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
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.SL_NO_TXT = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.GRAND_TOTAL_TXT = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.AVIL_QTY_TXT = New System.Windows.Forms.TextBox
        Me.BILL_NUMBER_TXT = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.REFRESH_BTN = New System.Windows.Forms.Button
        Me.SEARCH_CMB = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.PRINT_BTN = New System.Windows.Forms.Button
        Me.SAVE_BTN = New System.Windows.Forms.Button
        Me.EXIT_BTN = New System.Windows.Forms.Button
        Me.TOTAL_TXT = New System.Windows.Forms.TextBox
        Me.QUANTITY_TXT = New System.Windows.Forms.TextBox
        Me.SELLING_PRICE_TXT = New System.Windows.Forms.TextBox
        Me.EXPITY_DATE_DTP = New System.Windows.Forms.DateTimePicker
        Me.MANUFACTURING_DATE_DTP = New System.Windows.Forms.DateTimePicker
        Me.DATE_DTP = New System.Windows.Forms.DateTimePicker
        Me.PRODUCT_NAME_TXT = New System.Windows.Forms.TextBox
        Me.PRODUCT_ID_CMB = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.ADD_BTN = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(2, 337)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(996, 176)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SL_NO_TXT)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.GRAND_TOTAL_TXT)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.AVIL_QTY_TXT)
        Me.GroupBox1.Controls.Add(Me.BILL_NUMBER_TXT)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.REFRESH_BTN)
        Me.GroupBox1.Controls.Add(Me.SEARCH_CMB)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.PRINT_BTN)
        Me.GroupBox1.Controls.Add(Me.SAVE_BTN)
        Me.GroupBox1.Controls.Add(Me.EXIT_BTN)
        Me.GroupBox1.Controls.Add(Me.TOTAL_TXT)
        Me.GroupBox1.Controls.Add(Me.QUANTITY_TXT)
        Me.GroupBox1.Controls.Add(Me.SELLING_PRICE_TXT)
        Me.GroupBox1.Controls.Add(Me.EXPITY_DATE_DTP)
        Me.GroupBox1.Controls.Add(Me.MANUFACTURING_DATE_DTP)
        Me.GroupBox1.Controls.Add(Me.DATE_DTP)
        Me.GroupBox1.Controls.Add(Me.PRODUCT_NAME_TXT)
        Me.GroupBox1.Controls.Add(Me.PRODUCT_ID_CMB)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ADD_BTN)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Modern No. 20", 39.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(996, 319)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "BILL PRINT"
        '
        'SL_NO_TXT
        '
        Me.SL_NO_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SL_NO_TXT.Location = New System.Drawing.Point(347, 61)
        Me.SL_NO_TXT.Name = "SL_NO_TXT"
        Me.SL_NO_TXT.ReadOnly = True
        Me.SL_NO_TXT.Size = New System.Drawing.Size(216, 30)
        Me.SL_NO_TXT.TabIndex = 29
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial Black", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label13.Location = New System.Drawing.Point(6, 63)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 28)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "SL.NO"
        '
        'GRAND_TOTAL_TXT
        '
        Me.GRAND_TOTAL_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRAND_TOTAL_TXT.Location = New System.Drawing.Point(755, 283)
        Me.GRAND_TOTAL_TXT.Name = "GRAND_TOTAL_TXT"
        Me.GRAND_TOTAL_TXT.ReadOnly = True
        Me.GRAND_TOTAL_TXT.Size = New System.Drawing.Size(213, 30)
        Me.GRAND_TOTAL_TXT.TabIndex = 12
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Black", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label12.Location = New System.Drawing.Point(569, 285)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(172, 28)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "GRAND TOTAL"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial Black", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label11.Location = New System.Drawing.Point(569, 249)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(118, 28)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "AVIL QTY"
        '
        'AVIL_QTY_TXT
        '
        Me.AVIL_QTY_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AVIL_QTY_TXT.Location = New System.Drawing.Point(755, 247)
        Me.AVIL_QTY_TXT.Name = "AVIL_QTY_TXT"
        Me.AVIL_QTY_TXT.ReadOnly = True
        Me.AVIL_QTY_TXT.Size = New System.Drawing.Size(213, 30)
        Me.AVIL_QTY_TXT.TabIndex = 11
        '
        'BILL_NUMBER_TXT
        '
        Me.BILL_NUMBER_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BILL_NUMBER_TXT.Location = New System.Drawing.Point(347, 97)
        Me.BILL_NUMBER_TXT.Name = "BILL_NUMBER_TXT"
        Me.BILL_NUMBER_TXT.ReadOnly = True
        Me.BILL_NUMBER_TXT.Size = New System.Drawing.Size(216, 30)
        Me.BILL_NUMBER_TXT.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Black", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label10.Location = New System.Drawing.Point(569, 208)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 28)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "SEARCH"
        '
        'REFRESH_BTN
        '
        Me.REFRESH_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REFRESH_BTN.Location = New System.Drawing.Point(434, 279)
        Me.REFRESH_BTN.Name = "REFRESH_BTN"
        Me.REFRESH_BTN.Size = New System.Drawing.Size(113, 34)
        Me.REFRESH_BTN.TabIndex = 22
        Me.REFRESH_BTN.Text = "REFRESH"
        Me.REFRESH_BTN.UseVisualStyleBackColor = True
        '
        'SEARCH_CMB
        '
        Me.SEARCH_CMB.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SEARCH_CMB.FormattingEnabled = True
        Me.SEARCH_CMB.Location = New System.Drawing.Point(755, 203)
        Me.SEARCH_CMB.Name = "SEARCH_CMB"
        Me.SEARCH_CMB.Size = New System.Drawing.Size(213, 33)
        Me.SEARCH_CMB.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Black", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label9.Location = New System.Drawing.Point(6, 99)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(168, 28)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "BILL NUMBER"
        '
        'PRINT_BTN
        '
        Me.PRINT_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PRINT_BTN.Location = New System.Drawing.Point(323, 279)
        Me.PRINT_BTN.Name = "PRINT_BTN"
        Me.PRINT_BTN.Size = New System.Drawing.Size(105, 34)
        Me.PRINT_BTN.TabIndex = 19
        Me.PRINT_BTN.Text = "PRINT"
        Me.PRINT_BTN.UseVisualStyleBackColor = True
        '
        'SAVE_BTN
        '
        Me.SAVE_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SAVE_BTN.Location = New System.Drawing.Point(212, 279)
        Me.SAVE_BTN.Name = "SAVE_BTN"
        Me.SAVE_BTN.Size = New System.Drawing.Size(105, 34)
        Me.SAVE_BTN.TabIndex = 15
        Me.SAVE_BTN.Text = "SAVE"
        Me.SAVE_BTN.UseVisualStyleBackColor = True
        '
        'EXIT_BTN
        '
        Me.EXIT_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EXIT_BTN.Location = New System.Drawing.Point(101, 279)
        Me.EXIT_BTN.Name = "EXIT_BTN"
        Me.EXIT_BTN.Size = New System.Drawing.Size(105, 34)
        Me.EXIT_BTN.TabIndex = 14
        Me.EXIT_BTN.Text = "EXIT"
        Me.EXIT_BTN.UseVisualStyleBackColor = True
        '
        'TOTAL_TXT
        '
        Me.TOTAL_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TOTAL_TXT.Location = New System.Drawing.Point(755, 167)
        Me.TOTAL_TXT.Name = "TOTAL_TXT"
        Me.TOTAL_TXT.ReadOnly = True
        Me.TOTAL_TXT.Size = New System.Drawing.Size(213, 30)
        Me.TOTAL_TXT.TabIndex = 9
        '
        'QUANTITY_TXT
        '
        Me.QUANTITY_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QUANTITY_TXT.Location = New System.Drawing.Point(755, 131)
        Me.QUANTITY_TXT.Name = "QUANTITY_TXT"
        Me.QUANTITY_TXT.Size = New System.Drawing.Size(213, 30)
        Me.QUANTITY_TXT.TabIndex = 8
        '
        'SELLING_PRICE_TXT
        '
        Me.SELLING_PRICE_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SELLING_PRICE_TXT.Location = New System.Drawing.Point(755, 95)
        Me.SELLING_PRICE_TXT.Name = "SELLING_PRICE_TXT"
        Me.SELLING_PRICE_TXT.ReadOnly = True
        Me.SELLING_PRICE_TXT.Size = New System.Drawing.Size(213, 30)
        Me.SELLING_PRICE_TXT.TabIndex = 7
        '
        'EXPITY_DATE_DTP
        '
        Me.EXPITY_DATE_DTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EXPITY_DATE_DTP.Location = New System.Drawing.Point(755, 56)
        Me.EXPITY_DATE_DTP.Name = "EXPITY_DATE_DTP"
        Me.EXPITY_DATE_DTP.Size = New System.Drawing.Size(213, 30)
        Me.EXPITY_DATE_DTP.TabIndex = 6
        '
        'MANUFACTURING_DATE_DTP
        '
        Me.MANUFACTURING_DATE_DTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MANUFACTURING_DATE_DTP.Location = New System.Drawing.Point(347, 243)
        Me.MANUFACTURING_DATE_DTP.Name = "MANUFACTURING_DATE_DTP"
        Me.MANUFACTURING_DATE_DTP.Size = New System.Drawing.Size(216, 30)
        Me.MANUFACTURING_DATE_DTP.TabIndex = 5
        '
        'DATE_DTP
        '
        Me.DATE_DTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DATE_DTP.Location = New System.Drawing.Point(347, 208)
        Me.DATE_DTP.Name = "DATE_DTP"
        Me.DATE_DTP.Size = New System.Drawing.Size(216, 30)
        Me.DATE_DTP.TabIndex = 4
        '
        'PRODUCT_NAME_TXT
        '
        Me.PRODUCT_NAME_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PRODUCT_NAME_TXT.Location = New System.Drawing.Point(347, 172)
        Me.PRODUCT_NAME_TXT.Name = "PRODUCT_NAME_TXT"
        Me.PRODUCT_NAME_TXT.ReadOnly = True
        Me.PRODUCT_NAME_TXT.Size = New System.Drawing.Size(216, 30)
        Me.PRODUCT_NAME_TXT.TabIndex = 3
        '
        'PRODUCT_ID_CMB
        '
        Me.PRODUCT_ID_CMB.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PRODUCT_ID_CMB.FormattingEnabled = True
        Me.PRODUCT_ID_CMB.Location = New System.Drawing.Point(347, 133)
        Me.PRODUCT_ID_CMB.Name = "PRODUCT_ID_CMB"
        Me.PRODUCT_ID_CMB.Size = New System.Drawing.Size(216, 33)
        Me.PRODUCT_ID_CMB.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Black", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label8.Location = New System.Drawing.Point(569, 169)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 28)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "TOTAL"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Black", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label7.Location = New System.Drawing.Point(569, 133)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 28)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "QUANTITY"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Black", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label6.Location = New System.Drawing.Point(569, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(183, 28)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "SELLING PRICE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Black", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label5.Location = New System.Drawing.Point(569, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(160, 28)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "EXPIRY DATE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Black", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label4.Location = New System.Drawing.Point(6, 248)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(278, 28)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "MANUFACTURING DATE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Black", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label3.Location = New System.Drawing.Point(6, 211)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 28)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "DATE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Black", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label2.Location = New System.Drawing.Point(6, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(195, 28)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "PRODUCT NAME"
        '
        'ADD_BTN
        '
        Me.ADD_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ADD_BTN.Location = New System.Drawing.Point(11, 279)
        Me.ADD_BTN.Name = "ADD_BTN"
        Me.ADD_BTN.Size = New System.Drawing.Size(84, 34)
        Me.ADD_BTN.TabIndex = 13
        Me.ADD_BTN.Text = "ADD"
        Me.ADD_BTN.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label1.Location = New System.Drawing.Point(6, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PRODUCT ID"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(36, 519)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(539, 114)
        Me.DataGridView1.TabIndex = 2
        '
        'BILL_PRINT_FORM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(1020, 656)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Name = "BILL_PRINT_FORM"
        Me.Text = "BILL ENTRY"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ADD_BTN As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DATE_DTP As System.Windows.Forms.DateTimePicker
    Friend WithEvents PRODUCT_NAME_TXT As System.Windows.Forms.TextBox
    Friend WithEvents PRODUCT_ID_CMB As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents EXPITY_DATE_DTP As System.Windows.Forms.DateTimePicker
    Friend WithEvents MANUFACTURING_DATE_DTP As System.Windows.Forms.DateTimePicker
    Friend WithEvents SELLING_PRICE_TXT As System.Windows.Forms.TextBox
    Friend WithEvents TOTAL_TXT As System.Windows.Forms.TextBox
    Friend WithEvents QUANTITY_TXT As System.Windows.Forms.TextBox
    Friend WithEvents EXIT_BTN As System.Windows.Forms.Button
    Friend WithEvents SAVE_BTN As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PRINT_BTN As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents SEARCH_CMB As System.Windows.Forms.ComboBox
    Friend WithEvents REFRESH_BTN As System.Windows.Forms.Button
    Friend WithEvents BILL_NUMBER_TXT As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GRAND_TOTAL_TXT As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents SL_NO_TXT As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents AVIL_QTY_TXT As System.Windows.Forms.TextBox
End Class
