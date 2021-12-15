

Imports System.Data
Imports System.Data.SqlClient



Public Class frmParaOpcionesAdministrador


    Dim cn As SqlConnection
    Dim dsDatos As DataSet
    Dim daUsuarios As SqlDataAdapter


    Private Sub OpcionUsaurios(sender As Object, e As EventArgs) Handles cmdUsuarios.Click, Button6.Click

         Me.WindowState = FormWindowState.Maximized
        frmUsuariosListado.Show()

    End Sub

    Private Sub frmParaOpcionesAdministrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        txtUser.Hide()
        '--------------------------------------------------------------------------------------------
        cn = New SqlConnection(ConexionBD)
        dsDatos = New DataSet
        txtUser.Text = Conexion.UsuarioAccesoDatos


        '------------------------------------------------------------------------------------------
        Dim CoUsuarios As New SqlCommand("DatosUsuariosAccesos", cn)
        CoUsuarios.CommandType = CommandType.StoredProcedure
        'parametros
        CoUsuarios.Parameters.Add(New SqlParameter("@User", SqlDbType.Char, 20)).Value = txtUser.Text
        'adaptador para los usuarios
        Dim daUsuariosa As New SqlDataAdapter("DatosUsuariosAccesos", cn)
        daUsuariosa.SelectCommand = CoUsuarios

        daUsuariosa.Fill(dsDatos, "Usuarios")
        llenarUsuarios()
        UsuarioAccesoDatos = ""
    End Sub


    Private Sub llenarUsuarios()
        lblUsuario.Text = "ADMINISTRADOR :  " & dsDatos.Tables("Usuarios").Rows(0).Item("datpersona").ToString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmMantenedorClientes.ShowDialog()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        frmRepostesClientes.ShowDialog()
    End Sub

   
    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        frmVentasParaAdministrador.ShowDialog()
    End Sub

    Private Sub cmdAgregarBus_Click(sender As Object, e As EventArgs) Handles cmdAgregarBus.Click
        frmBuses.ShowDialog()
    End Sub
End Class