using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab4_Gabriel_Interiano {
    public partial class WebForm4 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

		protected void btnDisplay_Click(object sender, EventArgs e) {
			string msg = "Your favorite teams are:" + Environment.NewLine;
			foreach (ListItem li in cblTeams.Items) {
				if (li.Selected) {
					msg += "Text: " + li.Text + ", "
						+ "Value: " + li.Value + ", "
						+ "Selected: " + li.Selected
						+ Environment.NewLine;
				}
			}
			txtMessage.Text = msg;
		}

	}
}