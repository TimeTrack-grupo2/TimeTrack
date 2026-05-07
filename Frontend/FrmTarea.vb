Imports Gestion

Public Class FrmTarea
    Private Sub dgvTareas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
    Private Sub CargarDatosGrid()
        Dim errorConexion As String = ""
        Dim gestor As New GestionTareas(errorConexion)

        If Not String.IsNullOrEmpty(errorConexion) Then
            MessageBox.Show($"Error de conexión: {errorConexion}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Dim errorMensaje As String = ""
        Dim tabla As DataTable = gestor.BuscarTarea(alumno, errorConexion)

        If Not String.IsNullOrEmpty(errorMensaje) Then
            MessageBox.Show($"Error al obtener tareas: {errorMensaje}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        DataGridView1.DataSource = Nothing  ' <- Limpia cualquier enlace previo
        DataGridView1.DataSource = tabla
    End Sub
    Private Sub FrmTarea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatosGrid()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
End Class