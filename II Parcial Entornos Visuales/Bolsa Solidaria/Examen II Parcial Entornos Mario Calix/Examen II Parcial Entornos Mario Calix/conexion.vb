Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Public Class conexion

    Public conexion As SqlConnection = New SqlConnection("Data Source=   DESKTOP-G1O5PU1\SQLEXPRESS     ; Initial Catalog=Tienda; Integrated Security=True")
    Private cmb As SqlCommandBuilder
    Public ds As DataSet = New DataSet()
    Public da As SqlDataAdapter
    Public comando As SqlCommand
    Public adap As SqlDataAdapter
    Public datos2 As DataSet
    Public dt As DataTable

    Public Sub conectar()
        Try
            conexion.Open()
            MessageBox.Show("Conectado")
        Catch ex As Exception
            MessageBox.Show("Error al conectar")
        Finally
            conexion.Close()
        End Try
    End Sub

    Public Sub consulta(ByVal sql, ByVal tabla)
        ds.Tables.Clear()
        da = New SqlDataAdapter(sql, conexion)
        cmb = New SqlCommandBuilder(da)
        da.Fill(ds, tabla)
    End Sub




    Function insertar(ByVal sql)
    conexion.Open()
    comando = New SqlCommand(sql, conexion)
    Dim i As Integer = comando.ExecuteNonQuery()
    If (i > 0) Then
        Return True
    Else
        Return False
    End If
End Function

Function eliminar(ByVal tabla, ByVal condicion)
    conexion.Open()
    Dim eliminarE As String = "delete from " + tabla + " where " + condicion
    comando = New SqlCommand(eliminarE, conexion)
    Dim i As Integer = comando.ExecuteNonQuery()
    conexion.Close()
    If (i > 0) Then
        Return True
    Else
        Return False
    End If
End Function

Function modificar(ByVal tabla, ByVal campos, ByVal condicion)
    conexion.Open()
    Dim modificarE As String = "update " + tabla + " set " + campos + " where " + condicion
    comando = New SqlCommand(modificarE, conexion)
    Dim i As Integer = comando.ExecuteNonQuery()
    conexion.Close()
    If (i > 0) Then
        Return True
    Else
        Return False
    End If
End Function

    Function buscarEmpleados(ByVal condicion) As DataTable
        Try
            conexion.Open()
            Dim buscar As String = "select * from factura.producto " + " where " + condicion
            'SQLcommand requiere dos parametros: 1. Instruccion sql que será 'buscar', almacena la instrucción sql
            '2. Establecer una comunicacion con la base de datos, conexion
            Dim cmd As New SqlCommand(buscar, conexion)
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Sub consultaDinamica(ByVal id As String, ByVal dgv As DataGridView)
        Try
            adap = New SqlDataAdapter("Select * from factura.cliente where IdCliente like '" & "%" + id + "%" & "'", conexion)
            dt = New DataTable
            adap.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error realizar la consulta dinamica: " + ex.ToString)
        End Try
    End Sub



End Class


















