<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBoletosVentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBoletosVentas))
        Me.gbDatos = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnTarifa = New System.Windows.Forms.Button()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtCodigoBoleta = New System.Windows.Forms.TextBox()
        Me.txtVendedor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdBuscarCliente = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTarifa = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtCodigoBus = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNumeroAsiento = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboDestino = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtHoraSalida = New System.Windows.Forms.TextBox()
        Me.dtpFechaViaje = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPasajero = New System.Windows.Forms.TextBox()
        Me.cboOrigen = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblSutTotal = New System.Windows.Forms.Label()
        Me.SkinEngine1 = New Sunisoft.IrisSkin.SkinEngine(CType(Me, System.ComponentModel.Component))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.cmdAgregar = New System.Windows.Forms.Button()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblNumeroSerie = New System.Windows.Forms.Label()
        Me.lblNumeroBoleta = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtCargoAdicional = New System.Windows.Forms.TextBox()
        Me.gbDatos.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbDatos
        '
        Me.gbDatos.Controls.Add(Me.Label12)
        Me.gbDatos.Controls.Add(Me.btnTarifa)
        Me.gbDatos.Controls.Add(Me.Label23)
        Me.gbDatos.Controls.Add(Me.txtCodigoBoleta)
        Me.gbDatos.Controls.Add(Me.txtVendedor)
        Me.gbDatos.Controls.Add(Me.Label2)
        Me.gbDatos.Controls.Add(Me.cmdBuscarCliente)
        Me.gbDatos.Controls.Add(Me.Label5)
        Me.gbDatos.Controls.Add(Me.txtTarifa)
        Me.gbDatos.Controls.Add(Me.Label13)
        Me.gbDatos.Controls.Add(Me.txtCodigoBus)
        Me.gbDatos.Controls.Add(Me.Label10)
        Me.gbDatos.Controls.Add(Me.txtDNI)
        Me.gbDatos.Controls.Add(Me.Label9)
        Me.gbDatos.Controls.Add(Me.txtNumeroAsiento)
        Me.gbDatos.Controls.Add(Me.Label8)
        Me.gbDatos.Controls.Add(Me.cboDestino)
        Me.gbDatos.Controls.Add(Me.Label7)
        Me.gbDatos.Controls.Add(Me.Label6)
        Me.gbDatos.Controls.Add(Me.txtHoraSalida)
        Me.gbDatos.Controls.Add(Me.dtpFechaViaje)
        Me.gbDatos.Controls.Add(Me.Label4)
        Me.gbDatos.Controls.Add(Me.txtPasajero)
        Me.gbDatos.Controls.Add(Me.cboOrigen)
        Me.gbDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDatos.ForeColor = System.Drawing.Color.Blue
        Me.gbDatos.Location = New System.Drawing.Point(43, 123)
        Me.gbDatos.Name = "gbDatos"
        Me.gbDatos.Size = New System.Drawing.Size(760, 165)
        Me.gbDatos.TabIndex = 8
        Me.gbDatos.TabStop = False
        Me.gbDatos.Text = "DATOS"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(250, 23)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 15)
        Me.Label12.TabIndex = 47
        Me.Label12.Text = "Vendedor"
        '
        'btnTarifa
        '
        Me.btnTarifa.AutoSize = True
        Me.btnTarifa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTarifa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTarifa.ForeColor = System.Drawing.Color.Navy
        Me.btnTarifa.Location = New System.Drawing.Point(482, 135)
        Me.btnTarifa.Name = "btnTarifa"
        Me.btnTarifa.Size = New System.Drawing.Size(65, 27)
        Me.btnTarifa.TabIndex = 46
        Me.btnTarifa.Text = "TARIFA"
        Me.btnTarifa.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(478, 22)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(84, 15)
        Me.Label23.TabIndex = 45
        Me.Label23.Text = "Codigo Boleta"
        '
        'txtCodigoBoleta
        '
        Me.txtCodigoBoleta.Enabled = False
        Me.txtCodigoBoleta.Location = New System.Drawing.Point(570, 20)
        Me.txtCodigoBoleta.Name = "txtCodigoBoleta"
        Me.txtCodigoBoleta.Size = New System.Drawing.Size(90, 21)
        Me.txtCodigoBoleta.TabIndex = 44
        '
        'txtVendedor
        '
        Me.txtVendedor.Enabled = False
        Me.txtVendedor.Location = New System.Drawing.Point(328, 19)
        Me.txtVendedor.Name = "txtVendedor"
        Me.txtVendedor.Size = New System.Drawing.Size(120, 21)
        Me.txtVendedor.TabIndex = 42
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(314, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 15)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "TARIFA"
        '
        'cmdBuscarCliente
        '
        Me.cmdBuscarCliente.AutoSize = True
        Me.cmdBuscarCliente.Location = New System.Drawing.Point(244, 97)
        Me.cmdBuscarCliente.Name = "cmdBuscarCliente"
        Me.cmdBuscarCliente.Size = New System.Drawing.Size(26, 26)
        Me.cmdBuscarCliente.TabIndex = 4
        Me.cmdBuscarCliente.Text = "..."
        Me.cmdBuscarCliente.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 15)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Pasajero"
        '
        'txtTarifa
        '
        Me.txtTarifa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTarifa.Location = New System.Drawing.Point(410, 138)
        Me.txtTarifa.Name = "txtTarifa"
        Me.txtTarifa.Size = New System.Drawing.Size(66, 21)
        Me.txtTarifa.TabIndex = 40
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(84, 23)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(28, 15)
        Me.Label13.TabIndex = 38
        Me.Label13.Text = "Bus"
        '
        'txtCodigoBus
        '
        Me.txtCodigoBus.Enabled = False
        Me.txtCodigoBus.Location = New System.Drawing.Point(118, 21)
        Me.txtCodigoBus.Name = "txtCodigoBus"
        Me.txtCodigoBus.Size = New System.Drawing.Size(120, 21)
        Me.txtCodigoBus.TabIndex = 37
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 108)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 15)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "DNI"
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(118, 100)
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(120, 21)
        Me.txtDNI.TabIndex = 35
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 140)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 15)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "N° Asiento"
        '
        'txtNumeroAsiento
        '
        Me.txtNumeroAsiento.Enabled = False
        Me.txtNumeroAsiento.Location = New System.Drawing.Point(118, 134)
        Me.txtNumeroAsiento.Name = "txtNumeroAsiento"
        Me.txtNumeroAsiento.Size = New System.Drawing.Size(73, 21)
        Me.txtNumeroAsiento.TabIndex = 33
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(534, 105)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 15)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Destino"
        '
        'cboDestino
        '
        Me.cboDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDestino.FormattingEnabled = True
        Me.cboDestino.Location = New System.Drawing.Point(615, 102)
        Me.cboDestino.Name = "cboDestino"
        Me.cboDestino.Size = New System.Drawing.Size(127, 23)
        Me.cboDestino.TabIndex = 31
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(314, 102)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 15)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Origen"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(534, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 15)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Hora de Salida"
        '
        'txtHoraSalida
        '
        Me.txtHoraSalida.Location = New System.Drawing.Point(629, 67)
        Me.txtHoraSalida.Name = "txtHoraSalida"
        Me.txtHoraSalida.Size = New System.Drawing.Size(86, 21)
        Me.txtHoraSalida.TabIndex = 28
        '
        'dtpFechaViaje
        '
        Me.dtpFechaViaje.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaViaje.Location = New System.Drawing.Point(411, 67)
        Me.dtpFechaViaje.Name = "dtpFechaViaje"
        Me.dtpFechaViaje.Size = New System.Drawing.Size(117, 21)
        Me.dtpFechaViaje.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(314, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 15)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Fecha de Viaje"
        '
        'txtPasajero
        '
        Me.txtPasajero.Enabled = False
        Me.txtPasajero.Location = New System.Drawing.Point(117, 65)
        Me.txtPasajero.Name = "txtPasajero"
        Me.txtPasajero.Size = New System.Drawing.Size(191, 21)
        Me.txtPasajero.TabIndex = 22
        '
        'cboOrigen
        '
        Me.cboOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOrigen.FormattingEnabled = True
        Me.cboOrigen.Location = New System.Drawing.Point(410, 102)
        Me.cboOrigen.Name = "cboOrigen"
        Me.cboOrigen.Size = New System.Drawing.Size(121, 23)
        Me.cboOrigen.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Blue
        Me.Label11.Location = New System.Drawing.Point(596, 337)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 15)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "Sub Monto :"
        '
        'lblSutTotal
        '
        Me.lblSutTotal.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lblSutTotal.Location = New System.Drawing.Point(677, 332)
        Me.lblSutTotal.Name = "lblSutTotal"
        Me.lblSutTotal.Size = New System.Drawing.Size(122, 25)
        Me.lblSutTotal.TabIndex = 38
        Me.lblSutTotal.Text = "0.00"
        '
        'SkinEngine1
        '
        Me.SkinEngine1.SerialNumber = "U4N2UjLguUZs33UR+Vy47JAZ81t2fjIFvut28vc5oHiVeivGb/NZMA=="
        Me.SkinEngine1.SkinFile = Nothing
        Me.SkinEngine1.SkinStreamMain = CType(resources.GetObject("SkinEngine1.SkinStreamMain"), System.IO.Stream)
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdSalir)
        Me.GroupBox2.Controls.Add(Me.cmdAgregar)
        Me.GroupBox2.Controls.Add(Me.cmdNuevo)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(43, 370)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(352, 81)
        Me.GroupBox2.TabIndex = 39
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "OPCIONES"
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(220, 18)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(103, 57)
        Me.cmdSalir.TabIndex = 3
        Me.cmdSalir.Text = "SALIR"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'cmdAgregar
        '
        Me.cmdAgregar.Location = New System.Drawing.Point(111, 18)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(103, 57)
        Me.cmdAgregar.TabIndex = 1
        Me.cmdAgregar.Text = "CALCULAR"
        Me.cmdAgregar.UseVisualStyleBackColor = True
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Location = New System.Drawing.Point(6, 18)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(103, 57)
        Me.cmdNuevo.TabIndex = 0
        Me.cmdNuevo.Text = "NUEVO"
        Me.cmdNuevo.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.Image = Global.SistemaTransporte.My.Resources.Resources.logoBoleto1
        Me.Label14.Location = New System.Drawing.Point(40, 17)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(132, 93)
        Me.Label14.TabIndex = 40
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Gloucester MT Extra Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(202, 42)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(130, 23)
        Me.Label15.TabIndex = 100
        Me.Label15.Text = "De :  Jose ramos Rojas"
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Gloucester MT Extra Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(181, 70)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(189, 15)
        Me.Label16.TabIndex = 101
        Me.Label16.Text = "Av. Miraflores  #1234 - Tel : 75848 "
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(588, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 111)
        Me.Label1.TabIndex = 102
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(591, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 30)
        Me.Label3.TabIndex = 200
        Me.Label3.Text = "R.U.C."
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(660, 17)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(126, 21)
        Me.Label17.TabIndex = 201
        Me.Label17.Text = "20157485485"
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label18.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(588, 47)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(210, 32)
        Me.Label18.TabIndex = 202
        Me.Label18.Text = "BOLETO DE VIAJE"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNumeroSerie
        '
        Me.lblNumeroSerie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNumeroSerie.Font = New System.Drawing.Font("Gloucester MT Extra Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroSerie.Location = New System.Drawing.Point(600, 86)
        Me.lblNumeroSerie.Name = "lblNumeroSerie"
        Me.lblNumeroSerie.Size = New System.Drawing.Size(70, 26)
        Me.lblNumeroSerie.TabIndex = 203
        '
        'lblNumeroBoleta
        '
        Me.lblNumeroBoleta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNumeroBoleta.Font = New System.Drawing.Font("Gloucester MT Extra Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroBoleta.Location = New System.Drawing.Point(707, 86)
        Me.lblNumeroBoleta.Name = "lblNumeroBoleta"
        Me.lblNumeroBoleta.Size = New System.Drawing.Size(72, 26)
        Me.lblNumeroBoleta.TabIndex = 204
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(674, 85)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(29, 26)
        Me.Label21.TabIndex = 205
        Me.Label21.Text = "-"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lblTotal.Location = New System.Drawing.Point(676, 405)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(122, 25)
        Me.lblTotal.TabIndex = 208
        Me.lblTotal.Text = "0.00"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Blue
        Me.Label20.Location = New System.Drawing.Point(626, 410)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(43, 15)
        Me.Label20.TabIndex = 207
        Me.Label20.Text = "Total : "
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Blue
        Me.Label25.Location = New System.Drawing.Point(571, 370)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(99, 15)
        Me.Label25.TabIndex = 209
        Me.Label25.Text = "Cargo Adicional :"
        '
        'txtCargoAdicional
        '
        Me.txtCargoAdicional.Location = New System.Drawing.Point(675, 368)
        Me.txtCargoAdicional.Multiline = True
        Me.txtCargoAdicional.Name = "txtCargoAdicional"
        Me.txtCargoAdicional.Size = New System.Drawing.Size(73, 27)
        Me.txtCargoAdicional.TabIndex = 47
        Me.txtCargoAdicional.Text = "0.00"
        '
        'frmBoletosVentas
        '
        Me.AcceptButton = Me.cmdBuscarCliente
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(831, 488)
        Me.Controls.Add(Me.txtCargoAdicional)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.lblNumeroBoleta)
        Me.Controls.Add(Me.lblNumeroSerie)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lblSutTotal)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.gbDatos)
        Me.Name = "frmBoletosVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TARIFA"
        Me.gbDatos.ResumeLayout(False)
        Me.gbDatos.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbDatos As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtDNI As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtNumeroAsiento As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboDestino As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtHoraSalida As System.Windows.Forms.TextBox
    Friend WithEvents dtpFechaViaje As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPasajero As System.Windows.Forms.TextBox
    Friend WithEvents cboOrigen As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblSutTotal As System.Windows.Forms.Label
    Friend WithEvents SkinEngine1 As Sunisoft.IrisSkin.SkinEngine
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents cmdAgregar As System.Windows.Forms.Button
    Friend WithEvents cmdNuevo As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtCodigoBus As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lblNumeroSerie As System.Windows.Forms.Label
    Friend WithEvents lblNumeroBoleta As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cmdBuscarCliente As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTarifa As System.Windows.Forms.TextBox
    Friend WithEvents txtVendedor As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtCodigoBoleta As System.Windows.Forms.TextBox
    Friend WithEvents btnTarifa As System.Windows.Forms.Button
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtCargoAdicional As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class
