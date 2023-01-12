Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Public Class NEW_REGISTRATION_FORM
    Dim cn As New SqlConnection("Data Source=DESKTOP-UBSL876\SQLEXPRESS;Integrated Security=True")
    Dim cmd As New SqlCommand()
    Dim ad As New SqlDataAdapter()
    Private Sub Form9_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = MAIN_PAGE
        cn.Open()
        g()
        cmb()
        cl()
    End Sub
    Sub cl()
        NAME_TXT.Clear()
        LOGIN_TYPE_TXT.Clear()
        USERNAME_TXT.Clear()
        PASSWORD_TXT.Clear()
        CONTACT_NO_TXT.Clear()
        ADDRESS_TXT.Clear()
        REGISTRATION_NO_TXT.Clear()
    End Sub
    Sub g()
        cmd = New SqlCommand("SELECT * FROM TABLE_LOGIN", cn)
        ad = New SqlDataAdapter(cmd)
        Dim ds As New DataSet()
        ad.Fill(ds, "TABLE_LOGIN")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "TABLE_LOGIN"
    End Sub
    Sub cmb()
        cmd = New SqlCommand("SELECT * FROM TABLE_LOGIN", cn)
        ad = New SqlDataAdapter(cmd)
        Dim ds As New DataSet()
        ad.Fill(ds, "TABLE_LOGIN")
        SEARCH_INFO_CMB.DataSource = ds.Tables("TABLE_LOGIN")
        SEARCH_INFO_CMB.DisplayMember = "TABLE_LOGIN"
        SEARCH_INFO_CMB.ValueMember = "REGISTRATION_NUMBER"
    End Sub
    Private Sub SAVE_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SAVE_BTN.Click
        cmd = New SqlCommand("INSERT INTO TABLE_LOGIN VALUES('" & NAME_TXT.Text & "','" & LOGIN_TYPE_TXT.Text & "','" & USERNAME_TXT.Text & "','" & PASSWORD_TXT.Text & "','" & CONTACT_NO_TXT.Text & "','" & ADDRESS_TXT.Text & "','" & DATE_DTP.Text & "','" & REGISTRATION_NO_TXT.Text & "')", cn)
        cmd.ExecuteNonQuery()
        MsgBox("NEW REGISTRATION DONE FOR " & Val(LOGIN_TYPE_TXT.Text) & "")
        cl()
        g()
    End Sub
    Private Sub UPDATE_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UPDATE_BTN.Click
        cmd = New SqlCommand("UPDATE TABLE_LOGIN SET NAME_='" & NAME_TXT.Text & "',LOGGIN_TYPE='" & LOGIN_TYPE_TXT.Text & "',USERNAME='" & USERNAME_TXT.Text & "',UPASSWORD='" & PASSWORD_TXT.Text & "',CONTACT_NUMBER='" & CONTACT_NO_TXT.Text & "',ADDRESS_='" & ADDRESS_TXT.Text & "',DATE='" & DATE_DTP.Text & "',REGISTRATION_NUMBER='" & REGISTRATION_NO_TXT.Text & "' where REGISTRATION_NUMBER='" & REGISTRATION_NO_TXT.Text & "'", cn)
        cmd.ExecuteNonQuery()
        MsgBox("DATA UPDATED FOR " & Val(LOGIN_TYPE_TXT.Text) & "")
        g()
        cl()
    End Sub
    Private Sub DELETE_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DELETE_BTN.Click
        cmd = New SqlCommand("DELETE FROM TABLE_LOGIN WHERE REGISTRATION_NUMBER='" & REGISTRATION_NO_TXT.Text & "'", cn)
        cmd.ExecuteNonQuery()
        MsgBox("DATA DELETED FOR" & Val(REGISTRATION_NO_TXT.Text) & "")
        g()
        cl()
    End Sub
    Private Sub EXIT_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EXIT_BTN.Click
        Me.Close()
        LOGIN_FRM.Hide()
        BILL_VIEW_FORM.Hide()
        PURCHASE_DETAILS_FORM.Hide()
        BILL_PRINT_FORM.Hide()
        BILL_DATA_FORM.Hide()
        INTERNAL_BILL_VIEW_FORM.Hide()
        STOCK_ENTRY_FORM.Hide()
        MAIN_PAGE.Show()
    End Sub

    Private Sub SEARCH_INFO_CMB_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SEARCH_INFO_CMB.SelectedIndexChanged
        cl()
        cmd = New SqlCommand("SELECT * FROM TABLE_LOGIN", cn)
        ad = New SqlDataAdapter(cmd)
        Dim es As New DataSet()
        ad.Fill(es, "TABLE_LOGIN")
        NAME_TXT.Text = es.Tables("TABLE_LOGIN").Rows(SEARCH_INFO_CMB.SelectedIndex).Item("NAME_")
        LOGIN_TYPE_TXT.Text = es.Tables("TABLE_LOGIN").Rows(SEARCH_INFO_CMB.SelectedIndex).Item("LOGGIN_TYPE")
        USERNAME_TXT.Text = es.Tables("TABLE_LOGIN").Rows(SEARCH_INFO_CMB.SelectedIndex).Item("USERNAME")
        PASSWORD_TXT.Text = es.Tables("TABLE_LOGIN").Rows(SEARCH_INFO_CMB.SelectedIndex).Item("UPASSWORD")
        CONTACT_NO_TXT.Text = es.Tables("TABLE_LOGIN").Rows(SEARCH_INFO_CMB.SelectedIndex).Item("CONTACT_NUMBER")
        ADDRESS_TXT.Text = es.Tables("TABLE_LOGIN").Rows(SEARCH_INFO_CMB.SelectedIndex).Item("ADDRESS_")
        DATE_DTP.Text = es.Tables("TABLE_LOGIN").Rows(SEARCH_INFO_CMB.SelectedIndex).Item("DATE")
        REGISTRATION_NO_TXT.Text = es.Tables("TABLE_LOGIN").Rows(SEARCH_INFO_CMB.SelectedIndex).Item("REGISTRATION_NUMBER")
        SEARCH_INFO_CMB.Text = es.Tables("TABLE_LOGIN").Rows(SEARCH_INFO_CMB.SelectedIndex).Item("REGISTRATION_NUMBER")
        g()
    End Sub

    Private Sub REFRESH_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REFRESH_BTN.Click
        cl()
        g()
    End Sub
End Class