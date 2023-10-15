using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCard
{
    public class TicketFairDetails
    {

        public string TicketID { get { return _tickedID; } }

        public string FromLocation { get; set; }
        public string ToLocation { get; set; }
        public double TicketPrice { get; set; }

        static private int _id = 101;
        private string _tickedID;


        public TicketFairDetails(string fromLocation, string toLocation, double ticketPrice)
        {
            FromLocation = fromLocation;
            ToLocation = toLocation;
            TicketPrice = ticketPrice;
            _tickedID = "MR" + _id++;

        }



    }
}