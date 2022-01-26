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
        cmb_customer.ValueMember = "FLD_CUSTOMER_ID"
        cmb_customer.DisplayMember = "FLD_CUSTOMER_NAME"
        cmb_staff.DataSource = run_sql_query("SELECT * FROM TBL_STAFFS_A189289")
        cmb_staff.ValueMember = "FLD_STAFF_ID"
        cmb_staff.DisplayMember = "FLD_STAFF_NAME"


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

    Private Sub btn_order_Click(sender As Object, e As EventArgs) Handles btn_order.Click

        Dim mytransaction As OleDb.OleDbTransaction
        If myconnection2.State = False Then
            myconnection2.Open()
        End If


        If lst_cart.Items.Count = 0 Then
            MessageBox.Show("Cart cannot be empty")
            Return
        End If

        Try

            mytransaction = myconnection2.BeginTransaction

            Dim dateTime = Date.Now.ToString("dd/M/yyyy")
            ' Insert Orders table (only once)


            txt_orderId.Text = generate_Id("O", "TBL_ORDERS_A189289", "FLD_ORDER_ID")

            Dim orderQuery = $"INSERT INTO TBL_ORDERS_A189289 VALUES 
            ('" & txt_orderId.Text & "',
            '" & cmb_staff.SelectedValue.ToString & "',
            '" & dateTime & "',
            '" & cmb_customer.SelectedValue.ToString & "')"
            Dim mywriter As New OleDb.OleDbCommand(orderQuery, myconnection2, mytransaction)
            mywriter.ExecuteNonQuery()
            Dim productOrderId = generate_Id("X", "TBL_PRODUCTS_ORDERS_A189289", "FLD_PO_ID")

            Dim increment = 0
            For Each item As ListViewItem In lst_cart.Items
                Dim IdInt = productOrderId.Substring(1)
                IdInt += increment
                If IdInt < 10 Then
                    txt_poId.Text = String.Concat("X0", IdInt)
                Else
                    txt_poId.Text = String.Concat("X", IdInt)
                End If
                ' Insert products orders table (for each item)
                ' Reference order id 
                Dim productOrderQry As String = "INSERT INTO TBL_PRODUCTS_ORDERS_A189289 (FLD_PO_ID, FLD_ORDER_ID, FLD_PRODUCT_ID, FLD_QUANTITY ) VALUES 
                ('" & txt_poId.Text & "',
                '" & txt_orderId.Text & "',
                '" & item.SubItems(0).Text & "',
                " & item.SubItems(2).Text & ")"
                Dim mywriter2 As New OleDb.OleDbCommand(productOrderQry, myconnection2, mytransaction)
                mywriter2.ExecuteNonQuery()

                increment += 1
            Next

            mytransaction.Commit()
            myconnection2.Close()

            MessageBox.Show("Order Success")

        Catch ex As Exception
            mytransaction.Rollback()
            myconnection2.Close()
            MessageBox.Show($"E: {ex.Message}")
        End Try

    End Sub

    Private Function generate_Id(prefix, table, field) As String

        Dim lastmatric As String = run_sql_query($"SELECT MAX({field}) AS LASTMATRIC FROM {table}").Rows(0).Item("LASTMATRIC")
        Dim num = lastmatric.Substring(1)
        num += 1
        If num < 10 Then
            prefix = String.Concat(prefix, 0)
        End If
        Dim newId = String.Concat(prefix, num)
        Return newId

    End Function

End Class