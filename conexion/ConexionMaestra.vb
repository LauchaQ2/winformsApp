Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Module ConexionMaestra
    Public conexion As New SqlConnection("Server=LAPTOP-L8861K7K;Database=db_pacientes;User Id=lq;Password=123456")

    Sub Abrir_Conexion()
        If conexion.State = 0 Then
            conexion.Open()
        End If
    End Sub
    Sub Cerrar_Conexion()
        If conexion.State = 1 Then
            conexion.Close()
        End If

    End Sub
End Module

