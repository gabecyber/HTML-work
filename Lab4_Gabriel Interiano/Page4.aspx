<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page4.aspx.cs" Inherits="Lab4_Gabriel_Interiano.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="default.aspx">Back</asp:HyperLink>
            <asp:CheckBoxList ID="cblTeams" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem Value="blazers">vsu</asp:ListItem>
                <asp:ListItem Value="Broncos">FSU</asp:ListItem>
                <asp:ListItem Value="dddd">asdads</asp:ListItem>
                <asp:ListItem Value="asdasdsa">bnmbn</asp:ListItem>
                <asp:ListItem Value="bingus">bongos</asp:ListItem>
            </asp:CheckBoxList>
            <asp:Button ID="btnDisplay" runat="server" OnClick="btnDisplay_Click" Text="Display" />
            <br />
            <asp:TextBox ID="txtMessage" runat="server" Height="272px" TextMode="MultiLine" Width="454px"></asp:TextBox>
        </div>
    </form>
</body>
</html>
