<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAuto
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
        Me.button3 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.comboBox1 = New System.Windows.Forms.ComboBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.listBox1 = New System.Windows.Forms.ListBox()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'button3
        '
        Me.button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.button3.Location = New System.Drawing.Point(496, 368)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(75, 32)
        Me.button3.TabIndex = 22
        Me.button3.Text = "Eliminar"
        Me.button3.UseVisualStyleBackColor = False
        '
        'button2
        '
        Me.button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.button2.Location = New System.Drawing.Point(395, 368)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(75, 32)
        Me.button2.TabIndex = 21
        Me.button2.Text = "Modificar"
        Me.button2.UseVisualStyleBackColor = False
        '
        'button1
        '
        Me.button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.button1.Location = New System.Drawing.Point(286, 368)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(75, 32)
        Me.button1.TabIndex = 20
        Me.button1.Text = "Agregar"
        Me.button1.UseVisualStyleBackColor = False
        '
        'comboBox1
        '
        Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBox1.FormattingEnabled = True
        Me.comboBox1.Items.AddRange(New Object() {"Matricula", "Modelo", "Cliente"})
        Me.comboBox1.Location = New System.Drawing.Point(375, 33)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(161, 21)
        Me.comboBox1.TabIndex = 16
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(313, 39)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(56, 13)
        Me.label2.TabIndex = 19
        Me.label2.Text = "Filtrar por :"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(79, 36)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(40, 13)
        Me.label1.TabIndex = 18
        Me.label1.Text = "Buscar"
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(128, 36)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(156, 20)
        Me.textBox1.TabIndex = 17
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.listBox1)
        Me.groupBox1.Location = New System.Drawing.Point(32, 73)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(572, 279)
        Me.groupBox1.TabIndex = 15
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Vehiculos"
        '
        'listBox1
        '
        Me.listBox1.FormattingEnabled = True
        Me.listBox1.Location = New System.Drawing.Point(30, 31)
        Me.listBox1.Name = "listBox1"
        Me.listBox1.Size = New System.Drawing.Size(522, 225)
        Me.listBox1.TabIndex = 0
        '
        'FrmAuto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 417)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.comboBox1)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.groupBox1)
        Me.Name = "FrmAuto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmAuto"
        Me.groupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents button3 As Button
    Private WithEvents button2 As Button
    Private WithEvents button1 As Button
    Private WithEvents comboBox1 As ComboBox
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents textBox1 As TextBox
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents listBox1 As ListBox
End Class
