using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCard
{
    public class TravelDetails
    {

        public string TravelID { get { return _travelID; } }

        public string CardNumber { get; set; }
        public string FromLocation { get; set; }
        public string ToLocation { get; set; }
        public DateTime Date { get; set; }
        public double TravelCost { get; set; }

        static private int _id = 101;
        private string _travelID;
        public TravelDetails(string cardNumber, string fromLocation, string toLocation, DateTime date, double travelCost)
        {
            CardNumber = cardNumber;
            ToLocation = toLocation;
            TravelCost = travelCost;
            FromLocation = fromLocation;
            Date = date;

            _travelID = "TID" + _id++;

        }



    }
}