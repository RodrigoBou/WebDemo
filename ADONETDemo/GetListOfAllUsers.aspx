<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GetListOfAllUsers.aspx.cs" Inherits="ADONETDemo_GetListOfAllUsers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            background-color: #3399FF;
        }
        .auto-style2 {
            width: 380px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical">
            <AlternatingRowStyle BackColor="#DCDCDC" />
            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
            <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#0000A9" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#000065" />
        </asp:GridView>
    
        <br />
        <br />
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:BulletedList ID="BulletedList1" runat="server">
                    </asp:BulletedList>
                </td>
                <td>
                    <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                    </asp:CheckBoxList>
                </td>
                <td class="auto-style2">
                    <asp:DropDownList ID="DropDownList1" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
                </td>
                <td>
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                    </asp:RadioButtonList>
                </td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
        </table>
    
    </div>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Escribir desde XML" />
        <br />
        <br />
        <asp:GridView ID="GridView2" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
