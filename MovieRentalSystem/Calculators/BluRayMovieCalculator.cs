using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRentalSystem
{
    class BluRayMovieCalculator : ICalculator
    {
        public double Amount(int daysRented)
        {
            return daysRented * Movie.BLURAY_MOVIE_PRICE;
        }
    }
}
