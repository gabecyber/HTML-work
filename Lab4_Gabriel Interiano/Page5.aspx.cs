﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab4_Gabriel_Interiano {
    public partial class Page5 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

		protected void btnDisplay_Click(object sender, EventArgs e) {
			string msg = "Your favorite teams are:" + Environment.NewLine;
			ListItem li = rblTeams.SelectedItem;
			
				
					msg += "Text: " + li.Text + ", "
						+ "Value: " + li.Value + ", "
						+ "Selected: " + li.Selected
						+ Environment.NewLine;
				
			
			txtMessage.Text = msg;
		}

      
    }
}