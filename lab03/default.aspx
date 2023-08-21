<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="lab03._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

   <title>Lab 3 - Gabriel Interiano</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2> 
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
                Lab 3 - Gabriel Interiano</h2>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:Button ID="btnCompute" runat="server" OnClick="btnCompute_Click" Text="Square Root" />
                    <asp:TextBox ID="txtInput" runat="server"></asp:TextBox>
                    <asp:Label ID="IbIAnswer" runat="server" Text="IbIAnswer"></asp:Label>
                </ContentTemplate>
            </asp:UpdatePanel>
            <p> 
                &nbsp;</p>
        </div>
        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtInput" ErrorMessage="Input must be positive" ForeColor="Red" MaximumValue="Double.MaxValue" MinimumValue="0"></asp:RangeValidator>
        <br />
        <asp:Label ID="Label1" runat="server" Text="The reason the answer's always 13 is that  169.0 is set to be a default value when the page and the text input is loaded, so no matter what it will only calculate the square root of 169.0"></asp:Label>
        <br />
    </form>
</body>
</html>
