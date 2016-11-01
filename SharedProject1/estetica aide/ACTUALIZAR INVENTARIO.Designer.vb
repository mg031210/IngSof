<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ACTUALIZAR_INVENTARIO
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DESCRIPCION_DEL_PRODUCTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANTIDAD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRECIO_DE_COMPRA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GUARDAR = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(63, 33)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "SOLICITAR PEDIDO"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(234, 33)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(160, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "REGISTRAR INVENTARIO"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DESCRIPCION_DEL_PRODUCTO, Me.CANTIDAD, Me.PRECIO_DE_COMPRA})
        Me.DataGridView1.Location = New System.Drawing.Point(44, 96)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(350, 81)
        Me.DataGridView1.TabIndex = 2
        '
        'DESCRIPCION_DEL_PRODUCTO
        '
        Me.DESCRIPCION_DEL_PRODUCTO.HeaderText = "DESCRIPCION DEL PRODUCTO"
        Me.DESCRIPCION_DEL_PRODUCTO.Name = "DESCRIPCION_DEL_PRODUCTO"
        '
        'CANTIDAD
        '
        Me.CANTIDAD.HeaderText = "CANTIDAD"
        Me.CANTIDAD.Name = "CANTIDAD"
        '
        'PRECIO_DE_COMPRA
        '
        Me.PRECIO_DE_COMPRA.HeaderText = "PRECIO DE COMPRA"
        Me.PRECIO_DE_COMPRA.Name = "PRECIO_DE_COMPRA"
        '
        'GUARDAR
        '
        Me.GUARDAR.Location = New System.Drawing.Point(213, 231)
        Me.GUARDAR.Name = "GUARDAR"
        Me.GUARDAR.Size = New System.Drawing.Size(75, 23)
        Me.GUARDAR.TabIndex = 3
        Me.GUARDAR.Text = "GUARDAR"
        Me.GUARDAR.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(319, 231)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "IMPRIMIR"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ACTUALIZAR_INVENTARIO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 285)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GUARDAR)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "ACTUALIZAR_INVENTARIO"
        Me.Text = "ACTUALIZAR_INVENTARIO"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DESCRIPCION_DEL_PRODUCTO As DataGridViewTextBoxColumn
    Friend WithEvents CANTIDAD As DataGridViewTextBoxColumn
    Friend WithEvents PRECIO_DE_COMPRA As DataGridViewTextBoxColumn
    Friend WithEvents GUARDAR As Button
    Friend WithEvents Button3 As Button
End Class
