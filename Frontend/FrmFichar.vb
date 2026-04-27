Public Class FrmFichar

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        lblHora.Text = TimeOfDay.ToString("HH:mm:ss")
        lblFecha.Text = Today.ToString("dd/MM/yyyy")


    End Sub

End Class