Public Class FrmAlumnos


    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        DataGridView1.Rows.Add(
            txtNombre.Text,
            txtApellido.Text,
            txtApellido2.Text,
            txtCiclo.Text,
            txtDNI.Text
            )

    End Sub
End Class
