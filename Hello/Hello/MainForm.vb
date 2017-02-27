Public Class MainForm

    Dim frmHello As New HelloForm

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnHello_Click(sender As Object, e As EventArgs) Handles btnHello.Click
        frmHello.Show()

    End Sub

    Private Sub lblProgram_Click(sender As Object, e As EventArgs) Handles lblProgram.Click

    End Sub
End Class
