Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Se creo Exitosamente")
    End Sub

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click

        If TxtUsuario.Text = "administrador" And TxtContraseña.Text = "sinhacer2020" Then
                Especificaciones.Show()
                Me.Hide()
            Else
                MsgBox("Credencial no valida")
            End If

    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        TxtContraseña.Clear()
        TxtUsuario.Clear()


    End Sub
End Class