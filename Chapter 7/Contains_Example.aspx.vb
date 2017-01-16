
Partial Class Contains_Example
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim dc As New NWDataClassesDataContext
        Dim q = From p In dc.Products
                Select p
                Where p.ProductName.Contains("co")
        GridView1.DataSource = q
        GridView1.DataBind()
    End Sub
End Class
