
Partial Class _Default
    Inherits System.Web.UI.Page


    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If radTo.Checked Then
            lblText.Text = "Choice: " & radTo.Text
        ElseIf radMtl.Checked Then
            lblText.Text = "Choice: " & radMtl.Text
        ElseIf radVcr.Checked Then
            lblText.Text = "Choice: " & radVcr.Text
        Else
            lblText.Text = "No choice made."
        End If

    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblResponse.Text = rblBorg.SelectedValue
        If Not IsPostBack Then
            'Used for the Checkbox List
            Dim arrlGames As New ArrayList
            arrlGames.Add(“Scrabble”)
            arrlGames.Add(“Crosswords”)
            arrlGames.Add(“WonderWord”)
            arrlGames.Add(“Sudoku”)
            arrlGames.Sort()
            CheckBoxList1.DataSource = arrlGames
            CheckBoxList1.DataBind()

            'Used for the Dropdown List
            Dim enClr As System.Drawing.KnownColor
            Dim clrs As New _
            System.Collections.Generic.List _
            (Of System.Drawing.KnownColor)
            clrs.AddRange(System.Enum.GetValues _
            (enClr.GetType()))
            DropDownList1.DataSource = clrs
            DropDownList1.DataBind()
            Panel1.Height = Unit.Pixel(200)
            Panel1.Width = Unit.Pixel(300)

            'Used for the ListBox

            Dim q = From f In System.Drawing.FontFamily.Families
                    Select f.Name
            ListBox1.DataSource = q
            ListBox1.DataBind()



        End If
    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim strSel As String = “”
        For Each chbx As ListItem In CheckBoxList1.Items
            If chbx.Selected Then
                strSel = strSel & chbx.Text & “<br />”
            End If
        Next
        Label1.Text = strSel

    End Sub

    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList1.SelectedIndexChanged
        Dim strClr As String
        strClr = DropDownList1.SelectedValue
        Dim objColor As System.Drawing.Color
        objColor =
        System.Drawing.ColorTranslator.FromHtml(strClr)
        Panel1.BackColor = objColor
        Label3.Text = strClr
    End Sub
    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim strItems As String = “”
        For Each itm In ListBox1.Items
            If itm.Selected Then
                strItems = strItems & itm.Text & “<br />”
            End If
        Next
        Label4.Text = strItems
    End Sub
End Class
