<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TestThemes.aspx.cs" EnableTheming="true" Theme="Seasons" Inherits="ThemesExamples_TestThemes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
    
    </div>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:TextBox SkinID="SkinDemo" ID="TextBox3" runat="server" EnableTheming="True"></asp:TextBox>
    </form>
</body>
</html>
