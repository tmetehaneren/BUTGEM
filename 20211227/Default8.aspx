<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default8.aspx.cs" Inherits="WebApplication2.Default8" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:RadioButton ID="RadioButton1" runat="server" GroupName="cins" Text="Bay" />
            <asp:RadioButton ID="RadioButton2" runat="server" GroupName="cins" Text="Bayan" />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Cinsiyetiniz" />
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
