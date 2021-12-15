

Imports System.Data
Imports System.Data.SqlClient


Public Class frmVentas
    Dim cn As SqlConnection
    Dim dsDatos As DataSet
    Dim daUsuarios As SqlDataAdapter

   

    Private Sub frmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtuser.Hide()
        cn = New SqlConnection(ConexionBD)
        dsDatos = New DataSet
        txtuser.Text = Conexion.UsuarioAccesoDatos


        Dim CoUsuarios As New SqlCommand("DatosUsuariosAccesos", cn)
        CoUsuarios.CommandType = CommandType.StoredProcedure
        'parametros
        CoUsuarios.Parameters.Add(New SqlParameter("@User", SqlDbType.Char, 20)).Value = txtuser.Text
        'adaptador para los usuarios
        Dim daUsuariosa As New SqlDataAdapter("DatosUsuariosAccesos", cn)
        daUsuariosa.SelectCommand = CoUsuarios

        daUsuariosa.Fill(dsDatos, "Usuarios")
        llenarUsuario()
        ObtenerCodigoUsuario()



        sbFechas.Text = "                       FECHA:   " & Format(Microsoft.VisualBasic.Now.Date(), "Short Date")
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        sbHora.Text = "        HORA:  " & TimeOfDay
    End Sub

    Private Sub BUSCARCLIENTEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BUSCARCLIENTEToolStripMenuItem.Click

        Dim fCliente As New frmCliente
        Dim fPadre As frmVentas = Me
        Dim f As Form
        For Each f In fPadre.MdiChildren
            If f.Name = fCliente.Name Then
                f.Select()
                Exit Sub
            End If
        Next
        fCliente.MdiParent = Me
        fCliente.Show()

    End Sub

    Private Sub MANTENEDORCLIENTEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MANTENEDORCLIENTEToolStripMenuItem.Click
        Dim fMantenedroCliente As New frmMantenedorClientes
        Dim fPadre As frmVentas = Me
        Dim f As Form
        For Each f In fPadre.MdiChildren
            If f.Name = fMantenedroCliente.Name Then
                f.Select()
                Exit Sub
            End If
        Next
        fMantenedroCliente.MdiParent = Me
        fMantenedroCliente.Show()
    End Sub

    
    Private Sub llenarUsuario()

        sbUsuario.Text = "BIENVENIDO :   " & dsDatos.Tables("Usuarios").Rows(0).Item("datpersona").ToString

    End Sub

    Private Sub ObtenerCodigoUsuario()
        Conexion.UsuarioAccesoCodigo = dsDatos.Tables("Usuarios").Rows(0).Item("CodigoUsuario").ToString
    End Sub

  
    Private Sub FACTURACIONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FACTURACIONToolStripMenuItem.Click
        Dim fBuses As New frmSeleccionarBus
        Dim fPadre As frmVentas = Me
        Dim f As Form
        For Each f In fPadre.MdiChildren
            If f.Name = fBuses.Name Then
                f.Select()
                Exit Sub
            End If
        Next
        fBuses.MdiParent = Me
        fBuses.Show()
    End Sub
End Class