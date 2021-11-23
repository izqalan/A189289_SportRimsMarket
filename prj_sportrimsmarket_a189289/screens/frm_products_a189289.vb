Public Class frm_products_a189289
    Private Sub frm_products_a189289_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        grd_products.DataSource = run_sql_query("SELECT * FROM TBL_PRODUCTS_A189289")

        grd_products.Columns(0).HeaderText = "Product ID"
        grd_products.Columns(1).HeaderText = "Items"
        grd_products.Columns(2).HeaderText = "Price (RM)"
        grd_products.Columns(3).HeaderText = "Rating"
        grd_products.Columns(4).HeaderText = "Quantity"
        grd_products.Columns(5).HeaderText = "Compatbility"
        grd_products.Columns(6).HeaderText = "Size"

    End Sub

    Private Sub search(pid As String)
        Dim searchItem = run_sql_query("SELECT * FROM TBL_PRODUCTS_A189289 WHERE FLD_PRODUCT_ID like '%" & pid & "%'")
        rich_productName.Text = searchItem.Rows(0).Item("FLD_PRODUCT_NAME")
        txt_price.Text = searchItem.Rows(0).Item("FLD_PRODUCT_PRICE")

        Try
            pic_product.BackgroundImage = Image.FromFile("pictures/" & searchItem.Rows(0).Item("FLD_PRODUCT_ID") & ".jpg")
        Catch ex As Exception
            pic_product.BackgroundImage = Image.FromFile("pictures/nophoto.png")
        End Try

    End Sub

    Private Sub txt_search_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_search.KeyDown
        If e.KeyCode = Keys.Enter Then
            search(txt_search.Text)
        End If
    End Sub

    Private Sub grd_products_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_products.CellContentClick
        search(grd_products.SelectedCells.Item(0).Value)
    End Sub

    Private Sub MainToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MainToolStripMenuItem.Click
        frm_mainmenu_a189289.Show()
        Me.Hide()
    End Sub

    Private Sub ProductsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductsToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub OrdersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdersToolStripMenuItem.Click
        frm_orders_a189289.Show()
        Me.Hide()
    End Sub

    Private Sub StaffsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StaffsToolStripMenuItem.Click
        frm_staffs_a189289.Show()
        Me.Hide()
    End Sub

    Private Sub CustomersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomersToolStripMenuItem.Click
        frm_customers_a189289.Show()
        Me.Hide()
    End Sub
End Class