using System;
using Xunit;

namespace MovieRentalSystem.Tests
{
    public class CustomerTest
    {
        [Fact]
        public void ShoudlReturnTextStatementWithDefaultValues()
        {
            Customer customer = new Customer("Test0");
            Assert.Equal("Rental Record for Test0\n" +
                "Amount owed is 0\n" +
                "You earned 0 frequent renter points", customer.TextStatement());

        }

        [Fact]
        public void ShoudlReturnTextStatementWithSingleRental()
        {
            Customer customer = new Customer("Test0");
            customer.AddRental(new Rental(new Movie("ABC", MovieType.REGULAR), 5));
            Assert.Equal("Rental Record for Test0\n" +
                    "\tABC\t6.5\n" +
                    "Amount owed is 6.5\n" +
                    "You earned 1 frequent renter points", customer.TextStatement());
        }

        [Fact]
        public void ShoudlReturnTextStatementWithMultipleRentals()
        {
            Customer customer = new Customer("Test0");
            customer.AddRental(new Rental(new Movie("ABC", MovieType.REGULAR), 5));
            customer.AddRental(new Rental(new Movie("XYZ", MovieType.NEWRELEASE), 9));
            customer.AddRental(new Rental(new Movie("UVC", MovieType.CHILDRENS), 2));
            Assert.Equal("Rental Record for Test0\n" +
                    "\tABC\t6.5\n" +
                    "\tXYZ\t27\n" +
                    "\tUVC\t1.5\n" +
                    "Amount owed is 35\n" +
                    "You earned 4 frequent renter points", customer.TextStatement());
        }

        [Fact]
        public void ShouldReturnHTMLStatement()
        {
            Customer customer = new Customer("Test0");
            customer.AddRental(new Rental(new Movie("ABC", MovieType.REGULAR), 5));
            customer.AddRental(new Rental(new Movie("XYZ", MovieType.NEWRELEASE), 9));
            customer.AddRental(new Rental(new Movie("UVC", MovieType.CHILDRENS), 2));
            Assert.Equal("<html><H1>Rental Record for <b>Test0</b></H1>" +
                    "\tABC\t6.5<br>" +
                    "\tXYZ\t27<br>" +
                    "\tUVC\t1.5<br>" +
                    "Amount owed is <b>35</b><br>" +
                    "You earned <b>4</b> frequent renter points </html>", customer.HtmlStatement());
        }

        [Fact]
        public void ShouldReturnStatementForBluRayMovie()
        {
            Customer customer = new Customer("Test0");
            customer.AddRental(new Rental(new Movie("ABC", MovieType.BLURAY), 1));
            Assert.Equal("<html><H1>Rental Record for <b>Test0</b></H1>" +
                    "\tABC\t4<br>" +
                    "Amount owed is <b>4</b><br>" +
                    "You earned <b>3</b> frequent renter points </html>", customer.HtmlStatement());
        }

    }
}
