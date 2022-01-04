<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Plaka:"></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="187px" AutoPostBack="True">
                <asp:ListItem Value="Lütfen Plaka Seçiniz">Lütfen Plaka Seçiniz</asp:ListItem>
                <asp:ListItem Value="35">35</asp:ListItem>
                <asp:ListItem Value="06"></asp:ListItem>
                <asp:ListItem Value="34"></asp:ListItem>
                <asp:ListItem Value="07"></asp:ListItem>
                <asp:ListItem>16</asp:ListItem>
            </asp:DropDownList>
            <asp:Label ID="Label2" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
