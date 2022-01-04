<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebApplication2.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="104px">
                <asp:ListItem Value="0">Lütfen İl Seçiniz</asp:ListItem>
                <asp:ListItem Value="16">Bursa</asp:ListItem>
                <asp:ListItem Value="06">Ankara</asp:ListItem>
                <asp:ListItem Value="34">İstanbul</asp:ListItem>
                <asp:ListItem Value="35">İzmir</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:ListBox ID="ListBox1" runat="server" Height="97px" Width="107px"></asp:ListBox>
        </div>
    </form>
</body>
</html>
