﻿
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solid.Refactoring
{

    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void WhenRentRegularMovie_ShouldGiveRightStatement()
        {
            var terminator = new Movie("Terminator", MovieType.Regular);
            var john = new Customer("John");
            var rentOfTerminator = new Rental(terminator, 5);

            john.AddRental(rentOfTerminator);

            var statement = john.Statement();

            Assert.IsTrue(statement.Contains("Amount owed is 6.5"));
        }

        [TestMethod]
        public void WhenRentMovies_ShouldGiveRightStatement()
        {
            var terminator = new Movie("Terminator", MovieType.Regular);
            var xmen = new Movie("Xmen", MovieType.NewRelease);
            var john = new Customer("John");
            var rentOfTerminator = new Rental(terminator, 5);
            var rentOfXmen = new Rental(xmen, 3);

            john.AddRental(rentOfTerminator);
            john.AddRental(rentOfXmen);

            var statement = john.Statement();

            Assert.IsTrue(statement.Contains("Amount owed is 15.5"));
        }

        [TestMethod]
        public void WhenGetStatement_ShouldPrintCustomerName()
        {
            var terminator = new Movie("Terminator", MovieType.Regular);
            var john = new Customer("John");
            var rentOfTerminator = new Rental(terminator, 5);

            john.AddRental(rentOfTerminator);

            var statement = john.Statement();

            Assert.IsTrue(statement.Contains("Rental Record for " + john.GetName()));

        }

        [TestMethod]
        public void WhenGetStatement_ShouldPrintMovieTitle()
        {
            var terminator = new Movie("Terminator", MovieType.Regular);
            var john = new Customer("John");
            var rentOfTerminator = new Rental(terminator, 5);

            john.AddRental(rentOfTerminator);

            var statement = john.Statement();

            Assert.IsTrue(statement.Contains(terminator.Title));

        }

        [TestMethod]
        public void WhenGetStatement_ShouldPrintMoviesTitles()
        {
            var terminator = new Movie("Terminator", MovieType.Regular);
            var xmen = new Movie("Xmen", MovieType.NewRelease);
            var john = new Customer("John");
            var rentOfTerminator = new Rental(terminator, 5);
            var rentOfXmen = new Rental(xmen, 3);

            john.AddRental(rentOfTerminator);
            john.AddRental(rentOfXmen);

            var statement = john.Statement();
            Assert.IsTrue(statement.Contains(xmen.Title));
            Assert.IsTrue(statement.Contains(terminator.Title));

        }

        [TestMethod]
        public void WhenGetStatement_ShouldPrintFrequentPoint()
        {
            var terminator = new Movie("Terminator", MovieType.Regular);
            var john = new Customer("John");
            var rentOfTerminator = new Rental(terminator, 5);

            john.AddRental(rentOfTerminator);

            var statement = john.Statement();
            Assert.IsTrue(statement.Contains("You earned 1 frequent renter point"));
        }


        [TestMethod]
        public void WhenGetStatement_ShouldPrintFrequentPoints()
        {
            var terminator = new Movie("Terminator", MovieType.Regular);
            var xmen = new Movie("Xmen", MovieType.NewRelease);
            var john = new Customer("John");
            var rentOfTerminator = new Rental(terminator, 5);
            var rentOfXmen = new Rental(xmen, 3);

            john.AddRental(rentOfTerminator);
            john.AddRental(rentOfXmen);

            var statement = john.Statement();
            Assert.IsTrue(statement.Contains("You earned 3 frequent renter point"));
        }
    }
}
