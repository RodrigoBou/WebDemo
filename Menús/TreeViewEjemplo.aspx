<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TreeViewEjemplo.aspx.cs" Inherits="Menús_TreeViewEjemplo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:TreeView ID="TreeView1" runat="server" ImageSet="Simple">
            <HoverNodeStyle Font-Underline="True" ForeColor="#5555DD" />
            <Nodes>
                <asp:TreeNode Text="Nuevo nodo" Value="Nuevo nodo">
                    <asp:TreeNode Text="Nuevo nodo" Value="Nuevo nodo"></asp:TreeNode>
                    <asp:TreeNode Text="Nuevo nodo" Value="Nuevo nodo"></asp:TreeNode>
                    <asp:TreeNode Text="Nuevo nodo" Value="Nuevo nodo"></asp:TreeNode>
                </asp:TreeNode>
                <asp:TreeNode Text="Nuevo nodo" Value="Nuevo nodo">
                    <asp:TreeNode Text="Nuevo nodo" Value="Nuevo nodo"></asp:TreeNode>
                    <asp:TreeNode Text="Nuevo nodo" Value="Nuevo nodo"></asp:TreeNode>
                    <asp:TreeNode Text="Nuevo nodo" Value="Nuevo nodo"></asp:TreeNode>
                </asp:TreeNode>
            </Nodes>
            <NodeStyle Font-Names="Tahoma" Font-Size="10pt" ForeColor="Black" HorizontalPadding="0px" NodeSpacing="0px" VerticalPadding="0px" />
            <ParentNodeStyle Font-Bold="False" />
            <SelectedNodeStyle Font-Underline="True" ForeColor="#5555DD" HorizontalPadding="0px" VerticalPadding="0px" />
        </asp:TreeView>
    </form>
</body>
</html>
