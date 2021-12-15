Public Class frmCambios

    Private Sub frmCambios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtResultado.Enabled = False
        txtapagar.Enabled = False
    End Sub

    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtResultado.Text = Val (txtPagocon.Text )-Val(txtapagar.Text)
    End Sub
End Class