
Partial Class Like_Example
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim q = From sv As String In Request.ServerVariables
                Select sv
                Where sv Like "*SERVER*"
        GridView1.DataSource = q
        GridView1.DataBind()
    End Sub
End Class
