using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace hw03_Interiano {
    public class Seats {
        public int SeatNum;
        public String Name;
        public String age;
        public double price;
        public String Item;
        public Seats(int SeatNum) {
            this.SeatNum = SeatNum;
        }

        public Seats(String Name, int SeatNum, String age, double price) {
            this.Name = Name;
            this.SeatNum = SeatNum;
            this.age = age;
            this.price = price;
        }

        public Seats(String Item) {
            this.Item = Item;
        }
    }
}