Imports System.Data
Imports System.Data.SqlClient

Public Class frmVentasParaAdministrador

    Dim cn As SqlConnection
    Dim dsdatos As DataSet
    Dim daBoletos As SqlDataAdapter


    Private Sub frmVentasParaAdministrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CrearGrilla()
        CrearDataset()
        LlenarDatosGrilla()


    End Sub

    Private Sub CrearDataset()
        cn = New SqlConnection(ConexionBD)
        dsdatos = New DataSet
        daBoletos = New SqlDataAdapter("ListarBoletaVenta", cn)
        daBoletos.Fill(dsdatos, "Boleto")


    End Sub

    Private Sub CrearGrilla()
        Dim colCodigoProducto As New DataGridViewTextBoxColumn
        colCodigoProducto.Width = 60
        colCodigoProducto.HeaderText = "CÓDIGO"
        colCodigoProducto.Name = "Codigo"
        colCodigoProducto.ReadOnly = True
        dgVentas.Columns.Add(colCodigoProducto)

        Dim colNumeroBoleta As New DataGridViewTextBoxColumn
        colNumeroBoleta.Width = 100
        colNumeroBoleta.HeaderText = "N° BOLETA"
        colNumeroBoleta.Name = "numero boleta"
        colNumeroBoleta.ReadOnly = True
        dgVentas.Columns.Add(colNumeroBoleta)

        Dim colNumeroSerie As New DataGridViewTextBoxColumn
        colNumeroSerie.Width = 100
        colNumeroSerie.HeaderText = "N° SERIE"
        colNumeroSerie.Name = "numero serie"
        colNumeroSerie.ReadOnly = True
        dgVentas.Columns.Add(colNumeroSerie)

        Dim colCliente As New DataGridViewTextBoxColumn
        colCliente.Width = 230
        colCliente.HeaderText = "CLIENTE"
        colCliente.Name = "cliente"
        colCliente.ReadOnly = True
        dgVentas.Columns.Add(colCliente)

        Dim ColVendedor As New DataGridViewTextBoxColumn
        ColVendedor.Width = 230
        ColVendedor.HeaderText = "VENDEDOR"
        ColVendedor.Name = "vendedor"
        ColVendedor.ReadOnly = True
        dgVentas.Columns.Add(ColVendedor)

        Dim colAsiento As New DataGridViewTextBoxColumn
        colAsiento.Width = 90
        colAsiento.HeaderText = "N° ASIENTO"
        colAsiento.Name = "asiento"
        colAsiento.ReadOnly = True
        dgVentas.Columns.Add(colAsiento)

        Dim colMonto As New DataGridViewTextBoxColumn
        colMonto.Width = 60
        colMonto.HeaderText = "MONTO"
        colMonto.Name = "monto"
        colMonto.ReadOnly = True
        dgVentas.Columns.Add(colMonto)

    End Sub

    Private Sub LlenarDatosGrilla()

        dgVentas.Rows.Clear()
        For i As Integer = 0 To dsdatos.Tables("Boleto").Rows.Count - 1
            Dim codigo As String = dsdatos.Tables("Boleto").Rows(i).Item("CodigoBoleto").ToString
            Dim numeroboleta As String = dsdatos.Tables("Boleto").Rows(i).Item("NumeroBoleta").ToString
            Dim numeroserie As String = dsdatos.Tables("Boleto").Rows(i).Item("NumerioSerie").ToString
            Dim codigocliente As String = dsdatos.Tables("Boleto").Rows(i).Item("CodigoCliente").ToString
            Dim vendedor As String = dsdatos.Tables("Boleto").Rows(i).Item("vendedor").ToString
            Dim asiento As String = dsdatos.Tables("Boleto").Rows(i).Item("NumeroAsiento").ToString
            Dim monto As Single = dsdatos.Tables("Boleto").Rows(i).Item("Monto").ToString
            dgVentas.Rows.Add(codigo, numeroboleta, numeroserie, codigocliente, vendedor, asiento, monto)
        Next

    End Sub

End Class