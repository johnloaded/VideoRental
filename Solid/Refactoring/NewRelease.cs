namespace Solid.Refactoring
{
    public class NewRelease: Movie
    {
        private int StandardDays = 1;
        private double StandardRate = 3;
        private int ExtraPoint = 1;
        
        public NewRelease(string title) : base(title, MovieType.NewRelease){}
        
        public override double CalculatePrice(int daysRented)
        {
            return daysRented * StandardRate;
           
        }

        public override int CalculateFrequentRenterPoints(int daysRented)
        {
            var points = StandardPoint;
            // add frequent renter points

            // add bonus for a two day new release rental
            if (daysRented > StandardDays)
            {
                points+=ExtraPoint;
            }
            return points;
        }
    }
}