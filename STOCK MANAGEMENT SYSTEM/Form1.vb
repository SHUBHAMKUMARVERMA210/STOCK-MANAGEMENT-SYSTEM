Imports System.Data.SqlClient
Public Class LOGIN_FRM
    Dim cn As New SqlConnection("Data Source=DESKTOP-UBSL876\SQLEXPRESS;Integrated Security=True")
    Dim cmd As New SqlCommand("SELECT * FROM TABLE_LOGIN WHERE  USERNAME=@username and UPASSWORD=@password", cn)
    Dim cm As New SqlCommand("SELECT * FROM TABLE_LOGIN WHERE USERNAME=@username", cn)
    Dim ad As New SqlDataAdapter(cmd)
    Dim ad1 As New SqlDataAdapter(cm)
    Private Sub LG_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LG_BTN.Click
        STOCK_ENTRY_FORM.cl()
        PURCHASE_DETAILS_FORM.cl()
        BILL_PRINT_FORM.cl()

        Dim cmd5 As New SqlCommand("SELECT * FROM TABLE_LOGIN WHERE LOGGIN_TYPE=@login_type and USERNAME=@username and UPASSWORD=@password", cn)
        cmd5.Parameters.Add("@login_type", SqlDbType.VarChar).Value = LG_TYP_CMB.Text
        cmd5.Parameters.Add("@username", SqlDbType.VarChar).Value = US_NM_TXT.Text
        cmd5.Parameters.Add("@password", SqlDbType.VarChar).Value = PS_TXT.Text
        Dim ad5 As New SqlDataAdapter(cmd5)
        Dim table4 As New DataTable()
        ad5.Fill(table4)

        'ADMIN VALIDATION CODE'

        If US_NM_TXT.Text = "" And PS_TXT.Text = "" And LG_TYP_CMB.Text = "ADMIN" Then
            MsgBox("ADMIN IS REQUESTED PLEASE ENTER YOUR ID AND PASSWORD")
        ElseIf US_NM_TXT.Text = "" And PS_TXT.Text <> "" And LG_TYP_CMB.Text = "ADMIN" Then
            MsgBox("ADMIN IS REQUESTED PLEASE ENTER YOUR ID")
        ElseIf US_NM_TXT.Text <> "" And PS_TXT.Text = "" And LG_TYP_CMB.Text = "ADMIN" Then
            MsgBox("ADMIN IS REQUESTED PLEASE ENTER YOUR PASSWORD")

        Else
            Dim cmd1 As New SqlCommand("SELECT * FROM TABLE_LOGIN WHERE LOGGIN_TYPE=@login_type and USERNAME=@username", cn)
            cmd1.Parameters.Add("@login_type", SqlDbType.VarChar).Value = LG_TYP_CMB.Text
            cmd1.Parameters.Add("@username", SqlDbType.VarChar).Value = US_NM_TXT.Text
            Dim ad1 As New SqlDataAdapter(cmd1)
            Dim table As New DataTable()
            ad1.Fill(table)
            If table.Rows.Count() <= 0 And LG_TYP_CMB.Text = "ADMIN" Then
                MsgBox("INVALID ADMIN ID")
            Else
                Dim cmd2 As New SqlCommand("SELECT * FROM TABLE_LOGIN WHERE LOGGIN_TYPE=@login_type and UPASSWORD=@password", cn)
                cmd2.Parameters.Add("@login_type", SqlDbType.VarChar).Value = LG_TYP_CMB.Text
                cmd2.Parameters.Add("@password", SqlDbType.VarChar).Value = PS_TXT.Text
                Dim ad2 As New SqlDataAdapter(cmd2)
                Dim table1 As New DataTable()
                ad2.Fill(table1)
                If table1.Rows.Count() <= 0 And LG_TYP_CMB.Text = "ADMIN" Then
                    MsgBox("INVALID ADMIN PASSWORD")
                ElseIf LG_TYP_CMB.Text = "ADMIN" Then
                    MsgBox("ADMIN LOGIN SUCCESSFULL")
                    Me.Hide()
                    MAIN_PAGE.Show()
                End If
            End If
        End If

        'USER VALIDATION CODE'

        If US_NM_TXT.Text = "" And PS_TXT.Text = "" And LG_TYP_CMB.Text = "USER" Then
            MsgBox("USER IS REQUESTED PLEASE ENTER YOUR ID AND PASSWORD")
        ElseIf US_NM_TXT.Text = "" And PS_TXT.Text <> "" And LG_TYP_CMB.Text = "USER" Then
            MsgBox("USER IS REQUESTED PLEASE ENTER YOUR ID")
        ElseIf US_NM_TXT.Text <> "" And PS_TXT.Text = "" And LG_TYP_CMB.Text = "USER" Then
            MsgBox("USER IS REQUESTED PLEASE ENTER YOUR PASSWORD")

        Else
            Dim cmd3 As New SqlCommand("SELECT * FROM TABLE_LOGIN WHERE LOGGIN_TYPE=@login_type and USERNAME=@username", cn)
            cmd3.Parameters.Add("@login_type", SqlDbType.VarChar).Value = LG_TYP_CMB.Text
            cmd3.Parameters.Add("@username", SqlDbType.VarChar).Value = US_NM_TXT.Text
            Dim ad3 As New SqlDataAdapter(cmd3)
            Dim table2 As New DataTable()
            ad3.Fill(table2)
            If table2.Rows.Count() <= 0 And LG_TYP_CMB.Text = "USER" Then
                MsgBox("INVALID USER ID")
            Else
                Dim cmd4 As New SqlCommand("SELECT * FROM TABLE_LOGIN WHERE LOGGIN_TYPE=@login_type and UPASSWORD=@password", cn)
                cmd4.Parameters.Add("@login_type", SqlDbType.VarChar).Value = LG_TYP_CMB.Text
                cmd4.Parameters.Add("@password", SqlDbType.VarChar).Value = PS_TXT.Text
                Dim ad4 As New SqlDataAdapter(cmd4)
                Dim table3 As New DataTable()
                ad4.Fill(table3)
                If table3.Rows.Count() <= 0 And LG_TYP_CMB.Text = "USER" Then
                    MsgBox("INVALID USER PASSWORD")
                ElseIf LG_TYP_CMB.Text = "USER" Then
                    MsgBox("USER LOGIN SUCCESSFULL")
                    Me.Hide()
                    MAIN_PAGE.Show()
                End If
            End If
        End If
    End Sub
    Private Sub EX_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EX_BTN.Click
        Me.Close()
        MAIN_PAGE.Close()
        MAIN_PAGE.Close()
        BILL_VIEW_FORM.Close()
        PURCHASE_DETAILS_FORM.Close()
        BILL_PRINT_FORM.Close()
        BILL_DATA_FORM.Close()
        INTERNAL_BILL_VIEW_FORM.Close()
    End Sub
    Private Sub LOGIN_FRM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn.Open()
        cmp()
    End Sub
    Sub cmp()
        cmd = New SqlCommand("SELECT * FROM TABLE_LOGIN", cn)
        ad = New SqlDataAdapter(cmd)
        Dim ds As New DataSet()
        ad.Fill(ds, "TABLE_LOGIN")
        LG_TYP_CMB.DataSource = ds.Tables("TABLE_LOGIN")
        LG_TYP_CMB.DisplayMember = "TABLE_LOGIN"
        LG_TYP_CMB.ValueMember = "LOGGIN_TYPE"
    End Sub
    Sub cl()
        US_NM_TXT.Clear()
        PS_TXT.Clear()
    End Sub
    Private Sub LG_TYP_CMB_ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LG_TYP_CMB.SelectedIndexChanged
        cl()
        cmd = New SqlCommand("SELECT * FROM TABLE_LOGIN ", cn)
        ad = New SqlDataAdapter(cmd)
        Dim es As New DataSet()
        ad.Fill(es, "TABLE_LOGIN")
        LG_TYP_CMB.Text = es.Tables("TABLE_LOGIN").Rows(LG_TYP_CMB.SelectedIndex).Item("LOGGIN_TYPE")

    End Sub
End Class
