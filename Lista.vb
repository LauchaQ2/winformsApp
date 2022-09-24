Imports System.Data.SqlClient

Public Class Lista
    Private Sub Lista_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Abrir_Conexion()
        Mostrar()
        ' MsgBox("conexion creada con exito", vbOKOnly + vbInformation)
    End Sub


    Sub Mostrar()

        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            Abrir_Conexion()
            da = New SqlDataAdapter("Get_Pacientes", conexion)
            da.Fill(dt)
            DataGridView1.DataSource = dt
            Cerrar_Conexion()
        Catch ex As Exception
        End Try
    End Sub

    Sub Buscar()

        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            Abrir_Conexion()
            da = New SqlDataAdapter("Search_Paciente", conexion)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@Busqueda", txtSearch.Text)
            da.Fill(dt)
            DataGridView1.DataSource = dt
            Cerrar_Conexion()
        Catch ex As Exception

        End Try


    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Buscar()
    End Sub


    Private Sub btnEditar_Click_1(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim frmedit As New Editar
        frmedit.txtNombreEdit.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        frmedit.txtApellidoEdit.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        frmedit.txtEdadEdit.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
        frmedit.txtDniEdit.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        frmedit.ShowDialog()
    End Sub
End Class