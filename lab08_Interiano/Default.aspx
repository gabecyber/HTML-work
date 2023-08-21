<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="lab8_test_db.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Verify Database Access</title>
    <link href="..\site.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
			<p>
				Run this page. In the output you will see either &quot;Success&quot; or &quot;Failure&quot;</p>
			<asp:TextBox ID="txtMsg" runat="server" Height="472px" TextMode="MultiLine" Width="1097px"></asp:TextBox>
        </div>
    </form>
</body>
</html>