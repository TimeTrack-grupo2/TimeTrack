Public Class FrmTarea
    Private Sub dgvTareas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTareas.CellContentClick

    End Sub

    Private Sub FrmTarea_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim listaTareas = gestionTareas.BuscarTarea(alumno)
        If listaTareas IsNot Nothing Then
            For Each tarea In listaTareas
                dgvTareas.Item
            Next
        End If
    End Sub
End Class