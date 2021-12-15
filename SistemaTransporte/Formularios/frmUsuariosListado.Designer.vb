<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuariosListado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsuariosListado))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdAgregar = New System.Windows.Forms.Button()
        Me.cmdEditar = New System.Windows.Forms.Button()
        Me.cmdDesactivar = New System.Windows.Forms.Button()
        Me.SkinEngine1 = New Sunisoft.IrisSkin.SkinEngine(CType(Me, System.ComponentModel.Component))
        Me.gbEditar = New System.Windows.Forms.GroupBox()
        Me.txtCodigoUsuario = New System.Windows.Forms.TextBox()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboSexo = New System.Windows.Forms.ComboBox()
        Me.dtpFechaN = New System.Windows.Forms.DateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtApellidoMaterno = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtApellidoPaterno = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboUsuarios = New System.Windows.Forms.ComboBox()
        Me.gbLista = New System.Windows.Forms.GroupBox()
        Me.lvUsuarios = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox2.SuspendLayout()
        Me.gbEditar.SuspendLayout()
        Me.gbLista.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.cmdAgregar)
        Me.GroupBox2.Controls.Add(Me.cmdEditar)
        Me.GroupBox2.Controls.Add(Me.cmdDesactivar)
        Me.GroupBox2.Location = New System.Drawing.Point(475, 22)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(383, 116)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "OPCIONES"
        '
        'cmdAgregar
        '
        Me.cmdAgregar.AutoEllipsis = True
        Me.cmdAgregar.BackColor = System.Drawing.Color.Navy
        Me.cmdAgregar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmdAgregar.FlatAppearance.BorderSize = 3
        Me.cmdAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAgregar.ForeColor = System.Drawing.Color.White
        Me.cmdAgregar.Image = Global.SistemaTransporte.My.Resources.Resources.agregarUsuario
        Me.cmdAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdAgregar.Location = New System.Drawing.Point(18, 19)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(110, 79)
        Me.cmdAgregar.TabIndex = 5
        Me.cmdAgregar.Text = "AGREGAR"
        Me.cmdAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdAgregar.UseVisualStyleBackColor = False
        '
        'cmdEditar
        '
        Me.cmdEditar.AutoEllipsis = True
        Me.cmdEditar.BackColor = System.Drawing.Color.Navy
        Me.cmdEditar.Enabled = False
        Me.cmdEditar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmdEditar.FlatAppearance.BorderSize = 3
        Me.cmdEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEditar.ForeColor = System.Drawing.Color.White
        Me.cmdEditar.Image = Global.SistemaTransporte.My.Resources.Resources.editar1
        Me.cmdEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdEditar.Location = New System.Drawing.Point(134, 19)
        Me.cmdEditar.Name = "cmdEditar"
        Me.cmdEditar.Size = New System.Drawing.Size(110, 79)
        Me.cmdEditar.TabIndex = 4
        Me.cmdEditar.Text = "EDITAR"
        Me.cmdEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdEditar.UseVisualStyleBackColor = False
        '
        'cmdDesactivar
        '
        Me.cmdDesactivar.AutoEllipsis = True
        Me.cmdDesactivar.BackColor = System.Drawing.Color.Navy
        Me.cmdDesactivar.Enabled = False
        Me.cmdDesactivar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmdDesactivar.FlatAppearance.BorderSize = 3
        Me.cmdDesactivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDesactivar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDesactivar.ForeColor = System.Drawing.Color.White
        Me.cmdDesactivar.Image = Global.SistemaTransporte.My.Resources.Resources.desac01
        Me.cmdDesactivar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdDesactivar.Location = New System.Drawing.Point(250, 19)
        Me.cmdDesactivar.Name = "cmdDesactivar"
        Me.cmdDesactivar.Size = New System.Drawing.Size(110, 79)
        Me.cmdDesactivar.TabIndex = 3
        Me.cmdDesactivar.Text = "DESACTIVAR"
        Me.cmdDesactivar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdDesactivar.UseVisualStyleBackColor = False
        '
        'SkinEngine1
        '
        Me.SkinEngine1.SerialNumber = "U4N2UjLguUZs33UR+Vy47JAZ81t2fjIFvut28vc5oHiVeivGb/NZMA=="
        Me.SkinEngine1.SkinFile = "D:\SistemaTransporte\SistemaTransporte\SistemaTransporte\Componentes Graficos Vb2" & _
    "\SKIN NET 2010 WIN 7\SkinVS.NET\Emerald\Emerald.ssk"
        Me.SkinEngine1.SkinStreamMain = CType(resources.GetObject("SkinEngine1.SkinStreamMain"), System.IO.Stream)
        '
        'gbEditar
        '
        Me.gbEditar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbEditar.BackColor = System.Drawing.SystemColors.Control
        Me.gbEditar.Controls.Add(Me.GroupBox1)
        Me.gbEditar.Controls.Add(Me.txtCodigoUsuario)
        Me.gbEditar.Controls.Add(Me.cmdCancelar)
        Me.gbEditar.Controls.Add(Me.cboSexo)
        Me.gbEditar.Controls.Add(Me.dtpFechaN)
        Me.gbEditar.Controls.Add(Me.Label17)
        Me.gbEditar.Controls.Add(Me.Label16)
        Me.gbEditar.Controls.Add(Me.txtApellidoMaterno)
        Me.gbEditar.Controls.Add(Me.txtEmail)
        Me.gbEditar.Controls.Add(Me.Label15)
        Me.gbEditar.Controls.Add(Me.Label8)
        Me.gbEditar.Controls.Add(Me.txtApellidoPaterno)
        Me.gbEditar.Controls.Add(Me.Label2)
        Me.gbEditar.Controls.Add(Me.txtDNI)
        Me.gbEditar.Controls.Add(Me.txtNombre)
        Me.gbEditar.Controls.Add(Me.txtDireccion)
        Me.gbEditar.Controls.Add(Me.txtTelefono)
        Me.gbEditar.Controls.Add(Me.Label7)
        Me.gbEditar.Controls.Add(Me.Label6)
        Me.gbEditar.Controls.Add(Me.Label4)
        Me.gbEditar.Controls.Add(Me.Label3)
        Me.gbEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbEditar.ForeColor = System.Drawing.Color.MediumBlue
        Me.gbEditar.Location = New System.Drawing.Point(12, 146)
        Me.gbEditar.Name = "gbEditar"
        Me.gbEditar.Size = New System.Drawing.Size(877, 385)
        Me.gbEditar.TabIndex = 112
        Me.gbEditar.TabStop = False
        Me.gbEditar.Text = "DATOS"
        Me.gbEditar.Visible = False
        '
        'txtCodigoUsuario
        '
        Me.txtCodigoUsuario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCodigoUsuario.Location = New System.Drawing.Point(728, 22)
        Me.txtCodigoUsuario.Name = "txtCodigoUsuario"
        Me.txtCodigoUsuario.Size = New System.Drawing.Size(143, 20)
        Me.txtCodigoUsuario.TabIndex = 132
        Me.txtCodigoUsuario.Visible = False
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCancelar.Font = New System.Drawing.Font("Neo Gen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Location = New System.Drawing.Point(757, 342)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(114, 39)
        Me.cmdCancelar.TabIndex = 131
        Me.cmdCancelar.Text = "CANCELAR"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        Me.cmdCancelar.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(7, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 130
        Me.Label1.Text = "TIPO USUARIO"
        '
        'cboSexo
        '
        Me.cboSexo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboSexo.BackColor = System.Drawing.SystemColors.Control
        Me.cboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSexo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboSexo.FormattingEnabled = True
        Me.cboSexo.Items.AddRange(New Object() {"M", "F"})
        Me.cboSexo.Location = New System.Drawing.Point(258, 308)
        Me.cboSexo.Name = "cboSexo"
        Me.cboSexo.Size = New System.Drawing.Size(59, 21)
        Me.cboSexo.TabIndex = 129
        '
        'dtpFechaN
        '
        Me.dtpFechaN.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpFechaN.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaN.CalendarTitleForeColor = System.Drawing.Color.Maroon
        Me.dtpFechaN.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaN.Location = New System.Drawing.Point(257, 282)
        Me.dtpFechaN.Name = "dtpFechaN"
        Me.dtpFechaN.Size = New System.Drawing.Size(204, 20)
        Me.dtpFechaN.TabIndex = 127
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Navy
        Me.Label17.Location = New System.Drawing.Point(92, 282)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(128, 13)
        Me.Label17.TabIndex = 126
        Me.Label17.Text = "FECHA NACIMIENTO"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Navy
        Me.Label16.Location = New System.Drawing.Point(92, 173)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(132, 13)
        Me.Label16.TabIndex = 125
        Me.Label16.Text = "APELLIDO MATERNO"
        '
        'txtApellidoMaterno
        '
        Me.txtApellidoMaterno.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtApellidoMaterno.Location = New System.Drawing.Point(257, 169)
        Me.txtApellidoMaterno.Name = "txtApellidoMaterno"
        Me.txtApellidoMaterno.Size = New System.Drawing.Size(204, 20)
        Me.txtApellidoMaterno.TabIndex = 124
        '
        'txtEmail
        '
        Me.txtEmail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEmail.Location = New System.Drawing.Point(257, 251)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(204, 20)
        Me.txtEmail.TabIndex = 123
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Navy
        Me.Label15.Location = New System.Drawing.Point(97, 253)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(48, 13)
        Me.Label15.TabIndex = 122
        Me.Label15.Text = "E-MAIL"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(92, 313)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 121
        Me.Label8.Text = "SEXO"
        '
        'txtApellidoPaterno
        '
        Me.txtApellidoPaterno.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtApellidoPaterno.Location = New System.Drawing.Point(257, 140)
        Me.txtApellidoPaterno.Name = "txtApellidoPaterno"
        Me.txtApellidoPaterno.Size = New System.Drawing.Size(218, 20)
        Me.txtApellidoPaterno.TabIndex = 120
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(94, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 13)
        Me.Label2.TabIndex = 119
        Me.Label2.Text = "APELLIDO PATERNO"
        '
        'txtDNI
        '
        Me.txtDNI.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDNI.Location = New System.Drawing.Point(257, 83)
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(204, 20)
        Me.txtDNI.TabIndex = 118
        '
        'txtNombre
        '
        Me.txtNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombre.Location = New System.Drawing.Point(257, 112)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(278, 20)
        Me.txtNombre.TabIndex = 117
        '
        'txtDireccion
        '
        Me.txtDireccion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDireccion.Location = New System.Drawing.Point(257, 197)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(278, 20)
        Me.txtDireccion.TabIndex = 116
        '
        'txtTelefono
        '
        Me.txtTelefono.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTelefono.Location = New System.Drawing.Point(257, 223)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(204, 20)
        Me.txtTelefono.TabIndex = 115
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(97, 87)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 13)
        Me.Label7.TabIndex = 114
        Me.Label7.Text = "DNI"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(97, 117)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 113
        Me.Label6.Text = "NOMBRES"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(92, 200)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 112
        Me.Label4.Text = "DIRECCION"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(92, 227)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 111
        Me.Label3.Text = "TELEFONO"
        '
        'cboUsuarios
        '
        Me.cboUsuarios.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboUsuarios.BackColor = System.Drawing.SystemColors.Control
        Me.cboUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboUsuarios.FormattingEnabled = True
        Me.cboUsuarios.Location = New System.Drawing.Point(168, 19)
        Me.cboUsuarios.Name = "cboUsuarios"
        Me.cboUsuarios.Size = New System.Drawing.Size(204, 21)
        Me.cboUsuarios.TabIndex = 110
        '
        'gbLista
        '
        Me.gbLista.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbLista.Controls.Add(Me.lvUsuarios)
        Me.gbLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbLista.ForeColor = System.Drawing.Color.Blue
        Me.gbLista.Location = New System.Drawing.Point(12, 146)
        Me.gbLista.Name = "gbLista"
        Me.gbLista.Size = New System.Drawing.Size(877, 390)
        Me.gbLista.TabIndex = 131
        Me.gbLista.TabStop = False
        Me.gbLista.Text = "Usuarios"
        '
        'lvUsuarios
        '
        Me.lvUsuarios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvUsuarios.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.lvUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvUsuarios.ForeColor = System.Drawing.SystemColors.GrayText
        Me.lvUsuarios.FullRowSelect = True
        Me.lvUsuarios.GridLines = True
        Me.lvUsuarios.Location = New System.Drawing.Point(7, 21)
        Me.lvUsuarios.Name = "lvUsuarios"
        Me.lvUsuarios.Size = New System.Drawing.Size(865, 354)
        Me.lvUsuarios.TabIndex = 0
        Me.lvUsuarios.UseCompatibleStateImageBehavior = False
        Me.lvUsuarios.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "CODIGO"
        Me.ColumnHeader1.Width = 104
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "NOMBRE Y APELLIDO"
        Me.ColumnHeader2.Width = 175
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "DNI"
        Me.ColumnHeader3.Width = 148
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "USUARIO"
        Me.ColumnHeader5.Width = 130
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "PASSWORD"
        Me.ColumnHeader6.Width = 126
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Algerian", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(22, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(274, 30)
        Me.Label5.TabIndex = 132
        Me.Label5.Text = "USUARIOS"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboUsuarios)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(90, 18)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(383, 56)
        Me.GroupBox1.TabIndex = 133
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de acceso"
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "TIPO USUARIO"
        '
        'frmUsuariosListado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(901, 556)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.gbEditar)
        Me.Controls.Add(Me.gbLista)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmUsuariosListado"
        Me.Text = "frmUsuariosListado"
        Me.GroupBox2.ResumeLayout(False)
        Me.gbEditar.ResumeLayout(False)
        Me.gbEditar.PerformLayout()
        Me.gbLista.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdAgregar As System.Windows.Forms.Button
    Friend WithEvents cmdEditar As System.Windows.Forms.Button
    Friend WithEvents cmdDesactivar As System.Windows.Forms.Button
    Friend WithEvents SkinEngine1 As Sunisoft.IrisSkin.SkinEngine
    Friend WithEvents gbEditar As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboSexo As System.Windows.Forms.ComboBox
    Friend WithEvents dtpFechaN As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtApellidoMaterno As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtApellidoPaterno As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDNI As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboUsuarios As System.Windows.Forms.ComboBox
    Friend WithEvents gbLista As System.Windows.Forms.GroupBox
    Friend WithEvents lvUsuarios As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCodigoUsuario As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
End Class
