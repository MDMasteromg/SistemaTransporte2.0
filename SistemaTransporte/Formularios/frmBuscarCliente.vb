



Imports System.Data
Imports System.Data.SqlClient


Public Class frmCliente
    Dim cn As SqlConnection
    Dim dsDatos As DataSet
    Dim daClientes As SqlDataAdapter
    Dim dvClinentesBusqueda As DataView
    Dim vCourierPosicion As Integer


    Private Sub frmCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CrearDataset()
        LlenarLista()

    End Sub

    Private Sub CrearDataset()
        cn = New SqlConnection(ConexionBD)
        dsDatos = New DataSet
        daClientes = New SqlDataAdapter("BuscarClientes", cn)
        daClientes.Fill(dsDatos, "Clientes")

        dvClinentesBusqueda = New DataView(dsDatos.Tables("Clientes"), "CodigoCliente like '%'", "NombrePersona asc", DataViewRowState.OriginalRows)
        dvClinentesBusqueda = New DataView(dsDatos.Tables("Clientes"), "NombrePersona like '%'", "NombrePersona asc", DataViewRowState.OriginalRows)
        dvClinentesBusqueda = New DataView(dsDatos.Tables("Clientes"), "DNIPersona like '%'", "NombrePersona asc", DataViewRowState.OriginalRows)
        LlenarLista()
    End Sub

    Private Sub LlenarLista()

        lvClientes.Items.Clear()

        For i As Integer = 0 To dvClinentesBusqueda.Count - 1
            lvClientes.Items.Add(dvClinentesBusqueda.Item(i).Item("CodigoCliente"))
            lvClientes.Items(i).SubItems.Add(dvClinentesBusqueda.Item(i).Item("DNIPersona"))
            lvClientes.Items(i).SubItems.Add(dvClinentesBusqueda.Item(i).Item("NombrePersona"))
            lvClientes.Items(i).SubItems.Add(dvClinentesBusqueda.Item(i).Item("Apellidos"))
            lvClientes.Items(i).SubItems.Add(dvClinentesBusqueda.Item(i).Item("DireccionPersona"))
            lvClientes.Items(i).SubItems.Add(dvClinentesBusqueda.Item(i).Item("TelefonoPersona"))
            lvClientes.Items(i).SubItems.Add(dvClinentesBusqueda.Item(i).Item("RucCliente"))
            lvClientes.Items(i).SubItems.Add(dvClinentesBusqueda.Item(i).Item("SexoPersona"))
        Next
    End Sub

    Private Sub FiltraDatos()

        If rbCodigo.Checked = True Then

            dvClinentesBusqueda.RowFilter = "CodigoCliente like '" + Trim(txtBusqueda.Text) + "%'"

        ElseIf rbDNI.Checked = True Then
            dvClinentesBusqueda.RowFilter = "DNIPersona like'" + Trim(txtBusqueda.Text) + "%'"

        ElseIf rbNombre.Checked = True Then
            dvClinentesBusqueda.RowFilter = "NombrePersona like'" + Trim(txtBusqueda.Text) + "%'"
        End If
        LlenarLista()



    End Sub

    Private Sub rbCodigo_CheckedChanged(sender As Object, e As EventArgs) Handles rbCodigo.CheckedChanged
        FiltraDatos()
    End Sub

    Private Sub rbDNI_CheckedChanged(sender As Object, e As EventArgs) Handles rbDNI.CheckedChanged
        FiltraDatos()
    End Sub

    Private Sub rbNombre_CheckedChanged(sender As Object, e As EventArgs) Handles rbNombre.CheckedChanged
        FiltraDatos()
    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        FiltraDatos()
    End Sub

    Private Sub lvClientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvClientes.DoubleClick

        BCodigoCliente = lvClientes.SelectedItems(0).Text
        clienteencontrado = 1
        Me.Close()
    End Sub

    
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If lblMensaje.Visible = True Then
            lblMensaje.Visible = False
        Else
            lblMensaje.Visible = True
        End If

        If lblMensaje2.Visible = True Then
            lblMensaje2.Visible = False
        Else
            lblMensaje2.Visible = True
        End If


    End Sub
End Class