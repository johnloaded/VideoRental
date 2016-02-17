namespace Solid.Refactoring
{


    public class Regular : Movie
    {
        private int StandardDays = 2;
        private int StandardRate = 2;
        private double LateRate = 1.5;
        
        public Regular(string title) : base(title, MovieType.Regular)
        {
        }

        public override double CalculatePrice(int daysRented)
        {
            double rentalAmount = StandardRate;
            if (daysRented > StandardDays)
            {
                rentalAmount += (daysRented - StandardDays)*LateRate;
            }
            return rentalAmount;
        }

        public new int CalculateFrequentRenterPoints(int daysRented)
        {
            return StandardPoint;
        }
    }
}
