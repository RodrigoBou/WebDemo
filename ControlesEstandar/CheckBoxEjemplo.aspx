<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CheckBoxEjemplo.aspx.cs" Inherits="Controles_Estandar_CheckBoxEjemplo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            background-color: #66FFFF;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Salario"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Retenciones"></asp:Label>
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox1_CheckedChanged" Text="Renta" />
                    <br />
                    <asp:CheckBox ID="CheckBox2" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox2_CheckedChanged" Text="Seguro" />
                    <br />
                    <asp:CheckBox ID="CheckBox3" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox3_CheckedChanged" Text="Pension" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Salario Neto"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server">0</asp:TextBox>
                </td>
            </tr>
        </table>
    
    </div>
        <asp:SiteMapPath ID="SiteMapPath1" runat="server" Font-Names="Verdana" Font-Size="0.8em" PathSeparator=" : ">
            <CurrentNodeStyle ForeColor="#333333" />
            <NodeStyle Font-Bold="True" ForeColor="#7C6F57" />
            <PathSeparatorStyle Font-Bold="True" ForeColor="#5D7B9D" />
            <RootNodeStyle Font-Bold="True" ForeColor="#5D7B9D" />
        </asp:SiteMapPath>
    </form>
</body>
</html>
