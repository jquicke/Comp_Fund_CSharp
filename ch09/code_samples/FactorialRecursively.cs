using System;

// Demonstrate the iteratice solution to the factorial function
class FactorialRecursively
{
  public static int Factorial(int n)
  {
    // Precondition: n >= 0 and n is not too large
    if (n == 0) // Base case
      return 1;
    else        // Recursive case
      return n * Factorial(n - 1)  /* RP Fact */;
  }

  static void Main()
  {
    Console.WriteLine(Factorial(3) /* RP Main */);  // 6
  }
}