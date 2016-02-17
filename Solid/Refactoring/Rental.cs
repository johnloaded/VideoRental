using System.Runtime.InteropServices;

namespace Solid.Refactoring
{

    public class Rental
    {
        public IMovie Movie { get; private set; }
        private int _daysRented;

        public Rental(IMovie movie, int daysRented)
        {
            Movie = movie;
            _daysRented = daysRented;
        }

        public int GetDaysRented()
        {
            return _daysRented;
        }

        /*public int CalculateFrequentRenterPoints()
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
        }*/
    }
}