<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FormViewEjemplo.aspx.cs" Inherits="ManejodeDatos_FormViewEjemplo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ASPTrainingConnectionString %>" SelectCommand="SELECT * FROM [UserDetails]"></asp:SqlDataSource>
        <br />
        <asp:FormView ID="FormView1" runat="server" AllowPaging="True" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" DataKeyNames="UserName" DataSourceID="SqlDataSource1" ForeColor="Black">
            <EditItemTemplate>
                UserName:
                <asp:Label ID="UserNameLabel1" runat="server" Text='<%# Eval("UserName") %>' />
                <br />
                Password:
                <asp:TextBox ID="PasswordTextBox" runat="server" Text='<%# Bind("Password") %>' />
                <br />
                Email:
                <asp:TextBox ID="EmailTextBox" runat="server" Text='<%# Bind("Email") %>' />
                <br />
                Country:
                <asp:TextBox ID="CountryTextBox" runat="server" Text='<%# Bind("Country") %>' />
                <br />
                <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Actualizar" />
                &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancelar" />
            </EditItemTemplate>
            <EditRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
            <FooterStyle BackColor="Tan" />
            <HeaderStyle BackColor="Tan" Font-Bold="True" />
            <InsertItemTemplate>
                UserName:
                <asp:TextBox ID="UserNameTextBox" runat="server" Text='<%# Bind("UserName") %>' />
                <br />
                Password:
                <asp:TextBox ID="PasswordTextBox" runat="server" Text='<%# Bind("Password") %>' />
                <br />
                Email:
                <asp:TextBox ID="EmailTextBox" runat="server" Text='<%# Bind("Email") %>' />
                <br />
                Country:
                <asp:TextBox ID="CountryTextBox" runat="server" Text='<%# Bind("Country") %>' />
                <br />
                <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insertar" />
                &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancelar" />
            </InsertItemTemplate>
            <ItemTemplate>
                Querido
                <asp:Label ID="UserNameLabel" runat="server" style="font-weight: 700" Text='<%# Eval("UserName") %>' />
                <br />
                la nueva contraseña ha sido generada exitosamente
                <asp:Label ID="PasswordLabel" runat="server" style="font-style: italic; font-weight: 700" Text='<%# Bind("Password") %>' />
                <br />
                <br />
                <asp:Label ID="EmailLabel" runat="server" style="font-weight: 700" Text='<%# Bind("Email") %>' />
                <br />
                <asp:Label ID="CountryLabel" runat="server" style="font-weight: 700" Text='<%# Bind("Country") %>' />
                <br />
            </ItemTemplate>
            <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
        </asp:FormView>
    
    </div>
    </form>
</body>
</html>
