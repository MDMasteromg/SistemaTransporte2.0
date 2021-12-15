
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class frmBuses

    Dim cn As SqlConnection
    Dim dsDatos As DataSet
    Dim daBuses As SqlDataAdapter
    Dim msFotoBus As New MemoryStream
    Dim Posicion As Integer

    Private Sub Agregar(sender As Object, e As EventArgs) Handles cmdAgregar.Click

        If cmdAgregar.Text = "AGREGAR" Then
            cmdAgregar.Text = "GUARDAR"
            cmdEditar.Enabled = False
            cmdEliminar.Enabled = False
            txtCapacidad.Enabled = True
            txtCodigo.Enabled = True
            txtPlaca.Enabled = True
            txtCapacidad.Clear()
            txtCodigo.Clear()
            txtPlaca.Clear()

        Else
            Try

                Dim FotoBus() As Byte
                Dim coInsertarBus As New SqlCommand("InsertarBus", cn)
                coInsertarBus.CommandType = CommandType.StoredProcedure
                coInsertarBus.Parameters.Add("@CodigoBus", SqlDbType.NChar).Value = txtCodigo.Text
                coInsertarBus.Parameters.Add("@Capacidad", SqlDbType.Int).Value = txtCapacidad.Text
                coInsertarBus.Parameters.Add("@PlacaBus", SqlDbType.Char).Value = txtPlaca.Text
                If Me.pbImagen.ImageLocation = "" Then
                    Dim p(0) As Byte
                    coInsertarBus.Parameters.Add("@Foto", SqlDbType.Image).Value = p
                Else
                    pbImagen.Image.Save(msFotoBus, Imaging.ImageFormat.Jpeg)
                    FotoBus = msFotoBus.ToArray
                    coInsertarBus.Parameters.Add("@Foto", SqlDbType.Image).Value = FotoBus
                End If
                cn.Open()
                coInsertarBus.ExecuteNonQuery()
                cn.Close()
                MessageBox.Show("NUEVO BUS AGREGADO", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("ERRO AL REGISTRAR BUS", "Error")
            Finally
                If cn.State <> ConnectionState.Closed Then
                    cn.Close()
                End If
            End Try
            cmdEditar.Enabled = True
            cmdEliminar.Enabled = True
            cmdAgregar.Text = "AGREGAR"
            txtCapacidad.Enabled = False
            txtCodigo.Enabled = False
            txtPlaca.Enabled = False
        End If
    End Sub

    Private Sub frmBuses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        crearDataset()  
        MostarRegistro()
        LlenarLista()
    End Sub

  

    Private Sub LlenarLista()
        lvBuses.Items.Clear()

        For i As Integer = 0 To dsDatos.Tables("Buses").Rows.Count - 1
            lvBuses.Items.Add(dsDatos.Tables("Buses").Rows(i).Item("CodigoBus"))
            lvBuses.Items(i).SubItems().Add(dsDatos.Tables("Buses").Rows(i).Item("CapacidadBus"))
            lvBuses.Items(i).SubItems.Add(dsDatos.Tables("Buses").Rows(i).Item("PlacaBus"))
        Next
    End Sub

    Private Sub MostarRegistro()
        txtCodigo.Text = dsDatos.Tables("Buses").Rows(Posicion).Item("CodigoBus")
        txtCapacidad.Text = dsDatos.Tables("Buses").Rows(Posicion).Item("CapacidadBus")
        txtPlaca.Text = dsDatos.Tables("Buses").Rows(Posicion).Item("PlacaBus")
        Try
            Dim ImagenBit As Byte() = CType(dsDatos.Tables("Buses").Rows(Posicion).Item("FotoBus"), Byte())
            Dim memorybits As New MemoryStream(ImagenBit)
            Dim Mapabits As New Bitmap(memorybits)
            pbImagen.Image = Mapabits
        Catch ex As Exception
            pbImagen.Image = Nothing
        End Try

    End Sub

    Private Sub crearDataset()
        cn = New SqlConnection(ConexionBD)
        dsDatos = New DataSet
        daBuses = New SqlDataAdapter("ListarBuses", cn)
        daBuses.Fill(dsDatos, "Buses")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles cmdBuscarFoto.Click
        Dim BuscarFoto As New OpenFileDialog
        BuscarFoto.Filter = "Archivo de Imagen|*.jpg"
        If BuscarFoto.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.pbImagen.ImageLocation = BuscarFoto.FileName
        End If
    End Sub

    Private Sub EDITAR(sender As Object, e As EventArgs) Handles cmdEditar.Click
        If cmdEditar.Text = "EDITAR" Then
            cmdEditar.Text = "GRABAR"
            cmdAgregar.Enabled = False
            cmdEliminar.Enabled = False
            txtCapacidad.Enabled = True
            txtCodigo.Enabled = True
            txtPlaca.Enabled = True
            lvBuses.Enabled = False


        Else
            Try

                Dim FotoBus() As Byte
                Dim coInsertarBus As New SqlCommand("EditarBus", cn)
                coInsertarBus.CommandType = CommandType.StoredProcedure
                coInsertarBus.Parameters.Add("@CodigoBus", SqlDbType.NChar).Value = txtCodigo.Text
                coInsertarBus.Parameters.Add("@Capacidad", SqlDbType.Int).Value = txtCapacidad.Text
                coInsertarBus.Parameters.Add("@PlacaBus", SqlDbType.Char).Value = txtPlaca.Text
                If Me.pbImagen.ImageLocation = "" Then
                    Dim p(0) As Byte
                    coInsertarBus.Parameters.Add("@Foto", SqlDbType.Image).Value = p
                Else
                    pbImagen.Image.Save(msFotoBus, Imaging.ImageFormat.Jpeg)
                    FotoBus = msFotoBus.ToArray
                    coInsertarBus.Parameters.Add("@Foto", SqlDbType.Image).Value = FotoBus
                End If
                cn.Open()
                coInsertarBus.ExecuteNonQuery()
                cn.Close()
                MessageBox.Show("SE EDITO CORRECTAMENTE", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("ERRO AL EDITAR", "Error")
            Finally
                If cn.State <> ConnectionState.Closed Then
                    cn.Close()
                End If
            End Try
            crearDataset()
            cmdAgregar.Enabled = True
            cmdEliminar.Enabled = True
            cmdEditar.Text = "EDITAR"
            txtCapacidad.Enabled = False
            txtCodigo.Enabled = False
            txtPlaca.Enabled = False
            lvBuses.Enabled = True
        End If
    End Sub

    
   

    Private Sub lvBuses_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvBuses.SelectedIndexChanged
        If lvBuses.SelectedItems.Count = 0 Then Exit Sub

        For i As Integer = 0 To dsDatos.Tables("Buses").Rows.Count - 1
            If dsDatos.Tables("Buses").Rows(i).Item("CodigoBus") = lvBuses.SelectedItems(0).Text Then
                Posicion = i

            End If
        Next
        MostarRegistro()
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        cmdEditar.Enabled = True
        cmdEliminar.Enabled = True
        txtCapacidad.Enabled = False
        txtCodigo.Enabled = False
        txtPlaca.Enabled = False
        MostarRegistro()
        cmdAgregar.Enabled = True
        cmdAgregar.Text = "AGREGAR"
        cmdEditar.Text = "EDITAR"
        lvBuses.Enabled = True
    End Sub


    Private Sub cmdEliminar_Click(sender As Object, e As EventArgs) Handles cmdEliminar.Click

        If MessageBox.Show("¿Desea Eliminar :   " & txtPlaca.Text & "?", "Eliminacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            Dim coEliminar As New SqlCommand("EliminarBus", cn)
            coEliminar.CommandType = CommandType.StoredProcedure

            coEliminar.Parameters.Add(New SqlParameter("@CodigoBus", SqlDbType.NChar, 4, ParameterDirection.Input)).Value = txtCodigo.Text

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
            crearDataset()
            LlenarLista()
            MostarRegistro()
        End If
    End Sub
End Class