<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page3.aspx.cs" Inherits="Lab4_Gabriel_Interiano.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="default.aspx">Back</asp:HyperLink>
            <br />
            <asp:Button ID="btnDisplay" runat="server" OnClick="btnDisplay_Click" Text="Display" />
            <asp:Button ID="btnRemove" runat="server" OnClick="btnRemove_Click" Text="Remove Selected" />
            <asp:ListBox ID="lbxNames" runat="server" SelectionMode="Multiple">
                <asp:ListItem Value="12">bingos</asp:ListItem>
                <asp:ListItem Value="20">asdfadasd</asp:ListItem>
                <asp:ListItem Value="55">hhh</asp:ListItem>
                <asp:ListItem Value="67">fhsdoifhsdi</asp:ListItem>
                <asp:ListItem Value="97">ggggg</asp:ListItem>
            </asp:ListBox>
            <br />
            <asp:TextBox ID="txtMessage" runat="server" Height="276px" TextMode="MultiLine" Width="549px"></asp:TextBox>
        </div>
    </form>
</body>
</html>
