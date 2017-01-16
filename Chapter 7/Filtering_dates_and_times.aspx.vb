
Partial Class Filtering_dates_and_times
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim cinfo As New System.Globalization.CultureInfo("en-CA")
        Dim dt(2) As Date
        dt(0) = Date.Parse("December 24, 2007", cinfo)
        dt(1) = Date.Parse("May 22, 2008", cinfo)
        dt(2) = Date.Parse("February 10, 2008", cinfo)
        Dim q = From d In dt
                Where d > DateTime.ParseExact _
                ("January 13, 2008", "D", cinfo)
                Select d.ToLongDateString
        CheckBoxList1.DataSource = q
        CheckBoxList1.DataBind()

    End Sub
End Class
