Imports Clases
Imports Gestion

Public Class FrmFichar


    Private Sub FrmFichar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

        txtDNI.Text = alumno.Dni
        txtNombre.Text = alumno.Nombre & " " & alumno.Apellido1 & " " & alumno.Apellido2

        cmbCurso.SelectedValue = alumno.Id_ciclo

        Dim fila As DataRow = gestionAlumno.ObtenerAlumnoPorDni(alumno.Dni)

        If fila IsNot Nothing Then
            txtDNI.Text = fila("DNI").ToString()
            txtNombre.Text = fila("NOMBRE").ToString() & " " &
                             fila("APELLIDO1").ToString() & " " &
                             fila("APELLIDO2").ToString()
            cmbCurso.Text = fila("NOMBRECICLO").ToString()
        End If

        txtDNI.ReadOnly = True
        txtNombre.ReadOnly = True
        cmbCurso.Enabled = False

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        lblFecha.Text = Today.ToString("dd/MM/yyyy")


    End Sub

    Private Sub btnEntrada_Click(sender As Object, e As EventArgs) Handles btnEntrada.Click
        ' Los datos DNI, Nombre y Curso ya están cargados automáticamente
        Dim dni As String = txtDNI.Text
        Dim horas As Integer = CInt(txtHoras.Text)

        Dim jornada As New Jornada(
    dni,
    0,
    horas,
    DateTime.Now,
    "EN CURSO"       ' ← antes ponía "Entrada"
)

        ' Llamar a AnadirJornada solo con la jornada
        Dim errorConexion As String = ""
        Dim gestionJornada As New gestionJornadas(errorConexion)
        Dim resultado As String = gestionJornada.AnadirJornada(jornada)

        MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information)

        If resultado.Contains("con éxito") Then
            LimpiarFormulario()
            Dim fila As New DataGridViewRow()
            fila.CreateCells(dtgMovimientos)
            fila.Cells(0).Value = DateTime.Now.ToShortDateString
            fila.Cells(1).Value = DateTime.Now.ToString("HH:mm:ss")   ' Columna Hora
            dtgMovimientos.Rows.Add(fila)
        End If
    End Sub

    Private Sub LimpiarFormulario()
        txtDNI.Text = ""
        txtHoras.Text = ""
        txtNombre.Text = ""
    End Sub
End Class