Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Btncalcular_Click(sender As Object, e As EventArgs) Handles Btncalcular.Click
        Dim punitario, cantidad As Integer
        Dim descuento, subtotal, total As Double
        Dim aplicaDescuento As Boolean
        Dim combovariable As Double
        Dim interes As Double
        Dim total1 As Double
        Dim total2 As Double

        punitario = Val(Txtpunitario.Text)
        cantidad = Val(txtcantidad.Text)
        combovariable = Val(combodescuento.Text)

        subtotal = punitario * cantidad





        If Me.chdescuento.Checked = True Then



            If combodescuento.SelectedIndex = 0 Then
                descuento = subtotal * 0.1
            End If
            If combodescuento.SelectedIndex = 1 Then
                descuento = subtotal * 0.2
            End If
            If combodescuento.SelectedIndex = 2 Then
                descuento = subtotal * 0.3
            End If
            If combodescuento.SelectedIndex = 3 Then
                descuento = subtotal * 0.4
            End If
            If combodescuento.SelectedIndex = 4 Then
                descuento = subtotal * 0.5
            End If
            If combodescuento.SelectedIndex = 5 Then
                descuento = subtotal * 0.6
            End If

            total1 = subtotal - descuento

        End If



        If Me.chISV.Checked = True Then


            If comboISV.SelectedIndex = 0 Then
                interes = subtotal * 0.15
            End If
            If comboISV.SelectedIndex = 1 Then
                interes = subtotal * 0.17
            End If
            total = subtotal + interes



        End If



        total = subtotal + interes - descuento

        txtsubtotal.Text = subtotal
        txtdescuento.Text = descuento
        txttotal.Text = total
        txtISV.Text = interes
        Btnnuevo.Enabled = True
    End Sub

    Private Sub comboISV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboISV.SelectedIndexChanged
        If chdescuento.Checked = True Then
            comboISV.Enabled = False
            combodescuento.Enabled = True

        ElseIf chISV.Checked = True Then
            combodescuento.Enabled = False
            chISV.Enabled = True
        End If

    End Sub

    Private Sub Btnnuevo_Click(sender As Object, e As EventArgs) Handles Btnnuevo.Click
        txtcantidad.Text = 0
        Txtpunitario.Text = 0
        txtdescuento.Clear()
        txtsubtotal.Clear()
        txttotal.Clear()
        txtISV.Clear()
        combodescuento.Text = ""
        comboISV.Text = ""
        chdescuento.Checked = False
        chISV.Checked = False




    End Sub

    Private Sub combodescuento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combodescuento.SelectedIndexChanged

        If chdescuento.Checked = True Then
            comboISV.Enabled = False
            combodescuento.Enabled = True

        ElseIf chISV.Checked = True Then
            combodescuento.Enabled = False
            chISV.Enabled = True
        End If

    End Sub

    Private Sub Txtpunitario_TextChanged(sender As Object, e As EventArgs) Handles Txtpunitario.TextChanged


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Btnnuevo.Enabled = False
        combodescuento.Enabled = False
        comboISV.Enabled = False


    End Sub

    Private Sub chdescuento_CheckedChanged(sender As Object, e As EventArgs) Handles chdescuento.CheckedChanged
        If chdescuento.Checked = True Then
            combodescuento.Enabled = True
            chISV.Checked = False
        ElseIf chdescuento.Checked = False Then
            combodescuento.Enabled = False
            chISV.Checked = True
        End If
    End Sub

    Private Sub chISV_CheckedChanged(sender As Object, e As EventArgs) Handles chISV.CheckedChanged
        If chISV.Checked = True Then
            comboISV.Enabled = True
            chdescuento.Checked = False
        ElseIf chISV.Checked = False Then
            comboISV.Enabled = False
            chdescuento.Checked = True
        End If
    End Sub

    Private Sub txtcantidad_TextChanged(sender As Object, e As EventArgs) Handles txtcantidad.TextChanged

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        End
    End Sub
End Class
