<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MenuEjemplo.aspx.cs" Inherits="Menús_MenuEjemplo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Menu ID="Menu2" runat="server" BackColor="#F7F6F3" DataSourceID="XmlDataSource1" DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#7C6F57" StaticSubMenuIndent="10px">
            <DataBindings>
                <asp:MenuItemBinding DataMember="ControlType" TextField="Name" />
                <asp:MenuItemBinding DataMember="Control" NavigateUrlField="url" TextField="Name" />
            </DataBindings>
            <DynamicHoverStyle BackColor="#7C6F57" ForeColor="White" />
            <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
            <DynamicMenuStyle BackColor="#F7F6F3" />
            <DynamicSelectedStyle BackColor="#5D7B9D" />
            <StaticHoverStyle BackColor="#7C6F57" ForeColor="White" />
            <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
            <StaticSelectedStyle BackColor="#5D7B9D" />
        </asp:Menu>
        <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/App_Data/MisMenus.xml"></asp:XmlDataSource>
    </form>
</body>
</html>
