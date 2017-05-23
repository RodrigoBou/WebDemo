<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TestCustomControl.aspx.cs" Inherits="CustomControls_TestCustomControl" %>

<%@ Register assembly="MyCCD" namespace="MyCCD" tagprefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <cc1:Greetings ID="Greetings1" runat="server" Counter="5" Message="Hola Yohalmo">
        </cc1:Greetings>
    
    </div>
    </form>
</body>
</html>
