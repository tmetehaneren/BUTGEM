<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="WebApplication2.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem Value="0">Lütfen İl Seçiniz</asp:ListItem>
                <asp:ListItem Value="1">Bursa</asp:ListItem>
                <asp:ListItem Value="2">İstanbul</asp:ListItem>
                <asp:ListItem Value="3">İzmir</asp:ListItem>
            </asp:DropDownList>
        </div>
        <asp:Panel ID="Panel1" runat="server" Visible="False"> <li
            Osmangazi<br /> Nilüfer<br /> Yıldırım<br />
        </asp:Panel>
        <asp:Panel ID="Panel2" runat="server" Visible="False">
        </asp:Panel>
        <asp:Panel ID="Panel3" runat="server" Visible="False">
        </asp:Panel>
    </form>
</body>
</html>
