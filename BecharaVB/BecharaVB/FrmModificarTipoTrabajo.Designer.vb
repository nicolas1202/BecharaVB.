<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModificarTipoTrabajo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim NombreLabel As System.Windows.Forms.Label
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.BecharaDataSet = New BecharaVB.becharaDataSet()
        Me.TipotrabajoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TipotrabajoTableAdapter = New BecharaVB.becharaDataSetTableAdapters.tipotrabajoTableAdapter()
        Me.TableAdapterManager = New BecharaVB.becharaDataSetTableAdapters.TableAdapterManager()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        NombreLabel = New System.Windows.Forms.Label()
        CType(Me.BecharaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipotrabajoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(50, 41)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(45, 13)
        NombreLabel.TabIndex = 4
        NombreLabel.Text = "nombre:"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(53, 87)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 1
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(172, 87)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'BecharaDataSet
        '
        Me.BecharaDataSet.DataSetName = "becharaDataSet"
        Me.BecharaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TipotrabajoBindingSource
        '
        Me.TipotrabajoBindingSource.DataMember = "tipotrabajo"
        Me.TipotrabajoBindingSource.DataSource = Me.BecharaDataSet
        '
        'TipotrabajoTableAdapter
        '
        Me.TipotrabajoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.autosTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clientesTableAdapter = Nothing
        Me.TableAdapterManager.ordentrabajo_has_tipotrabajoTableAdapter = Nothing
        Me.TableAdapterManager.ordentrabajoTableAdapter = Nothing
        Me.TableAdapterManager.presupuesto_has_tipotrabajoTableAdapter = Nothing
        Me.TableAdapterManager.presupuestoTableAdapter = Nothing
        Me.TableAdapterManager.tipotrabajoTableAdapter = Me.TipotrabajoTableAdapter
        Me.TableAdapterManager.turnosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = BecharaVB.becharaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'txtNombre
        '
        Me.txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TipotrabajoBindingSource, "nombre", True))
        Me.txtNombre.Location = New System.Drawing.Point(147, 38)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 5
        '
        'FrmModificarTipoTrabajo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(290, 130)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Name = "FrmModificarTipoTrabajo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmModificarTipoTrabajo"
        CType(Me.BecharaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipotrabajoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents BecharaDataSet As becharaDataSet
    Friend WithEvents TipotrabajoBindingSource As BindingSource
    Friend WithEvents TipotrabajoTableAdapter As becharaDataSetTableAdapters.tipotrabajoTableAdapter
    Friend WithEvents TableAdapterManager As becharaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents txtNombre As TextBox
End Class
