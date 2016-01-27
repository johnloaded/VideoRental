namespace Solid.Refactoring
{
    public class Childrens: IMovie
    {
        public Childrens(string title)
        {
            Title = title;
        }

        public MovieType MovieType { get; set; }

        public string Title { get; private set; }

        public double CalculatePrice (int daysRented)
        {
            var rentalAmount = 0.00;

            rentalAmount += 1.5;
            if (daysRented > 3)
            {
                rentalAmount += (daysRented - 3) * 1.5;
            }
            return rentalAmount;
        }
    }
}