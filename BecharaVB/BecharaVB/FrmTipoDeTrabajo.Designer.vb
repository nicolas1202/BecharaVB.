<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTipoDeTrabajo
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
        Me.comboBox2 = New System.Windows.Forms.ComboBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.textBox2 = New System.Windows.Forms.TextBox()
        Me.button3 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.listBox1 = New System.Windows.Forms.ListBox()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'comboBox2
        '
        Me.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBox2.FormattingEnabled = True
        Me.comboBox2.Items.AddRange(New Object() {"Nombre", "Categoria"})
        Me.comboBox2.Location = New System.Drawing.Point(326, 26)
        Me.comboBox2.Name = "comboBox2"
        Me.comboBox2.Size = New System.Drawing.Size(161, 21)
        Me.comboBox2.TabIndex = 23
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(270, 29)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(56, 13)
        Me.label3.TabIndex = 26
        Me.label3.Text = "Filtrar por :"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(36, 26)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(40, 13)
        Me.label4.TabIndex = 25
        Me.label4.Text = "Buscar"
        '
        'textBox2
        '
        Me.textBox2.Location = New System.Drawing.Point(85, 26)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(156, 20)
        Me.textBox2.TabIndex = 24
        '
        'button3
        '
        Me.button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.button3.Location = New System.Drawing.Point(508, 383)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(75, 32)
        Me.button3.TabIndex = 22
        Me.button3.Text = "Eliminar"
        Me.button3.UseVisualStyleBackColor = False
        '
        'button2
        '
        Me.button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.button2.Location = New System.Drawing.Point(407, 383)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(75, 32)
        Me.button2.TabIndex = 21
        Me.button2.Text = "Modificar"
        Me.button2.UseVisualStyleBackColor = False
        '
        'button1
        '
        Me.button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.button1.Location = New System.Drawing.Point(308, 383)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(75, 32)
        Me.button1.TabIndex = 19
        Me.button1.Text = "Agregar"
        Me.button1.UseVisualStyleBackColor = False
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.listBox1)
        Me.groupBox1.Location = New System.Drawing.Point(27, 82)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(586, 276)
        Me.groupBox1.TabIndex = 20
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Clientes"
        '
        'listBox1
        '
        Me.listBox1.FormattingEnabled = True
        Me.listBox1.Location = New System.Drawing.Point(30, 19)
        Me.listBox1.Name = "listBox1"
        Me.listBox1.Size = New System.Drawing.Size(522, 225)
        Me.listBox1.TabIndex = 0
        '
        'FrmTipoDeTrabajo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 440)
        Me.Controls.Add(Me.comboBox2)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.textBox2)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.groupBox1)
        Me.Name = "FrmTipoDeTrabajo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmTipoDeTrabajo"
        Me.groupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents comboBox2 As ComboBox
    Private WithEvents label3 As Label
    Private WithEvents label4 As Label
    Private WithEvents textBox2 As TextBox
    Private WithEvents button3 As Button
    Private WithEvents button2 As Button
    Private WithEvents button1 As Button
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents listBox1 As ListBox
End Class
