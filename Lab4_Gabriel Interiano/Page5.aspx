<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page5.aspx.cs" Inherits="Lab4_Gabriel_Interiano.Page5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="default.aspx">Back</asp:HyperLink>
        </div>
        <asp:Button ID="btnDisplay" runat="server" OnClick="btnDisplay_Click" Text="Display" />
        <asp:RadioButtonList ID="rblTeams" runat="server" RepeatDirection="Horizontal">
            <asp:ListItem Value="Blazers">Vsu</asp:ListItem>
            <asp:ListItem Value="Bongos">Bingos</asp:ListItem>
            <asp:ListItem Value="hghggh">asdasd</asp:ListItem>
            <asp:ListItem Value="blop[">brep</asp:ListItem>
            <asp:ListItem Value="asdaasds">myhndf</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <asp:TextBox ID="txtMessage" runat="server" Height="307px" TextMode="MultiLine" Width="555px"></asp:TextBox>
    </form>
</body>
</html>
