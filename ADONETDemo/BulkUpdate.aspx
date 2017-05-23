<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BulkUpdate.aspx.cs" Inherits="CustomerDetails" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:TemplateField HeaderText="Name">
            <ItemTemplate>
                <asp:TextBox ID="txtName" ReadOnly="true" runat="server" Text=<%# Eval("CustName")%>></asp:TextBox>
            </ItemTemplate>
            </asp:TemplateField>
            
            
            <asp:TemplateField HeaderText="Position">
            <ItemTemplate>
                <asp:TextBox ID="txtPosition" runat="server" Text=<%# Eval("CustPosition") %>></asp:TextBox>
            </ItemTemplate>
            </asp:TemplateField>
            
            <asp:TemplateField HeaderText="City">
            
            <ItemTemplate>
                <asp:TextBox ID="txtCity" runat="server" Text=<%# Eval("CustCity") %>></asp:TextBox>
            </ItemTemplate>
            </asp:TemplateField>
            
            <asp:TemplateField HeaderText="State">
            
            <ItemTemplate>
                <asp:TextBox ID="txtState" runat="server" Text=<%# Eval("CustState") %>></asp:TextBox>
            </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <p>
        <asp:Label ID="lblError" runat="server"></asp:Label>
    </p>
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
        Text="Update Customer" />
    </form>
</body>
</html>
