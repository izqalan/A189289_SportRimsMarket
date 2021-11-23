Public Class frm_mainmenu_a189289
    Private Sub frm_mainmenu_a189289_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub btn_products_Click(sender As Object, e As EventArgs) Handles btn_products.Click
        frm_products_a189289.Show()
        Me.Hide()
    End Sub

    Private Sub btn_customers_Click(sender As Object, e As EventArgs) Handles btn_customers.Click
        frm_customers_a189289.Show()
        Me.Hide()
    End Sub

    Private Sub btn_orders_Click(sender As Object, e As EventArgs) Handles btn_orders.Click
        frm_orders_a189289.Show()
        Me.Hide()
    End Sub

    Private Sub btn_staffs_Click(sender As Object, e As EventArgs) Handles btn_staffs.Click
        frm_staffs_a189289.Show()
        Me.Hide()
    End Sub

End Class