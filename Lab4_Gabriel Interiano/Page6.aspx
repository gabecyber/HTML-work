<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page6.aspx.cs" Inherits="Lab4_Gabriel_Interiano.WebForm5" %>

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
            <asp:Calendar ID="cal" runat="server"></asp:Calendar>
            <asp:TextBox ID="txtMessage" runat="server" Height="247px" TextMode="MultiLine" Width="526px"></asp:TextBox>
        </div>
    </form>
</body>
</html>
