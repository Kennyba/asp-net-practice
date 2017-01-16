
Partial Class Sum_Example
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim dc As New NWDataClassesDataContext
        Dim q = (From p In dc.Products
                 Select p.UnitPrice).Sum()
        Label1.Text = “The total is “ &
        Format(q, “C”)
    End Sub
End Class
