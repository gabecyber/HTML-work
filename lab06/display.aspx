<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="display.aspx.cs" Inherits="lab06.display" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        	Me &amp; My Dogs
			<asp:Button ID="btnCreateMore" runat="server" OnClick="btnCreateMore_Click" Text="Create More Dogs" />
			<br />
			<asp:TextBox ID="txtMessage" runat="server" Height="245px" TextMode="MultiLine" Width="481px"></asp:TextBox>
			<br />
        </div>
    </form>
</body>
</html>

5.	Open the code behind file and replace the display class (everything below the namespace, except the last brace) with:

	public partial class display : System.Web.UI.Page {
		private Person p;
		protected void Page_Load(object sender, EventArgs e) {

			if (Session["person"] == null) {
				txtMessage.Text = "Didn't find a Person";
			}
			else {
				p = (Person)Session["person"];

				foreach (Dog dog in p.Dogs) {
					txtMessage.Text += dog.Name + ", " + dog.Age + "\n";
				}
			}
		}

		protected void btnCreateMore_Click(object sender, EventArgs e) {
			Response.Redirect("create.aspx");
		}
	}

