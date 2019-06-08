using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRentalSystem
{
    public class Customer
    {
        private string Name { get; set; }

        private List<Rental> Rentals { get; set; }

        public Customer(string name)
        {
            this.Name = name;
            this.Rentals = new List<Rental>();
        }

        public void AddRental(Rental rental)
        {
            this.Rentals.Add(rental);
        }

        public string TextStatement()
        {
            return new TextStatement(Name, Rentals, TotalAmount(), TotalFrequentRenterPoints()).Statement();
        }

        public string HtmlStatement()
        {
            return new HtmlStatement(Name, Rentals, TotalAmount(), TotalFrequentRenterPoints()).Statement();
        }

        private int TotalFrequentRenterPoints()
        {
            var totalFrequentRenterPoints = 0;
            foreach (var rental in Rentals)
            {
                totalFrequentRenterPoints += rental.FrequentRenterPoints();
            }
            return totalFrequentRenterPoints;

        }

        private double TotalAmount()
        {
            double totalAmount = 0;

            foreach (var rental in Rentals)
            {
                totalAmount += rental.Amount();
            }

            return totalAmount;
        }



    }
}
