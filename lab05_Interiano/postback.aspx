<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="postback.aspx.cs" Inherits="lab05_Interiano.postback" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lbxNames" runat="server" Height="233px"></asp:ListBox>
            <asp:Button ID="btnDisplay" runat="server" OnClick="btnDisplay_Click" Text="Button" />
            <br />
            <asp:TextBox ID="txtMessage" runat="server" Height="175px" TextMode="MultiLine" Width="264px"></asp:TextBox>
        </div>
    </form>
</body>
</html>
