﻿Public Class Form1
    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged

    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress


        If Not Char.IsLetter(e.KeyChar) _
                 AndAlso Not Char.IsControl(e.KeyChar) _
                 AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub checkPobreza_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub checkExtrema_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub checkBasica_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub checkRegular_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtIdentidad_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtIdentidad.MaskInputRejected

    End Sub

    Private Sub txtIdentidad_MouseHover(sender As Object, e As EventArgs) Handles txtIdentidad.MouseHover

        ToolTip1.SetToolTip(txtIdentidad, "Ingrese numero de Identidad")
        ToolTip1.ToolTipTitle = "ID"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnEntregar_Click(sender As Object, e As EventArgs) Handles btnEntregar.Click

        Dim existeElDato As Boolean = False
        For Each itm As DataGridViewRow In dataRegistro.Rows
            If itm.Cells(0).Value = txtIdentidad.Text Then
                existeElDato = True
            End If
        Next
        If Me.dataRegistro.Rows.Count > 0 AndAlso existeElDato = True Then
            MsgBox("El numero de identidad ya fue ingresado uan vez")


            txtIdentidad.Text = ""
            txtNombre.Text = ""
            txtIntegrantes.Text = ""
            txtDireccion.Text = ""
            comboBolsa.Text = ""
            comboEstado.Text = ""


        Else


            dataRegistro.Rows.Add(txtIdentidad.Text, txtNombre.Text, txtIntegrantes.Text, txtDireccion.Text, comboEstado.Text, comboBolsa.Text, TxtDepartamento.Text, TxtMunicipio.Text)

            txtIdentidad.Text = ""
            txtNombre.Text = ""
            txtIntegrantes.Text = ""
            txtDireccion.Text = ""
            TxtMunicipio.Text = ""
            TxtDepartamento.Text = ""
            comboBolsa.Text = ""
            comboEstado.Text = ""

        End If

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
End Class
