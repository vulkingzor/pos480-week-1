Public Class HelloForm

    Private Sub btnLanguage_Click(sender As Object, e As EventArgs) Handles btnLanguage.Click
        If Me.lblHello.Text = "Hello" Then
            Me.lblHello.Text = "Bonjour"
        ElseIf Me.lblHello.Text = "Bonjour" Then
            Me.lblHello.Text = "Hola"
        Else
            Me.lblHello.Text = "Hello"
        End If
    End Sub
    Private Sub btnColor_Click(sender As Object, e As EventArgs) Handles btnColor.Click
        If Me.lblHello.ForeColor = Color.Black Then
            Me.lblHello.ForeColor = Color.Crimson
        ElseIf Me.lblHello.ForeColor = Color.Crimson Then
            Me.lblHello.ForeColor = Color.DarkSalmon
        Else
            Me.lblHello.ForeColor = Color.Black
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()

    End Sub

    Private Sub lblHello_Click(sender As Object, e As EventArgs) Handles lblHello.Click

    End Sub
End Class