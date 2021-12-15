
Imports System.Data
Imports System.Data.SqlClient


Public Class frmMantenedorClientes

    Dim cn As SqlConnection
    Dim dsDatos As DataSet
    Dim daClientes As SqlDataAdapter
    Dim daClientesBusqueda As SqlDataAdapter
    Dim vClientesPosicion As Integer
    Dim dvClientesVista As DataView



    Private Sub frmMantenedorClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CrearDataset()
        LlenarLista()
        MostrarRegistro()

    End Sub


    Private Sub CrearDataset()
        cn = New SqlConnection(ConexionBD)
        dsDatos = New DataSet
        daClientes = New SqlDataAdapter("spListarClientes", cn)
        daClientes.Fill(dsDatos, "Clientes")
        dvClientesVista = New DataView(dsDatos.Tables("Clientes"), " DNIPersona like '%'", "Cliente asc", DataViewRowState.OriginalRows)
        LlenarListaBusqueda()
        daClientes = New SqlDataAdapter("spMostrarCliente", cn)
        daClientes.Fill(dsDatos, "Mostrarclientes")

    End Sub

    Private Sub LlenarListaBusqueda()
        lvClientes.Items.Clear()
        For i As Integer = 0 To dvClientesVista.Count - 1
            lvClientes.Items.Add(dvClientesVista.Item(i).Item("CodigoCliente"))
            lvClientes.Items(i).SubItems.Add(dvClientesVista.Item(i).Item("DNIPersona"))
            lvClientes.Items(i).SubItems.Add(dvClientesVista.Item(i).Item("Cliente"))
            lvClientes.Items(i).SubItems.Add(dvClientesVista.Item(i).Item("RucCliente"))

        Next

    End Sub

    Private Sub LlenarLista()
        lvClientes.Items.Clear()
        For i As Integer = 0 To dsDatos.Tables("Clientes").Rows.Count - 1
            lvClientes.Items.Add(dsDatos.Tables("Clientes").Rows(i).Item("CodigoCliente").ToString)
            lvClientes.Items(i).SubItems.Add(dsDatos.Tables("Clientes").Rows(i).Item("DNIPersona").ToString)
            lvClientes.Items(i).SubItems.Add(dsDatos.Tables("Clientes").Rows(i).Item("Cliente").ToString)
            lvClientes.Items(i).SubItems.Add(dsDatos.Tables("Clientes").Rows(i).Item("RucCliente").ToString)
        Next
    End Sub
    Private Sub MostrarRegistro()
        txtCodigo.Text = dsDatos.Tables("Mostrarclientes").Rows(vClientesPosicion).Item("CodigoCliente").ToString
        txtDNI.Text = dsDatos.Tables("Mostrarclientes").Rows(vClientesPosicion).Item("DNIPersona").ToString
        txtNombre.Text = dsDatos.Tables("Mostrarclientes").Rows(vClientesPosicion).Item("NombrePersona").ToString
        txtApellidoPaterno.Text = dsDatos.Tables("Mostrarclientes").Rows(vClientesPosicion).Item("ApellidoPaternoPersona").ToString
        txtApellidoMaterno.Text = dsDatos.Tables("Mostrarclientes").Rows(vClientesPosicion).Item("ApellidoMaternoPersona").ToString
        dtpFechaN.Text = dsDatos.Tables("Mostrarclientes").Rows(vClientesPosicion).Item("FechaNacimientoPersona").ToString
        txtDireccion.Text = dsDatos.Tables("Mostrarclientes").Rows(vClientesPosicion).Item("DireccionPersona").ToString
        txtTelefono.Text = dsDatos.Tables("Mostrarclientes").Rows(vClientesPosicion).Item("TelefonoPersona").ToString
        txtEmail.Text = dsDatos.Tables("Mostrarclientes").Rows(vClientesPosicion).Item("EmailPersona").ToString
        txtRUC.Text = dsDatos.Tables("Mostrarclientes").Rows(vClientesPosicion).Item("RucCliente").ToString
        txtSexo.Text = dsDatos.Tables("Mostrarclientes").Rows(vClientesPosicion).Item("SexoPersona").ToString


    End Sub



    Private Sub lvClientes_SelectedIndexChanged(sender As Object, e As EventArgs)

        If lvClientes.SelectedItems.Count = 0 Then Exit Sub

        For i As Integer = 0 To dsDatos.Tables("Mostrarclientes").Rows.Count - 1
            If dsDatos.Tables("Mostrarclientes").Rows(i).Item("CodigoCliente") = lvClientes.SelectedItems(0).Text Then
                vClientesPosicion = i
                Exit For
            End If
        Next
        MostrarRegistro()

    End Sub


    Private Sub EVENTOS(sender As Object, e As EventArgs) Handles cmdAgregar.Click, cmdActualizar.Click, cmdEliminar.Click, cmdCancelar.Click, cmdSalir.Click,
        cmdSiguiente.Click, cmdAnterior.Click

        If sender Is cmdAgregar Then
            AgregarCliente()

        ElseIf sender Is cmdActualizar Then
            editarCliente()
        ElseIf sender Is cmdAnterior Then

            If vClientesPosicion > 0 Then
                vClientesPosicion -= 1
            End If
            MostrarRegistro()

        ElseIf sender Is cmdCancelar Then
            Cancelar()

        ElseIf sender Is cmdEliminar Then
            eliminarCliente()

        ElseIf sender Is cmdSalir Then
            Me.Close()

        ElseIf sender Is cmdSiguiente Then

            If vClientesPosicion < dsDatos.Tables("Mostrarclientes").Rows.Count - 1 Then
                vClientesPosicion += 1
            End If
            MostrarRegistro()

        End If

    End Sub

    Private Sub salir1(sender As Object, e As EventArgs) Handles cmdSalir.MouseEnter
        cmdSalir.Size = cmdSalir.MaximumSize

    End Sub

    Private Sub salir(sender As Object, e As EventArgs) Handles cmdSalir.MouseLeave
        cmdSalir.Size = cmdSalir.MinimumSize

    End Sub

    Private Sub Botones(agregar As Boolean, editar As Boolean, eliminar As Boolean, cancelar As Boolean, salir As Boolean)
        cmdAgregar.Enabled = agregar
        cmdActualizar.Enabled = editar
        cmdEliminar.Enabled = eliminar
        cmdCancelar.Enabled = cancelar
        cmdSalir.Enabled = salir

    End Sub
    Private Sub Controles(codigo As Boolean, dni As Boolean, nombre As Boolean, apellidop As Boolean, apellidom As Boolean, ruc As Boolean, direccion As Boolean, telefono As Boolean,
                          email As Boolean, sexo As Boolean, fecha As Boolean)
        txtCodigo.Enabled = codigo
        txtDNI.Enabled = dni
        txtNombre.Enabled = nombre
        txtApellidoPaterno.Enabled = apellidop
        txtApellidoMaterno.Enabled = apellidom
        txtRUC.Enabled = ruc
        txtDireccion.Enabled = direccion
        txtTelefono.Enabled = telefono
        txtEmail.Enabled = email
        txtSexo.Enabled = sexo
        dtpFechaN.Enabled = fecha


    End Sub


    Private Sub Cancelar()

        Botones(True, True, True, False, True)
        LlenarLista()
        DesactivarCajas()
        MostrarRegistro()
        txtBuscar.Clear()
        cboSexo.Visible = False
        txtSexo.Visible = True
        cmdAgregar.Text = "AGREGAR"
        cmdActualizar.Text = "ACTUALIZAR"
        txtBuscar.Enabled = True

    End Sub

    Private Sub AgregarCliente()

        If cmdAgregar.Text = "AGREGAR" Then
            cmdAgregar.Text = "GUARDAR"
            Botones(True, False, False, True, True)
            LimpiarCajas()
            txtSexo.Visible = False
            cboSexo.Visible = True
            ActivarCajas()
            txtBuscar.Enabled = False

        Else

            Dim coAgregar As New SqlCommand("insertarCliente", cn)
            coAgregar.CommandType = CommandType.StoredProcedure

            coAgregar.Parameters.Add(New SqlParameter("@NombrePersona", SqlDbType.VarChar, 100, ParameterDirection.Input)).Value = txtNombre.Text
            coAgregar.Parameters.Add(New SqlParameter("@ApellidoPaternoPersona", SqlDbType.VarChar, 100, ParameterDirection.Input)).Value = txtApellidoPaterno.Text
            coAgregar.Parameters.Add(New SqlParameter("@ApellidoMaternoPersona", SqlDbType.VarChar, 100, ParameterDirection.Input)).Value = txtApellidoMaterno.Text
            coAgregar.Parameters.Add(New SqlParameter("@SexoPersona", SqlDbType.Char, 1, ParameterDirection.Input)).Value = cboSexo.SelectedItem
            coAgregar.Parameters.Add(New SqlParameter("@FechaNacimientoPersona", SqlDbType.VarChar, 20, ParameterDirection.Input)).Value = dtpFechaN.Text
            coAgregar.Parameters.Add(New SqlParameter("@DNIPersona", SqlDbType.VarChar, 8, ParameterDirection.Input)).Value = txtDNI.Text
            coAgregar.Parameters.Add(New SqlParameter("@DireccionPersona", SqlDbType.VarChar, 50, ParameterDirection.Input)).Value = txtDireccion.Text
            coAgregar.Parameters.Add(New SqlParameter("@TelefonoPersona", SqlDbType.VarChar, 20, ParameterDirection.Input)).Value = txtTelefono.Text
            coAgregar.Parameters.Add(New SqlParameter("@EmailPersona", SqlDbType.VarChar, 50, ParameterDirection.Input)).Value = txtEmail.Text
            coAgregar.Parameters.Add(New SqlParameter("@RucCliente", SqlDbType.NChar, 11, ParameterDirection.Input)).Value = txtRUC.Text
            coAgregar.Parameters.Add(New SqlParameter("@Estado", SqlDbType.Char, 1, ParameterDirection.Input)).Value = "A"


            If cn.State <> ConnectionState.Closed Then
                cn.Close()
            End If

            Try
                cn.Open()
                coAgregar.ExecuteNonQuery()
                cn.Close()
                MessageBox.Show("CLIENTE NUEVO AGREGADO..")
                txtCodigo.Enabled = False
            Catch ex As Exception
                MessageBox.Show("NO SE PUDO AGREGAR REGISTRO", "ERROR..")
            End Try

            CrearDataset()
            LlenarLista()
            MostrarRegistro()
            cboSexo.Visible = False
            txtSexo.Visible = True
            cmdAgregar.Text = "AGREGAR"
            Botones(True, True, True, False, True)
            DesactivarCajas()
            txtBuscar.Enabled = True
        End If


    End Sub


    Private Sub LimpiarCajas()
        txtCodigo.Clear()
        txtApellidoMaterno.Clear()
        txtApellidoPaterno.Clear()
        txtDireccion.Clear()
        txtDNI.Clear()
        txtEmail.Clear()
        txtNombre.Clear()
        txtRUC.Clear()
        txtTelefono.Clear()

    End Sub

    Private Sub ActivarCajas()
        txtCodigo.Enabled = False
        txtApellidoMaterno.Enabled = True
        txtApellidoPaterno.Enabled = True
        txtDireccion.Enabled = True
        txtDNI.Enabled = True
        txtEmail.Enabled = True
        txtNombre.Enabled = True
        txtRuc.Enabled = True
        txtTelefono.Enabled = True

    End Sub

    Private Sub DesactivarCajas()
        txtCodigo.Enabled = False
        txtApellidoMaterno.Enabled = False
        txtApellidoPaterno.Enabled = False
        txtDireccion.Enabled = False
        txtDNI.Enabled = False
        txtEmail.Enabled = False
        txtNombre.Enabled = False
        txtRuc.Enabled = False
        txtTelefono.Enabled = False

    End Sub


    Private Sub editarCliente()

        If cmdActualizar.Text = "ACTUALIZAR" Then
            cmdActualizar.Text = "GUARDAR"
            Botones(False, True, False, True, True)
            ActivarCajas()
            txtSexo.Visible = False
            cboSexo.Visible = True
            txtBuscar.Enabled = False

        Else

            Dim coEditar As New SqlCommand("spEditarCliente", cn)
            coEditar.CommandType = CommandType.StoredProcedure

            coEditar.Parameters.Add(New SqlParameter("@CodigoCliente", SqlDbType.NChar, 8, ParameterDirection.Input)).Value = txtCodigo.Text
            coEditar.Parameters.Add(New SqlParameter("@NombrePersona", SqlDbType.VarChar, 100, ParameterDirection.Input)).Value = txtNombre.Text
            coEditar.Parameters.Add(New SqlParameter("@ApellidoPaternoPersona", SqlDbType.VarChar, 100, ParameterDirection.Input)).Value = txtApellidoPaterno.Text
            coEditar.Parameters.Add(New SqlParameter("@ApellidoMaternoPersona", SqlDbType.VarChar, 100, ParameterDirection.Input)).Value = txtApellidoMaterno.Text
            coEditar.Parameters.Add(New SqlParameter("@SexoPersona", SqlDbType.Char, 1, ParameterDirection.Input)).Value = cboSexo.SelectedItem
            coEditar.Parameters.Add(New SqlParameter("@FechaNacimientoPersona", SqlDbType.VarChar, 20, ParameterDirection.Input)).Value = dtpFechaN.Text
            coEditar.Parameters.Add(New SqlParameter("@DNIPersona", SqlDbType.VarChar, 8, ParameterDirection.Input)).Value = txtDNI.Text
            coEditar.Parameters.Add(New SqlParameter("@DireccionPersona", SqlDbType.VarChar, 50, ParameterDirection.Input)).Value = txtDireccion.Text
            coEditar.Parameters.Add(New SqlParameter("@TelefonoPersona", SqlDbType.VarChar, 20, ParameterDirection.Input)).Value = txtTelefono.Text
            coEditar.Parameters.Add(New SqlParameter("@EmailPersona", SqlDbType.VarChar, 50, ParameterDirection.Input)).Value = txtEmail.Text
            coEditar.Parameters.Add(New SqlParameter("@RucCliente", SqlDbType.NChar, 11, ParameterDirection.Input)).Value = txtRuc.Text
            coEditar.Parameters.Add(New SqlParameter("@Estado", SqlDbType.Char, 1, ParameterDirection.Input)).Value = "A"

            If cn.State <> ConnectionState.Closed Then
                cn.Close()

            End If

            Try
                cn.Open()
                coEditar.ExecuteNonQuery()
                cn.Close()
                MessageBox.Show("REGISTRO ACTUALIZADO..", "CONCLUIDO")
            Catch ex As Exception
                MessageBox.Show("NO SE PUDO ACTUALIZAR REGISTRO", "ERROR")
            End Try

            CrearDataset()
            LlenarLista()
            MostrarRegistro()

            cmdActualizar.Text = "ACTUALIZAR"
            DesactivarCajas()
            cboSexo.Visible = False
            txtSexo.Visible = True
            Botones(True, True, True, False, True)
            txtBuscar.Enabled = True
            txtBuscar.Clear()

        End If


    End Sub

    Private Sub eliminarCliente()

        Dim coEliminar As New SqlCommand("EliminarCliente", cn)
        coEliminar.CommandType = CommandType.StoredProcedure

        coEliminar.Parameters.Add(New SqlParameter("@codCliente", SqlDbType.NChar, 8, ParameterDirection.Input)).Value = txtCodigo.Text

        If cn.State <> ConnectionState.Closed Then
            cn.Close()

        End If

        Try
            cn.Open()
            coEliminar.ExecuteNonQuery()
            cn.Close()
            MessageBox.Show("REGISTRO ELIMINADO")

        Catch ex As Exception
            MessageBox.Show("NO SE PUDO ELIMINAR REGISTRO")
        End Try
        CrearDataset()
        LlenarLista()
        MostrarRegistro()


    End Sub



    Private Sub cmdMinimizar_Click(sender As Object, e As EventArgs)
        Dim mantenedor As New frmMantenedorClientes
        mantenedor.Size = mantenedor.MinimumSize


    End Sub

    Private Sub lvClientes_SelectedIndexChanged_2(sender As Object, e As EventArgs) Handles lvClientes.SelectedIndexChanged
        If lvClientes.SelectedItems.Count = 0 Then Exit Sub

        For i As Integer = 0 To dsDatos.Tables("Clientes").Rows.Count - 1
            If dsDatos.Tables("Clientes").Rows(i).Item("CodigoCliente") = lvClientes.SelectedItems(0).Text Then
                vClientesPosicion = i

            End If
        Next
        MostrarRegistro()

    End Sub

   
   
  
    Private Sub txtBuscar_TextChanged_1(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        dvClientesVista.RowFilter = "DNIPersona LIKE '" + Trim(txtBuscar.Text) + "%'"
        LlenarListaBusqueda()

    End Sub

    Private Sub BUSCAR(sender As Object, e As EventArgs) Handles txtBuscar.Click
        Botones(False, True, True, True, True)
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        clienteencontrado = 0

        frmCliente.ShowDialog()
        If clienteencontrado = 1 Then
            For i As Integer = 0 To dsDatos.Tables("Mostrarclientes").Rows.Count - 1
                If dsDatos.Tables("Mostrarclientes").Rows(i).Item(0) = BCodigoCliente Then
                    vClientesPosicion = i

                End If
            Next
            MostrarRegistro()
        End If
    End Sub
End Class