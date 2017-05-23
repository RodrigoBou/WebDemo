<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RepeaterExample.aspx.cs" Inherits="ManejodeDatos_RepeaterExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Repeater ID="Repeater1" runat="server" DataSourceID="SqlDataSource1">
            <HeaderTemplate>
                <table border="5" bgColor="aqua">
                    <tr>
                        <td>Nombre de usuario</td>
                        <td>Contraseña</td>
                        <td>Pais</td>
                        <td>Email</td>
                    </tr>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td><%#Eval("UserName") %></td>
                    <td><%#Eval("Password") %></td>
                    <td><%#Eval("Country") %></td>
                    <td><%#Eval("Email") %></td>
                </tr>
            </ItemTemplate>
            <AlternatingItemTemplate>

            </AlternatingItemTemplate>
            <FooterTemplate>
                </table>
            </FooterTemplate>
        </asp:Repeater>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ASPTrainingConnectionString %>" SelectCommand="SELECT * FROM [UserDetails]"></asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
