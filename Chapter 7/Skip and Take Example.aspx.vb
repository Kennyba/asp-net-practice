
Partial Class Skip_and_Take_Example
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            GetData()
        End If
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GetData()
    End Sub
    Protected Sub GetData()
        Dim intPos As Integer = 0
        If IsNothing(ViewState("pos")) Then
            ViewState("pos") = 0
        Else
            intPos = Convert.ToInt32(ViewState("pos")) + 5
            ViewState("pos") = intPos
        End If
        Dim q =
        From c In
        System.Globalization.CultureInfo.GetCultures(2)
        Select c.EnglishName
        Order By EnglishName Skip (intPos) Take (5)
        GridView1.DataSource = q
        GridView1.DataBind()
    End Sub
End Class
