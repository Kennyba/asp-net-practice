
Partial Class Min_Max_Example
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim dc As New NWDataClassesDataContext
        Dim q = From p In dc.Products
                Select p.UnitPrice
        Label1.Text = "The cheapest item is " &
        Format(q.Min, "C") &
        " and the most expensive is " &
        Format(q.Max, "C")
    End Sub
End Class
