
Partial Class Count_Example
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Dim q = From f In New System.IO.DirectoryInfo _
            (Server.MapPath("~")).GetFiles()
                    Select f
                    Where f.Extension = ".aspx"
            Label1.Text = "ASPX count: " & q.Count().ToString()
            GridView1.DataSource = q
            GridView1.DataBind()
        Catch ex As Exception
            Label1.Text = "Not allowed to do that!"
        End Try
    End Sub
End Class
