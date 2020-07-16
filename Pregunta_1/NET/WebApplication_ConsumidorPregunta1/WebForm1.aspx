<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication_ConsumidorPregunta1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="height: 160px">
    <form id="form1" runat="server">
        <div>
            CI</div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Buscar DB" OnClick="Button1_Click" />
        <asp:GridView ID="GridView1" runat="server" Height="167px" Width="224px">
        </asp:GridView>
        <p>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Ver sin DB" />
        </p>
        <asp:TextBox ID="TextBox2" runat="server" Width="213px"></asp:TextBox>
    </form>
</body>
</html>
