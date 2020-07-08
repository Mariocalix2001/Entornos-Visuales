Public Class Venta

    Dim conexion As New conexion()
    Dim dt As New DataTable

    Private Sub Venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrarDatos()
        conexion.conectar()
        TxtIdProducto.Enabled = False
        TxtIdCliente.Enabled = False
    End Sub


    Private Sub mostrarDatos()
        conexion.consulta("select  idVenta as idVenta, fechaVenta  as 'Fecha Venta', precio as 'Precio', cantidad as 'Cantidad', idCliente as 'IdCliente', idProducto as 'IdProducto'  from factura.Venta", "factura.Venta")
        DataGridView1.DataSource = conexion.ds.Tables("factura.Venta")
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try

            Dim guardar As String =
       "insert into factura.Venta values(" + TxtIdVenta.Text + ",'" + TxtFechaVenta.Text + "','" + TxtPrecio.Text + "','" + TxtCantidad.Text + "')"
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

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Try
            'Ejemplo
            'UPDATE personas.estudiante 
            'WHERE codigo ='36'
            Dim modificar As String =
            "idVenta='" + TxtIdVenta.Text + "', fechaVenta='" + TxtFechaVenta.Text + "', precio='" + TxtPrecio.Text + "'"
            If (conexion.modificar("factura.Venta", modificar, " idVenta=" + TxtIdVenta.Text)) Then
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Menu1.Show()
        Me.Hide()
    End Sub
End Class