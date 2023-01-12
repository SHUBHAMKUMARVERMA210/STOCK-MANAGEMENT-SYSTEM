Imports System.Data.SqlClient
Public Class BILL_PRINT_FORM
    Dim rn As New Random
    Dim cn As New SqlConnection("Data Source=DESKTOP-UBSL876\SQLEXPRESS;Integrated Security=True")
    Dim cmd As New SqlCommand()
    Dim ad As New SqlDataAdapter()
    Sub g()
        cmd = New SqlCommand("SELECT * FROM BILL_PRINT", cn)
        ad = New SqlDataAdapter(cmd)
        Dim ds As New DataSet()
        ad.Fill(ds, "BILL_PRINT")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "BILL_PRINT"
    End Sub
    Sub cmb()
        cmd = New SqlCommand("SELECT * FROM STOCK", cn)
        ad = New SqlDataAdapter(cmd)
        Dim ds As New DataSet()
        ad.Fill(ds, "STOCK")
        PRODUCT_ID_CMB.DataSource = ds.Tables("STOCK")
        PRODUCT_ID_CMB.DisplayMember = "STOCK"
        PRODUCT_ID_CMB.ValueMember = "PRODUCT_ID"
    End Sub
    Sub cmp()
        cmd = New SqlCommand("SELECT * FROM BILL_PRINT", cn)
        ad = New SqlDataAdapter(cmd)
        Dim ds As New DataSet()
        ad.Fill(ds, "BILL_PRINT")
        SEARCH_CMB.DataSource = ds.Tables("BILL_PRINT")
        SEARCH_CMB.DisplayMember = "BILL_PRINT"
        SEARCH_CMB.ValueMember = "BILL_NUMBER"
    End Sub
    Sub cl()
        PRODUCT_NAME_TXT.Clear()
        SELLING_PRICE_TXT.Clear()
        QUANTITY_TXT.Clear()
        TOTAL_TXT.Clear()
    End Sub
    Private Sub PRODUCT_ID_CMB_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PRODUCT_ID_CMB.SelectedIndexChanged
        cl()
        cmd = New SqlCommand("SELECT * FROM STOCK", cn)
        ad = New SqlDataAdapter(cmd)
        Dim es As New DataSet()
        ad.Fill(es, "STOCK")
        PRODUCT_ID_CMB.Text = es.Tables("STOCK").Rows(PRODUCT_ID_CMB.SelectedIndex).Item("PRODUCT_ID")
        PRODUCT_NAME_TXT.Text = es.Tables("STOCK").Rows(PRODUCT_ID_CMB.SelectedIndex).Item("PURCHASE_PRODUCT")
        MANUFACTURING_DATE_DTP.Text = es.Tables("STOCK").Rows(PRODUCT_ID_CMB.SelectedIndex).Item("MANUFACTURING_DATE")
        EXPITY_DATE_DTP.Text = es.Tables("STOCK").Rows(PRODUCT_ID_CMB.SelectedIndex).Item("EXPIRIY_DATE")
        SELLING_PRICE_TXT.Text = es.Tables("STOCK").Rows(PRODUCT_ID_CMB.SelectedIndex).Item("SELLING_PRICE")
        AVIL_QTY_TXT.Text = es.Tables("STOCK").Rows(PRODUCT_ID_CMB.SelectedIndex).Item("QUANTITY")
    End Sub
    Private Sub SEARCH_CMB_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SEARCH_CMB.SelectedIndexChanged
        cl()
        cmd = New SqlCommand("SELECT * FROM BILL_PRINT", cn)
        ad = New SqlDataAdapter(cmd)
        Dim es As New DataSet()
        ad.Fill(es, "BILL_PRINT")
        SEARCH_CMB.Text = es.Tables("BILL_PRINT").Rows(SEARCH_CMB.SelectedIndex).Item("BILL_NUMBER")
    End Sub
    Private Sub BILL_PRINT_FORM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = MAIN_PAGE
        cn.Open()
        g()
        cl()
        SL_NO_TXT.Clear()
        cmb()
        cmp()
    End Sub
    Private Sub QUANTITY_TXT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles QUANTITY_TXT.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            MsgBox("YOU CAN ONLY INPUT NUMERIC VALUE")
        End If
    End Sub
    Private Sub ADD_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADD_BTN.Click
        SL_NO_TXT.Text = Val(SL_NO_TXT.Text) + 1
        SL_NO_TXT.Text = Val(SL_NO_TXT.Text)
        TOTAL_TXT.Text = Val(SELLING_PRICE_TXT.Text) * Val(QUANTITY_TXT.Text)
        AVIL_QTY_TXT.Text = Val(AVIL_QTY_TXT.Text) - Val(QUANTITY_TXT.Text)
        cmd = New SqlCommand("UPDATE STOCK SET QUANTITY='" & AVIL_QTY_TXT.Text & "'  where PRODUCT_ID='" & Me.PRODUCT_ID_CMB.Text & "'", cn)
        cmd.ExecuteNonQuery()
        STOCK_ENTRY_FORM.g()
        cmd = New SqlCommand("INSERT INTO NEW_BILL VALUES('" & SL_NO_TXT.Text & "','" & PRODUCT_ID_CMB.Text & "','" & PRODUCT_NAME_TXT.Text & "','" & DATE_DTP.Text & "','" & MANUFACTURING_DATE_DTP.Text & "','" & EXPITY_DATE_DTP.Text & "','" & SELLING_PRICE_TXT.Text & "','" & QUANTITY_TXT.Text & "','" & TOTAL_TXT.Text & "')", cn)
        cmd.ExecuteNonQuery()
        BILL_VIEW_FORM.p()
        RichTextBox1.AppendText(vbNewLine & SL_NO_TXT.Text & "   " & PRODUCT_ID_CMB.Text & "   " & PRODUCT_NAME_TXT.Text & "   " & DATE_DTP.Text & "   " & MANUFACTURING_DATE_DTP.Text & "    " & EXPITY_DATE_DTP.Text & "   " & SELLING_PRICE_TXT.Text & "    " & QUANTITY_TXT.Text & "    " & TOTAL_TXT.Text & "   " & vbNewLine)
        TOTAL_TXT.Text = Val(GRAND_TOTAL_TXT.Text) + Val(TOTAL_TXT.Text)
        GRAND_TOTAL_TXT.Text = Val(TOTAL_TXT.Text)
        TOTAL_TXT.Clear()
    End Sub
    Private Sub EXIT_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EXIT_BTN.Click
        Me.Close()
        LOGIN_FRM.Hide()
        STOCK_ENTRY_FORM.Hide()
        BILL_VIEW_FORM.Hide()
        PURCHASE_DETAILS_FORM.Hide()
        BILL_DATA_FORM.Hide()
        INTERNAL_BILL_VIEW_FORM.Hide()
        MAIN_PAGE.Show()
    End Sub
    Private Sub SAVE_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SAVE_BTN.Click
        BILL_NUMBER_TXT.Text = rn.Next(1, 100)
        GRAND_TOTAL_TXT.Text = Val(GRAND_TOTAL_TXT.Text)
        cmd = New SqlCommand("INSERT INTO BILL_PRINT VALUES('" & BILL_NUMBER_TXT.Text & "','" & RichTextBox1.Text & "','" & GRAND_TOTAL_TXT.Text & "')", cn)
        cmd.ExecuteNonQuery()
        cmd = New SqlCommand("INSERT INTO BILL_VIEW VALUES('" & BILL_NUMBER_TXT.Text & "','" & RichTextBox1.Text & "','" & GRAND_TOTAL_TXT.Text & "')", cn)
        cmd.ExecuteNonQuery()
        BILL_VIEW_FORM.g()
        MsgBox("DATA SAVED")
        cl()
        g()
    End Sub
    Private Sub PRINT_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PRINT_BTN.Click
        BILL_DATA_FORM.Show()
        LOGIN_FRM.Hide()
        STOCK_ENTRY_FORM.Hide()
        BILL_VIEW_FORM.Hide()
        PURCHASE_DETAILS_FORM.Hide()
        Me.Hide()
    End Sub
    Private Sub REFRESH_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REFRESH_BTN.Click
        g()
        SL_NO_TXT.Clear()
        cl()
        cmb()
        cmp()
        cmd = New SqlCommand("DELETE FROM BILL_PRINT WHERE BILL_NUMBER='" & SEARCH_CMB.Text & "'", cn)
        cmd.ExecuteNonQuery()
        MsgBox("DATA REFRESHED")
        g()
        cl()
        cmd = New SqlCommand("DELETE FROM NEW_BILL ", cn)
        cmd.ExecuteNonQuery()
        BILL_VIEW_FORM.p()
    End Sub
End Class