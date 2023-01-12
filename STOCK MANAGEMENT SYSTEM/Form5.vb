Imports System.Data.SqlClient
Public Class PURCHASE_DETAILS_FORM
    Dim cn As New SqlConnection("Data Source=DESKTOP-UBSL876\SQLEXPRESS;Integrated Security=True")
    Dim cmd As New SqlCommand()
    Dim ad As New SqlDataAdapter()
    Private Sub PURCHASE_DETAILS_FORM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = MAIN_PAGE
        cl()
        cn.Open()
        g()
        cmb()
    End Sub
    Sub g()
        cmd = New SqlCommand("SELECT * FROM PURCHASE_DETAILS", cn)
        ad = New SqlDataAdapter(cmd)
        Dim ds As New DataSet()
        ad.Fill(ds, "PURCHASE_DETAILS")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "PURCHASE_DETAILS"
    End Sub
    Sub cl()
        PRODUCT_ID_TXT.Clear()
        PRODUCT_NAME_TXT.Clear()
        QUANTITY_TXT.Clear()
        DISTRIBUTER_NAME_TXT.Clear()
        DISTRIBUTER_ADDRESS_TXT.Clear()
        COST_PRICE_TXT.Clear()
        CONTACT_NUMBER_TXT.Clear()
    End Sub
    Sub cmb()
        cmd = New SqlCommand("SELECT * FROM PURCHASE_DETAILS", cn)
        ad = New SqlDataAdapter(cmd)
        Dim ds As New DataSet()
        ad.Fill(ds, "PURCHASE_DETAILS")
        SEARCH_CMB.DataSource = ds.Tables("PURCHASE_DETAILS")
        SEARCH_CMB.DisplayMember = "PURCHASE_DETAILS"
        SEARCH_CMB.ValueMember = "PRODUCT_ID"
    End Sub
    Private Sub SAVE_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SAVE_BTN.Click
        SL_NO_TXT.Text = Val(SL_NO_TXT.Text) + 1
        SL_NO_TXT.Text = Val(SL_NO_TXT.Text)
        If CONTACT_NUMBER_TXT.Text.Length > 10 Then
            MsgBox("PLEASE ENTER YOUR CONTACT NUMBER CORRECTLY")
        End If
        cmd = New SqlCommand("INSERT INTO PURCHASE_DETAILS VALUES('" & SL_NO_TXT.Text & "','" & PRODUCT_ID_TXT.Text & "','" & PRODUCT_NAME_TXT.Text & "','" & DATE_DTP.Text & "','" & MANUFACTURING_DATE_DTP.Text & "','" & EXPIRY_DATE_DTP.Text & "','" & QUANTITY_TXT.Text & "','" & DISTRIBUTER_NAME_TXT.Text & "','" & DISTRIBUTER_ADDRESS_TXT.Text & "','" & COST_PRICE_TXT.Text & "','" & CONTACT_NUMBER_TXT.Text & "')", cn)
        cmd.ExecuteNonQuery()
        MsgBox("DATA SAVED")
        cl()
        g()
    End Sub
    Private Sub UPDATE_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UPDATE_BTN.Click
        cmd = New SqlCommand("UPDATE PURCHASE_DETAILS SET SL_NO='" & SEARCH_CMB.Text & "',PRODUCT_ID='" & PRODUCT_ID_TXT.Text & "',PRODUCT_NAME='" & PRODUCT_NAME_TXT.Text & "',DATE='" & DATE_DTP.Text & "',MANUFACTURING_DATE='" & MANUFACTURING_DATE_DTP.Text & "',EXPIRIY_DATE='" & EXPIRY_DATE_DTP.Text & "',QUANTITY='" & QUANTITY_TXT.Text & "',DISTRIBUTE_NAME='" & DISTRIBUTER_NAME_TXT.Text & "',DISTRIBUTER_ADDRESS='" & DISTRIBUTER_ADDRESS_TXT.Text & "',COST_PRICE='" & COST_PRICE_TXT.Text & "',CONTACT_NUMBER='" & CONTACT_NUMBER_TXT.Text & "' where PRODUCT_ID='" & PRODUCT_ID_TXT.Text & "'", cn)
        cmd.ExecuteNonQuery()
        MsgBox("DATA UPDATED")
        g()
        cl()
    End Sub

    Private Sub DELETE_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DELETE_BTN.Click
        cmd = New SqlCommand("DELETE FROM PURCHASE_DETAILS WHERE PRODUCT_ID='" & PRODUCT_ID_TXT.Text & "'", cn)
        cmd.ExecuteNonQuery()
        MsgBox("DATA DELETED")
        g()
        cl()
    End Sub
    Private Sub EXIT_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EXIT_BTN.Click
        Me.Close()
        LOGIN_FRM.Hide()
        STOCK_ENTRY_FORM.Hide()
        BILL_VIEW_FORM.Hide()
        BILL_PRINT_FORM.Hide()
        BILL_DATA_FORM.Hide()
        INTERNAL_BILL_VIEW_FORM.Hide()
        MAIN_PAGE.Show()
    End Sub
    Private Sub PRODUCT_ID_TXT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PRODUCT_ID_TXT.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            MsgBox("YOU CAN ONLY INPUT NUMERIC VALUE")
        End If
    End Sub
    Private Sub PRODUCT_NAME_TXT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PRODUCT_NAME_TXT.KeyPress
        If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 122 Then
            e.Handled = True
            MsgBox("YOU CAN ONLY INPUT CHARACTER OR STRING")
        End If
    End Sub
    Private Sub QUANTITY_TXT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles QUANTITY_TXT.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            MsgBox("YOU CAN ONLY INPUT NUMERIC VALUE")
        End If
    End Sub
    Private Sub DISTRIBUTER_NAME_TXT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DISTRIBUTER_NAME_TXT.KeyPress
        If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 122 Then
            e.Handled = True
            MsgBox("YOU CAN ONLY INPUT CHARACTER OR STRING")
        End If
    End Sub
    Private Sub COST_PRICE_TXT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles COST_PRICE_TXT.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            MsgBox("YOU CAN ONLY INPUT NUMERIC VALUE")
        End If
    End Sub
    Private Sub CONTACT_NUMBER_TXT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CONTACT_NUMBER_TXT.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            MsgBox("YOU CAN ONLY INPUT NUMERIC VALUE")
        End If
    End Sub
    Private Sub SEARCH_CMB_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SEARCH_CMB.SelectedIndexChanged
        cl()
        cmd = New SqlCommand("SELECT * FROM PURCHASE_DETAILS", cn)
        ad = New SqlDataAdapter(cmd)
        Dim es As New DataSet()
        ad.Fill(es, "PURCHASE_DETAILS")
        SEARCH_CMB.Text = es.Tables("PURCHASE_DETAILS").Rows(SEARCH_CMB.SelectedIndex).Item("SL_NO")
        PRODUCT_ID_TXT.Text = es.Tables("PURCHASE_DETAILS").Rows(SEARCH_CMB.SelectedIndex).Item("PRODUCT_ID")
        PRODUCT_NAME_TXT.Text = es.Tables("PURCHASE_DETAILS").Rows(SEARCH_CMB.SelectedIndex).Item("PRODUCT_NAME")
        DATE_DTP.Text = es.Tables("PURCHASE_DETAILS").Rows(SEARCH_CMB.SelectedIndex).Item("DATE")
        MANUFACTURING_DATE_DTP.Text = es.Tables("PURCHASE_DETAILS").Rows(SEARCH_CMB.SelectedIndex).Item("MANUFACTURING_DATE")
        EXPIRY_DATE_DTP.Text = es.Tables("PURCHASE_DETAILS").Rows(SEARCH_CMB.SelectedIndex).Item("EXPIRIY_DATE")
        QUANTITY_TXT.Text = es.Tables("PURCHASE_DETAILS").Rows(SEARCH_CMB.SelectedIndex).Item("QUANTITY")
        DISTRIBUTER_NAME_TXT.Text = es.Tables("PURCHASE_DETAILS").Rows(SEARCH_CMB.SelectedIndex).Item("DISTRIBUTE_NAME")
        DISTRIBUTER_ADDRESS_TXT.Text = es.Tables("PURCHASE_DETAILS").Rows(SEARCH_CMB.SelectedIndex).Item("DISTRIBUTER_ADDRESS")
        COST_PRICE_TXT.Text = es.Tables("PURCHASE_DETAILS").Rows(SEARCH_CMB.SelectedIndex).Item("COST_PRICE")
        CONTACT_NUMBER_TXT.Text = es.Tables("PURCHASE_DETAILS").Rows(SEARCH_CMB.SelectedIndex).Item("CONTACT_NUMBER")
    End Sub
End Class