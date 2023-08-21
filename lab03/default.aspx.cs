using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab03
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCompute_Click(object sender, EventArgs e) {
            String strInput = txtInput.Text;
            double dblInput = Convert.ToDouble(strInput);
            IbIAnswer.Text = "Square Root = " + Math.Sqrt(dblInput);

        }
    }
}