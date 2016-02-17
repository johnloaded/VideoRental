namespace Solid.Refactoring
{
    public interface IMovie
    {
        string Title { get; }
        double CalculatePrice(int daysRented);
        int CalculateFrequentRenterPoints(int daysRented);
        MovieType MovieType { get; }
    }
}