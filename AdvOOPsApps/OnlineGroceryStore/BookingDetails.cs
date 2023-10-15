using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceryStore
{
    public enum BookingStatus{Select, Initiated, Booked, Cancelled}
    public class BookingDetails
    {
        private static int s_id = 3000;
        private string _bookingID;

        public string BookingID
        {
            get
            {
                return _bookingID;
            }
        }
        public string CustomerID { get; set; }
        public double TotalPrice { get; set; }
        public DateTime DateOfBooking { get; set; }
        public BookingStatus BookingStatus { get; set; }

        public BookingDetails(string customerID)
        {
            _bookingID = $"BID{++s_id}";
            CustomerID = customerID;
            TotalPrice = 0;
            DateOfBooking = DateTime.Today;
            BookingStatus = BookingStatus.Initiated;
        }

        public BookingDetails(string customerID, double totalPrice, DateTime dateOfBooking, BookingStatus bookingStatus)
        {
            _bookingID = $"BID{++s_id}";
            CustomerID = customerID;
            TotalPrice = totalPrice;
            DateOfBooking = dateOfBooking;
            BookingStatus = bookingStatus;
        }
    }
}