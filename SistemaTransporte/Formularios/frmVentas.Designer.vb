<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVentas))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CLIENTESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BUSCARCLIENTEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MANTENEDORCLIENTEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VENTASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FACTURACIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REPORTESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TARIFASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.INFORMACIONDETARIFASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DESTINOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MANTENEDORDEDESTINOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.sbUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.sbHora = New System.Windows.Forms.ToolStripStatusLabel()
        Me.sbFecha = New System.Windows.Forms.ToolStripStatusLabel()
        Me.sbFechas = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtuser = New System.Windows.Forms.TextBox()
        Me.SkinEngine1 = New Sunisoft.IrisSkin.SkinEngine(CType(Me, System.ComponentModel.Component))
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CLIENTESToolStripMenuItem, Me.VENTASToolStripMenuItem, Me.TARIFASToolStripMenuItem, Me.DESTINOSToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1164, 25)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CLIENTESToolStripMenuItem
        '
        Me.CLIENTESToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BUSCARCLIENTEToolStripMenuItem, Me.MANTENEDORCLIENTEToolStripMenuItem})
        Me.CLIENTESToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CLIENTESToolStripMenuItem.ForeColor = System.Drawing.Color.MediumBlue
        Me.CLIENTESToolStripMenuItem.Image = Global.SistemaTransporte.My.Resources.Resources.CLIENTE1
        Me.CLIENTESToolStripMenuItem.Name = "CLIENTESToolStripMenuItem"
        Me.CLIENTESToolStripMenuItem.Size = New System.Drawing.Size(94, 21)
        Me.CLIENTESToolStripMenuItem.Text = "CLIENTES"
        '
        'BUSCARCLIENTEToolStripMenuItem
        '
        Me.BUSCARCLIENTEToolStripMenuItem.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BUSCARCLIENTEToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.BUSCARCLIENTEToolStripMenuItem.Image = Global.SistemaTransporte.My.Resources.Resources.Sign_In_24x24_32
        Me.BUSCARCLIENTEToolStripMenuItem.Name = "BUSCARCLIENTEToolStripMenuItem"
        Me.BUSCARCLIENTEToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.BUSCARCLIENTEToolStripMenuItem.Text = "INFORMACION CLIENTE"
        '
        'MANTENEDORCLIENTEToolStripMenuItem
        '
        Me.MANTENEDORCLIENTEToolStripMenuItem.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MANTENEDORCLIENTEToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.MANTENEDORCLIENTEToolStripMenuItem.Image = Global.SistemaTransporte.My.Resources.Resources.Customize_48x48_32
        Me.MANTENEDORCLIENTEToolStripMenuItem.Name = "MANTENEDORCLIENTEToolStripMenuItem"
        Me.MANTENEDORCLIENTEToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.MANTENEDORCLIENTEToolStripMenuItem.Text = "MANTENEDOR CLIENTE"
        '
        'VENTASToolStripMenuItem
        '
        Me.VENTASToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FACTURACIONToolStripMenuItem, Me.REPORTESToolStripMenuItem})
        Me.VENTASToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VENTASToolStripMenuItem.ForeColor = System.Drawing.Color.MediumBlue
        Me.VENTASToolStripMenuItem.Image = Global.SistemaTransporte.My.Resources.Resources.Shopping_cart_24x24_321
        Me.VENTASToolStripMenuItem.Name = "VENTASToolStripMenuItem"
        Me.VENTASToolStripMenuItem.Size = New System.Drawing.Size(86, 21)
        Me.VENTASToolStripMenuItem.Text = "VENTAS"
        '
        'FACTURACIONToolStripMenuItem
        '
        Me.FACTURACIONToolStripMenuItem.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FACTURACIONToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.FACTURACIONToolStripMenuItem.Image = Global.SistemaTransporte.My.Resources.Resources.VENDER1
        Me.FACTURACIONToolStripMenuItem.Name = "FACTURACIONToolStripMenuItem"
        Me.FACTURACIONToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.FACTURACIONToolStripMenuItem.Text = "VENDER PASAJE"
        '
        'REPORTESToolStripMenuItem
        '
        Me.REPORTESToolStripMenuItem.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REPORTESToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.REPORTESToolStripMenuItem.Image = Global.SistemaTransporte.My.Resources.Resources.Folder_48x48_32
        Me.REPORTESToolStripMenuItem.Name = "REPORTESToolStripMenuItem"
        Me.REPORTESToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.REPORTESToolStripMenuItem.Text = "REPORTES"
        '
        'TARIFASToolStripMenuItem
        '
        Me.TARIFASToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.INFORMACIONDETARIFASToolStripMenuItem})
        Me.TARIFASToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TARIFASToolStripMenuItem.ForeColor = System.Drawing.Color.MediumBlue
        Me.TARIFASToolStripMenuItem.Image = Global.SistemaTransporte.My.Resources.Resources.tarifas
        Me.TARIFASToolStripMenuItem.Name = "TARIFASToolStripMenuItem"
        Me.TARIFASToolStripMenuItem.Size = New System.Drawing.Size(88, 21)
        Me.TARIFASToolStripMenuItem.Text = "TARIFAS"
        '
        'INFORMACIONDETARIFASToolStripMenuItem
        '
        Me.INFORMACIONDETARIFASToolStripMenuItem.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.INFORMACIONDETARIFASToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.INFORMACIONDETARIFASToolStripMenuItem.Name = "INFORMACIONDETARIFASToolStripMenuItem"
        Me.INFORMACIONDETARIFASToolStripMenuItem.Size = New System.Drawing.Size(245, 22)
        Me.INFORMACIONDETARIFASToolStripMenuItem.Text = "INFORMACION  DE TARIFAS"
        '
        'DESTINOSToolStripMenuItem
        '
        Me.DESTINOSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MANTENEDORDEDESTINOSToolStripMenuItem})
        Me.DESTINOSToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DESTINOSToolStripMenuItem.ForeColor = System.Drawing.Color.MediumBlue
        Me.DESTINOSToolStripMenuItem.Name = "DESTINOSToolStripMenuItem"
        Me.DESTINOSToolStripMenuItem.Size = New System.Drawing.Size(83, 21)
        Me.DESTINOSToolStripMenuItem.Text = "DESTINOS"
        '
        'MANTENEDORDEDESTINOSToolStripMenuItem
        '
        Me.MANTENEDORDEDESTINOSToolStripMenuItem.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MANTENEDORDEDESTINOSToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.MANTENEDORDEDESTINOSToolStripMenuItem.Image = Global.SistemaTransporte.My.Resources.Resources.destino
        Me.MANTENEDORDEDESTINOSToolStripMenuItem.Name = "MANTENEDORDEDESTINOSToolStripMenuItem"
        Me.MANTENEDORDEDESTINOSToolStripMenuItem.Size = New System.Drawing.Size(251, 22)
        Me.MANTENEDORDEDESTINOSToolStripMenuItem.Text = "MANTENEDOR DE DESTINOS"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.StatusStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Document)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sbUsuario, Me.sbHora, Me.sbFecha, Me.sbFechas, Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 418)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1164, 26)
        Me.StatusStrip1.TabIndex = 3
        '
        'sbUsuario
        '
        Me.sbUsuario.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sbUsuario.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.sbUsuario.Name = "sbUsuario"
        Me.sbUsuario.Size = New System.Drawing.Size(508, 21)
        Me.sbUsuario.Text = "                                                                                 " & _
    "                                            "
        '
        'sbHora
        '
        Me.sbHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sbHora.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.sbHora.Name = "sbHora"
        Me.sbHora.Size = New System.Drawing.Size(195, 21)
        Me.sbHora.Text = "                         HORA :         "
        '
        'sbFecha
        '
        Me.sbFecha.Name = "sbFecha"
        Me.sbFecha.Size = New System.Drawing.Size(0, 21)
        '
        'sbFechas
        '
        Me.sbFechas.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sbFechas.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.sbFechas.Name = "sbFechas"
        Me.sbFechas.Size = New System.Drawing.Size(225, 21)
        Me.sbFechas.Text = "                                                      FECHA : "
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 21)
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel2.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(312, 21)
        Me.ToolStripStatusLabel2.Text = "                                                       VENDEDOR"
        '
        'Timer1
        '
        '
        'txtuser
        '
        Me.txtuser.Location = New System.Drawing.Point(1034, 422)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(10, 20)
        Me.txtuser.TabIndex = 7
        '
        'SkinEngine1
        '
        Me.SkinEngine1.SerialNumber = "U4N2UjLguUZs33UR+Vy47JAZ81t2fjIFvut28vc5oHiVeivGb/NZMA=="
        Me.SkinEngine1.SkinFile = "D:\PROGRAMACION ORIENTADA A OBJETOS 2\PROYECTO\SistemaTransporte\SistemaTransport" & _
    "e\Componentes Graficos Vb2\SKIN NET 2010 WIN 7\SkinVS.NET\Wave\WaveColor2.ssk"
        Me.SkinEngine1.SkinStreamMain = CType(resources.GetObject("SkinEngine1.SkinStreamMain"), System.IO.Stream)
        '
        'frmVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SistemaTransporte.My.Resources.Resources.azul_ventas2
        Me.ClientSize = New System.Drawing.Size(1164, 444)
        Me.Controls.Add(Me.txtuser)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmVentas"
        Me.Text = "frmPrincipal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CLIENTESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BUSCARCLIENTEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MANTENEDORCLIENTEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VENTASToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FACTURACIONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents REPORTESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TARIFASToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents INFORMACIONDETARIFASToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents sbHora As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents sbFecha As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents DESTINOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MANTENEDORDEDESTINOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents sbFechas As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtuser As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents sbUsuario As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents SkinEngine1 As Sunisoft.IrisSkin.SkinEngine
End Class
