Public Class Especificaciones
    Dim acumactivo As Integer
    Dim acumrecuperado As Integer
    Dim acummuerto As Integer
    Dim resultado As Integer
    Dim acumuertocholu As Integer
    Dim acumactivocholu As Integer
    Dim acumrecuperadocholu As Integer
    Dim acumuertocolon As Integer
    Dim acumactivocolon As Integer
    Dim acumrecuperadocolon As Integer
    Dim acumuertocoma As Integer
    Dim acumactivocoma As Integer
    Dim acumrecuperadocoma As Integer
    Dim acumuertocortes As Integer
    Dim acumactivocortes As Integer
    Dim acumrecuperadocortes As Integer
    Dim acumuertocopan As Integer
    Dim acumactivocopan As Integer
    Dim acumrecuperadocopan As Integer
    Dim acumuertoelparaiso As Integer
    Dim acumactivoelparaiso As Integer
    Dim acumrecuperadoelparaiso As Integer
    Dim acumuertofrancisco As Integer
    Dim acumactivofrancisco As Integer
    Dim acumrecuperadofrancisco As Integer

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TxtMostrarActivos.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click


        If CmbDepartamento.SelectedIndex = 0 Then
            ListBox1.Items.Add(TxtNiombre.Text)
            ListBox1.Items.Add(TxtEdad.Text)
            ListBox1.Items.Add(TxtMunicipio.Text)
            ListBox1.Items.Add(TxtDescripcion.Text)

            If ChActico.Checked = True Then
                acumactivo = acumactivo + 1
                TxtMostrarActivos.Text = acumactivo
                ChRecuperado.Enabled = False
                ChMuerto.Enabled = False
            End If
            If ChRecuperado.Checked = True Then
                acumrecuperado = acumrecuperado + 1
                TxtRecuperados.Text = acumrecuperado
                ChActico.Enabled = False
                ChMuerto.Enabled = False
            End If
            If ChMuerto.Enabled = True Then
                acummuerto = acummuerto + 1
                TxtMuerto.Text = acummuerto
                ChRecuperado.Enabled = False
                ChActico.Enabled = False
            End If

            'acum = acum + 1'
        End If

        If CmbDepartamento.SelectedIndex = 1 Then
            LisCholu.Items.Add(TxtNiombre.Text)
            LisCholu.Items.Add(TxtEdad.Text)
            LisCholu.Items.Add(TxtMunicipio.Text)
            LisCholu.Items.Add(TxtDescripcion.Text)

            If ChActico.Checked = True Then
                acumactivocholu = acumactivocholu + 1
                TxtActivoscholu.Text = acumactivo
                ChRecuperado.Enabled = False
                ChMuerto.Enabled = False
            End If
            If ChRecuperado.Checked = True Then
                acumrecuperadocholu = acumrecuperadocholu + 1
                TxtRecuperadosCholu.Text = acumrecuperado
                ChActico.Enabled = False
                ChMuerto.Enabled = False
            End If
            If ChMuerto.Enabled = True Then
                acumuertocholu = acumuertocholu + 1
                TxtMuertoscholu.Text = acummuerto
                ChRecuperado.Enabled = False
                ChActico.Enabled = False
            End If

            'acum = acum + 1'
        End If
        If CmbDepartamento.SelectedIndex = 2 Then
            Liscolon.Items.Add(TxtNiombre.Text)
            Liscolon.Items.Add(TxtEdad.Text)
            Liscolon.Items.Add(TxtMunicipio.Text)
            Liscolon.Items.Add(TxtDescripcion.Text)

            If ChActico.Checked = True Then
                acumactivocolon = acumactivocolon + 1
                TxtActivoscolon.Text = acumactivocolon
                ChRecuperado.Enabled = False
                ChMuerto.Enabled = False
            End If
            If ChRecuperado.Checked = True Then
                acumrecuperadocolon = acumrecuperadocolon + 1
                TxtRecuperadoscolon.Text = acumrecuperadocolon
                ChActico.Enabled = False
                ChMuerto.Enabled = False
            End If
            If ChMuerto.Enabled = True Then
                acumuertocolon = acumuertocolon + 1
                TxtMuertosColon.Text = acumuertocolon
                ChRecuperado.Enabled = False
                ChActico.Enabled = False
            End If


        End If
        If CmbDepartamento.SelectedIndex = 3 Then
            LisComayagua.Items.Add(TxtNiombre.Text)
            LisComayagua.Items.Add(TxtEdad.Text)
            LisComayagua.Items.Add(TxtMunicipio.Text)
            LisComayagua.Items.Add(TxtDescripcion.Text)

            If ChActico.Checked = True Then
                acumactivocoma = acumactivocoma + 1
                TxtActivoscoma.Text = acumactivocoma
                ChRecuperado.Enabled = False
                ChMuerto.Enabled = False
            End If
            If ChRecuperado.Checked = True Then
                acumrecuperadocoma = acumrecuperadocoma + 1
                TxtRecucoma.Text = acumrecuperadocoma
                ChActico.Enabled = False
                ChMuerto.Enabled = False
            End If
            If ChMuerto.Enabled = True Then
                acumuertocoma = acumuertocoma + 1
                TxtMuertocoma.Text = acumuertocoma
                ChRecuperado.Enabled = False
                ChActico.Enabled = False
            End If


        End If
        If CmbDepartamento.SelectedIndex = 4 Then
            Liscortes.Items.Add(TxtNiombre.Text)
            Liscortes.Items.Add(TxtEdad.Text)
            Liscortes.Items.Add(TxtMunicipio.Text)
            Liscortes.Items.Add(TxtDescripcion.Text)

            If ChActico.Checked = True Then
                acumactivocortes = acumactivocortes + 1
                TxtActivoscortes.Text = acumactivocortes
                ChRecuperado.Enabled = False
                ChMuerto.Enabled = False
            End If
            If ChRecuperado.Checked = True Then
                acumrecuperadocortes = acumrecuperadocortes + 1
                TxtRecuperadoscortes.Text = acumrecuperadocortes
                ChActico.Enabled = False
                ChMuerto.Enabled = False
            End If
            If ChMuerto.Enabled = True Then
                acumuertocortes = acumuertocortes + 1
                TxtMuertoscortes.Text = acumuertocortes
                ChRecuperado.Enabled = False
                ChActico.Enabled = False
            End If


        End If

        If CmbDepartamento.SelectedIndex = 5 Then
            Listcopan.Items.Add(TxtNiombre.Text)
            Listcopan.Items.Add(TxtEdad.Text)
            Listcopan.Items.Add(TxtMunicipio.Text)
            Listcopan.Items.Add(TxtDescripcion.Text)

            If ChActico.Checked = True Then
                acumactivocopan = acumactivocopan + 1
                TxtActivoCopan.Text = acumactivocopan
                ChRecuperado.Enabled = False
                ChMuerto.Enabled = False
            End If
            If ChRecuperado.Checked = True Then
                acumrecuperadocortes = acumrecuperadocortes + 1
                TxtRecuperadosCopan.Text = acumrecuperadocopan
                ChActico.Enabled = False
                ChMuerto.Enabled = False
            End If
            If ChMuerto.Enabled = True Then
                acumuertocopan = acumuertocopan + 1
                TxtMuertosCopan.Text = acumuertocopan
                ChRecuperado.Enabled = False
                ChActico.Enabled = False
            End If


        End If

        If CmbDepartamento.SelectedIndex = 6 Then
            LisElParaiso.Items.Add(TxtNiombre.Text)
            LisElParaiso.Items.Add(TxtEdad.Text)
            LisElParaiso.Items.Add(TxtMunicipio.Text)
            LisElParaiso.Items.Add(TxtDescripcion.Text)

            If ChActico.Checked = True Then
                acumactivoelparaiso = acumactivoelparaiso + 1
                TxtActivoselParaiso.Text = acumactivoelparaiso
                ChRecuperado.Enabled = False
                ChMuerto.Enabled = False
            End If
            If ChRecuperado.Checked = True Then
                acumrecuperadocortes = acumrecuperadocortes + 1
                TxtRecuperadosElParaiso.Text = acumrecuperadoelparaiso
                ChActico.Enabled = False
                ChMuerto.Enabled = False
            End If
            If ChMuerto.Enabled = True Then
                acumuertoelparaiso = acumuertoelparaiso + 1
                TxtMuertosElParaiso.Text = acumuertoelparaiso
                ChRecuperado.Enabled = False
                ChActico.Enabled = False
            End If


        End If

        If CmbDepartamento.SelectedIndex = 7 Then
            LisFranciscoMorazan.Items.Add(TxtNiombre.Text)
            LisFranciscoMorazan.Items.Add(TxtEdad.Text)
            LisFranciscoMorazan.Items.Add(TxtMunicipio.Text)
            LisFranciscoMorazan.Items.Add(TxtDescripcion.Text)

            If ChActico.Checked = True Then
                acumactivofrancisco = acumactivofrancisco + 1
                TxtActivosFrancis.Text = acumactivofrancisco
                ChRecuperado.Enabled = False
                ChMuerto.Enabled = False
            End If
            If ChRecuperado.Checked = True Then
                acumrecuperadofrancisco = acumrecuperadofrancisco + 1
                TxtRecuperadosFrancisco.Text = acumrecuperadofrancisco
                ChActico.Enabled = False
                ChMuerto.Enabled = False
            End If
            If ChMuerto.Enabled = True Then
                acumuertofrancisco = acumuertofrancisco + 1
                TxtMuertoFrancisco.Text = acumuertofrancisco
                ChRecuperado.Enabled = False
                ChActico.Enabled = False
            End If


        End If



    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles ChActico.CheckedChanged

    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        TxtEdad.Clear()
        TxtMunicipio.Clear()
        TxtNiombre.Clear()
        Positivo.Enabled = True
        Negativo.Enabled = True
        ChMuerto.Checked = False
        ChRecuperado.Checked = False
        ChActico.Checked = False
        TxtDescripcion.Clear()


    End Sub

    Private Sub Positivo_CheckedChanged(sender As Object, e As EventArgs) Handles Positivo.CheckedChanged
        ChMuerto.Enabled = True
        ChRecuperado.Enabled = True
        ChActico.Enabled = True
    End Sub

    Private Sub Especificaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChMuerto.Enabled = False
        ChRecuperado.Enabled = False
        ChActico.Enabled = False
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        MsgBox("¿Desea salir?", MsgBoxStyle.YesNo)
        End
    End Sub
End Class