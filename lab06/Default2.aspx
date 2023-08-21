<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default2.aspx.cs" Inherits="lab06.Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtMessage" runat="server" OnTextChanged="TextBox1_TextChanged" TextMode="MultiLine"></asp:TextBox>
        </div>
    </form>
</body>
</html>
