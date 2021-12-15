
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class frmSeleccionarBus

    Dim cn As SqlConnection
    Dim dsDatos As DataSet
    Dim daBuses As SqlDataAdapter
    Dim Posicion As Integer

    Private Sub frmSeleccionarBus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CrearDataset()
        LlenarLista()
        MostarDatos()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pcbImagen.Click
        Conexion.PlacaBus = lblPlaca.Text
        Conexion.CodigoBus = lblCodigo.Text
        Me.Hide()
        frmAsientos.Show()
    End Sub

    Private Sub CrearDataset()
        cn = New SqlConnection(ConexionBD)
        dsDatos = New DataSet
        daBuses = New SqlDataAdapter("ListarBuses", cn)
        daBuses.Fill(dsDatos, "Buses")
    End Sub


    Private Sub LlenarLista()
        lvBus.Items.Clear()
        For i As Integer = 0 To dsDatos.Tables("Buses").Rows.Count - 1
            lvBus.Items.Add(dsDatos.Tables("Buses").Rows(i).Item("CodigoBus").ToString)
            lvBus.Items(i).SubItems.Add(dsDatos.Tables("Buses").Rows(i).Item("PlacaBus").ToString)
            lvBus.Items(i).SubItems.Add(dsDatos.Tables("Buses").Rows(i).Item("CapacidadBus").ToString)
        Next
    End Sub


    Private Sub MostarDatos()
        lblCodigo.Text = dsDatos.Tables("Buses").Rows(Posicion).Item("CodigoBus").ToString
        lblPlaca.Text = dsDatos.Tables("Buses").Rows(Posicion).Item("PlacaBus").ToString
        lblCapacidad.Text = dsDatos.Tables("Buses").Rows(Posicion).Item("CapacidadBus").ToString
        Try
            Dim ImagenBit As Byte() = CType(dsDatos.Tables("Buses").Rows(Posicion).Item("FotoBus"), Byte())
            Dim memorybits As New MemoryStream(ImagenBit)
            Dim Mapabits As New Bitmap(memorybits)
            pcbImagen.Image = Mapabits
        Catch ex As Exception
            pcbImagen.Image = Nothing
        End Try
    End Sub

    Private Sub lvBus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvBus.SelectedIndexChanged

        If lvBus.SelectedItems.Count = 0 Then Exit Sub

        For i As Integer = 0 To dsDatos.Tables("Buses").Rows.Count - 1
            If dsDatos.Tables("Buses").Rows(i).Item("CodigoBus") = lvBus.SelectedItems(0).Text Then
                Posicion = i

            End If
        Next
        MostarDatos()
    End Sub
End Class