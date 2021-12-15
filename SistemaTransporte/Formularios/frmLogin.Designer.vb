<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.cmdLogin = New System.Windows.Forms.Button()
        Me.cmdCerrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(128, 159)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(185, 23)
        Me.txtPassword.TabIndex = 1
        '
        'txtUser
        '
        Me.txtUser.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.Location = New System.Drawing.Point(128, 97)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(185, 23)
        Me.txtUser.TabIndex = 2
        '
        'cmdLogin
        '
        Me.cmdLogin.FlatAppearance.BorderSize = 0
        Me.cmdLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.cmdLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.cmdLogin.Image = Global.SistemaTransporte.My.Resources.Resources.boton_login
        Me.cmdLogin.Location = New System.Drawing.Point(214, 213)
        Me.cmdLogin.MaximumSize = New System.Drawing.Size(120, 41)
        Me.cmdLogin.MinimumSize = New System.Drawing.Size(118, 39)
        Me.cmdLogin.Name = "cmdLogin"
        Me.cmdLogin.Size = New System.Drawing.Size(118, 39)
        Me.cmdLogin.TabIndex = 3
        Me.cmdLogin.UseVisualStyleBackColor = True
        '
        'cmdCerrar
        '
        Me.cmdCerrar.BackColor = System.Drawing.Color.Black
        Me.cmdCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCerrar.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.cmdCerrar.FlatAppearance.BorderSize = 2
        Me.cmdCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCerrar.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCerrar.ForeColor = System.Drawing.Color.Red
        Me.cmdCerrar.Location = New System.Drawing.Point(463, 5)
        Me.cmdCerrar.MaximumSize = New System.Drawing.Size(48, 33)
        Me.cmdCerrar.MinimumSize = New System.Drawing.Size(44, 28)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(44, 31)
        Me.cmdCerrar.TabIndex = 4
        Me.cmdCerrar.Text = "X"
        Me.cmdCerrar.UseVisualStyleBackColor = False
        '
        'frmLogin
        '
        Me.AcceptButton = Me.cmdLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SistemaTransporte.My.Resources.Resources.loginacceso
        Me.CancelButton = Me.cmdCerrar
        Me.ClientSize = New System.Drawing.Size(517, 273)
        Me.Controls.Add(Me.cmdCerrar)
        Me.Controls.Add(Me.cmdLogin)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.txtPassword)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(517, 273)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(517, 273)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TransparencyKey = System.Drawing.SystemColors.Control
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents cmdLogin As System.Windows.Forms.Button
    Friend WithEvents cmdCerrar As System.Windows.Forms.Button

End Class
