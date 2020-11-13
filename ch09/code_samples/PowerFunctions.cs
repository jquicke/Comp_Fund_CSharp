using System;

// A class with two methods that do the same thing differently
class PowerFunctions
{
  // Recursive solution to the Power function.
  public static int PowRecurse(int number, int power)
  {
    // Precondition: number and power are positive && number != 0
    if (power == 0)
      return 1;
    else           // Make this recursive call \\
      return number * PowRecurse(number, power - 1);
  }

  // Iterative solution to the Power function.
  public static int PowLoop(int number, int power)
  {
    // Precondition: number and power are positive && number != 0
    int result;
    if (power == 0)
      result = 1;
    else
    {
      result = number;
      for (int j = 2; j <= power; j++)
        result = result * number;
    }
    return result;
  }

  static void Main()
  {
    Console.WriteLine("PowLoop(number, power)");
    Console.WriteLine("4^0 is {0}", PowLoop(4, 0));
    Console.WriteLine("4^1 is {0}", PowLoop(4, 1));
    Console.WriteLine("4^2 is {0}", PowLoop(4, 2));
    Console.WriteLine("4^4 is {0}", PowLoop(4, 4));

    Console.WriteLine();  // blank line
    Console.WriteLine("PowRecurse(number, power)");
    Console.WriteLine("4^0 is {0}", PowRecurse(4, 0));
    Console.WriteLine("4^1 is {0}", PowRecurse(4, 1));
    Console.WriteLine("4^2 is {0}", PowRecurse(4, 2));
    Console.WriteLine("4^4 is {0}", PowRecurse(4, 4));
  }
}