using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCard
{
    public class UserDetails
    {
        public string CardNumber { get { return _cardNumber; } }

        public string UserName { get; set; }
        public long PhoneNumber { get; set; }
        public double Balance { get; set; }

        static private int _id = 101;
        private string _cardNumber;

        public UserDetails(string userName, long phoneNumber, double balance)
        {
            UserName = userName;
            Balance = balance;
            PhoneNumber = phoneNumber;
            _cardNumber = "CMRL" + _id++;

        }

    }
}