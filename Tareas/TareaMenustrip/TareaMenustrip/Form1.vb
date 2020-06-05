Public Class Form1
    Private Sub SumaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SumaToolStripMenuItem1.Click
        Dim valor1 As Integer
        Dim valor2 As Integer
        Dim suma As Integer
        Dim cantasumar As Integer
        Try
            cantasumar = InputBox("Ingrese los valores a sumar")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Try
            For i = 1 To cantasumar Step 1
                suma = InputBox("Ingrese el valor numero " & i)
                If Not IsNumeric(suma) Then
                    MsgBox("No se permiten letras")
                End If
                valor1 = suma + valor1
                txtResultado.Text = valor1
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RestaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RestaToolStripMenuItem1.Click
        Dim valor1 As Integer
        Dim valor2 As Integer
        Dim resta As Integer
        Dim cantarestar As Integer

        cantarestar = InputBox("Ingrese los valores a restar")
        Try
            For i = 1 To cantarestar Step 1
                resta = InputBox("Ingrese el valor numero" & i)
                If valor1 > resta Then
                    MsgBox("El valor es mayor al dato anterior")
                End If
                valor1 = resta - valor1
                txtResultado.Text = valor1
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MultiplicacionToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MultiplicacionToolStripMenuItem1.Click
        Dim valor1 = 1
        Dim valor2 As Integer
        Dim multi As Integer
        Dim cantamultli As Integer

        cantamultli = InputBox("Ingrese los valores a multiplicar")
        Try
            For i = 1 To cantamultli Step 1
                multi = InputBox("Ingrese el valor numero " & i)
                valor1 = multi * valor1
                txtResultado.Text = valor1
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DivisionToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DivisionToolStripMenuItem1.Click
        Dim valor1 = 1
        Dim valor2 As Integer
        Dim division As Integer
        Dim cantadividir As Integer

        cantadividir = InputBox("Ingrese los valores a dividir")
        Try
            For i = 1 To cantadividir Step 1
                division = InputBox("Ingrese el valor numero " & i)
                If division < valor1 Then
                    MsgBox("El Valor ingresado es menor al numero antes ingresado")
                End If
                valor1 = division  / division

                txtResultado.Text = valor1
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PotenciaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PotenciaToolStripMenuItem1.Click
        Dim valor1 = 1
        Dim valor2 As Integer
        Dim pow As Integer
        Dim cantapotenc As Integer

        cantapotenc = InputBox("Ingrese los valores a potenciar")
        Try
            For i = 1 To cantapotenc Step 1
                pow = InputBox("Ingrese el valor numero " & i)
                valor1 = pow ^ valor1
                txtResultado.Text = valor1
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DivisionToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles DivisionToolStripMenuItem2.Click
        Dim raiz As Integer
        Dim raizcuadrada As Double
        Dim resultado As Double

        Try
            raiz = InputBox("Ingrese el valor de la raiz cuadrada que quiere sacar ")
            If raiz <= 0 Then
                MsgBox("No se aceptan numeros negativos, ni raiz cuadrada de 0")
            End If
            raiz = Math.Sqrt(raiz)
            txtResultado.Text = raiz




        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Btnlimpiar_Click(sender As Object, e As EventArgs) Handles Btnlimpiar.Click
        txtResultado.Clear()

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        End
    End Sub
End Class
