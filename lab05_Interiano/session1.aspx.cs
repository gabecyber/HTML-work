using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab05_Interiano {
	public partial class session1 : System.Web.UI.Page {

		int sum;
		protected void Page_Load(object sender, EventArgs e) {
			if (!Page.IsPostBack) {
				Session.Add("Sum", 0);
			}
			else {
				sum = Convert.ToInt32(Session["Sum"]);
			}

		}

		protected void bthAdd_Click(object sender, EventArgs e) {
			int curNum = Convert.ToInt32(txtNum.Text);
			sum += curNum;
			txtMessage.Text += "Current Num=" + curNum + ", Sum=" + sum + "\n";
			txtNum.Focus();
			txtNum.Attributes["onfocus"] = "this.select();";
			Session.Add("Sum", sum);
		}
	}

}