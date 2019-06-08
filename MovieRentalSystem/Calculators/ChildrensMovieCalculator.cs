using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRentalSystem
{
    class ChildrensMovieCalculator : ICalculator
    {
        public double Amount(int daysRented)
        {
            var amount = Movie.CHILDREN_MOVIE_PRICE;

            if(daysRented > Movie.CHILDERS_MOVIE_THRESHOLD_DAYS)
            {
                amount += (daysRented - Movie.CHILDREN_MOVIE_PRICE) * Movie.CHILDERS_MOVIE_SURGE;
            }

            return amount;
        }
    }
}
