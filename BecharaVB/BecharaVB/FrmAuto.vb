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
            nuevoAuto("tipoCombustible") = FrmAgregarNuevoAuto.txtTipoCombustible.Text

            nuevoAuto.EndEdit()
            AutosTableAdapter.Update(BecharaDataSet)
            AutosTableAdapter.Fill(BecharaDataSet.autos)
        End If
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Try

            Dim auto As DataRowView = AutosBindingSource.Current

            FrmModificarAuto.txtMarca.Text = auto("marca")
            FrmModificarAuto.txtModelo.Text = auto("modelo")
            FrmModificarAuto.txtAnio.Text = auto("anio")
            FrmModificarAuto.txtColor.Text = auto("color")
            FrmModificarAuto.txtFiltroAceite.Text = auto("filtroAceite")
            FrmModificarAuto.txtFiltroAire.Text = auto("filtroAire")
            FrmModificarAuto.txtFiltroCombustible.Text = auto("filtroCombustible")
            FrmModificarAuto.txtFiltroHabitaculo.Text = auto("filtroHabitaculo")
            FrmModificarAuto.txtAceiteMotor.Text = auto("aceiteMotor")
            FrmModificarAuto.txtCorrea.Text = auto("distribucion")
            FrmModificarAuto.txtTipoCombustible.Text = auto("tipoCombustible")



            If (DialogResult.OK = FrmModificarAuto.ShowDialog()) Then



                auto("marca") = FrmModificarAuto.txtMarca.Text
                auto("modelo") = FrmModificarAuto.txtModelo.Text
                auto("anio") = FrmModificarAuto.txtAnio.Text
                auto("color") = FrmModificarAuto.txtColor.Text
                auto("filtroAceite") = FrmModificarAuto.txtFiltroAceite.Text
                auto("filtroAire") = FrmModificarAuto.txtFiltroAire.Text
                auto("filtroCombustible") = FrmModificarAuto.txtFiltroCombustible.Text
                auto("filtroHabitaculo") = FrmModificarAuto.txtFiltroHabitaculo.Text
                auto("aceiteMotor") = FrmModificarAuto.txtAceiteMotor.Text
                auto("distribucion") = FrmModificarAuto.txtCorrea.Text
                auto("tipoCombustible") = FrmModificarAuto.txtTipoCombustible.Text


                auto.EndEdit()
                AutosTableAdapter.Update(BecharaDataSet)
                AutosTableAdapter.Fill(BecharaDataSet.autos)
            End If
        Catch ex As NullReferenceException
            MessageBox.Show("Error , no hay registros para modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class