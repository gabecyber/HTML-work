using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab05_Interiano {
	public partial class session2b : System.Web.UI.Page {

		private int sum;
		private string name;
		protected void Page_Load(object sender, EventArgs e) {
			if (!Page.IsPostBack) {
				// If first time on page, and sum is not in Session,
				// initialize sum to 0 and put in Session.
				if (Session["Sum"] == null) {
					sum = 0;
					Session.Add("Sum", sum);
				}
				// If first time on page and sum is in Session, get it
				// and display it.
				else {
					int sum = Convert.ToInt32(Session["Sum"]);
					lblSum.Text = sum.ToString();
				}
			}
			else {
				// If postback, pull sum from Session
				sum = Convert.ToInt32(Session["Sum"]);
			}

		}

		protected void btnAdd1_Click(object sender, EventArgs e) {
			// Increase the sum by 1, put in Session, and display.
			sum++;
			Session.Add("Sum", sum);
			lblSum.Text = sum.ToString();
		}

		protected void btnPage1_Click(object sender, EventArgs e) {
			// Go back to first page.
			Response.Redirect("session2a.aspx");
		}
	}

}