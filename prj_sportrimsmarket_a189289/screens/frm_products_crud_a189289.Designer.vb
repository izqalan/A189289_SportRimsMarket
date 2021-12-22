<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_products_crud_a189289
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grd_products = New System.Windows.Forms.DataGridView()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.rich_productName = New System.Windows.Forms.RichTextBox()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.txt_picture = New System.Windows.Forms.TextBox()
        Me.btn_selectPicture = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btn_create = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.txt_rating = New System.Windows.Forms.TextBox()
        Me.lbl_rating = New System.Windows.Forms.Label()
        Me.lbl_quantity = New System.Windows.Forms.Label()
        Me.txt_quantity = New System.Windows.Forms.TextBox()
        Me.lbl_compatibility = New System.Windows.Forms.Label()
        Me.txt_compatibility = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_size = New System.Windows.Forms.ComboBox()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.lbl_price = New System.Windows.Forms.Label()
        CType(Me.grd_products, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grd_products
        '
        Me.grd_products.AllowUserToAddRows = False
        Me.grd_products.AllowUserToDeleteRows = False
        Me.grd_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_products.Location = New System.Drawing.Point(43, 295)
        Me.grd_products.MultiSelect = False
        Me.grd_products.Name = "grd_products"
        Me.grd_products.ReadOnly = True
        Me.grd_products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grd_products.Size = New System.Drawing.Size(672, 255)
        Me.grd_products.TabIndex = 0
        '
        'pic_product
        '
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_product.Location = New System.Drawing.Point(43, 27)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(157, 132)
        Me.pic_product.TabIndex = 1
        Me.pic_product.TabStop = False
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(271, 27)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(126, 20)
        Me.txt_id.TabIndex = 2
        '
        'rich_productName
        '
        Me.rich_productName.Location = New System.Drawing.Point(271, 63)
        Me.rich_productName.Name = "rich_productName"
        Me.rich_productName.Size = New System.Drawing.Size(261, 96)
        Me.rich_productName.TabIndex = 3
        Me.rich_productName.Text = ""
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(271, 165)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(126, 20)
        Me.txt_price.TabIndex = 4
        '
        'txt_picture
        '
        Me.txt_picture.Location = New System.Drawing.Point(43, 165)
        Me.txt_picture.Name = "txt_picture"
        Me.txt_picture.Size = New System.Drawing.Size(157, 20)
        Me.txt_picture.TabIndex = 5
        '
        'btn_selectPicture
        '
        Me.btn_selectPicture.Location = New System.Drawing.Point(43, 191)
        Me.btn_selectPicture.Name = "btn_selectPicture"
        Me.btn_selectPicture.Size = New System.Drawing.Size(157, 23)
        Me.btn_selectPicture.TabIndex = 6
        Me.btn_selectPicture.Text = "Select picture"
        Me.btn_selectPicture.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btn_create
        '
        Me.btn_create.Location = New System.Drawing.Point(640, 92)
        Me.btn_create.Name = "btn_create"
        Me.btn_create.Size = New System.Drawing.Size(75, 23)
        Me.btn_create.TabIndex = 7
        Me.btn_create.Text = "Create"
        Me.btn_create.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Location = New System.Drawing.Point(640, 121)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(75, 23)
        Me.btn_update.TabIndex = 8
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.Red
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_delete.Location = New System.Drawing.Point(640, 150)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(75, 23)
        Me.btn_delete.TabIndex = 9
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btn_clear
        '
        Me.btn_clear.Location = New System.Drawing.Point(640, 63)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(75, 23)
        Me.btn_clear.TabIndex = 10
        Me.btn_clear.Text = "Clear field"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'txt_rating
        '
        Me.txt_rating.Location = New System.Drawing.Point(271, 194)
        Me.txt_rating.Name = "txt_rating"
        Me.txt_rating.Size = New System.Drawing.Size(83, 20)
        Me.txt_rating.TabIndex = 11
        '
        'lbl_rating
        '
        Me.lbl_rating.AutoSize = True
        Me.lbl_rating.Location = New System.Drawing.Point(227, 197)
        Me.lbl_rating.Name = "lbl_rating"
        Me.lbl_rating.Size = New System.Drawing.Size(38, 13)
        Me.lbl_rating.TabIndex = 12
        Me.lbl_rating.Text = "Rating"
        '
        'lbl_quantity
        '
        Me.lbl_quantity.AutoSize = True
        Me.lbl_quantity.Location = New System.Drawing.Point(219, 223)
        Me.lbl_quantity.Name = "lbl_quantity"
        Me.lbl_quantity.Size = New System.Drawing.Size(46, 13)
        Me.lbl_quantity.TabIndex = 14
        Me.lbl_quantity.Text = "Quantity"
        '
        'txt_quantity
        '
        Me.txt_quantity.Location = New System.Drawing.Point(271, 220)
        Me.txt_quantity.Name = "txt_quantity"
        Me.txt_quantity.Size = New System.Drawing.Size(83, 20)
        Me.txt_quantity.TabIndex = 13
        '
        'lbl_compatibility
        '
        Me.lbl_compatibility.AutoSize = True
        Me.lbl_compatibility.Location = New System.Drawing.Point(365, 197)
        Me.lbl_compatibility.Name = "lbl_compatibility"
        Me.lbl_compatibility.Size = New System.Drawing.Size(65, 13)
        Me.lbl_compatibility.TabIndex = 16
        Me.lbl_compatibility.Text = "Compatibility"
        '
        'txt_compatibility
        '
        Me.txt_compatibility.Location = New System.Drawing.Point(436, 194)
        Me.txt_compatibility.Name = "txt_compatibility"
        Me.txt_compatibility.Size = New System.Drawing.Size(137, 20)
        Me.txt_compatibility.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(403, 223)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Size"
        '
        'cmb_size
        '
        Me.cmb_size.FormattingEnabled = True
        Me.cmb_size.Location = New System.Drawing.Point(436, 220)
        Me.cmb_size.Name = "cmb_size"
        Me.cmb_size.Size = New System.Drawing.Size(137, 21)
        Me.cmb_size.TabIndex = 18
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(207, 30)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(58, 13)
        Me.lbl_id.TabIndex = 19
        Me.lbl_id.Text = "Product ID"
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Location = New System.Drawing.Point(230, 63)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(35, 13)
        Me.lbl_name.TabIndex = 20
        Me.lbl_name.Text = "Name"
        '
        'lbl_price
        '
        Me.lbl_price.AutoSize = True
        Me.lbl_price.Location = New System.Drawing.Point(234, 168)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(31, 13)
        Me.lbl_price.TabIndex = 21
        Me.lbl_price.Text = "Price"
        '
        'frm_products_crud_a189289
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(800, 562)
        Me.Controls.Add(Me.lbl_price)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.cmb_size)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_compatibility)
        Me.Controls.Add(Me.txt_compatibility)
        Me.Controls.Add(Me.lbl_quantity)
        Me.Controls.Add(Me.txt_quantity)
        Me.Controls.Add(Me.lbl_rating)
        Me.Controls.Add(Me.txt_rating)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_create)
        Me.Controls.Add(Me.btn_selectPicture)
        Me.Controls.Add(Me.txt_picture)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.rich_productName)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.pic_product)
        Me.Controls.Add(Me.grd_products)
        Me.Name = "frm_products_crud_a189289"
        Me.Text = "frm_products_crud_a189289"
        CType(Me.grd_products, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grd_products As DataGridView
    Friend WithEvents pic_product As PictureBox
    Friend WithEvents txt_id As TextBox
    Friend WithEvents rich_productName As RichTextBox
    Friend WithEvents txt_price As TextBox
    Friend WithEvents txt_picture As TextBox
    Friend WithEvents btn_selectPicture As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btn_create As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_clear As Button
    Friend WithEvents txt_rating As TextBox
    Friend WithEvents lbl_rating As Label
    Friend WithEvents lbl_quantity As Label
    Friend WithEvents txt_quantity As TextBox
    Friend WithEvents lbl_compatibility As Label
    Friend WithEvents txt_compatibility As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmb_size As ComboBox
    Friend WithEvents lbl_id As Label
    Friend WithEvents lbl_name As Label
    Friend WithEvents lbl_price As Label
End Class
