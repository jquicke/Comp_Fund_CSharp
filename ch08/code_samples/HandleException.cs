// Demonstrates handling one exception (FormatException).
using System;

class HandleException
{
  public static readonly double DEFAULT_VALUE = -1.0;

  static void Main()
  { // read a number
    Console.Write("Enter an integer: ");
    string numString = Console.ReadLine();
    double number;
    
    try
    { // convert the number from string to double
      number = double.Parse(numString);
      Console.WriteLine("Number parsed successfully.");
    }
    catch (FormatException fe)
    {
      // Execute this code whenever Parse throws an exception
      Console.WriteLine("Error with value {0}: {1}", 
                        numString, fe.Message);
      Console.WriteLine("Setting number to {0}", DEFAULT_VALUE);
      number = DEFAULT_VALUE;  // reset to -1
    }
    
    Console.WriteLine("{0} stored as {1}", numString, number);
  }
}