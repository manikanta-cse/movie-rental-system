using System.Collections.Generic;
using MovieRentalSystem.Movie;

namespace MovieRentalSystem.Statements
{
    public class TextStatement : IStatement
    {

        private string Name { get; }

        private IEnumerable<Rental> Rentals { get; }

        private double TotalAmount { get; }

        private int TotalFrequentRenterPoints { get; }


        public TextStatement(string name, IEnumerable<Rental> rentals, double totalAmount, int totalFrequentRenterPoints)
        {
            this.Rentals = rentals;
            this.Name = name;
            this.TotalFrequentRenterPoints = totalFrequentRenterPoints;
            this.TotalAmount = totalAmount;
        }

        public string Statement()
        {
            return Header() + Body() + Footer();
        }

        private string Footer()
        {
            string footer = "";
            footer += "Amount owed is " + TotalAmount + "\n";
            footer += "You earned " + TotalFrequentRenterPoints + " frequent renter points";
            return footer;
        }

        private string Body()
        {
            string body = "";

            foreach (var rental in Rentals)
            {
                body += "\t" + rental.Movie.Title + "\t" + rental.Amount() + "\n";
            }
            return body;
        }

        private string Header()
        {
            return "Rental Record for " + Name + "\n";
        }


    }
}
