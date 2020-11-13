using System;

// Find average by using SENTINEL of -1 to terminate loop
// that counts number of inputs and accumulates them.
class DemonstrateIndeterminateLoop
{
  public static readonly int SENTINEL = -1;
  
  static void Main()
  {
    Console.WriteLine("This program computes an average on");
    Console.WriteLine("numbers entered before {0}", SENTINEL);
    Console.WriteLine();

    int number;
    double accumulator = 0.0;
    int n = 0;

    Console.Write("Enter number or {0} to quit: ", SENTINEL);
    number = int.Parse(Console.ReadLine());
    while (number != SENTINEL)
    {
      // Process input
      accumulator += number;

      // Read the next string to be processed as a number or 
      // the sentinel value that terminates the loop
      Console.Write("Enter number or {0} to quit: ", 
                    SENTINEL);
      number = int.Parse(Console.ReadLine());

      n++;
    }

    if (n == 0)
      Console.WriteLine("Can't average zero numbers");
    else
      Console.WriteLine("Average {0:F1}", accumulator / n);
  }
}