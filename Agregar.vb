Imports System.Data.SqlClient

Public Class AgregarPaciente

    Private Sub EnviarDatos_Click(sender As Object, e As EventArgs) Handles EnviarDatos.Click
        Dim cmd As New SqlCommand

        Dim stNombre As String
        Dim stApellido As String
        Dim stEdad As String
        Dim stDni As String

        stNombre = txtNombre.Text
        stApellido = txtApellido.Text
        stEdad = txtEdad.Text
        stDni = txtDni.Text

        If txtNombre.Text <> "" Or txtApellido.Text <> "" Then
            Try
                Abrir_Conexion()
                cmd = New SqlCommand("Add_Paciente", conexion)
                cmd.CommandType = 4
                cmd.Parameters.AddWithValue("@IdPaciente", stDni.ToString)
                cmd.Parameters.AddWithValue("@Nombre", stNombre.ToString)
                cmd.Parameters.AddWithValue("@Apellido", stApellido.ToString)
                cmd.Parameters.AddWithValue("@Edad", stEdad)
                cmd.ExecuteNonQuery()
                MsgBox("Enviado")
                txtNombre.Text = ""
                txtApellido.Text = ""
                txtEdad.Text = ""
                txtDni.Text = ""
                Cerrar_Conexion()
            Catch ex As Exception

            End Try

        End If

    End Sub
End Class