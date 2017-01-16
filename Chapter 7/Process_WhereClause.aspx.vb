
Partial Class Process_WhereClause
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim q = From p In
                System.Diagnostics.Process.GetProcesses()
                Select p.Id, p.ProcessName, p.PrivateMemorySize64
                Where PrivateMemorySize64 > 1000000
        GridView1.DataSource = q
        GridView1.DataBind()

    End Sub
End Class
