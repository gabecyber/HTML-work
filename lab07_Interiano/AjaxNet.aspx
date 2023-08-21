<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AjaxNet.aspx.cs" Inherits="lab07_Interiano.AjaxNet" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Ajax .Net Controls</title>
</head>
<body>
    <h1>Simple AJAX Example Using .Net Server Controls</h1>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <asp:Label ID="lblTime" runat="server" Text="Label"></asp:Label>
            <asp:Timer ID="Timer1" runat="server" Interval="2000" OnTick="Timer1_Tick">
            </asp:Timer>
            <br />
            Ajax: Click a a name in either list and it moves to the other list
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:ListBox ID="ListNames1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ListNames1_SelectedIndexChanged">
                        <asp:ListItem>Dontavious</asp:ListItem>
                        <asp:ListItem>Linda</asp:ListItem>
                        <asp:ListItem>Xavier</asp:ListItem>
                    </asp:ListBox>
                    <asp:ListBox ID="ListNames2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ListNames2_SelectedIndexChanged">
                        <asp:ListItem>Wally</asp:ListItem>
                        <asp:ListItem>Suzy</asp:ListItem>
                        <asp:ListItem>Remmy</asp:ListItem>
                    </asp:ListBox>
                    <asp:UpdateProgress ID="UpdateProgress1" runat="server">
                        <ProgressTemplate>
                            <asp:Label ID="Label1" runat="server" Text="...moving name"></asp:Label>
                        </ProgressTemplate>
                    </asp:UpdateProgress>
                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="Button1" EventName="Click" />
                </Triggers>
            </asp:UpdatePanel>
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Move First" />
    </form>
</body>
</html>
