using System.Collections.Generic;

namespace Solid.Refactoring
{
    public class Customer
    {
        private string _name;
        private List<Rental> _rentals = new List<Rental>();

        public Customer(string name)
        {
            _name = name;
        }

        public void AddRental(Rental arg)
        {
            _rentals.Add(arg);
        }

        public string GetName()
        {
            return _name;
        }

        public string Statement()
        {
            double totalAmount = 0;
            string result = "Rental Record for " + GetName() + "\n";
            foreach (var rental in _rentals)
            {
                var rentalAmount = rental.CalculateRent();
                totalAmount += rentalAmount;
                //show figures for this rental
                result += "\t" + rental.Movie.Title + "\t" + rentalAmount + "\n";

            }
            //add footer lines
            result += "Amount owed is " + totalAmount + "\n";
            result += "You earned " + GetfrequentRenterPoints() + " frequent renter points";
            return result;
        }

        private int GetfrequentRenterPoints()
        {
            int frequentRenterPoints = 0;
            foreach (var rental in _rentals)
            {
                frequentRenterPoints += rental.CalculateFrequentRenterPoints();
            }
            return frequentRenterPoints;
        }
    }
}