using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab05_Interiano {
	public partial class session2a : System.Web.UI.Page {

		private int sum;
		protected void Page_Load(object sender, EventArgs e) {
			if (!Page.IsPostBack) {
				// If first time on page, initialize sum to 0 and put in Session.
				sum = 0;
				Session.Add("Sum", sum);
			}
			else {
				// If postback, pull sum from Session
				sum = Convert.ToInt32(Session["Sum"]);
			}
		}

		protected void btnSave_Click(object sender, EventArgs e) {
			// Get the value entered ...
			int num = Convert.ToInt32(txtFavInt.Text);
			// ...which serves as the initial sum
			sum = num;
			// Add the sum and name to Session.
			Session.Add("Sum", sum);
			Session.Add("Name", txtName.Text);
			// Display the sum
			lblSum.Text = num.ToString();
		}

		protected void btnAdd1_Click(object sender, EventArgs e) {
			// Add 1 to the current sum and then store in Session.
			sum++;
			Session.Add("Sum", sum);
			lblSum.Text = sum.ToString();
		}

		protected void btnPage2_Click(object sender, EventArgs e) {
			// Go to new page.
			Response.Redirect("session2b.aspx");
		}
	}


}