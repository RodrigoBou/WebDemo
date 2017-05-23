<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="MembersShipDemo_Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        bienvenido de nuevo
        <asp:LoginName ID="LoginName1" runat="server" />
        <br />
        <br />
        <asp:LoginStatus ID="LoginStatus1" runat="server" LogoutAction="Redirect" LogoutPageUrl="~/MembersShipDemo/Login.aspx" />
        <br />
        <br />
        <asp:LoginView ID="LoginView1" runat="server">
            <AnonymousTemplate>
                eres un usuario no registrado
            </AnonymousTemplate>
            <LoggedInTemplate>
                <asp:ChangePassword ID="ChangePassword1" runat="server" BackColor="#F7F6F3" BorderColor="#E6E2D8" BorderPadding="4" BorderStyle="Solid" BorderWidth="1px" ContinueDestinationPageUrl="~/MembersShipDemo/Login.aspx" Font-Names="Verdana" Font-Size="0.8em">
                    <CancelButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284775" />
                    <ChangePasswordButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284775" />
                    <ContinueButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284775" />
                    <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
                    <PasswordHintStyle Font-Italic="True" ForeColor="#888888" />
                    <TextBoxStyle Font-Size="0.8em" />
                    <TitleTextStyle BackColor="#5D7B9D" Font-Bold="True" Font-Size="0.9em" ForeColor="White" />
                </asp:ChangePassword>
            </LoggedInTemplate>
        </asp:LoginView>

    </div>    
    </form>
</body>
</html>
