// Show the return value from calling Math methods.
// The Math class is in the System namespace.
using System; 

class ShowMathMethods
{
  static void Main() 
  {
    double x = -2.1;

    Console.WriteLine("x: {0}", x);
    Console.WriteLine("Abs(x): {0}", Math.Abs(x));
    Console.WriteLine("Abs(10-27): {0}", Math.Abs(10 - 27));
    Console.WriteLine("Pow(x, 2.0): {0}", Math.Pow(x, 2.0));
    Console.WriteLine("Round(x): {0}", Math.Round(x));
    Console.WriteLine("Round(3.5): {0}", Math.Round(3.5));
    Console.WriteLine("Round(9.9): {0}", Math.Round(9.9));
  }
}