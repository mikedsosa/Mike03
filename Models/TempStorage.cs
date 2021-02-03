using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mike03.Models
{

    //Create a temporary storage location/list to store all the movies a user enters during his/her session
    public static class TempStorage
    {
        private static List<EnterNewMovieResponse> movies = new List<EnterNewMovieResponse>();

        public static IEnumerable<EnterNewMovieResponse> Movies => movies;
        public static void AddMovie(EnterNewMovieResponse movie)
        {
            movies.Add(movie);
        }
    }
}
