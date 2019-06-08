namespace MovieRentalSystem
{
    public class Rental
    {
        public int DaysRented { get; }
        public Movie Movie { get; }

        public Rental(Movie movie, int daysRented)
        {
            this.Movie = movie;
            this.DaysRented = daysRented;
        }

        public double Amount()
        {
            return Movie.Amount(DaysRented);
        }

        public int FrequentRenterPoints()
        {
            return Movie.FrequentRenterPoints(DaysRented);
        }
    }
}