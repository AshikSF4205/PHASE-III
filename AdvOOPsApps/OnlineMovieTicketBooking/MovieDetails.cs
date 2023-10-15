using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieTicketBooking
{
    /// <summary>
    /// Class used to MovieDetails Datatype creation
    /// </summary>
    public class MovieDetails
    {
        // Field
        /// <summary>
        /// Static field for auto-incrementing the movie id <see cref="movieDetails"/> class
        /// </summary>
        private static int s_id = 500;
        /// <summary>
        /// Static field for return the movie id <see cref="movieDetails"/> class
        /// </summary>
        private string _movieId;

        // property
        /// <summary>
        /// Property name used to get movieId
        /// </summary>
        /// <value>string returnType</value>
        public string MovieId
        {
            get
            {
                return _movieId;
            }
        }

        // property
        /// <summary>
        /// Property name used to get movie name
        /// </summary>
        /// <value>string returnType</value>
        public string MovieName { get; set; }

        // property
        /// <summary>
        /// Property name used to get movie language
        /// </summary>
        /// <value>string returnType</value>
        public string Language { get; set; }

        // constructor
        /// <summary>
        /// Constructor used to get movie details
        /// </summary>
        /// <param name="movieName"></param>
        /// <param name="language"></param>
        public MovieDetails(string movieName, string language)
        {
            _movieId = "MID" + (++s_id);
            MovieName = movieName;
            Language = language;

        }
    }
}