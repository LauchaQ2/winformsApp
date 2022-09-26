Imports System.Data.SqlClient

Public Class AgregarPaciente

    Dim conex As New dbManager

    Public Sub EnviarDatos_Click(sender As Object, e As EventArgs) Handles EnviarDatos.Click
        Dim user As New User

        user.Nombre = txtNombre.Text
        user.Apellido = txtApellido.Text
        user.Edad = txtEdad.Text
        user.Dni = txtDni.Text

        If txtNombre.Text <> "" Or txtApellido.Text <> "" Then
            Try
                conex.Insert(user)
                MsgBox("Enviado")
                txtNombre.Text = ""
                txtApellido.Text = ""
                txtEdad.Text = ""
                txtDni.Text = ""
            Catch ex As Exception

            End Try

        End If

    End Sub
End Class