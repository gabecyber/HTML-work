using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab05_Interiano {
    public partial class pback1 : System.Web.UI.Page {
        string newLine = Environment.NewLine;
        protected void Page_Load(object sender, System.EventArgs e) {
            // First time on page
            if (!Page.IsPostBack) {
                txtMessage.Text += newLine + "***First time on page" + newLine;
            }
            // Postback
            else {
                txtMessage.Text += newLine + "***Post-back" + newLine;
            }
        }
        protected void btnSubmit_Click(object sender, System.EventArgs e) {
            txtMessage.Text += "***Submit callled" + newLine;
        }
        protected void btnLoadPage_Click(object sender, EventArgs e) {
            // Reload the page.
            Response.Redirect(Request.RawUrl);
        }
        protected void btnPage2_Click(object sender, EventArgs e) {
            // Go to page 2.
            Response.Redirect("pback2.aspx");
        }
    }

}