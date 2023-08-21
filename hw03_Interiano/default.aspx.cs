using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using hw03_Interiano;

namespace hw03_Interiano {
    public partial class _default : System.Web.UI.Page {
        List<int> Aseats = new List<int>();
        public List<Seats> purchases = new List<Seats>();
        protected void Page_Load(object sender, EventArgs e) {
            Aseats = (List<int>)Session["AvailableSeats"] as List<int>;
            List<Seats> items = new List<Seats>();
            if ( !Page.IsPostBack && Aseats != null) {
                
                
                
                    for (int i = 0; i < Aseats.Count; i++) {
                        AvailableSeats.Items.Add(Aseats.ElementAt(i).ToString());
                        
                        amountSeats.Text = "Pick Seat, " + AvailableSeats.Items.Count + " Available";
                    }
              
            }
            items = (List<Seats>)Session["List"] as List<Seats>;
            
        }

        protected void EventSummary_Click(object sender, EventArgs e) {
            
            List<Seats> items = new List<Seats>();
            SEvent order = new SEvent(EventName.Text);
            Session["Event"] = order;
          

            Session["Purchases"] = purchases;

            Response.Redirect("Summary.aspx");
        }

        protected void Reset_Click(object sender, EventArgs e) {
            Session.Clear();
            EventName.Text = "";
            AvailableSeats.Items.Clear();
            amountSeats.Text = "Pick Seat, " + "0" + " Available";
        }

        protected void MakeEvent_Click(object sender, EventArgs e) {
            String eventName = EventName.Text;
            int MinSeats = Int32.Parse(First.Text);
            int MaxSeats = Int32.Parse(Last.Text);
            SEvent Sevent = new SEvent(eventName);
            Sevent.addSeats(MaxSeats, MinSeats);
            Session["Event"] = Sevent;
            List<int> seats= new List<int>(Sevent.GetList());
            for (int i = 0; i < seats.Count; i++) {
                AvailableSeats.Items.Add(seats.ElementAt(i).ToString());
            }
            amountSeats.Text = "Pick Seat, " + AvailableSeats.Items.Count +" Available";
        }

        protected void Purchase_Click(object sender, EventArgs e) {
            if (Name.Text != "" && Age.Text != "") {
                List<int> Aseats = new List<int>();
                for (int i = 0; i < AvailableSeats.Items.Count; i++) {
                    Aseats.Add(Int32.Parse(AvailableSeats.Items[i].ToString()));
                }

                List<Seats> items = new List<Seats>();
                List<Seats> tempitems = new List<Seats>(purchases);
                tempitems = (List<Seats>)Session["List"] as List<Seats>;
                if (tempitems != null) {
                    items = tempitems;
                }
                String IName = Name.Text;
                String IAge = Age.Text;
                double Price = 0;
                int Seat = Int32.Parse(AvailableSeats.SelectedItem.ToString());

                if (int.Parse(Age.Text) <= 12) {
                    Price = 5.00;
                }
                else {
                    Price = 10.00;
                }
                Seats Order = new Seats(IName, Seat, IAge, Price);

                items.Add(Order);
                Session["List"] = items;
                Aseats.Remove(Order.SeatNum);
                AvailableSeats.Items.Remove(AvailableSeats.SelectedItem);
                Session["AvailableSeats"] = Aseats;
                amountSeats.Text = "Pick Seat, " + AvailableSeats.Items.Count + " Available";
            }
            else {
                amountSeats.Text = "Please add your name and age";
            }
        }
    }
}