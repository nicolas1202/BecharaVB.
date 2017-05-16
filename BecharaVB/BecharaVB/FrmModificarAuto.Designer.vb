<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModificarAuto
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
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCorrea = New System.Windows.Forms.TextBox()
        Me.label13 = New System.Windows.Forms.Label()
        Me.txtTipoCombustible = New System.Windows.Forms.TextBox()
        Me.label14 = New System.Windows.Forms.Label()
        Me.txtKilometraje = New System.Windows.Forms.TextBox()
        Me.label11 = New System.Windows.Forms.Label()
        Me.txtAceiteMotor = New System.Windows.Forms.TextBox()
        Me.label12 = New System.Windows.Forms.Label()
        Me.txtFiltroHabitaculo = New System.Windows.Forms.TextBox()
        Me.label9 = New System.Windows.Forms.Label()
        Me.txtFiltroCombustible = New System.Windows.Forms.TextBox()
        Me.txtFiltroAire = New System.Windows.Forms.TextBox()
        Me.label10 = New System.Windows.Forms.Label()
        Me.txtFiltroAceite = New System.Windows.Forms.TextBox()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.txtPatente = New System.Windows.Forms.TextBox()
        Me.txtAnio = New System.Windows.Forms.TextBox()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.BecharaDataSet = New BecharaVB.becharaDataSet()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New BecharaVB.becharaDataSetTableAdapters.clientesTableAdapter()
        Me.groupBox1.SuspendLayout()
        CType(Me.BecharaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'button2
        '
        Me.button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.button2.Location = New System.Drawing.Point(356, 388)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(75, 31)
        Me.button2.TabIndex = 16
        Me.button2.Text = "Cancelar"
        Me.button2.UseVisualStyleBackColor = False
        '
        'button1
        '
        Me.button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.button1.Location = New System.Drawing.Point(211, 388)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(75, 31)
        Me.button1.TabIndex = 15
        Me.button1.Text = "Aceptar"
        Me.button1.UseVisualStyleBackColor = False
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.txtCorrea)
        Me.groupBox1.Controls.Add(Me.label13)
        Me.groupBox1.Controls.Add(Me.txtTipoCombustible)
        Me.groupBox1.Controls.Add(Me.label14)
        Me.groupBox1.Controls.Add(Me.txtKilometraje)
        Me.groupBox1.Controls.Add(Me.label11)
        Me.groupBox1.Controls.Add(Me.txtAceiteMotor)
        Me.groupBox1.Controls.Add(Me.label12)
        Me.groupBox1.Controls.Add(Me.txtFiltroHabitaculo)
        Me.groupBox1.Controls.Add(Me.label9)
        Me.groupBox1.Controls.Add(Me.txtFiltroCombustible)
        Me.groupBox1.Controls.Add(Me.txtFiltroAire)
        Me.groupBox1.Controls.Add(Me.label10)
        Me.groupBox1.Controls.Add(Me.txtFiltroAceite)
        Me.groupBox1.Controls.Add(Me.txtColor)
        Me.groupBox1.Controls.Add(Me.label6)
        Me.groupBox1.Controls.Add(Me.label7)
        Me.groupBox1.Controls.Add(Me.label8)
        Me.groupBox1.Controls.Add(Me.txtMarca)
        Me.groupBox1.Controls.Add(Me.txtPatente)
        Me.groupBox1.Controls.Add(Me.txtAnio)
        Me.groupBox1.Controls.Add(Me.txtModelo)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.label5)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Location = New System.Drawing.Point(33, 28)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(591, 328)
        Me.groupBox1.TabIndex = 14
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Datos Del Auto a Modificar"
        '
        'txtCorrea
        '
        Me.txtCorrea.Location = New System.Drawing.Point(135, 230)
        Me.txtCorrea.Name = "txtCorrea"
        Me.txtCorrea.Size = New System.Drawing.Size(118, 20)
        Me.txtCorrea.TabIndex = 28
        '
        'label13
        '
        Me.label13.AutoSize = True
        Me.label13.Location = New System.Drawing.Point(29, 230)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(96, 13)
        Me.label13.TabIndex = 26
        Me.label13.Text = "Correa Distribución"
        '
        'txtTipoCombustible
        '
        Me.txtTipoCombustible.Location = New System.Drawing.Point(135, 266)
        Me.txtTipoCombustible.Name = "txtTipoCombustible"
        Me.txtTipoCombustible.Size = New System.Drawing.Size(118, 20)
        Me.txtTipoCombustible.TabIndex = 27
        '
        'label14
        '
        Me.label14.AutoSize = True
        Me.label14.Location = New System.Drawing.Point(31, 269)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(88, 13)
        Me.label14.TabIndex = 25
        Me.label14.Text = "Tipo Combustible"
        '
        'txtKilometraje
        '
        Me.txtKilometraje.Location = New System.Drawing.Point(422, 217)
        Me.txtKilometraje.Name = "txtKilometraje"
        Me.txtKilometraje.Size = New System.Drawing.Size(118, 20)
        Me.txtKilometraje.TabIndex = 24
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Location = New System.Drawing.Point(318, 224)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(58, 13)
        Me.label11.TabIndex = 22
        Me.label11.Text = "Kilometraje"
        '
        'txtAceiteMotor
        '
        Me.txtAceiteMotor.Location = New System.Drawing.Point(422, 180)
        Me.txtAceiteMotor.Name = "txtAceiteMotor"
        Me.txtAceiteMotor.Size = New System.Drawing.Size(118, 20)
        Me.txtAceiteMotor.TabIndex = 23
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Location = New System.Drawing.Point(318, 183)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(67, 13)
        Me.label12.TabIndex = 21
        Me.label12.Text = "Aceite Motor"
        '
        'txtFiltroHabitaculo
        '
        Me.txtFiltroHabitaculo.Location = New System.Drawing.Point(422, 139)
        Me.txtFiltroHabitaculo.Name = "txtFiltroHabitaculo"
        Me.txtFiltroHabitaculo.Size = New System.Drawing.Size(118, 20)
        Me.txtFiltroHabitaculo.TabIndex = 20
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(318, 146)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(83, 13)
        Me.label9.TabIndex = 18
        Me.label9.Text = "Filtro Habitaculo"
        '
        'txtFiltroCombustible
        '
        Me.txtFiltroCombustible.Location = New System.Drawing.Point(422, 63)
        Me.txtFiltroCombustible.Name = "txtFiltroCombustible"
        Me.txtFiltroCombustible.Size = New System.Drawing.Size(118, 20)
        Me.txtFiltroCombustible.TabIndex = 16
        '
        'txtFiltroAire
        '
        Me.txtFiltroAire.Location = New System.Drawing.Point(422, 102)
        Me.txtFiltroAire.Name = "txtFiltroAire"
        Me.txtFiltroAire.Size = New System.Drawing.Size(118, 20)
        Me.txtFiltroAire.TabIndex = 19
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Location = New System.Drawing.Point(318, 105)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(50, 13)
        Me.label10.TabIndex = 17
        Me.label10.Text = "Filtro Aire"
        '
        'txtFiltroAceite
        '
        Me.txtFiltroAceite.Location = New System.Drawing.Point(422, 24)
        Me.txtFiltroAceite.Name = "txtFiltroAceite"
        Me.txtFiltroAceite.Size = New System.Drawing.Size(118, 20)
        Me.txtFiltroAceite.TabIndex = 15
        '
        'txtColor
        '
        Me.txtColor.Location = New System.Drawing.Point(135, 188)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(118, 20)
        Me.txtColor.TabIndex = 14
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(31, 191)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(31, 13)
        Me.label6.TabIndex = 13
        Me.label6.Text = "Color"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(318, 67)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(89, 13)
        Me.label7.TabIndex = 12
        Me.label7.Text = "Filtro Combustible"
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(318, 32)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(62, 13)
        Me.label8.TabIndex = 11
        Me.label8.Text = "Filtro Aceite"
        '
        'txtMarca
        '
        Me.txtMarca.Location = New System.Drawing.Point(135, 28)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(118, 20)
        Me.txtMarca.TabIndex = 9
        '
        'txtPatente
        '
        Me.txtPatente.Location = New System.Drawing.Point(135, 148)
        Me.txtPatente.Name = "txtPatente"
        Me.txtPatente.Size = New System.Drawing.Size(118, 20)
        Me.txtPatente.TabIndex = 8
        '
        'txtAnio
        '
        Me.txtAnio.Location = New System.Drawing.Point(135, 107)
        Me.txtAnio.Name = "txtAnio"
        Me.txtAnio.Size = New System.Drawing.Size(118, 20)
        Me.txtAnio.TabIndex = 7
        '
        'txtModelo
        '
        Me.txtModelo.Location = New System.Drawing.Point(135, 67)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(118, 20)
        Me.txtModelo.TabIndex = 6
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(31, 31)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(37, 13)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Marca"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(31, 70)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(42, 13)
        Me.label5.TabIndex = 4
        Me.label5.Text = "Modelo"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(29, 151)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(44, 13)
        Me.label4.TabIndex = 3
        Me.label4.Text = "Patente"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(31, 110)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(26, 13)
        Me.label3.TabIndex = 2
        Me.label3.Text = "Año"
        '
        'BecharaDataSet
        '
        Me.BecharaDataSet.DataSetName = "becharaDataSet"
        Me.BecharaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "clientes"
        Me.ClientesBindingSource.DataSource = Me.BecharaDataSet
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'FrmModificarAuto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(666, 438)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.groupBox1)
        Me.Name = "FrmModificarAuto"
        Me.Text = "FrmModificarAuto"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.BecharaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents button2 As Button
    Private WithEvents button1 As Button
    Private WithEvents groupBox1 As GroupBox
    Public WithEvents txtCorrea As TextBox
    Private WithEvents label13 As Label
    Public WithEvents txtTipoCombustible As TextBox
    Private WithEvents label14 As Label
    Public WithEvents txtKilometraje As TextBox
    Private WithEvents label11 As Label
    Public WithEvents txtAceiteMotor As TextBox
    Private WithEvents label12 As Label
    Public WithEvents txtFiltroHabitaculo As TextBox
    Private WithEvents label9 As Label
    Public WithEvents txtFiltroCombustible As TextBox
    Public WithEvents txtFiltroAire As TextBox
    Private WithEvents label10 As Label
    Public WithEvents txtFiltroAceite As TextBox
    Public WithEvents txtColor As TextBox
    Private WithEvents label6 As Label
    Private WithEvents label7 As Label
    Private WithEvents label8 As Label
    Public WithEvents txtMarca As TextBox
    Public WithEvents txtPatente As TextBox
    Public WithEvents txtAnio As TextBox
    Public WithEvents txtModelo As TextBox
    Private WithEvents label2 As Label
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Friend WithEvents BecharaDataSet As becharaDataSet
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As becharaDataSetTableAdapters.clientesTableAdapter
End Class
