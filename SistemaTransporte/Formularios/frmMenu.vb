Public Class frmMenu


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblHora.Text = TimeOfDay

    End Sub

    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdLogin.Click

        Dim frmlogin As Form = New frmLogin
        frmlogin.ShowDialog()

    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        frmParaOpcionesAdministrador.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogin_MouseEnter(sender As Object, e As EventArgs) Handles cmdLogin.MouseEnter
        cmdLogin.BackColor = Color.Beige
    End Sub
    Private Sub cmdLogin_MouseLeave(sender As Object, e As EventArgs) Handles cmdLogin.MouseLeave
        cmdLogin.BackColor = Color.White
    End Sub

    Private Sub cmdAcercaDe_MouseEnter(sender As Object, e As EventArgs) Handles cmdAcercaDe.MouseEnter
        cmdAcercaDe.BackColor = Color.Beige
    End Sub

    Private Sub cmdAcercaDe_MouseLeave(sender As Object, e As EventArgs) Handles cmdAcercaDe.MouseLeave
        cmdAcercaDe.BackColor = Color.White
    End Sub

    Private Sub cmdDestinos_MouseEnter(sender As Object, e As EventArgs) Handles cmdDestinos.MouseEnter
        cmdDestinos.BackColor = Color.Beige
    End Sub

    Private Sub cmdDestinos_MouseLeave(sender As Object, e As EventArgs) Handles cmdDestinos.MouseLeave
        cmdDestinos.BackColor = Color.White
    End Sub

    Private Sub lblHora_Click(sender As Object, e As EventArgs) Handles lblHora.Click


    End Sub
End Class