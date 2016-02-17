namespace Solid.Refactoring
{
    public abstract class Movie : IMovie
    {
        protected int StandardPoint = 1;
        protected Movie(string title, MovieType movieType)
        {
            Title = title;
            MovieType = movieType;
        }

        public string Title { get; private set; }
        public abstract double CalculatePrice(int daysRented);

        public virtual int CalculateFrequentRenterPoints(int daysRented){
        
            return StandardPoint;
        }

        public MovieType MovieType { get; private set; }
    }

}