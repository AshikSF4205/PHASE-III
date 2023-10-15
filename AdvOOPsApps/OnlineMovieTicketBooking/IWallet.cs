using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieTicketBooking
{
    /// <summary>
    /// Interface used to Wallet functions
    /// </summary>
    public interface IWallet
    {
        public double WalletBalance { get; }
        public void WalletRecharge(double rechargeAmount);

    }
}