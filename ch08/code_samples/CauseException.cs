// Demonstrates causing an exception when input is not a number.
using System;

class CauseException
{
  static void Main()
  {
    Console.Write("Enter an integer: ");
    
    string numString = Console.ReadLine();
    int anInt = int.Parse(numString);

    Console.WriteLine("{0} stored in number as {1}", 
                      numString, anInt);
    Console.ReadLine();
  }
}