namespace Solid.Refactoring {

  public class Movie {
    //
    public const int Childrens = 2;
    public const int Regular = 0;
    public const int NewRelease = 1;

    public string Title { get; private set; }
    public int PriceCode { get; private set; }

    public Movie( string title, int price) {
     
      PriceCode = price;
      Title = title;
    }

    public void SetPrice( int arg )
    {
      PriceCode = arg;
    }
  }