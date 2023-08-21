using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab06 {
    public partial class Default2 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            Dog d1 = new Dog("Chaps", 6);
            Dog d2 = new Dog("Gigi", 4);
            Dog d3 = new Dog("Zoro", 11);

            Person p = new Person("Jackson");
            p.Dogs.Add(d1);
            p.Dogs.Add(d2);
            p.Dogs.Add(d3);

            foreach (Dog dog in p.Dogs) {
                txtMessage.Text += dog.Name + ", " + dog.Age + "\n";
            }

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e) {

        }
    }
}