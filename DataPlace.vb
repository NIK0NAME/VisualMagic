Imports System.Data.SqlClient

Module DataPlace
    'El string de conexion con la base de datos
    Private conn_string As String = "Data Source=SEGUNDO150;Initial Catalog=DAM_nikolayzabaleta_DEV;Integrated Security=True"
    Public cn As New SqlConnection(conn_string)

    'Creamos los dataAdapter por cada tabla en la base de datos
    Public adapterPedidos As New SqlDataAdapter("SELECT * FROM [DB_COMPRAS].[pedidos]", cn)
    Public adatpterDetalles As New SqlDataAdapter("SELECT * FROM [DB_COMPRAS].[lineasdetalle]", cn)
    Public adapterProductos As New SqlDataAdapter("SELECT * FROM [DB_COMPRAS].[productos]", cn)

    'Creamos los builders que utilizan los adapters
    'Public builderPedidos As New SqlCommandBuilder(adapterPedidos)
    'Public builderDetalles As New SqlCommandBuilder(adatpterDetalles)
    'Public builderProductos As New SqlCommandBuilder(adapterProductos)

    'Creamos el dataset
    Public dataSet As New DataSet()

    Public Sub InitDataSet()
        'Pedidos
        MakeAdapter(adapterPedidos)

        'Detalles
        MakeAdapter(adatpterDetalles)

        'Productos
        MakeAdapter(adapterProductos)

        'Inicializar datasets
        adapterPedidos.Fill(dataSet, "Pedidos")
        adatpterDetalles.Fill(dataSet, "lineasdetalle")
        adapterProductos.Fill(dataSet, "Productos")

        'Creamos PK
        MakePK("Pedidos", "idpedido")
        MakePK("lineasdetalle", "iddetalle")
        MakePK("Productos", "idproducto")

        'Creamos las relaciones
        Dim rel1 As New DataRelation("LineasPedido", dataSet.Tables("Pedidos").Columns("idpedido"), dataSet.Tables("lineasdetalle").Columns("idpedido"))
        Dim rel2 As New DataRelation("Productos", dataSet.Tables("Productos").Columns("idproducto"), dataSet.Tables("lineasdetalle").Columns("idproducto"))

        'Añadimos las relaciones
        dataSet.Relations.Add(rel1)
        dataSet.Relations.Add(rel2)

    End Sub

    Public Sub MakeAdapter(adapter As SqlDataAdapter)
        Dim builder As New SqlCommandBuilder(adapter)
        adapter.UpdateCommand = builder.GetUpdateCommand()
        adapter.InsertCommand = builder.GetInsertCommand()
        adapter.DeleteCommand = builder.GetDeleteCommand()
    End Sub

    Public Sub MakePK(n_tabla As String, n_col As String)
        Dim pk_col(0) As DataColumn
        pk_col(0) = dataSet.Tables(n_tabla).Columns(n_col)
        dataSet.Tables(n_tabla).PrimaryKey = pk_col
    End Sub

End Module
