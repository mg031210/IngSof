<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class REGISTRAR_VENTA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(REGISTRAR_VENTA))
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SERVICIO = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.BUSCAR = New System.Windows.Forms.Button()
        Me.AÑADIR = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DESCRIPCION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANTIDAD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MONTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.ACEPTAR = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(12, 34)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(260, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'SERVICIO
        '
        Me.SERVICIO.AutoSize = True
        Me.SERVICIO.Location = New System.Drawing.Point(42, 37)
        Me.SERVICIO.Name = "SERVICIO"
        Me.SERVICIO.Size = New System.Drawing.Size(57, 13)
        Me.SERVICIO.TabIndex = 1
        Me.SERVICIO.Text = "SERVICIO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "DESCRIPCION "
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(105, 84)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(324, 20)
        Me.TextBox1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(451, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "MONTO    $"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(522, 84)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(112, 20)
        Me.TextBox2.TabIndex = 6
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(171, 297)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 7
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(105, 157)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(233, 20)
        Me.TextBox4.TabIndex = 8
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(454, 158)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(62, 20)
        Me.TextBox5.TabIndex = 9
        '
        'BUSCAR
        '
        Me.BUSCAR.BackgroundImage = CType(resources.GetObject("BUSCAR.BackgroundImage"), System.Drawing.Image)
        Me.BUSCAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BUSCAR.Location = New System.Drawing.Point(344, 154)
        Me.BUSCAR.Name = "BUSCAR"
        Me.BUSCAR.Size = New System.Drawing.Size(44, 23)
        Me.BUSCAR.TabIndex = 10
        Me.BUSCAR.UseVisualStyleBackColor = True
        '
        'AÑADIR
        '
        Me.AÑADIR.Location = New System.Drawing.Point(546, 154)
        Me.AÑADIR.Name = "AÑADIR"
        Me.AÑADIR.Size = New System.Drawing.Size(75, 23)
        Me.AÑADIR.TabIndex = 11
        Me.AÑADIR.Text = "AÑADIR"
        Me.AÑADIR.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(102, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "DESCRIPCION"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(454, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "CANTIDAD"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DESCRIPCION, Me.CANTIDAD, Me.MONTO})
        Me.DataGridView1.Location = New System.Drawing.Point(105, 205)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(344, 46)
        Me.DataGridView1.TabIndex = 14
        '
        'DESCRIPCION
        '
        Me.DESCRIPCION.HeaderText = "DESCRIPCION"
        Me.DESCRIPCION.Name = "DESCRIPCION"
        '
        'CANTIDAD
        '
        Me.CANTIDAD.HeaderText = "CANTIDAD"
        Me.CANTIDAD.Name = "CANTIDAD"
        '
        'MONTO
        '
        Me.MONTO.HeaderText = "MONTO"
        Me.MONTO.Name = "MONTO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(102, 300)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "TOTAL     $"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(309, 300)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "RECIBIDO     $"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(394, 300)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(88, 20)
        Me.TextBox6.TabIndex = 17
        '
        'ACEPTAR
        '
        Me.ACEPTAR.Location = New System.Drawing.Point(522, 298)
        Me.ACEPTAR.Name = "ACEPTAR"
        Me.ACEPTAR.Size = New System.Drawing.Size(84, 23)
        Me.ACEPTAR.TabIndex = 18
        Me.ACEPTAR.Text = "ACEPTAR"
        Me.ACEPTAR.UseVisualStyleBackColor = True
        '
        'REGISTRAR_VENTA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 322)
        Me.Controls.Add(Me.ACEPTAR)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.AÑADIR)
        Me.Controls.Add(Me.BUSCAR)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SERVICIO)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "REGISTRAR_VENTA"
        Me.Text = "REGISTRAR VENTA"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents SERVICIO As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents BUSCAR As Button
    Friend WithEvents AÑADIR As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DESCRIPCION As DataGridViewTextBoxColumn
    Friend WithEvents CANTIDAD As DataGridViewTextBoxColumn
    Friend WithEvents MONTO As DataGridViewTextBoxColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents ACEPTAR As Button
End Class
