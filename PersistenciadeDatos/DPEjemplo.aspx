<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DPEjemplo.aspx.cs" Inherits="PersistenciadeDatos_DPEjemplo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            background-color: #66FFCC;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Escribir en ViewState" OnClick="Button1_Click" />
                </td>
                <td>
                    <asp:Button ID="Button2" runat="server" Text="Leer de View State" OnClick="Button2_Click" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Escribir en Sesion" />
                </td>
                <td>
                    <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Leer de Sesion" />
                </td>
                <td>
                    <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Leer Session en otra Pagina" />
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Salir" />
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="Escribir Cookie" />
                </td>
                <td>
                    <asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="Leer Cookie" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
        <asp:Label ID="Label3" runat="server"></asp:Label>
    </form>
</body>
</html>
