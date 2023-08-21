using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace hw03_Interiano {
    public class SEvent {
        List<Seats> purchases = new List<Seats>();
        public String EventName;
        public List<int> seats = new List<int>();

        public SEvent(String EventName) {
            this.EventName = EventName;
        }
        public SEvent(List<Seats> purchases) {
            this.purchases = purchases;
        }
        public void addSeats(int numMax, int numMin) {

            for (int i = 0; i <= numMax; i++) {
                if (i >= numMin) {
                    
                    seats.Add(i);

                }
            }
        }


        public int GetSeats(int i) {
            if (i >= 0 && i < seats.Count) {
                return seats[i];
            }
            return 0;
        }
        public List<int> GetList() {
            return seats;
        }
        public String GenerateReport(List<Seats> purchases, List<int> AvailableSeats) {
            string newLine = Environment.NewLine;
            double TotalTicketsPrices = 0.0;
            double TicketsAverage = 0.0;
            int TicketsSold = 0;
            string report = String.Format("Name                      Seat         Age       Price \n");
            report += String.Format("-------------------------  --------- ---------- ----------\n");
            for (int i = 0; i < purchases.Count; i++) {
                Seats currentOrder = purchases[i];
            report += String.Format(currentOrder.Name.ToString() +"                         " + currentOrder.SeatNum+"          "+ currentOrder.age + "          $" + currentOrder.price +".00\n");
                TicketsSold++;
                TotalTicketsPrices += currentOrder.price;
                TicketsAverage += currentOrder.price;
            }
            
            report+= String.Format("-------------------------  --------- ---------- ----------\n");
            int ACount = AvailableSeats.Count - 1;
            report += String.Format("Tickets Sold: " + TicketsSold+"\n");
            report += String.Format("Tickets Available: "+ + ACount+ "\n");
            report += String.Format("Total Ticket Prices: $" + TotalTicketsPrices + ".00"+"\n");
            
            report += String.Format("Average Ticket Prices: $" + TicketsAverage / purchases.Count+"\n");
            report += String.Format("Available Seats: ");
            for (int i = 0; i < AvailableSeats.Count; i++) {

                report += String.Format(AvailableSeats[i].ToString() +",");
            }
            report += String.Format("\n");




            return report;
        }
    }
}
