﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PageOutputCaching.aspx.cs" Inherits="ADONETDemo_PageOutputCaching" %>
<%--<%@ OutputCache Duration="600" VaryByParam="None" %>--%>
<%@ OutputCache CacheProfile="MyCacheProfile" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
