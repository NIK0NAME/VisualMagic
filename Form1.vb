Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitDataSet()
    End Sub

    Private Sub NuevoPedidoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoPedidoToolStripMenuItem.Click
        Dim pedidos As New Pedido()
        Dim res As MsgBoxResult = MessageBox.Show("Seuro que kieres metere nuevo producto", "Sure", MessageBoxButtons.OKCancel)
        If res = MsgBoxResult.Ok Then
            pedidos.MdiParent = Me
            pedidos.Show()
        Else

        End If
    End Sub
End Class
