<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pback1.aspx.cs" Inherits="lab05_Interiano.pback1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
   <div>
        <p><strong>Postback Multipage Example</strong></p>
        <p>This page illustrates when it is the first time on the page or postback and what happens when you navigate to a new page and then back. You should look carefully at the code for this page and for &quot;Page 2&quot; (pback2.aspx).</p>
        
        <p>
            <asp:Button ID="btnSubmit" runat="server" onclick="btnSubmit_Click" Text="Submit/Postback" />&nbsp;
            <asp:Button ID="btnLoadPage" runat="server" onclick="btnLoadPage_Click" Text="Reload" />&nbsp;
            <asp:Button ID="btnPage2" runat="server" onclick="btnPage2_Click" Text="Page 2" />
        </p>
        <p>
            <asp:TextBox ID="txtMessage" runat="server" EnableViewState="False" 
            Height="224px" TextMode="MultiLine" Width="384px"></asp:TextBox>
        </p>
    
    </div>
    </form>
</body>
</html>

