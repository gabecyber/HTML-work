<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="create.aspx.cs" Inherits="lab06.create" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
	</head>
<body>
    <form id="form1" runat="server">
        <div>
			<p><asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>&nbsp;
				<asp:TextBox ID="txtNamePerson" runat="server"></asp:TextBox>&nbsp;
				<asp:Button ID="btnCreatePerson" runat="server" Text="Create Person" OnClick="btnCreatePerson_Click" />
			</p>
			<p><asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>&nbsp;
				<asp:TextBox ID="txtNameDog" runat="server"></asp:TextBox>&nbsp;
				<asp:Label ID="Label3" runat="server" Text="Age"></asp:Label>&nbsp;
				<asp:TextBox ID="txtAgeDog" runat="server"></asp:TextBox>&nbsp;
				<asp:Button ID="btnCreateDog" runat="server" Text="Create Dog" OnClick="btnCreateDog_Click" />
			</p>
			<p>&nbsp;
				<asp:Button ID="btnDisplayAll" runat="server" Text="Display All" OnClick="btnDisplayAll_Click" />&nbsp;<asp:Button ID="btnDisplayAllOtherPage" runat="server" Text="Display All Other Page" OnClick="btnDisplayAllOtherPage_Click" />&nbsp;<asp:Button ID="btnStartOver" runat="server" OnClick="btnStartOver_Click" Text="Start Over" />
			</p>
			<asp:TextBox ID="txtMessage" runat="server" Height="175px" TextMode="MultiLine" Width="558px" OnTextChanged="txtMessage_TextChanged"></asp:TextBox>

		</div>
	</form>
</body>
</html>

