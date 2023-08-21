<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page2.aspx.cs" Inherits="lab09_Interiano.Page2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="btnReadData" runat="server" OnClick="btnReadData_Click" Text="Read Data" />
        <div>
            <asp:TextBox ID="txtMsg" runat="server" Height="359px" TextMode="MultiLine" Width="587px"></asp:TextBox>
        </div>
    </form>
</body>
</html>
