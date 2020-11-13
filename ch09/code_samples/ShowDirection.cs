using System;

class ShowDirection
{
  public static void Forward(int n)
  {
    if (n > 1)
      Forward(n - 1);

    // Return Point: RP Forward
    Console.WriteLine(n);
  }

  static void Main()
  {
    int number = 3;
    Forward(number);

    // Return Point: RP Main
    Console.WriteLine("back in Main");
  }
}