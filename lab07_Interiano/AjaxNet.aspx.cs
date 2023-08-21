using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab07_Interiano {
    public partial class AjaxNet : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void ListNames1_SelectedIndexChanged(object sender, EventArgs e) {
            System.Threading.Thread.Sleep(3000);
            string curItem = ListNames1.SelectedItem.ToString();
            ListNames2.Items.Add(curItem);
            ListNames1.Items.Remove(ListNames1.SelectedItem);

        }

        protected void ListNames2_SelectedIndexChanged(object sender, EventArgs e) {
            System.Threading.Thread.Sleep(3000);
            string curItem = ListNames2.SelectedItem.ToString();
            ListNames1.Items.Add(curItem);
            ListNames2.Items.Remove(ListNames2.SelectedItem);
        }

        protected void Button1_Click(object sender, EventArgs e) {

            if (ListNames1.Items.Count > 0) {
                ListItem li = ListNames1.Items[0];
                ListNames1.Items.Remove(li);
                ListNames2.Items.Add(li);
                ListNames2.SelectedIndex = -1;
            }

        }

        protected void Timer1_Tick(object sender, EventArgs e) {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }
    }
}