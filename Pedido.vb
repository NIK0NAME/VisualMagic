Imports System.Data.SqlClient

Public Class Pedido
    Dim pedidooo As DataRow
    Private Sub Pedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarProductos()
        txtIdPedido.Text = calcIdPedido()
        txtFechaPedido.Text = Date.Now.ToShortDateString

        pedidooo = dataSet.Tables("pedidos").NewRow
        pedidooo.BeginEdit()
        pedidooo("idpedido") = CInt(txtIdPedido.Text)
        pedidooo("fecha") = txtFechaPedido.Text.ToString()
        pedidooo("cerrado") = 0
        pedidooo("totalneto") = 0
        pedidooo("totaliva") = 0
        pedidooo("totalpagar") = 0

        dataSet.Tables("Pedidos").Rows.Add(pedidooo)

        adapterPedidos.Update(dataSet, "pedidos")
    End Sub

    Public Sub llenarProductos()
        listaProductos.Items.Clear()

        For Each r As DataRow In dataSet.Tables("Productos").Rows
            'Dim itemo As New Object
            '' itemo.
            'itemo.Text = r("descrip")
            'itemo.SubItems.Add(r("idproducto"))
            listaProductos.Items.Add(r("idproducto"))
        Next
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        'Creamos la fila
        Dim r As DataRow
        r = dataSet.Tables("lineasdetalle").NewRow
        r("iddetalle") = calIdDetalle()
        r("idpedido") = CInt(txtIdPedido.Text)
        r("idproducto") = CInt(listaProductos.Text)
        r("unidades") = CInt(txtUnidades.Text)
        r("totallinea") = CDbl(txtTotalLinea.Text)

        'Metemos la fila en la tabla
        dataSet.Tables("lineasdetalle").Rows.Add(r)
        adatpterDetalles.Update(dataSet, "lineasdetalle")
        llenarListaProductos()
        txtUnidades.Clear()
        txtTotalLinea.Clear()
    End Sub

    Public Sub llenarListaProductos()
        listaDetalles.Items.Clear()
        For Each r As DataRow In dataSet.Tables("lineasdetalle").Select("idpedido = " + txtIdPedido.Text)
            Dim it As New ListViewItem(r("iddetalle").ToString)
            it.SubItems.Add(r("idpedido"))
            it.SubItems.Add(r("idproducto"))
            it.SubItems.Add(r("unidades"))
            it.SubItems.Add(r("totallinea"))
            listaDetalles.Items.Add(it)
        Next
    End Sub

    Private Function calIdDetalle() As Object
        Dim query As New SqlCommand("SELECT max(iddetalle) FROM [DB_COMPRAS].[LineasDetalle]", cn)
        cn.Open()
        Dim id As Object
        id = query.ExecuteScalar()
        cn.Close()
        If IsDBNull(id) Then
            Return 1
        Else
            Return CInt(id) + 1
        End If
    End Function

    Public Function calcIdPedido()
        Dim query As New SqlCommand("SELECT isnull(max(idpedido), 0) + 1 FROM [DB_COMPRAS].[Pedidos]", cn)
        cn.Open()
        Dim id As Object
        id = query.ExecuteScalar()
        cn.Close()

        Return CInt(id)

    End Function

    Private Sub ListaProductos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listaProductos.SelectedIndexChanged
        Dim pr_id As Integer = CInt(listaProductos.Text)
        Dim fila() As DataRow = dataSet.Tables("Productos").Select("idproducto = " + pr_id.ToString)
        txtPrecio.Text = fila(0)("pvp").ToString()
    End Sub

    Private Sub TxtUnidades_TextChanged(sender As Object, e As EventArgs) Handles txtUnidades.TextChanged
        Dim cantidad As Integer
        If Integer.TryParse(txtUnidades.Text, cantidad) Then
            txtTotalLinea.Text = cantidad * CInt(txtPrecio.Text)
        Else
            txtTotalLinea.Clear()
            MessageBox.Show("La cantidad introducidad no es numerica", "Retrasadoo")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        pedidooo.EndEdit()



    End Sub
End Class