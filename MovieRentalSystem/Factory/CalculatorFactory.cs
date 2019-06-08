using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRentalSystem
{
    public static class CalculatorFactory
    {


        public static ICalculator GetCalculator(MovieType movieType)
        {
            switch (movieType)
            {
                case MovieType.REGULAR:
                    return new RegularMovieCalculator();
                case MovieType.NEWRELEASE:
                    return new NewReleaseMovieCalculator();
                case MovieType.CHILDRENS:
                    return new ChildrensMovieCalculator();
                case MovieType.BLURAY:
                    return new BluRayMovieCalculator();
                default:
                    throw new InvalidOperationException();
            }
        }

    }
}
