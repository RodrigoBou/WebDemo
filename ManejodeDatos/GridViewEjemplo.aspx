<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GridViewEjemplo.aspx.cs" Inherits="ManejodeDatos_GridViewEjemplo" %>

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
    
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ASPTrainingConnectionString %>" DeleteCommand="DELETE FROM UserDetails WHERE (UserName = @UserName)" SelectCommand="SELECT * FROM [UserDetails]" UpdateCommand="UPDATE UserDetails SET Password = @Password, Email = @Email, Country = @Country WHERE (UserName = @UserName)">
            <DeleteParameters>
                <asp:ControlParameter ControlID="GridView1" Name="UserName" PropertyName="SelectedValue" />
            </DeleteParameters>
            <UpdateParameters>
                <asp:ControlParameter ControlID="GridView1" Name="Password" PropertyName="SelectedValue" />
                <asp:ControlParameter ControlID="GridView1" Name="Email" PropertyName="SelectedValue" />
                <asp:ControlParameter ControlID="GridView1" Name="Country" PropertyName="SelectedValue" />
                <asp:ControlParameter ControlID="GridView1" Name="UserName" PropertyName="SelectedValue" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <br />
    
    </div>
        <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" DataKeyNames="UserName" DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <AlternatingRowStyle BackColor="PaleGoldenrod" />
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                <asp:BoundField DataField="UserName" HeaderText="UserName" ReadOnly="True" SortExpression="UserName" />
                <asp:BoundField DataField="Password" HeaderText="Password" SortExpression="Password" />
                <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                <asp:BoundField DataField="Country" HeaderText="Country" SortExpression="Country" />
            </Columns>
            <FooterStyle BackColor="Tan" />
            <HeaderStyle BackColor="Tan" Font-Bold="True" />
            <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
            <SortedAscendingCellStyle BackColor="#FAFAE7" />
            <SortedAscendingHeaderStyle BackColor="#DAC09E" />
            <SortedDescendingCellStyle BackColor="#E1DB9C" />
            <SortedDescendingHeaderStyle BackColor="#C2A47B" />
        </asp:GridView>
        <br />
        <table class="auto-style1">
            <tr>
                <td>Usuario</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Contraseña</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Email</td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Pais</td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
