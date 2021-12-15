
Imports System.Data
Imports System.Data.SqlClient

Public Class frmAgregarCliente


    Private Sub frmAgregarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn = New SqlConnection(ConexionBD)
        txtDni.Text = Conexion.DNI
        txtDni.Enabled = False
    End Sub



    Dim cn As SqlConnection
    Dim dsDatos As DataSet
    Dim daClientes As SqlDataAdapter
    Dim mensaje As Integer = 0




    Private Sub Agregar(sender As Object, e As EventArgs) Handles cmdRegistrar.Click

        Dim sexo As String = ""
        Dim coAgregar As New SqlCommand("insertarCliente", cn)
        coAgregar.CommandType = CommandType.StoredProcedure

        coAgregar.Parameters.Add(New SqlParameter("@NombrePersona", SqlDbType.VarChar, 100, ParameterDirection.Input)).Value = txtNombre.Text
        coAgregar.Parameters.Add(New SqlParameter("@ApellidoPaternoPersona", SqlDbType.VarChar, 100, ParameterDirection.Input)).Value = txtApePaterno.Text
        coAgregar.Parameters.Add(New SqlParameter("@ApellidoMaternoPersona", SqlDbType.VarChar, 100, ParameterDirection.Input)).Value = txtApeMaterno.Text
        If rbSexoF.Checked Then
            sexo = "F"
        Else
            sexo = "M"
        End If

        coAgregar.Parameters.Add(New SqlParameter("@SexoPersona", SqlDbType.Char, 1, ParameterDirection.Input)).Value = sexo
        coAgregar.Parameters.Add(New SqlParameter("@FechaNacimientoPersona", SqlDbType.VarChar, 20, ParameterDirection.Input)).Value = dtpFechaNacimiento.Text
        coAgregar.Parameters.Add(New SqlParameter("@DNIPersona", SqlDbType.VarChar, 8, ParameterDirection.Input)).Value = txtDni.Text
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
            mensaje = 1
        Catch ex As Exception
            MessageBox.Show("NO SE PUDO AGREGAR REGISTRO", "ERROR..")
        End Try

        If mensaje = 1 Then
            Me.Close()

        End If
    End Sub
End Class
