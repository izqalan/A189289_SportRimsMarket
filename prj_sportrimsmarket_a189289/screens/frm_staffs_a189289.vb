Public Class frm_staffs_a189289
    Private Sub frm_staffs_a189289_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lst_staffs.Columns.Add(0).Text = "Staff ID"
        lst_staffs.Columns.Add(1).Text = "Staff Name"
        lst_staffs.Columns.Add(2).Text = "Staff Role"

        LoadList()

    End Sub

    Private Sub MainToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MainToolStripMenuItem.Click
        frm_mainmenu_a189289.Show()
        Me.Hide()
    End Sub

    Private Sub ProductsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductsToolStripMenuItem.Click
        frm_products_a189289.Show()
        Me.Hide()
    End Sub

    Private Sub OrdersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdersToolStripMenuItem.Click
        frm_orders_a189289.Show()
        Me.Hide()
    End Sub

    Private Sub StaffsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StaffsToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub CustomersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomersToolStripMenuItem.Click
        frm_customers_a189289.Show()
        Me.Hide()
    End Sub

    Private Sub LoadList()
        Dim dtable As DataTable
        dtable = run_sql_query("SELECT * FROM TBL_STAFFS_A189289")

        lst_staffs.Items.Clear()
        lst_staffs.View = View.Details

        For Each row As DataRow In dtable.Rows
            lst_staffs.Items.Add(New ListViewItem(Array.ConvertAll(row.ItemArray, Function(o) o.ToString)))
        Next

    End Sub

    Private Sub lst_staffs_MouseClick(sender As Object, e As EventArgs) Handles lst_staffs.MouseClick
        search(lst_staffs.SelectedItems.Item(0).Text)
    End Sub

    Private Sub search(sid As String)
        Dim searchItem = run_sql_query("SELECT * FROM TBL_STAFFS_A189289 WHERE FLD_STAFF_ID like '%" & sid & "%'")
        txt_id.Text = searchItem.Rows(0).Item("FLD_STAFF_ID")
        txt_name.Text = searchItem.Rows(0).Item("FLD_STAFF_NAME")
        txt_role.Text = searchItem.Rows(0).Item("FLD_STAFF_ROLE")
        txt_id.Enabled = False
    End Sub

    Private Sub resetField()
        txt_id.Text = ""
        txt_name.Text = ""
        txt_role.Text = ""
        txt_id.Enabled = True
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        resetField()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        run_sql_command("UPDATE TBL_STAFFS_A189289 SET
                            FLD_STAFF_NAME='" & txt_name.Text & "',
                            FLD_STAFF_ROLE='" & txt_role.Text & "'
                            WHERE FLD_STAFF_ID='" & txt_id.Text & "'")
        resetField()
        LoadList()
    End Sub

    Private Sub btn_create_Click(sender As Object, e As EventArgs) Handles btn_create.Click
        run_sql_command("INSERT INTO TBL_STAFFS_A189289 
                (FLD_STAFF_ID, 
                FLD_STAFF_NAME, 
                FLD_STAFF_ROLE) VALUES 
            ('" & txt_id.Text & "',
            '" & txt_name.Text & "',
            '" & txt_role.Text & "')")
        resetField()
        LoadList()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        run_sql_command("DELETE FROM TBL_STAFFS_A189289 WHERE FLD_STAFF_ID='" & txt_id.Text & "'")
        resetField()
        LoadList()
    End Sub
End Class