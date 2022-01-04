<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="WebApplication2.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem Value="0">Lütfen Seçiniz</asp:ListItem>
                <asp:ListItem Value="1">Kare</asp:ListItem>
                <asp:ListItem Value="2">Üçgen</asp:ListItem>
                <asp:ListItem Value="3">Daire</asp:ListItem>
            </asp:DropDownList>
            <asp:Label ID="LblSonuc" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Panel ID="Panel1" runat="server">
            </asp:Panel>
            <asp:Panel ID="PnlKare" runat="server" Visible="False">
                <asp:Label ID="Label1" runat="server" Text="Kara Alan Hesabı"></asp:Label>
                <br />
                <asp:Label ID="Label2" runat="server" Text="Kenar"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Hesapla" />
            </asp:Panel>
            <asp:Panel ID="PnlUcgen" runat="server" Visible="False">
                <asp:Label ID="Label3" runat="server" Text="Üçgen Alan Hesabı"></asp:Label>
                <br />
                <asp:Label ID="Label4" runat="server" Text="Taban"></asp:Label>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <asp:Label ID="Label5" runat="server" Text="Yükseklik"></asp:Label>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                <asp:Button ID="Button2" runat="server" Text="Hesapla" OnClick="Button2_Click" />
            </asp:Panel>
            <asp:Panel ID="PnlDaire" runat="server" Visible="False">
                <asp:Label ID="Label6" runat="server" Text="Daire Alan Hesabı"></asp:Label>
                <br />
                <asp:Label ID="Label7" runat="server" Text="Yarı Çap"></asp:Label>
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Hesapla" />
            </asp:Panel>
        </div>
    </form>
</body>
</html>
