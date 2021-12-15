<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.lblHora = New System.Windows.Forms.Label()
        Me.cmdDestinos = New System.Windows.Forms.Button()
        Me.cmdAcercaDe = New System.Windows.Forms.Button()
        Me.cmdLogin = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SkinEngine1 = New Sunisoft.IrisSkin.SkinEngine(CType(Me, System.ComponentModel.Component))
        Me.SuspendLayout()
        '
        'lblHora
        '
        Me.lblHora.BackColor = System.Drawing.Color.Black
        Me.lblHora.Font = New System.Drawing.Font("LCDMono2", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblHora.Location = New System.Drawing.Point(708, 166)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(168, 34)
        Me.lblHora.TabIndex = 4
        '
        'cmdDestinos
        '
        Me.cmdDestinos.BackColor = System.Drawing.Color.White
        Me.cmdDestinos.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed
        Me.cmdDestinos.FlatAppearance.BorderSize = 3
        Me.cmdDestinos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDestinos.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDestinos.Image = Global.SistemaTransporte.My.Resources.Resources.destinos11
        Me.cmdDestinos.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdDestinos.Location = New System.Drawing.Point(461, 102)
        Me.cmdDestinos.MaximumSize = New System.Drawing.Size(204, 158)
        Me.cmdDestinos.MinimumSize = New System.Drawing.Size(204, 138)
        Me.cmdDestinos.Name = "cmdDestinos"
        Me.cmdDestinos.Size = New System.Drawing.Size(204, 150)
        Me.cmdDestinos.TabIndex = 10
        Me.cmdDestinos.Text = "DESTINOS"
        Me.cmdDestinos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdDestinos.UseVisualStyleBackColor = False
        '
        'cmdAcercaDe
        '
        Me.cmdAcercaDe.BackColor = System.Drawing.Color.White
        Me.cmdAcercaDe.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed
        Me.cmdAcercaDe.FlatAppearance.BorderSize = 3
        Me.cmdAcercaDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAcercaDe.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAcercaDe.Image = Global.SistemaTransporte.My.Resources.Resources.acercadenuevo
        Me.cmdAcercaDe.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdAcercaDe.Location = New System.Drawing.Point(254, 102)
        Me.cmdAcercaDe.MaximumSize = New System.Drawing.Size(204, 150)
        Me.cmdAcercaDe.MinimumSize = New System.Drawing.Size(204, 138)
        Me.cmdAcercaDe.Name = "cmdAcercaDe"
        Me.cmdAcercaDe.Size = New System.Drawing.Size(204, 150)
        Me.cmdAcercaDe.TabIndex = 9
        Me.cmdAcercaDe.Text = "INFORMACION"
        Me.cmdAcercaDe.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdAcercaDe.UseVisualStyleBackColor = False
        '
        'cmdLogin
        '
        Me.cmdLogin.AutoSize = True
        Me.cmdLogin.BackColor = System.Drawing.Color.White
        Me.cmdLogin.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed
        Me.cmdLogin.FlatAppearance.BorderSize = 3
        Me.cmdLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdLogin.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLogin.Image = Global.SistemaTransporte.My.Resources.Resources.logeo001
        Me.cmdLogin.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdLogin.Location = New System.Drawing.Point(48, 102)
        Me.cmdLogin.MaximumSize = New System.Drawing.Size(204, 170)
        Me.cmdLogin.MinimumSize = New System.Drawing.Size(204, 138)
        Me.cmdLogin.Name = "cmdLogin"
        Me.cmdLogin.Size = New System.Drawing.Size(204, 150)
        Me.cmdLogin.TabIndex = 8
        Me.cmdLogin.Text = "LOGIN"
        Me.cmdLogin.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdLogin.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Image = Global.SistemaTransporte.My.Resources.Resources.trans
        Me.Label1.Location = New System.Drawing.Point(-2, 255)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(931, 344)
        Me.Label1.TabIndex = 1
        '
        'Timer1
        '
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.LightSlateGray
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label2.Font = New System.Drawing.Font("Imprint MT Shadow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(931, 54)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "SISTEMA TRASNPORTE"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SkinEngine1
        '
        Me.SkinEngine1.SerialNumber = "U4N2UjLguUZs33UR+Vy47JAZ81t2fjIFvut28vc5oHiVeivGb/NZMA=="
        Me.SkinEngine1.SkinFile = "D:\SistemaTransporte\SistemaTransporte\SistemaTransporte\Componentes Graficos Vb2" & _
    "\SKIN NET 2010 WIN 7\SkinVS.NET\Glass\GlassGreen.ssk"
        Me.SkinEngine1.SkinStreamMain = CType(resources.GetObject("SkinEngine1.SkinStreamMain"), System.IO.Stream)
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.BackgroundImage = Global.SistemaTransporte.My.Resources.Resources.wallpapers_negros_negro_azul_wallpaper
        Me.ClientSize = New System.Drawing.Size(931, 582)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdDestinos)
        Me.Controls.Add(Me.cmdAcercaDe)
        Me.Controls.Add(Me.cmdLogin)
        Me.Controls.Add(Me.lblHora)
        Me.Controls.Add(Me.Label1)
        Me.MaximumSize = New System.Drawing.Size(947, 620)
        Me.MinimumSize = New System.Drawing.Size(947, 572)
        Me.Name = "frmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMenu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblHora As System.Windows.Forms.Label
    Friend WithEvents cmdLogin As System.Windows.Forms.Button
    Friend WithEvents cmdAcercaDe As System.Windows.Forms.Button
    Friend WithEvents cmdDestinos As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SkinEngine1 As Sunisoft.IrisSkin.SkinEngine
End Class
