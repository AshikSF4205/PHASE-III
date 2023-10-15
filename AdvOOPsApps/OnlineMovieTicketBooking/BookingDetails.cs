using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieTicketBooking
{
    /// <summary>
    ///Booking Status Enum type
    /// </summary>
    public enum BookingStatusEnum { Booked = 1, Cancelled = 0 }

    /// <summary>
    /// Class used to BookingDetails Datatype creation
    /// </summary>
    public class BookingDetails
    {
        // Field
        /// <summary>
        /// Static field for auto-incrementing the booking id <see cref="BookingDetails"/> class
        /// </summary>
        private static int s_id = 7000;
        /// <summary>
        /// Static field for return the booking id <see cref="BookingDetails"/> class
        /// </summary>
        private string _bookingId;

        // property
        /// <summary>
        /// Property name used to get booking Id
        /// </summary>
        /// <value>string returnType</value>
        public string BookingId
        {
            get
            {
                return _bookingId;
            }
        }

        // property
        /// <summary>
        /// Property name used to get userId
        /// </summary>
        /// <value>string returnType</value>
        public string UserId { get; set; }

        // property
        /// <summary>
        /// Property name used to get movie id
        /// </summary>
        /// <value>string returnType</value>
        public string MovieId { get; set; }

        // property
        /// <summary>
        /// Property name used to get theater id
        /// </summary>
        /// <value>string returnType</value>
        public string TheaterId { get; set; }

        // property
        /// <summary>
        /// Property name used to get seat count
        /// </summary>
        /// <value>int returnType</value>
        public int SeatCount { get; set; }


        // property
        /// <summary>
        /// Property name used to get total amount of booking
        /// </summary>
        /// <value>double returnType</value>
        public double TotalAmount { get; set; }

        // property
        /// <summary>
        /// Property name used to get booking status
        /// </summary>
        /// <value>BookingStatusEnum returnType</value>
        public BookingStatusEnum BookingStatus { get; set; }

        // constructor
        /// <summary>
        /// Constructor used to get booking details
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="movieId"></param>
        /// <param name="theaterId"></param>
        /// <param name="seatCount"></param>
        /// <param name="totalAmount"></param>
        /// <param name="bookingStatus"></param>
        public BookingDetails(string userId, string movieId, string theaterId, int seatCount, double totalAmount, BookingStatusEnum bookingStatus)
        {

            _bookingId = "BID" + (++s_id);
            UserId = userId;
            MovieId = movieId;
            TheaterId = theaterId;
            SeatCount = seatCount;
            TotalAmount = totalAmount;
            BookingStatus = bookingStatus;

        }

        //Default Constructor
        public BookingDetails()
        {

        }
    }
}