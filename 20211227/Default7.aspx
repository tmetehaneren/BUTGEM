<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default7.aspx.cs" Inherits="WebApplication2.Default7" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="1.Sayı"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Text="2.Sayı"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Hesapla" />
            <asp:Label ID="Label3" runat="server"></asp:Label>
            <br />
            <asp:RadioButton ID="RadioButton1" runat="server" GroupName="islem" Text="Topla" />
            <asp:RadioButton ID="RadioButton2" runat="server" GroupName="islem" Text="Çıkar" />
            <asp:RadioButton ID="RadioButton3" runat="server" GroupName="islem" Text="Böl" />
            <asp:RadioButton ID="RadioButton4" runat="server" GroupName="islem" Text="Çarp" />
        </div>
    </form>
</body>
</html>
