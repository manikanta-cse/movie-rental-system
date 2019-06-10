namespace MovieRentalSystem.Calculators
{
    class BluRayMovieCalculator : ICalculator
    {
        public double Amount(int daysRented)
        {
            return daysRented * Movie.Movie.BLURAY_MOVIE_PRICE;
        }
    }
}
