Public Class Form1
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        'comentarios

        'inicio
        Dim valor1 As Integer
        Dim valor2 As Integer
        Dim suma As Integer

        valor1 = Val(txtValor1.Text)
        valor2 = Val(txtValor2.Text)

        'proceso
        suma = valor1 + valor2

        'salida
        txtSuma.Text = suma

    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        End
    End Sub

    Private Sub btnRestar_Click(sender As Object, e As EventArgs) Handles btnRestar.Click
        Dim valor1 As Integer
        Dim valor2 As Integer
        Dim resta As Integer

        valor1 = Val(txtValor1.Text)
        valor2 = Val(txtValor2.Text)

        'proceso
        resta = valor1 - valor2

        'salida
        txtSuma.Text = resta

    End Sub

    Private Sub btnMultiplicar_Click(sender As Object, e As EventArgs) Handles btnMultiplicar.Click

        Dim valor1 As Integer
        Dim valor2 As Integer
        Dim multiplicacion As Integer

        valor1 = Val(txtValor1.Text)
        valor2 = Val(txtValor2.Text)

        'proceso
        multiplicacion = valor1 * valor2

        'salida
        txtSuma.Text = multiplicacion

    End Sub

    Private Sub btnDividir_Click(sender As Object, e As EventArgs) Handles btnDividir.Click

        Dim valor1 As Integer
        Dim valor2 As Integer
        Dim division As Double

        valor1 = Val(txtValor1.Text)
        valor2 = Val(txtValor2.Text)

        'proceso
        division = valor1 / valor2

        'salida
        txtSuma.Text = division
    End Sub
End Class
