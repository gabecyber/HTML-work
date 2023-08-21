<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Summary.aspx.cs" Inherits="hw03_Interiano.Summary" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div><h1>
            <asp:Label ID="EventName" runat="server" Text="Ticket Holders for [Event Name]"></asp:Label>
            </h1>
            <br />
            <asp:Button ID="PurchaseMore" runat="server" OnClick="PurchaseMore_Click" Text="Purchase More Tickets" />

            <br />

            <asp:Label ID="Label3" runat="server" Text="    Sort: "></asp:Label>
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" Height="58px" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
                <asp:ListItem>Order Purchased</asp:ListItem>
                <asp:ListItem>Name</asp:ListItem>
                <asp:ListItem>Seat</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Remove Ticket Holder "></asp:Label>
            <asp:DropDownList ID="ddlTicketHolders" runat="server" Height="18px" Width="177px" >
            </asp:DropDownList>
            <asp:Button ID="Remove" runat="server" Text="Remove" OnClick="Remove_Click" />
            <br />
            <asp:TextBox ID="OrdersBox" runat="server" Height="307px" Width="524px" TextMode="MultiLine"></asp:TextBox>
            <table>
                </table>
        </div>
    </form>
</body>
</html>
