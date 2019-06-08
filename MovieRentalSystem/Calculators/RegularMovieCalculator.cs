using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRentalSystem
{
    class RegularMovieCalculator : ICalculator
    {
        public double Amount(int daysRented)
        {
            double amount = Movie.REGULAR_MOVIE_PRICE;
            if (daysRented > Movie.REGULAR_MOVIE_THRESHOLD_DAYS)
            {
                amount += (daysRented - Movie.REGULAR_MOVIE_PRICE) * Movie.REGULAR_MOVIE_SURGE;
            }

            return amount;
        }
    }
}
