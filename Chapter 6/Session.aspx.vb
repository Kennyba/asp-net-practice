
Partial Class Session
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Session(“strCountry”) = TextBox1.Text

    End Sub
End Class
