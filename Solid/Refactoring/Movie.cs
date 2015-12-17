namespace Solid.Refactoring
{

    public class Movie
    {
        public string Title { get; private set; }
        public MovieType MovieType { get; private set; }

        public Movie(string title, MovieType movieType)
        {

            MovieType = movieType;
            Title = title;
        }

        public void SetPrice(MovieType movieType)
        {
            MovieType = movieType;
        }
    }
}