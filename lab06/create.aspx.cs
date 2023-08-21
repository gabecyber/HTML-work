using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab06 {
	public partial class create : System.Web.UI.Page {
		private Person p;
		protected void Page_Load(object sender, EventArgs e) {

			if (!Page.IsPostBack) {
				if (Session["person"] == null) {
					txtMessage.Text = "Create a Person";
				}
				else {
					// If returning from display page, pull Person from Session
					p = (Person)Session["person"];
				}
			}
			else {
				// If postback, pull Person from Session
				p = (Person)Session["person"];
			}
		}

		protected void btnCreatePerson_Click(object sender, EventArgs e) {
			// Create Person object
			Person p = new Person(txtNamePerson.Text);
			// Save object to Session.
			Session.Add("person", p);

			txtMessage.Text = "";
			txtNameDog.Focus();
		}

		protected void btnCreateDog_Click(object sender, EventArgs e) {
			// Make sure there is a Person object
			if (p == null) {
				txtMessage.Text = "No person has been created yet";
				return;
			}
			// Create Dog and add to Person
			int age = Convert.ToInt32(txtAgeDog.Text);
			Dog d = new Dog(txtNameDog.Text, age);
			p.Dogs.Add(d);

			// Must update Session after change to Person
			Session.Add("person", p);

			// Clean up UI
			txtNameDog.Text = "";
			txtNameDog.Focus();
			txtAgeDog.Text = "";
		}

		protected void btnDisplayAll_Click(object sender, EventArgs e) {
			foreach (Dog dog in p.Dogs) {
				txtMessage.Text += dog.Name + ", " + dog.Age + "\n";
			}
		}

		protected void btnStartOver_Click(object sender, EventArgs e) {
			Session.Clear();
			Response.Redirect(Request.RawUrl);
		}

		protected void btnDisplayAllOtherPage_Click(object sender, EventArgs e) {
			Response.Redirect("display.aspx");
		}
	}
