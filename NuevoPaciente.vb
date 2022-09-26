Public Class NuevoPaciente
    Dim conex As New dbManager
    Private Sub EnviarDatos_Click(sender As Object, e As EventArgs) Handles EnviarDatos.Click
        Dim pacienteAtendido As New Paciente

        pacienteAtendido._fechaAtencion = FechaForm.Value
        pacienteAtendido.Dni = txtDni.Text

        Try
            conex.InsertPaciente(pacienteAtendido)

            If conex.InsertPaciente(pacienteAtendido) Then
                MsgBox("Usuario actualizado")
            Else
                MsgBox("Usuario no existe")
            End If
            Me.Close()

        Catch ex As Exception

        End Try

    End Sub
End Class