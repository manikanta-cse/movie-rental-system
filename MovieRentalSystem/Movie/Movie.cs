using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRentalSystem
{
    public class Movie
    {

        public const double REGULAR_MOVIE_PRICE = 2;
        public const double NEW_RELEASE_MOVIE_PRICE = 3;
        public const double CHILDREN_MOVIE_PRICE = 1.5;
        public const double BLURAY_MOVIE_PRICE = 4;

        public const double REGULAR_MOVIE_THRESHOLD_DAYS = 2;
        public const double CHILDERS_MOVIE_THRESHOLD_DAYS = 3;

        public const double REGULAR_MOVIE_SURGE = 1.5;
        public const double CHILDERS_MOVIE_SURGE = 1.5;



        public string Title { get;  }

        public MovieType PriceCode { get;  }


        public Movie(string title, MovieType priceCode)
        {
            this.Title = title;
            this.PriceCode = priceCode;
        }
       

        public double Amount(int daysRented)
        {
            return CalculatorFactory.GetCalculator(PriceCode).Amount(daysRented);
        }

        private bool IsNewRelease()
        {
            return PriceCode == MovieType.NEWRELEASE;
        }

        private bool IsBluRay()
        {
            return PriceCode == MovieType.BLURAY;
        }

        private bool IsBonusApplicable(int daysRented)
        {
            return IsNewRelease() && daysRented > 1;
        }

        public int FrequentRenterPoints(int daysRented)
        {
            int points = 1;
            if (IsBonusApplicable(daysRented))
            {
                points = 2;
            }
            else if (IsBluRay())
            {
                points = 3;
            }

            return points;
        }
    }
}
