<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="pruebaweb1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Label ID="Label1" runat="server" Text="Control"></asp:Label>

            <br />

            <br />

        </div>
        Colores<asp:DropDownList ID="ddColores" runat="server" OnSelectedIndexChanged="ddColores_SelectedIndexChanged" AutoPostBack="True">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="lbColores" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lbSesion" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Sabores:"></asp:Label>
        <br />
        <br />
        <asp:RadioButtonList ID="rbSabores" runat="server" AutoPostBack="True" OnSelectedIndexChanged="rbSabores_SelectedIndexChanged">
        </asp:RadioButtonList>
        <br />
        <br />
        <asp:Label ID="lbIndiceS" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lbContenidoS" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        Cafe:<br />
        <br />
        <asp:CheckBoxList ID="cbCafe" runat="server" AutoPostBack="True" OnSelectedIndexChanged="cbCafe_SelectedIndexChanged">
        </asp:CheckBoxList>
        <br />
        <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
        <br />
        <br />
        <asp:ListBox ID="ListBox2" runat="server"></asp:ListBox>
        <br />
    </form>
</body>
</html>
