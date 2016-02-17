namespace Solid.Refactoring
{
    public class Childrens : Movie
    {
        private int StandardDays = 3;
        private double StandardRate = 1.5;
        private double LateRate = 1.5;
        
        public Childrens(string title) : base(title, MovieType.Childrens)
        {
        }

        public override double CalculatePrice(int daysRented)
        {

            double rentalAmount = StandardRate;
            if (daysRented > StandardDays)
            {
                rentalAmount += (daysRented - StandardRate)*LateRate;
            }
            return rentalAmount;
        }

        public new int CalculateFrequentRenterPoints(int daysRented)
        {
            return StandardPoint;
        }
    }
}