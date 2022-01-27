<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_order_summary_a189289
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
        Me.lbl_orderId = New System.Windows.Forms.Label()
        Me.lst_orders = New System.Windows.Forms.ListView()
        Me.productId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.productName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.productPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.quantity = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.amount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.val_totalAmount = New System.Windows.Forms.Label()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.lbl_tax = New System.Windows.Forms.Label()
        Me.val_tax = New System.Windows.Forms.Label()
        Me.lbl_grandTotal = New System.Windows.Forms.Label()
        Me.val_grandTotal = New System.Windows.Forms.Label()
        Me.lbl_customerName = New System.Windows.Forms.Label()
        Me.lbl_createdAt = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_staff = New System.Windows.Forms.Label()
        Me.lbl_staffName = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_orderId
        '
        Me.lbl_orderId.AutoSize = True
        Me.lbl_orderId.Font = New System.Drawing.Font("Reem Kufi", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_orderId.Location = New System.Drawing.Point(30, 18)
        Me.lbl_orderId.Name = "lbl_orderId"
        Me.lbl_orderId.Size = New System.Drawing.Size(129, 46)
        Me.lbl_orderId.TabIndex = 0
        Me.lbl_orderId.Text = "#OrderId"
        '
        'lst_orders
        '
        Me.lst_orders.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lst_orders.BackColor = System.Drawing.Color.Azure
        Me.lst_orders.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lst_orders.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.productId, Me.productName, Me.productPrice, Me.quantity, Me.amount})
        Me.lst_orders.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_orders.HideSelection = False
        Me.lst_orders.Location = New System.Drawing.Point(38, 190)
        Me.lst_orders.MaximumSize = New System.Drawing.Size(688, 157)
        Me.lst_orders.MinimumSize = New System.Drawing.Size(688, 60)
        Me.lst_orders.Name = "lst_orders"
        Me.lst_orders.Size = New System.Drawing.Size(688, 157)
        Me.lst_orders.TabIndex = 1
        Me.lst_orders.UseCompatibleStateImageBehavior = False
        Me.lst_orders.View = System.Windows.Forms.View.Details
        '
        'productId
        '
        Me.productId.Text = "Product ID"
        Me.productId.Width = 75
        '
        'productName
        '
        Me.productName.Text = "Name"
        Me.productName.Width = 373
        '
        'productPrice
        '
        Me.productPrice.Text = "Price (RM)"
        Me.productPrice.Width = 88
        '
        'quantity
        '
        Me.quantity.Text = "Quantity"
        Me.quantity.Width = 71
        '
        'amount
        '
        Me.amount.Text = "Amount"
        Me.amount.Width = 80
        '
        'val_totalAmount
        '
        Me.val_totalAmount.AutoSize = True
        Me.val_totalAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.val_totalAmount.Location = New System.Drawing.Point(645, 363)
        Me.val_totalAmount.Name = "val_totalAmount"
        Me.val_totalAmount.Size = New System.Drawing.Size(81, 20)
        Me.val_totalAmount.TabIndex = 2
        Me.val_totalAmount.Text = "RM400.0"
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.Location = New System.Drawing.Point(534, 363)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(49, 20)
        Me.lbl_total.TabIndex = 3
        Me.lbl_total.Text = "Total"
        '
        'lbl_tax
        '
        Me.lbl_tax.AutoSize = True
        Me.lbl_tax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tax.Location = New System.Drawing.Point(490, 383)
        Me.lbl_tax.Name = "lbl_tax"
        Me.lbl_tax.Size = New System.Drawing.Size(93, 16)
        Me.lbl_tax.TabIndex = 5
        Me.lbl_tax.Text = "6% SST Tax"
        '
        'val_tax
        '
        Me.val_tax.AutoSize = True
        Me.val_tax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.val_tax.Location = New System.Drawing.Point(646, 383)
        Me.val_tax.Name = "val_tax"
        Me.val_tax.Size = New System.Drawing.Size(67, 16)
        Me.val_tax.TabIndex = 4
        Me.val_tax.Text = "RM400.0"
        Me.val_tax.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_grandTotal
        '
        Me.lbl_grandTotal.AutoSize = True
        Me.lbl_grandTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_grandTotal.ForeColor = System.Drawing.Color.Blue
        Me.lbl_grandTotal.Location = New System.Drawing.Point(479, 432)
        Me.lbl_grandTotal.Name = "lbl_grandTotal"
        Me.lbl_grandTotal.Size = New System.Drawing.Size(104, 20)
        Me.lbl_grandTotal.TabIndex = 7
        Me.lbl_grandTotal.Text = "Grand Total"
        '
        'val_grandTotal
        '
        Me.val_grandTotal.AutoSize = True
        Me.val_grandTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.val_grandTotal.ForeColor = System.Drawing.Color.Blue
        Me.val_grandTotal.Location = New System.Drawing.Point(645, 432)
        Me.val_grandTotal.Name = "val_grandTotal"
        Me.val_grandTotal.Size = New System.Drawing.Size(81, 20)
        Me.val_grandTotal.TabIndex = 6
        Me.val_grandTotal.Text = "RM400.0"
        Me.val_grandTotal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_customerName
        '
        Me.lbl_customerName.AutoSize = True
        Me.lbl_customerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_customerName.Location = New System.Drawing.Point(35, 140)
        Me.lbl_customerName.Name = "lbl_customerName"
        Me.lbl_customerName.Size = New System.Drawing.Size(106, 16)
        Me.lbl_customerName.TabIndex = 8
        Me.lbl_customerName.Text = "Cusotmer_name"
        '
        'lbl_createdAt
        '
        Me.lbl_createdAt.AutoSize = True
        Me.lbl_createdAt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_createdAt.Location = New System.Drawing.Point(35, 153)
        Me.lbl_createdAt.Name = "lbl_createdAt"
        Me.lbl_createdAt.Size = New System.Drawing.Size(69, 16)
        Me.lbl_createdAt.TabIndex = 9
        Me.lbl_createdAt.Text = "Date_time"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = Global.prj_sportrimsmarket_a189289.My.Resources.Resources.VroomX
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(595, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(131, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'lbl_staff
        '
        Me.lbl_staff.AutoSize = True
        Me.lbl_staff.Location = New System.Drawing.Point(38, 363)
        Me.lbl_staff.Name = "lbl_staff"
        Me.lbl_staff.Size = New System.Drawing.Size(87, 13)
        Me.lbl_staff.TabIndex = 11
        Me.lbl_staff.Text = "Person in charge"
        '
        'lbl_staffName
        '
        Me.lbl_staffName.AutoSize = True
        Me.lbl_staffName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_staffName.Location = New System.Drawing.Point(38, 376)
        Me.lbl_staffName.Name = "lbl_staffName"
        Me.lbl_staffName.Size = New System.Drawing.Size(125, 16)
        Me.lbl_staffName.TabIndex = 12
        Me.lbl_staffName.Text = "Person in charge"
        '
        'frm_order_summary_a189289
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(800, 568)
        Me.Controls.Add(Me.lbl_staffName)
        Me.Controls.Add(Me.lbl_staff)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_createdAt)
        Me.Controls.Add(Me.lbl_customerName)
        Me.Controls.Add(Me.lbl_grandTotal)
        Me.Controls.Add(Me.val_grandTotal)
        Me.Controls.Add(Me.lbl_tax)
        Me.Controls.Add(Me.val_tax)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.val_totalAmount)
        Me.Controls.Add(Me.lst_orders)
        Me.Controls.Add(Me.lbl_orderId)
        Me.Name = "frm_order_summary_a189289"
        Me.Text = "frm_order_summary_a189289"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_orderId As Label
    Friend WithEvents lst_orders As ListView
    Friend WithEvents productId As ColumnHeader
    Friend WithEvents productName As ColumnHeader
    Friend WithEvents productPrice As ColumnHeader
    Friend WithEvents quantity As ColumnHeader
    Friend WithEvents amount As ColumnHeader
    Friend WithEvents val_totalAmount As Label
    Friend WithEvents lbl_total As Label
    Friend WithEvents lbl_tax As Label
    Friend WithEvents val_tax As Label
    Friend WithEvents lbl_grandTotal As Label
    Friend WithEvents val_grandTotal As Label
    Friend WithEvents lbl_customerName As Label
    Friend WithEvents lbl_createdAt As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbl_staff As Label
    Friend WithEvents lbl_staffName As Label
End Class
