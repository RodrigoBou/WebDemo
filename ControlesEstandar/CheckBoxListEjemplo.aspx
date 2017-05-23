<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CheckBoxListEjemplo.aspx.cs" Inherits="Controles_Estandar_CheckBoxListEjemplo" %>

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
        .auto-style2 {
            width: 184px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Salario:</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Retenciones</td>
                <td>
                    <asp:CheckBoxList ID="CheckBoxList1" runat="server" OnSelectedIndexChanged="CheckBoxList1_SelectedIndexChanged" RepeatColumns="2" RepeatDirection="Horizontal">
                        <asp:ListItem>renta</asp:ListItem>
                        <asp:ListItem>seguro</asp:ListItem>
                        <asp:ListItem>insaforp</asp:ListItem>
                        <asp:ListItem>pension</asp:ListItem>
                    </asp:CheckBoxList>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Salario Neto:</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Calcular" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
