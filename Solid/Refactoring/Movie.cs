namespace Solid.Refactoring
{
    public abstract class Movie : IMovie
    {
        protected Movie(string title, MovieType movieType)
        {
            Title = title;
            MovieType = movieType;
        }

        public string Title { get; private set; }
        public abstract double CalculatePrice(int daysRented);
        public MovieType MovieType { get; private set; }
    }

}