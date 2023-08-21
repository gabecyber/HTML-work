<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pback2.aspx.cs" Inherits="lab05_Interiano.pback2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <p><strong>Postback Multipage Example - Page 2</strong></p>
        <p>
            <asp:Button ID="btnSubmit" runat="server" onclick="btnSubmit_Click" Text="Submit/Postback" />&nbsp;
            <asp:Button ID="btnPage1" runat="server" onclick="btnPage1_Click" Text="Page 1" />
        &nbsp;</p>
        <p>
            <asp:TextBox ID="txtMessage" runat="server" Height="182px" TextMode="MultiLine" 
                Width="279px"></asp:TextBox>
        </p>
        </div>
    </form>
</body>
</html>
