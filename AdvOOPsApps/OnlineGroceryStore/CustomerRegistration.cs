using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceryStore
{
    public class CustomerRegistration : PersonalDetails, IBalance
    {
        private static int s_id = 3000;
        private string _customerID;

        public string CustomerID
        {
            get
            {
                return _customerID;
            }
        }
        public double WalletBalance { get; set; }
        
        public void WalletRecharge(double amount)
        {
            WalletBalance += amount;
        }

        public CustomerRegistration(string name, string fatherName, Gender gender, long mobileNumber, DateTime dob, string mailID, double walletBalance) : base(name, fatherName, gender, mobileNumber, dob, mailID)
        {
            _customerID = $"CID{++s_id}";
            WalletBalance = walletBalance;
        }
    }
}