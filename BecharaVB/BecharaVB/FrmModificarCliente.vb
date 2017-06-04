Public Class FrmModificarCliente
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        If (Valida()) Then
            DialogResult = DialogResult.OK
        Else
            MessageBox.Show("Falta completar algún campo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Function Valida() As Boolean
        If String.IsNullOrEmpty(txtApellidoCliente.Text) Or String.IsNullOrEmpty(txtDireccionCliente.Text) Or String.IsNullOrEmpty(hola.Text) Or String.IsNullOrEmpty(txtDniCliente.Text) Or String.IsNullOrEmpty(txtTelefonoCliente.Text) Then

            Return False

        End If
        Return True

    End Function

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Close()
    End Sub

    Private Sub FrmModificarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class