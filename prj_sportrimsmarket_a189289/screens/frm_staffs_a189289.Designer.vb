<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_staffs_a189289
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MainToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrdersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StaffsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lst_staffs = New System.Windows.Forms.ListView()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_role = New System.Windows.Forms.TextBox()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_create = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.lbl_role = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainToolStripMenuItem, Me.ProductsToolStripMenuItem, Me.OrdersToolStripMenuItem, Me.StaffsToolStripMenuItem, Me.CustomersToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 12
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
        'lst_staffs
        '
        Me.lst_staffs.FullRowSelect = True
        Me.lst_staffs.HideSelection = False
        Me.lst_staffs.Location = New System.Drawing.Point(12, 38)
        Me.lst_staffs.Name = "lst_staffs"
        Me.lst_staffs.Size = New System.Drawing.Size(331, 400)
        Me.lst_staffs.TabIndex = 13
        Me.lst_staffs.UseCompatibleStateImageBehavior = False
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(460, 46)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(100, 20)
        Me.txt_id.TabIndex = 14
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(460, 72)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(198, 20)
        Me.txt_name.TabIndex = 15
        '
        'txt_role
        '
        Me.txt_role.Location = New System.Drawing.Point(460, 98)
        Me.txt_role.Name = "txt_role"
        Me.txt_role.Size = New System.Drawing.Size(198, 20)
        Me.txt_role.TabIndex = 16
        '
        'btn_clear
        '
        Me.btn_clear.Location = New System.Drawing.Point(397, 154)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(75, 23)
        Me.btn_clear.TabIndex = 17
        Me.btn_clear.Text = "Clear Field"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Location = New System.Drawing.Point(559, 154)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(75, 23)
        Me.btn_update.TabIndex = 18
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_create
        '
        Me.btn_create.Location = New System.Drawing.Point(478, 154)
        Me.btn_create.Name = "btn_create"
        Me.btn_create.Size = New System.Drawing.Size(75, 23)
        Me.btn_create.TabIndex = 19
        Me.btn_create.Text = "Create"
        Me.btn_create.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.Red
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_delete.Location = New System.Drawing.Point(640, 154)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(75, 23)
        Me.btn_delete.TabIndex = 20
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_id.Location = New System.Drawing.Point(411, 49)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(43, 13)
        Me.lbl_id.TabIndex = 21
        Me.lbl_id.Text = "Staff ID"
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_name.Location = New System.Drawing.Point(394, 75)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(60, 13)
        Me.lbl_name.TabIndex = 22
        Me.lbl_name.Text = "Staff Name"
        '
        'lbl_role
        '
        Me.lbl_role.AutoSize = True
        Me.lbl_role.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_role.Location = New System.Drawing.Point(425, 101)
        Me.lbl_role.Name = "lbl_role"
        Me.lbl_role.Size = New System.Drawing.Size(29, 13)
        Me.lbl_role.TabIndex = 23
        Me.lbl_role.Text = "Role"
        '
        'frm_staffs_a189289
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbl_role)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_create)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.txt_role)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.lst_staffs)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "frm_staffs_a189289"
        Me.Text = "s"
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
    Friend WithEvents lst_staffs As ListView
    Friend WithEvents txt_id As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_role As TextBox
    Friend WithEvents btn_clear As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_create As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents lbl_id As Label
    Friend WithEvents lbl_name As Label
    Friend WithEvents lbl_role As Label
End Class
