using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab05_Interiano {
    public partial class postback : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
           
            if (!Page.IsPostBack) {
                lbxNames.Items.Add(new ListItem("Dave", "11"));
                lbxNames.Items.Add(new ListItem("Paul", "44"));
                lbxNames.Items.Add(new ListItem("Anna", "3"));
            }
            else {
                // Postback
            }

        }

        protected void btnDisplay_Click(object sender, EventArgs e) {
            
            for (int i = lbxNames.Items.Count - 1; i >= 0; i--) {
                ListItem li = lbxNames.Items[i];

                if (li.Selected) {

                    txtMessage.Text += li.ToString() + ", ";

                    lbxNames.Items.Remove(li);
                }
            }
        }
    }
}