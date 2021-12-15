
Imports System.Data
Imports System.Data.SqlClient

Public Class frmUsuariosListado

    Dim cn As SqlConnection
    Dim dsDatos As DataSet
    Dim daUsuarios As SqlDataAdapter
    Dim daUsuariosMostrar As SqlDataAdapter
    Dim daTipoUsuarios As SqlDataAdapter
    Dim vPosicionUsuario As Integer


    Private Sub frmUsuariosListado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CrearDataset()
        llenarLista()
        VaciarCajas = 0
        MostrarRegistro()
    End Sub


    Private Sub CrearDataset()
        cn = New SqlConnection(ConexionBD)
        dsDatos = New DataSet

        daUsuarios = New SqlDataAdapter("ListarUsuarios", cn)
        daUsuarios.Fill(dsDatos, "Usuarios")

        daTipoUsuarios = New SqlDataAdapter("ListadoTipoUsuarioParaUsuario", cn)
        daTipoUsuarios.Fill(dsDatos, "TipoUsuarios")

    End Sub


    Private Sub MostrarRegistro()


        cboUsuarios.DataSource = dsDatos.Tables("TipoUsuarios")
        cboUsuarios.DisplayMember = "DescripcionTipoUsuario"
        cboUsuarios.ValueMember = "CodigoTipoUsuario"

        txtCodigoUsuario.Text = dsDatos.Tables("Usuarios").Rows(vPosicionUsuario).Item("CodigoUsuario")
        txtNombre.Text = dsDatos.Tables("Usuarios").Rows(vPosicionUsuario).Item("NombrePersona")
        txtApellidoPaterno.Text = dsDatos.Tables("Usuarios").Rows(vPosicionUsuario).Item("ApellidoPaternoPersona")
        txtApellidoMaterno.Text = dsDatos.Tables("Usuarios").Rows(vPosicionUsuario).Item("ApellidoMaternoPersona")
        txtDireccion.Text = dsDatos.Tables("Usuarios").Rows(vPosicionUsuario).Item("DireccionPersona")
        txtDNI.Text = dsDatos.Tables("Usuarios").Rows(vPosicionUsuario).Item("DNI_Usuario")
        txtEmail.Text = dsDatos.Tables("Usuarios").Rows(vPosicionUsuario).Item("EmailPersona")
        txtTelefono.Text = dsDatos.Tables("Usuarios").Rows(vPosicionUsuario).Item("TelefonoPersona")
        dtpFechaN.Text = dsDatos.Tables("Usuarios").Rows(vPosicionUsuario).Item("FechaNacimientoPersona")
        cboSexo.Text = dsDatos.Tables("Usuarios").Rows(vPosicionUsuario).Item("SexoPersona")

    End Sub

    Private Sub llenarLista()

        lvUsuarios.Items.Clear()
        For i As Integer = 0 To dsDatos.Tables("Usuarios").Rows.Count - 1
            lvUsuarios.Items.Add(dsDatos.Tables("Usuarios").Rows(i).Item("CodigoUsuario").ToString)
            lvUsuarios.Items(i).SubItems.Add(dsDatos.Tables("Usuarios").Rows(i).Item("Usuario").ToString)
            lvUsuarios.Items(i).SubItems.Add(dsDatos.Tables("Usuarios").Rows(i).Item("DNI_Usuario").ToString)
            lvUsuarios.Items(i).SubItems.Add(dsDatos.Tables("Usuarios").Rows(i).Item("UserName").ToString)
            lvUsuarios.Items(i).SubItems.Add(dsDatos.Tables("Usuarios").Rows(i).Item("PassUsuario").ToString)

            For j As Integer = 0 To dsDatos.Tables("TipoUsuarios").Rows.Count - 1
                If dsDatos.Tables("TipoUsuarios").Rows(j).Item("CodigoTipoUsuario") = dsDatos.Tables("Usuarios").Rows(i).Item("CodigoTipoUsuario") Then
                    lvUsuarios.Items(i).SubItems.Add(dsDatos.Tables("TipoUsuarios").Rows(j).Item("DescripcionTipoUsuario").ToString)
                End If
            Next

        Next

    End Sub


    Private Sub OPCIONES(sender As Object, e As EventArgs) Handles cmdAgregar.Click, cmdDesactivar.Click, cmdEditar.Click

        VaciarCajas = 1

        If sender Is cmdAgregar Then
            AgregarUsuario()
        ElseIf sender Is cmdDesactivar Then

        ElseIf sender Is cmdEditar Then
            EditarUsuarios()

        End If

        If lvUsuarios.SelectedItems.Count = 0 Then
            cmdDesactivar.Enabled = False
            cmdEditar.Enabled = False

        End If


    End Sub

    Private Sub AgregarUsuario()
        frmAgregarUsuarios.ShowDialog()
        If Actualizar = 1 Then
            CrearDataset()
            llenarLista()

        End If
    End Sub


    Private Sub EditarUsuarios()
        Dim volver As Integer = 0

        If cmdEditar.Text = "EDITAR" Then
            cmdEditar.Text = "GUARDAR"
            cmdAgregar.Enabled = False
            cmdDesactivar.Enabled = False
            cmdCancelar.Visible = True
            gbLista.Visible = False
            gbEditar.Visible = True

        Else

            Dim coEditarUsuarios = New SqlCommand("editarUsuarios", cn)
            coEditarUsuarios.CommandType = CommandType.StoredProcedure


            coEditarUsuarios.Parameters.Add(New SqlParameter("@CodigoPersona", SqlDbType.NChar, 8, ParameterDirection.Input)).Value = txtCodigoUsuario.Text
            coEditarUsuarios.Parameters.Add(New SqlParameter("@CodigoTipoUsuario", SqlDbType.NChar, 4, ParameterDirection.Input)).Value = cboUsuarios.SelectedValue
            coEditarUsuarios.Parameters.Add(New SqlParameter("@dni", SqlDbType.VarChar, 8, ParameterDirection.Input)).Value = txtDNI.Text
            coEditarUsuarios.Parameters.Add(New SqlParameter("@Nombres", SqlDbType.VarChar, 100, ParameterDirection.Input)).Value = txtNombre.Text
            coEditarUsuarios.Parameters.Add(New SqlParameter("@apePaterno", SqlDbType.VarChar, 100, ParameterDirection.Input)).Value = txtApellidoPaterno.Text
            coEditarUsuarios.Parameters.Add(New SqlParameter("@apeMater", SqlDbType.VarChar, 100, ParameterDirection.Input)).Value = txtApellidoMaterno.Text
            coEditarUsuarios.Parameters.Add(New SqlParameter("@Direccion", SqlDbType.VarChar, 50, ParameterDirection.Input)).Value = txtDireccion.Text
            coEditarUsuarios.Parameters.Add(New SqlParameter("@estado", SqlDbType.Char, 1, ParameterDirection.Input)).Value = "A"
            coEditarUsuarios.Parameters.Add(New SqlParameter("@Telefono", SqlDbType.VarChar, 20, ParameterDirection.Input)).Value = txtTelefono.Text
            coEditarUsuarios.Parameters.Add(New SqlParameter("@email", SqlDbType.VarChar, 50, ParameterDirection.Input)).Value = txtEmail.Text
            coEditarUsuarios.Parameters.Add(New SqlParameter("@fechaNacimineto", SqlDbType.VarChar, 20, ParameterDirection.Input)).Value = dtpFechaN.Text
            coEditarUsuarios.Parameters.Add(New SqlParameter("@sexo", SqlDbType.Char, 1, ParameterDirection.Input)).Value = cboSexo.SelectedItem



            If cn.State <> ConnectionState.Closed Then
                cn.Close()
            End If

            Try
                cn.Open()
                coEditarUsuarios.ExecuteNonQuery()
                cn.Close()
                MessageBox.Show("Usuario Editado")
            Catch ex As Exception
                MessageBox.Show("Error al editar")
                volver = 1
            End Try

            If volver = 0 Then
                gbLista.Visible = True
                gbEditar.Visible = False
                cmdEditar.Text = "EDITAR"
                cmdAgregar.Enabled = True
                cmdDesactivar.Enabled = True
                cmdCancelar.Visible = False
                CrearDataset()
                llenarLista()
            End If
        End If


    End Sub


   
    Private Sub lvUsuarios_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles lvUsuarios.SelectedIndexChanged

        If lvUsuarios.SelectedItems.Count = 0 Then Exit Sub
        For i As Integer = 0 To dsDatos.Tables("Usuarios").Rows.Count - 1
            If dsDatos.Tables("Usuarios").Rows(i).Item("CodigoUsuario") = lvUsuarios.SelectedItems(0).Text Then
                vPosicionUsuario = i
                Exit For
            End If
        Next
        MostrarRegistro()
        cmdDesactivar.Enabled = True
        cmdEditar.Enabled = True

    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click

        gbEditar.Visible = False
        gbLista.Visible = True
        cmdEditar.Text = "EDITAR"
        cmdAgregar.Enabled = True
        cmdDesactivar.Enabled = False
        cmdEditar.Enabled = False

    End Sub


End Class