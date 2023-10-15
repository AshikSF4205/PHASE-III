using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieTicketBooking
{
    /// <summary>
    /// Class used to ScreeningDetails Datatype creation
    /// </summary>
    public class ScreeningDetails
    {
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
        /// Property name used to get ticket price
        /// </summary>
        /// <value>double returnType</value>
        public double TicketPrice { get; set; }

        // property
        /// <summary>
        /// Property name used to get no.of seats available
        /// </summary>
        /// <value>int returnType</value>
        public int NoOfSeatsAvailable { get; set; }

        // constructor
        /// <summary>
        /// Constructor used to get screening details
        /// </summary>
        /// <param name="movieId"></param>
        /// <param name="theaterId"></param>
        /// <param name="noOfSeatsAvailable"></param>
        /// <param name="ticketPrice"></param>
        public ScreeningDetails(string movieId, string theaterId, double ticketPrice, int noOfSeatsAvailable)
        {
            MovieId = movieId;
            TheaterId = theaterId;
            TicketPrice = ticketPrice;
            NoOfSeatsAvailable = noOfSeatsAvailable;

        }
    }
}