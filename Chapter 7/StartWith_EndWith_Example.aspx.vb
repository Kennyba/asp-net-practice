
Partial Class StartWith_EndWith_Example
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim names As String() =
        {"Elaine", "Brenda", "Julie", "Jaclyn"}
        Dim q = From s In names
                Where
                s.StartsWith("j",
                StringComparison.CurrentCultureIgnoreCase) _
                Or
                s.EndsWith("e",
                StringComparison.CurrentCultureIgnoreCase)

        BulletedList1.DataSource = q
        BulletedList1.DataBind()
    End Sub
End Class
