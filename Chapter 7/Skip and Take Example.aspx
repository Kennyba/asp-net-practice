<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Skip and Take Example.aspx.vb" Inherits="Skip_and_Take_Example" %>
<%@ Import Namespace="System.Linq" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <asp:Button ID="Button1" runat="server" Text="Button" />
        <br />
    
    </div>
    </form>
</body>
</html>
