using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieTicketBooking
{
    /// <summary>
    /// Class used to PersonalDetails Datatype creation
    /// </summary>
    public class PersonalDetails
    {
        // property
        /// <summary>
        /// Property name used to get user name
        /// </summary>
        /// <value>string returnType</value>
        public string UserName { get; set; }

        // property
        /// <summary>
        /// Property name used to get age of the user
        /// </summary>
        /// <value>int returnType</value>
        public int Age { get; set; }

        // property
        /// <summary>
        /// Property name used to get phone number of the user
        /// </summary>
        /// <value>long returnType</value>
        public long PhoneNumber { get; set; }

        // constructor
        /// <summary>
        /// Constructor used to get personal details
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="age"></param>
        /// <param name="phoneNumber"></param>
        public PersonalDetails(string userName, int age, long phoneNumber)
        {

            UserName = userName;
            Age = age;
            PhoneNumber = phoneNumber;

        }
    }
}