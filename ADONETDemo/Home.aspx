<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="ADONETDemo_Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            background-color: #33CCFF;
        }
        .auto-style2 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Cambiar Contraseña</asp:LinkButton>
                </td>
                <td>
                    <asp:LinkButton ID="LinkButton4" runat="server" OnClick="LinkButton4_Click">Cambiar Datos</asp:LinkButton>
                </td>
                <td class="auto-style2">
                    <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">Desinscribir</asp:LinkButton>
                </td>
                <td class="auto-style2">
                    <asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click">Salir</asp:LinkButton>
                </td>
            </tr>
        </table>
        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>
    </form>
</body>
</html>
