namespace Solid.Refactoring
{
  

    public class Regular : Movie
    {
        public Regular(string title):base(title, MovieType.Regular){}

        public override double CalculatePrice(int daysRented)
        {
            var rentalAmount = 0.00;

            rentalAmount += 2;
            if (daysRented > 2)
            {
                rentalAmount += (daysRented - 2) * 1.5;
            }
            return rentalAmount;
        }
    }
}