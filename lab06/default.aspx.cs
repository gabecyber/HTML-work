using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab06 {
    public partial class _default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            Dog d = new Dog("Chaps", 6);
            d.Age = 7;
            txtMessage.Text = "Name: " + d.Name + ", Age: " + d.Age;


        }
    }
}