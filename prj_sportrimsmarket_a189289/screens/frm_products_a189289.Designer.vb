<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_products_a189289
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.grd_products = New System.Windows.Forms.DataGridView()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.lbl_itemName = New System.Windows.Forms.Label()
        Me.lbl_product = New System.Windows.Forms.Label()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.lbl_search = New System.Windows.Forms.Label()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.rich_productName = New System.Windows.Forms.RichTextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MainToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrdersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StaffsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_compatibility = New System.Windows.Forms.Label()
        Me.txt_compatibility = New System.Windows.Forms.TextBox()
        Me.lbl_quantity = New System.Windows.Forms.Label()
        Me.txt_quantity = New System.Windows.Forms.TextBox()
        Me.lbl_rating = New System.Windows.Forms.Label()
        Me.txt_rating = New System.Windows.Forms.TextBox()
        Me.txt_size = New System.Windows.Forms.TextBox()
        Me.btn_pos = New System.Windows.Forms.Button()
        Me.btn_neg = New System.Windows.Forms.Button()
        Me.txt_amount = New System.Windows.Forms.TextBox()
        Me.btn_cart = New System.Windows.Forms.Button()
        Me.lbl_cart = New System.Windows.Forms.Label()
        Me.btn_order = New System.Windows.Forms.Button()
        Me.cmb_customer = New System.Windows.Forms.ComboBox()
        Me.cmb_staff = New System.Windows.Forms.ComboBox()
        Me.lbl_staff = New System.Windows.Forms.Label()
        Me.lbl_customer = New System.Windows.Forms.Label()
        Me.lst_cart = New System.Windows.Forms.ListView()
        Me.ProductID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ProductName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Quantity = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txt_productId = New System.Windows.Forms.TextBox()
        Me.txt_orderId = New System.Windows.Forms.TextBox()
        Me.txt_poId = New System.Windows.Forms.TextBox()
        CType(Me.grd_products, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grd_products
        '
        Me.grd_products.AllowUserToAddRows = False
        Me.grd_products.AllowUserToDeleteRows = False
        Me.grd_products.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grd_products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.grd_products.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.grd_products.Location = New System.Drawing.Point(12, 241)
        Me.grd_products.MultiSelect = False
        Me.grd_products.Name = "grd_products"
        Me.grd_products.ReadOnly = True
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grd_products.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.grd_products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grd_products.Size = New System.Drawing.Size(1280, 339)
        Me.grd_products.TabIndex = 1
        '
        'pic_product
        '
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_product.Location = New System.Drawing.Point(12, 60)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(182, 175)
        Me.pic_product.TabIndex = 2
        Me.pic_product.TabStop = False
        '
        'lbl_itemName
        '
        Me.lbl_itemName.AutoSize = True
        Me.lbl_itemName.Location = New System.Drawing.Point(215, 73)
        Me.lbl_itemName.Name = "lbl_itemName"
        Me.lbl_itemName.Size = New System.Drawing.Size(0, 13)
        Me.lbl_itemName.TabIndex = 3
        '
        'lbl_product
        '
        Me.lbl_product.AutoSize = True
        Me.lbl_product.Location = New System.Drawing.Point(210, 73)
        Me.lbl_product.Name = "lbl_product"
        Me.lbl_product.Size = New System.Drawing.Size(43, 13)
        Me.lbl_product.TabIndex = 4
        Me.lbl_product.Text = "product"
        '
        'lbl_price
        '
        Me.lbl_price.AutoSize = True
        Me.lbl_price.Location = New System.Drawing.Point(210, 136)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(31, 13)
        Me.lbl_price.TabIndex = 5
        Me.lbl_price.Text = "Price"
        '
        'txt_search
        '
        Me.txt_search.Location = New System.Drawing.Point(94, 29)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(100, 20)
        Me.txt_search.TabIndex = 6
        '
        'lbl_search
        '
        Me.lbl_search.AutoSize = True
        Me.lbl_search.Location = New System.Drawing.Point(22, 32)
        Me.lbl_search.Name = "lbl_search"
        Me.lbl_search.Size = New System.Drawing.Size(66, 13)
        Me.lbl_search.TabIndex = 7
        Me.lbl_search.Text = "Search by id"
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(258, 133)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(83, 20)
        Me.txt_price.TabIndex = 8
        '
        'rich_productName
        '
        Me.rich_productName.Location = New System.Drawing.Point(258, 70)
        Me.rich_productName.Name = "rich_productName"
        Me.rich_productName.Size = New System.Drawing.Size(276, 57)
        Me.rich_productName.TabIndex = 9
        Me.rich_productName.Text = ""
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainToolStripMenuItem, Me.ProductsToolStripMenuItem, Me.OrdersToolStripMenuItem, Me.StaffsToolStripMenuItem, Me.CustomersToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1304, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MainToolStripMenuItem
        '
        Me.MainToolStripMenuItem.Name = "MainToolStripMenuItem"
        Me.MainToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.MainToolStripMenuItem.Text = "Main"
        '
        'ProductsToolStripMenuItem
        '
        Me.ProductsToolStripMenuItem.Name = "ProductsToolStripMenuItem"
        Me.ProductsToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.ProductsToolStripMenuItem.Text = "Products"
        '
        'OrdersToolStripMenuItem
        '
        Me.OrdersToolStripMenuItem.Name = "OrdersToolStripMenuItem"
        Me.OrdersToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.OrdersToolStripMenuItem.Text = "Orders"
        '
        'StaffsToolStripMenuItem
        '
        Me.StaffsToolStripMenuItem.Name = "StaffsToolStripMenuItem"
        Me.StaffsToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.StaffsToolStripMenuItem.Text = "Staffs"
        '
        'CustomersToolStripMenuItem
        '
        Me.CustomersToolStripMenuItem.Name = "CustomersToolStripMenuItem"
        Me.CustomersToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.CustomersToolStripMenuItem.Text = "Customers"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(390, 188)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Size"
        '
        'lbl_compatibility
        '
        Me.lbl_compatibility.AutoSize = True
        Me.lbl_compatibility.Location = New System.Drawing.Point(352, 162)
        Me.lbl_compatibility.Name = "lbl_compatibility"
        Me.lbl_compatibility.Size = New System.Drawing.Size(65, 13)
        Me.lbl_compatibility.TabIndex = 24
        Me.lbl_compatibility.Text = "Compatibility"
        '
        'txt_compatibility
        '
        Me.txt_compatibility.Location = New System.Drawing.Point(423, 159)
        Me.txt_compatibility.Name = "txt_compatibility"
        Me.txt_compatibility.Size = New System.Drawing.Size(111, 20)
        Me.txt_compatibility.TabIndex = 23
        '
        'lbl_quantity
        '
        Me.lbl_quantity.AutoSize = True
        Me.lbl_quantity.Location = New System.Drawing.Point(206, 188)
        Me.lbl_quantity.Name = "lbl_quantity"
        Me.lbl_quantity.Size = New System.Drawing.Size(46, 13)
        Me.lbl_quantity.TabIndex = 22
        Me.lbl_quantity.Text = "Quantity"
        '
        'txt_quantity
        '
        Me.txt_quantity.Location = New System.Drawing.Point(258, 185)
        Me.txt_quantity.Name = "txt_quantity"
        Me.txt_quantity.Size = New System.Drawing.Size(83, 20)
        Me.txt_quantity.TabIndex = 21
        '
        'lbl_rating
        '
        Me.lbl_rating.AutoSize = True
        Me.lbl_rating.Location = New System.Drawing.Point(214, 162)
        Me.lbl_rating.Name = "lbl_rating"
        Me.lbl_rating.Size = New System.Drawing.Size(38, 13)
        Me.lbl_rating.TabIndex = 20
        Me.lbl_rating.Text = "Rating"
        '
        'txt_rating
        '
        Me.txt_rating.Location = New System.Drawing.Point(258, 159)
        Me.txt_rating.Name = "txt_rating"
        Me.txt_rating.Size = New System.Drawing.Size(83, 20)
        Me.txt_rating.TabIndex = 19
        '
        'txt_size
        '
        Me.txt_size.Location = New System.Drawing.Point(423, 188)
        Me.txt_size.Name = "txt_size"
        Me.txt_size.Size = New System.Drawing.Size(111, 20)
        Me.txt_size.TabIndex = 26
        '
        'btn_pos
        '
        Me.btn_pos.Location = New System.Drawing.Point(658, 155)
        Me.btn_pos.Name = "btn_pos"
        Me.btn_pos.Size = New System.Drawing.Size(33, 24)
        Me.btn_pos.TabIndex = 27
        Me.btn_pos.Text = "+1"
        Me.btn_pos.UseVisualStyleBackColor = True
        '
        'btn_neg
        '
        Me.btn_neg.Location = New System.Drawing.Point(547, 156)
        Me.btn_neg.Name = "btn_neg"
        Me.btn_neg.Size = New System.Drawing.Size(33, 24)
        Me.btn_neg.TabIndex = 28
        Me.btn_neg.Text = "-1"
        Me.btn_neg.UseVisualStyleBackColor = True
        '
        'txt_amount
        '
        Me.txt_amount.Location = New System.Drawing.Point(586, 160)
        Me.txt_amount.Name = "txt_amount"
        Me.txt_amount.Size = New System.Drawing.Size(66, 20)
        Me.txt_amount.TabIndex = 29
        Me.txt_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_cart
        '
        Me.btn_cart.Location = New System.Drawing.Point(586, 189)
        Me.btn_cart.Name = "btn_cart"
        Me.btn_cart.Size = New System.Drawing.Size(66, 34)
        Me.btn_cart.TabIndex = 30
        Me.btn_cart.Text = "Add to Cart"
        Me.btn_cart.UseVisualStyleBackColor = True
        '
        'lbl_cart
        '
        Me.lbl_cart.AutoSize = True
        Me.lbl_cart.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cart.Location = New System.Drawing.Point(692, 47)
        Me.lbl_cart.Name = "lbl_cart"
        Me.lbl_cart.Size = New System.Drawing.Size(109, 25)
        Me.lbl_cart.TabIndex = 32
        Me.lbl_cart.Text = "Your cart"
        '
        'btn_order
        '
        Me.btn_order.Location = New System.Drawing.Point(961, 189)
        Me.btn_order.Name = "btn_order"
        Me.btn_order.Size = New System.Drawing.Size(83, 23)
        Me.btn_order.TabIndex = 33
        Me.btn_order.Text = "Order now"
        Me.btn_order.UseVisualStyleBackColor = True
        '
        'cmb_customer
        '
        Me.cmb_customer.FormattingEnabled = True
        Me.cmb_customer.Location = New System.Drawing.Point(1066, 88)
        Me.cmb_customer.Name = "cmb_customer"
        Me.cmb_customer.Size = New System.Drawing.Size(184, 21)
        Me.cmb_customer.TabIndex = 34
        '
        'cmb_staff
        '
        Me.cmb_staff.FormattingEnabled = True
        Me.cmb_staff.Location = New System.Drawing.Point(1066, 132)
        Me.cmb_staff.Name = "cmb_staff"
        Me.cmb_staff.Size = New System.Drawing.Size(184, 21)
        Me.cmb_staff.TabIndex = 35
        '
        'lbl_staff
        '
        Me.lbl_staff.AutoSize = True
        Me.lbl_staff.Location = New System.Drawing.Point(1063, 116)
        Me.lbl_staff.Name = "lbl_staff"
        Me.lbl_staff.Size = New System.Drawing.Size(29, 13)
        Me.lbl_staff.TabIndex = 36
        Me.lbl_staff.Text = "Staff"
        '
        'lbl_customer
        '
        Me.lbl_customer.AutoSize = True
        Me.lbl_customer.Location = New System.Drawing.Point(1063, 73)
        Me.lbl_customer.Name = "lbl_customer"
        Me.lbl_customer.Size = New System.Drawing.Size(51, 13)
        Me.lbl_customer.TabIndex = 37
        Me.lbl_customer.Text = "Customer"
        '
        'lst_cart
        '
        Me.lst_cart.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ProductID, Me.ProductName, Me.Quantity})
        Me.lst_cart.FullRowSelect = True
        Me.lst_cart.HideSelection = False
        Me.lst_cart.Location = New System.Drawing.Point(697, 78)
        Me.lst_cart.Name = "lst_cart"
        Me.lst_cart.Size = New System.Drawing.Size(347, 105)
        Me.lst_cart.TabIndex = 40
        Me.lst_cart.UseCompatibleStateImageBehavior = False
        Me.lst_cart.View = System.Windows.Forms.View.Details
        '
        'ProductID
        '
        Me.ProductID.Text = "Product ID"
        Me.ProductID.Width = 66
        '
        'ProductName
        '
        Me.ProductName.Text = "Product"
        Me.ProductName.Width = 220
        '
        'Quantity
        '
        Me.Quantity.Text = "Quantity"
        Me.Quantity.Width = 57
        '
        'txt_productId
        '
        Me.txt_productId.Location = New System.Drawing.Point(258, 44)
        Me.txt_productId.Name = "txt_productId"
        Me.txt_productId.Size = New System.Drawing.Size(83, 20)
        Me.txt_productId.TabIndex = 41
        '
        'txt_orderId
        '
        Me.txt_orderId.Location = New System.Drawing.Point(697, 191)
        Me.txt_orderId.Name = "txt_orderId"
        Me.txt_orderId.Size = New System.Drawing.Size(100, 20)
        Me.txt_orderId.TabIndex = 42
        Me.txt_orderId.Visible = False
        '
        'txt_poId
        '
        Me.txt_poId.Location = New System.Drawing.Point(803, 191)
        Me.txt_poId.Name = "txt_poId"
        Me.txt_poId.Size = New System.Drawing.Size(100, 20)
        Me.txt_poId.TabIndex = 43
        Me.txt_poId.Visible = False
        '
        'frm_products_a189289
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(1304, 592)
        Me.Controls.Add(Me.txt_poId)
        Me.Controls.Add(Me.txt_orderId)
        Me.Controls.Add(Me.txt_productId)
        Me.Controls.Add(Me.lst_cart)
        Me.Controls.Add(Me.lbl_customer)
        Me.Controls.Add(Me.lbl_staff)
        Me.Controls.Add(Me.cmb_staff)
        Me.Controls.Add(Me.cmb_customer)
        Me.Controls.Add(Me.btn_order)
        Me.Controls.Add(Me.lbl_cart)
        Me.Controls.Add(Me.btn_cart)
        Me.Controls.Add(Me.txt_amount)
        Me.Controls.Add(Me.btn_neg)
        Me.Controls.Add(Me.btn_pos)
        Me.Controls.Add(Me.txt_size)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_compatibility)
        Me.Controls.Add(Me.txt_compatibility)
        Me.Controls.Add(Me.lbl_quantity)
        Me.Controls.Add(Me.txt_quantity)
        Me.Controls.Add(Me.lbl_rating)
        Me.Controls.Add(Me.txt_rating)
        Me.Controls.Add(Me.rich_productName)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.lbl_search)
        Me.Controls.Add(Me.txt_search)
        Me.Controls.Add(Me.lbl_price)
        Me.Controls.Add(Me.lbl_product)
        Me.Controls.Add(Me.lbl_itemName)
        Me.Controls.Add(Me.pic_product)
        Me.Controls.Add(Me.grd_products)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frm_products_a189289"
        Me.Text = "frm_products_a189289"
        CType(Me.grd_products, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grd_products As DataGridView
    Friend WithEvents pic_product As PictureBox
    Friend WithEvents lbl_itemName As Label
    Friend WithEvents lbl_product As Label
    Friend WithEvents lbl_price As Label
    Friend WithEvents txt_search As TextBox
    Friend WithEvents lbl_search As Label
    Friend WithEvents txt_price As TextBox
    Friend WithEvents rich_productName As RichTextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MainToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrdersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StaffsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_compatibility As Label
    Friend WithEvents txt_compatibility As TextBox
    Friend WithEvents lbl_quantity As Label
    Friend WithEvents txt_quantity As TextBox
    Friend WithEvents lbl_rating As Label
    Friend WithEvents txt_rating As TextBox
    Friend WithEvents txt_size As TextBox
    Friend WithEvents btn_pos As Button
    Friend WithEvents btn_neg As Button
    Friend WithEvents txt_amount As TextBox
    Friend WithEvents btn_cart As Button
    Friend WithEvents lbl_cart As Label
    Friend WithEvents btn_order As Button
    Friend WithEvents cmb_customer As ComboBox
    Friend WithEvents cmb_staff As ComboBox
    Friend WithEvents lbl_staff As Label
    Friend WithEvents lbl_customer As Label
    Friend WithEvents lst_cart As ListView
    Friend WithEvents ProductID As ColumnHeader
    Friend WithEvents ProductName As ColumnHeader
    Friend WithEvents Quantity As ColumnHeader
    Friend WithEvents txt_productId As TextBox
    Friend WithEvents txt_orderId As TextBox
    Friend WithEvents txt_poId As TextBox
End Class
