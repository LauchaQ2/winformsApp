Imports System.Data.SqlClient

Public Class Editar

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmd As New SqlCommand

        Dim stNombre As String
        Dim stApellido As String
        Dim stEdad As String
        Dim stDni As String

        stNombre = txtNombreEdit.Text
        stApellido = txtApellidoEdit.Text
        stEdad = txtEdadEdit.Text
        stDni = txtDniEdit.Text

        If txtNombreEdit.Text <> "" Or txtApellidoEdit.Text <> "" Then
            Try
                Abrir_Conexion()
                cmd = New SqlCommand("Edit_Paciente", conexion)
                cmd.CommandType = 4
                cmd.Parameters.AddWithValue("@IdPaciente", stDni.ToString)
                cmd.Parameters.AddWithValue("@Nombre", stNombre.ToString)
                cmd.Parameters.AddWithValue("@Apellido", stApellido.ToString)
                cmd.Parameters.AddWithValue("@Edad", stEdad)
                cmd.ExecuteNonQuery()
                MsgBox("Usuario actualizado")
                Cerrar_Conexion()
            Catch ex As Exception

            End Try

        End If
    End Sub

End Class