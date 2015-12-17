using System.Collections.Generic;

namespace Solid.Refactoring {
  public class Customer {
    private string _name;
    private List<Rental> _rentals = new List<Rental>();

    public Customer( string name ) {
      _name = name;
    }

    public void AddRental( Rental arg ) {
      _rentals.Add( arg );
    }

    public string GetName() {
      return _name;
    }

    public string Statement() {
      double totalAmount = 0;
      int frequentRenterPoints = 0;
      string result = "Rental Record for " + GetName() + "\n";
      foreach ( var rental in _rentals ) {
        double rentalAmount = 0;
        //determine amounts for each line 
        switch ( rental.Movie.MovieType ) {
          case MovieType.Regular:
            rentalAmount += 2;
            if ( rental.GetDaysRented() > 2 ) {
              rentalAmount += ( rental.GetDaysRented() - 2 ) * 1.5;
            }
            break;
          case MovieType.NewRelease:
            rentalAmount += rental.GetDaysRented() * 3;
            break;
          case MovieType.Childrens:
            rentalAmount += 1.5;
            if ( rental.GetDaysRented() > 3 ) {
              rentalAmount += ( rental.GetDaysRented() - 3 ) * 1.5;
            }
            break;
        }

        // add frequent renter points
        frequentRenterPoints++;
        
        // add bonus for a two day new release rental
        if ( ( rental.Movie.MovieType == MovieType.NewRelease ) && rental.GetDaysRented() > 1 ) {
          frequentRenterPoints++;
        }

        //show figures for this rental
        result += "\t" + rental.Movie.Title + "\t" + rentalAmount + "\n";
        totalAmount += rentalAmount;
      }
      //add footer lines
      result += "Amount owed is " + totalAmount + "\n";
      result += "You earned " + frequentRenterPoints + " frequent renter points";
      return result;
    }
  }
}