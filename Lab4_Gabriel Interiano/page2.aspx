<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="page2.aspx.cs" Inherits="Lab4_Gabriel_Interiano.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="default.aspx">Back</asp:HyperLink>
            <br />
            <br />
            <asp:Button ID="btnDisplayAll" runat="server" OnClick="btnDisplayAll_Click" Text="Display All" />
            <asp:DropDownList ID="ddlNames" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlNames_SelectedIndexChanged">
                <asp:ListItem Value="38">Jones</asp:ListItem>
                <asp:ListItem Value="22">Able</asp:ListItem>
                <asp:ListItem Value="47">Mackey</asp:ListItem>
                <asp:ListItem Value="11">Benton</asp:ListItem>
            </asp:DropDownList>
            <asp:Button ID="btnDisplaySelected" runat="server" OnClick="btnDisplaySelected_Click" Text="Display Selected" />
            <asp:Button ID="btnRemoveSelected" runat="server" OnClick="btnRemoveSelected_Click" Text="Remove Selected" />
            <br />
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="height: 26px" Text="Add" />
            <asp:Label ID="Label1" runat="server" Text="Text"></asp:Label>
            <asp:TextBox ID="txtText" runat="server"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Text="Value"></asp:Label>
            <asp:TextBox ID="txtValue" runat="server"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtMessage" runat="server" Height="191px" TextMode="MultiLine" Width="394px"></asp:TextBox>
        </div>
    </form>
</body>
</html>
