Public Class frm_customers_crud_a189289
    Private Sub frm_customers_crud_a189289_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lst_customers.Columns.Add(0).Text = "Customer ID"
        lst_customers.Columns.Add(1).Text = "Customer Name"

        LoadList()

        btn_update.Visible = False
        btn_delete.Visible = False
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
        dtable = run_sql_query("SELECT * FROM TBL_CUSTOMERS_A189289")

        lst_customers.Items.Clear()
        lst_customers.View = View.Details

        For Each row As DataRow In dtable.Rows
            lst_customers.Items.Add(New ListViewItem(Array.ConvertAll(row.ItemArray, Function(o) o.ToString)))
        Next

    End Sub

    Private Sub lst_customers_MouseClick(sender As Object, e As EventArgs) Handles lst_customers.MouseClick
        search(lst_customers.SelectedItems.Item(0).Text)
        btn_create.Visible = False
        btn_update.Visible = True
        btn_delete.Visible = True
    End Sub

    Private Sub search(id As String)
        Dim searchItem = run_sql_query("SELECT * FROM TBL_CUSTOMERS_A189289 WHERE FLD_CUSTOMER_ID like '%" & id & "%'")
        txt_id.Text = searchItem.Rows(0).Item("FLD_CUSTOMER_ID")
        txt_name.Text = searchItem.Rows(0).Item("FLD_CUSTOMER_NAME")
        txt_id.Enabled = False
    End Sub

    Private Sub resetField()
        txt_id.Text = ""
        txt_name.Text = ""
        txt_id.Enabled = True
        btn_create.Visible = True
        btn_update.Visible = False
        btn_delete.Visible = False
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        resetField()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        run_sql_command("UPDATE TBL_CUSTOMERS_A189289 SET
                            FLD_CUSTOMER_NAME='" & txt_name.Text & "'
                            WHERE FLD_CUSTOMER_ID='" & txt_id.Text & "'")
        resetField()
        LoadList()
    End Sub

    Private Sub btn_create_Click(sender As Object, e As EventArgs) Handles btn_create.Click
        run_sql_command("INSERT INTO TBL_CUSTOMERS_A189289 
                (FLD_CUSTOMER_ID, 
                FLD_CUSTOMER_NAME) VALUES 
            ('" & txt_id.Text & "',
            '" & txt_name.Text & "')")
        resetField()
        LoadList()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        run_sql_command("DELETE FROM TBL_CUSTOMERS_A189289 WHERE FLD_CUSTOMER_ID='" & txt_id.Text & "'")
        resetField()
        LoadList()
    End Sub
End Class