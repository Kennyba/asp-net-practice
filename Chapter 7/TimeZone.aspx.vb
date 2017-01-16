
Partial Class TimeZone
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim q = From tz In System.TimeZoneInfo.GetSystemTimeZones
        For Each tz As TimeZoneInfo In q
            Response.Write(tz.DisplayName & “<br />”)
        Next
        GridView1.DataSource = q
        GridView1.DataBind()

    End Sub
End Class
