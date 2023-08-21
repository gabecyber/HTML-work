<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="hw03_Interiano._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>HW3 Gabriel Interiano</h1>
            <a href="ClassDiagram.aspx">Class Diagram</a>
            <br />
            <asp:Panel ID="Panel1" runat="server" GroupingText="Create Event">
                <br />
                <asp:Label ID="Label2" runat="server" Text="Event Name: "></asp:Label>
                <asp:TextBox ID="EventName" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label4" runat="server" Text="Available Seat Numbers: "></asp:Label>
                <asp:Label ID="Label5" runat="server" Text="First "></asp:Label>
                <asp:TextBox ID="First" runat="server" Width="64px"></asp:TextBox>
                <asp:Label ID="Label6" runat="server" Text="Last "></asp:Label>
                <asp:TextBox ID="Last" runat="server" Width="40px"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="MakeEvent" runat="server" Text="Make Event" OnClick="MakeEvent_Click" />
                <asp:Button ID="Reset" runat="server" Text="Start Over" OnClick="Reset_Click" />
            </asp:Panel>
        </div>
        <asp:Panel ID="Panel2" runat="server" GroupingText="Purchase Ticket">
            <asp:Label ID="Label3" runat="server" Text="Name "></asp:Label>
            <asp:TextBox ID="Name" runat="server"></asp:TextBox>
            &nbsp;<asp:Label ID="Label7" runat="server" Text="Age"></asp:Label>
            &nbsp;<asp:TextBox ID="Age" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="amountSeats" runat="server" Text="Pick Seat, 0  available"></asp:Label>
            <br />
            <table>
                <tr>
                    <td>
                        <asp:ListBox ID="AvailableSeats" runat="server" Height="224px" Width="61px"></asp:ListBox>
                    </td>
                
                
                    
                    <td>
                        <asp:Button ID="Purchase" runat="server" Text="Purchase" OnClick="Purchase_Click" />
                   <br />
                   
                        <asp:Button ID="EventSummary" runat="server" Text="Event Summary" OnClick="EventSummary_Click" />
                        <asp:ListBox ID="TempList" runat="server" EnableTheming="True" Visible="False"></asp:ListBox>
                     </td>
                </tr>
                
            </table>
           
        </asp:Panel>
    </form>
</body>
</html>
