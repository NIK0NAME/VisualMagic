<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pedido
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIdPedido = New System.Windows.Forms.TextBox()
        Me.txtFechaPedido = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.listaDetalles = New System.Windows.Forms.ListView()
        Me.iddetalle = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.idpedido = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.idproducto = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.unidades = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.totallinea = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTotalLinea = New System.Windows.Forms.TextBox()
        Me.txtTotoalLinea = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtUnidades = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.listaProductos = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID. Pedido"
        '
        'txtIdPedido
        '
        Me.txtIdPedido.Location = New System.Drawing.Point(29, 52)
        Me.txtIdPedido.Name = "txtIdPedido"
        Me.txtIdPedido.Size = New System.Drawing.Size(86, 20)
        Me.txtIdPedido.TabIndex = 1
        '
        'txtFechaPedido
        '
        Me.txtFechaPedido.Location = New System.Drawing.Point(411, 52)
        Me.txtFechaPedido.Name = "txtFechaPedido"
        Me.txtFechaPedido.Size = New System.Drawing.Size(153, 20)
        Me.txtFechaPedido.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(408, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha"
        '
        'listaDetalles
        '
        Me.listaDetalles.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.iddetalle, Me.idpedido, Me.idproducto, Me.unidades, Me.totallinea})
        Me.listaDetalles.HideSelection = False
        Me.listaDetalles.Location = New System.Drawing.Point(29, 105)
        Me.listaDetalles.Name = "listaDetalles"
        Me.listaDetalles.Size = New System.Drawing.Size(535, 271)
        Me.listaDetalles.TabIndex = 4
        Me.listaDetalles.UseCompatibleStateImageBehavior = False
        Me.listaDetalles.View = System.Windows.Forms.View.Details
        '
        'iddetalle
        '
        Me.iddetalle.Text = "ID detalle"
        Me.iddetalle.Width = 103
        '
        'idpedido
        '
        Me.idpedido.Text = "ID Pedido"
        Me.idpedido.Width = 104
        '
        'idproducto
        '
        Me.idproducto.Text = "ID Producto"
        Me.idproducto.Width = 158
        '
        'unidades
        '
        Me.unidades.Text = "Unidades"
        '
        'totallinea
        '
        Me.totallinea.Text = "Total Linea"
        Me.totallinea.Width = 104
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtTotalLinea)
        Me.GroupBox1.Controls.Add(Me.txtTotoalLinea)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.txtUnidades)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtPrecio)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.listaProductos)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 383)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(535, 100)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nueva Linea"
        '
        'txtTotalLinea
        '
        Me.txtTotalLinea.Location = New System.Drawing.Point(348, 37)
        Me.txtTotalLinea.Name = "txtTotalLinea"
        Me.txtTotalLinea.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalLinea.TabIndex = 9
        '
        'txtTotoalLinea
        '
        Me.txtTotoalLinea.AutoSize = True
        Me.txtTotoalLinea.Location = New System.Drawing.Point(345, 20)
        Me.txtTotoalLinea.Name = "txtTotoalLinea"
        Me.txtTotoalLinea.Size = New System.Drawing.Size(60, 13)
        Me.txtTotoalLinea.TabIndex = 8
        Me.txtTotoalLinea.Text = "Total Linea"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(454, 35)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtUnidades
        '
        Me.txtUnidades.Location = New System.Drawing.Point(243, 37)
        Me.txtUnidades.Name = "txtUnidades"
        Me.txtUnidades.Size = New System.Drawing.Size(100, 20)
        Me.txtUnidades.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(240, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Unidades"
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(137, 37)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecio.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(134, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Precio"
        '
        'listaProductos
        '
        Me.listaProductos.FormattingEnabled = True
        Me.listaProductos.Location = New System.Drawing.Point(10, 37)
        Me.listaProductos.Name = "listaProductos"
        Me.listaProductos.Size = New System.Drawing.Size(121, 21)
        Me.listaProductos.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Producto"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(489, 511)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Cerrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(39, 514)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(121, 20)
        Me.TextBox1.TabIndex = 7
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(166, 514)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 8
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(272, 514)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(36, 497)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Precio"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(163, 497)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Unidades"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(269, 497)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Total Linea"
        '
        'Pedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 562)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.listaDetalles)
        Me.Controls.Add(Me.txtFechaPedido)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtIdPedido)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Pedido"
        Me.Text = "Pedido"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtIdPedido As TextBox
    Friend WithEvents txtFechaPedido As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents listaDetalles As ListView
    Private WithEvents iddetalle As ColumnHeader
    Friend WithEvents idpedido As ColumnHeader
    Friend WithEvents idproducto As ColumnHeader
    Friend WithEvents unidades As ColumnHeader
    Friend WithEvents totallinea As ColumnHeader
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtUnidades As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents listaProductos As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtTotalLinea As TextBox
    Friend WithEvents txtTotoalLinea As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
