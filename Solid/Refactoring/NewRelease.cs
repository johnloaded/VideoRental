namespace Solid.Refactoring
{
    public class NewRelease: IMovie
    {
        public NewRelease(string title)
        {
            Title = title;
        }

        public MovieType MovieType
        {
            get
            {
                return MovieType.NewRelease;
            }
            
        }

        public string Title { get; private set; }

        public double CalculatePrice(int daysRented)
        {
            var rentalAmount = 0.00;

            rentalAmount = daysRented * 3;

            return rentalAmount;
        }
    }
}