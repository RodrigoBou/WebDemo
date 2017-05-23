<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DetailsViewsEjemplo.aspx.cs" Inherits="ManejodeDatos_DetailsViewsEjemplo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ASPTrainingConnectionString %>" DeleteCommand="DELETE FROM UserDetails WHERE (UserName = @UserName)" SelectCommand="SELECT * FROM [UserDetails]" UpdateCommand="UPDATE UserDetails SET Password = @Password, Email = @Email, Country = @Country WHERE (UserName = @UserName)" InsertCommand="INSERT INTO UserDetails(UserName, Password, Email, Country) VALUES (@UserName, @Password, @Email, @Country)">
            <DeleteParameters>
                <asp:ControlParameter ControlID="DetailsView1" Name="UserName" PropertyName="SelectedValue" />
            </DeleteParameters>
            <InsertParameters>
                <asp:ControlParameter ControlID="DetailsView1" Name="UserName" PropertyName="SelectedValue" />
                <asp:ControlParameter ControlID="DetailsView1" Name="Password" PropertyName="SelectedValue" />
                <asp:ControlParameter ControlID="DetailsView1" Name="Email" PropertyName="SelectedValue" />
                <asp:ControlParameter ControlID="DetailsView1" Name="Country" PropertyName="SelectedValue" />
            </InsertParameters>
            <UpdateParameters>
                <asp:ControlParameter ControlID="DetailsView1" Name="UserName" PropertyName="SelectedValue" />
                <asp:ControlParameter ControlID="DetailsView1" Name="Password" PropertyName="SelectedValue" />
                <asp:ControlParameter ControlID="DetailsView1" Name="Email" PropertyName="SelectedValue" />
                <asp:ControlParameter ControlID="DetailsView1" Name="Country" PropertyName="SelectedValue" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <br />
        <asp:DetailsView ID="DetailsView1" runat="server" AllowPaging="True" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="None" Height="50px" Width="125px">
            <AlternatingRowStyle BackColor="PaleGoldenrod" />
            <EditRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
            <Fields>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowInsertButton="True" />
            </Fields>
            <FooterStyle BackColor="Tan" />
            <HeaderStyle BackColor="Tan" Font-Bold="True" />
            <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
        </asp:DetailsView>
    
    </div>
    </form>
</body>
</html>
