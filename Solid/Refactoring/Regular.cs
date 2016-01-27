namespace Solid.Refactoring
{
    public class Regular: IMovie
    {
        public Regular(string title)
        {
            Title = title;
        }

        public string Title { get; private set; }

        public double CalculatePrice(int daysRented)
        {
            var rentalAmount = 0.00;

            rentalAmount += 2;
            if (daysRented > 2)
            {
                rentalAmount += (daysRented - 2) * 1.5;
            }
            return rentalAmount;
        }

        public MovieType MovieType { get; set; }
    }
}