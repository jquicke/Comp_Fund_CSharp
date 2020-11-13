// This program reads a number from the user,
// then writes out that number squared.

using System;

class SquareIt
{
  // This Main method runs my program.
  static void Main()
  {
    // I)nput   -- get the number from the user
    Console.Write("Enter a number: ");
    double number = double.Parse(Console.ReadLine());

    // P)rocess -- make calculations based on the input
    double result = number * number;

    // O)utput  -- display the results on the screen
    Console.WriteLine("{0} squared = {1}", number, result);
  }
}