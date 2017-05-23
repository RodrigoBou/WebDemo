<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ChangeProfile.aspx.cs" Inherits="ADONETDemo_ChangeProfile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            background-color: #0066FF;
        }
        .auto-style2 {
            width: 294px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label1" runat="server" Text="Usuario"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label2" runat="server" Text="Contraseña"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label3" runat="server" Text="Pais"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem>El Salvador</asp:ListItem>
                        <asp:ListItem>Guatemala</asp:ListItem>
                        <asp:ListItem>Costa Rica</asp:ListItem>
                        <asp:ListItem>Nicaragua</asp:ListItem>
                        <asp:ListItem>Panama</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label4" runat="server" Text="Correo"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="Button1" runat="server" Text="Cambiar" OnClick="Button1_Click" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
        <br />
        <asp:Label ID="Label5" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
