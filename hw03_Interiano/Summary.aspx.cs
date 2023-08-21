using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace hw03_Interiano {
    public partial class Summary : System.Web.UI.Page {
       
        SEvent order;
        List<Seats> purchases = new List<Seats>();
        List<int> AvailableSeats = new List<int>();
        protected void Page_Load(object sender, EventArgs e) {
            if (!Page.IsPostBack) {
                if (Session["Event"] == null) {
                    Response.Redirect("default.aspx");
                }
                else {

                    order = (SEvent)Session["Event"];
                    EventName.Text = "Ticket Holders for "+ order.EventName;
                    purchases = (List<Seats>)Session["List"] as List<Seats>;
                    AvailableSeats = (List<int>)Session["AvailableSeats"] as List<int>;
                    OrdersBox.Text = order.GenerateReport(purchases,AvailableSeats);
                    ddlTicketHolders.Items.Insert(0, new ListItem("Choose Person to Remove", "0"));
                    for (int i = 0; i < purchases.Count; i++) {
                        ddlTicketHolders.Items.Add(purchases[i].Name.ToString());
                    }
                }
            }
            else {
                order = (SEvent)Session["SEvent"];
                List<Seats> Items = (List<Seats>)Session["List"];
            }
        }

        protected void PurchaseMore_Click(object sender, EventArgs e) {
            List<Seats> items = new List<Seats>();

            SEvent order = new SEvent(EventName.Text);
            Session["Event"] = order;
            order = (SEvent)Session["Event"];
            
            purchases = (List<Seats>)Session["List"] as List<Seats>;
            AvailableSeats = (List<int>)Session["AvailableSeats"] as List<int>;

            Session["Purchases"] = purchases;
            Session["AvailableSeats"] = AvailableSeats;
            Response.Redirect("default.aspx");
        }

        protected void Remove_Click(object sender, EventArgs e) {
            order = (SEvent)Session["Event"];
            purchases = (List<Seats>)Session["List"] as List<Seats>;
            AvailableSeats = (List<int>)Session["AvailableSeats"] as List<int>;
            String ItemToRemove = ddlTicketHolders.SelectedItem.ToString();
            
            while( 0 < purchases.Count) {
               
                if (purchases[0].Name.ToString()==(ItemToRemove)) {
                    AvailableSeats.Add(purchases[0].SeatNum);
                    purchases.Remove(purchases[0]);
                    
                }
                
                
            }
            OrdersBox.Text = order.GenerateReport(purchases, AvailableSeats);
            Session["AvailableSeats"] = AvailableSeats;
            Session["List"] = purchases;
        }

      

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e) {
            order = (SEvent)Session["Event"];
            purchases = (List<Seats>)Session["List"] as List<Seats>;
            List<Seats> TempList = purchases; 
            AvailableSeats = (List<int>)Session["AvailableSeats"] as List<int>;

            if (RadioButtonList1.SelectedIndex ==0) {
               TempList = sortPurchased(TempList);
                OrdersBox.Text = order.GenerateReport(TempList, AvailableSeats);
            }
            if (RadioButtonList1.SelectedIndex == 1) {
               TempList = sortName(TempList);
                OrdersBox.Text = order.GenerateReport(TempList, AvailableSeats);
            }
            if (RadioButtonList1.SelectedIndex == 2) {
                TempList = sortSeat(TempList);
                OrdersBox.Text = order.GenerateReport(TempList, AvailableSeats);
            }
            
        }

        public List<Seats> sortPurchased(List<Seats> purchases) {
            purchases = (List<Seats>)Session["List"] as List<Seats>;
            return purchases;
        }
        public List<Seats> sortName(List<Seats> purchases) {
            List<Seats> SortedList = purchases.OrderBy(o => o.Name).ToList();
            return SortedList;
        }
        public List<Seats> sortSeat(List<Seats> purchases) {
            List<Seats> SortedList = purchases.OrderBy(o => o.SeatNum).ToList();
            return SortedList;
        }
    }
}