// Show the CD class and its varying versions of 
// ToString results based on the number of units sold.
using System;

public class TestCD
{
  static void Main()
  { 
    // Construct two instances of CD and view state with ToString 
    CD album1 = new CD("20-Cent", "Shout First");
    CD album2 = new CD("Bungles", "Green Album");

    Console.WriteLine(album1);
    album1.RecordNewSales(250000);
    Console.WriteLine(album1);
    album1.RecordNewSales(300000);
    Console.WriteLine(album1);
    album1.RecordNewSales(600000);
    Console.WriteLine(album1);

    // Another CD Object
    Console.WriteLine();
    album2.RecordNewSales(501342);
    Console.WriteLine(album2);
  }
} // end class TestCD