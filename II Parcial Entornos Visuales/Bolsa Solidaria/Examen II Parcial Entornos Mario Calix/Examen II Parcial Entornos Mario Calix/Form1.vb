Imports System.ComponentModel
Public Class Form1
    Dim conexion As New conexion()
    Dim dt As New DataTable


    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub mostrarDatos()
        conexion.consulta("select  idProducto as IdProducto, nombreProducto  as 'Nombre Prodcuto', descripcion as 'Descripcion' from factura.producto", "factura.producto")
        DtgProducto.DataSource = conexion.ds.Tables("factura.producto")
    End Sub


    Private Sub DtgProducto_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DtgProducto.CellContentClick
        llenarCampos(e)
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click


        Try

            Dim guardar As String =
             "insert into factura.producto values(" + TxtId.Text + ",'" + TxtnomProducto.Text + "','" + TxtDescripcion.Text + "')"

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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conexion.conectar()
        mostrarDatos()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        mostrarDatos()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Try
            'Ejemplo
            'UPDATE personas.estudiante 
            'WHERE codigo ='36'
            Dim modificar As String =
            "idProducto='" + TxtId.Text + "', nombreProducto='" + TxtnomProducto.Text + "', descripcion='" + TxtDescripcion.Text + "'"
            If (conexion.modificar("factura.producto", modificar, " idProducto=" + TxtId.Text)) Then
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
    Private Sub llenarCampos(e As DataGridViewCellEventArgs)
        'Rellena los campos en los textbox, asignando de acuerdo a la posicion que se encuentra en el datagrid
        Try
            Dim dtg As DataGridViewRow = DtgProducto.Rows(e.RowIndex)
            TxtId.Text = dtg.Cells(0).Value.ToString()
            TxtnomProducto.Text = dtg.Cells(1).Value.ToString()
            TxtDescripcion.Text = dtg.Cells(2).Value.ToString()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
    Public Sub Limpiar()
        TxtId.Clear()
        TxtnomProducto.Clear()
        TxtDescripcion.Clear()
        conexion.conexion.Close()
        mostrarDatos()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Try
            'Ejemplo: delete from personas.estudiante where codigo = 0036 '8836 es txtCodigo'
            'Parametros enviados son la tabla: personas.estudinte, La condicion="codigo=" + txtCodigo.Text
            If (conexion.eliminar("factura.producto", "idProducto=" + TxtId.Text)) Then
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Menu1.Show()
        Me.Hide()

    End Sub
End Class
