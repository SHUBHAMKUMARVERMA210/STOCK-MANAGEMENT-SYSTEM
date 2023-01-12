Public Class MAIN_PAGE
    Private Sub STOCKENTRYDETAILSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles STOCKENTRYDETAILSToolStripMenuItem.Click
        If LOGIN_FRM.LG_TYP_CMB.Text = "ADMIN" Then
            STOCK_ENTRY_FORM.cl()
            STOCK_ENTRY_FORM.Show()
            LOGIN_FRM.Hide()
            BILL_VIEW_FORM.Hide()
            PURCHASE_DETAILS_FORM.Hide()
            BILL_PRINT_FORM.Hide()
            NEW_REGISTRATION_FORM.Hide()
            STOCK_ENTRY_FORM.cl()
        ElseIf LOGIN_FRM.LG_TYP_CMB.Text <> "ADMIN" Then
            MsgBox("LOGIN WITH ADMIN")
        End If
    End Sub

    Private Sub BILLDETAILSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BILLDETAILSToolStripMenuItem.Click
        BILL_VIEW_FORM.Show()
        LOGIN_FRM.Hide()
        STOCK_ENTRY_FORM.Hide()
        PURCHASE_DETAILS_FORM.Hide()
        BILL_PRINT_FORM.Hide()
        NEW_REGISTRATION_FORM.Hide()
    End Sub

    Private Sub PURCHASEDETAILSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PURCHASEDETAILSToolStripMenuItem.Click
        If LOGIN_FRM.LG_TYP_CMB.Text = "ADMIN" Then
            PURCHASE_DETAILS_FORM.cl()
            PURCHASE_DETAILS_FORM.Show()
            LOGIN_FRM.Hide()
            BILL_VIEW_FORM.Hide()
            STOCK_ENTRY_FORM.Hide()
            BILL_PRINT_FORM.Hide()
            NEW_REGISTRATION_FORM.Hide()
        ElseIf LOGIN_FRM.LG_TYP_CMB.Text <> "ADMIN" Then
            MsgBox("LOGIN WITH ADMIN")
        End If
    End Sub

    Private Sub LOGOUTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOGOUTToolStripMenuItem.Click
        Select Case MsgBox("ARE YOU SURE TO LOG OUT ", MsgBoxStyle.YesNoCancel)
            Case MsgBoxResult.Yes
                LOGIN_FRM.Show()
                Me.Hide()
                STOCK_ENTRY_FORM.Hide()
                BILL_VIEW_FORM.Hide()
                PURCHASE_DETAILS_FORM.Hide()
                BILL_PRINT_FORM.Hide()
                BILL_DATA_FORM.Hide()
                INTERNAL_BILL_VIEW_FORM.Hide()
                NEW_REGISTRATION_FORM.Hide()
                LOGIN_FRM.US_NM_TXT.Clear()
                LOGIN_FRM.PS_TXT.Clear()
            Case MsgBoxResult.No
                MsgBox("SELECTION ABORTED")
                Me.Show()
                LOGIN_FRM.Hide()
                STOCK_ENTRY_FORM.Hide()
                BILL_VIEW_FORM.Hide()
                PURCHASE_DETAILS_FORM.Hide()
                BILL_PRINT_FORM.Hide()
                BILL_DATA_FORM.Hide()
                INTERNAL_BILL_VIEW_FORM.Hide()
                NEW_REGISTRATION_FORM.Hide()
            Case MsgBoxResult.Cancel
        End Select
    End Sub

    Private Sub PRINTBILLToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PRINTBILLToolStripMenuItem.Click
        BILL_PRINT_FORM.Show()
        LOGIN_FRM.Hide()
        BILL_VIEW_FORM.Hide()
        STOCK_ENTRY_FORM.Hide()
        PURCHASE_DETAILS_FORM.Hide()
        NEW_REGISTRATION_FORM.Hide()
        BILL_PRINT_FORM.g()
        BILL_PRINT_FORM.cl()
        BILL_PRINT_FORM.cmb()
        BILL_PRINT_FORM.cmp()
        BILL_PRINT_FORM.RichTextBox1.Clear()
    End Sub
    Private Sub NEWUSERREGISTRATIONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NEWUSERREGISTRATIONToolStripMenuItem.Click
        If LOGIN_FRM.LG_TYP_CMB.Text = "ADMIN" Then
            NEW_REGISTRATION_FORM.cl()
            NEW_REGISTRATION_FORM.Show()
            LOGIN_FRM.Hide()
            STOCK_ENTRY_FORM.Hide()
            BILL_VIEW_FORM.Hide()
            PURCHASE_DETAILS_FORM.Hide()
            BILL_PRINT_FORM.Hide()
        ElseIf LOGIN_FRM.LG_TYP_CMB.Text <> "ADMIN" Then
            MsgBox("LOGIN WITH ADMIN")
        End If
    End Sub
End Class