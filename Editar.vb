Imports System.Data.SqlClient

Public Class Editar
    Dim conex As New dbManager
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim user As New User

        user.Nombre = txtNombreEdit.Text
        user.Apellido = txtApellidoEdit.Text
        user.Edad = txtEdadEdit.Text
        user.Dni = txtDniEdit.Text


        If txtNombreEdit.Text <> "" Or txtApellidoEdit.Text <> "" Then
            Try
                conex.Edit(user)

                If conex.Edit(user) Then
                    MsgBox("Usuario actualizado")
                Else
                    MsgBox("Usuario no existe")
                End If
                Me.Close()
            Catch ex As Exception

            End Try

        End If
    End Sub

End Class