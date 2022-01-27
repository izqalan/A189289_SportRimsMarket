Public Class frm_order_summary_a189289
    Private Sub frm_order_summary_a189289_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_orderId.Text = $"Order No. #{frm_orders_a189289.orderId}"
        lbl_customerName.Text = $"Customer: {frm_orders_a189289.custName}"


        Dim dt As DateTime = Convert.ToDateTime(frm_orders_a189289.orderCreatedAt)
        lbl_createdAt.Text = $"Date Ordered: {dt.ToString("d MMM yyyy")}"

        Dim totalAmount = 0

        Dim orderTable As DataTable = run_sql_query($"SELECT FLD_STAFF_NAME FROM TBL_STAFFS_A189289
            INNER JOIN TBL_ORDERS_A189289
            ON TBL_STAFFS_A189289.FLD_STAFF_ID=TBL_ORDERS_A189289.FLD_STAFF_ID
            WHERE TBL_ORDERS_A189289.FLD_ORDER_ID = '{frm_orders_a189289.orderId}'")

        lbl_staffName.Text = orderTable.Rows.Item(0).Item("FLD_STAFF_NAME").ToString()

        Dim dtable As DataTable
        dtable = run_sql_query($"SELECT 
            TBL_PRODUCTS_A189289.FLD_PRODUCT_ID,
            TBL_PRODUCTS_A189289.FLD_PRODUCT_NAME,
            TBL_PRODUCTS_A189289.FLD_PRODUCT_PRICE,
            TBL_PRODUCTS_ORDERS_A189289.FLD_QUANTITY,
            (TBL_PRODUCTS_A189289.FLD_PRODUCT_PRICE * TBL_PRODUCTS_ORDERS_A189289.FLD_QUANTITY) As [amount]
            FROM TBL_PRODUCTS_ORDERS_A189289 INNER JOIN TBL_PRODUCTS_A189289
            ON TBL_PRODUCTS_A189289.FLD_PRODUCT_ID = TBL_PRODUCTS_ORDERS_A189289.FLD_PRODUCT_ID
            WHERE FLD_ORDER_ID = '{frm_orders_a189289.orderId}'")

        For Each row As DataRow In dtable.Rows
            lst_orders.Items.Add(New ListViewItem(Array.ConvertAll(row.ItemArray, Function(o) o.ToString)))
        Next

        For Each row As DataRow In dtable.Rows
            If Not row Is Nothing Then
                totalAmount += row.Item("amount")
            End If
        Next
        Dim taxAmount = totalAmount * 0.06
        val_totalAmount.Text = $"RM {totalAmount}"
        val_tax.Text = $"RM {taxAmount}"
        val_grandTotal.Text = $"RM {totalAmount + taxAmount}"

    End Sub

End Class