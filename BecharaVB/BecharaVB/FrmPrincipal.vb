Public Class principal

    Public Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        If (DialogResult.OK = FrmAgregarCliente.ShowDialog()) Then
            Dim nuevocliente As DataRowView

            'AGREGA CLIENTE
            nuevocliente = ClientesBindingSource.AddNew()
            nuevocliente("nombre") = FrmAgregarCliente.txtNombre.Text
            nuevocliente("apellido") = FrmAgregarCliente.txtApellidoCliente.Text
            nuevocliente("direccion") = FrmAgregarCliente.txtDireccionCliente.Text
            nuevocliente("telefono") = FrmAgregarCliente.txtTelefonoCliente.Text
            nuevocliente("fechaNacimiento") = FrmAgregarCliente.dtpCliente.Value
            nuevocliente("dni") = FrmAgregarCliente.txtDniCliente.Text

            nuevocliente.EndEdit()
            ClientesTableAdapter.Update(BecharaDataSet)
            ClientesTableAdapter.Fill(BecharaDataSet.clientes)
            FrmAgregarCliente.Dispose()
        End If
    End Sub

    Private Sub principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BecharaDataSet.clientes' table. You can move, or remove it, as needed.
        Me.ClientesTableAdapter.Fill(Me.BecharaDataSet.clientes)
        Me.AutosTableAdapter.Fill(Me.BecharaDataSet.autos)


    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click


        Try
            Dim clienteActual As DataRowView = ClientesBindingSource.Current
            Dim result As Integer = MessageBox.Show("¿Esta seguro de eliminar al cliente " + clienteActual("nombre") + " " + clienteActual("apellido") + " ?. Se eliminaràn todos sus autos", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Error)

            If result = DialogResult.Yes Then
                clienteActual.Delete()
                ' ClientesTableAdapter.Delete(clienteActual("idCliente"), clienteActual("nombre"), clienteActual("apellido"), clienteActual("direccion"), clienteActual("telefono"), clienteActual("fechaNacimiento"), clienteActual("dni"))
                ClientesTableAdapter.Update(BecharaDataSet.clientes)
                ClientesTableAdapter.Fill(BecharaDataSet.clientes)
                AutosTableAdapter.Fill(BecharaDataSet.autos)
            ElseIf result = DialogResult.No Then

            End If


        Catch ex As NullReferenceException
            MessageBox.Show("No se ha seleccionado ningun cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try







    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Try

            Dim cliente As DataRowView = ClientesBindingSource.Current

            FrmModificarCliente.hola.Text = cliente("nombre")
            FrmModificarCliente.txtApellidoCliente.Text = cliente("apellido")
            FrmModificarCliente.txtDireccionCliente.Text = cliente("direccion")
            FrmModificarCliente.txtTelefonoCliente.Text = cliente("telefono")
            FrmModificarCliente.dtpCliente.Text = cliente("fechaNacimiento")
            FrmModificarCliente.txtDniCliente.Text = cliente("dni")


            If (DialogResult.OK = FrmModificarCliente.ShowDialog()) Then



                cliente("nombre") = FrmModificarCliente.hola.Text
                cliente("apellido") = FrmModificarCliente.txtApellidoCliente.Text
                cliente("direccion") = FrmModificarCliente.txtDireccionCliente.Text
                cliente("telefono") = FrmModificarCliente.txtTelefonoCliente.Text
                cliente("fechaNacimiento") = FrmModificarCliente.dtpCliente.Value
                cliente("dni") = FrmModificarCliente.txtDniCliente.Text


                cliente.EndEdit()
                ClientesTableAdapter.Update(BecharaDataSet)
                ClientesTableAdapter.Fill(BecharaDataSet.clientes)
            End If
        Catch ex As NullReferenceException
            MessageBox.Show("Error , no hay registros para modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub autosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles autosToolStripMenuItem.Click
        Dim frmAuto As New FrmAuto()
        frmAuto.Show()
    End Sub

    Private Sub ordenDeTrabajoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ordenDeTrabajoToolStripMenuItem.Click
        Dim frmTipoTrabajo As New FrmTipoDeTrabajo()
        frmTipoTrabajo.Show()
    End Sub

    Private Sub tiposDeTrabajoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tiposDeTrabajoToolStripMenuItem.Click
        Dim frmTrabajo As New FrmTrabajos()
        frmTrabajo.Show()
    End Sub

    Private Sub turnosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles turnosToolStripMenuItem.Click
        Dim frmTurno As New FrmTurnos()
        frmTurno.Show()
    End Sub

    Private Sub textBox1_TextChanged(sender As Object, e As EventArgs) Handles txtBuscaCliente.TextChanged

        Try
            Dim filtro As String
            filtro = cmbFiltroCliente.SelectedItem.ToString


            If filtro = "Nombre" Then
                ClientesBindingSource.Filter = "nombre like '*" & txtBuscaCliente.Text & "*'"

            ElseIf filtro = "Apellido" Then
                ClientesBindingSource.Filter = "apellido like '*" & txtBuscaCliente.Text & "*'"



            Else
                ClientesBindingSource.Filter = "Direccion like '*" & txtBuscaCliente.Text & "*'"

            End If

        Catch ex As Exception
            MessageBox.Show("Seleccione un filtro de búsqueda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtBuscaCliente.Clear()
        End Try

    End Sub
End Class


