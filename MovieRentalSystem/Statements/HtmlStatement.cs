using System.Collections.Generic;
using MovieRentalSystem.Movie;

namespace MovieRentalSystem.Statements
{
    public class HtmlStatement : IStatement
    {

        private string Name { get; }

        private IEnumerable<Rental> Rentals { get; }

        private double TotalAmount { get; }

        private int TotalFrequentRenterPoints { get; }


        public HtmlStatement(string name, IEnumerable<Rental> rentals, double totalAmount, int totalFrequentRenterPoints)
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
            footer += "Amount owed is <b>" + TotalAmount + "</b><br>";
            footer += "You earned <b>" + TotalFrequentRenterPoints
                    + "</b> frequent renter points </html>";
            return footer;
        }

        private string Body()
        {
            string body = "";

            foreach (var rental in Rentals)
            {
                body += "\t" + rental.Movie.Title + "\t" + rental.Amount() + "<br>";
            }
            return body;
        }

        private string Header()
        {
            return "<html><H1>Rental Record for <b>" + Name + "</b></H1>";
        }

    }
}
