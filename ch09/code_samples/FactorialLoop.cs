using System;

// Demonstrate the iterative solution to the factorial function
class FactorialLoop
{
  public static int Factorial(int n)
  { // Precondition: n >= 0 and n is not too large (n < 13)
    int result = 1;
    for (int j = 2; j <= n; j++)
    {
      result = result * j;
    }
    return result;
  }

  static void Main()
  {
    Console.WriteLine(Factorial(0));  // 1
    Console.WriteLine(Factorial(1));  // 1
    Console.WriteLine(Factorial(2));  // 2
    Console.WriteLine(Factorial(3));  // 6
    Console.WriteLine(Factorial(4));  // 24
    Console.WriteLine(Factorial(12)); // 479001600
  }
}