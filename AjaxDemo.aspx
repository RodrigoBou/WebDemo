<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AjaxDemo.aspx.cs" Inherits="AjaxDemo" %>

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
            width: 339px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    
        <br />
        <br />
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <table class="auto-style1">
                    <tr>
                        <td class="auto-style2">
                            <asp:Label ID="Label1" runat="server" Text="Primer Numero:"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style2">
                            <asp:Label ID="Label2" runat="server" Text="Segundo Numero:"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style2">
                            <asp:Label ID="Label3" runat="server" Text="Resultado:"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style2">
                            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Sumar" />
                            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Restar" />
                            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Multiplicar" />
                            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Dividir" />
                        </td>
                    </tr>
                </table>
            </ContentTemplate>
        </asp:UpdatePanel>
        <br />
        <br />
        <asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="UpdatePanel1">
            <ProgressTemplate>
                <asp:Label ID="Label4" runat="server" Text="Calculando..."></asp:Label>
            </ProgressTemplate>
        </asp:UpdateProgress>
        <br />
        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
            <ContentTemplate>
                <asp:Timer ID="Timer1" runat="server" Interval="1000" OnTick="Timer1_Tick" />
                <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Size="30pt" ForeColor="Blue" Text="Label"></asp:Label>
            </ContentTemplate>
        </asp:UpdatePanel>
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
