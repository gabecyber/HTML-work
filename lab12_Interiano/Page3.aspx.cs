using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab12_Interiano {
    public partial class Page3 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

		/// <summary>
		/// This event is fired after an attempt has been made to delete a row from the
		/// GridView (and database). If the delete fails, an exception is thrown, which
		/// is contained in the event arg, "e".
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected void gvTeams_RowDeleted(object sender, GridViewDeletedEventArgs e) {
			// If delete was successful (i.e. no exception was thrown)
			if (e.Exception == null) {
				lblDeleteStatus.Text = "Team deleted";
			}
			// If delete failed (i.e. an exception was thrown), then display a message
			// and set a flag indicating that the exception was handled.
			else {
				lblDeleteStatus.Text = "Team can't be deleted, Players exist.";
				e.ExceptionHandled = true;
			}

		}

	}
}