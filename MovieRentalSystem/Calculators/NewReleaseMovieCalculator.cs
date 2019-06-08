using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRentalSystem
{
    class NewReleaseMovieCalculator : ICalculator
    {
        public double Amount(int daysRented)
        {
            return daysRented * Movie.NEW_RELEASE_MOVIE_PRICE;
        }
    }
}
