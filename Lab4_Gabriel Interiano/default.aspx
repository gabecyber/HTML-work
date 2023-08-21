<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Lab4_Gabriel_Interiano.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
<script>
	$(document).ready(function () {
		// Get width of label and textbox
		var lblWidth = $('#Label1').width();
		var txtWidth = $('#TextBox1').width();
		// Set width of panel to 20% larger than the sum of components width
		$('#Panel1').width(lblWidth + txtWidth * 1.20);
		// Set padding around panel
		$('#Panel1').css({ 'padding': '10px' });
	});
</script>

    <title>Lab4 - Gabriel Interiano</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Lab 4 - Gabriel Interiano</h2>
        </div>
        <asp:Button ID="btnHideShow" runat="server" OnClick="btnHideShow_Click" Text="Hide" />
        <asp:TextBox ID="txtInput" runat="server"></asp:TextBox>
        <asp:Panel ID="Panel1" runat="server" BorderStyle="Solid">
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </asp:Panel>
        <br />
        <asp:Button ID="btnHideShow2" runat="server" OnClick="btnHideShow2_Click" Text="Hide" />
        <br />
        <br />
        <br />
        <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="Page6.aspx">Page6</asp:HyperLink>
        <br />
        <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="Page5.aspx">Page5</asp:HyperLink>
        <br />
        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="Page4.aspx">Page4</asp:HyperLink>
        <br />
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="Page3.aspx">Page3</asp:HyperLink>
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/page2.aspx">Page2</asp:HyperLink>
    </form>
</body>
</html>
