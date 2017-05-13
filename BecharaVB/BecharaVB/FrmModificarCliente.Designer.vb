<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModificarCliente
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
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpCliente = New System.Windows.Forms.DateTimePicker()
        Me.label6 = New System.Windows.Forms.Label()
        Me.txtApellidoCliente = New System.Windows.Forms.TextBox()
        Me.txtTelefonoCliente = New System.Windows.Forms.TextBox()
        Me.txtDireccionCliente = New System.Windows.Forms.TextBox()
        Me.txtDniCliente = New System.Windows.Forms.TextBox()
        Me.hola = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'button2
        '
        Me.button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.button2.Location = New System.Drawing.Point(228, 305)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(75, 35)
        Me.button2.TabIndex = 13
        Me.button2.Text = "Cancelar"
        Me.button2.UseVisualStyleBackColor = False
        '
        'button1
        '
        Me.button1.AutoSize = True
        Me.button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.button1.Location = New System.Drawing.Point(59, 305)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(75, 35)
        Me.button1.TabIndex = 12
        Me.button1.Text = "Aceptar"
        Me.button1.UseVisualStyleBackColor = False
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.dtpCliente)
        Me.groupBox1.Controls.Add(Me.label6)
        Me.groupBox1.Controls.Add(Me.txtApellidoCliente)
        Me.groupBox1.Controls.Add(Me.txtTelefonoCliente)
        Me.groupBox1.Controls.Add(Me.txtDireccionCliente)
        Me.groupBox1.Controls.Add(Me.txtDniCliente)
        Me.groupBox1.Controls.Add(Me.hola)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.label5)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Location = New System.Drawing.Point(12, 23)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(343, 260)
        Me.groupBox1.TabIndex = 11
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Modificar Datos del Cliente"
        '
        'dtpCliente
        '
        Me.dtpCliente.Location = New System.Drawing.Point(135, 216)
        Me.dtpCliente.Name = "dtpCliente"
        Me.dtpCliente.Size = New System.Drawing.Size(200, 20)
        Me.dtpCliente.TabIndex = 11
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(29, 222)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(93, 13)
        Me.label6.TabIndex = 10
        Me.label6.Text = "Fecha Nacimiento"
        '
        'txtApellidoCliente
        '
        Me.txtApellidoCliente.AcceptsReturn = True
        Me.txtApellidoCliente.Location = New System.Drawing.Point(135, 60)
        Me.txtApellidoCliente.Name = "txtApellidoCliente"
        Me.txtApellidoCliente.Size = New System.Drawing.Size(118, 20)
        Me.txtApellidoCliente.TabIndex = 9
        '
        'txtTelefonoCliente
        '
        Me.txtTelefonoCliente.Location = New System.Drawing.Point(135, 180)
        Me.txtTelefonoCliente.Name = "txtTelefonoCliente"
        Me.txtTelefonoCliente.Size = New System.Drawing.Size(118, 20)
        Me.txtTelefonoCliente.TabIndex = 8
        '
        'txtDireccionCliente
        '
        Me.txtDireccionCliente.Location = New System.Drawing.Point(135, 139)
        Me.txtDireccionCliente.Name = "txtDireccionCliente"
        Me.txtDireccionCliente.Size = New System.Drawing.Size(118, 20)
        Me.txtDireccionCliente.TabIndex = 7
        '
        'txtDniCliente
        '
        Me.txtDniCliente.Location = New System.Drawing.Point(135, 99)
        Me.txtDniCliente.Name = "txtDniCliente"
        Me.txtDniCliente.Size = New System.Drawing.Size(118, 20)
        Me.txtDniCliente.TabIndex = 6
        '
        'hola
        '
        Me.hola.Location = New System.Drawing.Point(135, 24)
        Me.hola.Name = "hola"
        Me.hola.Size = New System.Drawing.Size(118, 20)
        Me.hola.TabIndex = 5
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(31, 63)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(44, 13)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Apellido"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(31, 102)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(26, 13)
        Me.label5.TabIndex = 4
        Me.label5.Text = "DNI"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(31, 32)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(44, 13)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Nombre"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(29, 183)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(49, 13)
        Me.label4.TabIndex = 3
        Me.label4.Text = "Telefono"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(31, 142)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(52, 13)
        Me.label3.TabIndex = 2
        Me.label3.Text = "Direccion"
        '
        'FrmModificarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 359)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.groupBox1)
        Me.Name = "FrmModificarCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmModificarCliente"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents button2 As Button
    Private WithEvents button1 As Button
    Private WithEvents groupBox1 As GroupBox
    Public WithEvents dtpCliente As DateTimePicker
    Private WithEvents label6 As Label
    Public WithEvents txtApellidoCliente As TextBox
    Public WithEvents txtTelefonoCliente As TextBox
    Public WithEvents txtDireccionCliente As TextBox
    Public WithEvents hola As TextBox
    Private WithEvents label2 As Label
    Private WithEvents label5 As Label
    Private WithEvents label1 As Label
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Public WithEvents txtDniCliente As TextBox
End Class
