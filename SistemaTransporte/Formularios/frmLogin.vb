
Imports System.Data
Imports System.Data.SqlClient


Public Class frmLogin

    Private Sub Ingresar(sender As Object, e As EventArgs) Handles cmdLogin.Click

      
        Conexion.UsuarioAccesoDatos = txtUser.Text
      
        Dim cn As New SqlConnection(ConexionBD)
        Dim coAcceso As New SqlCommand("spAccesoSistema", cn)
        coAcceso.CommandType = CommandType.StoredProcedure


        coAcceso.Parameters.Add(New SqlParameter("@User", SqlDbType.Char, 20)).Value = txtUser.Text
        coAcceso.Parameters.Add(New SqlParameter("@pass", SqlDbType.Char, 20)).Value = txtPassword.Text
        'parametro de valor de retorno
        Dim paRetorno As New SqlParameter
        paRetorno.ParameterName = "@ValorRetornado"
        paRetorno.Direction = ParameterDirection.ReturnValue
        paRetorno.SqlDbType = SqlDbType.Int
        coAcceso.Parameters.Add(paRetorno)

        cn.Open()
        coAcceso.ExecuteNonQuery()
        Dim VRetorno As Integer = coAcceso.Parameters("@ValorRetornado").Value
        cn.Close()
        If VRetorno = 1 Then

            frmMenu.Hide()
            Me.Hide()
            frmVentas.Show()

        ElseIf VRetorno = 2 Then
            frmMenu.Hide()
            Me.Hide()
            frmParaOpcionesAdministrador.Show()
        Else
            MessageBox.Show("usuario o clave incorrecta")

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles cmdCerrar.Click
        Me.Close()

    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles cmdLogin.MouseEnter
        cmdLogin.Size = cmdLogin.MaximumSize

    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles cmdLogin.MouseLeave
        cmdLogin.Size = cmdLogin.MinimumSize

    End Sub

    Private Sub Button2_MouseEnter(sender As Object, e As EventArgs) Handles cmdCerrar.MouseEnter
        cmdCerrar.Size = cmdCerrar.MaximumSize

    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles cmdCerrar.MouseLeave
        cmdCerrar.Size = cmdCerrar.MinimumSize

    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
