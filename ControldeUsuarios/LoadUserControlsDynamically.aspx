<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LoadUserControlsDynamically.aspx.cs" Inherits="ControldeUsuarios_LoadUserControlsDynamically" %>

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
                    <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:PlaceHolder ID="PlaceHolder2" runat="server"></asp:PlaceHolder>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:PlaceHolder ID="PlaceHolder3" runat="server"></asp:PlaceHolder>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
