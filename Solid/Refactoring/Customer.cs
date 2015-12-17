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

        public int GetfrequentRenterPoints()
        {
            int frequentRenterPoints = 0;
            foreach (var rental in _rentals)
            {

                // add frequent renter points
                frequentRenterPoints++;
                // add bonus for a two day new release rental
                if ((rental.Movie.MovieType == MovieType.NewRelease) && rental.GetDaysRented() > 1)
                {
                    frequentRenterPoints++;
                }
            }
            return frequentRenterPoints;
        }
    }
}