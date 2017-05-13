<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTurnos
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
        Me.listView1 = New System.Windows.Forms.ListView()
        Me.monthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.SuspendLayout()
        '
        'listView1
        '
        Me.listView1.Location = New System.Drawing.Point(264, 77)
        Me.listView1.Name = "listView1"
        Me.listView1.Size = New System.Drawing.Size(417, 162)
        Me.listView1.TabIndex = 3
        Me.listView1.UseCompatibleStateImageBehavior = False
        '
        'monthCalendar1
        '
        Me.monthCalendar1.Location = New System.Drawing.Point(25, 77)
        Me.monthCalendar1.Name = "monthCalendar1"
        Me.monthCalendar1.TabIndex = 2
        '
        'FrmTurnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(713, 331)
        Me.Controls.Add(Me.listView1)
        Me.Controls.Add(Me.monthCalendar1)
        Me.Name = "FrmTurnos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmTurnos"
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents listView1 As ListView
    Private WithEvents monthCalendar1 As MonthCalendar
End Class
