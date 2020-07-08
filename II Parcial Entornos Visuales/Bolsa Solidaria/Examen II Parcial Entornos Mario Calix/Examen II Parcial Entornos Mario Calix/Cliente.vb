Public Class Cliente
    Dim conexion As New conexion()
    Dim dt As New DataTable
    Dim obj As New conexion
    Private Sub Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrarDatos()
        conexion.conectar()

    End Sub
    Private Sub mostrarDatos()
        conexion.consulta("select  idCliente as IdCliente, nombre as 'Nombre Cliente', apellido as 'Apellido', direccion as 'Direccion' from factura.cliente", "factura.cliente")
        DtgCliente.DataSource = conexion.ds.Tables("factura.cliente")
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try

            Dim guardar As String =
             "insert into factura.cliente values(" + TxtIdCliente.Text + ",'" + TxtNombreCliente.Text + "','" + TxtApellidoCliente.Text + "','" + TxtDireccionCliente.Text + "')"

            If (conexion.insertar(guardar)) Then
                MessageBox.Show("Guardado")
                mostrarDatos()

                conexion.conexion.Close()
            Else
                MessageBox.Show("Error al guardar")
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub llenarCampos(e As DataGridViewCellEventArgs)
        'Rellena los campos en los textbox, asignando de acuerdo a la posicion que se encuentra en el datagrid
        Try
            Dim dtg As DataGridViewRow = DtgCliente.Rows(e.RowIndex)
            TxtIdCliente.Text = dtg.Cells(0).Value.ToString()
            TxtNombreCliente.Text = dtg.Cells(1).Value.ToString()
            TxtApellidoCliente.Text = dtg.Cells(2).Value.ToString()
            TxtDireccionCliente.Text = dtg.Cells(3).Value.ToString()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Try
            'Ejemplo
            'UPDATE personas.estudiante 
            'WHERE codigo ='36'
            Dim modificar As String =
            "idCliente='" + TxtIdCliente.Text + "',  nombre= '" + TxtNombreCliente.Text + "',  apellido='" + TxtApellidoCliente.Text + "', direccion='" + TxtDireccionCliente.Text + "'"
            If (conexion.modificar("factura.cliente", modificar, " idCliente=" + TxtIdCliente.Text)) Then
                MessageBox.Show("Actualizado")
                mostrarDatos()
                'Limpiar()
                conexion.conexion.Close()
            Else
                MessageBox.Show("Error al actualizar")
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DtgCliente_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DtgCliente.CellContentClick
        llenarCampos(e)
    End Sub

    Public Sub Limpiar()
        TxtIdCliente.Clear()
        TxtNombreCliente.Clear()
        TxtApellidoCliente.Clear()
        TxtDireccionCliente.Clear()
        conexion.conexion.Close()
        mostrarDatos()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Try
            'Ejemplo: delete from personas.estudiante where codigo = 0036 '8836 es txtCodigo'
            'Parametros enviados son la tabla: personas.estudinte, La condicion="codigo=" + txtCodigo.Text
            If (conexion.eliminar("factura.cliente", "idCliente=" + TxtIdCliente.Text)) Then
                MessageBox.Show("Eliminado")
                mostrarDatos()
                Limpiar()
                conexion.conexion.Close()
            Else
                MessageBox.Show("Error al Eliminar")
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        obj.consultaDinamica(TxtIdCliente.Text, DtgCliente)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Menu1.Show()
        Me.Hide()

    End Sub
End Class