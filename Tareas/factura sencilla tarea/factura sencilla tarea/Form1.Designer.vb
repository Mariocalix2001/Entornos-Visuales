<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btncalcular = New System.Windows.Forms.Button()
        Me.Btnnuevo = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.Txtpunitario = New System.Windows.Forms.TextBox()
        Me.chdescuento = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.comboISV = New System.Windows.Forms.ComboBox()
        Me.combodescuento = New System.Windows.Forms.ComboBox()
        Me.chISV = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.txtISV = New System.Windows.Forms.TextBox()
        Me.txtdescuento = New System.Windows.Forms.TextBox()
        Me.txtsubtotal = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "P. Unitario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cantidad"
        '
        'Btncalcular
        '
        Me.Btncalcular.Location = New System.Drawing.Point(397, 75)
        Me.Btncalcular.Name = "Btncalcular"
        Me.Btncalcular.Size = New System.Drawing.Size(75, 23)
        Me.Btncalcular.TabIndex = 2
        Me.Btncalcular.Text = "Calcular"
        Me.Btncalcular.UseVisualStyleBackColor = True
        '
        'Btnnuevo
        '
        Me.Btnnuevo.Location = New System.Drawing.Point(397, 112)
        Me.Btnnuevo.Name = "Btnnuevo"
        Me.Btnnuevo.Size = New System.Drawing.Size(75, 23)
        Me.Btnnuevo.TabIndex = 3
        Me.Btnnuevo.Text = "Nuevo"
        Me.Btnnuevo.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(397, 151)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 23)
        Me.BtnSalir.TabIndex = 4
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(82, 59)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(100, 20)
        Me.txtcantidad.TabIndex = 5
        '
        'Txtpunitario
        '
        Me.Txtpunitario.Location = New System.Drawing.Point(82, 28)
        Me.Txtpunitario.Name = "Txtpunitario"
        Me.Txtpunitario.Size = New System.Drawing.Size(100, 20)
        Me.Txtpunitario.TabIndex = 6
        '
        'chdescuento
        '
        Me.chdescuento.AutoSize = True
        Me.chdescuento.Location = New System.Drawing.Point(9, 120)
        Me.chdescuento.Name = "chdescuento"
        Me.chdescuento.Size = New System.Drawing.Size(113, 17)
        Me.chdescuento.TabIndex = 7
        Me.chdescuento.Text = "Aplicar Descuento"
        Me.chdescuento.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global.factura_sencilla_tarea.My.Resources.Resources.fondos_1_7281
        Me.GroupBox1.Controls.Add(Me.comboISV)
        Me.GroupBox1.Controls.Add(Me.combodescuento)
        Me.GroupBox1.Controls.Add(Me.chISV)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.chdescuento)
        Me.GroupBox1.Controls.Add(Me.Txtpunitario)
        Me.GroupBox1.Controls.Add(Me.txtcantidad)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(41, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(248, 225)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Requeridos "
        '
        'comboISV
        '
        Me.comboISV.FormattingEnabled = True
        Me.comboISV.Items.AddRange(New Object() {"Interes 15%", "Interes 17%"})
        Me.comboISV.Location = New System.Drawing.Point(9, 192)
        Me.comboISV.Name = "comboISV"
        Me.comboISV.Size = New System.Drawing.Size(121, 21)
        Me.comboISV.TabIndex = 10
        '
        'combodescuento
        '
        Me.combodescuento.FormattingEnabled = True
        Me.combodescuento.Items.AddRange(New Object() {"Descuento 1", "Descuento 2", "Descuento 3", "Descuento 4", "Descuento 5", "Descuento 6", "", ""})
        Me.combodescuento.Location = New System.Drawing.Point(9, 144)
        Me.combodescuento.Name = "combodescuento"
        Me.combodescuento.Size = New System.Drawing.Size(121, 21)
        Me.combodescuento.TabIndex = 9
        '
        'chISV
        '
        Me.chISV.AutoSize = True
        Me.chISV.Location = New System.Drawing.Point(6, 171)
        Me.chISV.Name = "chISV"
        Me.chISV.Size = New System.Drawing.Size(78, 17)
        Me.chISV.TabIndex = 8
        Me.chISV.Text = "Aplicar ISV"
        Me.chISV.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackgroundImage = Global.factura_sencilla_tarea.My.Resources.Resources.fondos_1_7282
        Me.GroupBox2.Controls.Add(Me.txttotal)
        Me.GroupBox2.Controls.Add(Me.txtISV)
        Me.GroupBox2.Controls.Add(Me.txtdescuento)
        Me.GroupBox2.Controls.Add(Me.txtsubtotal)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(47, 287)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(242, 202)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalle Factura"
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(88, 135)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(100, 20)
        Me.txttotal.TabIndex = 10
        '
        'txtISV
        '
        Me.txtISV.Location = New System.Drawing.Point(88, 104)
        Me.txtISV.Name = "txtISV"
        Me.txtISV.Size = New System.Drawing.Size(100, 20)
        Me.txtISV.TabIndex = 9
        '
        'txtdescuento
        '
        Me.txtdescuento.Location = New System.Drawing.Point(88, 74)
        Me.txtdescuento.Name = "txtdescuento"
        Me.txtdescuento.Size = New System.Drawing.Size(100, 20)
        Me.txtdescuento.TabIndex = 8
        '
        'txtsubtotal
        '
        Me.txtsubtotal.Location = New System.Drawing.Point(88, 43)
        Me.txtsubtotal.Name = "txtsubtotal"
        Me.txtsubtotal.Size = New System.Drawing.Size(100, 20)
        Me.txtsubtotal.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Total"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "ISV 15%"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Descuento"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Subtotal"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.factura_sencilla_tarea.My.Resources.Resources.fondos_1_728
        Me.ClientSize = New System.Drawing.Size(484, 512)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.Btnnuevo)
        Me.Controls.Add(Me.Btncalcular)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Btncalcular As Button
    Friend WithEvents Btnnuevo As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents txtcantidad As TextBox
    Friend WithEvents Txtpunitario As TextBox
    Friend WithEvents chdescuento As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents comboISV As ComboBox
    Friend WithEvents combodescuento As ComboBox
    Friend WithEvents chISV As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txttotal As TextBox
    Friend WithEvents txtISV As TextBox
    Friend WithEvents txtdescuento As TextBox
    Friend WithEvents txtsubtotal As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class
