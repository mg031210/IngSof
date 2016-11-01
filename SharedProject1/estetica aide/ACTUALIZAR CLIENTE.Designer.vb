<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ACTUALIZAR_CLIENTE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ACTUALIZAR_CLIENTE))
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BUSCAR = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.GUARDAR = New System.Windows.Forms.Button()
        Me.ELIMINAR = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"INGRESAR", "MODIFICAR", "ELIMINAR"})
        Me.ComboBox1.Location = New System.Drawing.Point(35, 31)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(183, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "INGRESAR"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BUSCAR)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(35, 70)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(618, 75)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "//"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "NOMBRE "
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(69, 27)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(329, 20)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(472, 27)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(83, 20)
        Me.TextBox2.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(425, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "CLAVE"
        '
        'BUSCAR
        '
        Me.BUSCAR.BackgroundImage = CType(resources.GetObject("BUSCAR.BackgroundImage"), System.Drawing.Image)
        Me.BUSCAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BUSCAR.Location = New System.Drawing.Point(561, 21)
        Me.BUSCAR.Name = "BUSCAR"
        Me.BUSCAR.Size = New System.Drawing.Size(51, 30)
        Me.BUSCAR.TabIndex = 4
        Me.BUSCAR.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(35, 341)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(216, 17)
        Me.CheckBox1.TabIndex = 3
        Me.CheckBox1.Text = "ACEPTO TERMINOS Y CONDICIONES"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "NOMBRE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 196)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "TELEFONO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(32, 231)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "DIRECCION"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(32, 263)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "CORREO"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(32, 296)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "DESCRIPCION"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(118, 162)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(530, 20)
        Me.TextBox3.TabIndex = 9
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(118, 193)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(261, 20)
        Me.TextBox4.TabIndex = 10
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(118, 224)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(529, 20)
        Me.TextBox5.TabIndex = 11
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(118, 263)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(261, 20)
        Me.TextBox6.TabIndex = 12
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(118, 293)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(530, 20)
        Me.TextBox7.TabIndex = 13
        '
        'GUARDAR
        '
        Me.GUARDAR.Location = New System.Drawing.Point(463, 335)
        Me.GUARDAR.Name = "GUARDAR"
        Me.GUARDAR.Size = New System.Drawing.Size(75, 23)
        Me.GUARDAR.TabIndex = 14
        Me.GUARDAR.Text = "GUARDAR"
        Me.GUARDAR.UseVisualStyleBackColor = True
        '
        'ELIMINAR
        '
        Me.ELIMINAR.Location = New System.Drawing.Point(572, 335)
        Me.ELIMINAR.Name = "ELIMINAR"
        Me.ELIMINAR.Size = New System.Drawing.Size(75, 23)
        Me.ELIMINAR.TabIndex = 15
        Me.ELIMINAR.Text = "ELIMINAR"
        Me.ELIMINAR.UseVisualStyleBackColor = True
        '
        'ACTUALIZAR_CLIENTE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 370)
        Me.Controls.Add(Me.ELIMINAR)
        Me.Controls.Add(Me.GUARDAR)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "ACTUALIZAR_CLIENTE"
        Me.Text = "ACTUALIZAR CLIENTE"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BUSCAR As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents GUARDAR As Button
    Friend WithEvents ELIMINAR As Button
End Class
