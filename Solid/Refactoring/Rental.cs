using System.Runtime.InteropServices;

namespace Solid.Refactoring
{

    public class Rental
    {
        public Movie Movie { get; private set; }
        private int _daysRented;

        public Rental(Movie movie, int daysRented)
        {
            Movie = movie;
            _daysRented = daysRented;
        }

        public int GetDaysRented()
        {
            return _daysRented;
        }

        public double CalculateRent()
        {
            var rentalAmount = 0.00;
            switch (Movie.MovieType)
            {
                case MovieType.Regular:
                    rentalAmount += 2;
                    if (_daysRented > 2)
                    {
                        rentalAmount += (_daysRented - 2) * 1.5;
                    }
                    break;
                case MovieType.NewRelease:
                    rentalAmount += _daysRented * 3;
                    break;
                case MovieType.Childrens:
                    rentalAmount += 1.5;
                    if (_daysRented > 3)
                    {
                        rentalAmount += (_daysRented - 3) * 1.5;
                    }
                    break;
            }
            return rentalAmount;
        }

        public int CalculateFrequentRenterPoints()
        {
            var points = 0;
            // add frequent renter points

            points++;
            // add bonus for a two day new release rental
            if ((Movie.MovieType == MovieType.NewRelease) && _daysRented > 1)
            {
                points++;
            }
            return points;
        }
    }
}