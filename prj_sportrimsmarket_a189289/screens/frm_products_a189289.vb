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

        cmb_customer.DataSource = run_sql_query("SELECT * FROM TBL_CUSTOMERS_A189289")
        cmb_customer.DisplayMember = "FLD_CUSTOMER_NAME"
        cmb_customer.ValueMember = "FLD_CUSTOMER_ID"
        cmb_staff.DataSource = run_sql_query("SELECT * FROM TBL_STAFFS_A189289")
        cmb_staff.DisplayMember = "FLD_STAFF_NAME"
        cmb_staff.ValueMember = "FLD_STAFF_ID"

        btn_cart.Enabled = False

    End Sub

    Private Sub search(pid As String)
        Try
            Dim searchItem = run_sql_query("SELECT * FROM TBL_PRODUCTS_A189289 WHERE FLD_PRODUCT_ID like '%" & pid & "%'")
            rich_productName.Text = searchItem.Rows(0).Item("FLD_PRODUCT_NAME")
            txt_productId.Text = searchItem.Rows(0).Item("FLD_PRODUCT_ID")
            txt_price.Text = searchItem.Rows(0).Item("FLD_PRODUCT_PRICE")
            txt_size.Text = searchItem.Rows(0).Item("FLD_PRODUCT_SIZE")
            txt_rating.Text = searchItem.Rows(0).Item("FLD_PRODUCT_RATING")
            txt_quantity.Text = searchItem.Rows(0).Item("FLD_PRODUCT_QUANTITY")
            txt_compatibility.Text = searchItem.Rows(0).Item("FLD_PRODUCT_COMPATIBILITY")
            pic_product.BackgroundImage = Image.FromFile("pictures/" & searchItem.Rows(0).Item("FLD_PRODUCT_ID") & ".jpg")
            btn_cart.Enabled = True
            txt_amount.Text = 1
            If searchItem.Rows(0).Item("FLD_PRODUCT_QUANTITY") < 1 Then
                btn_cart.Enabled = False
                btn_pos.Enabled = False
                btn_neg.Enabled = False
            End If
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

    Private Sub btn_pos_Click(sender As Object, e As EventArgs) Handles btn_pos.Click
        txt_amount.Text = txt_amount.Text + 1
    End Sub

    Private Sub btn_neg_Click(sender As Object, e As EventArgs) Handles btn_neg.Click
        If txt_amount.Text > 0 Then
            txt_amount.Text = txt_amount.Text - 1
        End If
    End Sub

    Private Sub btn_cart_Click(sender As Object, e As EventArgs) Handles btn_cart.Click

        For Each item As ListViewItem In lst_cart.Items
            If item.SubItems(0).Text = txt_productId.Text Then
                item.SubItems(2).Text = Convert.ToInt32(item.SubItems(2).Text) + Convert.ToInt32(txt_amount.Text)
                Return
            End If
        Next

        Dim lvitem As ListViewItem
        lst_cart.BeginUpdate()

        lvitem = Me.lst_cart.Items.Add(txt_productId.Text)
        lvitem.SubItems.Add(rich_productName.Text)
        lvitem.SubItems.Add(txt_amount.Text)

        lst_cart.Update()
        lst_cart.EndUpdate()

    End Sub

End Class