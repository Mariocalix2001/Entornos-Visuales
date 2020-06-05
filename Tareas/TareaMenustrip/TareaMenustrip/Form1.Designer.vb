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
        Me.components = New System.ComponentModel.Container()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OperacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SumaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MultiplicacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DivisionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PotenciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RaizToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OperacionesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SumaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MultiplicacionToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DivisionToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PotenciaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DivisionToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btnlimpiar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OperacionesToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(141, 26)
        '
        'OperacionesToolStripMenuItem
        '
        Me.OperacionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SumaToolStripMenuItem, Me.RestaToolStripMenuItem, Me.MultiplicacionToolStripMenuItem, Me.DivisionToolStripMenuItem, Me.PotenciaToolStripMenuItem, Me.RaizToolStripMenuItem})
        Me.OperacionesToolStripMenuItem.Name = "OperacionesToolStripMenuItem"
        Me.OperacionesToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.OperacionesToolStripMenuItem.Text = "Operaciones"
        '
        'SumaToolStripMenuItem
        '
        Me.SumaToolStripMenuItem.Name = "SumaToolStripMenuItem"
        Me.SumaToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.SumaToolStripMenuItem.Text = "Suma"
        '
        'RestaToolStripMenuItem
        '
        Me.RestaToolStripMenuItem.Name = "RestaToolStripMenuItem"
        Me.RestaToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.RestaToolStripMenuItem.Text = "Resta"
        '
        'MultiplicacionToolStripMenuItem
        '
        Me.MultiplicacionToolStripMenuItem.Name = "MultiplicacionToolStripMenuItem"
        Me.MultiplicacionToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.MultiplicacionToolStripMenuItem.Text = "Multiplicacion"
        '
        'DivisionToolStripMenuItem
        '
        Me.DivisionToolStripMenuItem.Name = "DivisionToolStripMenuItem"
        Me.DivisionToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.DivisionToolStripMenuItem.Text = "Division"
        '
        'PotenciaToolStripMenuItem
        '
        Me.PotenciaToolStripMenuItem.Name = "PotenciaToolStripMenuItem"
        Me.PotenciaToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.PotenciaToolStripMenuItem.Text = "Potencia"
        '
        'RaizToolStripMenuItem
        '
        Me.RaizToolStripMenuItem.Name = "RaizToolStripMenuItem"
        Me.RaizToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.RaizToolStripMenuItem.Text = "Raiz"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OperacionesToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(353, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OperacionesToolStripMenuItem1
        '
        Me.OperacionesToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SumaToolStripMenuItem1, Me.RestaToolStripMenuItem1, Me.MultiplicacionToolStripMenuItem1, Me.DivisionToolStripMenuItem1, Me.PotenciaToolStripMenuItem1, Me.DivisionToolStripMenuItem2})
        Me.OperacionesToolStripMenuItem1.Name = "OperacionesToolStripMenuItem1"
        Me.OperacionesToolStripMenuItem1.Size = New System.Drawing.Size(85, 20)
        Me.OperacionesToolStripMenuItem1.Text = "Operaciones"
        '
        'SumaToolStripMenuItem1
        '
        Me.SumaToolStripMenuItem1.Name = "SumaToolStripMenuItem1"
        Me.SumaToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.SumaToolStripMenuItem1.Text = "Suma"
        '
        'RestaToolStripMenuItem1
        '
        Me.RestaToolStripMenuItem1.Name = "RestaToolStripMenuItem1"
        Me.RestaToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.RestaToolStripMenuItem1.Text = "Resta"
        '
        'MultiplicacionToolStripMenuItem1
        '
        Me.MultiplicacionToolStripMenuItem1.Name = "MultiplicacionToolStripMenuItem1"
        Me.MultiplicacionToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.MultiplicacionToolStripMenuItem1.Text = "Multiplicacion"
        '
        'DivisionToolStripMenuItem1
        '
        Me.DivisionToolStripMenuItem1.Name = "DivisionToolStripMenuItem1"
        Me.DivisionToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.DivisionToolStripMenuItem1.Text = "Division"
        '
        'PotenciaToolStripMenuItem1
        '
        Me.PotenciaToolStripMenuItem1.Name = "PotenciaToolStripMenuItem1"
        Me.PotenciaToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.PotenciaToolStripMenuItem1.Text = "Potencia"
        '
        'DivisionToolStripMenuItem2
        '
        Me.DivisionToolStripMenuItem2.Name = "DivisionToolStripMenuItem2"
        Me.DivisionToolStripMenuItem2.Size = New System.Drawing.Size(180, 22)
        Me.DivisionToolStripMenuItem2.Text = "Raiz cuadrada"
        '
        'txtResultado
        '
        Me.txtResultado.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtResultado.Location = New System.Drawing.Point(114, 82)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(114, 20)
        Me.txtResultado.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(131, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "El resultado es:"
        '
        'Btnlimpiar
        '
        Me.Btnlimpiar.Location = New System.Drawing.Point(252, 140)
        Me.Btnlimpiar.Name = "Btnlimpiar"
        Me.Btnlimpiar.Size = New System.Drawing.Size(75, 23)
        Me.Btnlimpiar.TabIndex = 4
        Me.Btnlimpiar.Text = "Limpiar"
        Me.Btnlimpiar.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(252, 111)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 23)
        Me.BtnSalir.TabIndex = 5
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TareaMenustrip.My.Resources.Resources.descarga
        Me.ClientSize = New System.Drawing.Size(353, 184)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.Btnlimpiar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents OperacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SumaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RestaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MultiplicacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DivisionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PotenciaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RaizToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OperacionesToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SumaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents RestaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MultiplicacionToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DivisionToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PotenciaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DivisionToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Btnlimpiar As Button
    Friend WithEvents BtnSalir As Button
End Class
