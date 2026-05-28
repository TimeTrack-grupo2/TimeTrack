Imports System.Windows.Forms.MonthCalendar
Imports Clases
Imports Gestion

Public Class FrmTarea

    Private idJornada As Integer
    Private dniAlumno As String
    Private horas As Integer
    Private idTarea As Integer
    Private descripcion As String

    Private raTarea As Integer
    Private moduloTarea As Integer
    Public Sub New(dni As String, id As Integer)
        InitializeComponent()
        idJornada = id
        dniAlumno = dni
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

        DataGridView1.DataSource = Nothing
        DataGridView1.DataSource = tabla

        DataGridView1.Columns("DNI").Visible = False
        DataGridView1.Columns("ID_JORNADA").Visible = False
        DataGridView1.Columns("ID_TAREA").Visible = False
    End Sub
    Private Sub FrmTarea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatosGrid()

        cboModulos.DisplayMember = "nombreModulo"

        cboModulos.DataSource = gestionTareas.ModulosPorCiclo(alumno.Id_ciclo)
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If Not Integer.TryParse(txtHoras.Text, horas) Then
            MessageBox.Show("Tienes que introducir un valor numérico.")
            txtHoras.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(txtDescripcion.Text) Then
            MessageBox.Show("Tienes que introducir una descripción.")
            txtDescripcion.Focus()
            Return
        End If

        Dim moduloSeleccionado As Modulo = TryCast(cboModulos.SelectedItem, Modulo)

        If moduloSeleccionado Is Nothing Then
            MessageBox.Show("Selecciona un módulo.")
            cboModulos.Focus()
            Return
        End If

        Dim raSeleccionado As Ra = TryCast(cboResultadosAprendizaje.SelectedItem, Ra)

        If raSeleccionado Is Nothing Then
            MessageBox.Show("Selecciona un resultado de aprendizaje.")
            cboResultadosAprendizaje.Focus()
            Return
        End If

        Me.moduloTarea = moduloSeleccionado.idModulo
        Me.raTarea = raSeleccionado.idRa

        Dim idTarea As Integer = gestionTareas.CalcularIdTareaPorJornada(idJornada)
        Dim resultado As String = ""
        Dim errorSql As String = ""
        If (gestionTareas.ControlarHoras(Me.dniAlumno, Me.idJornada, horas, errorSql)) Then
            resultado = gestionTareas.AgregarTarea(New Tarea(dniAlumno, idJornada, idTarea, horas, txtDescripcion.Text), Me.moduloTarea, Me.raTarea, alumno.Id_ciclo)

        Else
            resultado = "Las horas totales de las tarea no pueden superar las de la jornada."
        End If

        MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information)

        If resultado.Contains("con éxito") Then
            CargarDatosGrid()
        End If

    End Sub


    Private Sub cboModulos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboModulos.SelectedIndexChanged
        Dim modulo As Modulo = TryCast(cboModulos.SelectedItem, Modulo)

        If modulo Is Nothing Then Return
        Me.moduloTarea = modulo.idModulo
        cboResultadosAprendizaje.DisplayMember = "ra"
        cboResultadosAprendizaje.DataSource = gestionTareas.RaPorModulos(modulo.idModulo)
    End Sub



    Private Sub btnElimina_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If DataGridView1.CurrentRow Is Nothing Then
            MessageBox.Show("Selecciona una tarea primero.")
            Return
        End If

        Dim fila = DataGridView1.CurrentRow
        Dim tarea As New Tarea
        tarea.Dni = fila.Cells("DNI").Value.ToString()
        tarea.Id_Jornada = Convert.ToInt32(fila.Cells("ID_JORNADA").Value)
        tarea.Id_Tarea = Convert.ToInt32(fila.Cells("ID_TAREA").Value)

        Dim resultado As String = gestionTareas.BorrarTarea(tarea)
        MessageBox.Show(resultado)

        CargarDatosGrid()
    End Sub
End Class