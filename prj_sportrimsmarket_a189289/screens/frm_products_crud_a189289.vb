Public Class frm_products_crud_a189289
    Private Sub frm_products_crud_a189289_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grd_products.DataSource = run_sql_query("SELECT * FROM TBL_PRODUCTS_A189289")
        txt_picture.Text = defaultpicture
        pic_product.BackgroundImage = Image.FromFile(defaultpicture)

        grd_products.Columns(0).HeaderText = "Product ID"
        grd_products.Columns(1).HeaderText = "Items"
        grd_products.Columns(2).HeaderText = "Price (RM)"
        grd_products.Columns(3).HeaderText = "Rating"
        grd_products.Columns(4).HeaderText = "Quantity"
        grd_products.Columns(5).HeaderText = "Compatbility"
        grd_products.Columns(6).HeaderText = "Size"

        txt_id.Enabled = True
        btn_delete.Visible = False
        btn_update.Visible = False

        cmb_size.DataSource = run_sql_query("SELECT DISTINCT FLD_PRODUCT_SIZE FROM TBL_PRODUCTS_A189289")
        cmb_size.DisplayMember = "FLD_PRODUCT_SIZE"

    End Sub

    Private Sub search(pid As String)
        Dim searchItem = run_sql_query("SELECT * FROM TBL_PRODUCTS_A189289 WHERE FLD_PRODUCT_ID like '%" & pid & "%'")
        rich_productName.Text = searchItem.Rows(0).Item("FLD_PRODUCT_NAME")
        txt_price.Text = searchItem.Rows(0).Item("FLD_PRODUCT_PRICE")
        txt_id.Text = searchItem.Rows(0).Item("FLD_PRODUCT_ID")
        txt_id.Enabled = False
        cmb_size.Text = searchItem.Rows(0).Item("FLD_PRODUCT_SIZE")
        txt_rating.Text = searchItem.Rows(0).Item("FLD_PRODUCT_RATING")
        txt_quantity.Text = searchItem.Rows(0).Item("FLD_PRODUCT_QUANTITY")
        txt_compatibility.Text = searchItem.Rows(0).Item("FLD_PRODUCT_COMPATIBILITY")

        Try
            pic_product.BackgroundImage = Image.FromFile("pictures/" & searchItem.Rows(0).Item("FLD_PRODUCT_ID") & ".jpg")
        Catch ex As Exception
            pic_product.BackgroundImage = Image.FromFile("pictures/nophoto.png")
        End Try

    End Sub

    Private Sub btn_selectPicture_Click(sender As Object, e As EventArgs) Handles btn_selectPicture.Click
        Dim mydesktop As String = My.Computer.FileSystem.SpecialDirectories.Desktop
        Try
            OpenFileDialog1.InitialDirectory = mydesktop
            OpenFileDialog1.FileName = ""
            OpenFileDialog1.Filter = "JPG files (*.jpg)|*.jpg"
            OpenFileDialog1.ShowDialog()
            pic_product.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
            txt_picture.Text = OpenFileDialog1.FileName
        Catch ex As Exception

        End Try
    End Sub

    Private Sub grd_products_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_products.CellContentClick
        search(grd_products.SelectedCells.Item(0).Value)
        btn_delete.Visible = True
        btn_update.Visible = True
        btn_create.Visible = False
    End Sub

    Private Sub resetField()
        txt_picture.Text = defaultpicture
        pic_product.BackgroundImage = Image.FromFile(defaultpicture)
        txt_id.Enabled = True
        txt_id.Text = ""
        rich_productName.Text = ""
        txt_price.Text = ""
        txt_compatibility.Text = ""
        txt_quantity.Text = ""
        txt_rating.Text = ""
        cmb_size.Text = ""
        btn_delete.Visible = False
        btn_update.Visible = False
        btn_create.Visible = True
    End Sub

    Private Sub refresh_grid()
        Dim searchItem = run_sql_query("SELECT * FROM TBL_PRODUCTS_A189289")
        grd_products.DataSource = searchItem
        rich_productName.Text = searchItem.Rows(0).Item("FLD_PRODUCT_NAME")
        txt_price.Text = searchItem.Rows(0).Item("FLD_PRODUCT_PRICE")
        txt_id.Text = searchItem.Rows(0).Item("FLD_PRODUCT_ID")
        txt_id.Enabled = False
        cmb_size.Text = searchItem.Rows(0).Item("FLD_PRODUCT_SIZE")
        txt_rating.Text = searchItem.Rows(0).Item("FLD_PRODUCT_RATING")
        txt_quantity.Text = searchItem.Rows(0).Item("FLD_PRODUCT_QUANTITY")
        txt_compatibility.Text = searchItem.Rows(0).Item("FLD_PRODUCT_COMPATIBILITY")
        Try
            pic_product.BackgroundImage = Image.FromFile("pictures/" & searchItem.Rows(0).Item("FLD_PRODUCT_ID") & ".jpg")
        Catch ex As Exception
            pic_product.BackgroundImage = Image.FromFile("pictures/nophoto.png")
        End Try
    End Sub

    Private Sub btn_create_Click(sender As Object, e As EventArgs) Handles btn_create.Click
        Dim mysql As String = "INSERT INTO TBL_PRODUCTS_A189289 
                (FLD_PRODUCT_ID, 
                FLD_PRODUCT_NAME, 
                FLD_PRODUCT_PRICE, 
                FLD_PRODUCT_QUANTITY, 
                FLD_PRODUCT_RATING, 
                FLD_PRODUCT_SIZE, 
                FLD_PRODUCT_COMPATIBILITY) VALUES 
            ('" & txt_id.Text & "',
            '" & rich_productName.Text & "',
            '" & txt_price.Text & "',
            '" & txt_quantity.Text & "',
            '" & txt_rating.Text & "',
            '" & cmb_size.Text & "',
            '" & txt_compatibility.Text & "')"

        My.Computer.FileSystem.CopyFile(txt_picture.Text, "pictures\" & txt_id.Text & ".jpg")

        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)
        Try
            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

            Beep()
            MsgBox("You have successfully created the product""" & txt_id.Text & """.")

            refresh_grid()
            resetField()

        Catch ex As Exception
            Beep()
            MsgBox("There is a mistake in the data you entered, as shown below" & vbCrLf & vbCrLf & ex.Message)
            mywriter.Connection.Close()
        End Try
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        run_sql_command("UPDATE TBL_PRODUCTS_A189289 SET
                            FLD_PRODUCT_NAME='" & rich_productName.Text & "',
                            FLD_PRODUCT_PRICE=" & txt_price.Text & ",
                            FLD_PRODUCT_QUANTITY=" & txt_quantity.Text & ",
                            FLD_PRODUCT_RATING=" & txt_rating.Text & ",
                            FLD_PRODUCT_SIZE='" & cmb_size.Text & "',
                            FLD_PRODUCT_COMPATIBILITY='" & txt_compatibility.Text & "'
                            WHERE FLD_PRODUCT_ID='" & txt_id.Text & "'")

        Beep()
        MsgBox("You have successfully updated the product """ & txt_id.Text & """.")

        refresh_grid()
        resetField()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        run_sql_command("DELETE FROM TBL_PRODUCTS_A189289 WHERE FLD_PRODUCT_ID='" & txt_id.Text & "'")
        Beep()
        MsgBox("The course """ & txt_id.Text & """ has been successfully deleted.")
        refresh_grid()
        resetField()
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        resetField()
    End Sub

End Class