Public Class FrmAgregarNuevoAuto


    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        If (Valida()) Then
            DialogResult = DialogResult.OK
        Else
            MessageBox.Show("Falta completar algún campo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Function Valida() As Boolean
        If String.IsNullOrEmpty(txtMarca.Text) Or String.IsNullOrEmpty(txtModelo.Text) Or String.IsNullOrEmpty(txtAnio.Text) Or String.IsNullOrEmpty(txtFiltroAceite.Text) Or String.IsNullOrEmpty(txtFiltroAire.Text) Or String.IsNullOrEmpty(txtFiltroCombustible.Text) Or String.IsNullOrEmpty(txtFiltroHabitaculo.Text) Or String.IsNullOrEmpty(txtAceiteMotor.Text) Or String.IsNullOrEmpty(txtKilometraje.Text) Or String.IsNullOrEmpty(txtCorrea.Text) Or String.IsNullOrEmpty(txtTipoCombustible.Text) Or String.IsNullOrEmpty(txtColor.Text) Then

            Return False

        End If
        Return True
    End Function
    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Close()
    End Sub

    Private Sub FrmAgregarNuevoAuto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BecharaDataSet.clientes' table. You can move, or remove it, as needed.
        Me.ClientesTableAdapter.Fill(Me.BecharaDataSet.clientes)

    End Sub

    Private Sub cmbCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCliente.SelectedIndexChanged
        Try
            Dim cliente As DataRowView = ClientesBindingSource.Current
            AutosBindingSource.Filter = "clientes_idcliente = " & cliente("nombre")
        Catch ex As Exception

        End Try
    End Sub
End Class