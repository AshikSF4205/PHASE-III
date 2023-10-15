using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieTicketBooking
{
    /// <summary>
    /// Class used to TheatreDetails Datatype creation
    /// </summary>
    public class TheatreDetails
    {
        // Field
        /// <summary>
        /// Static field for auto-incrementing the theatre id <see cref="TheatreDetails"/> class
        /// </summary>
        private static int s_id = 300;
        /// <summary>
        /// Static field for return the theatre id <see cref="TheatreDetails"/> class
        /// </summary>
        private string _theatreId;

        // property
        /// <summary>
        /// Property name used to get theatreId
        /// </summary>
        /// <value>string returnType</value>
        public string TheatreId
        {
            get
            {
                return _theatreId;
            }
        }

        // property
        /// <summary>
        /// Property name used to get theatre name
        /// </summary>
        /// <value>string returnType</value>
        public string TheatreName { get; set; }

        // property
        /// <summary>
        /// Property name used to get theatre location
        /// </summary>
        /// <value>string returnType</value>
        public string TheatreLocation { get; set; }

        // constructor
        /// <summary>
        /// Constructor used to get theatre details
        /// </summary>
        /// <param name="theatreName"></param>
        /// <param name="theatreLocation"></param>
        public TheatreDetails(string theatreName, string theatreLocation)
        {
            _theatreId = "TID" + (++s_id);
            TheatreName = theatreName;
            TheatreLocation = theatreLocation;

        }

        public TheatreDetails(){
            
        }
    }
}