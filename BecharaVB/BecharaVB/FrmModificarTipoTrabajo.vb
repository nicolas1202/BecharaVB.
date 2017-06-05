Public Class FrmModificarTipoTrabajo
    Private Sub TipotrabajoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TipotrabajoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BecharaDataSet)

    End Sub

    Private Sub FrmModificarTipoTrabajo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BecharaDataSet.tipotrabajo' table. You can move, or remove it, as needed.
        Me.TipotrabajoTableAdapter.Fill(Me.BecharaDataSet.tipotrabajo)

    End Sub


    Private Function Valida() As Boolean
        If String.IsNullOrEmpty(txtNombre.Text) Then

            Return False

        End If
        Return True

    End Function

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If (Valida()) Then
            DialogResult = DialogResult.OK
        Else
            MessageBox.Show("Falta completar algún campo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Close()
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class