using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solid.Refactoring;

namespace Solid {
  internal class Program {
    private static void Main( string[] args )
    {

        var terminator = new Movie("Terminator", MovieType.Regular);
        var xmen = new Movie("Xmen", MovieType.NewRelease);
        var john = new Customer("John");
        var rentOfTerminator = new Rental(terminator, 5);
        var rentOfXmen = new Rental(xmen, 3);

        john.AddRental(rentOfTerminator);
        john.AddRental(rentOfXmen);

      Console.WriteLine(john.Statement());

      Console.ReadKey();
    }

    private static void InterfaceExample()
    {
      var bmw = new Car(5);
      GetConsumption(bmw, 20);
      //var result = bmw.Consume(20);
      //Console.WriteLine( result );

      //GetConsumption( bmw, 20 );

      var myvan = new Van(8);
      GetConsumption(myvan, 20);

      //var vanResult = myvan.Consume(20);
      //Console.WriteLine( vanResult );

      //GetConsumption( myvan, 20 );
    }

    /// <summary>
    /// because we cannot access not static method within static 
    /// context we changed this method to be static
    /// </summary>
    //private static void GetConsumption( Car car, int mileages ) {
    //  var result = car.Consume( mileages );
    //  Console.WriteLine( result );
    //}

    //private static void GetConsumption( Van van, int mileages ) {
    //  var result = van.Consume( mileages );
    //  Console.WriteLine( result );
    //}

    private static void GetConsumption( IConsume vehicle, int mileages ) {
      var result = vehicle.FuelConsumption( mileages );
      Console.WriteLine( result );
    }
  }
}
