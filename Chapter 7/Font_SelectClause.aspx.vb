
Partial Class Font_SelectClause
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim q = From f In System.Drawing.FontFamily.Families
                Select f.Name
        For Each fnt As String In q
            Response.Write(fnt & “<br />”)
        Next

    End Sub
End Class
