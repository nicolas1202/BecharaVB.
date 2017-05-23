Public Class FrmModificarAuto
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        ' If (Valida()) Then
        DialogResult = DialogResult.OK
        '  Else
        ' MessageBox.Show("Falta completar algún campo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '  End If
    End Sub

    Private Function Valida() As Boolean
        ' If String.IsNullOrEmpty(txtMarca.Text) Or String.IsNullOrEmpty(txtModelo.Text) Or String.IsNullOrEmpty(txtAnio.Text.ToString) Or String.IsNullOrEmpty(txtColor.Text) Or String.IsNullOrEmpty(txtFiltroAceite.Text Or String.IsNullOrEmpty(txtFiltroCombustible.Text) Or String.IsNullOrEmpty(txtFiltroHabitaculo.Text) Or String.IsNullOrEmpty(txtAceiteMotor.Text) Or String.IsNullOrEmpty(txtKilometraje.Text.ToString) Or String.IsNullOrEmpty(txtCorrea.Text) Or String.IsNullOrEmpty(txtTipoCombustible.Text)) Then

        '   Return False

        ' End If
        '   Return True

    End Function

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Close()
    End Sub

    Private Sub FrmModificarAuto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BecharaDataSet.clientes' table. You can move, or remove it, as needed.
        Me.ClientesTableAdapter.Fill(Me.BecharaDataSet.clientes)

    End Sub
End Class