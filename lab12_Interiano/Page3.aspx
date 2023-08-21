<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page3.aspx.cs" Inherits="lab12_Interiano.Page3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="gvTeams" runat="server" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="TeamID" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" OnRowDeleted="gvTeams_RowDeleted">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                    <asp:BoundField DataField="TeamID" HeaderText="TeamID" InsertVisible="False" ReadOnly="True" SortExpression="TeamID" Visible="False" />
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                    <asp:BoundField DataField="CoachLName" HeaderText="CoachLName" SortExpression="CoachLName" />
                    <asp:BoundField DataField="CoachFName" HeaderText="CoachFName" SortExpression="CoachFName" />
                </Columns>
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\players.mdb;Persist Security Info=True" DeleteCommand="DELETE FROM [Teams] WHERE [TeamID] = ?" InsertCommand="INSERT INTO [Teams] ([TeamID], [Name], [CoachLName], [CoachFName]) VALUES (?, ?, ?, ?)" ProviderName="System.Data.OleDb" SelectCommand="SELECT [TeamID], [Name], [CoachLName], [CoachFName] FROM [Teams]" UpdateCommand="UPDATE [Teams] SET [Name] = ?, [CoachLName] = ?, [CoachFName] = ? WHERE [TeamID] = ?">
                <DeleteParameters>
                    <asp:Parameter Name="TeamID" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="TeamID" Type="Int32" />
                    <asp:Parameter Name="Name" Type="String" />
                    <asp:Parameter Name="CoachLName" Type="String" />
                    <asp:Parameter Name="CoachFName" Type="String" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="Name" Type="String" />
                    <asp:Parameter Name="CoachLName" Type="String" />
                    <asp:Parameter Name="CoachFName" Type="String" />
                    <asp:Parameter Name="TeamID" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
            <asp:Label ID="lblDeleteStatus" runat="server" Font-Bold="True" ForeColor="Red" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
