Public Class ListaAtendidos
    Dim conex As New dbManager
    Private Sub ListaAtendidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListaPacientes.DataSource = conex.HistoriaClinica(txtDni.Text)
    End Sub
End Class