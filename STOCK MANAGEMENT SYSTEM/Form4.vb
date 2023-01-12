Imports System.Data.SqlClient
Public Class BILL_VIEW_FORM
    Dim rn As New Random
    Dim cn As New SqlConnection("Data Source=DESKTOP-UBSL876\SQLEXPRESS;Integrated Security=True")
    Dim cmd As New SqlCommand()
    Dim ad As New SqlDataAdapter()
 Private Sub BILL_VIEW_FORM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = MAIN_PAGE
        cn.Open()
        g()
        p()
    End Sub
    Sub g()
        cmd = New SqlCommand("SELECT * FROM BILL_VIEW", cn)
        ad = New SqlDataAdapter(cmd)
        Dim ds As New DataSet()
        ad.Fill(ds, "BILL_VIEW")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "BILL_VIEW"
    End Sub
    Sub p()
        cmd = New SqlCommand("SELECT * FROM NEW_BILL", cn)
        ad = New SqlDataAdapter(cmd)
        Dim ds As New DataSet()
        ad.Fill(ds, "NEW_BILL")
    End Sub
    Private Sub EXIT_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EXIT_BTN.Click
        Me.Close()
        LOGIN_FRM.Hide()
        STOCK_ENTRY_FORM.Hide()
        PURCHASE_DETAILS_FORM.Hide()
        BILL_PRINT_FORM.Hide()
        MAIN_PAGE.Show()
    End Sub
    Private Sub VIEW_DATA_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VIEW_DATA_BTN.Click
        INTERNAL_BILL_VIEW_FORM.Show()
        STOCK_ENTRY_FORM.Hide()
        Me.Hide()
        PURCHASE_DETAILS_FORM.Hide()
        BILL_PRINT_FORM.Hide()
        BILL_DATA_FORM.Hide()
    End Sub
End Class