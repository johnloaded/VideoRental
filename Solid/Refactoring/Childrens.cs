namespace Solid.Refactoring
{
    public class Childrens: Movie
    {
       public Childrens(string title):base(title, MovieType.Childrens){}

       public override double CalculatePrice (int daysRented)
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