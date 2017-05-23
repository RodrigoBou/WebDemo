<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ValidationsDemo.aspx.cs" Inherits="Controles_de_Validacion_ValidationsDemo" %>

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
        .auto-style2 {
            width: 195px;
        }
        .auto-style3 {
            width: 254px;
        }
        .auto-style4 {
            width: 100%;
            background-color: #00FFFF;
        }
        .auto-style5 {
            width: 194px;
        }
        .auto-style6 {
            width: 255px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Usuario</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="El nombre de usuario es un dato obligatorio">*</asp:RequiredFieldValidator>
                    <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="El tamaño minimo de letras es 5" OnServerValidate="CustomValidator1_ServerValidate">*</asp:CustomValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Password</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="La contraseña es un campo obligatorio" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Confirmar Password</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
                <td style="margin-left: 40px">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="Debes confirmar tu contraseña" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox2" ControlToValidate="TextBox3" ErrorMessage="Contraseñas no coinciden">*</asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Edad</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4" ErrorMessage="La edad es obligatodia">*</asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToValidate="TextBox4" ErrorMessage="Edad debe ser mayor a 18" Operator="GreaterThanEqual" Type="Integer" ValueToCompare="18">*</asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Fecha de Nacimiento </td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox5" ErrorMessage="fecha obligatoria">*</asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidator3" runat="server" ControlToValidate="TextBox5" ErrorMessage="debe ser una fecha valida" Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
                    <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox5" ErrorMessage="fecha debe estar entre 13/11/1995 y 13/11/2017 " MaximumValue="13/11/2017" MinimumValue="13/11/1995" SetFocusOnError="True" Type="Date">*</asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Email</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBox6" ErrorMessage="Email debe ser digitado">*</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox6" ErrorMessage="Email invalido..." ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Pais</td>
                <td class="auto-style3">
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem>Seleccionar</asp:ListItem>
                        <asp:ListItem>USA</asp:ListItem>
                        <asp:ListItem>El Salvador</asp:ListItem>
                        <asp:ListItem>Canada</asp:ListItem>
                        <asp:ListItem>Rusia</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="DropDownList1" ErrorMessage="Debes seleccionar un pais" InitialValue="Seleccionar">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="Button1" runat="server" Text="Registrar" />
                </td>
                <td class="auto-style3">
                    <asp:Button ID="Button2" runat="server" CausesValidation="False" Text="Cancelar" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True" ShowSummary="False" />
        <p>
            &nbsp;</p>
        <table class="auto-style4">
            <tr>
                <td class="auto-style5">Usuario</td>
                <td class="auto-style6">
                    <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="TextBox7" ErrorMessage="usuario invalido" ValidationGroup="LoginGroup">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Password</td>
                <td class="auto-style6">
                    <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="TextBox8" ErrorMessage="RequiredFieldValidator" ValidationGroup="LoginGroup"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Button ID="Button3" runat="server" CausesValidation="False" OnClick="Button3_Click" Text="Entrar" ValidationGroup="LoginGroup" />
                </td>
                <td class="auto-style6">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
