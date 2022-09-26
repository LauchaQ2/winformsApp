Imports System.Data.SqlClient

Public Class dbManager

    Public Property _da As SqlDataAdapter

    Public Function Insert(user As User)
        Dim cmd As New SqlCommand
        OpenConex()
        cmd = New SqlCommand("Add_Paciente", conexion)
        cmd.CommandType = 4
        cmd.Parameters.AddWithValue("@IdPaciente", user.Dni)
        cmd.Parameters.AddWithValue("@Nombre", user.Nombre)
        cmd.Parameters.AddWithValue("@Apellido", user.Apellido)
        cmd.Parameters.AddWithValue("@Edad", user.Edad)
        cmd.ExecuteNonQuery()
        CloseConex()
    End Function

    Public Function ShowData()

        Dim dt As New DataTable
        Try
            OpenConex()
            _da = New SqlDataAdapter("Get_Pacientes", conexion)
            _da.Fill(dt)
            CloseConex()
            Return dt
        Catch ex As Exception
        End Try

    End Function

    Private Sub OpenConex()

        ConexionMaestra.Abrir_Conexion()

    End Sub

    Private Sub CloseConex()
        ConexionMaestra.Cerrar_Conexion()
    End Sub

    Public Function Search(searchValue As String)

        Dim dt As New DataTable

        Try
            OpenConex()
            _da = New SqlDataAdapter("Search_Paciente", conexion)
            _da.SelectCommand.CommandType = 4
            _da.SelectCommand.Parameters.AddWithValue("@Busqueda", searchValue)
            _da.Fill(dt)
            CloseConex()
            Return dt
        Catch ex As Exception

        End Try


    End Function

    Public Function Edit(user As User)

        Try
            Dim cmd As SqlCommand
            OpenConex()
            cmd = New SqlCommand("Edit_Paciente", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@IdPaciente", user.Dni)
            cmd.Parameters.AddWithValue("@Nombre", user.Nombre)
            cmd.Parameters.AddWithValue("@Apellido", user.Apellido)
            cmd.Parameters.AddWithValue("@Edad", user.Edad)
            Dim result = cmd.ExecuteNonQuery()
            If result < 1 Then
                Return False
            End If
            Return True
        Catch ex As Exception
            Return False
        Finally
            CloseConex()
        End Try
    End Function

    Public Function InsertPaciente(atendido As Paciente)
        Try
            Dim cmd As New SqlCommand
            OpenConex()
            cmd = New SqlCommand("Insert_Atendido", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@IdPaciente", atendido.Dni)
            cmd.Parameters.AddWithValue("@Fecha", atendido._fechaAtencion)
            Dim result = cmd.ExecuteNonQuery()
            If result < 1 Then
                Return False
            End If
            Return True
        Catch ex As Exception
            Return False
        Finally
            CloseConex()
        End Try

    End Function

    Public Function HistoriaClinica(id As String)

        Dim dt As New DataTable
        Try
            OpenConex()
            _da = New SqlDataAdapter("Get_Atentidos", conexion)
            _da.SelectCommand.CommandType = 4
            _da.SelectCommand.Parameters.AddWithValue("@Id", id)
            _da.Fill(dt)
            CloseConex()
            Return dt
        Catch ex As Exception
        End Try

    End Function

End Class
