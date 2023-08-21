<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="session2b.aspx.cs" Inherits="lab05_Interiano.session2b" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        	<p>
				Welcome,
				<asp:Label ID="lblName" runat="server" ForeColor="Red" Text="Label"></asp:Label>
			</p>
			<p>
				Your current sum is:
				<asp:Label ID="lblSum" runat="server" ForeColor="Red" Text="Label"></asp:Label>
			</p>
			<p>
				<asp:Button ID="btnAdd1" runat="server" OnClick="btnAdd1_Click" Text="Add 1" />
&nbsp;
				<asp:Button ID="btnPage1" runat="server" OnClick="btnPage1_Click" Text="Page 1" />
				<br />
			</p>
        </div>
    </form>
</body>
</html>

