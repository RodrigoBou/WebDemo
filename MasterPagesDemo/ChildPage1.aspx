<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPagesDemo/MasterPage.master" AutoEventWireup="true" CodeFile="ChildPage1.aspx.cs" Inherits="MasterPagesDemo_ChildPage1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
    <tr>
        <td>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="RequiredFieldValidator">*</asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="RequiredFieldValidator">*</asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Button ID="Button1" runat="server" Text="Button" />
        </td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>

