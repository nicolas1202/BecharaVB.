Public Class FrmAuto
    Private Sub AutosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AutosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BecharaDataSet)

    End Sub

    Private Sub FrmAuto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BecharaDataSet.autos' table. You can move, or remove it, as needed.
        Me.AutosTableAdapter.Fill(Me.BecharaDataSet.autos)

    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        If (DialogResult.OK = FrmAgregarNuevoAuto.ShowDialog()) Then
            Dim nuevoAuto As DataRowView
            Dim cliente As DataRowView = ClientesBindingSource.AddNew()
            'AGREGA AUTO
            nuevoAuto = AutosBindingSource.AddNew()
            nuevoAuto("clientes_idCliente") = FrmAgregarNuevoAuto.cmbCliente.SelectedValue
            nuevoAuto("marca") = FrmAgregarNuevoAuto.txtMarca.Text
            nuevoAuto("modelo") = FrmAgregarNuevoAuto.txtModelo.Text
            nuevoAuto("anio") = FrmAgregarNuevoAuto.txtAnio.Text
            nuevoAuto("color") = FrmAgregarNuevoAuto.txtColor.Text
            nuevoAuto("filtroAceite") = FrmAgregarNuevoAuto.txtFiltroAceite.Text
            nuevoAuto("filtroAire") = FrmAgregarNuevoAuto.txtFiltroAire.Text
            nuevoAuto("filtroCombustible") = FrmAgregarNuevoAuto.txtFiltroCombustible.Text
            nuevoAuto("filtroHabitaculo") = FrmAgregarNuevoAuto.txtFiltroHabitaculo.Text
            nuevoAuto("aceiteMotor") = FrmAgregarNuevoAuto.txtAceiteMotor.Text
            nuevoAuto("kilometraje") = FrmAgregarNuevoAuto.txtKilometraje.Text
            nuevoAuto("distribucion") = FrmAgregarNuevoAuto.txtCorrea.Text
            nuevoAuto("tipoCombustible") = FrmAgregarNuevoAuto.cmbTipoCombustible.SelectedItem

            nuevoAuto.EndEdit()
            AutosTableAdapter.Update(BecharaDataSet)
            AutosTableAdapter.Fill(BecharaDataSet.autos)
            FrmAgregarNuevoAuto.Dispose()
        End If
    End Sub


End Class