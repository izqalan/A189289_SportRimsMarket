Public Class frm_orders_a189289
    Public orderId As String
    Public orderCreatedAt As String
    Public custName As String
    Private Sub frm_orders_a189289_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadList()
    End Sub

    Private Sub LoadList()
        Dim dtable As DataTable
        dtable = run_sql_query("SELECT 
        TBL_ORDERS_A189289.FLD_ORDER_ID,
        TBL_ORDERS_A189289.FLD_CREATED_AT, 
        TBL_CUSTOMERS_A189289.FLD_CUSTOMER_NAME,
        TBL_ORDERS_A189289.FLD_CUSTOMER_ID
        FROM TBL_ORDERS_A189289 
        INNER JOIN TBL_CUSTOMERS_A189289
        ON TBL_ORDERS_A189289.FLD_CUSTOMER_ID=TBL_CUSTOMERS_A189289.FLD_CUSTOMER_ID")

        lst_orders.Items.Clear()
        lst_orders.View = View.Details

        For Each row As DataRow In dtable.Rows
            lst_orders.Items.Add(New ListViewItem(Array.ConvertAll(row.ItemArray, Function(o) o.ToString)))
        Next

    End Sub

    Private Sub lst_orders_MouseClick(sender As Object, e As EventArgs) Handles lst_orders.MouseClick
        orderId = lst_orders.SelectedItems.Item(0).Text
        orderCreatedAt = lst_orders.SelectedItems.Item(0).SubItems.Item(1).Text
        custName = lst_orders.SelectedItems.Item(0).SubItems.Item(2).Text
        frm_order_summary_a189289.Show()
    End Sub

    Private Sub MainToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MainToolStripMenuItem.Click
        frm_mainmenu_a189289.Show()
        Me.Close()
    End Sub

    Private Sub ProductsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductsToolStripMenuItem.Click
        frm_products_a189289.Show()
        Me.Close()
    End Sub

    Private Sub OrdersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdersToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub StaffsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StaffsToolStripMenuItem.Click
        frm_staffs_a189289.Show()
        Me.Close()
    End Sub

    Private Sub CustomersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomersToolStripMenuItem.Click
        frm_customers_a189289.Show()
        Me.Close()
    End Sub
End Class