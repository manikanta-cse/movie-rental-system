using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRentalSystem
{
    public interface ICalculator
    {
        double Amount(int daysRented);
    }
}
