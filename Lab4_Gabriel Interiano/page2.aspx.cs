using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab4_Gabriel_Interiano {
    public partial class WebForm2 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

		protected void btnDisplayAll_Click(object sender, EventArgs e) {
			string msg = string.Empty;
			foreach (ListItem li in ddlNames.Items) {
				msg += "Text: " + li.Text + ", "
					+ "Value: " + li.Value + ", "
					+ "Selected: " + li.Selected
					+ Environment.NewLine;
			}
			txtMessage.Text = msg;
		}

		protected void btnDisplaySelected_Click(object sender, EventArgs e) {
			ListItem li = ddlNames.SelectedItem;
			string msg = Environment.NewLine + "In Click event" + Environment.NewLine
				+ "   Text: " + li.Text + ", "
				+ "Value: " + li.Value + ", "
				+ "Selected: " + li.Selected;
			txtMessage.Text += msg;

		}

		protected void btnAdd_Click(object sender, EventArgs e) {
			if (!String.IsNullOrEmpty(txtText.Text) && !String.IsNullOrEmpty(txtValue.Text)) {
				string text = txtText.Text;
				string value = txtValue.Text;
				ListItem li = new ListItem(text, value);
				ddlNames.Items.Add(li);
				txtMessage.Text = "ListItem added to dropdown";
				txtText.Text = String.Empty;
				txtValue.Text = String.Empty;
			}
			else {
				txtMessage.Text = "Must supply a value for Text & Value";
			}

		}

		protected void btnRemoveSelected_Click(object sender, EventArgs e) {
			if (ddlNames.SelectedItem != null) {
				ListItem li = ddlNames.SelectedItem;
				ddlNames.Items.Remove(li);
				txtMessage.Text = "ListItem removed: " + li.Text + ", " + li.Value;
			}
		}

        protected void ddlNames_SelectedIndexChanged(object sender, EventArgs e) {
			ListItem li = ddlNames.SelectedItem;
			string msg = Environment.NewLine + "In SelectedIndexChanged event" + Environment.NewLine
				+ "   Text: " + li.Text + ", "
				+ "Value: " + li.Value + ", "
				+ "Selected: " + li.Selected;
			txtMessage.Text += msg;

		}
	}
}