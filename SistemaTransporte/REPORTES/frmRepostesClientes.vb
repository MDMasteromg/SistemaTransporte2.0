
Imports System.Data
Imports System.Data.SqlClient
Public Class frmRepostesClientes


    Private Sub frmRepostesClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cn As New SqlConnection(ConexionBD)
        Dim dsReportesClientes As New dsDatosReporte
        Dim daPersonas As New SqlDataAdapter("select * from Persona", cn)
        Dim daClientes As New SqlDataAdapter("select * from Clientes", cn)
        daPersonas.Fill(dsReportesClientes, "Persona")
        daClientes.Fill(dsReportesClientes, "Clientes")

        Dim oReporteClientes As New ReporteClientes
        oReporteClientes.SetDataSource(dsReportesClientes)
        crClientes.ReportSource = oReporteClientes
    End Sub

End Class