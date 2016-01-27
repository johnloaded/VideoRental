namespace Solid.Refactoring
{
    public class NewRelease: Movie
    {
        public NewRelease(string title) : base(title, MovieType.NewRelease){}
        
        public override double CalculatePrice(int daysRented)
        {
            var rentalAmount = 0.00;

            rentalAmount = daysRented * 3;

            return rentalAmount;
        }
    }
}