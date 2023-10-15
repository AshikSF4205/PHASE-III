using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarInfo.obj
{
    public class CarInfo
    {

        // RCBookNumber, EngineNumber, ChasisNumber, Milage, Tank Capacity, NumberOfSeats, NumberOfKmDriven, DateOfPurchase.

        public string RCNumber { get; set; }
        public string EngineNumber { get; set; }
        public string ChasisNumber { get; set; }
        public double Milage { get; set; }
        public int Capacity { get; set; }
        public int NumberOfSeats { get; set; }
        public double NumberOfKmDriven { get; set; }
        public DateTime DoP { get; set; }
        public CarInfo(string rCNumber, string engineNumber, string chasisNumber, double milage, int capacity, int numberOfSeats, double numberOfKmDriven, DateTime doP)
        {
            RCNumber = rCNumber;
            EngineNumber = engineNumber;
            ChasisNumber = chasisNumber;
            Milage = milage;
            Capacity = capacity;
            NumberOfSeats = numberOfSeats;
            NumberOfKmDriven = numberOfKmDriven;
            DoP = doP;
        }
         
        public int CalculateMilage(){
            
            return 0 ;
        }

        
    }
}