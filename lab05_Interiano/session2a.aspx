<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="session2a.aspx.cs" Inherits="lab05_Interiano.session2a" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        	<p>
				Name
				<asp:TextBox ID="txtName" runat="server"></asp:TextBox>
			</p>
			<p>
				Favorite Integer
				<asp:TextBox ID="txtFavInt" runat="server"></asp:TextBox>
			</p>
			<p>
&nbsp;
				<asp:Button ID="btnSave" runat="server" OnClick="btnSave_Click" Text="Save" />
&nbsp;<asp:Button ID="btnAdd1" runat="server" OnClick="btnAdd1_Click" Text="Add 1" />
&nbsp;
				<asp:Button ID="btnPage2" runat="server" OnClick="btnPage2_Click" Text="Page 2" />
			&nbsp;
			</p>
			<p>
				Your current sum is: <asp:Label ID="lblSum" runat="server" ForeColor="Red" Text="n/a"></asp:Label>
				<br />
			</p>
        </div>
    </form>
</body>
</html>

