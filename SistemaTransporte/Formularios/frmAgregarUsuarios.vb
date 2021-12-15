

Imports System.Data
Imports System.Data.SqlClient



Public Class frmAgregarUsuarios

    Dim cn As SqlConnection
    Dim dsDatos As DataSet
    Dim daUsuarios As SqlDataAdapter

    Private Sub limpiar()
        txtApellidoMaterno.Clear()
        txtApellidoPaterno.Clear()
        txtDireccion.Clear()
        txtDNI.Clear()
        txtEmail.Clear()
        txtNombre.Clear()
        txtTelefono.Clear()

    End Sub


    Private Sub frmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If VaciarCajas = 1 Then
            limpiar()
        End If

        CrearDataset()
        llenarCombo()


    End Sub

    Private Sub CrearDataset()

        cn = New SqlConnection(ConexionBD)
        dsDatos = New DataSet
        daUsuarios = New SqlDataAdapter("ListadoTipoUsuarioParaUsuario", cn)
        daUsuarios.Fill(dsDatos, "TipoUsuarios")

    End Sub

    Private Sub llenarCombo()

        cboUsuarios.DataSource = dsDatos.Tables("TipoUsuarios")
        cboUsuarios.DisplayMember = "DescripcionTipoUsuario"
        cboUsuarios.ValueMember = "CodigoTipoUsuario"

    End Sub

    Dim mensaje As Integer

    Private Sub Guardar(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Actualizar = 0
        Dim coGuardar As New SqlCommand("InsertarUsuarios", cn)
        coGuardar.CommandType = CommandType.StoredProcedure

        coGuardar.Parameters.Add(New SqlParameter("@NombrePersona", SqlDbType.VarChar, 100, ParameterDirection.Input)).Value = txtNombre.Text
        coGuardar.Parameters.Add(New SqlParameter("@ApellidoPaternoPersona", SqlDbType.VarChar, 100, ParameterDirection.Input)).Value = txtApellidoPaterno.Text
        coGuardar.Parameters.Add(New SqlParameter("@ApellidoMaternoPersona", SqlDbType.VarChar, 100, ParameterDirection.Input)).Value = txtApellidoMaterno.Text
        coGuardar.Parameters.Add(New SqlParameter("@SexoPersona", SqlDbType.Char, 1, ParameterDirection.Input)).Value = cboSexo.SelectedItem
        coGuardar.Parameters.Add(New SqlParameter("@FechaNacimientoPersona", SqlDbType.VarChar, 20, ParameterDirection.Input)).Value = dtpFechaN.Text
        coGuardar.Parameters.Add(New SqlParameter("@DNIPersona", SqlDbType.VarChar, 8, ParameterDirection.Input)).Value = txtDNI.Text
        coGuardar.Parameters.Add(New SqlParameter("@DireccionPersona", SqlDbType.VarChar, 50, ParameterDirection.Input)).Value = txtDireccion.Text
        coGuardar.Parameters.Add(New SqlParameter("@TelefonoPersona", SqlDbType.VarChar, 20, ParameterDirection.Input)).Value = txtTelefono.Text
        coGuardar.Parameters.Add(New SqlParameter("@EmailPersona", SqlDbType.VarChar, 50, ParameterDirection.Input)).Value = txtEmail.Text
        coGuardar.Parameters.Add(New SqlParameter("@Estado", SqlDbType.Char, 1, ParameterDirection.Input)).Value = "A"
        coGuardar.Parameters.Add(New SqlParameter("@CodiTipoUsuario", SqlDbType.NChar, 4, ParameterDirection.Input)).Value = cboUsuarios.SelectedValue


        If cn.State <> ConnectionState.Closed Then
            cn.Close()
        End If

        Try

            cn.Open()
            coGuardar.ExecuteNonQuery()
            cn.Close()
            MessageBox.Show("Usuario Registrado...")
            mensaje = 1
            Actualizar = 1
        Catch ex As Exception
            MessageBox.Show("Erros Al InsertarUsuario...")

        End Try

        If mensaje = 1 Then
            Me.Close()
        End If


    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Me.Close()

    End Sub
End Class