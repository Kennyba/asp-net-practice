<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Session.aspx.vb" Inherits="Session" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" />
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/starter.aspx">HyperLink</asp:HyperLink>
    
    </div>
    </form>
</body>
</html>
