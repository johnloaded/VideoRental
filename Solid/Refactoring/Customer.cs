using System;
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
            return CreateStatementHeader() + CreateStatementBody() + CreateStatementFooter();
        }

        private string CreateStatementHeader()
        {
            return "Rental Record for " + GetName() + "\n";
        }

        private string CreateStatementBody()
        {
            string result = String.Empty;
            foreach (var rental in _rentals)

            {
                var rentalAmount = rental.Movie.CalculatePrice(rental.GetDaysRented());
                //show figures for this rental
                result += "\t" + rental.Movie.Title + "\t" + rentalAmount + "\n";
            }
            return result;
        }

        private string CreateStatementFooter()
        {
            var result = "Amount owed is " + GetTotalRentalAmount() + "\n";
            result += "You earned " + GetfrequentRenterPoints() + " frequent renter points";
            return result;
        }

        private double GetTotalRentalAmount()
        {
            double totalAmount = 0;
            foreach (var rental in _rentals)
            {
                totalAmount += rental.Movie.CalculatePrice(rental.GetDaysRented());
            }
            return totalAmount;
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