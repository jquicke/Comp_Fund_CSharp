using System;

class ExceptionExample
{
  static void Main()
  { 
    // Integer division by zero causes a DivideByZeroException
    int numerator = 5;
    int denominator = 0;
    int quotient = numerator / denominator;  // A runtime error
    Console.WriteLine("This message will not be reached");
  }
}