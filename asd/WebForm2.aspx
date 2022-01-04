<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication2.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="166px">
                <asp:ListItem Value="0">Lütfen Seçiniz...</asp:ListItem>
                <asp:ListItem Value="1">0-6</asp:ListItem>
                <asp:ListItem Value="2">7-12</asp:ListItem>
                <asp:ListItem Value="3">13-18</asp:ListItem>
                <asp:ListItem Value="4">19-23</asp:ListItem>
            </asp:DropDownList>
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
