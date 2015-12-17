namespace Solid.Refactoring {

  public class Rental {
    public Movie Movie { get; private set; }
    private int _daysRented;

    public Rental( Movie movie, int daysRented ) {
      Movie = movie;
      _daysRented = daysRented;
    }

    public int GetDaysRented() {
      return _daysRented;
    }
  }
}