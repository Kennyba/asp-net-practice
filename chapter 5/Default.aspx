<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>
<%@ Import Namespace="System.Linq"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">


        .auto-style1 {
            text-decoration: underline;
        }


    </style>
</head>
<body style="height: 1500px">
    <form id="form1" runat="server">
    <div style="height: 1000px">
    
        Text box<br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <span class="auto-style1">
        <br />
        <span class="auto-style2"><strong><em>Radio Button</em></strong></span></span><br />
        <br />
        <asp:RadioButton ID="radTo" runat="server" GroupName="cities" Text="Toronto" />
        <br />
        <asp:RadioButton ID="radMtl" runat="server" GroupName="cities" Text="Montreal" />
        <br />
        <asp:RadioButton ID="radVcr" runat="server" GroupName="cities" Text="Vancouver" />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" />
        <br />
        <asp:Label ID="lblText" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <span class="auto-style1"><span class="auto-style2"><strong><em>Radio Button List</em></strong></span><br />
        <br />
        <asp:Label ID="lblPrompt" runat="server" style="font-weight: 700" Text="Rate Your Fear of the Borg"></asp:Label>
        </span>
        <asp:RadioButtonList ID="rblBorg" runat="server">
            <asp:ListItem Value="3">Plenty</asp:ListItem>
            <asp:ListItem Value="2">Somewhat</asp:ListItem>
            <asp:ListItem Value="1">Whatever</asp:ListItem>
            <asp:ListItem Value="0">Zilch</asp:ListItem>
        </asp:RadioButtonList>
        <asp:Label ID="lblResponse" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Button ID="Button2" runat="server" Text="Button" />
        <br />
        <br />
        <span class="auto-style2"><strong><em>CheckBox and CheckBoxList</em></strong></span><br />
        <br />
        <asp:CheckBoxList ID="CheckBoxList1" runat="server" RepeatColumns="2" RepeatDirection="Horizontal">
        </asp:CheckBoxList>
        <asp:Button ID="Button3" runat="server" Text="Button" />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <span style="font-weight: 700; font-style: italic">DropDownList</span><br />
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        <br />
&nbsp;&nbsp;&nbsp;
        <br />
        <asp:Panel ID="Panel1" runat="server">
        </asp:Panel>
        <br />
        <strong><em>ListBox</em></strong>
        <br />
        

        <br />
        <asp:ListBox ID="ListBox1" runat="server" SelectionMode="Multiple"></asp:ListBox>
        

        <br />
        <br />
        <asp:Button ID="Button4" runat="server" Text="Button" />
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
        

    </div>
    </form>

</body>
</html>
