<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FileUploadEjemplo.aspx.cs" Inherits="Controles_Estandar_FileUploadEjemplo" %>

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
    
        <table class="auto-style1">
            <tr>
                <td>Seleccione un Archivo:</td>
                <td>
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Subir" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>Tipo:</td>
                <td>
                    <asp:Label ID="Label2" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Tamaño:</td>
                <td>
                    <asp:Label ID="Label3" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
        <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
