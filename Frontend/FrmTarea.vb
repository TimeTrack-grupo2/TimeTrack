Imports System.Windows.Forms.MonthCalendar
Imports Clases
Imports Gestion

Public Class FrmTarea

    Private idJornada As Integer
    Private dniAlumno As String
    Private horas As Integer
    Private idTarea As Integer
    Private descripcion As String
    Dim tarea As New Tarea(dniAlumno, idJornada, idTarea, horas, descripcion)

    Public Sub New(dni As String, id As Integer)
        InitializeComponent()
        idJornada = id
        dniAlumno = dni
    End Sub
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
        Dim tabla As DataTable = gestor.BuscarTarea(dniAlumno, idJornada, errorConexion)

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

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If Not Integer.TryParse(txtHoras.Text, horas) Then
            MessageBox.Show("Error tienes que introducir un valor numerico")
        End If

        If String.IsNullOrWhiteSpace(txtDescripcion.Text) Then
            MessageBox.Show("Error tienes que introducir una descripcion en este campo")
        End If
        Dim modulos As Modulo = TryCast(cboModulos.SelectedItem, Modulo)
        Dim resultado As String = gestionTareas.AgregarTarea(tarea)
        MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        If resultado.Contains("con éxito") Then
            CargarDatosGrid()
        End If


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        CargarDatosGrid()
        Dim idCiclo As Integer
        Dim modulos = gestionTareas.ModulosPorCiclo(idCiclo)
        For Each modulo In modulos
            cboModulos.Items.Add(modulo)
        Next
        cboModulos.DisplayMember = "NombreCiclo"
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If gestionTareas.EliminarTareaRa(tarea) Then
            Dim resultado As DialogResult
            resultado = MessageBox.Show("¿Estás seguro de que quieres eliminar la tarea del alumno?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If resultado = DialogResult.No Then Exit Sub
        End If

        'ESTO CREOOO QUE SERIA EL CODIGO PARA ELIMAR LA TAREA PERO FALTARA ALGUNA COSA
    End Sub
End Class