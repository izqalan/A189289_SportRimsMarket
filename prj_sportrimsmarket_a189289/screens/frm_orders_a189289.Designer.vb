<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_orders_a189289
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MainToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrdersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StaffsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lst_orders = New System.Windows.Forms.ListView()
        Me.oid = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.createdAt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.customerName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.customerId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lbl_your_order = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainToolStripMenuItem, Me.ProductsToolStripMenuItem, Me.OrdersToolStripMenuItem, Me.StaffsToolStripMenuItem, Me.CustomersToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 11
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
        'lst_orders
        '
        Me.lst_orders.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.oid, Me.createdAt, Me.customerName, Me.customerId})
        Me.lst_orders.FullRowSelect = True
        Me.lst_orders.HideSelection = False
        Me.lst_orders.Location = New System.Drawing.Point(25, 91)
        Me.lst_orders.Name = "lst_orders"
        Me.lst_orders.Size = New System.Drawing.Size(741, 324)
        Me.lst_orders.Sorting = System.Windows.Forms.SortOrder.Descending
        Me.lst_orders.TabIndex = 26
        Me.lst_orders.UseCompatibleStateImageBehavior = False
        Me.lst_orders.View = System.Windows.Forms.View.Details
        '
        'oid
        '
        Me.oid.Text = "Order ID"
        Me.oid.Width = 126
        '
        'createdAt
        '
        Me.createdAt.Text = "Created At"
        Me.createdAt.Width = 412
        '
        'customerName
        '
        Me.customerName.DisplayIndex = 3
        Me.customerName.Text = "Customer Name"
        Me.customerName.Width = 104
        '
        'customerId
        '
        Me.customerId.DisplayIndex = 2
        Me.customerId.Text = "Customer Id"
        Me.customerId.Width = 95
        '
        'lbl_your_order
        '
        Me.lbl_your_order.AutoSize = True
        Me.lbl_your_order.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_your_order.Location = New System.Drawing.Point(25, 46)
        Me.lbl_your_order.Name = "lbl_your_order"
        Me.lbl_your_order.Size = New System.Drawing.Size(156, 29)
        Me.lbl_your_order.TabIndex = 27
        Me.lbl_your_order.Text = "Your Orders"
        '
        'frm_orders_a189289
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbl_your_order)
        Me.Controls.Add(Me.lst_orders)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "frm_orders_a189289"
        Me.Text = "frm_orders_a189289"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MainToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrdersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StaffsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lst_orders As ListView
    Friend WithEvents oid As ColumnHeader
    Friend WithEvents createdAt As ColumnHeader
    Friend WithEvents customerId As ColumnHeader
    Friend WithEvents lbl_your_order As Label
    Friend WithEvents customerName As ColumnHeader
End Class
