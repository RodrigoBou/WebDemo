<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPagesDemo/Site.master" AutoEventWireup="true" CodeFile="ChildPage2.aspx.cs" Inherits="MasterPagesDemo_ChildPage2" %>

<%@ Register src="../ControldeUsuarios/ListaUsuarios.ascx" tagname="ListaUsuarios" tagprefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <uc2:ListaUsuarios ID="ListaUsuarios1" runat="server" />
</asp:Content>

