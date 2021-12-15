<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRepostesClientes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.crClientes = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'crClientes
        '
        Me.crClientes.ActiveViewIndex = -1
        Me.crClientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crClientes.Cursor = System.Windows.Forms.Cursors.Default
        Me.crClientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crClientes.Location = New System.Drawing.Point(0, 0)
        Me.crClientes.Name = "crClientes"
        Me.crClientes.Size = New System.Drawing.Size(1028, 521)
        Me.crClientes.TabIndex = 0
        '
        'frmRepostesClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 521)
        Me.Controls.Add(Me.crClientes)
        Me.Name = "frmRepostesClientes"
        Me.Text = "frmRepostesClientes"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crClientes As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
