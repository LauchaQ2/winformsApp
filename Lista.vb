Imports System.Data.SqlClient

Public Class Lista

    Dim conex As New dbManager

    Private Sub Lista_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar()
        ' MsgBox("conexion creada con exito", vbOKOnly + vbInformation)
    End Sub


    Sub Mostrar()
        DataGridView1.DataSource = conex.ShowData()
    End Sub


    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        DataGridView1.DataSource = conex.Search(txtSearch.Text)
    End Sub


    Private Sub btnEditar_Click_1(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim frmedit As New Editar
        frmedit.txtNombreEdit.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        frmedit.txtApellidoEdit.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        frmedit.txtEdadEdit.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
        frmedit.txtDniEdit.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        frmedit.ShowDialog()
    End Sub

    Private Sub PacienteNuevo_Click(sender As Object, e As EventArgs) Handles PacienteNuevo.Click
        Dim frmnew As New NuevoPaciente
        frmnew.txtNombre.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        frmnew.txtApellido.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        frmnew.txtEdad.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
        frmnew.txtDni.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        frmnew.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frmhis As New ListaAtendidos

        frmhis.txtApellido.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        frmhis.txtDni.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()

        frmhis.ShowDialog()
    End Sub
End Class