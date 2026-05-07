Public Class FrmTarea
    Private Sub dgvTareas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub FrmTarea_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim listaTareas = gestionTareas.BuscarTarea(alumno)
        If listaTareas IsNot Nothing Then
            For Each tarea In listaTareas
                DataGridView1.Items.add(tarea)
            Next
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class