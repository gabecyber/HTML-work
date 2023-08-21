using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab05_Interiano {
    public partial class pback2 : System.Web.UI.Page {
        string newLine = System.Environment.NewLine;
        protected void Page_Load(object sender, EventArgs e) {
            // First time on page
            if (!Page.IsPostBack) {
                txtMessage.Text += newLine + "***First time on page" + newLine;
            }
            // Postback.
            else {
                txtMessage.Text += newLine + "***Post-back" + newLine;
            }
        }
        protected void btnSubmit_Click(object sender, EventArgs e) {
            txtMessage.Text += "***Submit callled" + newLine;
        }
        protected void btnPage1_Click(object sender, EventArgs e) {
            // Go to page 1
            Response.Redirect("pback1.aspx");
        }
    }

}