<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TestUserControls.aspx.cs" Inherits="ControldeUsuarios_TestUserControls" %>

<%@ Register src="Header.ascx" tagname="Header" tagprefix="uc1" %>
<%@ Register src="Footer.ascx" tagname="Footer" tagprefix="uc2" %>
<%@ Register src="ListaUsuarios.ascx" tagname="ListaUsuarios" tagprefix="uc3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            background-color: #66CCFF;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td>
                    <uc1:Header ID="Header1" runat="server" />
                </td>
            </tr>
            <tr>
                <td>
                    <uc3:ListaUsuarios ID="ListaUsuarios1" runat="server" Country="El Salvador" />
                </td>
            </tr>
            <tr>
                <td>
                    <uc2:Footer ID="Footer1" runat="server" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
