<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page2.aspx.cs" Inherits="lab10_Interiano.Page2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="gvPlayers" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="dsPlayers" DataKeyNames="PlayerID" OnSelectedIndexChanged="gvPlayers_SelectedIndexChanged">
                <Columns>
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                    <asp:BoundField DataField="PlayerID" HeaderText="PlayerID" InsertVisible="False" ReadOnly="True" SortExpression="PlayerID" />
                    <asp:TemplateField HeaderText="Team" SortExpression="TeamID">
                        <EditItemTemplate>
                            <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="dsSqlTeams" DataTextField="Name" DataValueField="TeamID" SelectedValue='<%# Bind("TeamID") %>'>
                            </asp:DropDownList>
                            <asp:SqlDataSource ID="dsSqlTeams" runat="server" ConnectionString="<%$ ConnectionStrings:playersConnectionString %>" ProviderName="<%$ ConnectionStrings:playersConnectionString.ProviderName %>" SelectCommand="SELECT [TeamID], [Name] FROM [Teams]"></asp:SqlDataSource>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="gvLblTeamName" runat="server" Text='<%# Bind("Name") %>'></asp:Label>
                            <asp:HiddenField ID="TeamIDHidden" runat="server" Visible="false" 
Value='<%# Eval("TeamID") %>' />

                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="LName" HeaderText="LName" SortExpression="LName" />
                    <asp:BoundField DataField="FName" HeaderText="FName" SortExpression="FName" />
                    <asp:BoundField DataField="PNumber" HeaderText="PNumber" SortExpression="PNumber" />
                    <asp:BoundField DataField="BDate" DataFormatString="{0:MM/dd/yyyy}" HeaderText="BDate" SortExpression="BDate" />
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" Visible="False" />
                </Columns>
            </asp:GridView>
            <asp:TextBox ID="txtMsg" runat="server" Height="215px" TextMode="MultiLine" Width="418px"></asp:TextBox>
            <br />
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="TeamID">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:playersConnectionString %>" ProviderName="<%$ ConnectionStrings:playersConnectionString.ProviderName %>" SelectCommand="SELECT [TeamID], [Name] FROM [Teams]"></asp:SqlDataSource>
            <asp:SqlDataSource ID="dsPlayers" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" DeleteCommand="DELETE FROM [Players] WHERE [PlayerID] = ?" InsertCommand="INSERT INTO [Players] ([PlayerID], [TeamID], [LName], [FName], [PNumber], [BDate]) VALUES (?, ?, ?, ?, ?, ?)" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT Players.PlayerID, Players.TeamID, Players.LName, Players.FName, Players.PNumber, Players.BDate, Teams.Name FROM (Players INNER JOIN Teams ON Players.TeamID = Teams.TeamID)" UpdateCommand="UPDATE [Players] SET [TeamID] = ?, [LName] = ?, [FName] = ?, [PNumber] = ?, [BDate] = ? WHERE [PlayerID] = ?">
                <DeleteParameters>
                    <asp:Parameter Name="PlayerID" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="PlayerID" Type="Int32" />
                    <asp:Parameter Name="TeamID" Type="Int32" />
                    <asp:Parameter Name="LName" Type="String" />
                    <asp:Parameter Name="FName" Type="String" />
                    <asp:Parameter Name="PNumber" Type="Int32" />
                    <asp:Parameter Name="BDate" Type="DateTime" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="TeamID" Type="Int32" />
                    <asp:Parameter Name="LName" Type="String" />
                    <asp:Parameter Name="FName" Type="String" />
                    <asp:Parameter Name="PNumber" Type="Int32" />
                    <asp:Parameter Name="BDate" Type="DateTime" />
                    <asp:Parameter Name="PlayerID" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
