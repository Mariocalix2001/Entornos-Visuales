Public Class Form1
    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        Dim valor As Integer
        valor = InputBox("Ingrese numero", "Ingreso")
        txtValor.Text = valor
    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Dim opcion As DialogResult
        opcion = MessageBox.Show("Desea salir", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opcion = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub Btncalcular_Click(sender As Object, e As EventArgs) Handles Btncalcular.Click
        Dim suma, resta, multipliacacion, valor As Integer
        Dim division As Double
        valor = Val(txtValor.Text)

        For i = 1 To 10 Step 1
            suma = valor + i
            resta = valor - i
            multipliacacion = valor * i
            division = Format((valor / i).ToString, 2)
            cmbSuma.Items.Add(valor & " + " & i & " = " & suma)
            cmbResta.Items.Add(valor & " - " & i & " = " & resta)
            cmbMultiplicacion.Items.Add(valor & " x " & i & " = " & multipliacacion)
            cmbDivision.Items.Add(valor & " / " & i & " = " & division)

        Next
    End Sub
End Class
