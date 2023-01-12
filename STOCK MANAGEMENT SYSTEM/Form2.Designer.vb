<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MAIN_PAGE
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.STOCKENTRYDETAILSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BILLDETAILSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PURCHASEDETAILSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PRINTBILLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NEWUSERREGISTRATIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LOGOUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.STOCKENTRYDETAILSToolStripMenuItem, Me.PURCHASEDETAILSToolStripMenuItem, Me.NEWUSERREGISTRATIONToolStripMenuItem, Me.LOGOUTToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(733, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'STOCKENTRYDETAILSToolStripMenuItem
        '
        Me.STOCKENTRYDETAILSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BILLDETAILSToolStripMenuItem})
        Me.STOCKENTRYDETAILSToolStripMenuItem.Name = "STOCKENTRYDETAILSToolStripMenuItem"
        Me.STOCKENTRYDETAILSToolStripMenuItem.Size = New System.Drawing.Size(140, 20)
        Me.STOCKENTRYDETAILSToolStripMenuItem.Text = "STOCK ENTRY DETAILS"
        '
        'BILLDETAILSToolStripMenuItem
        '
        Me.BILLDETAILSToolStripMenuItem.Name = "BILLDETAILSToolStripMenuItem"
        Me.BILLDETAILSToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.BILLDETAILSToolStripMenuItem.Text = "BILL DETAILS"
        '
        'PURCHASEDETAILSToolStripMenuItem
        '
        Me.PURCHASEDETAILSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PRINTBILLToolStripMenuItem})
        Me.PURCHASEDETAILSToolStripMenuItem.Name = "PURCHASEDETAILSToolStripMenuItem"
        Me.PURCHASEDETAILSToolStripMenuItem.Size = New System.Drawing.Size(124, 20)
        Me.PURCHASEDETAILSToolStripMenuItem.Text = "PURCHASE DETAILS"
        '
        'PRINTBILLToolStripMenuItem
        '
        Me.PRINTBILLToolStripMenuItem.Name = "PRINTBILLToolStripMenuItem"
        Me.PRINTBILLToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.PRINTBILLToolStripMenuItem.Text = "PRINT BILL"
        '
        'NEWUSERREGISTRATIONToolStripMenuItem
        '
        Me.NEWUSERREGISTRATIONToolStripMenuItem.Name = "NEWUSERREGISTRATIONToolStripMenuItem"
        Me.NEWUSERREGISTRATIONToolStripMenuItem.Size = New System.Drawing.Size(127, 20)
        Me.NEWUSERREGISTRATIONToolStripMenuItem.Text = "NEW REGISTRATION"
        '
        'LOGOUTToolStripMenuItem
        '
        Me.LOGOUTToolStripMenuItem.Name = "LOGOUTToolStripMenuItem"
        Me.LOGOUTToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.LOGOUTToolStripMenuItem.Text = "LOG OUT"
        '
        'MAIN_PAGE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Gray
        Me.BackgroundImage = Global.STOCK_MANAGEMENT_SYSTEM.My.Resources.Resources.IMG_20170618_WA0000
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(733, 406)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MAIN_PAGE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "MAIN PAGE"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents LOGOUTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents STOCKENTRYDETAILSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BILLDETAILSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PURCHASEDETAILSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PRINTBILLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NEWUSERREGISTRATIONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
