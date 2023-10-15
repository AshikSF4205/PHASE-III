using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieTicketBooking
{
    /// <summary>
    /// Class used to UserDetails Datatype creation
    /// </summary>
    public class UserDetails : PersonalDetails, IWallet
    {
        // Field
        /// <summary>
        /// Static field for auto-incrementing the user id <see cref="UserDetails"/> class
        /// </summary>
        private static int s_id = 1000;
        /// <summary>
        /// field for return the user id <see cref="UserDetails"/> class
        /// </summary>
        private string _userId;

        /// <summary>
        /// field for return the balance <see cref="UserDetails"/> class
        /// </summary>
        private double _balance;

        // property
        /// <summary>
        /// Property name used to get userId
        /// </summary>
        /// <value>string returnType</value>
        public string UserId
        {
            get
            {
                return _userId;
            }
        }

        // property
        /// <summary>
        /// Property name used to get wallet balance
        /// </summary>
        /// <value>double returnType</value>
        public double WalletBalance
        {
            get
            {
                return _balance;
            }
        }

        // constructor
        /// <summary>
        /// Constructor used to get user details
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="age"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="walletBalance"></param>
        public UserDetails(string userName, int age, long phoneNumber, double walletBalance) : base(userName, age, phoneNumber)
        {
            _userId = "UID" + (++s_id);
            UserName = userName;
            Age = age;
            PhoneNumber = phoneNumber;
            _balance = walletBalance;

        }

        // Method for recharging the wallet
        /// <summary>
        /// Method used to recharge the wallet
        /// </summary>
        /// <param name="rechargeAmount"></param>
        public void WalletRecharge(double rechargeAmount)
        {
            _balance += rechargeAmount;
        }

        // Method for deducting amount from wallet
        /// <summary>
        /// Method used to deduct the balance
        /// </summary>
        /// <param name="deductAmount"></param>
        public void DeductBalance(double deductAmount)
        {
            _balance -= deductAmount;
        }

    }
}
