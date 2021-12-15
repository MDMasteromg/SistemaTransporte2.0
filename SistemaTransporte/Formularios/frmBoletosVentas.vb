
Imports System.Data
Imports System.Data.SqlClient


Public Class frmBoletosVentas

    Dim cn As SqlConnection
    Dim dsDatos As DataSet
    Dim daClientes As SqlDataAdapter
    Dim daDestinos As SqlDataAdapter
    Dim daOrigenes As SqlDataAdapter
    Dim daBoleta As SqlDataAdapter
    Dim daBus As SqlDataAdapter
    Dim CodigoBoleta As String = ""
    Dim CodigoDetalleBoleta As String = ""
    Dim NumeroSerie As Integer
    Dim NumeroBoleta As Integer

    Private Sub frmBoletosVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNumeroAsiento.Text = Conexion.asiento
        CrearDataset()
        LlenarCombos()
        txtVendedor.Text = Conexion.UsuarioAccesoCodigo
        GeneradorCodigoBoleta()
        txtTarifa.Enabled = False
        MostarNumeroYserieBoleta()
        txtCodigoBus.Text = Conexion.CodigoBus
        gbDatos.Enabled = True
        LlenarConCeros()
        frmAsientos.Visible = False
    End Sub

    Private Sub MostarNumeroYserieBoleta()
        Dim UltimoDato As Integer = dsDatos.Tables("Boleta").Rows.Count
        lblNumeroBoleta.Text = Format(UltimoDato + 1, "0000")
        Dim serie As Integer = dsDatos.Tables("Boleta").Rows(0).Item("NumerioSerie")
        lblNumeroSerie.Text = Format(serie, "0000")
    End Sub


    Private Sub LlenarConCeros()
        lblSutTotal.Text = "0.00"
        lblTotal.Text = "0.00"
    End Sub


    Public Sub Limpiar(ByVal Grupo As Windows.Forms.GroupBox)
        Dim miControl As Object
        For Each miControl In Grupo.Controls
            If miControl.GetType Is GetType(System.Windows.Forms.TextBox) Then
                miControl.Clear()
            End If
            System.Windows.Forms.Application.DoEvents()
        Next
    End Sub


    Private Sub TARIFA()
        If cboOrigen.SelectedValue = "O001" And cboDestino.SelectedValue = "D002" Then
            txtTarifa.Text = 8.0

        ElseIf cboOrigen.SelectedValue = "O001" And cboDestino.SelectedValue = "D003" Then
            txtTarifa.Text = 12.0

        ElseIf cboOrigen.SelectedValue = "O001" And cboDestino.SelectedValue = "D004" Then
            txtTarifa.Text = 15.0

            'destino002----------------------------------------------------------------
        ElseIf cboOrigen.SelectedValue = "O002" And cboDestino.SelectedValue = "D001" Then
            txtTarifa.Text = 8.0

        ElseIf cboOrigen.SelectedValue = "O002" And cboDestino.SelectedValue = "D003" Then
            txtTarifa.Text = 5.0

        ElseIf cboOrigen.SelectedValue = "O002" And cboDestino.SelectedValue = "D004" Then
            txtTarifa.Text = 10.0

            'destino003-------------------------------------------------------------------

        ElseIf cboOrigen.SelectedValue = "O003" And cboDestino.SelectedValue = "D001" Then
            txtTarifa.Text = 10.0

        ElseIf cboOrigen.SelectedValue = "O003" And cboDestino.SelectedValue = "D002" Then
            txtTarifa.Text = 5.0

        ElseIf cboOrigen.SelectedValue = "O003" And cboDestino.SelectedValue = "D004" Then
            txtTarifa.Text = 7.0


            'destino004-------------------------------------------------------------------

        ElseIf cboOrigen.SelectedValue = "O004" And cboDestino.SelectedValue = "D001" Then
            txtTarifa.Text = 15.0

        ElseIf cboOrigen.SelectedValue = "O004" And cboDestino.SelectedValue = "D002" Then
            txtTarifa.Text = 12.5

        ElseIf cboOrigen.SelectedValue = "O004" And cboDestino.SelectedValue = "D003" Then
            txtTarifa.Text = 12.0

        End If
    End Sub


    Private Sub GeneradorCodigoBoleta()

        Dim Codigo As New Random
        Dim numero As Integer

        numero = Codigo.Next(1000, 9000)
        txtCodigoBoleta.Text = "BO" & numero

    End Sub

    Private Sub CrearDataset()
        cn = New SqlConnection(ConexionBD)
        dsDatos = New DataSet
        daDestinos = New SqlDataAdapter("ListarDestinos", cn)
        daDestinos.Fill(dsDatos, "Destinos")

        daOrigenes = New SqlDataAdapter("ListarOrigenes", cn)
        daOrigenes.Fill(dsDatos, "Origen")

        daBoleta = New SqlDataAdapter("ListarBoleta", cn)
        daBoleta.Fill(dsDatos, "Boleta")

    End Sub

    Private Sub LlenarCombos()
        cboOrigen.DataSource = dsDatos.Tables("Origen")
        cboOrigen.ValueMember = "CodigoOrigen"
        cboOrigen.DisplayMember = "CiudadOrigen"

        cboDestino.DataSource = dsDatos.Tables("Destinos")
        cboDestino.ValueMember = "CodigoDestino"
        cboDestino.DisplayMember = "CiudadDestino"


    End Sub

    Private Sub BuscarCliente(sender As Object, e As EventArgs) Handles cmdBuscarCliente.Click

        cn = New SqlConnection(ConexionBD)
        dsDatos = New DataSet

        Dim coClientes As New SqlCommand("BuscarClienteParaBoleta", cn)
        coClientes.CommandType = CommandType.StoredProcedure

        coClientes.Parameters.Add(New SqlParameter("@DNICliente", SqlDbType.VarChar, 8)).Value = txtDNI.Text

        Dim daClientes As New SqlDataAdapter("BuscarClienteParaBoleta", cn)
        daClientes.SelectCommand = coClientes
        daClientes.Fill(dsDatos, "Clientes")
        If dsDatos.Tables("Clientes").Rows.Count = 0 Then
            Conexion.DNI = txtDNI.Text
            frmAgregarCliente.ShowDialog()

        Else
            txtPasajero.Text = dsDatos.Tables("Clientes").Rows(0).Item("Cliente").ToString
            txtDNI.Text = dsDatos.Tables("Clientes").Rows(0).Item("DNIPersona").ToString
            Conexion.codigoClientes = dsDatos.Tables("Clientes").Rows(0).Item("CodigoPersona").ToString
        End If

    End Sub

  




    Private Sub AgregarADetalle(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        If cmdAgregar.Text = "CALCULAR" Then
            lblSutTotal.Text = Val(txtTarifa.Text)
            lblTotal.Text = Val(lblSutTotal.Text) + Val(txtCargoAdicional.Text)
            cmdAgregar.Text = "GUARDAR"

        Else
            Dim coAgregar As New SqlCommand("InsertarBoletaViaje", cn)
            coAgregar.CommandType = CommandType.StoredProcedure

            coAgregar.Parameters.Add(New SqlParameter("@CodigoBoleta", SqlDbType.Char, 6, ParameterDirection.Input)).Value = txtCodigoBoleta.Text
            coAgregar.Parameters.Add(New SqlParameter("@NumeroSerie", SqlDbType.Char, 4, ParameterDirection.Input)).Value = Val(lblNumeroSerie.Text)
            coAgregar.Parameters.Add(New SqlParameter("@NumeroBoleta", SqlDbType.Char, 4, ParameterDirection.Input)).Value = Val(lblNumeroBoleta.Text)
            coAgregar.Parameters.Add(New SqlParameter("@FechaViaje", SqlDbType.Date, ParameterDirection.Input)).Value = Convert.ToDateTime(dtpFechaViaje.Text)
            coAgregar.Parameters.Add(New SqlParameter("@HoraSalida", SqlDbType.VarChar, 10, ParameterDirection.Input)).Value = txtHoraSalida.Text
            coAgregar.Parameters.Add(New SqlParameter("@CodigoVendedor", SqlDbType.NChar, 8, ParameterDirection.Input)).Value = txtVendedor.Text
            coAgregar.Parameters.Add(New SqlParameter("@CodigoBus", SqlDbType.NChar, 4, ParameterDirection.Input)).Value = txtCodigoBus.Text
            coAgregar.Parameters.Add(New SqlParameter("@CodigoOrigen", SqlDbType.NChar, 4, ParameterDirection.Input)).Value = cboOrigen.SelectedValue
            coAgregar.Parameters.Add(New SqlParameter("@CodigoCliente", SqlDbType.NChar, 8, ParameterDirection.Input)).Value = Conexion.codigoClientes
            coAgregar.Parameters.Add(New SqlParameter("@CodigoDestino", SqlDbType.NChar, 4, ParameterDirection.Input)).Value = cboDestino.SelectedValue
            coAgregar.Parameters.Add(New SqlParameter("@NumeroAsiento", SqlDbType.Char, 2, ParameterDirection.Input)).Value = txtNumeroAsiento.Text
            coAgregar.Parameters.Add(New SqlParameter("@Monto", SqlDbType.Decimal, ParameterDirection.Input)).Value = txtCargoAdicional.Text

            If cn.State <> ConnectionState.Closed Then
                cn.Close()
            End If

            Try
                cn.Open()
                coAgregar.ExecuteNonQuery()
                cn.Close()
                MessageBox.Show("Boleta Guardada.")
                gbDatos.Enabled = False
                cmdAgregar.Enabled = False
            Catch ex As Exception
                MessageBox.Show("NO SE PUDO REGISTRAR BOLETA", "ERROR..")
            End Try
        End If
        CrearDataset()
    End Sub

    Private Sub btnTarifa_Click(sender As Object, e As EventArgs) Handles btnTarifa.Click
        TARIFA()
    End Sub

    Private Sub NUEVO(sender As Object, e As EventArgs) Handles cmdNuevo.Click

        Call Limpiar(gbDatos)
        txtCargoAdicional.Clear()
        cmdAgregar.Text = "CALCULAR"
        Me.Close()
        frmAsientos.Visible = True


    End Sub

    Private Sub txtCargoAdicional_TextChanged(sender As Object, e As EventArgs) Handles txtCargoAdicional.TextChanged
        txtCargoAdicional.ClearUndo()
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs)

    End Sub
End Class