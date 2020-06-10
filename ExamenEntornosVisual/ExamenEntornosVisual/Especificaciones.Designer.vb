<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Especificaciones
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
        Me.Nombre = New System.Windows.Forms.Label()
        Me.TxtNiombre = New System.Windows.Forms.TextBox()
        Me.TxtEdad = New System.Windows.Forms.TextBox()
        Me.TxtMunicipio = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Positivo = New System.Windows.Forms.CheckBox()
        Me.Negativo = New System.Windows.Forms.CheckBox()
        Me.CmbDepartamento = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Descripcion = New System.Windows.Forms.Label()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.TxtMostrarActivos = New System.Windows.Forms.TextBox()
        Me.TxtRecuperados = New System.Windows.Forms.TextBox()
        Me.TxtMuerto = New System.Windows.Forms.TextBox()
        Me.LisCholu = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ChActico = New System.Windows.Forms.CheckBox()
        Me.ChRecuperado = New System.Windows.Forms.CheckBox()
        Me.ChMuerto = New System.Windows.Forms.CheckBox()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TxtMuertoscholu = New System.Windows.Forms.TextBox()
        Me.TxtRecuperadosCholu = New System.Windows.Forms.TextBox()
        Me.TxtActivoscholu = New System.Windows.Forms.TextBox()
        Me.Activos = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtMuertosColon = New System.Windows.Forms.TextBox()
        Me.TxtRecuperadoscolon = New System.Windows.Forms.TextBox()
        Me.TxtActivoscolon = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Liscolon = New System.Windows.Forms.ListBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TxtMuertocoma = New System.Windows.Forms.TextBox()
        Me.TxtRecucoma = New System.Windows.Forms.TextBox()
        Me.TxtActivoscoma = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.LisComayagua = New System.Windows.Forms.ListBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TxtMuertoscortes = New System.Windows.Forms.TextBox()
        Me.TxtRecuperadoscortes = New System.Windows.Forms.TextBox()
        Me.TxtActivoscortes = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Liscortes = New System.Windows.Forms.ListBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TxtMuertosCopan = New System.Windows.Forms.TextBox()
        Me.TxtRecuperadosCopan = New System.Windows.Forms.TextBox()
        Me.TxtActivoCopan = New System.Windows.Forms.TextBox()
        Me.Copan = New System.Windows.Forms.Label()
        Me.Listcopan = New System.Windows.Forms.ListBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.TxtMuertosElParaiso = New System.Windows.Forms.TextBox()
        Me.TxtRecuperadosElParaiso = New System.Windows.Forms.TextBox()
        Me.TxtActivoselParaiso = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.LisElParaiso = New System.Windows.Forms.ListBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.TxtMuertoFrancisco = New System.Windows.Forms.TextBox()
        Me.TxtRecuperadosFrancisco = New System.Windows.Forms.TextBox()
        Me.TxtActivosFrancis = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.LisFranciscoMorazan = New System.Windows.Forms.ListBox()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Nombre
        '
        Me.Nombre.AutoSize = True
        Me.Nombre.Location = New System.Drawing.Point(45, 32)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(44, 13)
        Me.Nombre.TabIndex = 0
        Me.Nombre.Text = "Nombre"
        '
        'TxtNiombre
        '
        Me.TxtNiombre.Location = New System.Drawing.Point(91, 32)
        Me.TxtNiombre.Name = "TxtNiombre"
        Me.TxtNiombre.Size = New System.Drawing.Size(100, 20)
        Me.TxtNiombre.TabIndex = 1
        '
        'TxtEdad
        '
        Me.TxtEdad.Location = New System.Drawing.Point(91, 67)
        Me.TxtEdad.Name = "TxtEdad"
        Me.TxtEdad.Size = New System.Drawing.Size(100, 20)
        Me.TxtEdad.TabIndex = 2
        '
        'TxtMunicipio
        '
        Me.TxtMunicipio.Location = New System.Drawing.Point(91, 115)
        Me.TxtMunicipio.Name = "TxtMunicipio"
        Me.TxtMunicipio.Size = New System.Drawing.Size(100, 20)
        Me.TxtMunicipio.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Edad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Municipio"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(64, 155)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Resultado de la Prueba"
        '
        'Positivo
        '
        Me.Positivo.AutoSize = True
        Me.Positivo.Location = New System.Drawing.Point(28, 182)
        Me.Positivo.Name = "Positivo"
        Me.Positivo.Size = New System.Drawing.Size(63, 17)
        Me.Positivo.TabIndex = 8
        Me.Positivo.Text = "Positivo"
        Me.Positivo.UseVisualStyleBackColor = True
        '
        'Negativo
        '
        Me.Negativo.AutoSize = True
        Me.Negativo.Location = New System.Drawing.Point(139, 182)
        Me.Negativo.Name = "Negativo"
        Me.Negativo.Size = New System.Drawing.Size(69, 17)
        Me.Negativo.TabIndex = 9
        Me.Negativo.Text = "Negativo"
        Me.Negativo.UseVisualStyleBackColor = True
        '
        'CmbDepartamento
        '
        Me.CmbDepartamento.FormattingEnabled = True
        Me.CmbDepartamento.Items.AddRange(New Object() {"Atlántida", "Choluteca", "Colón: ", "Comayagua", "Copán", "Cortés", "El Paraíso ", "Francisco Morazán", "Gracias a Dios", "Intibucá", "Islas de la Bahía", "La Paz", "Lempira", "Ocotepeque", "Olancho", "Santa Bárbara", "Valle", "Yoro"})
        Me.CmbDepartamento.Location = New System.Drawing.Point(28, 217)
        Me.CmbDepartamento.Name = "CmbDepartamento"
        Me.CmbDepartamento.Size = New System.Drawing.Size(204, 21)
        Me.CmbDepartamento.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(99, 202)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Departamento"
        '
        'Descripcion
        '
        Me.Descripcion.AutoSize = True
        Me.Descripcion.Location = New System.Drawing.Point(110, 257)
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Size = New System.Drawing.Size(63, 13)
        Me.Descripcion.TabIndex = 13
        Me.Descripcion.Text = "Descripcion"
        '
        'BtnAgregar
        '
        Me.BtnAgregar.BackColor = System.Drawing.Color.Lime
        Me.BtnAgregar.Location = New System.Drawing.Point(309, 345)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAgregar.TabIndex = 14
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = False
        '
        'TxtMostrarActivos
        '
        Me.TxtMostrarActivos.Location = New System.Drawing.Point(232, 123)
        Me.TxtMostrarActivos.Name = "TxtMostrarActivos"
        Me.TxtMostrarActivos.Size = New System.Drawing.Size(48, 20)
        Me.TxtMostrarActivos.TabIndex = 16
        '
        'TxtRecuperados
        '
        Me.TxtRecuperados.Location = New System.Drawing.Point(286, 123)
        Me.TxtRecuperados.Name = "TxtRecuperados"
        Me.TxtRecuperados.Size = New System.Drawing.Size(48, 20)
        Me.TxtRecuperados.TabIndex = 17
        '
        'TxtMuerto
        '
        Me.TxtMuerto.Location = New System.Drawing.Point(340, 123)
        Me.TxtMuerto.Name = "TxtMuerto"
        Me.TxtMuerto.Size = New System.Drawing.Size(48, 20)
        Me.TxtMuerto.TabIndex = 18
        '
        'LisCholu
        '
        Me.LisCholu.FormattingEnabled = True
        Me.LisCholu.Location = New System.Drawing.Point(433, 48)
        Me.LisCholu.Name = "LisCholu"
        Me.LisCholu.Size = New System.Drawing.Size(141, 69)
        Me.LisCholu.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(291, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Atlantida"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(474, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Choluteca"
        '
        'ChActico
        '
        Me.ChActico.AutoSize = True
        Me.ChActico.Location = New System.Drawing.Point(28, 392)
        Me.ChActico.Name = "ChActico"
        Me.ChActico.Size = New System.Drawing.Size(56, 17)
        Me.ChActico.TabIndex = 22
        Me.ChActico.Text = "Activo"
        Me.ChActico.UseVisualStyleBackColor = True
        '
        'ChRecuperado
        '
        Me.ChRecuperado.AutoSize = True
        Me.ChRecuperado.Location = New System.Drawing.Point(127, 392)
        Me.ChRecuperado.Name = "ChRecuperado"
        Me.ChRecuperado.Size = New System.Drawing.Size(85, 17)
        Me.ChRecuperado.TabIndex = 23
        Me.ChRecuperado.Text = "Recuperado"
        Me.ChRecuperado.UseVisualStyleBackColor = True
        '
        'ChMuerto
        '
        Me.ChMuerto.AutoSize = True
        Me.ChMuerto.Location = New System.Drawing.Point(232, 392)
        Me.ChMuerto.Name = "ChMuerto"
        Me.ChMuerto.Size = New System.Drawing.Size(59, 17)
        Me.ChMuerto.TabIndex = 24
        Me.ChMuerto.Text = "Muerto"
        Me.ChMuerto.UseVisualStyleBackColor = True
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Location = New System.Drawing.Point(28, 273)
        Me.TxtDescripcion.Multiline = True
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(224, 95)
        Me.TxtDescripcion.TabIndex = 25
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackColor = System.Drawing.Color.Aqua
        Me.BtnLimpiar.Location = New System.Drawing.Point(309, 316)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.BtnLimpiar.TabIndex = 26
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = False
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(232, 48)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(156, 69)
        Me.ListBox1.TabIndex = 27
        '
        'TxtMuertoscholu
        '
        Me.TxtMuertoscholu.Location = New System.Drawing.Point(535, 123)
        Me.TxtMuertoscholu.Name = "TxtMuertoscholu"
        Me.TxtMuertoscholu.Size = New System.Drawing.Size(48, 20)
        Me.TxtMuertoscholu.TabIndex = 31
        '
        'TxtRecuperadosCholu
        '
        Me.TxtRecuperadosCholu.Location = New System.Drawing.Point(481, 123)
        Me.TxtRecuperadosCholu.Name = "TxtRecuperadosCholu"
        Me.TxtRecuperadosCholu.Size = New System.Drawing.Size(48, 20)
        Me.TxtRecuperadosCholu.TabIndex = 30
        '
        'TxtActivoscholu
        '
        Me.TxtActivoscholu.Location = New System.Drawing.Point(427, 123)
        Me.TxtActivoscholu.Name = "TxtActivoscholu"
        Me.TxtActivoscholu.Size = New System.Drawing.Size(48, 20)
        Me.TxtActivoscholu.TabIndex = 29
        '
        'Activos
        '
        Me.Activos.AutoSize = True
        Me.Activos.Location = New System.Drawing.Point(430, 146)
        Me.Activos.Name = "Activos"
        Me.Activos.Size = New System.Drawing.Size(42, 13)
        Me.Activos.TabIndex = 32
        Me.Activos.Text = "Activos"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(489, 146)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 13)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Recu"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(538, 146)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Muertos"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(340, 146)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Muertos"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(291, 146)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(33, 13)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Recu"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(232, 146)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 13)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "Activos"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(745, 146)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 13)
        Me.Label12.TabIndex = 46
        Me.Label12.Text = "Muertos"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(696, 146)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(33, 13)
        Me.Label13.TabIndex = 45
        Me.Label13.Text = "Recu"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(637, 146)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(42, 13)
        Me.Label14.TabIndex = 44
        Me.Label14.Text = "Activos"
        '
        'TxtMuertosColon
        '
        Me.TxtMuertosColon.Location = New System.Drawing.Point(742, 123)
        Me.TxtMuertosColon.Name = "TxtMuertosColon"
        Me.TxtMuertosColon.Size = New System.Drawing.Size(48, 20)
        Me.TxtMuertosColon.TabIndex = 43
        '
        'TxtRecuperadoscolon
        '
        Me.TxtRecuperadoscolon.Location = New System.Drawing.Point(688, 123)
        Me.TxtRecuperadoscolon.Name = "TxtRecuperadoscolon"
        Me.TxtRecuperadoscolon.Size = New System.Drawing.Size(48, 20)
        Me.TxtRecuperadoscolon.TabIndex = 42
        '
        'TxtActivoscolon
        '
        Me.TxtActivoscolon.Location = New System.Drawing.Point(634, 123)
        Me.TxtActivoscolon.Name = "TxtActivoscolon"
        Me.TxtActivoscolon.Size = New System.Drawing.Size(48, 20)
        Me.TxtActivoscolon.TabIndex = 41
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(681, 32)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(34, 13)
        Me.Label15.TabIndex = 40
        Me.Label15.Text = "Colon"
        '
        'Liscolon
        '
        Me.Liscolon.FormattingEnabled = True
        Me.Liscolon.Location = New System.Drawing.Point(640, 48)
        Me.Liscolon.Name = "Liscolon"
        Me.Liscolon.Size = New System.Drawing.Size(138, 69)
        Me.Liscolon.TabIndex = 39
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(938, 146)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(45, 13)
        Me.Label16.TabIndex = 55
        Me.Label16.Text = "Muertos"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(889, 146)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(33, 13)
        Me.Label17.TabIndex = 54
        Me.Label17.Text = "Recu"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(830, 146)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(42, 13)
        Me.Label18.TabIndex = 53
        Me.Label18.Text = "Activos"
        '
        'TxtMuertocoma
        '
        Me.TxtMuertocoma.Location = New System.Drawing.Point(935, 123)
        Me.TxtMuertocoma.Name = "TxtMuertocoma"
        Me.TxtMuertocoma.Size = New System.Drawing.Size(48, 20)
        Me.TxtMuertocoma.TabIndex = 52
        '
        'TxtRecucoma
        '
        Me.TxtRecucoma.Location = New System.Drawing.Point(881, 123)
        Me.TxtRecucoma.Name = "TxtRecucoma"
        Me.TxtRecucoma.Size = New System.Drawing.Size(48, 20)
        Me.TxtRecucoma.TabIndex = 51
        '
        'TxtActivoscoma
        '
        Me.TxtActivoscoma.Location = New System.Drawing.Point(827, 123)
        Me.TxtActivoscoma.Name = "TxtActivoscoma"
        Me.TxtActivoscoma.Size = New System.Drawing.Size(48, 20)
        Me.TxtActivoscoma.TabIndex = 50
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(874, 32)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(63, 13)
        Me.Label19.TabIndex = 49
        Me.Label19.Text = "Comayagua"
        '
        'LisComayagua
        '
        Me.LisComayagua.FormattingEnabled = True
        Me.LisComayagua.Location = New System.Drawing.Point(833, 48)
        Me.LisComayagua.Name = "LisComayagua"
        Me.LisComayagua.Size = New System.Drawing.Size(134, 69)
        Me.LisComayagua.TabIndex = 48
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(932, 280)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(45, 13)
        Me.Label20.TabIndex = 63
        Me.Label20.Text = "Muertos"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(883, 280)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(33, 13)
        Me.Label21.TabIndex = 62
        Me.Label21.Text = "Recu"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(824, 280)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(42, 13)
        Me.Label22.TabIndex = 61
        Me.Label22.Text = "Activos"
        '
        'TxtMuertoscortes
        '
        Me.TxtMuertoscortes.Location = New System.Drawing.Point(929, 257)
        Me.TxtMuertoscortes.Name = "TxtMuertoscortes"
        Me.TxtMuertoscortes.Size = New System.Drawing.Size(48, 20)
        Me.TxtMuertoscortes.TabIndex = 60
        '
        'TxtRecuperadoscortes
        '
        Me.TxtRecuperadoscortes.Location = New System.Drawing.Point(875, 257)
        Me.TxtRecuperadoscortes.Name = "TxtRecuperadoscortes"
        Me.TxtRecuperadoscortes.Size = New System.Drawing.Size(48, 20)
        Me.TxtRecuperadoscortes.TabIndex = 59
        '
        'TxtActivoscortes
        '
        Me.TxtActivoscortes.Location = New System.Drawing.Point(821, 257)
        Me.TxtActivoscortes.Name = "TxtActivoscortes"
        Me.TxtActivoscortes.Size = New System.Drawing.Size(48, 20)
        Me.TxtActivoscortes.TabIndex = 58
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(868, 166)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(37, 13)
        Me.Label23.TabIndex = 57
        Me.Label23.Text = "Cortes"
        '
        'Liscortes
        '
        Me.Liscortes.FormattingEnabled = True
        Me.Liscortes.Location = New System.Drawing.Point(827, 182)
        Me.Liscortes.Name = "Liscortes"
        Me.Liscortes.Size = New System.Drawing.Size(134, 69)
        Me.Liscortes.TabIndex = 56
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(370, 280)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(45, 13)
        Me.Label24.TabIndex = 71
        Me.Label24.Text = "Muertos"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(321, 280)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(33, 13)
        Me.Label25.TabIndex = 70
        Me.Label25.Text = "Recu"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(262, 280)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(42, 13)
        Me.Label26.TabIndex = 69
        Me.Label26.Text = "Activos"
        '
        'TxtMuertosCopan
        '
        Me.TxtMuertosCopan.Location = New System.Drawing.Point(367, 257)
        Me.TxtMuertosCopan.Name = "TxtMuertosCopan"
        Me.TxtMuertosCopan.Size = New System.Drawing.Size(48, 20)
        Me.TxtMuertosCopan.TabIndex = 68
        '
        'TxtRecuperadosCopan
        '
        Me.TxtRecuperadosCopan.Location = New System.Drawing.Point(313, 257)
        Me.TxtRecuperadosCopan.Name = "TxtRecuperadosCopan"
        Me.TxtRecuperadosCopan.Size = New System.Drawing.Size(48, 20)
        Me.TxtRecuperadosCopan.TabIndex = 67
        '
        'TxtActivoCopan
        '
        Me.TxtActivoCopan.Location = New System.Drawing.Point(259, 257)
        Me.TxtActivoCopan.Name = "TxtActivoCopan"
        Me.TxtActivoCopan.Size = New System.Drawing.Size(48, 20)
        Me.TxtActivoCopan.TabIndex = 66
        '
        'Copan
        '
        Me.Copan.AutoSize = True
        Me.Copan.Location = New System.Drawing.Point(306, 166)
        Me.Copan.Name = "Copan"
        Me.Copan.Size = New System.Drawing.Size(38, 13)
        Me.Copan.TabIndex = 65
        Me.Copan.Text = "Copan"
        '
        'Listcopan
        '
        Me.Listcopan.FormattingEnabled = True
        Me.Listcopan.Location = New System.Drawing.Point(265, 182)
        Me.Listcopan.Name = "Listcopan"
        Me.Listcopan.Size = New System.Drawing.Size(134, 69)
        Me.Listcopan.TabIndex = 64
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(554, 280)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(45, 13)
        Me.Label27.TabIndex = 79
        Me.Label27.Text = "Muertos"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(505, 280)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(33, 13)
        Me.Label28.TabIndex = 78
        Me.Label28.Text = "Recu"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(446, 280)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(42, 13)
        Me.Label29.TabIndex = 77
        Me.Label29.Text = "Activos"
        '
        'TxtMuertosElParaiso
        '
        Me.TxtMuertosElParaiso.Location = New System.Drawing.Point(551, 257)
        Me.TxtMuertosElParaiso.Name = "TxtMuertosElParaiso"
        Me.TxtMuertosElParaiso.Size = New System.Drawing.Size(48, 20)
        Me.TxtMuertosElParaiso.TabIndex = 76
        '
        'TxtRecuperadosElParaiso
        '
        Me.TxtRecuperadosElParaiso.Location = New System.Drawing.Point(497, 257)
        Me.TxtRecuperadosElParaiso.Name = "TxtRecuperadosElParaiso"
        Me.TxtRecuperadosElParaiso.Size = New System.Drawing.Size(48, 20)
        Me.TxtRecuperadosElParaiso.TabIndex = 75
        '
        'TxtActivoselParaiso
        '
        Me.TxtActivoselParaiso.Location = New System.Drawing.Point(443, 257)
        Me.TxtActivoselParaiso.Name = "TxtActivoselParaiso"
        Me.TxtActivoselParaiso.Size = New System.Drawing.Size(48, 20)
        Me.TxtActivoselParaiso.TabIndex = 74
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(490, 166)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(54, 13)
        Me.Label30.TabIndex = 73
        Me.Label30.Text = "El Paraiso"
        '
        'LisElParaiso
        '
        Me.LisElParaiso.FormattingEnabled = True
        Me.LisElParaiso.Location = New System.Drawing.Point(449, 182)
        Me.LisElParaiso.Name = "LisElParaiso"
        Me.LisElParaiso.Size = New System.Drawing.Size(134, 69)
        Me.LisElParaiso.TabIndex = 72
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(721, 276)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(45, 13)
        Me.Label31.TabIndex = 87
        Me.Label31.Text = "Muertos"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(672, 276)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(33, 13)
        Me.Label32.TabIndex = 86
        Me.Label32.Text = "Recu"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(613, 276)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(42, 13)
        Me.Label33.TabIndex = 85
        Me.Label33.Text = "Activos"
        '
        'TxtMuertoFrancisco
        '
        Me.TxtMuertoFrancisco.Location = New System.Drawing.Point(718, 253)
        Me.TxtMuertoFrancisco.Name = "TxtMuertoFrancisco"
        Me.TxtMuertoFrancisco.Size = New System.Drawing.Size(48, 20)
        Me.TxtMuertoFrancisco.TabIndex = 84
        '
        'TxtRecuperadosFrancisco
        '
        Me.TxtRecuperadosFrancisco.Location = New System.Drawing.Point(664, 253)
        Me.TxtRecuperadosFrancisco.Name = "TxtRecuperadosFrancisco"
        Me.TxtRecuperadosFrancisco.Size = New System.Drawing.Size(48, 20)
        Me.TxtRecuperadosFrancisco.TabIndex = 83
        '
        'TxtActivosFrancis
        '
        Me.TxtActivosFrancis.Location = New System.Drawing.Point(610, 253)
        Me.TxtActivosFrancis.Name = "TxtActivosFrancis"
        Me.TxtActivosFrancis.Size = New System.Drawing.Size(48, 20)
        Me.TxtActivosFrancis.TabIndex = 82
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(631, 162)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(97, 13)
        Me.Label34.TabIndex = 81
        Me.Label34.Text = "Francisco Morazan"
        '
        'LisFranciscoMorazan
        '
        Me.LisFranciscoMorazan.FormattingEnabled = True
        Me.LisFranciscoMorazan.Location = New System.Drawing.Point(616, 178)
        Me.LisFranciscoMorazan.Name = "LisFranciscoMorazan"
        Me.LisFranciscoMorazan.Size = New System.Drawing.Size(134, 69)
        Me.LisFranciscoMorazan.TabIndex = 80
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.Red
        Me.BtnSalir.Location = New System.Drawing.Point(397, 316)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 23)
        Me.BtnSalir.TabIndex = 88
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'Especificaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ExamenEntornosVisual.My.Resources.Resources.fondos_1_728__1_
        Me.ClientSize = New System.Drawing.Size(1009, 421)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.TxtMuertoFrancisco)
        Me.Controls.Add(Me.TxtRecuperadosFrancisco)
        Me.Controls.Add(Me.TxtActivosFrancis)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.LisFranciscoMorazan)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.TxtMuertosElParaiso)
        Me.Controls.Add(Me.TxtRecuperadosElParaiso)
        Me.Controls.Add(Me.TxtActivoselParaiso)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.LisElParaiso)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.TxtMuertosCopan)
        Me.Controls.Add(Me.TxtRecuperadosCopan)
        Me.Controls.Add(Me.TxtActivoCopan)
        Me.Controls.Add(Me.Copan)
        Me.Controls.Add(Me.Listcopan)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.TxtMuertoscortes)
        Me.Controls.Add(Me.TxtRecuperadoscortes)
        Me.Controls.Add(Me.TxtActivoscortes)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Liscortes)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.TxtMuertocoma)
        Me.Controls.Add(Me.TxtRecucoma)
        Me.Controls.Add(Me.TxtActivoscoma)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.LisComayagua)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TxtMuertosColon)
        Me.Controls.Add(Me.TxtRecuperadoscolon)
        Me.Controls.Add(Me.TxtActivoscolon)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Liscolon)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Activos)
        Me.Controls.Add(Me.TxtMuertoscholu)
        Me.Controls.Add(Me.TxtRecuperadosCholu)
        Me.Controls.Add(Me.TxtActivoscholu)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.TxtDescripcion)
        Me.Controls.Add(Me.ChMuerto)
        Me.Controls.Add(Me.ChRecuperado)
        Me.Controls.Add(Me.ChActico)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LisCholu)
        Me.Controls.Add(Me.TxtMuerto)
        Me.Controls.Add(Me.TxtRecuperados)
        Me.Controls.Add(Me.TxtMostrarActivos)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.Descripcion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CmbDepartamento)
        Me.Controls.Add(Me.Negativo)
        Me.Controls.Add(Me.Positivo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtMunicipio)
        Me.Controls.Add(Me.TxtEdad)
        Me.Controls.Add(Me.TxtNiombre)
        Me.Controls.Add(Me.Nombre)
        Me.Name = "Especificaciones"
        Me.Text = "Especificaciones"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Nombre As Label
    Friend WithEvents TxtNiombre As TextBox
    Friend WithEvents TxtEdad As TextBox
    Friend WithEvents TxtMunicipio As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Positivo As CheckBox
    Friend WithEvents Negativo As CheckBox
    Friend WithEvents CmbDepartamento As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Descripcion As Label
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents TxtMostrarActivos As TextBox
    Friend WithEvents TxtRecuperados As TextBox
    Friend WithEvents TxtMuerto As TextBox
    Friend WithEvents LisCholu As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ChActico As CheckBox
    Friend WithEvents ChRecuperado As CheckBox
    Friend WithEvents ChMuerto As CheckBox
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents TxtMuertoscholu As TextBox
    Friend WithEvents TxtRecuperadosCholu As TextBox
    Friend WithEvents TxtActivoscholu As TextBox
    Friend WithEvents Activos As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TxtMuertosColon As TextBox
    Friend WithEvents TxtRecuperadoscolon As TextBox
    Friend WithEvents TxtActivoscolon As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Liscolon As ListBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents TxtMuertocoma As TextBox
    Friend WithEvents TxtRecucoma As TextBox
    Friend WithEvents TxtActivoscoma As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents LisComayagua As ListBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents TxtMuertoscortes As TextBox
    Friend WithEvents TxtRecuperadoscortes As TextBox
    Friend WithEvents TxtActivoscortes As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Liscortes As ListBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents TxtMuertosCopan As TextBox
    Friend WithEvents TxtRecuperadosCopan As TextBox
    Friend WithEvents TxtActivoCopan As TextBox
    Friend WithEvents Copan As Label
    Friend WithEvents Listcopan As ListBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents TxtMuertosElParaiso As TextBox
    Friend WithEvents TxtRecuperadosElParaiso As TextBox
    Friend WithEvents TxtActivoselParaiso As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents LisElParaiso As ListBox
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents TxtMuertoFrancisco As TextBox
    Friend WithEvents TxtRecuperadosFrancisco As TextBox
    Friend WithEvents TxtActivosFrancis As TextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents LisFranciscoMorazan As ListBox
    Friend WithEvents BtnSalir As Button
End Class
